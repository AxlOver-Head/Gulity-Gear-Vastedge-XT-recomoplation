using UnityEngine;

public class UILoading : MonoBehaviour
{
	public bool isEnding;

	public int current;

	private static readonly float ALPHA_ADD_FADE = 0.05f;

	public float fadeAlpha;

	private int m_Cnt;

	private bool prepared;

	public static readonly int LOAD_START = 90;

	public bool loadStart;

	private GameObject UI_BG;

	private GameObject UI_Chain_0a;

	private GameObject UI_Chain_1a;

	private GameObject UI_Rolling;

	private GameObject UI_Loading;

	private GameObject UI_Ribo;

	private UIWidget WI_Fade;

	private UISprite Sp_Loading;

	private static string[] spriteTable = new string[4] { "loading_moji5", "loading_moji5_1", "loading_moji5_2", "loading_moji5_3" };

	private void Awake()
	{
		isEnding = false;
		prepared = false;
		loadStart = false;
		current = 0;
		fadeAlpha = 0f;
		m_Cnt = 0;
		Object.DontDestroyOnLoad(base.gameObject);
		SGLG.isSceneChange = true;
	}

	public void init()
	{
		UI_BG = GameObject.Find("Loading(Clone)/Camera/Anchor/Panel/BG");
		UI_Chain_0a = GameObject.Find("Loading(Clone)/Camera/Anchor/Panel/Chain_0a");
		UI_Chain_1a = GameObject.Find("Loading(Clone)/Camera/Anchor/Panel/Chain_1a");
		UI_Rolling = GameObject.Find("Loading(Clone)/Camera/Anchor/Panel/Rolling");
		UI_Loading = GameObject.Find("Loading(Clone)/Camera/Anchor/Panel/Loading");
		UI_Ribo = GameObject.Find("Loading(Clone)/Camera/Anchor/Panel/Ribo");
		WI_Fade = GameObject.Find("Loading(Clone)/Camera/Anchor/Panel/Fade").GetComponent<UIWidget>();
		Sp_Loading = UI_Loading.GetComponent<UISprite>();
		prepared = true;
		setVisible(false);
	}

	private void setVisible(bool _flag)
	{
		UI_BG.SetActiveRecursively(_flag);
		UI_Chain_0a.SetActiveRecursively(_flag);
		UI_Chain_1a.SetActiveRecursively(_flag);
		UI_Rolling.SetActiveRecursively(_flag);
		UI_Loading.SetActiveRecursively(_flag);
		UI_Ribo.SetActiveRecursively(_flag);
	}

	private void move()
	{
		int num = m_Cnt / 8 % 4;
		Sp_Loading.spriteName = spriteTable[num];
		m_Cnt++;
	}

	private void Update()
	{
		if (!prepared)
		{
			return;
		}
		switch (current)
		{
		case 0:
			fadeAlpha += ALPHA_ADD_FADE * 60f * SGLG.deltaTime;
			if (fadeAlpha >= 1f)
			{
				setVisible(true);
				fadeAlpha = 1f;
				current++;
			}
			break;
		case 1:
			fadeAlpha -= ALPHA_ADD_FADE * 60f * SGLG.deltaTime;
			if (fadeAlpha <= 0f)
			{
				fadeAlpha = 0f;
				current++;
			}
			move();
			break;
		case 2:
			if (m_Cnt >= LOAD_START)
			{
				loadStart = true;
			}
			if (isEnding && loadStart)
			{
				current++;
			}
			move();
			break;
		case 3:
			if (!SGLG.isSceneChange)
			{
				current++;
			}
			move();
			break;
		case 4:
			fadeAlpha += ALPHA_ADD_FADE * 60f * SGLG.deltaTime;
			if (fadeAlpha >= 1f)
			{
				setVisible(false);
				fadeAlpha = 1f;
				current++;
			}
			move();
			break;
		case 5:
			fadeAlpha -= ALPHA_ADD_FADE * 60f * SGLG.deltaTime;
			if (fadeAlpha <= 0f)
			{
				fadeAlpha = 0f;
				current++;
			}
			break;
		case 6:
			UI_BG = null;
			UI_Chain_0a = null;
			UI_Chain_1a = null;
			UI_Rolling = null;
			UI_Loading = null;
			UI_Ribo = null;
			WI_Fade = null;
			Sp_Loading = null;
			SGLG.isLoading = false;
			SGLG.loading = null;
			Object.Destroy(base.gameObject);
			Resources.UnloadUnusedAssets();
			return;
		}
		WI_Fade.color = new Color(0f, 0f, 0f, fadeAlpha);
	}

	public void end()
	{
		isEnding = true;
	}
}
