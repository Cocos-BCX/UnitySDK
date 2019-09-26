#if UNITY_IOS

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using UnityEngine;
using AOT;


namespace BCX
{

    public class BCXWrapperIOS : BCXWrapperBase
    {
        public static event BCXEventHandler BCXEvent;
        private static Dictionary<string, string> nameMap = new Dictionary<string, string>();

        public static void connect(string chainId, string nodeUrlString, string faucetUrl, string coreAsset, bool isOpenLog)
        {
#if !UNITY_EDITOR
            BCX_set_unity_callback(BCXBridgeCallback);
            BCX_connect(chainId, nodeUrlString, faucetUrl, coreAsset, isOpenLog);
#endif
        }

        public static void create_account(string strAccountName, string strPassword, string accountType, bool isAutoLogin)
        {
#if !UNITY_EDITOR
            BCX_create_account(strAccountName, strPassword, accountType, isAutoLogin);
#endif
        }

        public static void get_dao_account_objects()
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, "Cocos_QueryAllAccountSuccess");
        }

        public static void get_accounts(string accountId)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, "Cocos_GetAccount", accountId);
        }

        public static void get_full_accounts(string names_or_id, bool subscribe)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, "Cocos_GetFullAccount", names_or_id);
        }

        public static void lookup_nh_asset(List<string> nh_asset_ids_or_hash)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, "Cocos_LookupNHAsset", nh_asset_ids_or_hash);
        }

        public static void list_account_nh_asset(string account_id_or_name, List<string> world_view_name_or_ids, int page, int pageSize)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, "Cocos_ListAccountNHAsset", account_id_or_name, world_view_name_or_ids, pageSize, page);
        }

        public static void list_account_nh_asset_order(string account_id_or_name, int pageSize, int page)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, "Cocos_ListAccountNHAssetOrder", account_id_or_name, pageSize, page);
        }

        public static void list_nh_asset_order(string asset_id_or_symbol, string world_view_name_or_ids, string baseDescribe, int pageSize, int page)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, "Cocos_AllListNHAssetOrder", asset_id_or_symbol, world_view_name_or_ids, baseDescribe, pageSize, page);
        }

        public static void lookup_world_view(List<string> world_view_names)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, "Cocos_LookupWorldView", world_view_names);
        }

        public static void list_nh_asset_by_creator(string account_id, int page, int pageSize)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, "Cocos_ListNHAssetByCreator", account_id, pageSize, page);
        }

        public static void transfer_nh_asset_fee(string account_from, string account_to, string fee_asset_symbol, string nh_asset_id)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, "Cocos_TransferNHAssetFee", account_from, account_to, nh_asset_id, fee_asset_symbol);
        }

        public static void transfer_nh_asset(string password, string account_from, string account_to, string fee_asset_symbol, string nh_asset_id)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, "Cocos_TransferNHAsset", account_from, account_to, nh_asset_id, password, fee_asset_symbol);
        }

        public static void delete_nh_asset_fee(string fee_paying_account, string nhasset_id, string fee_symbol)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, "Cocos_DeleteNHAssetFeeAccount", fee_paying_account, fee_symbol, nhasset_id);
        }

        public static void delete_nh_asset(string fee_paying_account, string password, string nhasset_id, string fee_symbol)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, "Cocos_DeleteNHAssetAccount", fee_paying_account, password, fee_symbol, nhasset_id);
        }

        public static void cancel_nh_asset_order_fee(string fee_paying_account, string order_id, string fee_symbol)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, "Cocos_CancelNHAssetFeeAccount", fee_paying_account, fee_symbol, order_id);
        }

        public static void cancel_nh_asset_order(string fee_paying_account, string password, string order_id, string fee_symbol)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, "Cocos_CancelNHAssetAccount", fee_paying_account, password, fee_symbol, order_id);
        }

        public static void buy_nh_asset_fee(string fee_paying_account, string order_Id, string fee_paying_asset)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, "Cocos_BuyNHAssetFeeOrderID", order_Id, fee_paying_account, fee_paying_asset);
        }

        public static void buy_nh_asset(string password, string fee_paying_account, string order_Id, string fee_paying_asset)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, "Cocos_BuyNHAssetOrderID", order_Id, fee_paying_account, password, fee_paying_asset);
        }

        public static void create_nh_asset_order_fee(string otcaccount, string seller, string pending_order_nh_asset, string pending_order_fee, string pending_order_fee_symbol, string pending_order_memo, string pending_order_price, string pending_order_price_symbol, long pending_order_valid_time_second)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, "Cocos_SellNHAssetFeeSeller", seller, pending_order_nh_asset, pending_order_memo, pending_order_price, pending_order_fee, pending_order_fee_symbol, pending_order_price_symbol, pending_order_valid_time_second.ToString());
        }

        public static void create_nh_asset_order(string otcaccount, string seller, string password, string pending_order_nh_asset, string pending_order_fee, string pending_order_fee_symbol, string pending_order_memo, string pending_order_price, string pending_order_price_symbol, long pending_order_valid_time_second)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, "Cocos_SellNHAssetSeller", seller, password, pending_order_nh_asset, pending_order_memo, pending_order_price, pending_order_fee, pending_order_fee_symbol, pending_order_price_symbol, pending_order_valid_time_second.ToString());
        }

        public static void upgrade_to_lifetime_member_fee(string upgrade_account_id_or_symbol, string fee_paying_asset_id_or_symbol)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, "Cocos_UpgradeMemberFeeAccount", upgrade_account_id_or_symbol, fee_paying_asset_id_or_symbol);
        }

        public static void upgrade_to_lifetime_member(string upgrade_account_id_or_symbol, string upgrade_account_password, string fee_paying_asset_id_or_symbol)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, "Cocos_UpgradeMemberAccount", upgrade_account_id_or_symbol, upgrade_account_password, fee_paying_asset_id_or_symbol);
        }

        public static void get_contract(string contractNameOrId)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, "Cocos_GetContract", contractNameOrId);
        }

        public static void password_login(string strAccountName, string strPassword)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, "Cocos_LoginAccountWithName", strAccountName, strPassword);
        }

        public static void import_keystore(string keystore, string password, string accountType)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, "Cocos_RecoverWalletWithString", keystore, password);
        }

        public static void export_keystore(string accountName, string password)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, "Cocos_BackupWalletWithAccountName", accountName);
        }

        public static void import_wif_key(string wifKey, string password, string accountType)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, "Cocos_ImportWalletWithPrivate", wifKey, accountType, password);
        }

        public static void export_private_key(string accountName, string password)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, "Cocos_GetPrivateWithName", accountName, password);
        }

        public static void lookup_asset_symbols(string assetsSymbolOrId)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, "Cocos_GetAsset", assetsSymbolOrId);
        }

        public static void transfer_calculate_fee(string password, string from, string to, string strAmount, string strAssetSymbol, string strFeeSymbolOrId, string strMemo)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, "Cocos_GetTransferFeesFrom", from, to, password, strAssetSymbol, strAmount, strFeeSymbolOrId, strMemo);
        }

        public static void calculate_invoking_contract_fee(string strAccount, string feeAssetSymbol, string contractId, string functionName, string param)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, "Cocos_GetCallContractFee", contractId, str2list(param), functionName, strAccount, feeAssetSymbol);
        }

        public static void invoking_contract(string strAccount, string password, string feeAssetSymbol, string contractNameOrId, string functionName, string param)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, "Cocos_CallContract", contractNameOrId, str2list(param), functionName, strAccount, feeAssetSymbol, password);
        }

        public static void transfer(string password, string strFrom, string strTo, string strAmount, string strAssetSymbol, string strFeeSymbol, string strMemo)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, "Cocos_TransferFromAccount", strFrom, strTo, password, strAssetSymbol, strAmount, strFeeSymbol, strMemo);
        }

        public static void get_block(string nBlockNumber)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, "Cocos_GetBlockWithBlockNum", nBlockNumber);
        }

        public static void get_account_history(string accountName, int nLimit)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, "Cocos_GetAccountHistory", accountName, nLimit);
        }

        public static void get_account_balances(string accountId, string assetsId)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, "Cocos_GetAccountBalance", accountId, str2list(assetsId));
        }

        public static void get_block_header(double nBlockNumber)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, "Cocos_GetBlockHeaderWithBlockNum", nBlockNumber);
        }

        public static void get_dynamic_global_properties()
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, "Cocos_GetDynamicGlobalPropertiesWithSuccess");
        }

        public static void get_transaction_in_block_info(string tr_id)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, "Cocos_GetTransactionBlockWithHash", tr_id);
        }

        public static void get_transaction_by_id(string tr_id)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, "Cocos_GetTransactionById", tr_id);
        }

        public static void decrypt_memo_message(string accountName, string password, string mMemoJson)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, "Cocos_DecryptMemo", accountName, password, mMemoJson);
        }

        public static void get_version_info()
        {
#if !UNITY_EDITOR
            BCX_get_version_info();
#endif
        }

        public static void log_out(string accountName)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, "Cocos_DeleteWalletAccountName", accountName);
        }


        private static List<string> str2list(string str)
        {
            return str.Split(',').Select(p => p.Trim()).ToList();
        }

        private static void apiNameMaping(string apiName, string realName)
        {
            if (!nameMap.ContainsKey(realName))
            {
                nameMap.Add(realName, apiName);
            }
        }

        private static string getAPIName(string realName)
        {
            if (nameMap.ContainsKey(realName))
            {
                return nameMap[realName];
            }
            return realName;
        }

        private static JSONObject params2JSON(params object[] objs)
        {
            JSONObject objP = new JSONObject(JSONObject.Type.ARRAY);
            foreach (var item in objs)
            {
                string s = item as string;
                if (null != s)
                {
                    objP.Add(s);
                }
                else if (IsNumber(item))
                {
                    objP.Add(Convert.ToInt32(item));
                }
                else if (item is bool)
                {
                    objP.Add(Convert.ToInt32((bool)item));
                }
                else if (item is List<string>)
                {
                    JSONObject objL = new JSONObject(JSONObject.Type.ARRAY);
                    foreach(var o in (item as List<string>))
                    {
                        objL.Add(o);
                    }
                    objP.Add(objL);
                }
            }
            return objP;
        }

        private static void Invoke(string api, string f, params object[] arr)
        {
            apiNameMaping(api, f);
            JSONObject obj = new JSONObject(JSONObject.Type.OBJECT);
            obj.AddField("f", f);
            obj.AddField("p", params2JSON(arr));

#if !UNITY_EDITOR
            BCX_reflectionCall(obj.ToString());
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

        /*
         *  Native Related
         *
         */
        // delegate signature for callbacks from SDKBOX runtime.
        public delegate void BCXBridgeCallbackDelegate(string method, string error);

        [MonoPInvokeCallback(typeof(BCXBridgeCallbackDelegate))]
        private static void BCXBridgeCallback(string method, string json)
        {
            RunInUnityMainThread(() => {
                string evt = method;
                // Debug.Log("BCXBridgeCallback:" + evt);
                // Debug.Log("BCXBridgeCallback:" + json);
                switch (method)
                {
                    case "get_version_info":
                    {
                        JSONObject jObj = new JSONObject(json);
                        JSONObject codeObj = jObj.GetField("code");
                        JSONObject dataObj = jObj.GetField("data");
                        if (1 == codeObj.n) {
                            dataObj.str = BCXWrapperBase.VERSION + "-" + dataObj.str;
                        }
                        jObj.SetField("data", dataObj);
                        json = jObj.ToString();
                        break;
                    }
                    default: {
                        evt = getAPIName(evt);
                        // Debug.Log("BCXBridgeCallback not handled");
                        break;
                    }
                }
                BCXWrapperIOS.BCXEvent.Invoke(evt, json);
            });
        }


        [DllImport("__Internal")]
        public static extern void BCX_set_unity_callback(BCXBridgeCallbackDelegate callback);

        [DllImport("__Internal")]
        public static extern void BCX_reflectionCall(string json);

        [DllImport("__Internal")]
        public static extern void BCX_connect(string chainId, string nodeUrlString, string faucetUrl, string coreAsset, bool isOpenLog);

        [DllImport("__Internal")]
        public static extern void BCX_get_version_info();

        [DllImport("__Internal")]
        public static extern void BCX_create_account(string account, string password, string accountType, bool isAutoLogin);

    }
}

#endif

