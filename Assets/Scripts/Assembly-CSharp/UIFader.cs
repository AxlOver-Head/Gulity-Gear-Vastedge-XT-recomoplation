using UnityEngine;

public class UIFader : MonoBehaviour
{
	public bool isEnding;

	public int current;

	public static readonly float ALPHA_ADD_FADE = 0.025f;

	public static readonly float ALPHA_ADD_FAST = 0.0625f;

	private float fadeAlpha;

	public static float fadeSpeed = ALPHA_ADD_FADE;

	public UIWidget WI_Fade;

	private void Awake()
	{
		isEnding = false;
		current = 0;
		fadeAlpha = 0f;
		Object.DontDestroyOnLoad(base.gameObject);
	}

	public void init()
	{
		GameObject gameObject = GameObject.Find("Fader(Clone)/Camera/Anchor/Panel/Fade");
		WI_Fade = gameObject.GetComponent<UIWidget>();
	}

	private void Update()
	{
		switch (current)
		{
		case 0:
			fadeAlpha += fadeSpeed * 60f * SGLG.deltaTime;
			if (fadeAlpha >= 1f)
			{
				fadeAlpha = 1f;
				current++;
			}
			break;
		case 1:
			if (isEnding)
			{
				current++;
			}
			break;
		case 2:
			fadeAlpha -= fadeSpeed * 60f * SGLG.deltaTime;
			if (fadeAlpha <= 0f)
			{
				fadeAlpha = 0f;
				current++;
			}
			break;
		case 3:
			Object.Destroy(base.gameObject);
			SGLG.fader = null;
			SGLG.isFading = false;
			return;
		}
		WI_Fade.color = new Color(0f, 0f, 0f, fadeAlpha);
	}

	public bool isFadeOutComplete()
	{
		return current == 1;
	}

	public void end()
	{
		isEnding = true;
	}
}
