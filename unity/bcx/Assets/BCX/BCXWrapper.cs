using System;
using UnityEngine;

namespace BCX
{
#if UNITY_ANDROID
    public class BCXWrapper : BCXWrapperAndroid
#elif UNITY_IOS
    public class BCXWrapper : BCXWrapperIOS
#else
    public class BCXWrapper : BCXWrapperDummy
#endif
    {
    }
}

