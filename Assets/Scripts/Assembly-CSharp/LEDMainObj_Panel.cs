using UnityEngine;

public class LEDMainObj_Panel : LEDMainObj
{
	public enum KIND
	{
		PANEL_01 = 0,
		PANEL_02 = 1,
		PANEL_03 = 2,
		PANEL_04 = 3,
		PANEL_05 = 4,
		PANEL_06 = 5,
		PANEL_07 = 6,
		PANEL_08 = 7,
		PANEL_09 = 8,
		PANEL_10 = 9,
		PANEL_11 = 10,
		PANEL_12 = 11,
		PANEL_13 = 12,
		PANEL_14 = 13,
		PANEL_15 = 14,
		PANEL_16 = 15,
		PANEL_17 = 16,
		PANEL_18 = 17,
		PANEL_19 = 18,
		PANEL_20 = 19,
		PANEL_21 = 20,
		PANEL_22 = 21,
		PANEL_GEKI_01_L = 22,
		PANEL_GEKI_01_R = 23,
		PANEL_GEKI_02_L = 24,
		PANEL_GEKI_02_R = 25,
		PANEL_GEKI_03_L = 26,
		PANEL_GEKI_03_R = 27,
		PANEL_GEKI_ALPHA_L = 28,
		PANEL_GEKI_ALPHA_R = 29,
		PANEL_GEKI_ALPHA_L2 = 30,
		PANEL_GEKI_ALPHA_R2 = 31,
		MAX = 32
	}

	public LEDMainObj_Panel(LEDMainManager _man)
		: base(_man)
	{
		m_LEDArray = new GameObject[32];
		m_LEDArray[0] = GameObject.Find("kyoutai/body/LED/bottom_panel_light/bottom_panel_LED_01");
		m_LEDArray[1] = GameObject.Find("kyoutai/body/LED/bottom_panel_light/bottom_panel_LED_02");
		m_LEDArray[2] = GameObject.Find("kyoutai/body/LED/bottom_panel_light/bottom_panel_LED_03");
		m_LEDArray[3] = GameObject.Find("kyoutai/body/LED/bottom_panel_light/bottom_panel_LED_04");
		m_LEDArray[4] = GameObject.Find("kyoutai/body/LED/bottom_panel_light/bottom_panel_LED_05");
		m_LEDArray[5] = GameObject.Find("kyoutai/body/LED/bottom_panel_light/bottom_panel_LED_06");
		m_LEDArray[6] = GameObject.Find("kyoutai/body/LED/bottom_panel_light/bottom_panel_LED_07");
		m_LEDArray[7] = GameObject.Find("kyoutai/body/LED/bottom_panel_light/bottom_panel_LED_08");
		m_LEDArray[8] = GameObject.Find("kyoutai/body/LED/bottom_panel_light/bottom_panel_LED_09");
		m_LEDArray[9] = GameObject.Find("kyoutai/body/LED/bottom_panel_light/bottom_panel_LED_10");
		m_LEDArray[10] = GameObject.Find("kyoutai/body/LED/bottom_panel_light/bottom_panel_LED_11");
		m_LEDArray[11] = GameObject.Find("kyoutai/body/LED/bottom_panel_light/bottom_panel_LED_12");
		m_LEDArray[12] = GameObject.Find("kyoutai/body/LED/bottom_panel_light/bottom_panel_LED_13");
		m_LEDArray[13] = GameObject.Find("kyoutai/body/LED/bottom_panel_light/bottom_panel_LED_14");
		m_LEDArray[14] = GameObject.Find("kyoutai/body/LED/bottom_panel_light/bottom_panel_LED_15");
		m_LEDArray[15] = GameObject.Find("kyoutai/body/LED/bottom_panel_light/bottom_panel_LED_16");
		m_LEDArray[16] = GameObject.Find("kyoutai/body/LED/bottom_panel_light/bottom_panel_LED_17");
		m_LEDArray[17] = GameObject.Find("kyoutai/body/LED/bottom_panel_light/bottom_panel_LED_18");
		m_LEDArray[18] = GameObject.Find("kyoutai/body/LED/bottom_panel_light/bottom_panel_LED_19");
		m_LEDArray[19] = GameObject.Find("kyoutai/body/LED/bottom_panel_light/bottom_panel_LED_20");
		m_LEDArray[20] = GameObject.Find("kyoutai/body/LED/bottom_panel_light/bottom_panel_LED_21");
		m_LEDArray[21] = GameObject.Find("kyoutai/body/LED/bottom_panel_light/bottom_panel_LED_22");
		m_LEDArray[22] = GameObject.Find("kyoutai/body/LED/bottom_panel_light/bottom_panel_light_over_L");
		m_LEDArray[23] = GameObject.Find("kyoutai/body/LED/bottom_panel_light/bottom_panel_light_over_R");
		m_LEDArray[24] = GameObject.Find("kyoutai/body/LED/bottom_panel_light/gekihen/bottom_panel_light_under_01_L");
		m_LEDArray[25] = GameObject.Find("kyoutai/body/LED/bottom_panel_light/gekihen/bottom_panel_light_under_01_R");
		m_LEDArray[26] = GameObject.Find("kyoutai/body/LED/bottom_panel_light/gekihen/bottom_panel_light_under_02_L");
		m_LEDArray[27] = GameObject.Find("kyoutai/body/LED/bottom_panel_light/gekihen/bottom_panel_light_under_02_R");
		m_LEDArray[28] = GameObject.Find("kyoutai/body/LED/bottom_panel_light/bottom_panel_light_over_alpha_L");
		m_LEDArray[29] = GameObject.Find("kyoutai/body/LED/bottom_panel_light/bottom_panel_light_over_alpha_R");
		m_LEDArray[30] = GameObject.Find("kyoutai/body/LED/bottom_panel_light/bottom_panel_light_over_alpha_L2");
		m_LEDArray[31] = GameObject.Find("kyoutai/body/LED/bottom_panel_light/bottom_panel_light_over_alpha_R2");
		setLEDColor();
	}

