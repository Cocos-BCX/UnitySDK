using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour {

    public UnityEngine.UI.Text logText;
    private string logBuffer = "Log:";
	private const int MAX_LOG_LINE = 3;

	// Use this for initialization
	void Start () {
		BCX.BCXWrapper.BCXEvent += BCXCallback;

		string nodeUrl = "ws://39.106.126.54:8049";
        string faucetUrl = "http://47.93.62.96:8041";
        string chainId = "7d89b84f22af0b150780a2b121aa6c715b19261c8b7fe0fda3a564574ed7d3e9";
        string coreAsset = "COCOS";
        bool isOpenLog = true;
        BCX.BCXWrapper.connect(chainId, nodeUrl, faucetUrl, coreAsset, isOpenLog);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void onLogin() {
		InputField acc =  GameObject.Find("/Canvas/Scroll View/Viewport/Content/loginArea/IFAccount").GetComponent<InputField>() as InputField;
		InputField pw =  (InputField)GameObject.Find("/Canvas/Scroll View/Viewport/Content/loginArea/IFPassword").GetComponent<InputField>() as InputField;
		if (null == acc || null == pw) {
			return;
		}
        log("to password_login");
		BCX.BCXWrapper.password_login(acc.text, pw.text);
	}

	private void BCXCallback(string evt, string json) {
		log(evt);
		log(json);
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
