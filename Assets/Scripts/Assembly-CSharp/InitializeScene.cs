public class InitializeScene : SceneUpdater
{
	private void Start()
	{
		SGLG.m_Scene = (InitializeScene)base.gameObject.GetComponent("InitializeScene");
	}

	public override void init()
	{
		SubResource.init();
		SGLG.startFade();
		m_IsOK = true;
	}

	public override void control()
	{
		if (SGLG.isFadeOutComplete())
		{
			SGLG.m_Mode = SGLG.MODE.LOGO;
		}
		base.control();
	}

	public override void controlReel()
	{
	}

	public override void controlFrame()
	{
	}

	public override void keyEvent()
	{
		base.keyEvent();
	}

	private void Update()
	{
	}
}
