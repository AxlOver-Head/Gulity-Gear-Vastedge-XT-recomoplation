using UnityEngine;

public class LEDMainObj_Jyd : LEDMainObj
{
	public enum KIND
	{
		JYD01 = 0,
		JYD02 = 1,
		JYD03 = 2,
		JYD04 = 3,
		JYD05 = 4,
		MAX = 5
	}

	public LEDMainObj_Jyd(LEDMainManager _man)
		: base(_man)
	{
		m_LEDArray = new GameObject[5];
		m_LEDArray[0] = GameObject.Find("kyoutai/sglg_JYD/gun_ue_N/sglg_JYD_light/JYD_light_01");
		m_LEDArray[1] = GameObject.Find("kyoutai/sglg_JYD/gun_ue_N/sglg_JYD_light/JYD_light_02");
		m_LEDArray[2] = GameObject.Find("kyoutai/sglg_JYD/gun_ue_N/sglg_JYD_light/JYD_light_03");
		m_LEDArray[3] = GameObject.Find("kyoutai/sglg_JYD/gun_ue_N/sglg_JYD_light/JYD_light_04");
		m_LEDArray[4] = GameObject.Find("kyoutai/sglg_JYD/gun_ue_N/sglg_JYD_light/JYD_light_05");
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
			num = (float)(int)man.blendData[188] / 31f;
			num2 = (float)(int)man.blendData[189] / 31f;
			num3 = (float)(int)man.blendData[190] / 31f;
			num4 = 1f;
			break;
		case 1:
			num = (float)(int)man.blendData[191] / 31f;
			num2 = (float)(int)man.blendData[192] / 31f;
			num3 = (float)(int)man.blendData[193] / 31f;
			num4 = 1f;
			break;
		case 2:
			num = (float)(int)man.blendData[194] / 31f;
			num2 = (float)(int)man.blendData[195] / 31f;
			num3 = (float)(int)man.blendData[196] / 31f;
			num4 = 1f;
			break;
		case 3:
			num = (float)(int)man.blendData[197] / 31f;
			num2 = (float)(int)man.blendData[198] / 31f;
			num3 = (float)(int)man.blendData[199] / 31f;
			num4 = 1f;
			break;
		case 4:
			num = (float)(int)man.blendData[200] / 31f;
			num2 = (float)(int)man.blendData[201] / 31f;
			num3 = (float)(int)man.blendData[202] / 31f;
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
