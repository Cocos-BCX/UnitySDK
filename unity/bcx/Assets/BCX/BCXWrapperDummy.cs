
using System;
using System.Collections.Generic;
using UnityEngine;

namespace BCX
{

    public class BCXWrapperDummy : BCXWrapperBase
    {
        public static event BCXEventHandler BCXEvent;
        private static String DUMMY_NOTE = "Dummy on current platform";

        public static void connect(string chainId, string nodeUrlString, string faucetUrl, string coreAsset, bool isOpenLog)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void create_account(string strAccountName, string strPassword, string accountType, bool isAutoLogin)
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

        public static void lookup_world_view(List<string> world_view_names)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void list_nh_asset_by_creator(string account_id, string worldView, int page, int pageSize)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void transfer_nh_asset(string password, string account_from, string account_to, string nh_asset_ids)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void delete_nh_asset(string fee_paying_account, string password, string nhasset_ids)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void cancel_nh_asset_order(string fee_paying_account, string password, string order_id)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void buy_nh_asset(string fee_paying_account, string password, string order_Id)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void create_nh_asset_order(string otcaccount, string seller, string password, string pending_order_nh_asset, string pending_order_fee, string pending_order_fee_symbol, string pending_order_memo, string pending_order_price, string pending_order_price_symbol, long pending_order_valid_time_second)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void upgrade_to_lifetime_member(string upgrade_account_id_or_symbol, string upgrade_account_password)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void get_contract(string contractNameOrId)
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

        public static void invoking_contract(string strAccount, string password, string contractNameOrId, string functionName, string param)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void transfer(string password, string strFrom, string strTo, string strAmount, string strAssetSymbol, string strMemo)
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

        public static void get_account_balances(string accountId, string assetsId)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void get_block_header(double nBlockNumber)
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

        public static void get_version_info()
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void log_out()
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void get_estimation_gas(string amount)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void update_collateral_for_gas(string mortgagor, string password, string beneficiary, string amount)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void get_vesting_balances(string accountNameOrId)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void receive_vesting_balances(string accountNameOrId, string password, string awardId)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void get_committee_members(string support_account)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void get_witnesses_members(string support_account)
        {
            Debug.Log(DUMMY_NOTE);
        }

        public static void vote_members(string vote_account, string password, int type, List<string> vote_ids, string vote_count)
        {
            Debug.Log(DUMMY_NOTE);
        }


    }
}

