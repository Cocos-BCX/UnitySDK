using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BCX
{
public class BCXAndroidReceiver : MonoBehaviour {

#if UNITY_ANDROID

	public void connect(string json)
	{
		BCX.BCXWrapperAndroid.notify_bcx_event(System.Reflection.MethodBase.GetCurrentMethod().Name, json);
	}

	public void create_password_account(string json)
	{
		BCX.BCXWrapperAndroid.notify_bcx_event(System.Reflection.MethodBase.GetCurrentMethod().Name, json);
	}

	public void create_wallet_account(string json)
	{
		BCX.BCXWrapperAndroid.notify_bcx_event(System.Reflection.MethodBase.GetCurrentMethod().Name, json);
	}

	public void create_account(string json)
	{
		BCX.BCXWrapperAndroid.notify_bcx_event(System.Reflection.MethodBase.GetCurrentMethod().Name, json);
	}

	public void get_dao_account_objects(string json)
	{
		BCX.BCXWrapperAndroid.notify_bcx_event(System.Reflection.MethodBase.GetCurrentMethod().Name, json);
	}

	public void get_accounts(string json)
	{
		BCX.BCXWrapperAndroid.notify_bcx_event(System.Reflection.MethodBase.GetCurrentMethod().Name, json);
	}

	public void lookup_account_names(string json)
	{
		BCX.BCXWrapperAndroid.notify_bcx_event(System.Reflection.MethodBase.GetCurrentMethod().Name, json);
	}

	public void get_account_object(string json)
	{
		BCX.BCXWrapperAndroid.notify_bcx_event(System.Reflection.MethodBase.GetCurrentMethod().Name, json);
	}

	public void get_account_id_by_name(string json)
	{
		BCX.BCXWrapperAndroid.notify_bcx_event(System.Reflection.MethodBase.GetCurrentMethod().Name, json);
	}

	public void get_account_name_by_id(string json)
	{
		BCX.BCXWrapperAndroid.notify_bcx_event(System.Reflection.MethodBase.GetCurrentMethod().Name, json);
	}

	public void get_full_accounts(string json)
	{
		BCX.BCXWrapperAndroid.notify_bcx_event(System.Reflection.MethodBase.GetCurrentMethod().Name, json);
	}

	public void lookup_nh_asset(string json)
	{
		BCX.BCXWrapperAndroid.notify_bcx_event(System.Reflection.MethodBase.GetCurrentMethod().Name, json);
	}

	public void list_account_nh_asset(string json)
	{
		BCX.BCXWrapperAndroid.notify_bcx_event(System.Reflection.MethodBase.GetCurrentMethod().Name, json);
	}

	public void list_account_nh_asset_order(string json)
	{
		BCX.BCXWrapperAndroid.notify_bcx_event(System.Reflection.MethodBase.GetCurrentMethod().Name, json);
	}

	public void list_nh_asset_order(string json)
	{
		BCX.BCXWrapperAndroid.notify_bcx_event(System.Reflection.MethodBase.GetCurrentMethod().Name, json);
	}

	public void lookup_world_view(string json)
	{
		BCX.BCXWrapperAndroid.notify_bcx_event(System.Reflection.MethodBase.GetCurrentMethod().Name, json);
	}

	public void get_nh_creator(string json)
	{
		BCX.BCXWrapperAndroid.notify_bcx_event(System.Reflection.MethodBase.GetCurrentMethod().Name, json);
	}

	public void list_nh_asset_by_creator(string json)
	{
		BCX.BCXWrapperAndroid.notify_bcx_event(System.Reflection.MethodBase.GetCurrentMethod().Name, json);
	}

	public void transfer_nh_asset_fee(string json)
	{
		BCX.BCXWrapperAndroid.notify_bcx_event(System.Reflection.MethodBase.GetCurrentMethod().Name, json);
	}

	public void transfer_nh_asset(string json)
	{
		BCX.BCXWrapperAndroid.notify_bcx_event(System.Reflection.MethodBase.GetCurrentMethod().Name, json);
	}

	public void delete_nh_asset_fee(string json)
	{
		BCX.BCXWrapperAndroid.notify_bcx_event(System.Reflection.MethodBase.GetCurrentMethod().Name, json);
	}

	public void delete_nh_asset(string json)
	{
		BCX.BCXWrapperAndroid.notify_bcx_event(System.Reflection.MethodBase.GetCurrentMethod().Name, json);
	}

	public void cancel_nh_asset_order_fee(string json)
	{
		BCX.BCXWrapperAndroid.notify_bcx_event(System.Reflection.MethodBase.GetCurrentMethod().Name, json);
	}

	public void cancel_nh_asset_order(string json)
	{
		BCX.BCXWrapperAndroid.notify_bcx_event(System.Reflection.MethodBase.GetCurrentMethod().Name, json);
	}

	public void buy_nh_asset_fee(string json)
	{
		BCX.BCXWrapperAndroid.notify_bcx_event(System.Reflection.MethodBase.GetCurrentMethod().Name, json);
	}

	public void buy_nh_asset(string json)
	{
		BCX.BCXWrapperAndroid.notify_bcx_event(System.Reflection.MethodBase.GetCurrentMethod().Name, json);
	}

	public void create_nh_asset_order_fee(string json)
	{
		BCX.BCXWrapperAndroid.notify_bcx_event(System.Reflection.MethodBase.GetCurrentMethod().Name, json);
	}

	public void create_nh_asset_order(string json)
	{
		BCX.BCXWrapperAndroid.notify_bcx_event(System.Reflection.MethodBase.GetCurrentMethod().Name, json);
	}

	public void upgrade_to_lifetime_member_fee(string json)
	{
		BCX.BCXWrapperAndroid.notify_bcx_event(System.Reflection.MethodBase.GetCurrentMethod().Name, json);
	}

	public void upgrade_to_lifetime_member(string json)
	{
		BCX.BCXWrapperAndroid.notify_bcx_event(System.Reflection.MethodBase.GetCurrentMethod().Name, json);
	}

	public void create_child_account_fee(string json)
	{
		BCX.BCXWrapperAndroid.notify_bcx_event(System.Reflection.MethodBase.GetCurrentMethod().Name, json);
	}

	public void create_child_account(string json)
	{
		BCX.BCXWrapperAndroid.notify_bcx_event(System.Reflection.MethodBase.GetCurrentMethod().Name, json);
	}

	public void get_objects(string json)
	{
		BCX.BCXWrapperAndroid.notify_bcx_event(System.Reflection.MethodBase.GetCurrentMethod().Name, json);
	}

	public void get_contract(string json)
	{
		BCX.BCXWrapperAndroid.notify_bcx_event(System.Reflection.MethodBase.GetCurrentMethod().Name, json);
	}

	public void delete_account_by_name(string json)
	{
		BCX.BCXWrapperAndroid.notify_bcx_event(System.Reflection.MethodBase.GetCurrentMethod().Name, json);
	}

	public void delete_account_by_id(string json)
	{
		BCX.BCXWrapperAndroid.notify_bcx_event(System.Reflection.MethodBase.GetCurrentMethod().Name, json);
	}

	public void password_login(string json)
	{
		BCX.BCXWrapperAndroid.notify_bcx_event(System.Reflection.MethodBase.GetCurrentMethod().Name, json);
	}

	public void import_keystore(string json)
	{
		BCX.BCXWrapperAndroid.notify_bcx_event(System.Reflection.MethodBase.GetCurrentMethod().Name, json);
	}

	public void export_keystore(string json)
	{
		BCX.BCXWrapperAndroid.notify_bcx_event(System.Reflection.MethodBase.GetCurrentMethod().Name, json);
	}

	public void import_wif_key(string json)
	{
		BCX.BCXWrapperAndroid.notify_bcx_event(System.Reflection.MethodBase.GetCurrentMethod().Name, json);
	}

	public void export_private_key(string json)
	{
		BCX.BCXWrapperAndroid.notify_bcx_event(System.Reflection.MethodBase.GetCurrentMethod().Name, json);
	}

	public void lookup_asset_symbols(string json)
	{
		BCX.BCXWrapperAndroid.notify_bcx_event(System.Reflection.MethodBase.GetCurrentMethod().Name, json);
	}

	public void transfer_calculate_fee(string json)
	{
		BCX.BCXWrapperAndroid.notify_bcx_event(System.Reflection.MethodBase.GetCurrentMethod().Name, json);
	}

	public void calculate_invoking_contract_fee(string json)
	{
		BCX.BCXWrapperAndroid.notify_bcx_event(System.Reflection.MethodBase.GetCurrentMethod().Name, json);
	}

	private void get_invoking_contract_tx_id(string json)
	{
		BCX.BCXWrapperAndroid.notify_bcx_event(System.Reflection.MethodBase.GetCurrentMethod().Name, json);
	}

	public void invoking_contract(string json)
	{
		BCX.BCXWrapperAndroid.notify_bcx_event(System.Reflection.MethodBase.GetCurrentMethod().Name, json);
	}

	public void transfer(string json)
	{
		BCX.BCXWrapperAndroid.notify_bcx_event(System.Reflection.MethodBase.GetCurrentMethod().Name, json);
	}

	public void get_block(string json)
	{
		BCX.BCXWrapperAndroid.notify_bcx_event(System.Reflection.MethodBase.GetCurrentMethod().Name, json);
	}

	public void get_account_history(string json)
	{
		BCX.BCXWrapperAndroid.notify_bcx_event(System.Reflection.MethodBase.GetCurrentMethod().Name, json);
	}

	public void get_all_account_balances(string json)
	{
		BCX.BCXWrapperAndroid.notify_bcx_event(System.Reflection.MethodBase.GetCurrentMethod().Name, json);
	}

	public void get_account_balances(string json)
	{
		BCX.BCXWrapperAndroid.notify_bcx_event(System.Reflection.MethodBase.GetCurrentMethod().Name, json);
	}

	public void get_block_header(string json)
	{
		BCX.BCXWrapperAndroid.notify_bcx_event(System.Reflection.MethodBase.GetCurrentMethod().Name, json);
	}

	public void get_global_properties(string json)
	{
		BCX.BCXWrapperAndroid.notify_bcx_event(System.Reflection.MethodBase.GetCurrentMethod().Name, json);
	}

	public void get_dynamic_global_properties(string json)
	{
		BCX.BCXWrapperAndroid.notify_bcx_event(System.Reflection.MethodBase.GetCurrentMethod().Name, json);
	}

	public void get_transaction_in_block_info(string json)
	{
		BCX.BCXWrapperAndroid.notify_bcx_event(System.Reflection.MethodBase.GetCurrentMethod().Name, json);
	}

	public void get_transaction_by_id(string json)
	{
		BCX.BCXWrapperAndroid.notify_bcx_event(System.Reflection.MethodBase.GetCurrentMethod().Name, json);
	}

	public void decrypt_memo_message(string json)
	{
		BCX.BCXWrapperAndroid.notify_bcx_event(System.Reflection.MethodBase.GetCurrentMethod().Name, json);
	}

	public void get_payment_qrcode_json(string json)
	{
		BCX.BCXWrapperAndroid.notify_bcx_event(System.Reflection.MethodBase.GetCurrentMethod().Name, json);
	}

	public void get_version_info(string json)
	{
		JSONObject jObj = new JSONObject(json);
		JSONObject codeObj = jObj.GetField("code");
		JSONObject dataObj = jObj.GetField("data");
		if (1 == codeObj.n) {
			dataObj.str = BCXWrapperBase.VERSION + "-" + dataObj.str;
		}
		jObj.SetField("data", dataObj);
		BCX.BCXWrapperAndroid.notify_bcx_event(System.Reflection.MethodBase.GetCurrentMethod().Name, jObj.ToString());
	}

	public void log_out(string json)
	{
		BCX.BCXWrapperAndroid.notify_bcx_event(System.Reflection.MethodBase.GetCurrentMethod().Name, json);
	}

#endif

}

}








