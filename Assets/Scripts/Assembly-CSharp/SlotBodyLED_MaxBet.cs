using UnityEngine;

public class SlotBodyLED_MaxBet
{
	public enum STATE
	{
		OFF = 0,
		ON = 1
	}

	private GameObject m_LED;

	private STATE m_State;

	public void init()
	{
		m_LED = GameObject.Find("kyoutai/sglg_maxbet/Maxbet_light");
		setState(STATE.ON);
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
			num2 = 1f;
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
