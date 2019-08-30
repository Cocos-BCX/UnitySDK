#include "BCXBridgeListener.h"

namespace BCXBridgeIOS {
    
    BCXBridgeListener::BCXBridgeListener(): _callback(0) {
    }

    void BCXBridgeListener::setUnityCallback(tBCXBridgeUnityCallback callback) {
        _callback = callback;
    }

    void BCXBridgeListener::notifyUnity(const char* method, const char* params) {
        if (nullptr == _callback) {
            return;
        }

        _callback(method, params);
    }

}