/*


public void connect(String chainId, List<String> nodeUrls, String faucetUrl, String coreAsset, boolean isOpenLog);
public void create_password_account( String strAccountName,  String strPassword,  boolean isAutoLogin,  IBcxCallBack callBack);
public void create_wallet_account(String strAccountName, String strPassword, boolean isAutoLogin, IBcxCallBack callBack);
public void create_account(String strAccountName, String strPassword, AccountType accountType, boolean isAutoLogin, IBcxCallBack callBack);
public void get_dao_account_objects(IBcxCallBack callBack);
public void get_accounts(String accountId, IBcxCallBack callBack);
public void lookup_account_names(String account_name, IBcxCallBack callBack);
public void get_account_object(String strAccountNameOrId, IBcxCallBack callBack);
public String get_account_id_by_name(String accountName);
public String get_account_name_by_id(String accountId);
public void get_full_accounts(String names_or_id, boolean subscribe, IBcxCallBack callBack);
public void lookup_nh_asset(List<String> nh_asset_ids_or_hash, IBcxCallBack callBack);
public void list_account_nh_asset(String account_id_or_name, List<String> world_view_name_or_ids, int page, int pageSize, IBcxCallBack callBack);
public void list_account_nh_asset_order(String account_id_or_name, int pageSize, int page, IBcxCallBack callBack);
public void list_nh_asset_order(String asset_id_or_symbol, String world_view_name_or_ids, String baseDescribe, int pageSize, int page, IBcxCallBack callBack);
public void list_nh_asset_order(int page, int pageSize, IBcxCallBack callBack);
public void lookup_world_view(List<String> world_view_names, IBcxCallBack callBack);
public void get_nh_creator(String account_id_or_name, IBcxCallBack callBack);
public void list_nh_asset_by_creator(String account_id, int page, int pageSize, IBcxCallBack callBack);
public void transfer_nh_asset_fee(String account_from, String account_to, String fee_asset_symbol, String nh_asset_id, IBcxCallBack callBack);
public void transfer_nh_asset(String password, String account_from, String account_to, String fee_asset_symbol, String nh_asset_id, IBcxCallBack callBack);
public void delete_nh_asset_fee(String fee_paying_account, String nhasset_id, String fee_symbol, IBcxCallBack callBack);
public void delete_nh_asset(String fee_paying_account, String password, String nhasset_id, String fee_symbol, IBcxCallBack callBack);
public void cancel_nh_asset_order_fee(String fee_paying_account, String order_id, String fee_symbol, IBcxCallBack callBack);
public void cancel_nh_asset_order(String fee_paying_account, String password, String order_id, String fee_symbol, IBcxCallBack callBack);
public void buy_nh_asset_fee(String fee_paying_account, String order_Id, IBcxCallBack callBack);
public void buy_nh_asset(String password, String fee_paying_account, String order_Id, IBcxCallBack callBack);
public void create_nh_asset_order_fee(String otcaccount, String seller, String pending_order_nh_asset, String pending_order_fee, String pending_order_fee_symbol, String pending_order_memo, String pending_order_price, String pending_order_price_symbol, long pending_order_valid_time_millis, IBcxCallBack callBack);
public void create_nh_asset_order(String otcaccount, String seller, String password, String pending_order_nh_asset, String pending_order_fee, String pending_order_fee_symbol, String pending_order_memo, String pending_order_price, String pending_order_price_symbol, long pending_order_valid_time_millis, IBcxCallBack callBack);
public void upgrade_to_lifetime_member_fee(String upgrade_account_id_or_symbol, String fee_paying_asset_id_or_symbol, IBcxCallBack callBack);
public void upgrade_to_lifetime_member(String upgrade_account_id_or_symbol, String upgrade_account_password, String fee_paying_asset_id_or_symbol, IBcxCallBack callBack);
public void create_child_account_fee(String child_account, String child_account_password, String registrar_account_id_or_symbol, String pay_asset_symbol_or_id, String accountType, IBcxCallBack callBack);
public void create_child_account(String child_account, String child_account_password, String registrar_account_id_or_symbol, String registrar_account_password, String pay_asset_symbol_or_id, String accountType, IBcxCallBack callBack);
public void get_objects(List<String> ids, IBcxCallBack callBack);
public void get_objects(String id, IBcxCallBack callBack);
public void get_contract(String contractNameOrId, IBcxCallBack callBack);
public void delete_account_by_name(String accountName, IBcxCallBack callBack);
public void delete_account_by_id(String accountId, IBcxCallBack callBack);
public List<String> get_dao_account_names();
public AccountEntity.AccountBean get_dao_account_by_name(String account_name);
public void password_login(String strAccountName, String strPassword, IBcxCallBack callBack);
public void import_keystore(String keystore, String password, String accountType, IBcxCallBack callBack);
public void export_keystore(String accountName, String password, IBcxCallBack callBack);
public void import_wif_key(String wifKey, String password, String accountType, IBcxCallBack callBack);
public void export_private_key(String accountName, String password, IBcxCallBack callBack);
public void lookup_asset_symbols(String assetsSymbolOrId, IBcxCallBack callBack);
public asset_object get_asset_object(String assetsSymbolOrId);
public void transfer_calculate_fee(String password, String from, String to, String strAmount, String strAssetSymbol, String strFeeSymbolOrId, String strMemo, IBcxCallBack callBack);
public void calculate_invoking_contract_fee(String strAccount, String feeAssetSymbol, String contractId, String functionName, String params, IBcxCallBack callBack);
private void get_invoking_contract_tx_id(String strAccount, String password, String feeAssetSymbol, String contractNameOrId, String functionName, String params, IBcxCallBack callBack);
public void invoking_contract(String strAccount, String password, String feeAssetSymbol, String contractNameOrId, String functionName, String params, IBcxCallBack callBack);
public void transfer(String password, String strFrom, String strTo, String strAmount, String strAssetSymbol, String strFeeSymbol, String strMemo, IBcxCallBack callBack);
public void get_block(String nBlockNumber, IBcxCallBack callBack);
public void get_account_history(String accountName, int nLimit, IBcxCallBack callBack);
public void get_all_account_balances(String accountId, IBcxCallBack callBack);
public void get_account_balances(String accountId, String assetsId, IBcxCallBack callBack);
public contract_object get_contract_object(String contractNameOrId);
public void get_block_header(double nBlockNumber, IBcxCallBack callBack);
public void get_global_properties(IBcxCallBack callBack);
public void get_dynamic_global_properties(IBcxCallBack callBack);
public void get_transaction_in_block_info(String tr_id, IBcxCallBack callBack);
public void get_transaction_by_id(String tr_id, IBcxCallBack callBack);
public void decrypt_memo_message(String accountName, String password, String mMemoJson, IBcxCallBack callBack);
public String get_payment_qrcode_json(String accountName, String amount, String assetSymbol);
public String get_version_info();
public void log_out();

*/









