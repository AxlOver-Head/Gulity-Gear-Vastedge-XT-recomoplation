using UnityEngine;

public class UIDataBonus
{
	private UISprite[] m_Bonus_Num_01;

	private UISprite[] m_Bonus_Num_02;

	private UISprite[] m_Bonus_Num_03;

	private UISprite[] m_Bonus_Num_04;

	private UISprite[] m_Bonus_Num_05;

	private UISprite[] m_Bonus_Num_06;

	private UISprite[] m_Bonus_Num_07;

	private UISprite[] m_Bonus_Num_08;

	private UIData parent;

	public UIDataBonus(UIData _parent)
	{
		string text = "Data(Clone)/Camera/Anchor2_Center/Panel_2_Bonus/";
		string[] name = new string[3] { "Bonus_01/num_001", "Bonus_01/num_010", "Bonus_01/num_100" };
		string[] name2 = new string[3] { "Bonus_02/num_001", "Bonus_02/num_010", "Bonus_02/num_100" };
		string[] name3 = new string[3] { "Bonus_03/num_001", "Bonus_03/num_010", "Bonus_03/num_100" };
		string[] name4 = new string[3] { "Bonus_04/num_001", "Bonus_04/num_010", "Bonus_04/num_100" };
		string[] name5 = new string[5] { "Bonus_05/num_0_001", "Bonus_05/num_0_010", "Bonus_05/num_0_100", "Bonus_05/num_0X000", "Bonus_05/num_1_000" };
		string[] name6 = new string[3] { "Bonus_06/num_001", "Bonus_06/num_010", "Bonus_06/num_100" };
		string[] name7 = new string[5] { "Bonus_07/num_0_001", "Bonus_07/num_0_010", "Bonus_07/num_0_100", "Bonus_07/num_0X000", "Bonus_07/num_1_000" };
		string[] name8 = new string[5] { "Bonus_08/num_0001", "Bonus_08/num_0010", "Bonus_08/num_0100", "Bonus_08/num_1000", "Bonus_08/num_comma" };
		parent = _parent;
		m_Bonus_Num_01 = parent.setUISprite(text, name);
		m_Bonus_Num_02 = parent.setUISprite(text, name2);
		m_Bonus_Num_03 = parent.setUISprite(text, name3);
		m_Bonus_Num_04 = parent.setUISprite(text, name4);
		m_Bonus_Num_05 = parent.setUISprite(text, name5);
		m_Bonus_Num_06 = parent.setUISprite(text, name6);
		m_Bonus_Num_07 = parent.setUISprite(text, name7);
		m_Bonus_Num_08 = parent.setUISprite(text, name8);
	}

	public void setData(int data_01, int data_02, int data_03, int data_04, int data_05, int data_06, int data_07, int data_08)
	{
		if (data_01 < 0)
		{
			data_01 = 0;
		}
		if (data_02 < 0)
		{
			data_02 = 0;
		}
		if (data_03 < 0)
		{
			data_03 = 0;
		}
		if (data_04 < 0)
		{
			data_04 = 0;
		}
		if (data_05 < 0)
		{
			data_05 = 0;
		}
		if (data_06 < 0)
		{
			data_06 = 0;
		}
		if (data_07 < 0)
		{
			data_07 = 0;
		}
		if (data_08 < 0)
		{
			data_08 = 0;
		}
		if (data_01 > 999)
		{
			data_01 = 999;
		}
		if (data_02 > 999)
		{
			data_02 = 999;
		}
		if (data_03 > 999)
		{
			data_03 = 999;
		}
		if (data_04 > 999)
		{
			data_04 = 999;
		}
		if (data_05 > 999)
		{
			data_05 = 999;
		}
		if (data_06 > 999)
		{
			data_06 = 999;
		}
		if (data_07 > 999)
		{
			data_07 = 999;
		}
		if (data_08 > 9999)
		{
			data_08 = 9999;
		}
		UISprite[] array = null;
		int num = 0;
		array = m_Bonus_Num_01;
		num = data_01;
		parent.setSpriteNum(0, num, array[0], false);
		parent.setSpriteNum(1, num, array[1], true);
		parent.setSpriteNum(2, num, array[2], true);
		array = m_Bonus_Num_02;
		num = data_02;
		parent.setSpriteNum(0, num, array[0], false);
		parent.setSpriteNum(1, num, array[1], true);
		parent.setSpriteNum(2, num, array[2], true);
		array = m_Bonus_Num_03;
		num = data_03;
		parent.setSpriteNum(0, num, array[0], false);
		parent.setSpriteNum(1, num, array[1], true);
		parent.setSpriteNum(2, num, array[2], true);
		array = m_Bonus_Num_04;
		num = data_04;
		parent.setSpriteNum(0, num, array[0], false);
		parent.setSpriteNum(1, num, array[1], true);
		parent.setSpriteNum(2, num, array[2], true);
		array = m_Bonus_Num_05;
		num = data_05;
		if (num <= 0)
		{
			Color color = new Color(1f, 1f, 1f, 0f);
			array[0].spriteName = "data_num_b_m";
			array[1].color = color;
			array[2].color = color;
			array[3].color = color;
			array[4].color = color;
		}
		else
		{
			parent.setSpriteNum(0, num, array[0], false);
			parent.setSpriteNum(1, num, array[1], true);
			parent.setSpriteNum(2, num, array[2], true);
			parent.setSpriteKakuritsu(num, array[3], 3);
			parent.setSpriteKakuritsu(num, array[4], 3);
		}
		array = m_Bonus_Num_06;
		num = data_06;
		parent.setSpriteNum(0, num, array[0], false);
		parent.setSpriteNum(1, num, array[1], true);
		parent.setSpriteNum(2, num, array[2], true);
		array = m_Bonus_Num_07;
		num = data_07;
		if (num <= 0)
		{
			Color color2 = new Color(1f, 1f, 1f, 0f);
			array[0].spriteName = "data_num_b_m";
			array[1].color = color2;
			array[2].color = color2;
			array[3].color = color2;
			array[4].color = color2;
		}
		else
		{
			parent.setSpriteNum(0, num, array[0], false);
			parent.setSpriteNum(1, num, array[1], true);
			parent.setSpriteNum(2, num, array[2], true);
			parent.setSpriteKakuritsu(num, array[3], 3);
			parent.setSpriteKakuritsu(num, array[4], 3);
		}
		array = m_Bonus_Num_08;
		num = data_08;
		parent.setSpriteNum(0, num, array[0], false);
		parent.setSpriteNum(1, num, array[1], true);
		parent.setSpriteNum(2, num, array[2], true);
		parent.setSpriteNum(3, num, array[3], true);
		parent.setSpriteComma(num, array[4]);
	}
}
