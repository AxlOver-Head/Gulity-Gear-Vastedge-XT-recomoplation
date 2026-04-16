public class GameStartScene : SceneUpdater
{
	private void Start()
	{
		SGLG.m_Scene = (GameStartScene)base.gameObject.GetComponent("GameStartScene");
	}

	public override void init()
	{
		SGLG.prod = SGLG.m_GameObj.AddComponent<Production>();
		SGLG.prodImg = SGLG.m_GameObj.AddComponent<ProductionImg>();
		SGLG.prodAnime = SGLG.m_GameObj.AddComponent<ProductionAnime>();
		SGLG.sound = SGLG.m_GameObj.AddComponent<Sound>();
		SGLG.prod.init();
		SGLG.prodImg.init();
		SGLG.prodAnime.init();
		SGLG.sound.init();
		SceneUpdater.setProd(SGLG.prod);
		SceneUpdater.setProdAnime(SGLG.prodAnime);
		SceneUpdater.setSound(SGLG.sound);
		PlayUserData.clear();
		PlayUserData.init();
		PlayUserData.load();
		Sim_PlayUserData.clear();
		Sim_PlayUserData.init();
		Sim_PlayUserData.load();
		Sim_MachineData.init();
		SlotUserData.init();
		Sim_SlotUserData.init();
		SlotUserData_m1.init();
		SlotUserData_m2.init();
		SlotUserData_m3.init();
		SlotUserData_m4.init();
		SlotUserData_m5.init();
		SlotUserData_m6.init();
		SlotUserData_m7.init();
		SlotUserData_m8.init();
		SlotUserData_m9.init();
		SlotUserData_m10.init();
		SGLG.startLoading();
		SGLG.endFade();
		m_IsOK = true;
	}

	public override void control()
	{
		if (SGLG.loading.loadStart && m_IsOK && SGLG.isReady())
		{
			SceneUpdater.sound.init2();
			SGLG.m_Mode = SGLG.MODE.TITLE;
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
