using UnityEngine;

public class LEDMainObj_GearM : LEDMainObj
{
	public enum KIND
	{
		GEAR_01 = 0,
		GEAR_02 = 1,
		GEAR_03 = 2,
		MAX = 3
	}

	public LEDMainObj_GearM(LEDMainManager _man)
		: base(_man)
	{
		m_LEDArray = new GameObject[3];
		m_LEDArray[0] = GameObject.Find("kyoutai/sglg_gear_tyu_LR/gear_cyu/sglg_gear_tyu_light/gear_tyu_light_01");
		m_LEDArray[1] = GameObject.Find("kyoutai/sglg_gear_tyu_LR/gear_cyu/sglg_gear_tyu_light/gear_tyu_light_02");
		m_LEDArray[2] = GameObject.Find("kyoutai/sglg_gear_tyu_LR/gear_cyu/sglg_gear_tyu_light/gear_tyu_light_03");
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
			num = (float)(int)man.blendData[158] / 31f;
			num2 = (float)(int)man.blendData[159] / 31f;
			num3 = (float)(int)man.blendData[160] / 31f;
			num4 = 1f;
			break;
		case 1:
			num = (float)(int)man.blendData[164] / 31f;
			num2 = (float)(int)man.blendData[165] / 31f;
			num3 = (float)(int)man.blendData[166] / 31f;
			num4 = 1f;
			break;
		case 2:
			num = (float)(int)man.blendData[161] / 31f;
			num2 = (float)(int)man.blendData[162] / 31f;
			num3 = (float)(int)man.blendData[163] / 31f;
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
