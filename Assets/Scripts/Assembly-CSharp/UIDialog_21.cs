using UnityEngine;

public class UIDialog_21 : UIDialog_Common
{
	public UIButtonMessage m_Btn1;

	private UISprite[] m_Medal_1;

	private UISprite[] m_Medal_2;

	private UISprite[] m_Medal_3;

	private void Awake()
	{
		string text = "Dialog_21(Clone)/Camera/Anchor/Panel/";
		string[] smdl = new string[6] { "Medal_1/00_001", "Medal_1/00_010", "Medal_1/00_100", "Medal_1/01_000", "Medal_1/10_000", "Medal_1/00X000" };
		string[] smdl2 = new string[7] { "Medal_2/00_001", "Medal_2/00_010", "Medal_2/00_100", "Medal_2/01_000", "Medal_2/10_000", "Medal_2/00X000", "Medal_2/minus" };
		string[] smdl3 = new string[7] { "Medal_3/00_001", "Medal_3/00_010", "Medal_3/00_100", "Medal_3/01_000", "Medal_3/10_000", "Medal_3/00X000", "Medal_3/minus" };
		init();
		m_Panel = GameObject.Find("Dialog_21(Clone)/Camera/Anchor/Panel");
		m_Btn1 = GameObject.Find(text + "Button1").GetComponent<UIButtonMessage>();
		m_Btn1.target = base.gameObject;
		m_Btn1.functionName = "OnClickButton1";
		UIDialog_Common.setMedalStatus(text, smdl, smdl2, smdl3, m_Medal_1, m_Medal_2, m_Medal_3);
	}

	private void OnClickButton1()
	{
		m_DecideID = 0;
	}
}
