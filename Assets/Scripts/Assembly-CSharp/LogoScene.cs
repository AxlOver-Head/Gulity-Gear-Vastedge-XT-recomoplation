using UnityEngine;

public class LogoScene : SceneUpdater
{
	private enum STATE
	{
		LOGO1_FADEIN = 0,
		LOGO1_WAIT = 1,
		LOGO1_FADEOUT = 2,
		LOGO2_FADEIN = 3,
		LOGO2_WAIT = 4,
		LOGO2_FADEOUT = 5
	}

	private GameObject m_Logo1;

	private GameObject m_Logo2;

	private static readonly int LOGO_WAIT = 30;

	private STATE m_Current;

	private int m_CurrentCnt;

	private void setCurrent(STATE _cur)
	{
		m_Current = _cur;
		m_CurrentCnt = 0;
	}

	private void Start()
	{
		SGLG.m_Scene = (LogoScene)base.gameObject.GetComponent("LogoScene");
	}

	public override void init()
	{
		m_Current = STATE.LOGO1_FADEIN;
		m_Logo1 = GameObject.Find("Logo/Camera/Anchor/Panel/Logo1");
		m_Logo2 = GameObject.Find("Logo/Camera/Anchor/Panel/Logo2");
		m_Logo1.SetActive(true);
		m_Logo2.SetActive(false);
		SGLG.endFade();
		m_IsOK = true;
	}

	public override void control()
	{
		if (!m_IsOK)
		{
			return;
		}
		switch (m_Current)
		{
		case STATE.LOGO1_FADEIN:
			if (!SGLG.isFading)
			{
				setCurrent(STATE.LOGO1_WAIT);
			}
			break;
		case STATE.LOGO1_WAIT:
			if (m_CurrentCnt >= LOGO_WAIT)
			{
				SGLG.startFade();
				setCurrent(STATE.LOGO1_FADEOUT);
			}
			break;
		case STATE.LOGO1_FADEOUT:
			if (SGLG.isFadeOutComplete())
			{
				m_Logo1.SetActive(false);
				m_Logo2.SetActive(true);
				SGLG.endFade();
				setCurrent(STATE.LOGO2_FADEIN);
			}
			break;
		case STATE.LOGO2_FADEIN:
			if (!SGLG.isFading)
			{
				setCurrent(STATE.LOGO2_WAIT);
			}
			break;
		case STATE.LOGO2_WAIT:
			if (m_CurrentCnt >= LOGO_WAIT)
			{
				SGLG.startFade();
				setCurrent(STATE.LOGO2_FADEOUT);
			}
			break;
		case STATE.LOGO2_FADEOUT:
			if (SGLG.isFadeOutComplete())
			{
				if (SGLG.isCompleteResource)
				{
					SGLG.m_Mode = SGLG.MODE.GAMESTART;
				}
				else
				{
					SGLG.m_Mode = SGLG.MODE.DOWNLOAD;
				}
			}
			break;
		}
		base.control();
		m_CurrentCnt++;
	}

	public override void controlReel()
	{
	}

	public override void controlFrame()
	{
	}

	public override void keyEvent()
	{
		switch (m_Current)
		{
		case STATE.LOGO1_WAIT:
			if (SGLGInput.isPush())
			{
				SGLG.startFade();
				setCurrent(STATE.LOGO1_FADEOUT);
			}
			break;
		case STATE.LOGO2_WAIT:
			if (SGLGInput.isPush())
			{
				SGLG.startFade();
				setCurrent(STATE.LOGO2_FADEOUT);
			}
			break;
		}
		base.keyEvent();
	}

	private void Update()
	{
	}
}
