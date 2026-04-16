using UnityEngine;

public class WebBrowser : MonoBehaviour
{
	private GameObject m_ButtonBackOn;

	private GameObject m_ButtonForwardOn;

	private GameObject m_ButtonReload;

	private GameObject m_ButtonClose;

	public GameObject target;

	public string functionName;

	private bool m_IsEnd;

	private void Awake()
	{
		m_IsEnd = false;
		m_ButtonBackOn = GameObject.Find("Button_1b");
		m_ButtonForwardOn = GameObject.Find("Button_2b");
		m_ButtonReload = GameObject.Find("Button_3");
		m_ButtonClose = GameObject.Find("Button_4");
		m_ButtonBackOn.SetActive(false);
		m_ButtonForwardOn.SetActive(false);
		
		UIButtonMessage component = m_ButtonBackOn.GetComponent<UIButtonMessage>();
		component.target = base.gameObject;
		component.functionName = "OnClickEvent_Back";
		
		component = m_ButtonForwardOn.GetComponent<UIButtonMessage>();
		component.target = base.gameObject;
		component.functionName = "OnClickEvent_Forward";
		
		component = m_ButtonReload.GetComponent<UIButtonMessage>();
		component.target = base.gameObject;
		component.functionName = "OnClickEvent_Reload";
		
		component = m_ButtonClose.GetComponent<UIButtonMessage>();
		component.target = base.gameObject;
		component.functionName = "OnClickEvent_Close";
		
		SGLG.m_Scene.OnBrowseEvent_Start();
		base.gameObject.SetActive(false);
	}

	private void Start()
	{
	}

	private void Update()
	{
		if (m_IsEnd)
		{
			if (SGLG.isFadeOutComplete())
			{
				SGLG.isBrowsing = false;
				SGLG.m_Scene.OnBrowseEvent_Close();
				SGLG.endFade();
				Object.Destroy(base.gameObject);
				SGLG.browser = null;
			}
		}
		else
		{
			// With Application.OpenURL, we can't control back/forward in-app
			// So these buttons are disabled
			m_ButtonBackOn.SetActive(false);
			m_ButtonForwardOn.SetActive(false);
		}
	}

	private void OnClickEvent_Back()
	{
		// Browser navigation not supported with Application.OpenURL
		Debug.LogWarning("Back button not supported - browser opens in system browser");
	}

	private void OnClickEvent_Forward()
	{
		// Browser navigation not supported with Application.OpenURL
		Debug.LogWarning("Forward button not supported - browser opens in system browser");
	}

	private void OnClickEvent_Reload()
	{
		// Browser navigation not supported with Application.OpenURL
		Debug.LogWarning("Reload button not supported - browser opens in system browser");
	}

	private void OnClickEvent_Close()
	{
		Close();
	}

	public void OpenURL(string url)
	{
		// Use Unity's built-in method to open URL in system browser
		Application.OpenURL(url);
		Close();
	}

	private void Close()
	{
		if (!SGLG.isFading && !m_IsEnd)
		{
			m_IsEnd = true;
			SGLG.startFade();
		}
	}
}