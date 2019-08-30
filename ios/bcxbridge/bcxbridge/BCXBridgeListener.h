#ifndef __ADDEALS_LISTENER_H__
#define __ADDEALS_LISTENER_H__

#include <string>

namespace BCXBridgeIOS {
    class BCXBridgeListener {
    public:

        typedef void (*tBCXBridgeUnityCallback)(const char* /*method*/, const char* /*json*/);

        BCXBridgeListener();

        void setUnityCallback(tBCXBridgeUnityCallback callback);
        void notifyUnity(const char* method, const char* params);

    protected:
        tBCXBridgeUnityCallback _callback;
    };
}

#endif // __ADDEALS_LISTENER_H__


