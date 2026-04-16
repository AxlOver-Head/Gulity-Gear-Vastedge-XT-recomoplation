using UnityEngine;

public class LEDMainObj_Body : LEDMainObj
{
	public enum KIND
	{
		GEAR_L = 0,
		GEAR_M = 1,
		EYE = 2,
		MAX = 3
	}

	public LEDMainObj_Body(LEDMainManager _man)
		: base(_man)
	{
		m_LEDArray = new GameObject[3];
		m_LEDArray[0] = GameObject.Find("kyoutai/body/LED/Body/gear_L");
		m_LEDArray[1] = GameObject.Find("kyoutai/body/LED/Body/gear_M");
		m_LEDArray[2] = GameObject.Find("kyoutai/body/LED/Body/eye");
		setLEDColor();
	}

	public void init()
	{
	}

	private void setColor(out Color col, int i, int j)
	{
		float r = 0f;
		float g = 0f;
		float b = 0f;
		float a = 0f;
		switch (i)
		{
		case 0:
			switch (j)
			{
			case 0:
			case 1:
			case 2:
				r = 1f;
				g = 1f;
				b = 1f;
				a = (float)(int)man.blendData[141] / 31f;
				break;
			case 3:
			case 4:
			case 5:
				r = 1f;
				g = 1f;
				b = 1f;
				a = (float)(int)man.blendData[142] / 31f;
				break;
			case 6:
			case 7:
			case 8:
				r = 1f;
				g = 1f;
				b = 1f;
				a = (float)(int)man.blendData[143] / 31f;
				break;
			case 9:
			case 10:
			case 11:
				r = 1f;
				g = 1f;
				b = 1f;
				a = (float)(int)man.blendData[144] / 31f;
				break;
			case 12:
			case 13:
			case 14:
				r = 1f;
				g = 1f;
				b = 1f;
				a = (float)(int)man.blendData[145] / 31f;
				break;
			case 15:
			case 16:
			case 17:
				r = (float)(int)man.blendData[126] / 31f;
				g = (float)(int)man.blendData[127] / 31f;
				b = (float)(int)man.blendData[128] / 31f;
				a = 1f;
				break;
			case 18:
			case 19:
			case 20:
				r = (float)(int)man.blendData[129] / 31f;
				g = (float)(int)man.blendData[130] / 31f;
				b = (float)(int)man.blendData[131] / 31f;
				a = 1f;
				break;
			case 21:
			case 22:
			case 23:
				r = (float)(int)man.blendData[132] / 31f;
				g = (float)(int)man.blendData[133] / 31f;
				b = (float)(int)man.blendData[134] / 31f;
				a = 1f;
				break;
			case 24:
			case 25:
			case 26:
				r = (float)(int)man.blendData[135] / 31f;
				g = (float)(int)man.blendData[136] / 31f;
				b = (float)(int)man.blendData[137] / 31f;
				a = 1f;
				break;
			case 27:
			case 28:
			case 29:
				r = (float)(int)man.blendData[138] / 31f;
				g = (float)(int)man.blendData[139] / 31f;
				b = (float)(int)man.blendData[140] / 31f;
				a = 1f;
				break;
			default:
				r = 0f;
				g = 0f;
				b = 0f;
				a = 0f;
				break;
			}
			break;
		case 1:
			switch (j)
			{
			case 0:
			case 1:
			case 2:
			case 3:
				r = (float)(int)man.blendData[152] / 31f;
				g = (float)(int)man.blendData[153] / 31f;
				b = (float)(int)man.blendData[154] / 31f;
				a = 1f;
				break;
			case 4:
			case 5:
			case 6:
			case 7:
				r = (float)(int)man.blendData[155] / 31f;
				g = (float)(int)man.blendData[156] / 31f;
				b = (float)(int)man.blendData[157] / 31f;
				a = 1f;
				break;
			case 8:
			case 9:
			case 10:
			case 11:
				r = (float)(int)man.blendData[167] / 31f;
				g = (float)(int)man.blendData[168] / 31f;
				b = (float)(int)man.blendData[169] / 31f;
				a = 1f;
				break;
			default:
				r = 0f;
				g = 0f;
				b = 0f;
				a = 0f;
				break;
			}
			break;
		case 2:
			switch (j)
			{
			case 0:
			case 1:
			case 2:
			case 3:
				r = (float)(int)man.blendData[9] / 31f;
				g = (float)(int)man.blendData[10] / 31f;
				b = (float)(int)man.blendData[11] / 31f;
				a = 1f;
				break;
			case 4:
			case 5:
			case 6:
			case 7:
			case 8:
			case 9:
			case 10:
			case 11:
			case 12:
			case 13:
			case 14:
			case 15:
			case 16:
			case 17:
			case 18:
				r = (float)(int)man.blendData[3] / 31f;
				g = (float)(int)man.blendData[4] / 31f;
				b = (float)(int)man.blendData[5] / 31f;
				a = 1f;
				break;
			case 19:
			case 20:
			case 21:
				r = (float)(int)man.blendData[6] / 31f;
				g = (float)(int)man.blendData[7] / 31f;
				b = (float)(int)man.blendData[8] / 31f;
				a = 1f;
				break;
			case 22:
			case 23:
			case 24:
			case 25:
			case 26:
				r = (float)(int)man.blendData[21] / 31f;
				g = (float)(int)man.blendData[22] / 31f;
				b = (float)(int)man.blendData[23] / 31f;
				a = 1f;
				break;
			case 27:
			case 28:
			case 29:
			case 30:
			case 31:
			case 32:
			case 33:
			case 34:
			case 35:
			case 36:
			case 37:
			case 38:
			case 39:
			case 40:
			case 41:
				r = (float)(int)man.blendData[15] / 31f;
				g = (float)(int)man.blendData[16] / 31f;
				b = (float)(int)man.blendData[17] / 31f;
				a = 1f;
				break;
			case 42:
			case 43:
			case 44:
				r = (float)(int)man.blendData[18] / 31f;
				g = (float)(int)man.blendData[19] / 31f;
				b = (float)(int)man.blendData[20] / 31f;
				a = 1f;
				break;
			default:
				r = 0f;
				g = 0f;
				b = 0f;
				a = 0f;
				break;
			}
			break;
		}
		col.a = a;
		col.r = r;
		col.g = g;
		col.b = b;
	}

	public void control()
	{
		for (int i = 0; i < m_LEDArray.Length; i++)
		{
			for (int j = 0; j < m_LEDColorArray[i].Length; j++)
			{
				setColor(out m_LEDColorArray[i][j], i, j);
			}
			m_LEDMeshArray[i].colors = m_LEDColorArray[i];
		}
	}
}
