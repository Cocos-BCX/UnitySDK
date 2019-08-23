#if UNITY_IOS

using System;
using System.Runtime.InteropServices;
using UnityEngine;
using AOT;

namespace BCX
{

    public class BCXWrapperIOS : BCXWrapperBase
    {
        public delegate void AdAvailableHandler(int adType, int uiOrientation, bool available);
        public delegate void AdEventHandler();
        public delegate void AdEventStringHandler(string error);
        public delegate void AdEventIntStringHandler(int adType, string error);

        public static event AdAvailableHandler AdAvailableEvent;
        public static event AdEventHandler SDKNotInitializedEvent;
        public static event AdEventHandler ShowAdVideoRewardGrantedEvent;
        public static event AdEventHandler ShowAdSucessEvent;
        public static event AdEventStringHandler ShowAdFailedEvent;
        public static event AdEventHandler CacheAdSuccessEvent;
        public static event AdEventStringHandler CacheAdFailedEvent;
        public static event AdEventHandler MinDelayBtwAdsNotReachedEvent;
        public static event AdEventHandler AdClosedTap;
        public static event AdEventHandler AdClickedTap;
        public static event AdEventHandler AdManagerInitSDKSuccess;
        public static event AdEventStringHandler AdManagerInitSDKFailed;
        public static event AdEventHandler AdManagerConsentSuccess;
        public static event AdEventStringHandler AdManagerConsentFailed;
        public static event AdEventHandler AdManagerAppDownloadSourceDetected;
        public static event AdEventHandler AdManagerAppSessionSourceDetected;

        public static void Init(String appKey, String appSecret)
        {
#if !UNITY_EDITOR
            AdDeals_initSDK(appKey, appSecret);
            AdDeals_set_unity_callback(AdDealsNativeCallback);
#endif
        }

        public static void EnableDebugMode()
        {
#if !UNITY_EDITOR
            AdDeals_enableDebugMode();
#endif
        }

        public static void SetConsent(int consent)
        {
#if !UNITY_EDITOR
            AdDeals_setConsent(consent);
#endif
        }

        public static void IsCachedAdAvailable(int adType, int uiOrientation)
        {
#if !UNITY_EDITOR
            bool b = AdDeals_isCacheAdAvailable(adType, AdDealsWrapperIOS.transToIOSOrientation(uiOrientation));
            AdDealsWrapperIOS.AdAvailableEvent.Invoke(adType, uiOrientation, b);
#endif
        }

        public static void CacheAd(int adKind, string placementID, int uiOrientation)
        {
#if !UNITY_EDITOR
            AdDeals_cacheAd(adKind, placementID, AdDealsWrapperIOS.transToIOSOrientation(uiOrientation));
#endif
        }

        public static void ShowAd(int adKind, string placementID, int uiOrientation)
        {
#if !UNITY_EDITOR
            AdDeals_showAd(adKind, placementID, AdDealsWrapperIOS.transToIOSOrientation(uiOrientation));
#endif
        }

        private static void RunInUnityMainThread(System.Action action)
        {
            UnityMainThreadDispatcher dispatcher = UnityMainThreadDispatcher.Instance();
            if (null == dispatcher)
            {
                Debug.Log("UnityMainThreadDispatcher is null, please add UnityMainThreadDispatcher.prefab to your scene");
                return;
            }
            dispatcher.Enqueue(action);
        }

        private static int transToIOSOrientation(int i)
        {
            //iOS have five orientation
            //0:Unknown 1:portrait 2:portraitUpsideDown 3:LandscapeRight 4:LandscapeLeft
            if (i == AdDealsWrapperIOS.UIOrientationUnset)
            {
                return 0;
            }
            else if (i == AdDealsWrapperIOS.UIOrientationPortrait)
            {
                return 1;
            }
            else
            {
                return 3;
            }
        }


        /*
         *  Native Related
         *
         */
        // delegate signature for callbacks from SDKBOX runtime.
        public delegate void AdDealsNativeCallbackDelegate(string method, string error);

