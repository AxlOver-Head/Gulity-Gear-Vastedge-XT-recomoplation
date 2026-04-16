using UnityEngine;

public class UIDialog_03 : UIDialog_Common
{
	public UIButtonMessage m_Btn1;

	public UIButtonMessage m_Btn2;

	private void Awake()
	{
		init();
		m_Panel = GameObject.Find("Dialog_03(Clone)/Camera/Anchor/Panel");
		m_Btn1 = GameObject.Find("Dialog_03(Clone)/Camera/Anchor/Panel/Button1").GetComponent<UIButtonMessage>();
		m_Btn1.target = base.gameObject;
		m_Btn1.functionName = "OnClickButton1";
		m_Btn2 = GameObject.Find("Dialog_03(Clone)/Camera/Anchor/Panel/Button2").GetComponent<UIButtonMessage>();
		m_Btn2.target = base.gameObject;
		m_Btn2.functionName = "OnClickButton2";
	}

	private void OnClickButton1()
	{
		m_DecideID = 0;
	}

	private void OnClickButton2()
	{
		m_DecideID = 1;
	}
}
