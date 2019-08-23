
using System;
using System.Collections.Generic;
using UnityEngine;

namespace BCX
{

    public class BCXWrapperDummy : BCXWrapperBase
    {
        private static String DUMMY_NOTE = "Dummy on current platform";

        public static void connect(string chainId, List<string> nodeUrls, string faucetUrl, string coreAsset, bool isOpenLog)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void create_password_account( string strAccountName,  string strPassword,  bool isAutoLogin)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void create_wallet_account(string strAccountName, string strPassword, bool isAutoLogin)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void create_account(string strAccountName, string strPassword, int accountType, bool isAutoLogin)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void get_dao_account_objects()
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void get_accounts(string accountId)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void lookup_account_names(string account_name)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void get_account_object(string strAccountNameOrId)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void get_account_id_by_name(string accountName)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void get_account_name_by_id(string accountId)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void get_full_accounts(string names_or_id, bool subscribe)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void lookup_nh_asset(List<string> nh_asset_ids_or_hash)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void list_account_nh_asset(string account_id_or_name, List<string> world_view_name_or_ids, int page, int pageSize)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void list_account_nh_asset_order(string account_id_or_name, int pageSize, int page)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void list_nh_asset_order(string asset_id_or_symbol, string world_view_name_or_ids, string baseDescribe, int pageSize, int page)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void list_nh_asset_order(int page, int pageSize)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void lookup_world_view(List<string> world_view_names)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void get_nh_creator(string account_id_or_name)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void list_nh_asset_by_creator(string account_id, int page, int pageSize)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void transfer_nh_asset_fee(string account_from, string account_to, string fee_asset_symbol, string nh_asset_id)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void transfer_nh_asset(string password, string account_from, string account_to, string fee_asset_symbol, string nh_asset_id)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void delete_nh_asset_fee(string fee_paying_account, string nhasset_id, string fee_symbol)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void delete_nh_asset(string fee_paying_account, string password, string nhasset_id, string fee_symbol)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void cancel_nh_asset_order_fee(string fee_paying_account, string order_id, string fee_symbol)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void cancel_nh_asset_order(string fee_paying_account, string password, string order_id, string fee_symbol)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void buy_nh_asset_fee(string fee_paying_account, string order_Id)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void buy_nh_asset(string password, string fee_paying_account, string order_Id)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void create_nh_asset_order_fee(string otcaccount, string seller, string pending_order_nh_asset, string pending_order_fee, string pending_order_fee_symbol, string pending_order_memo, string pending_order_price, string pending_order_price_symbol, long pending_order_valid_time_millis)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void create_nh_asset_order(string otcaccount, string seller, string password, string pending_order_nh_asset, string pending_order_fee, string pending_order_fee_symbol, string pending_order_memo, string pending_order_price, string pending_order_price_symbol, long pending_order_valid_time_millis)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void upgrade_to_lifetime_member_fee(string upgrade_account_id_or_symbol, string fee_paying_asset_id_or_symbol)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void upgrade_to_lifetime_member(string upgrade_account_id_or_symbol, string upgrade_account_password, string fee_paying_asset_id_or_symbol)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void create_child_account_fee(string child_account, string child_account_password, string registrar_account_id_or_symbol, string pay_asset_symbol_or_id, string accountType)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void create_child_account(string child_account, string child_account_password, string registrar_account_id_or_symbol, string registrar_account_password, string pay_asset_symbol_or_id, string accountType)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void get_objects(List<string> ids)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void get_objects(string id)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void get_contract(string contractNameOrId)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void delete_account_by_name(string accountName)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void delete_account_by_id(string accountId)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void password_login(string strAccountName, string strPassword)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void import_keystore(string keystore, string password, string accountType)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void export_keystore(string accountName, string password)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void import_wif_key(string wifKey, string password, string accountType)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void export_private_key(string accountName, string password)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void lookup_asset_symbols(string assetsSymbolOrId)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void transfer_calculate_fee(string password, string from, string to, string strAmount, string strAssetSymbol, string strFeeSymbolOrId, string strMemo)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void calculate_invoking_contract_fee(string strAccount, string feeAssetSymbol, string contractId, string functionName, string param)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void invoking_contract(string strAccount, string password, string feeAssetSymbol, string contractNameOrId, string functionName, string param)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void transfer(string password, string strFrom, string strTo, string strAmount, string strAssetSymbol, string strFeeSymbol, string strMemo)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void get_block(string nBlockNumber)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void get_account_history(string accountName, int nLimit)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void get_all_account_balances(string accountId)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void get_account_balances(string accountId, string assetsId)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void get_block_header(double nBlockNumber)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void get_global_properties()
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void get_dynamic_global_properties()
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void get_transaction_in_block_info(string tr_id)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void get_transaction_by_id(string tr_id)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void decrypt_memo_message(string accountName, string password, string mMemoJson)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void get_payment_qrcode_json(string accountName, string amount, string assetSymbol)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void get_version_info()
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void log_out()
        {
            Debug.Log(DUMMY_NOTE);
        }


    }
}