	public void init()
	{
	}

	private void setColor(out Color col, int _id)
	{
		float num = 0f;
		float num2 = 0f;
		float num3 = 0f;
		float num4 = 0f;
		switch (_id)
		{
		case 0:
			num = 1f;
			num2 = 1f;
			num3 = 1f;
			num4 = (float)(man.blendData[67] + man.blendData[68]) / 31f / 2f;
			break;
		case 1:
			num = 1f;
			num2 = 1f;
			num3 = 1f;
			num4 = (float)(int)man.blendData[60] / 31f;
			break;
		case 2:
			num = 1f;
			num2 = 1f;
			num3 = 1f;
			num4 = (float)(int)man.blendData[61] / 31f;
			break;
		case 3:
			num = 1f;
			num2 = 1f;
			num3 = 1f;
			num4 = (float)(int)man.blendData[64] / 31f;
			break;
		case 4:
			num = 1f;
			num2 = 1f;
			num3 = 1f;
			num4 = (float)(man.blendData[69] + man.blendData[70] + man.blendData[71]) / 31f / 3f;
			break;
		case 5:
			num = 1f;
			num2 = 1f;
			num3 = 1f;
			num4 = (float)(man.blendData[56] + man.blendData[57]) / 31f / 2f;
			break;
		case 6:
			num = 1f;
			num2 = 1f;
			num3 = 1f;
			num4 = (float)(man.blendData[53] + man.blendData[54]) / 31f / 2f;
			break;
		case 7:
			num = 1f;
			num2 = 1f;
			num3 = 1f;
			num4 = (float)(man.blendData[58] + man.blendData[59]) / 31f / 2f;
			break;
		case 8:
			num = 1f;
			num2 = 1f;
			num3 = 1f;
			num4 = (float)(man.blendData[65] + man.blendData[66]) / 31f / 2f;
			break;
		case 9:
			num = 1f;
			num2 = 1f;
			num3 = 1f;
			num4 = (float)(man.blendData[51] + man.blendData[73] + man.blendData[74]) / 31f / 3f;
			break;
		case 10:
			num = 1f;
			num2 = 1f;
			num3 = 1f;
			num4 = (float)(int)man.blendData[47] / 31f;
			break;
		case 11:
			num = 1f;
			num2 = 1f;
			num3 = 1f;
			num4 = (float)(int)man.blendData[50] / 31f;
			break;
		case 12:
			num = 1f;
			num2 = 1f;
			num3 = 1f;
			num4 = (float)(int)man.blendData[55] / 31f;
			break;
		case 13:
			num = 1f;
			num2 = 1f;
			num3 = 1f;
			num4 = (float)(int)man.blendData[52] / 31f;
			break;
		case 14:
			num = 1f;
			num2 = 1f;
			num3 = 1f;
			num4 = (float)(man.blendData[48] + man.blendData[49]) / 31f / 2f;
			break;
		case 15:
			num = 1f;
			num2 = 1f;
			num3 = 1f;
			num4 = (float)(int)man.blendData[44] / 31f;
			break;
		case 16:
			num = 1f;
			num2 = 1f;
			num3 = 1f;
			num4 = (float)(int)man.blendData[45] / 31f;
			break;
		case 17:
			num = 1f;
			num2 = 1f;
			num3 = 1f;
			num4 = (float)(man.blendData[62] + man.blendData[63]) / 31f / 2f;
			break;
		case 18:
			num = 1f;
			num2 = 1f;
			num3 = 1f;
			num4 = (float)(int)man.blendData[46] / 31f;
			break;
		case 19:
			num = 1f;
			num2 = 1f;
			num3 = 1f;
			num4 = (float)(int)man.blendData[42] / 31f;
			break;
		case 20:
			num = 1f;
			num2 = 1f;
			num3 = 1f;
			num4 = (float)(int)man.blendData[43] / 31f;
			break;
		case 21:
			num = 1f;
			num2 = 1f;
			num3 = 1f;
			num4 = (float)(int)man.blendData[72] / 31f;
			break;
		case 22:
			num = (float)(int)man.blendData[24] / 31f;
			num2 = (float)(int)man.blendData[25] / 31f;
			num3 = (float)(int)man.blendData[26] / 31f;
			num4 = 0.33f;
			break;
		case 23:
			num = (float)(int)man.blendData[27] / 31f;
			num2 = (float)(int)man.blendData[28] / 31f;
			num3 = (float)(int)man.blendData[29] / 31f;
			num4 = 0.33f;
			break;
		case 24:
			num = (float)(int)man.blendData[30] / 31f;
			num2 = (float)(int)man.blendData[31] / 31f;
			num3 = (float)(int)man.blendData[32] / 31f;
			num4 = 1f;
			break;
		case 25:
			num = (float)(int)man.blendData[33] / 31f;
			num2 = (float)(int)man.blendData[34] / 31f;
			num3 = (float)(int)man.blendData[35] / 31f;
			num4 = 1f;
			break;
		case 26:
			num = (float)(int)man.blendData[36] / 31f;
			num2 = (float)(int)man.blendData[37] / 31f;
			num3 = (float)(int)man.blendData[38] / 31f;
			num4 = 1f;
			break;
		case 27:
			num = (float)(int)man.blendData[39] / 31f;
			num2 = (float)(int)man.blendData[40] / 31f;
			num3 = (float)(int)man.blendData[41] / 31f;
			num4 = 1f;
			break;
		case 28:
			num = 1f;
			num2 = 1f;
			num3 = 1f;
			num4 = 0.25f;
			break;
		case 29:
			num = 1f;
			num2 = 1f;
			num3 = 1f;
			num4 = 0.25f;
			break;
		case 30:
			num = (float)(int)man.blendData[24] / 31f;
			num2 = (float)(int)man.blendData[25] / 31f;
			num3 = (float)(int)man.blendData[26] / 31f;
			num4 = (float)(man.blendData[24] + man.blendData[25] + man.blendData[26]) / 31f / 3f;
			num4 *= 0.33f;
			break;
		case 31:
			num = (float)(int)man.blendData[27] / 31f;
			num2 = (float)(int)man.blendData[28] / 31f;
			num3 = (float)(int)man.blendData[29] / 31f;
			num4 = (float)(man.blendData[27] + man.blendData[28] + man.blendData[29]) / 31f / 3f;
			num4 *= 0.33f;
			break;
		default:
			num = 0f;
			num2 = 0f;
			num3 = 0f;
			num4 = 0f;
			break;
		}
		col.a = num4;
		col.r = num;
		col.g = num2;
		col.b = num3;
	}

	public void control()
	{
		for (int i = 0; i < m_LEDArray.Length; i++)
		{
			for (int j = 0; j < m_LEDColorArray[i].Length; j++)
			{
				setColor(out m_LEDColorArray[i][j], i);
			}
			m_LEDMeshArray[i].colors = m_LEDColorArray[i];
		}
	}
}
