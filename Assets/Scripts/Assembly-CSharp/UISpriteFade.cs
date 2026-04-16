using UnityEngine;

public class UISpriteFade : MonoBehaviour
{
	private float timer = 100f;

	private float timeEnd;

	private float endAlpha;

	private UISprite sprite;

	private UIPanel panel;

	private Color startCol = Color.white;

	private Color endCol = Color.white;

	private void Start()
	{
	}

	private void Update()
	{
		updateSpr();
		updatePanel();
	}

	private void updateSpr()
	{
		if (sprite == null || sprite.alpha == endAlpha)
		{
			return;
		}
		if (endAlpha > sprite.alpha)
		{
			sprite.alpha += endAlpha / timer;
			if (endAlpha <= sprite.alpha)
			{
				sprite.alpha = endAlpha;
				sprite = null;
			}
		}
		else
		{
			sprite.alpha -= startCol.a / timer;
			if (endAlpha >= sprite.alpha)
			{
				sprite.alpha = endAlpha;
				sprite = null;
			}
		}
	}

	private void updatePanel()
	{
		if (panel == null || panel.alpha == endAlpha)
		{
			return;
		}
		if (endAlpha > panel.alpha)
		{
			panel.alpha += endAlpha / timer;
			if (endAlpha <= panel.alpha)
			{
				panel.alpha = endAlpha;
				panel = null;
			}
		}
		else
		{
			panel.alpha -= startCol.a / timer;
			if (endAlpha >= panel.alpha)
			{
				panel.alpha = endAlpha;
				panel = null;
			}
		}
	}

	public void setSpriteFadeIn(UISprite spr, Color startColor, float end = 0f)
	{
		sprite = spr;
		startCol = spr.color;
		startCol.a = 1f;
		sprite.color = startColor;
		endAlpha = end;
	}

	public void setSpriteFadeOut(UISprite spr, Color startColor, float end = 1f)
	{
		sprite = spr;
		startCol = spr.color;
		startCol.a = 0f;
		sprite.color = startColor;
		sprite.alpha = 0f;
		endAlpha = end;
	}

	public void setPanelFadeIn(UIPanel p, float a = 0f)
	{
		panel = p;
		startCol.a = 1f;
		endAlpha = a;
	}

	public void setPanelFadeOut(UIPanel p, float a = 1f)
	{
		panel = p;
		startCol.a = 0f;
		endAlpha = a;
	}

	public void setTime(float t)
	{
		timer = t;
	}

	public bool isSprEnd()
	{
		return sprite == null || sprite.alpha == endAlpha;
	}

	public bool isPanelEnd()
	{
		return panel == null || panel.alpha == endAlpha;
	}
}
