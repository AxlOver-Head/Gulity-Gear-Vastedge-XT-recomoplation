using System;
using UnityEngine;

public class AdjustmentCard
{
	private GameObject Card_Card;

	private GameObject Card_Tap;

	private UISprite[] Card_Sp_Medal;

	private UISprite[] Card_Sp_Tap;

	private UISprite[] Card_Sp_Ekisyo;

	private float m_CardY;

	private float m_ScrAlpha_2;

	private float m_ScrAlpha_3;

	private AdjustmentScene parent;

	public bool m_Pushed;

	public AdjustmentCard(AdjustmentScene _parent)
	{
		parent = _parent;
		string[] name = new string[6] { "00_001", "00_010", "00_100", "01_000", "10_000", "00X000" };
		string[] name2 = new string[1] { "Tap" };
		string[] name3 = new string[3] { "Ekisyo1", "Ekisyo2", "Ekisyo3" };
		string text = "Seisan_Card/Camera/Anchor/Panel/";
		Card_Card = GameObject.Find(text + "Card");
		Card_Tap = GameObject.Find(text + "Tap");
		Card_Sp_Medal = parent.setUISprite(text, name);
		Card_Sp_Tap = parent.setUISprite(text, name2);
		Card_Sp_Ekisyo = parent.setUISprite(text, name3);
		m_Pushed = false;
	}

	public void initCard()
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
		parent.setCardSpriteNum(0, num, Card_Sp_Medal[0], false);
		parent.setCardSpriteNum(1, num, Card_Sp_Medal[1], true);
		parent.setCardSpriteNum(2, num, Card_Sp_Medal[2], true);
		parent.setCardSpriteNum(3, num, Card_Sp_Medal[3], true);
		parent.setCardSpriteNum(4, num, Card_Sp_Medal[4], true);
		parent.setSpriteComma(num, Card_Sp_Medal[5]);
		Card_Tap.SetActive(false);
		for (int i = 0; i < Card_Sp_Medal.Length; i++)
		{
			if (Card_Sp_Medal[i].alpha == 0f)
			{
				Card_Sp_Medal[i].gameObject.SetActive(false);
			}
			Card_Sp_Medal[i].alpha = 0f;
		}
		m_CardY = Card_Card.transform.localPosition.y;
		m_ScrAlpha_2 = 0f;
		m_ScrAlpha_3 = 0f;
		Card_Sp_Ekisyo[1].color = new Color(1f, 1f, 1f, m_ScrAlpha_2);
		Card_Sp_Ekisyo[2].color = new Color(1f, 1f, 1f, m_ScrAlpha_3);
		Card_Sp_Tap[0].color = new Color(1f, 1f, 1f, 0f);
	}

	public void controlCard(int current, int currentCnt)
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
			m_CardY -= 40f;
			if (m_CardY <= 0f)
			{
				m_CardY = 0f;
				parent.forwardCurrent();
			}
			float x = Card_Card.transform.localPosition.x;
			float cardY = m_CardY;
			float z = Card_Card.transform.localPosition.z;
			Card_Card.transform.localPosition = new Vector3(x, cardY, z);
			break;
		}
		case 2:
		{
			m_ScrAlpha_2 += 0.1f;
			if (m_ScrAlpha_2 >= 1f)
			{
				m_ScrAlpha_2 = 1f;
				Card_Tap.SetActive(true);
				parent.forwardCurrent();
			}
			Card_Sp_Ekisyo[1].color = new Color(1f, 1f, 1f, m_ScrAlpha_2);
			for (int i = 0; i < Card_Sp_Medal.Length; i++)
			{
				Card_Sp_Medal[i].alpha = m_ScrAlpha_2;
			}
			break;
		}
		case 3:
		{
			int num = 8;
			float num2 = 1f;
			if (currentCnt >= 11)
			{
				num2 = Mathf.Sin((float)(currentCnt * num) * ((float)Math.PI / 180f));
			}
			Card_Sp_Tap[0].color = new Color(1f, 1f, 1f, 1f - num2);
			if (m_Pushed)
			{
				Card_Tap.SetActive(false);
				parent.forwardCurrent();
			}
			break;
		}
		case 4:
		{
			m_CardY -= 40f;
			float x2 = Card_Card.transform.localPosition.x;
			float cardY2 = m_CardY;
			float z2 = Card_Card.transform.localPosition.z;
			Card_Card.transform.localPosition = new Vector3(x2, cardY2, z2);
			if (m_CardY < -300f)
			{
				parent.forwardCurrent();
			}
			break;
		}
		case 5:
			if (m_CardY >= -700f)
			{
				m_CardY -= 40f;
				float x3 = Card_Card.transform.localPosition.x;
				float cardY3 = m_CardY;
				float z3 = Card_Card.transform.localPosition.z;
				Card_Card.transform.localPosition = new Vector3(x3, cardY3, z3);
			}
			m_ScrAlpha_3 += 0.1f;
			if (m_ScrAlpha_3 >= 1f)
			{
				m_ScrAlpha_3 = 1f;
				parent.forwardCurrent();
			}
			Card_Sp_Ekisyo[2].color = new Color(1f, 1f, 1f, m_ScrAlpha_3);
			break;
		case 6:
			if (currentCnt >= 30)
			{
				SGLG.startFadeWhite();
				parent.forwardCurrent();
			}
			break;
		case 7:
			if (SGLG.isFadeOutComplete())
			{
				SGLG.m_Mode = SGLG.MODE.TITLE;
			}
			break;
		}
	}
}
