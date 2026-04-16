using UnityEngine;

public class MainObjPayMedal : MonoBehaviour
{
	private float m_AddX = 0.01f;

	private float m_AddZ = 0.025f;

	private float MINUS_Z = 0.00175f;

	private float MINUS_X = 0.0005f;

	private float m_Alpha;

	private int m_Cnt;

	private int X_COUNT = 4;

	public bool m_Active = true;

	private Mesh mesh;

	private Vector3[] vertices;

	private Color[] colors;

	public void init()
	{
		int num = Random.Range(0, 201);
		m_AddX -= (float)num / 10000f;
		m_Alpha = 0f;
		m_Cnt = 0;
		m_Active = true;
		mesh = base.gameObject.GetComponent<MeshFilter>().mesh;
		vertices = mesh.vertices;
		colors = new Color[vertices.Length];
	}

	public void control()
	{
		float num = base.gameObject.transform.position.x;
		float y = base.gameObject.transform.position.y;
		float z = base.gameObject.transform.position.z + m_AddZ;
		if (m_Cnt >= X_COUNT)
		{
			num += m_AddX;
		}
		base.gameObject.transform.position = new Vector3(num, y, z);
		m_AddZ -= MINUS_Z;
		if (m_AddZ < 0f)
		{
			m_AddZ = 0f;
		}
		if (m_Cnt >= X_COUNT)
		{
			if (m_AddX > 0f)
			{
				m_AddX -= MINUS_X;
				if (m_AddX < 0f)
				{
					m_AddX = 0f;
				}
			}
			else if (m_AddX < 0f)
			{
				m_AddX += MINUS_X;
				if (m_AddX > 0f)
				{
					m_AddX = 0f;
				}
			}
		}
		if (m_Cnt >= 20)
		{
			float a = 1f - m_Alpha;
			float r = 1f;
			float g = 1f;
			float b = 1f;
			for (int i = 0; i < vertices.Length; i++)
			{
				colors[i] = new Color(r, g, b, a);
			}
			mesh.colors = colors;
			m_Alpha += 0.1f;
			if (m_Alpha >= 1f)
			{
				m_Active = false;
			}
		}
		m_Cnt++;
	}
}
