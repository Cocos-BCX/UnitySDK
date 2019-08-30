#ifndef __BCX_H__
#define __BCX_H__

#ifdef __cplusplus
extern "C" {
#endif

void BCX_set_unity_callback(void* callback);
void BCX_reflectionCall(const char* json);
void BCX_connect(const char* chainId, const char* nodeUrlsString, const char* faucetUrl, const char* coreAsset, bool isOpenLog);

    
#ifdef __cplusplus
}
#endif

#endif // __BCX_H__
