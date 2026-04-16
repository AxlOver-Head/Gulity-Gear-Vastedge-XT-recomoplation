using UnityEngine;

public class UIDialog_start2 : UIDialog_Common
{
	public UIButtonMessage m_Btn1;

	private void Awake()
	{
		init();
		m_Panel = GameObject.Find("Dialog_start2(Clone)/Camera/Anchor/Panel");
		m_Btn1 = GameObject.Find("Dialog_start2(Clone)/Camera/Anchor/Panel/Button").GetComponent<UIButtonMessage>();
		m_Btn1.target = base.gameObject;
		m_Btn1.functionName = "OnClickButton1";
	}

	private void OnClickButton1()
	{
		m_DecideID = 0;
	}
}
