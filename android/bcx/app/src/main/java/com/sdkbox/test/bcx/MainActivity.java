package com.sdkbox.test.bcx;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;

import com.cocos.bcx_sdk.unity.bridge.Bridge;

import java.util.Arrays;
import java.util.List;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        List<String> mListNode = Arrays.asList("ws://39.106.126.54:8049", "ws://39.106.126.54:8049");
        String faucetUrl = "http://47.93.62.96:8041";
        String chainId = "7d89b84f22af0b150780a2b121aa6c715b19261c8b7fe0fda3a564574ed7d3e9";
        String coreAsset = "COCOS";
        boolean isOpenLog = true;
        Bridge.connect(chainId, mListNode, faucetUrl, coreAsset, isOpenLog, this);

        // Bridge.reflectionCall("{\"p\":[\"hugo\",\"111111\"],\"f\":\"password_login\"}");
        Bridge.reflectionCall("{\"p\":[[\"string1\",\"string2\"]],\"f\":\"lookup_nh_asset\"}");
        // Bridge.reflectionCall("{\"f\":\"get_version_info\"}");
        // Bridge.reflectionCall("{\"f\":\"log_out\"}");
    }
}
