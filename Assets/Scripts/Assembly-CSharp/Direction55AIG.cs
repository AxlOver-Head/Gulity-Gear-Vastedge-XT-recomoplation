public class Direction55AIG : DirectionBase
{
	private int m_cnt;

	public Direction55AIG(DirectionManager _mng, byte _high, byte _low, byte _mode, DirectionManager.DIR _dir)
		: base(_mng, _high, _low, _mode, _dir, DirectionBase.PRIORITY_NORMAL)
	{
	}

	public override void start()
	{
		m_cnt = 0;
		base.start();
		if (low == 0)
		{
			switch (mode)
			{
			case 1:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.aig001_b, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.aig001_b_loop, DirectionManager.MOVIE.aig001_b, false, true, false, false);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1230();
				evt.eventPlaySound(DirectionManager.SOUND.S0667, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1015, Sound.CH.VC0, true, 1f, 40);
				evt.eventPlayMovie(DirectionManager.MOVIE.aig001_d, false, false, false, true, 128, 99, 99, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.aig001_d_loop, DirectionManager.MOVIE.aig001_d, false, true, false, true);
				break;
			case 2:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.aig003_b, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.aig003_b_loop, DirectionManager.MOVIE.aig003_b, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0268, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.aig003_d, true, false, false, true, 128, 99, 99, 0);
				break;
			case 3:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.aig002_b, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 17);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1236();
				evt.eventPlaySound(DirectionManager.SOUND.S0534, Sound.CH.SE0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, false, 1f, 17);
				evt.eventPlaySound(DirectionManager.SOUND.S0224, Sound.CH.SE1, true, 1f, 16);
				evt.eventPlayMovie(DirectionManager.MOVIE.aig003_d, true, false, false, true, 128, 99, 99, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_10, false, false, true, false, 0, 0, 90, 17);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_10_loop, DirectionManager.MOVIE.huc008_T_10, false, true, true, false);
				break;
			case 4:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.aig002_b, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 17);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1236();
				evt.eventPlaySound(DirectionManager.SOUND.S0534, Sound.CH.SE0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, false, 1f, 17);
				evt.eventPlaySound(DirectionManager.SOUND.S0225, Sound.CH.SE1, true, 1f, 16);
				evt.eventPlayMovie(DirectionManager.MOVIE.aig003_d, true, false, false, true, 128, 99, 99, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_20, false, false, true, false, 0, 0, 90, 17);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_20_loop, DirectionManager.MOVIE.huc008_T_20, false, true, true, false);
				break;
			case 5:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.aig002_b, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 17);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1236();
				evt.eventPlaySound(DirectionManager.SOUND.S0534, Sound.CH.SE0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, false, 1f, 17);
				evt.eventPlaySound(DirectionManager.SOUND.S0226, Sound.CH.SE1, true, 1f, 16);
				evt.eventPlayMovie(DirectionManager.MOVIE.aig003_d, true, false, false, true, 128, 99, 99, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_30, false, false, true, false, 0, 0, 90, 17);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_30_loop, DirectionManager.MOVIE.huc008_T_30, false, true, true, false);
				break;
			case 6:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.aig002_b, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 17);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1240();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1242();
				evt.eventPlaySound(DirectionManager.SOUND.S0534, Sound.CH.SE0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, false, 1f, 17);
				evt.eventPlaySound(DirectionManager.SOUND.S0227, Sound.CH.SE1, true, 1f, 16);
				evt.eventPlayMovie(DirectionManager.MOVIE.aig003_d, true, false, false, true, 128, 99, 99, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_50, false, false, true, false, 0, 0, 90, 17);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_50_loop, DirectionManager.MOVIE.huc008_T_50, false, true, true, false);
				break;
			case 7:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.aig002_b, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 17);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1240();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1242();
				evt.eventPlaySound(DirectionManager.SOUND.S0534, Sound.CH.SE0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, false, 1f, 17);
				evt.eventPlaySound(DirectionManager.SOUND.S0228, Sound.CH.SE1, true, 1f, 16);
				evt.eventPlayMovie(DirectionManager.MOVIE.aig003_d, true, false, false, true, 128, 99, 99, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_100, false, false, true, false, 0, 0, 90, 17);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_100_loop, DirectionManager.MOVIE.huc008_T_100, false, true, true, false);
				break;
			case 8:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.aig002_b, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 17);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1240();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1242();
				evt.eventPlaySound(DirectionManager.SOUND.S0534, Sound.CH.SE0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, false, 1f, 17);
				evt.eventPlaySound(DirectionManager.SOUND.S0229, Sound.CH.SE1, true, 1f, 16);
				evt.eventPlayMovie(DirectionManager.MOVIE.aig003_d, true, false, false, true, 128, 99, 99, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_150, false, false, true, false, 0, 0, 90, 17);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_150_loop, DirectionManager.MOVIE.huc008_T_150, false, true, true, false);
				break;
			case 9:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.aig002_b, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 17);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1246();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1248();
				evt.eventPlaySound(DirectionManager.SOUND.S0534, Sound.CH.SE0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, false, 1f, 17);
				evt.eventPlaySound(DirectionManager.SOUND.S0230, Sound.CH.SE1, true, 1f, 16);
				evt.eventPlayMovie(DirectionManager.MOVIE.aig003_d, true, false, false, true, 128, 99, 99, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_200, false, false, true, false, 0, 0, 90, 17);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_200_loop, DirectionManager.MOVIE.huc008_T_200, false, true, true, false);
				break;
			case 10:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.aig002_b, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 17);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1246();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1248();
				evt.eventPlaySound(DirectionManager.SOUND.S0534, Sound.CH.SE0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, false, 1f, 17);
				evt.eventPlaySound(DirectionManager.SOUND.S0231, Sound.CH.SE1, true, 1f, 16);
				evt.eventPlayMovie(DirectionManager.MOVIE.aig003_d, true, false, false, true, 128, 99, 99, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_300, false, false, true, false, 0, 0, 90, 17);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_300_loop, DirectionManager.MOVIE.huc008_T_300, false, true, true, false);
				break;
			case 11:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.aig001_r, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.aig001_r_loop, DirectionManager.MOVIE.aig001_r, false, true, false, false);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1251();
				evt.eventPlaySound(DirectionManager.SOUND.S0667, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1015, Sound.CH.VC0, true, 1f, 40);
				evt.eventPlayMovie(DirectionManager.MOVIE.aig001_d, false, false, false, true, 128, 99, 99, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.aig001_d_loop, DirectionManager.MOVIE.aig001_d, false, true, false, true);
				break;
			case 12:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.aig003_r, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.aig003_r_loop, DirectionManager.MOVIE.aig003_r, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0268, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.aig003_d, true, false, false, true, 128, 99, 99, 0);
				break;
			case 14:
				evt.eventDisableBefore(mng, 0);
				if (MainGameScene.dirMan.m_Mode[0] == 1)
				{
					evt.eventPlayMovie(DirectionManager.MOVIE.aig002_b, false, false, false, true, 128, 72, 100, 0);
				}
				else
				{
					evt.eventPlayMovie(DirectionManager.MOVIE.aig002_r, false, false, false, true, 128, 72, 100, 0);
				}
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 17);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0534, Sound.CH.SE0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, false, 1f, 17);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE0, false, 1f, 22);
				evt.eventPlayMovie(DirectionManager.MOVIE.aig003_d, true, false, false, true, 128, 99, 99, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.aig002_bd_nml, false, false, false, true, 128, 77, 98, 29);
				evt.eventAddMovie(DirectionManager.MOVIE.aig002_bd_loop_nml, DirectionManager.MOVIE.aig002_bd_nml, false, true, false, true);
				evt.eventPlayMovie(DirectionManager.MOVIE.aig002_bd_add, true, false, true, true, 128, 102, 97, 40);
				evt.eventPlayMovie(DirectionManager.MOVIE.aig002_bd_loop_add, false, true, true, true, 236, 88, 96, 9);
				break;
			case 15:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.aig002_r, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 17);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1236();
				evt.eventPlaySound(DirectionManager.SOUND.S0534, Sound.CH.SE0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, false, 1f, 17);
				evt.eventPlaySound(DirectionManager.SOUND.S0224, Sound.CH.SE1, true, 1f, 16);
				evt.eventPlayMovie(DirectionManager.MOVIE.aig003_d, true, false, false, true, 128, 99, 99, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_10, false, false, true, false, 0, 0, 90, 17);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_10_loop, DirectionManager.MOVIE.huc008_T_10, false, true, true, false);
				break;
			case 16:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.aig002_r, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 17);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1236();
				evt.eventPlaySound(DirectionManager.SOUND.S0534, Sound.CH.SE0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, false, 1f, 17);
				evt.eventPlaySound(DirectionManager.SOUND.S0225, Sound.CH.SE1, true, 1f, 16);
				evt.eventPlayMovie(DirectionManager.MOVIE.aig003_d, true, false, false, true, 128, 99, 99, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_20, false, false, true, false, 0, 0, 90, 17);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_20_loop, DirectionManager.MOVIE.huc008_T_20, false, true, true, false);
				break;
			case 17:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.aig002_r, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 17);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1236();
				evt.eventPlaySound(DirectionManager.SOUND.S0534, Sound.CH.SE0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, false, 1f, 17);
				evt.eventPlaySound(DirectionManager.SOUND.S0226, Sound.CH.SE1, true, 1f, 16);
				evt.eventPlayMovie(DirectionManager.MOVIE.aig003_d, true, false, false, true, 128, 99, 99, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_30, false, false, true, false, 0, 0, 90, 17);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_30_loop, DirectionManager.MOVIE.huc008_T_30, false, true, true, false);
				break;
			case 18:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.aig002_r, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 17);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1240();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1242();
				evt.eventPlaySound(DirectionManager.SOUND.S0534, Sound.CH.SE0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, false, 1f, 17);
				evt.eventPlaySound(DirectionManager.SOUND.S0227, Sound.CH.SE1, true, 1f, 16);
				evt.eventPlayMovie(DirectionManager.MOVIE.aig003_d, true, false, false, true, 128, 99, 99, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_50, false, false, true, false, 0, 0, 90, 17);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_50_loop, DirectionManager.MOVIE.huc008_T_50, false, true, true, false);
				break;
			case 19:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.aig002_r, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 17);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1240();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1242();
				evt.eventPlaySound(DirectionManager.SOUND.S0534, Sound.CH.SE0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, false, 1f, 17);
				evt.eventPlaySound(DirectionManager.SOUND.S0228, Sound.CH.SE1, true, 1f, 16);
				evt.eventPlayMovie(DirectionManager.MOVIE.aig003_d, true, false, false, true, 128, 99, 99, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_100, false, false, true, false, 0, 0, 90, 17);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_100_loop, DirectionManager.MOVIE.huc008_T_100, false, true, true, false);
				break;
			case 20:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.aig002_r, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 17);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1240();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1242();
				evt.eventPlaySound(DirectionManager.SOUND.S0534, Sound.CH.SE0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, false, 1f, 17);
				evt.eventPlaySound(DirectionManager.SOUND.S0229, Sound.CH.SE1, true, 1f, 16);
				evt.eventPlayMovie(DirectionManager.MOVIE.aig003_d, true, false, false, true, 128, 99, 99, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_150, false, false, true, false, 0, 0, 90, 17);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_150_loop, DirectionManager.MOVIE.huc008_T_150, false, true, true, false);
				break;
			case 21:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.aig002_r, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 17);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1246();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1248();
				evt.eventPlaySound(DirectionManager.SOUND.S0534, Sound.CH.SE0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, false, 1f, 17);
				evt.eventPlaySound(DirectionManager.SOUND.S0230, Sound.CH.SE1, true, 1f, 16);
				evt.eventPlayMovie(DirectionManager.MOVIE.aig003_d, false, false, false, true, 128, 99, 99, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_200, false, false, true, false, 0, 0, 90, 17);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_200_loop, DirectionManager.MOVIE.huc008_T_200, false, true, true, false);
				break;
			case 22:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.aig002_r, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 17);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1246();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1248();
				evt.eventPlaySound(DirectionManager.SOUND.S0534, Sound.CH.SE0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, false, 1f, 17);
				evt.eventPlaySound(DirectionManager.SOUND.S0231, Sound.CH.SE1, true, 1f, 16);
				evt.eventPlayMovie(DirectionManager.MOVIE.aig003_d, true, false, false, true, 128, 99, 99, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_300, false, false, true, false, 0, 0, 90, 17);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_300_loop, DirectionManager.MOVIE.huc008_T_300, false, true, true, false);
				break;
			case 23:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.aig002_b, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.aig004_b, DirectionManager.MOVIE.aig002_b, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.aig004_b_loop, DirectionManager.MOVIE.aig004_b, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0534, Sound.CH.SE0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0664, Sound.CH.SE0, false, 1f, 16);
				evt.eventPlaySound(DirectionManager.SOUND.S0217, Sound.CH.SE0, false, 1f, 75);
				evt.eventPlaySound(DirectionManager.SOUND.S0062, Sound.CH.SE0, true, 1f, 66);
				evt.eventPlaySound(DirectionManager.SOUND.S0091, Sound.CH.SE1, true, 1f, 71);
				evt.eventPlaySound(DirectionManager.SOUND.S0063, Sound.CH.SE0, true, 1f, 156);
				break;
			case 24:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.aig002_r, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.aig004_r, DirectionManager.MOVIE.aig002_r, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.aig004_r_loop, DirectionManager.MOVIE.aig004_r, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0534, Sound.CH.SE0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0664, Sound.CH.SE0, false, 1f, 16);
				evt.eventPlaySound(DirectionManager.SOUND.S0217, Sound.CH.SE0, false, 1f, 75);
				evt.eventPlaySound(DirectionManager.SOUND.S0062, Sound.CH.SE0, true, 1f, 66);
				evt.eventPlaySound(DirectionManager.SOUND.S0091, Sound.CH.SE1, true, 1f, 71);
				evt.eventPlaySound(DirectionManager.SOUND.S0063, Sound.CH.SE0, true, 1f, 156);
				break;
			}
		}
		if (low == 0)
		{
			switch (mode)
			{
			case 1:
				DirectionLedManager.YK_AIG_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				DirectionLedManager.m_panel_dest_01(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_6M));
				break;
			case 2:
				DirectionLedManager.YK_AIG_01_miss(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				DirectionLedManager.OFF_5m(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_6M));
				break;
			case 3:
				DirectionLedManager.YK_AIG_attack_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 4:
				DirectionLedManager.YK_AIG_attack_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 5:
				DirectionLedManager.YK_AIG_attack_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 6:
				DirectionLedManager.YK_AIG_attack_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 7:
				DirectionLedManager.YK_AIG_attack_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 8:
				DirectionLedManager.YK_AIG_attack_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 9:
				DirectionLedManager.YK_AIG_attack_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 10:
				DirectionLedManager.YK_AIG_attack_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 11:
				DirectionLedManager.YK_AIG_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				DirectionLedManager.m_panel_dest_02(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_6M));
				break;
			case 12:
				DirectionLedManager.YK_AIG_02_miss(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				DirectionLedManager.OFF_5m(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_6M));
				break;
			case 13:
				break;
			case 14:
				break;
			case 15:
				DirectionLedManager.YK_AIG_attack_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 16:
				DirectionLedManager.YK_AIG_attack_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 17:
				DirectionLedManager.YK_AIG_attack_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 18:
				DirectionLedManager.YK_AIG_attack_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 19:
				DirectionLedManager.YK_AIG_attack_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 20:
				DirectionLedManager.YK_AIG_attack_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 21:
				DirectionLedManager.YK_AIG_attack_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 22:
				DirectionLedManager.YK_AIG_attack_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 23:
				DirectionLedManager.YK_AIG_attack_01_rainbow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 24:
				DirectionLedManager.YK_AIG_attack_02_rainbow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 25:
				break;
			case 26:
				DirectionLedManager.YK_add_GB(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
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
		if (evt.m_Active && low == 0)
		{
			byte b = mode;
			if (b == 23 || b == 24)
			{
				int num = MainGameScene.slotGameMan.m_kaidoData[466];
				int num2 = MainGameScene.slotGameMan.m_kaidoData[470 + (num - 1)];
				if (MainGameScene.slotGameMan.m_kaidoData[465] != 0)
				{
					if (m_cnt == 55)
					{
						if (num == 1)
						{
							if (num2 == 0)
							{
								DirectionLedManager.DG_POW1_white_get(DirectionMainLED.LINE_MAIN_9);
							}
							if (num2 == 1)
							{
								DirectionLedManager.DG_POW1_blue_get(DirectionMainLED.LINE_MAIN_9);
							}
							if (num2 == 2)
							{
								DirectionLedManager.DG_POW1_yellow_get(DirectionMainLED.LINE_MAIN_9);
							}
							if (num2 == 3)
							{
								DirectionLedManager.DG_POW1_green_get(DirectionMainLED.LINE_MAIN_9);
							}
							if (num2 == 4)
							{
								DirectionLedManager.DG_POW1_red_get(DirectionMainLED.LINE_MAIN_9);
							}
							if (num2 == 5)
							{
								DirectionLedManager.DG_POW1_purple_get(DirectionMainLED.LINE_MAIN_9);
							}
							if (num2 == 6)
							{
								DirectionLedManager.DG_POW1_rainbow_get(DirectionMainLED.LINE_MAIN_9);
							}
						}
						if (num == 2)
						{
							if (num2 == 0)
							{
								DirectionLedManager.DG_POW2_white_get(DirectionMainLED.LINE_MAIN_10);
							}
							if (num2 == 1)
							{
								DirectionLedManager.DG_POW2_blue_get(DirectionMainLED.LINE_MAIN_10);
							}
							if (num2 == 2)
							{
								DirectionLedManager.DG_POW2_yellow_get(DirectionMainLED.LINE_MAIN_10);
							}
							if (num2 == 3)
							{
								DirectionLedManager.DG_POW2_green_get(DirectionMainLED.LINE_MAIN_10);
							}
							if (num2 == 4)
							{
								DirectionLedManager.DG_POW2_red_get(DirectionMainLED.LINE_MAIN_10);
							}
							if (num2 == 5)
							{
								DirectionLedManager.DG_POW2_purple_get(DirectionMainLED.LINE_MAIN_10);
							}
							if (num2 == 6)
							{
								DirectionLedManager.DG_POW2_rainbow_get(DirectionMainLED.LINE_MAIN_10);
							}
						}
						if (num == 3)
						{
							if (num2 == 0)
							{
								DirectionLedManager.DG_POW3_white_get(DirectionMainLED.LINE_MAIN_11);
							}
							if (num2 == 1)
							{
								DirectionLedManager.DG_POW3_blue_get(DirectionMainLED.LINE_MAIN_11);
							}
							if (num2 == 2)
							{
								DirectionLedManager.DG_POW3_yellow_get(DirectionMainLED.LINE_MAIN_11);
							}
							if (num2 == 3)
							{
								DirectionLedManager.DG_POW3_green_get(DirectionMainLED.LINE_MAIN_11);
							}
							if (num2 == 4)
							{
								DirectionLedManager.DG_POW3_red_get(DirectionMainLED.LINE_MAIN_11);
							}
							if (num2 == 5)
							{
								DirectionLedManager.DG_POW3_purple_get(DirectionMainLED.LINE_MAIN_11);
							}
							if (num2 == 6)
							{
								DirectionLedManager.DG_POW3_rainbow_get(DirectionMainLED.LINE_MAIN_11);
							}
						}
						if (num == 4)
						{
							if (num2 == 0)
							{
								DirectionLedManager.DG_POW4_white_get(DirectionMainLED.LINE_MAIN_12);
							}
							if (num2 == 1)
							{
								DirectionLedManager.DG_POW4_blue_get(DirectionMainLED.LINE_MAIN_12);
							}
							if (num2 == 2)
							{
								DirectionLedManager.DG_POW4_yellow_get(DirectionMainLED.LINE_MAIN_12);
							}
							if (num2 == 3)
							{
								DirectionLedManager.DG_POW4_green_get(DirectionMainLED.LINE_MAIN_12);
							}
							if (num2 == 4)
							{
								DirectionLedManager.DG_POW4_red_get(DirectionMainLED.LINE_MAIN_12);
							}
							if (num2 == 5)
							{
								DirectionLedManager.DG_POW4_purple_get(DirectionMainLED.LINE_MAIN_12);
							}
							if (num2 == 6)
							{
								DirectionLedManager.DG_POW4_rainbow_get(DirectionMainLED.LINE_MAIN_12);
							}
						}
						if (num == 5)
						{
							if (num2 == 0)
							{
								DirectionLedManager.DG_POW5_white_get(DirectionMainLED.LINE_MAIN_13);
							}
							if (num2 == 1)
							{
								DirectionLedManager.DG_POW5_blue_get(DirectionMainLED.LINE_MAIN_13);
							}
							if (num2 == 2)
							{
								DirectionLedManager.DG_POW5_yellow_get(DirectionMainLED.LINE_MAIN_13);
							}
							if (num2 == 3)
							{
								DirectionLedManager.DG_POW5_green_get(DirectionMainLED.LINE_MAIN_13);
							}
							if (num2 == 4)
							{
								DirectionLedManager.DG_POW5_red_get(DirectionMainLED.LINE_MAIN_13);
							}
							if (num2 == 5)
							{
								DirectionLedManager.DG_POW5_purple_get(DirectionMainLED.LINE_MAIN_13);
							}
							if (num2 == 6)
							{
								DirectionLedManager.DG_POW5_rainbow_get(DirectionMainLED.LINE_MAIN_13);
							}
						}
						if (num == 6)
						{
							if (num2 == 0)
							{
								DirectionLedManager.DG_POW6_rainbow_get(DirectionMainLED.LINE_MAIN_14);
							}
							if (num2 == 1)
							{
								DirectionLedManager.DG_POW6_rainbow_get(DirectionMainLED.LINE_MAIN_14);
							}
							if (num2 == 2)
							{
								DirectionLedManager.DG_POW6_rainbow_get(DirectionMainLED.LINE_MAIN_14);
							}
							if (num2 == 3)
							{
								DirectionLedManager.DG_POW6_rainbow_get(DirectionMainLED.LINE_MAIN_14);
							}
							if (num2 == 4)
							{
								DirectionLedManager.DG_POW6_rainbow_get(DirectionMainLED.LINE_MAIN_14);
							}
							if (num2 == 5)
							{
								DirectionLedManager.DG_POW6_rainbow_get(DirectionMainLED.LINE_MAIN_14);
							}
							if (num2 == 6)
							{
								DirectionLedManager.DG_POW6_rainbow_get(DirectionMainLED.LINE_MAIN_14);
							}
						}
					}
					m_cnt++;
				}
			}
		}
		base.control();
	}
}
