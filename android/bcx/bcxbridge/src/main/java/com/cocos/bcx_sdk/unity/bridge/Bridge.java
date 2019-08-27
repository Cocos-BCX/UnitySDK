package com.cocos.bcx_sdk.unity.bridge;

import android.app.Activity;
import android.app.Application;
import android.content.Context;
import android.util.Log;

import com.cocos.bcx_sdk.bcx_api.CocosBcxApiWrapper;
import com.cocos.bcx_sdk.bcx_callback.IBcxCallBack;
import com.unity3d.player.UnityPlayer;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import java.lang.reflect.Method;
import java.lang.reflect.Type;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class Bridge {

    private static final String TAG = "BCXBridge";
    private static final String GAME_OBJECT = "BCX";

    private static String combineSuccessResult(String s) {
        return String.format("{\"code\":1,\"data\":%s}", s);
    }

    private static String combineErrorResult(String s) {
        return String.format("{\"code\":0,\"message\":%s}", s);
    }

    public static void reflectionCall(String json) {
        JSONObject obj = null;
        try {
            obj = new JSONObject(json);
        } catch (JSONException e) {
            Log.e(TAG, "parse json failed:" + e.toString());
            return;
        }
        final String f = obj.optString("f", "");
        JSONArray arr = obj.optJSONArray("p");

        if (null == f || 0 == f.length()) {
            Log.e(TAG, "f is null");
            return;
        }

        CocosBcxApiWrapper api = CocosBcxApiWrapper.getBcxInstance();

        Method m = null;
        for(Method method : api.getClass().getMethods()) {
            if (f.equalsIgnoreCase(method.getName())) {
                m = method;
                break;
            }
        }
        if (null == m) {
            Log.e(TAG, "not find method:" + f);
            return;
        }

        Class<?>[] paramTypes = m.getParameterTypes();
        //Type[] paramTypes1 = m.getGenericParameterTypes();
        Class<?> returnType = m.getReturnType();
        List<Object> params = new ArrayList<Object>();

        if (String.class != returnType && void.class != returnType) {
            Log.e(TAG,"unknown return type:" + returnType.toString());
            return;
        }

        if (null != arr) {
            if (arr.length() > paramTypes.length) {
                Log.e(TAG, "params is not match:" + f);
                return;
            }
            for (int i = 0; i < paramTypes.length; i++) {
                Class<?> c = paramTypes[i];
                if (String.class == c) {
                    params.add(arr.optString(i, ""));
                } else if (boolean.class == c) {
                    params.add(arr.optBoolean(i, false));
                } else if (int.class == c) {
                    params.add(arr.optInt(i, 0));
                } else if (List.class == c) {
                    JSONArray a = arr.optJSONArray(i);
                    List<String> l = new ArrayList<String>();
                    for(int idx = 0; idx < a.length(); idx++) {
                        l.add(a.optString(idx, ""));
                    }
                    params.add(l);
                } else if (IBcxCallBack.class == c) {
                    params.add(new IBcxCallBack() {
                        @Override
                        public void onReceiveValue(String value) {
                            UnityPlayer.UnitySendMessage(GAME_OBJECT, f, value);
                        }
                    });
                } else {
                    Log.e(TAG,"known params type:" + c.toString());
                }
            }
        }

        try {
            Object rObj = null;
            if (0 == params.size()) {
                rObj = m.invoke(api);
            } else {
                rObj = m.invoke(api, params.toArray());
            }
            if (null != rObj) {
                Class<?> rCls = rObj.getClass();
                if (rCls == void.class) {
                } else if (rCls == String.class) {
                    UnityPlayer.UnitySendMessage(GAME_OBJECT, f, combineSuccessResult((String) rObj));
                } else {
                    Log.e(TAG, "unknown return type:" + rCls.toString());
                }
            }
        } catch (Exception e) {
            Log.e(TAG, "call failed:" + f + ":" + e.toString());
        }

    }

//    public static void connect(String chainId, List<String> nodeUrls, String faucetUrl, String coreAsset, boolean isOpenLog, Activity activity) {
//        Activity act = null != activity ? activity : UnityPlayer.currentActivity;
    public static void connect(String chainId, String nodeUrlsString, String faucetUrl, String coreAsset, boolean isOpenLog) {
        Activity act = UnityPlayer.currentActivity;
        if (null == act) {
            Log.e(TAG, "UnityPlayer.currentActivity is null");
            return;
        }
        Application app = act.getApplication();
        if (null == app) {
            Log.e(TAG, "can't get current application");
            return;
        }
        Context ctx = app;
        List<String> nodeUrls = new ArrayList<String>(Arrays.asList(nodeUrlsString.split(",")));

        CocosBcxApiWrapper.getBcxInstance().init(ctx);
        CocosBcxApiWrapper.getBcxInstance().connect(ctx, chainId, nodeUrls, faucetUrl, coreAsset, isOpenLog,
                new IBcxCallBack() {
                    @Override
                    public void onReceiveValue(String value) {
                        UnityPlayer.UnitySendMessage(GAME_OBJECT, "connect", value);
                    }
                });
    }

}
