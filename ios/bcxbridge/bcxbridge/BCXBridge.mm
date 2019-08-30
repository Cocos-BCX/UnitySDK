#import "BCXBridge.h"
#import "BCXBridgeListener.h"
#import <objc/runtime.h>
#import "CocosSDK.h"

BCXBridgeIOS::BCXBridgeListener* bcxBridgeListener = nullptr;
NSString* dic2str(NSDictionary *dic) {
    NSError *error = nil;
    NSData *jsonData = nil;
    NSMutableDictionary *dict = [NSMutableDictionary dictionary];
    [dic enumerateKeysAndObjectsUsingBlock:^(id  _Nonnull key, id  _Nonnull obj, BOOL * _Nonnull stop) {
        NSString *keyString = nil;
        NSString *valueString = nil;
        if ([key isKindOfClass:[NSString class]]) {
            keyString = key;
        }else{
            keyString = [NSString stringWithFormat:@"%@",key];
        }
        
        if ([obj isKindOfClass:[NSString class]]) {
            valueString = obj;
        }else{
            valueString = [NSString stringWithFormat:@"%@",obj];
        }
        
        [dict setObject:valueString forKey:keyString];
    }];
    jsonData = [NSJSONSerialization dataWithJSONObject:dict options:0 error:&error];
    if ([jsonData length] == 0 || error != nil) {
        return @"";
    }
    NSString *jsonString = [[NSString alloc] initWithData:jsonData encoding:NSUTF8StringEncoding];
    return jsonString;
}

void BCX_set_unity_callback(void* callback) {
    if (nullptr == bcxBridgeListener) {
        bcxBridgeListener = new BCXBridgeIOS::BCXBridgeListener();
    }
    bcxBridgeListener->setUnityCallback((BCXBridgeIOS::BCXBridgeListener::tBCXBridgeUnityCallback)callback);
}

void BCX_reflectionCall(const char* json) {
    NSString* jsonStr = [NSString stringWithUTF8String:json];
    NSData *jsonData = [jsonStr dataUsingEncoding:NSUTF8StringEncoding];
    NSDictionary *dic = [NSJSONSerialization JSONObjectWithData:jsonData
                                                        options:1
                                                          error:nil];
    if(nil == dic || 0 == [dic count]) {
        NSLog(@"parse json failed");
        return;
    }
    NSString* f = [dic valueForKey:@"f"];
    NSArray* p = [dic valueForKey:@"p"];
    
    CocosSDK* bcxSDK = [CocosSDK shareInstance];
    int i=0;
    unsigned int mc = 0;
    Method * mlist = class_copyMethodList(object_getClass(bcxSDK), &mc);
    for(i=0; i<mc; i++) {
        Method method = mlist[i];
        SEL mSel = method_getName(method);
        NSString* mName = [NSString stringWithUTF8String: sel_getName(mSel)];
        if ([mName hasPrefix:f]) {
            if([bcxSDK respondsToSelector:mSel]) {
                // NSUInteger argsCount = method_getNumberOfArguments(method);
                char returnType;
                method_getReturnType(method, &returnType, 1);

                NSInvocation *inv = [NSInvocation invocationWithMethodSignature:[bcxSDK methodSignatureForSelector:mSel]];
                [inv setSelector:mSel];
                [inv setTarget:bcxSDK];
                int idx = 0;
                if (nullptr != p) {
                    for (idx = 0; idx < [p count]; idx++) {
                        id param = p[idx];
                        if ([param isKindOfClass:[NSString class]]) {
                            [inv setArgument:&param atIndex:idx + 2];
                        } else if ([param isKindOfClass:[NSNumber class]]) {
                            [inv setArgument:&param atIndex:idx + 2];
                        } else {
                            NSLog(@"Unknown param type:%@", [param class]);
                        }
                    }
                }
                if ('v' == returnType) {
                    SuccessBlock sucBlock = nil;
                    Error errBlock = nil;
                    sucBlock = ^(id responseObject){
                        NSString* json = @"";
                        NSMutableDictionary *dict = [NSMutableDictionary dictionary];
                        if ([responseObject isKindOfClass:[NSDictionary class]]) {
                            json = dic2str(responseObject);
                        } else {
                            [dict setObject:[NSNumber numberWithInt:1] forKey: @"code"];
                            [dict setObject:responseObject forKey: @"data"];
                            json = dic2str(dict);
                        }
                        NSLog(@"success block:%@ => %@", f, json);
                        bcxBridgeListener->notifyUnity(f.UTF8String, json.UTF8String);
                        if (nil != sucBlock) Block_release(sucBlock);
                        if (nil != errBlock) Block_release(errBlock);
                    };
                    errBlock = ^(NSError *error){
                        NSMutableDictionary *dict = [NSMutableDictionary dictionary];
                        [dict setObject:[NSNumber numberWithInt:0] forKey: @"code"];
                        [dict setObject:error.description forKey: @"data"];
                        NSString* json = dic2str(dict);
                        NSLog(@"error block:%@ => %@", f, json);
                        bcxBridgeListener->notifyUnity(f.UTF8String, json.UTF8String);
                        if (nil != sucBlock) Block_release(sucBlock);
                        if (nil != errBlock) Block_release(errBlock);
                    };
                    Block_copy((__bridge void *)sucBlock);
                    Block_copy((__bridge void *)errBlock);
                    [inv setArgument:&sucBlock atIndex:idx + 2];
                    [inv setArgument:&errBlock atIndex:idx + 3];
                }

                [inv retainArguments];
                [inv invoke];
                break;
            }
        }
    }
    free(mlist);
}

void BCX_connect(const char* chainId,
                 const char* nodeUrlsString,
                 const char* faucetUrl,
                 const char* coreAsset,
                 bool isOpenLog) {
    [[CocosSDK shareInstance] Cocos_OpenLog: isOpenLog];
    [[CocosSDK shareInstance] Cocos_ConnectWithNodeUrl: [NSString stringWithUTF8String:nodeUrlsString]
                                             Fauceturl: [NSString stringWithUTF8String:faucetUrl]
                                               TimeOut: 5
                                             CoreAsset: [NSString stringWithUTF8String:coreAsset]
                                               ChainId: [NSString stringWithUTF8String:chainId]
                                       ConnectedStatus:^(WebsocketConnectStatus connectStatus) {
                                           if (nullptr == bcxBridgeListener) {
                                               return ;
                                           }
                                           NSMutableDictionary *dict = [NSMutableDictionary dictionary];
                                           if (WebsocketConnectStatusConnected == connectStatus) {
                                               [dict setObject:[NSNumber numberWithInt:1] forKey: @"code"];
                                           } else {
                                               [dict setObject:[NSNumber numberWithInt:0] forKey: @"code"];
                                           }
                                           NSLog(@"cb:connect");
                                           bcxBridgeListener->notifyUnity("connect", dic2str(dict).UTF8String);
                                       }];
}

