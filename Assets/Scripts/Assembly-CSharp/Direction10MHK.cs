public class Direction10MHK : DirectionBase
{
	public int m_mobX;

	public int m_nekoX;

	public Direction10MHK(DirectionManager _mng, byte _high, byte _low, byte _mode, DirectionManager.DIR _dir)
		: base(_mng, _high, _low, _mode, _dir, DirectionBase.PRIORITY_NORMAL)
	{
	}

	public override void start()
	{
		m_mobX = 256;
		m_nekoX = 0;
		base.start();
		if (low == 0)
		{
			switch (mode)
			{
			case 1:
				evt.eventPlayMovie(DirectionManager.MOVIE.mhk001_sol_c, false, false, false, true, MainGameScene.dir3MST_Sub.getPosSol(), (int)Direction3MST_Sub.POS_SOL_Y, Direction3MST_Sub.LAYER_SOL, 0);
				break;
			case 2:
				evt.eventPlayMovie(DirectionManager.MOVIE.mhk001_sol_d, false, false, false, true, MainGameScene.dir3MST_Sub.getPosSol(), (int)Direction3MST_Sub.POS_SOL_Y, Direction3MST_Sub.LAYER_SOL, 0);
				break;
			case 3:
				evt.eventPlayMovie(DirectionManager.MOVIE.mhk001_sin_e, false, false, false, true, MainGameScene.dir3MST_Sub.getPosSin(), (int)Direction3MST_Sub.POS_SIN_Y, Direction3MST_Sub.LAYER_SIN, 0);
				break;
			case 4:
				evt.eventPlayMovie(DirectionManager.MOVIE.mhk001_sin_d, false, false, false, true, MainGameScene.dir3MST_Sub.getPosSin(), (int)Direction3MST_Sub.POS_SIN_Y, Direction3MST_Sub.LAYER_SIN, 0);
				break;
			case 5:
				evt.eventPlayMovie(DirectionManager.MOVIE.mhk001_sin_c, false, true, false, true, MainGameScene.dir3MST_Sub.getPosSin(), (int)Direction3MST_Sub.POS_SIN_Y, Direction3MST_Sub.LAYER_SIN, 0);
				break;
			case 6:
				evt.eventPlayMovie(DirectionManager.MOVIE.mhk001_sol_e, false, false, false, true, MainGameScene.dir3MST_Sub.getPosSol(), (int)Direction3MST_Sub.POS_SOL_Y, Direction3MST_Sub.LAYER_SOL, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.mhk001_sol_e_gun, false, false, false, true, MainGameScene.dir3MST_Sub.getPosJYD(), (int)Direction3MST_Sub.POS_JYD_Y, Direction3MST_Sub.LAYER_JYD, 0);
				break;
			case 7:
				evt.eventPlayMovie(DirectionManager.MOVIE.mhk001_sol_f, false, false, false, true, MainGameScene.dir3MST_Sub.getPosSol(), (int)Direction3MST_Sub.POS_SOL_Y, Direction3MST_Sub.LAYER_SOL, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.mhk001_sol_f_gun, false, false, false, true, MainGameScene.dir3MST_Sub.getPosJYD(), (int)Direction3MST_Sub.POS_JYD_Y, Direction3MST_Sub.LAYER_JYD, 0);
				break;
			case 8:
				evt.eventPlayMovie(DirectionManager.MOVIE.mhk001_mob_white, false, true, false, true, m_mobX, 93, 199, 0);
				break;
			case 9:
				evt.eventPlayMovie(DirectionManager.MOVIE.mhk001_mob_blue, false, true, false, true, m_mobX, 93, 199, 0);
				break;
			case 10:
				evt.eventPlayMovie(DirectionManager.MOVIE.mhk001_mob_yellow, false, true, false, true, m_mobX, 93, 199, 0);
				break;
			case 11:
				evt.eventPlayMovie(DirectionManager.MOVIE.mhk001_mob_green, false, true, false, true, m_mobX, 93, 199, 0);
				break;
			case 12:
				evt.eventPlayMovie(DirectionManager.MOVIE.mhk001_mob_red, false, true, false, true, m_mobX, 93, 199, 0);
				break;
			case 13:
				evt.eventPlayMovie(DirectionManager.MOVIE.mhk001_mob_purple, false, true, false, true, m_mobX, 93, 199, 0);
				break;
			case 14:
				evt.eventPlayMovie(DirectionManager.MOVIE.mhk001_mob_rainbow, false, true, false, true, m_mobX, 93, 199, 0);
				break;
			case 15:
				evt.eventPlayMovie(DirectionManager.MOVIE.mhk001_dai, false, false, false, true, m_nekoX, 104, 100, 0);
				break;
			}
		}
		if (low == 0)
		{
			switch (mode)
			{
			case 1:
				break;
			case 2:
				break;
			case 3:
				break;
			case 4:
				break;
			case 5:
				break;
			case 6:
				break;
			case 7:
				break;
			case 8:
				break;
			case 9:
				break;
			case 10:
				break;
			case 11:
				break;
			case 12:
				break;
			case 13:
				break;
			case 14:
				break;
			case 15:
				break;
			}
		}
	}

	public override void end()
	{
		base.end();
	}

	public override void control()
	{
		base.control();
		int num = 0;
		if (mode == 15)
		{
			num = SGLG.prod.findLayer(100f);
			if (num >= 0)
			{
				m_nekoX = MainGameScene.dir3MST_Sub.getPosDai() + 165;
				SGLG.prod.SetXY(num, m_nekoX, 104f);
			}
			return;
		}
		num = SGLG.prod.findLayer(199f);
		if (num >= 0)
		{
			SGLG.prod.SetXY(num, m_mobX, 93f);
			m_mobX--;
			if (m_mobX < 0)
			{
				m_mobX = 0;
			}
		}
	}
}
