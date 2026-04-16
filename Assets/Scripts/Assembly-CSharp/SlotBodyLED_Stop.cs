using UnityEngine;

public class SlotBodyLED_Stop
{
	public enum STATE
	{
		OFF = 0,
		RED = 1,
		BLUE = 2
	}

	private GameObject m_LED;

	private STATE m_State;

	public void init(int i)
	{
		if (i >= 0 && i < 3)
		{
			switch (i)
			{
			case 0:
				m_LED = GameObject.Find("kyoutai/sglg_button_L/sglg_button_L/Button_light_L");
				break;
			case 1:
				m_LED = GameObject.Find("kyoutai/sglg_button_C/sglg_button_C/Button_light_C");
				break;
			case 2:
				m_LED = GameObject.Find("kyoutai/sglg_button_R/sglg_button_R/Button_light_R");
				break;
			}
			setState(STATE.RED);
		}
	}

	private Color getColor(STATE state)
	{
		float num = 0f;
		float num2 = 0f;
		float num3 = 0f;
		float num4 = 0f;
		switch ((int)state)
		{
		case 0:
			num = 1f;
			num2 = 1f;
			num3 = 1f;
			num4 = 0f;
			break;
		case 1:
			num = 1f;
			num2 = 0f;
			num3 = 0f;
			num4 = 1f;
			break;
		case 2:
			num = 0f;
			num2 = 0f;
			num3 = 1f;
			num4 = 1f;
			break;
		default:
			num = 0f;
			num2 = 0f;
			num3 = 0f;
			num4 = 0f;
			break;
		}
		return new Color(num, num2, num3, num4);
	}

	public void setState(STATE state)
	{
		Mesh mesh = m_LED.GetComponent<MeshFilter>().mesh;
		Vector3[] vertices = mesh.vertices;
		Color[] array = new Color[vertices.Length];
		for (int i = 0; i < vertices.Length; i++)
		{
			array[i] = getColor(state);
		}
		mesh.colors = array;
	}
}
