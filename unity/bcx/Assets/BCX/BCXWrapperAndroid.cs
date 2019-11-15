#if UNITY_ANDROID

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using UnityEngine;
using AOT;

namespace BCX
{

    public class BCXWrapperAndroid : BCXWrapperBase
    {
        public static event BCXEventHandler BCXEvent;
        private static String WRAPPER_CLASS = "com.cocos.bcx_sdk.unity.bridge.Bridge";

        public static void connect(string chainId, string nodeUrl, string faucetUrl, string coreAsset, bool isOpenLog)
        {
#if !UNITY_EDITOR
            using (AndroidJavaClass jc = new AndroidJavaClass(WRAPPER_CLASS))
            {
                jc.CallStatic("connect", chainId, String.Format("{0},{0}", nodeUrl), faucetUrl, coreAsset, isOpenLog);
            }
#endif
        }

        /*
         * accountType: "ACCOUNT", "WALLET"
         */
        public static void create_account(string strAccountName, string strPassword, string accountType, bool isAutoLogin)
        {
#if !UNITY_EDITOR
            using (AndroidJavaClass jc = new AndroidJavaClass(WRAPPER_CLASS))
            {
                jc.CallStatic("create_account", strAccountName, strPassword, accountType, isAutoLogin);
            }
#endif
        }

        public static void get_dao_account_objects()
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name);
        }

        public static void get_accounts(string accountId)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, accountId);
        }

        public static void get_full_accounts(string names_or_id, bool subscribe)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, names_or_id, subscribe);
        }

        public static void lookup_nh_asset(List<string> nh_asset_ids_or_hash)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, nh_asset_ids_or_hash);
        }

        public static void list_account_nh_asset(string account_id_or_name, List<string> world_view_name_or_ids, int page, int pageSize)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, account_id_or_name, world_view_name_or_ids, page, pageSize);
        }

        public static void list_account_nh_asset_order(string account_id_or_name, int pageSize, int page)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, account_id_or_name, pageSize, page);
        }

        public static void list_nh_asset_order(string asset_id_or_symbol, string world_view_name_or_ids, string baseDescribe, int pageSize, int page)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, asset_id_or_symbol, world_view_name_or_ids, baseDescribe, pageSize, page);
        }

        public static void lookup_world_view(List<string> world_view_names)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, world_view_names);
        }

        public static void list_nh_asset_by_creator(string account_id, string worldView, int page, int pageSize)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, account_id, worldView, page, pageSize);
        }

        public static void transfer_nh_asset(string password, string account_from, string account_to, string nh_asset_ids)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, password, account_from, account_to, str2list(nh_asset_ids));
        }

        public static void delete_nh_asset(string fee_paying_account, string password, string nhasset_ids)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, fee_paying_account, password, str2list(nhasset_ids));
        }

        public static void cancel_nh_asset_order(string fee_paying_account, string password, string order_id)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, fee_paying_account, password, order_id);
        }

        public static void buy_nh_asset(string fee_paying_account, string password, string order_Id)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, fee_paying_account, password, order_Id);
        }

        public static void create_nh_asset_order(string otcaccount, string seller, string password, string pending_order_nh_asset, string pending_order_fee, string pending_order_fee_symbol, string pending_order_memo, string pending_order_price, string pending_order_price_symbol, long pending_order_valid_time_second)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, otcaccount, seller, password, pending_order_nh_asset, pending_order_fee, pending_order_fee_symbol, pending_order_memo, pending_order_price, pending_order_price_symbol, pending_order_valid_time_second * 1000);
        }

        public static void upgrade_to_lifetime_member(string upgrade_account_id_or_symbol, string upgrade_account_password)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, upgrade_account_id_or_symbol, upgrade_account_password);
        }

        public static void get_contract(string contractNameOrId)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, contractNameOrId);
        }

        public static void password_login(string strAccountName, string strPassword)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, strAccountName, strPassword);
        }

        public static void import_keystore(string keystore, string password, string accountType)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, keystore, password, accountType);
        }

        public static void export_keystore(string accountName, string password)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, accountName, password);
        }

        public static void import_wif_key(string wifKey, string password, string accountType)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, wifKey, password, accountType);
        }

        public static void export_private_key(string accountName, string password)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, accountName, password);
        }

        public static void lookup_asset_symbols(string assetsSymbolOrId)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, assetsSymbolOrId);
        }

        public static void invoking_contract(string strAccount, string password, string contractNameOrId, string functionName, string param)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, strAccount, password, contractNameOrId, functionName, param);
        }

        public static void transfer(string password, string strFrom, string strTo, string strAmount, string strAssetSymbol, string strMemo)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, password, strFrom, strTo, strAmount, strAssetSymbol, strMemo);
        }

        public static void get_block(string nBlockNumber)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, nBlockNumber);
        }

        public static void get_account_history(string accountName, int nLimit)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, accountName, nLimit);
        }

        public static void get_account_balances(string accountId, string assetsId)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, accountId, assetsId);
        }

        public static void get_block_header(double nBlockNumber)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, nBlockNumber);
        }

        public static void get_dynamic_global_properties()
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name);
        }

        public static void get_transaction_in_block_info(string tr_id)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, tr_id);
        }

        public static void get_transaction_by_id(string tr_id)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, tr_id);
        }

        public static void decrypt_memo_message(string accountName, string password, string mMemoJson)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, accountName, password, mMemoJson);
        }

        public static void get_version_info()
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name);
        }

        public static void log_out(string accountName)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name);
        }

        public static void get_estimation_gas(string amount)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, amount);
        }

        public static void update_collateral_for_gas(string mortgagor, string password, string beneficiary, string amount)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, mortgagor, password, beneficiary, amount);
        }

        public static void get_vesting_balances(string accountNameOrId)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, accountNameOrId);
        }

        public static void receive_vesting_balances(string accountNameOrId, string password, string awardId)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, accountNameOrId, password, awardId);
        }

        public static void get_committee_members(string support_account)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, support_account);
        }

        public static void get_witnesses_members(string support_account)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, support_account);
        }

        /*
         * @Param type: 1 -> witnesses, 0 -> committee
         *
         */
        public static void vote_members(string vote_account, string password, int type, List<string> vote_ids, string vote_count)
        {
            string stype = "";
            if (0 == type)
            {
                stype = "committee";
            }
            else if (1 == type)
            {
                stype = "witnesses";
            }
            else
            {
                Debug.Log("Invalid param type");
            }
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, vote_account, password, stype, vote_ids, vote_count);
        }



        public static void notify_bcx_event(string evt, string json)
        {
            BCXWrapperAndroid.BCXEvent.Invoke(evt, json);
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

        private static void Invoke(string f, params object[] arr)
        {
            JSONObject obj = new JSONObject(JSONObject.Type.OBJECT);
            obj.AddField("f", f);
            obj.AddField("p", params2JSON(arr));

#if !UNITY_EDITOR
            using (AndroidJavaClass jc = new AndroidJavaClass(WRAPPER_CLASS))
            {
                jc.CallStatic("reflectionCall", obj.ToString());
            }
#endif
        }

    }
}

#endif

