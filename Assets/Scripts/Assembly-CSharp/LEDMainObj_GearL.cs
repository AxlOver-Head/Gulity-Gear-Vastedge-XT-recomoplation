using UnityEngine;

public class LEDMainObj_GearL : LEDMainObj
{
	public enum KIND
	{
		L01 = 0,
		L02 = 1,
		L03 = 2,
		MAX = 3
	}

	public LEDMainObj_GearL(LEDMainManager _man)
		: base(_man)
	{
		m_LEDArray = new GameObject[3];
		m_LEDArray[0] = GameObject.Find("kyoutai/sglg_gear_dai_light/gia_dai_light_001");
		m_LEDArray[1] = GameObject.Find("kyoutai/sglg_gear_dai_light/gia_dai_light_002");
		m_LEDArray[2] = GameObject.Find("kyoutai/sglg_gear_dai_light/gia_dai_light_003");
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
			num = (float)(int)man.blendData[146] / 31f;
			num2 = (float)(int)man.blendData[147] / 31f;
			num3 = (float)(int)man.blendData[148] / 31f;
			num4 = 1f;
			break;
		case 1:
			num = (float)(int)man.blendData[149] / 31f;
			num2 = (float)(int)man.blendData[150] / 31f;
			num3 = (float)(int)man.blendData[151] / 31f;
			num4 = 1f;
			break;
		case 2:
			num = (float)(man.blendData[146] + man.blendData[149]) / 31f / 2f;
			num2 = (float)(man.blendData[147] + man.blendData[150]) / 31f / 2f;
			num3 = (float)(man.blendData[148] + man.blendData[151]) / 31f / 2f;
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
