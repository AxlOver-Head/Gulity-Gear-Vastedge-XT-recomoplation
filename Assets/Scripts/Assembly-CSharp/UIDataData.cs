public class UIDataData
{
	private UISprite[] m_Data_Num_01;

	private UISprite[] m_Data_Num_02;

	private UISprite[] m_Data_Num_03;

	private UISprite[] m_Data_Num_04;

	private UISprite[] m_Data_Num_05;

	private UISprite[] m_Data_Num_06;

	private UISprite[] m_Data_Num_07;

	private UISprite[] m_Data_Num_08;

	private UISprite[] m_Data_Num_09;

	private UISprite[] m_Data_Num_10;

	private UIData parent;

	public UIDataData(UIData _parent)
	{
		string text = "Data(Clone)/Camera/Anchor2_Center/Panel_1_Data/";
		string[] name = new string[6] { "Data_01/num_00001", "Data_01/num_00010", "Data_01/num_00100", "Data_01/num_01000", "Data_01/num_10000", "Data_01/num_comma" };
		string[] name2 = new string[6] { "Data_02/num_00001", "Data_02/num_00010", "Data_02/num_00100", "Data_02/num_01000", "Data_02/num_10000", "Data_02/num_comma" };
		string[] name3 = new string[6] { "Data_03/num_00001", "Data_03/num_00010", "Data_03/num_00100", "Data_03/num_01000", "Data_03/num_10000", "Data_03/num_comma" };
		string[] name4 = new string[7] { "Data_04/num_00001", "Data_04/num_00010", "Data_04/num_00100", "Data_04/num_01000", "Data_04/num_10000", "Data_04/num_comma", "Data_04/num_minus" };
		string[] name5 = new string[6] { "Data_05/num_00001", "Data_05/num_00010", "Data_05/num_00100", "Data_05/num_01000", "Data_05/num_10000", "Data_05/num_comma" };
		string[] name6 = new string[6] { "Data_06/num_00001", "Data_06/num_00010", "Data_06/num_00100", "Data_06/num_01000", "Data_06/num_10000", "Data_06/num_comma" };
		string[] name7 = new string[7] { "Data_07/num_00001", "Data_07/num_00010", "Data_07/num_00100", "Data_07/num_01000", "Data_07/num_10000", "Data_07/num_comma", "Data_07/num_minus" };
		string[] name8 = new string[6] { "Data_08/num_00001", "Data_08/num_00010", "Data_08/num_00100", "Data_08/num_01000", "Data_08/num_10000", "Data_08/num_point" };
		string[] name9 = new string[7] { "Data_09/num_000001", "Data_09/num_000010", "Data_09/num_000100", "Data_09/num_001000", "Data_09/num_010000", "Data_09/num_100000", "Data_09/num_comma" };
		string[] name10 = new string[8] { "Data_10/num_000001", "Data_10/num_000010", "Data_10/num_000100", "Data_10/num_001000", "Data_10/num_010000", "Data_10/num_100000", "Data_10/num_comma", "Data_10/num_minus" };
		parent = _parent;
		m_Data_Num_01 = parent.setUISprite(text, name);
		m_Data_Num_02 = parent.setUISprite(text, name2);
		m_Data_Num_03 = parent.setUISprite(text, name3);
		m_Data_Num_04 = parent.setUISprite(text, name4);
		m_Data_Num_05 = parent.setUISprite(text, name5);
		m_Data_Num_06 = parent.setUISprite(text, name6);
		m_Data_Num_07 = parent.setUISprite(text, name7);
		m_Data_Num_08 = parent.setUISprite(text, name8);
		m_Data_Num_09 = parent.setUISprite(text, name9);
		m_Data_Num_10 = parent.setUISprite(text, name10);
	}

	public void setData(int data_01, int data_02, int data_03, int data_04, int data_05, int data_06, int data_07, int data_08, int data_09, int data_10)
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
		if (data_04 < -99999)
		{
			data_04 = -99999;
		}
		if (data_05 < 0)
		{
			data_05 = 0;
		}
		if (data_06 < 0)
		{
			data_06 = 0;
		}
		if (data_07 < -99999)
		{
			data_07 = -99999;
		}
		if (data_08 < 0)
		{
			data_08 = 0;
		}
		if (data_09 < 0)
		{
			data_09 = 0;
		}
		if (data_10 < -999999)
		{
			data_10 = -999999;
		}
		if (data_01 > 99999)
		{
			data_01 = 99999;
		}
		if (data_02 > 99999)
		{
			data_02 = 99999;
		}
		if (data_03 > 99999)
		{
			data_03 = 99999;
		}
		if (data_04 > 99999)
		{
			data_04 = 99999;
		}
		if (data_05 > 99999)
		{
			data_05 = 99999;
		}
		if (data_06 > 99999)
		{
			data_06 = 99999;
		}
		if (data_07 > 99999)
		{
			data_07 = 99999;
		}
		if (data_08 > 99999)
		{
			data_08 = 99999;
		}
		if (data_09 > 999999)
		{
			data_09 = 999999;
		}
		if (data_10 > 999999)
		{
			data_10 = 999999;
		}
		UISprite[] array = null;
		int num = 0;
		array = m_Data_Num_01;
		num = data_01;
		parent.setSpriteNum(0, num, array[0], false);
		parent.setSpriteNum(1, num, array[1], true);
		parent.setSpriteNum(2, num, array[2], true);
		parent.setSpriteNum(3, num, array[3], true);
		parent.setSpriteNum(4, num, array[4], true);
		parent.setSpriteComma(num, array[5]);
		array = m_Data_Num_02;
		num = data_02;
		parent.setSpriteNum(0, num, array[0], false);
		parent.setSpriteNum(1, num, array[1], true);
		parent.setSpriteNum(2, num, array[2], true);
		parent.setSpriteNum(3, num, array[3], true);
		parent.setSpriteNum(4, num, array[4], true);
		parent.setSpriteComma(num, array[5]);
		array = m_Data_Num_03;
		num = data_03;
		parent.setSpriteNum(0, num, array[0], false);
		parent.setSpriteNum(1, num, array[1], true);
		parent.setSpriteNum(2, num, array[2], true);
		parent.setSpriteNum(3, num, array[3], true);
		parent.setSpriteNum(4, num, array[4], true);
		parent.setSpriteComma(num, array[5]);
		array = m_Data_Num_04;
		num = data_04;
		parent.setSpriteNum(0, num, array[0], false);
		parent.setSpriteNum(1, num, array[1], true);
		parent.setSpriteNum(2, num, array[2], true);
		parent.setSpriteNum(3, num, array[3], true);
		parent.setSpriteNum(4, num, array[4], true);
		parent.setSpriteComma(num, array[5]);
		parent.setSpriteMinus(num, array[6], 5);
		array = m_Data_Num_05;
		num = data_05;
		parent.setSpriteNum(0, num, array[0], false);
		parent.setSpriteNum(1, num, array[1], true);
		parent.setSpriteNum(2, num, array[2], true);
		parent.setSpriteNum(3, num, array[3], true);
		parent.setSpriteNum(4, num, array[4], true);
		parent.setSpriteComma(num, array[5]);
		array = m_Data_Num_06;
		num = data_06;
		parent.setSpriteNum(0, num, array[0], false);
		parent.setSpriteNum(1, num, array[1], true);
		parent.setSpriteNum(2, num, array[2], true);
		parent.setSpriteNum(3, num, array[3], true);
		parent.setSpriteNum(4, num, array[4], true);
		parent.setSpriteComma(num, array[5]);
		array = m_Data_Num_07;
		num = data_07;
		parent.setSpriteNum(0, num, array[0], false);
		parent.setSpriteNum(1, num, array[1], true);
		parent.setSpriteNum(2, num, array[2], true);
		parent.setSpriteNum(3, num, array[3], true);
		parent.setSpriteNum(4, num, array[4], true);
		parent.setSpriteComma(num, array[5]);
		parent.setSpriteMinus(num, array[6], 5);
		array = m_Data_Num_08;
		num = data_08;
		parent.setSpriteNum(0, num, array[0], false);
		parent.setSpriteNum(1, num, array[1], false);
		parent.setSpriteNum(2, num, array[2], false);
		parent.setSpriteNum(3, num, array[3], true);
		parent.setSpriteNum(4, num, array[4], true);
		array = m_Data_Num_09;
		num = data_09;
		parent.setSpriteNum(0, num, array[0], false);
		parent.setSpriteNum(1, num, array[1], true);
		parent.setSpriteNum(2, num, array[2], true);
		parent.setSpriteNum(3, num, array[3], true);
		parent.setSpriteNum(4, num, array[4], true);
		parent.setSpriteNum(5, num, array[5], true);
		parent.setSpriteComma(num, array[6]);
		array = m_Data_Num_10;
		num = data_10;
		parent.setSpriteNum(0, num, array[0], false);
		parent.setSpriteNum(1, num, array[1], true);
		parent.setSpriteNum(2, num, array[2], true);
		parent.setSpriteNum(3, num, array[3], true);
		parent.setSpriteNum(4, num, array[4], true);
		parent.setSpriteNum(5, num, array[5], true);
		parent.setSpriteComma(num, array[6]);
		parent.setSpriteMinus(num, array[7], 6);
	}
}
