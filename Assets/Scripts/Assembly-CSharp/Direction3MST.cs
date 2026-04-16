public class Direction3MST : DirectionBase
{
	public Direction3MST(DirectionManager _mng, byte _high, byte _low, byte _mode, DirectionManager.DIR _dir)
		: base(_mng, _high, _low, _mode, _dir, DirectionBase.PRIORITY_NORMAL)
	{
	}

	public override void start()
	{
		base.start();
		if (low == 0)
		{
			byte b = mode;
			if (b == 1)
			{
				start_0_1(evt, mng);
			}
		}
		if (low == 0)
		{
			byte b = mode;
			if (b == 1)
			{
				lamp_0_1();
			}
		}
	}

	public static void lamp_0_1()
	{
		DirectionLedManager.OFF_1(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_1));
		DirectionLedManager.OFF_1(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_1));
		DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
		DirectionLedManager.OFF_3(DirectionLedManager.changeLineNum(LEDMainManager.LINE.UNDERPANEL));
		DirectionLedManager.OFF_4(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
		DirectionLedManager.OFF_5(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
		DirectionLedManager.OFF_6(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
		DirectionLedManager.OFF_7(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
		DirectionLedManager.OFF_8(DirectionLedManager.changeLineNum(LEDMainManager.LINE.DRIVE));
		DirectionLedManager.OFF_2m(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
		DirectionLedManager.init(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
		DirectionLedManager.init(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_6M));
		MainGameScene.ledPanelMan.stop(LEDPanelManager.LINE.LAYER_3M);
		MainGameScene.ledPanelMan.stop(LEDPanelManager.LINE.LAYER_6M);
	}

	public static void start_0_1(DirectionEvent _evt, DirectionManager _mng)
	{
		_evt.eventDisableBefore(_mng, 0);
		_evt.eventStopSound(Sound.CH.BGM, 0);
		_evt.eventPlayImage(DirectionManager.IMAGE.mst001_far, false, false, MainGameScene.dir3MST_Sub.getPosBG(), (int)Direction3MST_Sub.POS_BG_Y, Direction3MST_Sub.LAYER_BG, 0);
		_evt.eventPlayMovie(DirectionManager.MOVIE.mst001_sin_a, false, true, false, true, MainGameScene.dir3MST_Sub.getPosSin(), (int)Direction3MST_Sub.POS_SIN_Y, Direction3MST_Sub.LAYER_SIN, 0);
		_evt.eventPlayMovie(DirectionManager.MOVIE.mst001_mkira, false, true, true, true, MainGameScene.dir3MST_Sub.getPosKira(), (int)Direction3MST_Sub.POS_KIRA_Y, Direction3MST_Sub.LAYER_KIRA, 0);
		_evt.eventPlayMovie(DirectionManager.MOVIE.mst001_sol_a, false, true, false, true, MainGameScene.dir3MST_Sub.getPosSol(), (int)Direction3MST_Sub.POS_SOL_Y, Direction3MST_Sub.LAYER_SOL, 0);
		_evt.eventPlayMovie(DirectionManager.MOVIE.mst001_sol_a_nml2, false, false, false, true, MainGameScene.dir3MST_Sub.getPosJYD(), (int)Direction3MST_Sub.POS_JYD_Y, Direction3MST_Sub.LAYER_JYD, 0);
		_evt.eventPlayImage(DirectionManager.IMAGE.mst001_sol_a_nml, false, false, MainGameScene.dir3MST_Sub.getPosDai(), (int)Direction3MST_Sub.POS_DAI_Y, Direction3MST_Sub.LAYER_DAI, 0);
	}

	public override void end()
	{
		mst_killMovie(Direction3MST_Sub.LAYER_SIN);
		mst_killMovie(Direction3MST_Sub.LAYER_KIRA);
		mst_killMovie(Direction3MST_Sub.LAYER_SOL);
		mst_killMovie(Direction3MST_Sub.LAYER_JYD);
		mst_killImage(Direction3MST_Sub.LAYER_BG);
		mst_killImage(Direction3MST_Sub.LAYER_DAI);
		base.end();
	}

	public override void control()
	{
		base.control();
	}

	public void mst_killMovie(float layer)
	{
		int num = SGLG.prod.findLayer(layer);
		if (num >= 0)
		{
			SGLG.prod.Kill(num);
		}
	}

	public void mst_killImage(float layer)
	{
		int num = SGLG.prodImg.findLayer(layer);
		if (num >= 0)
		{
			SGLG.prodImg.Kill(num);
		}
	}
}
