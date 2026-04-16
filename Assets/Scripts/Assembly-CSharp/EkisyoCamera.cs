using UnityEngine;

public class EkisyoCamera : MonoBehaviour
{
	private Camera m_Camera;

	private bool m_First = true;

	private void Awake()
	{
		m_Camera = base.gameObject.GetComponent<Camera>();
		m_First = true;
	}

	private void LateUpdate()
	{
		if (m_First)
		{
			m_Camera.clearFlags = CameraClearFlags.Skybox;
			m_First = false;
		}
		if (SGLG.prod.isDrawNothing() && SGLG.prodImg.isDrawNothing() && SGLG.prodAnime.isDrawNothing())
		{
			m_Camera.clearFlags = CameraClearFlags.Nothing;
		}
		else
		{
			m_Camera.clearFlags = CameraClearFlags.Skybox;
		}
	}

	private void Update()
	{
	}
}
