using UnityEngine;

public class UIDialog_18 : UIDialog_Common
{
	public UIButtonMessage m_Btn1;

	public UIButtonMessage m_Btn2;

	public UIButtonMessage m_Check1;

	public UIButtonMessage m_Check2;

	private bool m_Checked;

	private void Awake()
	{
		init();
		m_Panel = GameObject.Find("Dialog_18(Clone)/Camera/Anchor/Panel");
		m_Btn1 = GameObject.Find("Dialog_18(Clone)/Camera/Anchor/Panel/Button1").GetComponent<UIButtonMessage>();
		m_Btn1.target = base.gameObject;
		m_Btn1.functionName = "OnClickButton1";
		m_Btn2 = GameObject.Find("Dialog_18(Clone)/Camera/Anchor/Panel/Button2").GetComponent<UIButtonMessage>();
		m_Btn2.target = base.gameObject;
		m_Btn2.functionName = "OnClickButton2";
		m_Check1 = GameObject.Find("Dialog_18(Clone)/Camera/Anchor/Panel/Check1").GetComponent<UIButtonMessage>();
		m_Check1.target = base.gameObject;
		m_Check1.functionName = "OnClickCheck1";
		m_Check2 = GameObject.Find("Dialog_18(Clone)/Camera/Anchor/Panel/Check2").GetComponent<UIButtonMessage>();
		m_Check2.target = base.gameObject;
		m_Check2.functionName = "OnClickCheck2";
		m_Check2.gameObject.SetActive(false);
	}

	private void OnClickButton1()
	{
		if (!m_Checked)
		{
			m_DecideID = 0;
		}
		else
		{
			m_DecideID = 2;
		}
	}

	private void OnClickButton2()
	{
		if (!m_Checked)
		{
			m_DecideID = 1;
		}
		else
		{
			m_DecideID = 3;
		}
	}

	private void OnClickCheck1()
	{
		m_Checked = true;
		m_Check1.gameObject.SetActive(false);
		m_Check2.gameObject.SetActive(true);
	}

	private void OnClickCheck2()
	{
		m_Checked = false;
		m_Check1.gameObject.SetActive(true);
		m_Check2.gameObject.SetActive(false);
	}
}
