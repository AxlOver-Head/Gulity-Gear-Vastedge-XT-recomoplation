using UnityEngine;

public class UIDialog_Common : MonoBehaviour
{
	public int m_Current;

	protected static readonly float SCALE_MIN = 0.01f;

	protected static readonly float SCALE_ADD = 0.1f;

	protected float m_Scale = SCALE_MIN;

	public GameObject m_Panel;

	public bool isEnd;

	public int m_DecideID = -1;

	private UISprite m_Mask;

	protected void init()
	{
		m_Scale = SCALE_MIN;
		isEnd = false;
		m_DecideID = -1;
		m_Mask = GameObject.Find(base.gameObject.name + "/Camera/Anchor/Panel_DialogMask/Mask").GetComponent<UISprite>();
	}

	private void Update()
	{
		switch (m_Current)
		{
		case 0:
		{
			m_Scale += SCALE_ADD * 60f * SGLG.deltaTime;
			if (m_Scale >= 1f)
			{
				m_Scale = 1f;
				m_Current++;
			}
			m_Panel.transform.localScale = new Vector3(m_Scale, m_Scale, 1f);
			float num2 = m_Scale / 1.5f;
			if (num2 > 1f)
			{
				num2 = 1f;
			}
			if (num2 < 0f)
			{
				num2 = 0f;
			}
			m_Mask.color = new Color(0f, 0f, 0f, num2);
			break;
		}
		case 1:
			if (m_DecideID >= 0)
			{
				m_Current++;
			}
			break;
		case 2:
		{
			m_Scale -= SCALE_ADD * 60f * SGLG.deltaTime;
			if (m_Scale <= SCALE_MIN)
			{
				m_Scale = SCALE_MIN;
				m_Current++;
			}
			m_Panel.transform.localScale = new Vector3(m_Scale, m_Scale, 1f);
			float num = m_Scale / 1.5f;
			if (num > 1f)
			{
				num = 1f;
			}
			if (num < 0f)
			{
				num = 0f;
			}
			m_Mask.color = new Color(0f, 0f, 0f, num);
			break;
		}
		case 3:
			isEnd = true;
			break;
		}
	}

	public static void setSpriteNum(int keta, int data, UISprite spr, bool erase_zero)
	{
		int num = 1;
		for (int i = 0; i < keta; i++)
		{
			num *= 10;
		}
		if (erase_zero && Mathf.Abs(data) < num)
		{
			spr.color = new Color(1f, 1f, 1f, 0f);
			return;
		}
		string text = "dialog_num_w_";
		if (data < 0)
		{
			text = "dialog_num_r_";
		}
		int num2 = data / num % 10;
		if (num2 < 0)
		{
			num2 = -num2;
		}
		spr.spriteName = text + num2;
	}

	public static void setSpriteComma(int data, UISprite spr)
	{
		if (data <= -1000)
		{
			spr.spriteName = "dialog_num_r_c";
		}
		else if (data < 1000)
		{
			spr.color = new Color(1f, 1f, 1f, 0f);
		}
	}

	public static void setSpriteMinus(int data, UISprite spr, int allKeta)
	{
		if (data >= 0)
		{
			spr.color = new Color(1f, 1f, 1f, 0f);
			return;
		}
		int num = -data;
		int num2 = 1;
		int i;
		for (i = 1; i < allKeta; i++)
		{
			if (num2 * 10 > num)
			{
				break;
			}
			num2 *= 10;
		}
		int num3 = allKeta - i;
		float num4 = (float)num3 * 20f;
		if (num < 1000)
		{
			num4 += 15f;
		}
		spr.gameObject.transform.localPosition = new Vector3(spr.gameObject.transform.localPosition.x + num4, spr.gameObject.transform.localPosition.y, spr.gameObject.transform.localPosition.z);
	}

	public static UISprite[] setUISprite(string _base, string[] _name)
	{
		UISprite[] array = new UISprite[_name.Length];
		for (int i = 0; i < _name.Length; i++)
		{
			array[i] = GameObject.Find(_base + _name[i]).GetComponent<UISprite>();
		}
		return array;
	}

	public static void setMedalStatus(string str_base, string[] smdl1, string[] smdl2, string[] smdl3, UISprite[] spr1, UISprite[] spr2, UISprite[] spr3)
	{
		int num = 0;
		int num2 = UserData.saveData.game.motiMedals;
		int num3 = num2 - num;
		if (num < 0)
		{
			num = 0;
		}
		if (num2 < -99999)
		{
			num2 = -99999;
		}
		if (num3 < -99999)
		{
			num3 = -99999;
		}
		if (num >= 99999)
		{
			num = 99999;
		}
		if (num2 >= 99999)
		{
			num2 = 99999;
		}
		if (num3 >= 99999)
		{
			num3 = 99999;
		}
		spr1 = setUISprite(str_base, smdl1);
		setSpriteNum(0, num, spr1[0], false);
		setSpriteNum(1, num, spr1[1], true);
		setSpriteNum(2, num, spr1[2], true);
		setSpriteNum(3, num, spr1[3], true);
		setSpriteNum(4, num, spr1[4], true);
		setSpriteComma(num, spr1[5]);
		spr2 = setUISprite(str_base, smdl2);
		setSpriteNum(0, num2, spr2[0], false);
		setSpriteNum(1, num2, spr2[1], true);
		setSpriteNum(2, num2, spr2[2], true);
		setSpriteNum(3, num2, spr2[3], true);
		setSpriteNum(4, num2, spr2[4], true);
		setSpriteComma(num2, spr2[5]);
		setSpriteMinus(num2, spr2[6], 5);
		spr3 = setUISprite(str_base, smdl3);
		setSpriteNum(0, num3, spr3[0], false);
		setSpriteNum(1, num3, spr3[1], true);
		setSpriteNum(2, num3, spr3[2], true);
		setSpriteNum(3, num3, spr3[3], true);
		setSpriteNum(4, num3, spr3[4], true);
		setSpriteComma(num3, spr3[5]);
		setSpriteMinus(num3, spr3[6], 5);
	}
}
