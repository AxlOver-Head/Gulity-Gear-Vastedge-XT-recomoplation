using UnityEngine;

public class LEDMainObj_Logo : LEDMainObj
{
	public enum KIND
	{
		LOGO = 0,
		MAX = 1
	}

	public LEDMainObj_Logo(LEDMainManager _man)
		: base(_man)
	{
		m_LEDArray = new GameObject[1];
		m_LEDArray[0] = GameObject.Find("kyoutai/sglg_logo/sglg_logo_light");
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
		if (i == 0)
		{
			switch (j)
			{
			case 0:
			case 1:
			case 2:
			case 3:
				r = (float)(int)man.blendData[75] / 31f;
				g = (float)(int)man.blendData[76] / 31f;
				b = (float)(int)man.blendData[77] / 31f;
				a = 1f;
				break;
			case 4:
			case 5:
			case 6:
			case 7:
				r = (float)(int)man.blendData[78] / 31f;
				g = (float)(int)man.blendData[79] / 31f;
				b = (float)(int)man.blendData[80] / 31f;
				a = 1f;
				break;
			case 8:
			case 9:
			case 10:
			case 11:
				r = (float)(int)man.blendData[81] / 31f;
				g = (float)(int)man.blendData[82] / 31f;
				b = (float)(int)man.blendData[83] / 31f;
				a = 1f;
				break;
			case 12:
			case 13:
			case 14:
			case 15:
				r = (float)(int)man.blendData[84] / 31f;
				g = (float)(int)man.blendData[85] / 31f;
				b = (float)(int)man.blendData[86] / 31f;
				a = 1f;
				break;
			case 16:
			case 17:
			case 18:
			case 19:
				r = (float)(int)man.blendData[87] / 31f;
				g = (float)(int)man.blendData[88] / 31f;
				b = (float)(int)man.blendData[89] / 31f;
				a = 1f;
				break;
			case 20:
			case 21:
			case 22:
			case 23:
				r = (float)(int)man.blendData[90] / 31f;
				g = (float)(int)man.blendData[91] / 31f;
				b = (float)(int)man.blendData[92] / 31f;
				a = 1f;
				break;
			case 24:
			case 25:
			case 26:
			case 27:
				r = (float)(int)man.blendData[93] / 31f;
				g = (float)(int)man.blendData[94] / 31f;
				b = (float)(int)man.blendData[95] / 31f;
				a = 1f;
				break;
			case 28:
			case 29:
			case 30:
			case 31:
				r = (float)(int)man.blendData[96] / 31f;
				g = (float)(int)man.blendData[97] / 31f;
				b = (float)(int)man.blendData[98] / 31f;
				a = 1f;
				break;
			case 32:
			case 33:
			case 34:
			case 35:
				r = (float)(int)man.blendData[99] / 31f;
				g = (float)(int)man.blendData[100] / 31f;
				b = (float)(int)man.blendData[101] / 31f;
				a = 1f;
				break;
			case 36:
			case 37:
			case 38:
			case 39:
				r = (float)(int)man.blendData[102] / 31f;
				g = (float)(int)man.blendData[103] / 31f;
				b = (float)(int)man.blendData[104] / 31f;
				a = 1f;
				break;
			case 40:
			case 41:
			case 42:
			case 43:
				r = (float)(int)man.blendData[105] / 31f;
				g = (float)(int)man.blendData[106] / 31f;
				b = (float)(int)man.blendData[107] / 31f;
				a = 1f;
				break;
			case 44:
			case 45:
			case 46:
			case 47:
				r = (float)(int)man.blendData[108] / 31f;
				g = (float)(int)man.blendData[109] / 31f;
				b = (float)(int)man.blendData[110] / 31f;
				a = 1f;
				break;
			case 48:
			case 49:
			case 50:
			case 51:
				r = (float)(int)man.blendData[111] / 31f;
				g = (float)(int)man.blendData[112] / 31f;
				b = (float)(int)man.blendData[113] / 31f;
				a = 1f;
				break;
			case 52:
			case 53:
			case 54:
			case 55:
				r = (float)(int)man.blendData[114] / 31f;
				g = (float)(int)man.blendData[115] / 31f;
				b = (float)(int)man.blendData[116] / 31f;
				a = 1f;
				break;
			case 56:
			case 57:
			case 58:
			case 59:
				r = (float)(int)man.blendData[117] / 31f;
				g = (float)(int)man.blendData[118] / 31f;
				b = (float)(int)man.blendData[119] / 31f;
				a = 1f;
				break;
			case 60:
			case 61:
			case 62:
			case 63:
				r = (float)(int)man.blendData[120] / 31f;
				g = (float)(int)man.blendData[121] / 31f;
				b = (float)(int)man.blendData[122] / 31f;
				a = 1f;
				break;
			case 64:
			case 65:
			case 66:
			case 67:
				r = (float)(int)man.blendData[123] / 31f;
				g = (float)(int)man.blendData[124] / 31f;
				b = (float)(int)man.blendData[125] / 31f;
				a = 1f;
				break;
			default:
				r = 0f;
				g = 0f;
				b = 0f;
				a = 0f;
				break;
			}
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
