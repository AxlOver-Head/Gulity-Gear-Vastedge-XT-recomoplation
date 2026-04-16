using UnityEngine;

public class EkisyoCamera_Front : MonoBehaviour
{
	private Camera m_Camera;

	private void Awake()
	{
		m_Camera = base.gameObject.GetComponent<Camera>();
	}

	private void LateUpdate()
	{
		if (SGLG.prod.isDrawNothing() && SGLG.prodImg.isDrawNothing() && SGLG.prodAnime.isDrawNothing())
		{
			m_Camera.enabled = false;
		}
		else
		{
			m_Camera.enabled = true;
		}
	}

	private void Update()
	{
	}
}
