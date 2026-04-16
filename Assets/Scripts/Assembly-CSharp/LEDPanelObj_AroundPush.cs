using UnityEngine;

public class LEDPanelObj_AroundPush : LEDPanelObj
{
	public enum KIND
	{
		AROUNDPUSH = 0,
		MAX = 1
	}

	public LEDPanelObj_AroundPush(LEDPanelManager _man)
		: base(_man)
	{
	}

	public void init()
	{
		m_LEDArray = new GameObject[1];
		m_LEDArray[0] = GameObject.Find("kyoutai/body/LED/AroundPush");
		setLEDColor();
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
				r = (float)(int)man.blendData[108] / 255f;
				g = (float)(int)man.blendData[109] / 255f;
				b = (float)(int)man.blendData[110] / 255f;
				a = 1f;
				break;
			case 4:
			case 5:
			case 6:
			case 7:
				r = (float)(int)man.blendData[111] / 255f;
				g = (float)(int)man.blendData[112] / 255f;
				b = (float)(int)man.blendData[113] / 255f;
				a = 1f;
				break;
			case 8:
			case 9:
			case 10:
			case 11:
				r = (float)(int)man.blendData[123] / 255f;
				g = (float)(int)man.blendData[124] / 255f;
				b = (float)(int)man.blendData[125] / 255f;
				a = 1f;
				break;
			case 12:
			case 13:
			case 14:
			case 15:
				r = (float)(int)man.blendData[120] / 255f;
				g = (float)(int)man.blendData[121] / 255f;
				b = (float)(int)man.blendData[122] / 255f;
				a = 1f;
				break;
			case 16:
			case 17:
			case 18:
			case 19:
			case 20:
				r = (float)(int)man.blendData[117] / 255f;
				g = (float)(int)man.blendData[118] / 255f;
				b = (float)(int)man.blendData[119] / 255f;
				a = 1f;
				break;
			case 21:
			case 22:
			case 23:
			case 24:
				r = (float)(int)man.blendData[114] / 255f;
				g = (float)(int)man.blendData[115] / 255f;
				b = (float)(int)man.blendData[116] / 255f;
				a = 1f;
				break;
			case 25:
			case 26:
			case 27:
				r = (float)(int)man.blendData[126] / 255f;
				g = (float)(int)man.blendData[127] / 255f;
				b = (float)(int)man.blendData[128] / 255f;
				a = 1f;
				break;
			case 28:
			case 29:
			case 30:
			case 31:
			case 32:
				r = (float)(int)man.blendData[129] / 255f;
				g = (float)(int)man.blendData[130] / 255f;
				b = (float)(int)man.blendData[131] / 255f;
				a = 1f;
				break;
			case 33:
			case 34:
			case 35:
			case 36:
				r = (float)(int)man.blendData[132] / 255f;
				g = (float)(int)man.blendData[133] / 255f;
				b = (float)(int)man.blendData[134] / 255f;
				a = 1f;
				break;
			case 37:
			case 38:
			case 39:
			case 40:
				r = (float)(int)man.blendData[135] / 255f;
				g = (float)(int)man.blendData[136] / 255f;
				b = (float)(int)man.blendData[137] / 255f;
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
