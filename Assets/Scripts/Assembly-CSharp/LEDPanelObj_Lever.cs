using UnityEngine;

public class LEDPanelObj_Lever : LEDPanelObj
{
	public enum KIND
	{
		LEVER = 0,
		MAX = 1
	}

	public LEDPanelObj_Lever(LEDPanelManager _man)
		: base(_man)
	{
	}

	public void init()
	{
		m_LEDArray = new GameObject[1];
		m_LEDArray[0] = GameObject.Find("kyoutai/sglg_lever/Lever_light");
		setLEDColor();
	}

	private void setColor(out Color col, int _id)
	{
		float num = 0f;
		float num2 = 0f;
		float num3 = 0f;
		float num4 = 0f;
		if (_id == 0)
		{
			num = (float)(int)man.blendData[0] / 255f * 0.5f;
			num2 = (float)(int)man.blendData[1] / 255f * 0.5f;
			num3 = (float)(int)man.blendData[2] / 255f * 0.5f;
			num4 = 1f;
		}
		else
		{
			num = 0f;
			num2 = 0f;
			num3 = 0f;
			num4 = 0f;
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