        [MonoPInvokeCallback(typeof(AdDealsNativeCallbackDelegate))]
        public static void AdDealsNativeCallback(string method, string error)
        {
            RunInUnityMainThread(() => {
                switch (method)
                {
                    case "initSDKSuccess":
                    {
                        AdDealsWrapperIOS.AdManagerInitSDKSuccess.Invoke();
                        break;
                    }
                    case "initSDKFailWithError":
                    {
                        AdDealsWrapperIOS.AdManagerInitSDKFailed.Invoke(error);
                        break;
                    }
                    case "updateConsentSuccess":
                    {
                        AdDealsWrapperIOS.AdManagerConsentSuccess.Invoke();
                        break;
                    }
                    case "updateConsentFailWithError":
                    {
                        AdDealsWrapperIOS.AdManagerConsentFailed.Invoke(error);
                        break;
                    }
                    case "cacheInterstitialAdSuccess":
                    {
                        AdDealsWrapperIOS.CacheAdSuccessEvent.Invoke();
                        break;
                    }
                    case "cacheInterstitialAdFailed":
                    {
                        AdDealsWrapperIOS.CacheAdFailedEvent.Invoke(error);
                        break;
                    }
                    case "showInterstitialAdSuccess":
                    {
                        AdDealsWrapperIOS.ShowAdSucessEvent.Invoke();
                        break;
                    }
                    case "showInterstitialAdFailed":
                    {
                        AdDealsWrapperIOS.ShowAdFailedEvent.Invoke(error);
                        break;
                    }
                    case "minDelayBtwInterstitialAdsNotReached":
                    {
                        AdDealsWrapperIOS.MinDelayBtwAdsNotReachedEvent.Invoke();
                        break;
                    }
                    case "interstitialAdClosed":
                    {
                        AdDealsWrapperIOS.AdClosedTap.Invoke();
                        break;
                    }
                    case "interstitialAdClicked":
                    {
                        AdDealsWrapperIOS.AdClickedTap.Invoke();
                        break;
                    }
                    case "cacheVideoAdSuccess":
                    {
                        AdDealsWrapperIOS.CacheAdSuccessEvent.Invoke();
                        break;
                    }
                    case "cacheVideoAdFailed":
                    {
                        AdDealsWrapperIOS.CacheAdFailedEvent.Invoke(error);
                        break;
                    }
                    case "showVideoAdSuccess":
                    {
                        AdDealsWrapperIOS.ShowAdSucessEvent.Invoke();
                        break;
                    }
                    case "showVideoAdFailed":
                    {
                        AdDealsWrapperIOS.ShowAdFailedEvent.Invoke(error);
                        break;
                    }
                    case "minDelayBtwVideoAdsNotReached":
                    {
                        AdDealsWrapperIOS.MinDelayBtwAdsNotReachedEvent.Invoke();
                        break;
                    }
                    case "videoAdClosed":
                    {
                        AdDealsWrapperIOS.AdClosedTap.Invoke();
                        break;
                    }
                    case "videoAdClicked":
                    {
                        AdDealsWrapperIOS.AdClickedTap.Invoke();
                        break;
                    }
                    case "videoRewardGranted":
                    {
                        AdDealsWrapperIOS.ShowAdVideoRewardGrantedEvent.Invoke();
                        break;
                    }
                    default:
                    {
                        Debug.Log("Missed callback " + method + " => " + error);
                        break;
                    }
                }
            });
        }


        [DllImport("__Internal")]
        public static extern void AdDeals_set_unity_callback(AdDealsNativeCallbackDelegate callback);

        [DllImport("__Internal")]
        public static extern void AdDeals_initSDK(string appID, string appSecret);

        [DllImport("__Internal")]
        public static extern void AdDeals_enableDebugMode();

        [DllImport("__Internal")]
        public static extern void AdDeals_setConsent(int consent);

        [DllImport("__Internal")]
        public static extern bool AdDeals_isCacheAdAvailable(int adKind, int uiOrientation);

        [DllImport("__Internal")]
        public static extern void AdDeals_cacheAd(int adKind, string placementID, int uiOrientation);

        [DllImport("__Internal")]
        public static extern void AdDeals_showAd(int adKind, string placementID, int uiOrientation);

    }
}

#endif
