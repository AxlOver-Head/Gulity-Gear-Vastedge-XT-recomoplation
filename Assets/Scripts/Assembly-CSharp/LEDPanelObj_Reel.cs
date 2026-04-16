using UnityEngine;

public class LEDPanelObj_Reel : LEDPanelObj
{
	public enum KIND
	{
		REEL_W_1 = 0,
		REEL_W_2 = 1,
		REEL_W_3 = 2,
		REEL_W_4 = 3,
		REEL_W_5 = 4,
		REEL_W_6 = 5,
		REEL_W_7 = 6,
		REEL_W_8 = 7,
		REEL_W_9 = 8,
		REEL_C_1 = 9,
		REEL_C_2 = 10,
		REEL_C_3 = 11,
		REEL_C_4 = 12,
		REEL_C_5 = 13,
		REEL_C_6 = 14,
		REEL_C_7 = 15,
		REEL_C_8 = 16,
		REEL_C_9 = 17,
		TOP_W1 = 18,
		TOP_W2 = 19,
		TOP_W3 = 20,
		TOP_C1 = 21,
		TOP_C2 = 22,
		TOP_C3 = 23,
		MAX = 24
	}

	public LEDPanelObj_Reel(LEDPanelManager _man)
		: base(_man)
	{
	}

	public void init()
	{
		m_LEDArray = new GameObject[24];
		m_LEDArray[0] = GameObject.Find("kyoutai/reel/Drum_L_under_light_t");
		m_LEDArray[1] = GameObject.Find("kyoutai/reel/Drum_L_under_light_m");
		m_LEDArray[2] = GameObject.Find("kyoutai/reel/Drum_L_under_light_b");
		m_LEDArray[3] = GameObject.Find("kyoutai/reel/Drum_C_under_light_t");
		m_LEDArray[4] = GameObject.Find("kyoutai/reel/Drum_C_under_light_m");
		m_LEDArray[5] = GameObject.Find("kyoutai/reel/Drum_C_under_light_b");
		m_LEDArray[6] = GameObject.Find("kyoutai/reel/Drum_R_under_light_t");
		m_LEDArray[7] = GameObject.Find("kyoutai/reel/Drum_R_under_light_m");
		m_LEDArray[8] = GameObject.Find("kyoutai/reel/Drum_R_under_light_b");
		m_LEDArray[9] = GameObject.Find("kyoutai/reel/Drum_L_under_light_t_c");
		m_LEDArray[10] = GameObject.Find("kyoutai/reel/Drum_L_under_light_m_c");
		m_LEDArray[11] = GameObject.Find("kyoutai/reel/Drum_L_under_light_b_c");
		m_LEDArray[12] = GameObject.Find("kyoutai/reel/Drum_C_under_light_t_c");
		m_LEDArray[13] = GameObject.Find("kyoutai/reel/Drum_C_under_light_m_c");
		m_LEDArray[14] = GameObject.Find("kyoutai/reel/Drum_C_under_light_b_c");
		m_LEDArray[15] = GameObject.Find("kyoutai/reel/Drum_R_under_light_t_c");
		m_LEDArray[16] = GameObject.Find("kyoutai/reel/Drum_R_under_light_m_c");
		m_LEDArray[17] = GameObject.Find("kyoutai/reel/Drum_R_under_light_b_c");
		m_LEDArray[18] = GameObject.Find("kyoutai/sglg_drum_top_light/drum_top_light_w_L");
		m_LEDArray[19] = GameObject.Find("kyoutai/sglg_drum_top_light/drum_top_light_w_C");
		m_LEDArray[20] = GameObject.Find("kyoutai/sglg_drum_top_light/drum_top_light_w_R");
		m_LEDArray[21] = GameObject.Find("kyoutai/sglg_drum_top_light/drum_top_light_c_L");
		m_LEDArray[22] = GameObject.Find("kyoutai/sglg_drum_top_light/drum_top_light_c_C");
		m_LEDArray[23] = GameObject.Find("kyoutai/sglg_drum_top_light/drum_top_light_c_R");
		setLEDColor();
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
			num4 = (float)(int)man.blendData[138] / 255f;
			break;
		case 1:
			num = 1f;
			num2 = 1f;
			num3 = 1f;
			num4 = (float)(int)man.blendData[142] / 255f;
			break;
		case 2:
			num = 1f;
			num2 = 1f;
			num3 = 1f;
			num4 = (float)(int)man.blendData[146] / 255f;
			break;
		case 3:
			num = 1f;
			num2 = 1f;
			num3 = 1f;
			num4 = (float)(int)man.blendData[150] / 255f;
			break;
		case 4:
			num = 1f;
			num2 = 1f;
			num3 = 1f;
			num4 = (float)(int)man.blendData[154] / 255f;
			break;
		case 5:
			num = 1f;
			num2 = 1f;
			num3 = 1f;
			num4 = (float)(int)man.blendData[158] / 255f;
			break;
		case 6:
			num = 1f;
			num2 = 1f;
			num3 = 1f;
			num4 = (float)(int)man.blendData[162] / 255f;
			break;
		case 7:
			num = 1f;
			num2 = 1f;
			num3 = 1f;
			num4 = (float)(int)man.blendData[166] / 255f;
			break;
		case 8:
			num = 1f;
			num2 = 1f;
			num3 = 1f;
			num4 = (float)(int)man.blendData[170] / 255f;
			break;
		case 9:
			num = (float)(int)man.blendData[139] / 255f;
			num2 = (float)(int)man.blendData[140] / 255f;
			num3 = (float)(int)man.blendData[141] / 255f;
			num4 = 1f;
			break;
		case 10:
			num = (float)(int)man.blendData[143] / 255f;
			num2 = (float)(int)man.blendData[144] / 255f;
			num3 = (float)(int)man.blendData[145] / 255f;
			num4 = 1f;
			break;
		case 11:
			num = (float)(int)man.blendData[147] / 255f;
			num2 = (float)(int)man.blendData[148] / 255f;
			num3 = (float)(int)man.blendData[149] / 255f;
			num4 = 1f;
			break;
		case 12:
			num = (float)(int)man.blendData[151] / 255f;
			num2 = (float)(int)man.blendData[152] / 255f;
			num3 = (float)(int)man.blendData[153] / 255f;
			num4 = 1f;
			break;
		case 13:
			num = (float)(int)man.blendData[155] / 255f;
			num2 = (float)(int)man.blendData[156] / 255f;
			num3 = (float)(int)man.blendData[157] / 255f;
			num4 = 1f;
			break;
		case 14:
			num = (float)(int)man.blendData[159] / 255f;
			num2 = (float)(int)man.blendData[160] / 255f;
			num3 = (float)(int)man.blendData[161] / 255f;
			num4 = 1f;
			break;
		case 15:
			num = (float)(int)man.blendData[163] / 255f;
			num2 = (float)(int)man.blendData[164] / 255f;
			num3 = (float)(int)man.blendData[165] / 255f;
			num4 = 1f;
			break;
		case 16:
			num = (float)(int)man.blendData[167] / 255f;
			num2 = (float)(int)man.blendData[168] / 255f;
			num3 = (float)(int)man.blendData[169] / 255f;
			num4 = 1f;
			break;
		case 17:
			num = (float)(int)man.blendData[171] / 255f;
			num2 = (float)(int)man.blendData[172] / 255f;
			num3 = (float)(int)man.blendData[173] / 255f;
			num4 = 1f;
			break;
		case 18:
		case 19:
		case 20:
			num = 1f;
			num2 = 1f;
			num3 = 1f;
			num4 = (float)(int)man.blendData[174] / 255f;
			break;
		case 21:
		case 22:
		case 23:
			num = (float)(int)man.blendData[175] / 255f;
			num2 = (float)(int)man.blendData[176] / 255f;
			num3 = (float)(int)man.blendData[177] / 255f;
			num4 = 1f;
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
