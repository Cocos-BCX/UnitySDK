using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour {

	public UnityEngine.UI.Text accountLable;
    public UnityEngine.UI.Text logText;

	private bool isLoginIn;
	private string userAccount;
	private string version;
    private string logBuffer = "Log:";
	private const int MAX_LOG_LINE = 5;

	// Use this for initialization
	void Start () {
		isLoginIn = false;
		userAccount = "(Not Login)";
		BCX.BCXWrapper.BCXEvent += BCXCallback;

		string nodeUrl = "ws://39.106.126.54:8049";
        string faucetUrl = "http://47.93.62.96:8041";
        string chainId = "7d89b84f22af0b150780a2b121aa6c715b19261c8b7fe0fda3a564574ed7d3e9";
        string coreAsset = "COCOS";
        bool isOpenLog = true;
        BCX.BCXWrapper.connect(chainId, nodeUrl, faucetUrl, coreAsset, isOpenLog);
		BCX.BCXWrapper.get_version_info();
	}

	// Update is called once per frame
	void Update () {
		
	}

	public void onFakeTest() {
#if UNITY_ANDROID
		BCX.BCXAndroidReceiver recv = GameObject.Find("BCX").GetComponent<BCX.BCXAndroidReceiver>() as BCX.BCXAndroidReceiver;
		recv.password_login("{\"code\":1,\"data\":{\"active\":{\"account_auths\":{},\"address_auths\":[],\"key_auths\":{\"COCOS5DxDPk56rAMrABeY482UySTAAABGn4EGUyzZDCyQP9VqsRyG6X\":1},\"weight_threshold\":1},\"id\":\"1.2.72961\",\"lifetime_referrer\":\"1.2.15\",\"lifetime_referrer_fee_percentage\":3000,\"membership_expiration_date\":\"1970-01-01T00:00:00\",\"name\":\"hugoo\",\"network_fee_percentage\":2000,\"options\":{\"extensions\":[],\"memo_key\":\"COCOS5DxDPk56rAMrABeY482UySTAAABGn4EGUyzZDCyQP9VqsRyG6X\",\"num_committee\":0,\"num_witness\":0,\"votes\":[],\"voting_account\":\"1.2.2\"},\"owner\":{\"account_auths\":{},\"address_auths\":[],\"key_auths\":{\"COCOS8LG2K2Pw9b44bYYj5DBuqsNKNWC9URDSwodMmHpoACcQHqQW8X\":1},\"weight_threshold\":1},\"referrer\":\"1.2.15\",\"referrer_rewards_percentage\":5000,\"registrar\":\"1.2.15\",\"statistics\":\"2.6.72961\"},\"message\":\"success\"}");
#endif
	}

	public void onLogin() {
		InputField acc =  GameObject.Find("/Canvas/Scroll View/Viewport/Content/AccountLoginArea/IFAccount").GetComponent<InputField>() as InputField;
		InputField pw =  (InputField)GameObject.Find("/Canvas/Scroll View/Viewport/Content/AccountLoginArea/IFPassword").GetComponent<InputField>() as InputField;
		if (null == acc || null == pw) {
            log("can't find input field");
			return;
		}
        log("test password_login");
		userAccount = acc.text;
		BCX.BCXWrapper.password_login(acc.text, pw.text);
	}

    public void onCreateAccount() {
		InputField acc =  GameObject.Find("/Canvas/Scroll View/Viewport/Content/AccountCreateArea/IFAccount").GetComponent<InputField>() as InputField;
		InputField pw =  (InputField)GameObject.Find("/Canvas/Scroll View/Viewport/Content/AccountCreateArea/IFPassword").GetComponent<InputField>() as InputField;
		if (null == acc || null == pw) {
            log("can't find input field");
			return;
		}
        log("test create_account");
		BCX.BCXWrapper.create_account(acc.text, pw.text, "ACCOUNT", false);
	}

    public void onExportPrivateKey() {
		InputField acc =  GameObject.Find("/Canvas/Scroll View/Viewport/Content/AccountExportPrivateKeyArea/IFAccount").GetComponent<InputField>() as InputField;
		InputField pw =  (InputField)GameObject.Find("/Canvas/Scroll View/Viewport/Content/AccountExportPrivateKeyArea/IFPassword").GetComponent<InputField>() as InputField;
		if (null == acc || null == pw) {
            log("can't find input field");
			return;
		}
        log("test export_private_key");
		BCX.BCXWrapper.export_private_key(acc.text, pw.text);
	}

	public void onAccountGetUpgradeFee() {
		InputField acc =  findInputField("/Canvas/Scroll View/Viewport/Content/AccountUpgradeArea/IFAccount");
		InputField pw =  findInputField("/Canvas/Scroll View/Viewport/Content/AccountUpgradeArea/IFPassword");
        InputField feeSymbol =  findInputField("/Canvas/Scroll View/Viewport/Content/AccountUpgradeArea/IFFeeSymbol");
		if (null == acc || null == pw || null == feeSymbol) {
            log("can't find input field");
			return;
		}
        log("test onAccountGetUpgradeFee");
		BCX.BCXWrapper.upgrade_to_lifetime_member_fee(acc.text, feeSymbol.text);
	}

	public void onAccountUpgrade() {
		InputField acc =  findInputField("/Canvas/Scroll View/Viewport/Content/AccountUpgradeArea/IFAccount");
		InputField pw =  findInputField("/Canvas/Scroll View/Viewport/Content/AccountUpgradeArea/IFPassword");
        InputField feeSymbol =  findInputField("/Canvas/Scroll View/Viewport/Content/AccountUpgradeArea/IFFeeSymbol");
		if (null == acc || null == pw || null == feeSymbol) {
            log("can't find input field");
			return;
		}
        log("test onAccountUpgrade");
		BCX.BCXWrapper.upgrade_to_lifetime_member(acc.text, pw.text, feeSymbol.text);
	}

    public void onTransferFee() {
		InputField accfrom =  findInputField("/Canvas/Scroll View/Viewport/Content/TransferArea/IFAccount");
		InputField pw =  findInputField("/Canvas/Scroll View/Viewport/Content/TransferArea/IFPassword");
        InputField accto =  findInputField("/Canvas/Scroll View/Viewport/Content/TransferArea/IFAccountTo");
        InputField amount =  findInputField("/Canvas/Scroll View/Viewport/Content/TransferArea/IFAmount");
        InputField assetType =  findInputField("/Canvas/Scroll View/Viewport/Content/TransferArea/IFTransferAssetType");
        InputField feeAssetType =  findInputField("/Canvas/Scroll View/Viewport/Content/TransferArea/IFFeeAssetType");
        InputField memo =  findInputField("/Canvas/Scroll View/Viewport/Content/TransferArea/IFTransferMemo");
		if (null == accfrom || null == pw || null == accto || null == amount || null == assetType || null == feeAssetType || null == memo) {
            log("can't find input field");
			return;
		}
        log("test onTransferFee");
		BCX.BCXWrapper.transfer_calculate_fee(pw.text, accfrom.text, accto.text, amount.text, assetType.text, feeAssetType.text, memo.text);
	}

    public void onTransfer() {
		InputField accfrom =  findInputField("/Canvas/Scroll View/Viewport/Content/TransferArea/IFAccount");
		InputField pw =  findInputField("/Canvas/Scroll View/Viewport/Content/TransferArea/IFPassword");
        InputField accto =  findInputField("/Canvas/Scroll View/Viewport/Content/TransferArea/IFAccountTo");
        InputField amount =  findInputField("/Canvas/Scroll View/Viewport/Content/TransferArea/IFAmount");
        InputField assetType =  findInputField("/Canvas/Scroll View/Viewport/Content/TransferArea/IFTransferAssetType");
        InputField feeAssetType =  findInputField("/Canvas/Scroll View/Viewport/Content/TransferArea/IFFeeAssetType");
        InputField memo =  findInputField("/Canvas/Scroll View/Viewport/Content/TransferArea/IFTransferMemo");
		if (null == accfrom || null == pw || null == accto || null == amount || null == assetType || null == feeAssetType || null == memo) {
            log("can't find input field");
			return;
		}
        log("test onTransfer");
		BCX.BCXWrapper.transfer(pw.text, accfrom.text, accto.text, amount.text, assetType.text, feeAssetType.text, memo.text);
	}

	public void onTransactionGetInfo() {
		InputField trid =  findInputField("/Canvas/Scroll View/Viewport/Content/QueryTransactionArea/IFTransaction");
		if (null == trid) {
            log("can't find input field");
			return;
		}
        log("test onTransactionGetInfo");
		BCX.BCXWrapper.get_transaction_by_id(trid.text);
	}

	public void onTransactionGetBlockInfo() {
		InputField trid =  findInputField("/Canvas/Scroll View/Viewport/Content/QueryTransactionArea/IFTransaction");
		if (null == trid) {
            log("can't find input field");
			return;
		}
        log("test onTransactionGetBlockInfo");
		BCX.BCXWrapper.get_transaction_in_block_info(trid.text);
	}

    public void onContractQuery() {
		InputField contract =  findInputField("/Canvas/Scroll View/Viewport/Content/QueryContractArea/IFContract");
		if (null == contract) {
            log("can't find input field");
			return;
		}
        log("test onContractQuery");
		BCX.BCXWrapper.get_contract(contract.text);
	}

    public void onContractCallFee() {
		InputField acc =  findInputField("/Canvas/Scroll View/Viewport/Content/CallContractArea/IFAccount");
        InputField feeAssetType =  findInputField("/Canvas/Scroll View/Viewport/Content/CallContractArea/IFFeeAssetType");
        InputField contract =  findInputField("/Canvas/Scroll View/Viewport/Content/CallContractArea/IFContract");
        InputField function =  findInputField("/Canvas/Scroll View/Viewport/Content/CallContractArea/IFFunction");
        InputField param =  findInputField("/Canvas/Scroll View/Viewport/Content/CallContractArea/IFParams");
		if (null == acc || null == feeAssetType || null == contract || null == function || null == param) {
            log("can't find input field");
			return;
		}
        log("test onContractCallFee");
		BCX.BCXWrapper.calculate_invoking_contract_fee(acc.text, feeAssetType.text, contract.text, function.text, param.text);
	}

    public void onContractCall() {
		InputField acc =  findInputField("/Canvas/Scroll View/Viewport/Content/CallContractArea/IFAccount");
        InputField pw =  findInputField("/Canvas/Scroll View/Viewport/Content/CallContractArea/IFPassword");
        InputField feeAssetType =  findInputField("/Canvas/Scroll View/Viewport/Content/CallContractArea/IFFeeAssetType");
        InputField contract =  findInputField("/Canvas/Scroll View/Viewport/Content/CallContractArea/IFContract");
        InputField function =  findInputField("/Canvas/Scroll View/Viewport/Content/CallContractArea/IFFunction");
        InputField param =  findInputField("/Canvas/Scroll View/Viewport/Content/CallContractArea/IFParams");
		if (null == acc || null == pw || null == feeAssetType || null == contract || null == function || null == param) {
            log("can't find input field");
			return;
		}
        log("test onContractCall");
		BCX.BCXWrapper.invoking_contract(acc.text, pw.text, feeAssetType.text, contract.text, function.text, param.text);
	}

    public void onWorldViewQuery() {
		InputField worldview =  findInputField("/Canvas/Scroll View/Viewport/Content/QueryWorldViewArea/IFWorldView");
		if (null == worldview) {
            log("can't find input field");
			return;
		}
        log("test onWorldViewQuery");
		BCX.BCXWrapper.lookup_world_view(worldview.text.Split(new Char[] { ',' }).ToList());
	}

    public void onNHAssetListByCreator() {
		InputField acc =  findInputField("/Canvas/Scroll View/Viewport/Content/ListNHAssetByCreatorArea/IFAccount");
        InputField pagesize =  findInputField("/Canvas/Scroll View/Viewport/Content/ListNHAssetByCreatorArea/IFPageSize");
        InputField page =  findInputField("/Canvas/Scroll View/Viewport/Content/ListNHAssetByCreatorArea/IFPage");
		if (null == acc || null == pagesize || null == page) {
            log("can't find input field");
			return;
		}
        log("test onNHAssetListByCreator");
        int iPage;
        int iPageSize;
        int.TryParse(page.text, out iPage);
        int.TryParse(pagesize.text, out iPageSize); 
		BCX.BCXWrapper.list_nh_asset_by_creator(acc.text, iPage, iPageSize);
	}

	public void onNHAssetListOrderByAccount() {
		InputField acc =  findInputField("/Canvas/Scroll View/Viewport/Content/ListNHAssetOrderByAccountArea/IFAccount");
        InputField pagesize =  findInputField("/Canvas/Scroll View/Viewport/Content/ListNHAssetOrderByAccountArea/IFPageSize");
        InputField page =  findInputField("/Canvas/Scroll View/Viewport/Content/ListNHAssetOrderByAccountArea/IFPage");
		if (null == acc || null == pagesize || null == page) {
            log("can't find input field");
			return;
		}
        log("test onNHAssetListOrderByAccount");
        int iPage;
        int iPageSize;
        int.TryParse(page.text, out iPage);
        int.TryParse(pagesize.text, out iPageSize); 
		BCX.BCXWrapper.list_account_nh_asset_order(acc.text, iPageSize, iPage);
	}

	public void onNHAssetListOrder() {
		InputField asset =  findInputField("/Canvas/Scroll View/Viewport/Content/ListNHAssetOrderArea/IFAsset");
		InputField worldview =  findInputField("/Canvas/Scroll View/Viewport/Content/ListNHAssetOrderArea/IFWorldView");
		InputField description =  findInputField("/Canvas/Scroll View/Viewport/Content/ListNHAssetOrderArea/IFBaseDescription");
        InputField pagesize =  findInputField("/Canvas/Scroll View/Viewport/Content/ListNHAssetOrderArea/IFPageSize");
        InputField page =  findInputField("/Canvas/Scroll View/Viewport/Content/ListNHAssetOrderArea/IFPage");
		if (null == asset || null == worldview || null == description || null == pagesize || null == page) {
            log("can't find input field");
			return;
		}
        log("test onNHAssetListOrder");
        int iPage;
        int iPageSize;
        int.TryParse(page.text, out iPage);
        int.TryParse(pagesize.text, out iPageSize);
		BCX.BCXWrapper.list_nh_asset_order(asset.text, worldview.text, description.text, iPageSize, iPage);
	}

	public void onNHAssetGetTransferFee() {
		InputField accountfrom =  findInputField("/Canvas/Scroll View/Viewport/Content/NHAssetTransferArea/IFAccountFrom");
		InputField password =  findInputField("/Canvas/Scroll View/Viewport/Content/NHAssetTransferArea/IFPassword");
		InputField accountto =  findInputField("/Canvas/Scroll View/Viewport/Content/NHAssetTransferArea/IFAccountTo");
        InputField feesymbol =  findInputField("/Canvas/Scroll View/Viewport/Content/NHAssetTransferArea/IFFeeSymbol");
        InputField asset =  findInputField("/Canvas/Scroll View/Viewport/Content/NHAssetTransferArea/IFNHAsset");
		if (null == accountfrom || null == password || null == accountto || null == feesymbol || null == asset) {
            log("can't find input field");
			return;
		}
        log("test onNHAssetGetTransferFee");
		BCX.BCXWrapper.transfer_nh_asset_fee(accountfrom.text, accountto.text, feesymbol.text, asset.text);
	}

	public void onNHAssetTransfer() {
		InputField accountfrom =  findInputField("/Canvas/Scroll View/Viewport/Content/NHAssetTransferArea/IFAccountFrom");
		InputField password =  findInputField("/Canvas/Scroll View/Viewport/Content/NHAssetTransferArea/IFPassword");
		InputField accountto =  findInputField("/Canvas/Scroll View/Viewport/Content/NHAssetTransferArea/IFAccountTo");
        InputField feesymbol =  findInputField("/Canvas/Scroll View/Viewport/Content/NHAssetTransferArea/IFFeeSymbol");
        InputField asset =  findInputField("/Canvas/Scroll View/Viewport/Content/NHAssetTransferArea/IFNHAsset");
		if (null == accountfrom || null == password || null == accountto || null == feesymbol || null == asset) {
            log("can't find input field");
			return;
		}
        log("test onNHAssetTransfer");
		BCX.BCXWrapper.transfer_nh_asset(password.text, accountfrom.text, accountto.text, feesymbol.text, asset.text);
	}

	public void onNHAssetGetDeleteFee() {
		InputField account =  findInputField("/Canvas/Scroll View/Viewport/Content/NHAssetDeleteArea/IFAccount");
		InputField password =  findInputField("/Canvas/Scroll View/Viewport/Content/NHAssetDeleteArea/IFPassword");
        InputField feesymbol =  findInputField("/Canvas/Scroll View/Viewport/Content/NHAssetDeleteArea/IFFeeSymbol");
        InputField asset =  findInputField("/Canvas/Scroll View/Viewport/Content/NHAssetDeleteArea/IFNHAsset");
		if (null == account || null == password || null == feesymbol || null == asset) {
            log("can't find input field");
			return;
		}
        log("test onNHAssetGetDeleteFee");
		BCX.BCXWrapper.delete_nh_asset_fee(account.text, asset.text, feesymbol.text);
	}

	public void onNHAssetDelete() {
		InputField account =  findInputField("/Canvas/Scroll View/Viewport/Content/NHAssetDeleteArea/IFAccount");
		InputField password =  findInputField("/Canvas/Scroll View/Viewport/Content/NHAssetDeleteArea/IFPassword");
        InputField feesymbol =  findInputField("/Canvas/Scroll View/Viewport/Content/NHAssetDeleteArea/IFFeeSymbol");
        InputField asset =  findInputField("/Canvas/Scroll View/Viewport/Content/NHAssetDeleteArea/IFNHAsset");
		if (null == account || null == password || null == feesymbol || null == asset) {
            log("can't find input field");
			return;
		}
        log("test onNHAssetDelete");
		BCX.BCXWrapper.delete_nh_asset(account.text, password.text, asset.text, feesymbol.text);
	}

	public void onNHAssetGetPurchaseFee() {
		InputField account =  findInputField("/Canvas/Scroll View/Viewport/Content/NHAssetPurchaseArea/IFAccount");
		InputField password =  findInputField("/Canvas/Scroll View/Viewport/Content/NHAssetPurchaseArea/IFPassword");
        InputField feesymbol =  findInputField("/Canvas/Scroll View/Viewport/Content/NHAssetPurchaseArea/IFFeeSymbol");
        InputField order =  findInputField("/Canvas/Scroll View/Viewport/Content/NHAssetPurchaseArea/IFOrder");
		if (null == account || null == password || null == feesymbol || null == order) {
            log("can't find input field");
			return;
		}
        log("test onNHAssetGetPurchaseFee");
		BCX.BCXWrapper.buy_nh_asset_fee(account.text, order.text, feesymbol.text);
	}

	public void onNHAssetPurchase() {
		InputField account =  findInputField("/Canvas/Scroll View/Viewport/Content/NHAssetPurchaseArea/IFAccount");
		InputField password =  findInputField("/Canvas/Scroll View/Viewport/Content/NHAssetPurchaseArea/IFPassword");
        InputField feesymbol =  findInputField("/Canvas/Scroll View/Viewport/Content/NHAssetPurchaseArea/IFFeeSymbol");
        InputField order =  findInputField("/Canvas/Scroll View/Viewport/Content/NHAssetPurchaseArea/IFOrder");
		if (null == account || null == password || null == feesymbol || null == order) {
            log("can't find input field");
			return;
		}
        log("test onNHAssetPurchase");
		BCX.BCXWrapper.buy_nh_asset(password.text, account.text, order.text, feesymbol.text);
	}

	public void onNHAssetGetSellFee() {
		InputField otcaccount =  findInputField("/Canvas/Scroll View/Viewport/Content/NHAssetSellArea/IFAccountOTC");
		InputField account =  findInputField("/Canvas/Scroll View/Viewport/Content/NHAssetSellArea/IFAccount");
		InputField password =  findInputField("/Canvas/Scroll View/Viewport/Content/NHAssetSellArea/IFPassword");
        InputField asset =  findInputField("/Canvas/Scroll View/Viewport/Content/NHAssetSellArea/IFSellNHAsset");
        InputField fee =  findInputField("/Canvas/Scroll View/Viewport/Content/NHAssetSellArea/IFSellFee");
		InputField feeSymbol =  findInputField("/Canvas/Scroll View/Viewport/Content/NHAssetSellArea/IFSellFeeSymbol");
		InputField memo =  findInputField("/Canvas/Scroll View/Viewport/Content/NHAssetSellArea/IFMemo");
		InputField price =  findInputField("/Canvas/Scroll View/Viewport/Content/NHAssetSellArea/IFSellPrice");
		InputField priceSymbol =  findInputField("/Canvas/Scroll View/Viewport/Content/NHAssetSellArea/IFSellPriceSymbol");
		InputField expiration =  findInputField("/Canvas/Scroll View/Viewport/Content/NHAssetSellArea/IFExpiration");
		if (null == otcaccount || null == account || null == password || null == asset || null == fee
			|| null == feeSymbol || null == memo || null == price || null == priceSymbol || null == expiration) {
            log("can't find input field");
			return;
		}
        log("test onNHAssetGetSellFee");
		long lexpiration;
		long.TryParse(expiration.text, out lexpiration);
		BCX.BCXWrapper.create_nh_asset_order_fee(otcaccount.text, account.text, asset.text, fee.text, feeSymbol.text, memo.text, price.text, priceSymbol.text, lexpiration);

	}

	public void onNHAssetSell() {
		InputField otcaccount =  findInputField("/Canvas/Scroll View/Viewport/Content/NHAssetSellArea/IFAccountOTC");
		InputField account =  findInputField("/Canvas/Scroll View/Viewport/Content/NHAssetSellArea/IFAccount");
		InputField password =  findInputField("/Canvas/Scroll View/Viewport/Content/NHAssetSellArea/IFPassword");
        InputField asset =  findInputField("/Canvas/Scroll View/Viewport/Content/NHAssetSellArea/IFSellNHAsset");
        InputField fee =  findInputField("/Canvas/Scroll View/Viewport/Content/NHAssetSellArea/IFSellFee");
		InputField feeSymbol =  findInputField("/Canvas/Scroll View/Viewport/Content/NHAssetSellArea/IFSellFeeSymbol");
		InputField memo =  findInputField("/Canvas/Scroll View/Viewport/Content/NHAssetSellArea/IFMemo");
		InputField price =  findInputField("/Canvas/Scroll View/Viewport/Content/NHAssetSellArea/IFSellPrice");
		InputField priceSymbol =  findInputField("/Canvas/Scroll View/Viewport/Content/NHAssetSellArea/IFSellPriceSymbol");
		InputField expiration =  findInputField("/Canvas/Scroll View/Viewport/Content/NHAssetSellArea/IFExpiration");
		if (null == otcaccount || null == account || null == password || null == asset || null == fee
			|| null == feeSymbol || null == memo || null == price || null == priceSymbol || null == expiration) {
            log("can't find input field");
			return;
		}
        log("test onNHAssetSell");
		long lexpiration;
		long.TryParse(expiration.text, out lexpiration);
		BCX.BCXWrapper.create_nh_asset_order(otcaccount.text, account.text, password.text, asset.text, fee.text, feeSymbol.text, memo.text, price.text, priceSymbol.text, lexpiration);
	}

	public void onNHAssetGetCancelSellOrderFee() {
		InputField account =  findInputField("/Canvas/Scroll View/Viewport/Content/NHAssetCancelSellArea/IFAccount");
		InputField password =  findInputField("/Canvas/Scroll View/Viewport/Content/NHAssetCancelSellArea/IFPassword");
        InputField order =  findInputField("/Canvas/Scroll View/Viewport/Content/NHAssetCancelSellArea/IFOrder");
		InputField feeSymbol =  findInputField("/Canvas/Scroll View/Viewport/Content/NHAssetCancelSellArea/IFFeeSymbol");
		if (null == account || null == password || null == order || null == feeSymbol) {
            log("can't find input field");
			return;
		}
        log("test onNHAssetGetCancelSellOrderFee");
		BCX.BCXWrapper.cancel_nh_asset_order_fee(account.text, order.text, feeSymbol.text);
	}

	public void onNHAssetCancelSellOrder() {
		InputField account =  findInputField("/Canvas/Scroll View/Viewport/Content/NHAssetCancelSellArea/IFAccount");
		InputField password =  findInputField("/Canvas/Scroll View/Viewport/Content/NHAssetCancelSellArea/IFPassword");
        InputField order =  findInputField("/Canvas/Scroll View/Viewport/Content/NHAssetCancelSellArea/IFOrder");
		InputField feeSymbol =  findInputField("/Canvas/Scroll View/Viewport/Content/NHAssetCancelSellArea/IFFeeSymbol");
		if (null == account || null == password || null == order || null == feeSymbol) {
            log("can't find input field");
			return;
		}
        log("test onNHAssetCancelSellOrder");
		BCX.BCXWrapper.cancel_nh_asset_order(account.text, password.text, order.text, feeSymbol.text);
	}

    private InputField findInputField(string path)
    {
        return GameObject.Find(path).GetComponent<InputField>() as InputField;
    }

	private void BCXCallback(string evt, string json) {
		log(evt);
		log(json);

		JSONObject jObj = new JSONObject(json);
		JSONObject codeObj = jObj.GetField("code");
		JSONObject dataObj = jObj.GetField("data");
		switch(evt) {
			case "password_login": {
				if (1 == codeObj.n) {
					isLoginIn = true;
					accountLable.text = "Account:" + (isLoginIn ? userAccount : "(Not Login)") + " Version:" + version;
				}
				break;
			}
			case "get_version_info": {
				if (1 == codeObj.n) {
					version = dataObj.str;
					accountLable.text = "Account:" + (isLoginIn ? userAccount : "(Not Login)") + " Version:" + version;
				}
				break;
			}
			default: {
				break;
			}
		}
	}

	private void log(string s)
    {
        Debug.Log(s);

        string newLine = "\n"; // System.Environment.NewLine;
        logBuffer += newLine;
        logBuffer += s;
        int numLines = logBuffer.Split(newLine.ToCharArray()).Length;
        if (numLines > MAX_LOG_LINE)
        {
            string[] lines = logBuffer.Split(newLine.ToCharArray()).Skip(numLines - MAX_LOG_LINE).ToArray();
            logBuffer = string.Join(newLine, lines);
        }

        if (logText)
        {
            logText.text = logBuffer;
        }
    }

}
