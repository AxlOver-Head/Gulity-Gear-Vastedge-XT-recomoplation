using System;
using UnityEngine;

public class AdjustmentReceipt
{
	private GameObject Receipt_Receipt;

	private GameObject Receipt_Tap;

	private UISprite[] Receipt_Sp_Medal;

	private UISprite[] Receipt_Sp_Tap;

	private UISprite[] Receipt_Sp_QR;

	private float m_ReceiptY;

	private AdjustmentScene parent;

	public bool m_Pushed;

	public AdjustmentReceipt(AdjustmentScene _parent)
	{
		parent = _parent;
		string[] name = new string[6] { "Panel_Receipt/Medal/00_001", "Panel_Receipt/Medal/00_010", "Panel_Receipt/Medal/00_100", "Panel_Receipt/Medal/01_000", "Panel_Receipt/Medal/10_000", "Panel_Receipt/Medal/00X000" };
		string[] name2 = new string[1] { "Panel_Receipt/QR" };
		string[] array = new string[1] { "Seisan_Receipt/Camera/Anchor/Panel_Mask/Push" };
		string text = "Seisan_Receipt/Camera/Anchor/Panel/";
		Receipt_Receipt = GameObject.Find(text + "Panel_Receipt");
		Receipt_Tap = GameObject.Find(array[0]);
		Receipt_Sp_Medal = parent.setUISprite(text, name);
		Receipt_Sp_QR = parent.setUISprite(text, name2);
		Receipt_Sp_Tap = parent.setUISprite(string.Empty, array);
		m_Pushed = false;
	}

	public void initReceipt()
	{
		int num = UserData.saveData.game.motiMedals;
		if (num < 0)
		{
			num = 0;
		}
		if (num > 99999)
		{
			num = 99999;
		}
		parent.setReceiptSpriteNum(0, num, Receipt_Sp_Medal[0], false);
		parent.setReceiptSpriteNum(1, num, Receipt_Sp_Medal[1], true);
		parent.setReceiptSpriteNum(2, num, Receipt_Sp_Medal[2], true);
		parent.setReceiptSpriteNum(3, num, Receipt_Sp_Medal[3], true);
		parent.setReceiptSpriteNum(4, num, Receipt_Sp_Medal[4], true);
		parent.setSpriteComma(num, Receipt_Sp_Medal[5]);
		m_ReceiptY = Receipt_Receipt.transform.localPosition.y;
		Receipt_Tap.SetActive(false);
		Receipt_Sp_Tap[0].color = new Color(1f, 1f, 1f, 0f);
	}

	public void controlReceipt(int current, int currentCnt)
	{
		switch (current)
		{
		case 0:
			if (currentCnt >= 30 && !SGLG.isFading)
			{
				parent.forwardCurrent();
			}
			break;
		case 1:
		{
			m_ReceiptY -= 40f;
			if (m_ReceiptY <= 0f)
			{
				m_ReceiptY = 0f;
				Receipt_Tap.SetActive(true);
				parent.forwardCurrent();
			}
			float x = Receipt_Receipt.transform.localPosition.x;
			float receiptY = m_ReceiptY;
			float z = Receipt_Receipt.transform.localPosition.z;
			Receipt_Receipt.transform.localPosition = new Vector3(x, receiptY, z);
			break;
		}
		case 2:
		{
			int num = 8;
			float num2 = 1f;
			if (currentCnt >= 11)
			{
				num2 = Mathf.Sin((float)(currentCnt * num) * ((float)Math.PI / 180f));
			}
			Receipt_Sp_Tap[0].color = new Color(1f, 1f, 1f, 1f - num2);
			if (m_Pushed)
			{
				Receipt_Tap.SetActive(false);
				SGLG.startFade();
				parent.forwardCurrent();
			}
			break;
		}
		case 3:
			if (SGLG.isFadeOutComplete())
			{
				parent.changeMode(AdjustmentScene.MODE.LOGIN);
			}
			break;
		}
	}
}
