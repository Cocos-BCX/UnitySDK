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

	public void transfer_nh_asset(string json)
	{
		BCX.BCXWrapperAndroid.notify_bcx_event(System.Reflection.MethodBase.GetCurrentMethod().Name, json);
	}

	public void delete_nh_asset(string json)
	{
		BCX.BCXWrapperAndroid.notify_bcx_event(System.Reflection.MethodBase.GetCurrentMethod().Name, json);
	}

	public void cancel_nh_asset_order(string json)
	{
		BCX.BCXWrapperAndroid.notify_bcx_event(System.Reflection.MethodBase.GetCurrentMethod().Name, json);
	}

	public void buy_nh_asset(string json)
	{
		BCX.BCXWrapperAndroid.notify_bcx_event(System.Reflection.MethodBase.GetCurrentMethod().Name, json);
	}

	public void create_nh_asset_order(string json)
	{
		BCX.BCXWrapperAndroid.notify_bcx_event(System.Reflection.MethodBase.GetCurrentMethod().Name, json);
	}

	public void upgrade_to_lifetime_member(string json)
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

	public void get_estimation_gas(string json)
	{
		BCX.BCXWrapperAndroid.notify_bcx_event(System.Reflection.MethodBase.GetCurrentMethod().Name, json);
	}

	public void update_collateral_for_gas(string json)
	{
		BCX.BCXWrapperAndroid.notify_bcx_event(System.Reflection.MethodBase.GetCurrentMethod().Name, json);
	}

	public void get_vesting_balances(string json)
	{
		BCX.BCXWrapperAndroid.notify_bcx_event(System.Reflection.MethodBase.GetCurrentMethod().Name, json);
	}

	public void receive_vesting_balances(string json)
	{
		BCX.BCXWrapperAndroid.notify_bcx_event(System.Reflection.MethodBase.GetCurrentMethod().Name, json);
	}

	public void get_committee_members(string json)
	{
		BCX.BCXWrapperAndroid.notify_bcx_event(System.Reflection.MethodBase.GetCurrentMethod().Name, json);
	}

	public void get_witnesses_members(string json)
	{
		BCX.BCXWrapperAndroid.notify_bcx_event(System.Reflection.MethodBase.GetCurrentMethod().Name, json);
	}

	public void vote_members(string json)
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

