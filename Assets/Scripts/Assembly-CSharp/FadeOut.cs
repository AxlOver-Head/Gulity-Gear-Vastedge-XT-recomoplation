using UnityEngine;

public class FadeOut : MonoBehaviour
{
	public bool transmission;

	private UISprite uis;

	private BoxCollider bc;

	private bool startFlg;

	private bool brightness;

	private GameObject call;

	private string method = string.Empty;

	private void Awake()
	{
		uis = base.gameObject.GetComponent<UISprite>();
		bc = base.gameObject.GetComponent<BoxCollider>();
		if (transmission)
		{
			uis.alpha = 0f;
			bc.enabled = false;
		}
		else
		{
			uis.alpha = 1f;
			bc.enabled = true;
		}
	}

	private void Start()
	{
	}

	private void Update()
	{
		if (!startFlg)
		{
			return;
		}
		if (brightness)
		{
			uis.alpha += 0.05f;
			if (uis.alpha >= 1f)
			{
				uis.alpha = 1f;
				startFlg = false;
				bc.enabled = false;
				if (method != string.Empty)
				{
					call.SendMessage(method);
				}
			}
			return;
		}
		uis.alpha -= 0.05f;
		if (uis.alpha <= 0f)
		{
			uis.alpha = 0f;
			startFlg = false;
			bc.enabled = false;
			if (method != string.Empty)
			{
				call.SendMessage(method);
			}
		}
	}

	public void StartFade(bool flg, GameObject obj, string name)
	{
		brightness = flg;
		startFlg = true;
		bc.enabled = true;
		call = obj;
		method = name;
	}

	public void SetAlpha(bool flg)
	{
		if (flg)
		{
			uis.alpha = 0f;
		}
		else
		{
			uis.alpha = 1f;
		}
	}
}
