using UnityEngine;

public class LEDMainObj
{
	protected LEDMainManager man;

	protected GameObject[] m_LEDArray;

	protected Mesh[] m_LEDMeshArray;

	protected Color[][] m_LEDColorArray;

	public LEDMainObj(LEDMainManager _man)
	{
		man = _man;
	}

	protected void setLEDColor()
	{
		m_LEDColorArray = new Color[m_LEDArray.Length][];
		m_LEDMeshArray = new Mesh[m_LEDArray.Length];
		for (int i = 0; i < m_LEDArray.Length; i++)
		{
			m_LEDMeshArray[i] = m_LEDArray[i].GetComponent<MeshFilter>().mesh;
			Vector3[] vertices = m_LEDMeshArray[i].vertices;
			m_LEDColorArray[i] = new Color[vertices.Length];
		}
	}
}
