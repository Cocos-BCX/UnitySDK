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

        public static void connect(string chainId, List<string> nodeUrls, string faucetUrl, string coreAsset, bool isOpenLog)
        {
#if !UNITY_EDITOR
            using (AndroidJavaClass jc = new AndroidJavaClass(WRAPPER_CLASS))
            {
                jc.CallStatic("connect", chainId, string.Join(",", nodeUrls.ToArray()), faucetUrl, coreAsset, isOpenLog);
            }
#endif
        }

        public static void create_account(string strAccountName, string strPassword, int accountType, bool isAutoLogin)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, strAccountName, strPassword, accountType, isAutoLogin);
        }

        public static void get_dao_account_objects()
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name);
        }

        public static void get_accounts(string accountId)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, accountId);
        }

        public static void lookup_account_names(string account_name)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, account_name);
        }

        public static void get_account_object(string strAccountNameOrId)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, strAccountNameOrId);
        }

        public static void get_account_id_by_name(string accountName)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, accountName);
        }

        public static void get_account_name_by_id(string accountId)
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

        public static void list_nh_asset_order(int page, int pageSize)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, page, pageSize);
        }

        public static void lookup_world_view(List<string> world_view_names)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, world_view_names);
        }

        public static void get_nh_creator(string account_id_or_name)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, account_id_or_name);
        }

        public static void list_nh_asset_by_creator(string account_id, int page, int pageSize)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, account_id, page, pageSize);
        }

        public static void transfer_nh_asset_fee(string account_from, string account_to, string fee_asset_symbol, string nh_asset_id)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, account_from, account_to, fee_asset_symbol, nh_asset_id);
        }

        public static void transfer_nh_asset(string password, string account_from, string account_to, string fee_asset_symbol, string nh_asset_id)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, password, account_from, account_to, fee_asset_symbol, nh_asset_id);
        }

        public static void delete_nh_asset_fee(string fee_paying_account, string nhasset_id, string fee_symbol)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, fee_paying_account, nhasset_id, fee_symbol);
        }

        public static void delete_nh_asset(string fee_paying_account, string password, string nhasset_id, string fee_symbol)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, fee_paying_account, password, nhasset_id, fee_symbol);
        }

        public static void cancel_nh_asset_order_fee(string fee_paying_account, string order_id, string fee_symbol)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, fee_paying_account, order_id, fee_symbol);
        }

        public static void cancel_nh_asset_order(string fee_paying_account, string password, string order_id, string fee_symbol)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, fee_paying_account, password, order_id, fee_symbol);
        }

        public static void buy_nh_asset_fee(string fee_paying_account, string order_Id, string fee_paying_asset)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, fee_paying_account, order_Id);
        }

        public static void buy_nh_asset(string password, string fee_paying_account, string order_Id, string fee_paying_asset)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, password, fee_paying_account, order_Id);
        }

        public static void create_nh_asset_order_fee(string otcaccount, string seller, string pending_order_nh_asset, string pending_order_fee, string pending_order_fee_symbol, string pending_order_memo, string pending_order_price, string pending_order_price_symbol, long pending_order_valid_time_millis)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, otcaccount, seller, pending_order_nh_asset, pending_order_fee, pending_order_fee_symbol, pending_order_memo, pending_order_price, pending_order_price_symbol, pending_order_valid_time_millis);
        }

        public static void create_nh_asset_order(string otcaccount, string seller, string password, string pending_order_nh_asset, string pending_order_fee, string pending_order_fee_symbol, string pending_order_memo, string pending_order_price, string pending_order_price_symbol, long pending_order_valid_time_millis)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, otcaccount, seller, password, pending_order_nh_asset, pending_order_fee, pending_order_fee_symbol, pending_order_memo, pending_order_price, pending_order_price_symbol, pending_order_valid_time_millis);
        }

        public static void upgrade_to_lifetime_member_fee(string upgrade_account_id_or_symbol, string fee_paying_asset_id_or_symbol)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, upgrade_account_id_or_symbol, fee_paying_asset_id_or_symbol);
        }

        public static void upgrade_to_lifetime_member(string upgrade_account_id_or_symbol, string upgrade_account_password, string fee_paying_asset_id_or_symbol)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, upgrade_account_id_or_symbol, upgrade_account_password, fee_paying_asset_id_or_symbol);
        }

        public static void create_child_account_fee(string child_account, string child_account_password, string registrar_account_id_or_symbol, string pay_asset_symbol_or_id, string accountType)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, child_account, child_account_password, registrar_account_id_or_symbol, pay_asset_symbol_or_id, accountType);
        }

        public static void create_child_account(string child_account, string child_account_password, string registrar_account_id_or_symbol, string registrar_account_password, string pay_asset_symbol_or_id, string accountType)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, child_account, child_account_password, registrar_account_id_or_symbol, registrar_account_password, pay_asset_symbol_or_id, accountType);
        }

        public static void get_objects(List<string> ids)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, ids);
        }

        public static void get_objects(string id)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, id);
        }

        public static void get_contract(string contractNameOrId)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, contractNameOrId);
        }

        public static void delete_account_by_name(string accountName)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, accountName);
        }

        public static void delete_account_by_id(string accountId)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, accountId);
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

        public static void transfer_calculate_fee(string password, string from, string to, string strAmount, string strAssetSymbol, string strFeeSymbolOrId, string strMemo)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, password, from, to, strAmount, strAssetSymbol, strFeeSymbolOrId, strMemo);
        }

        public static void calculate_invoking_contract_fee(string strAccount, string feeAssetSymbol, string contractId, string functionName, string param)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, strAccount, feeAssetSymbol, contractId, functionName, param);
        }

        public static void invoking_contract(string strAccount, string password, string feeAssetSymbol, string contractNameOrId, string functionName, string param)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, strAccount, password, feeAssetSymbol, contractNameOrId, functionName, param);
        }

        public static void transfer(string password, string strFrom, string strTo, string strAmount, string strAssetSymbol, string strFeeSymbol, string strMemo)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, password, strFrom, strTo, strAmount, strAssetSymbol, strFeeSymbol, strMemo);
        }

        public static void get_block(string nBlockNumber)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, nBlockNumber);
        }

        public static void get_account_history(string accountName, int nLimit)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, accountName, nLimit);
        }

        public static void get_all_account_balances(string accountId)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, accountId);
        }

        public static void get_account_balances(string accountId, string assetsId)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, accountId, assetsId);
        }

        public static void get_block_header(double nBlockNumber)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, nBlockNumber);
        }

        public static void get_global_properties()
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name);
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

        public static void get_payment_qrcode_json(string accountName, string amount, string assetSymbol)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name, accountName, amount, assetSymbol);
        }

        public static void get_version_info()
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name);
        }

        public static void log_out(string accountName)
        {
            Invoke(System.Reflection.MethodBase.GetCurrentMethod().Name);
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
