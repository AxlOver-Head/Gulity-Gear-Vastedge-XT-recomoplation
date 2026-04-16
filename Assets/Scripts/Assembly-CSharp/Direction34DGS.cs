public class Direction34DGS : DirectionBase
{
	public Direction34DGS(DirectionManager _mng, byte _high, byte _low, byte _mode, DirectionManager.DIR _dir)
		: base(_mng, _high, _low, _mode, _dir, DirectionBase.PRIORITY_NORMAL)
	{
	}

	public override void start()
	{
		if (low == 0)
		{
			switch (mode)
			{
			case 1:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.dgs004, false, false, false, false, 0, 0, 100, 0);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0467, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0468, Sound.CH.SE1, true, 1f, 0);
				break;
			case 2:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.dgs001, false, false, false, false, 0, 0, 100, 4);
				evt.eventAddMovie(DirectionManager.MOVIE.dgs001_loop, DirectionManager.MOVIE.dgs001, false, true, false, false);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_634();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_636();
				evt.eventPlayMovie(DirectionManager.MOVIE.dgs001_add, true, false, true, false, 0, 0, 99, 0);
				evt.eventStopSound(Sound.CH.BGM, 35);
				evt.eventPlaySound(DirectionManager.SOUND.S0465, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0861, Sound.CH.VC0, true, 1f, 5);
				evt.eventPlaySound(DirectionManager.SOUND.S0466, Sound.CH.SE1, true, 1f, 8);
				evt.eventPlaySound(DirectionManager.SOUND.S0366, Sound.CH.SE0, true, 1f, 35);
				evt.eventPlayMovie(DirectionManager.MOVIE.btd003, false, false, false, true, 128, 72, 98, 30);
				evt.eventAddMovie(DirectionManager.MOVIE.btd003_loop, DirectionManager.MOVIE.btd003, false, true, false, true);
				evt.eventPlaySound(DirectionManager.SOUND.S0358, Sound.CH.SE1, true, 1f, 16);
				break;
			case 3:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.dgs001, false, false, false, false, 0, 0, 100, 4);
				evt.eventAddMovie(DirectionManager.MOVIE.dgs001_loop, DirectionManager.MOVIE.dgs001, false, true, false, false);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_640();
				evt.eventPlayMovie(DirectionManager.MOVIE.dgs001_add, true, false, true, false, 0, 0, 99, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0465, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0861, Sound.CH.VC0, true, 1f, 5);
				evt.eventPlaySound(DirectionManager.SOUND.S0466, Sound.CH.SE1, true, 1f, 8);
				evt.eventPlaySound(DirectionManager.SOUND.S0366, Sound.CH.SE0, true, 1f, 35);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_10, false, false, true, false, 0, 0, 98, 30);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_10_loop, DirectionManager.MOVIE.huc008_T_10, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0224, Sound.CH.SE1, true, 1f, 30);
				break;
			case 4:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.dgs001, false, false, false, false, 0, 0, 100, 4);
				evt.eventAddMovie(DirectionManager.MOVIE.dgs001_loop, DirectionManager.MOVIE.dgs001, false, true, false, false);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_644();
				evt.eventPlayMovie(DirectionManager.MOVIE.dgs001_add, true, false, true, false, 0, 0, 99, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0465, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0861, Sound.CH.VC0, true, 1f, 5);
				evt.eventPlaySound(DirectionManager.SOUND.S0466, Sound.CH.SE1, true, 1f, 8);
				evt.eventPlaySound(DirectionManager.SOUND.S0366, Sound.CH.SE0, true, 1f, 35);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_20, false, false, true, false, 0, 0, 98, 30);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_20_loop, DirectionManager.MOVIE.huc008_T_20, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0225, Sound.CH.SE1, true, 1f, 30);
				break;
			case 5:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.dgs001, false, false, false, false, 0, 0, 100, 4);
				evt.eventAddMovie(DirectionManager.MOVIE.dgs001_loop, DirectionManager.MOVIE.dgs001, false, true, false, false);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_648();
				evt.eventPlayMovie(DirectionManager.MOVIE.dgs001_add, true, false, true, false, 0, 0, 99, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0465, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0861, Sound.CH.VC0, true, 1f, 5);
				evt.eventPlaySound(DirectionManager.SOUND.S0466, Sound.CH.SE1, true, 1f, 8);
				evt.eventPlaySound(DirectionManager.SOUND.S0366, Sound.CH.SE0, true, 1f, 35);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_30, false, false, true, false, 0, 0, 98, 30);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_30_loop, DirectionManager.MOVIE.huc008_T_30, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0226, Sound.CH.SE1, true, 1f, 30);
				break;
			case 6:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.dgs001, false, false, false, false, 0, 0, 100, 4);
				evt.eventAddMovie(DirectionManager.MOVIE.dgs001_loop, DirectionManager.MOVIE.dgs001, false, true, false, false);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_650();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_652();
				evt.eventPlayMovie(DirectionManager.MOVIE.dgs001_add, true, false, true, false, 0, 0, 99, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0465, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0861, Sound.CH.VC0, true, 1f, 5);
				evt.eventPlaySound(DirectionManager.SOUND.S0466, Sound.CH.SE1, true, 1f, 8);
				evt.eventPlaySound(DirectionManager.SOUND.S0366, Sound.CH.SE0, true, 1f, 35);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_50, false, false, true, false, 0, 0, 98, 30);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_50_loop, DirectionManager.MOVIE.huc008_T_50, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0227, Sound.CH.SE1, true, 1f, 30);
				break;
			case 7:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.dgs001, false, false, false, false, 0, 0, 100, 4);
				evt.eventAddMovie(DirectionManager.MOVIE.dgs001_loop, DirectionManager.MOVIE.dgs001, false, true, false, false);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_654();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_656();
				evt.eventPlayMovie(DirectionManager.MOVIE.dgs001_add, true, false, true, false, 0, 0, 99, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0465, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0861, Sound.CH.VC0, true, 1f, 5);
				evt.eventPlaySound(DirectionManager.SOUND.S0466, Sound.CH.SE1, true, 1f, 8);
				evt.eventPlaySound(DirectionManager.SOUND.S0366, Sound.CH.SE0, true, 1f, 35);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_100, false, false, true, false, 0, 0, 98, 30);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_100_loop, DirectionManager.MOVIE.huc008_T_100, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0228, Sound.CH.SE1, true, 1f, 30);
				break;
			case 8:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.dgs001, false, false, false, false, 0, 0, 100, 4);
				evt.eventAddMovie(DirectionManager.MOVIE.dgs001_loop, DirectionManager.MOVIE.dgs001, false, true, false, false);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_658();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_660();
				evt.eventPlayMovie(DirectionManager.MOVIE.dgs001_add, true, false, true, false, 0, 0, 99, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0465, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0861, Sound.CH.VC0, true, 1f, 5);
				evt.eventPlaySound(DirectionManager.SOUND.S0466, Sound.CH.SE1, true, 1f, 8);
				evt.eventPlaySound(DirectionManager.SOUND.S0366, Sound.CH.SE0, true, 1f, 35);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_150, false, false, true, false, 0, 0, 98, 30);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_150_loop, DirectionManager.MOVIE.huc008_T_150, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0229, Sound.CH.SE1, true, 1f, 30);
				break;
			case 9:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.dgs001, false, false, false, false, 0, 0, 100, 4);
				evt.eventAddMovie(DirectionManager.MOVIE.dgs001_loop, DirectionManager.MOVIE.dgs001, false, true, false, false);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_662();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_664();
				evt.eventPlayMovie(DirectionManager.MOVIE.dgs001_add, true, false, true, false, 0, 0, 99, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0465, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0861, Sound.CH.VC0, true, 1f, 5);
				evt.eventPlaySound(DirectionManager.SOUND.S0466, Sound.CH.SE1, true, 1f, 8);
				evt.eventPlaySound(DirectionManager.SOUND.S0366, Sound.CH.SE0, true, 1f, 35);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_200, false, false, true, false, 0, 0, 98, 30);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_200_loop, DirectionManager.MOVIE.huc008_T_200, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0230, Sound.CH.SE1, true, 1f, 30);
				break;
			case 10:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.dgs001, false, false, false, false, 0, 0, 100, 4);
				evt.eventAddMovie(DirectionManager.MOVIE.dgs001_loop, DirectionManager.MOVIE.dgs001, false, true, false, false);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_666();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_668();
				evt.eventPlayMovie(DirectionManager.MOVIE.dgs001_add, true, false, true, false, 0, 0, 99, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0465, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0861, Sound.CH.VC0, true, 1f, 5);
				evt.eventPlaySound(DirectionManager.SOUND.S0466, Sound.CH.SE1, true, 1f, 8);
				evt.eventPlaySound(DirectionManager.SOUND.S0366, Sound.CH.SE0, true, 1f, 35);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_300, false, false, true, false, 0, 0, 98, 30);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_300_loop, DirectionManager.MOVIE.huc008_T_300, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0231, Sound.CH.SE1, true, 1f, 30);
				break;
			case 11:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.dgs001, false, false, false, false, 0, 0, 100, 4);
				evt.eventAddMovie(DirectionManager.MOVIE.dgs001_loop, DirectionManager.MOVIE.dgs001, false, true, false, false);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_672();
				evt.eventPlayMovie(DirectionManager.MOVIE.dgs001_add, true, false, true, false, 0, 0, 99, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0465, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0861, Sound.CH.VC0, true, 1f, 5);
				evt.eventPlaySound(DirectionManager.SOUND.S0466, Sound.CH.SE1, true, 1f, 8);
				evt.eventPlaySound(DirectionManager.SOUND.S0366, Sound.CH.SE0, true, 1f, 35);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_7, false, false, true, false, 0, 0, 98, 30);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_7_loop, DirectionManager.MOVIE.huc008_T_7, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0224, Sound.CH.SE1, true, 1f, 30);
				break;
			}
		}
		if (low == 0)
		{
			switch (mode)
			{
			case 1:
				DirectionLedManager.YK_DI_total(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 2:
				DirectionLedManager.YK_DGS_add_BONUS(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			}
		}
		if (low == 0)
		{
			byte b = mode;
			if (b == 1)
			{
				int num = MainGameScene.slotGameMan.get_pkd_data(584);
				int num2 = num % 10;
				int num3 = num / 10 % 10;
				int num4 = num / 100 % 10;
				int num5 = num / 1000;
				DirectionManager.MOVIE[] array = new DirectionManager.MOVIE[10]
				{
					DirectionManager.MOVIE.dgs004_0_1,
					DirectionManager.MOVIE.dgs004_1_1,
					DirectionManager.MOVIE.dgs004_2_1,
					DirectionManager.MOVIE.dgs004_3_1,
					DirectionManager.MOVIE.dgs004_4_1,
					DirectionManager.MOVIE.dgs004_5_1,
					DirectionManager.MOVIE.dgs004_6_1,
					DirectionManager.MOVIE.dgs004_7_1,
					DirectionManager.MOVIE.dgs004_8_1,
					DirectionManager.MOVIE.dgs004_9_1
				};
				DirectionManager.MOVIE[] array2 = new DirectionManager.MOVIE[10]
				{
					DirectionManager.MOVIE.dgs004_0_2,
					DirectionManager.MOVIE.dgs004_1_2,
					DirectionManager.MOVIE.dgs004_2_2,
					DirectionManager.MOVIE.dgs004_3_2,
					DirectionManager.MOVIE.dgs004_4_2,
					DirectionManager.MOVIE.dgs004_5_2,
					DirectionManager.MOVIE.dgs004_6_2,
					DirectionManager.MOVIE.dgs004_7_2,
					DirectionManager.MOVIE.dgs004_8_2,
					DirectionManager.MOVIE.dgs004_9_2
				};
				DirectionManager.MOVIE[] array3 = new DirectionManager.MOVIE[10]
				{
					DirectionManager.MOVIE.dgs004_0_3,
					DirectionManager.MOVIE.dgs004_1_3,
					DirectionManager.MOVIE.dgs004_2_3,
					DirectionManager.MOVIE.dgs004_3_3,
					DirectionManager.MOVIE.dgs004_4_3,
					DirectionManager.MOVIE.dgs004_5_3,
					DirectionManager.MOVIE.dgs004_6_3,
					DirectionManager.MOVIE.dgs004_7_3,
					DirectionManager.MOVIE.dgs004_8_3,
					DirectionManager.MOVIE.dgs004_9_3
				};
				DirectionManager.MOVIE[] array4 = new DirectionManager.MOVIE[10]
				{
					DirectionManager.MOVIE.dgs004_0_4,
					DirectionManager.MOVIE.dgs004_1_4,
					DirectionManager.MOVIE.dgs004_2_4,
					DirectionManager.MOVIE.dgs004_3_4,
					DirectionManager.MOVIE.dgs004_4_4,
					DirectionManager.MOVIE.dgs004_5_4,
					DirectionManager.MOVIE.dgs004_6_4,
					DirectionManager.MOVIE.dgs004_7_4,
					DirectionManager.MOVIE.dgs004_8_4,
					DirectionManager.MOVIE.dgs004_9_4
				};
				DirectionManager.MOVIE[] array5 = new DirectionManager.MOVIE[10]
				{
					DirectionManager.MOVIE.dgs004_0_2_nml,
					DirectionManager.MOVIE.dgs004_1_2_nml,
					DirectionManager.MOVIE.dgs004_2_2_nml,
					DirectionManager.MOVIE.dgs004_3_2_nml,
					DirectionManager.MOVIE.dgs004_4_2_nml,
					DirectionManager.MOVIE.dgs004_5_2_nml,
					DirectionManager.MOVIE.dgs004_6_2_nml,
					DirectionManager.MOVIE.dgs004_7_2_nml,
					DirectionManager.MOVIE.dgs004_8_2_nml,
					DirectionManager.MOVIE.dgs004_9_2_nml
				};
				DirectionManager.MOVIE[] array6 = new DirectionManager.MOVIE[10]
				{
					DirectionManager.MOVIE.dgs004_0_1_loop,
					DirectionManager.MOVIE.dgs004_1_1_loop,
					DirectionManager.MOVIE.dgs004_2_1_loop,
					DirectionManager.MOVIE.dgs004_3_1_loop,
					DirectionManager.MOVIE.dgs004_4_1_loop,
					DirectionManager.MOVIE.dgs004_5_1_loop,
					DirectionManager.MOVIE.dgs004_6_1_loop,
					DirectionManager.MOVIE.dgs004_7_1_loop,
					DirectionManager.MOVIE.dgs004_8_1_loop,
					DirectionManager.MOVIE.dgs004_9_1_loop
				};
				if (num5 == 0 && num4 == 0 && num3 == 0)
				{
					evt.eventPlayMovie(array[num2], false, false, false, true, 128, 72, 80, 27);
					evt.eventAddMovie(array6[num2], array[num2], false, true, false, true);
					evt.eventPlayMovie(DirectionManager.MOVIE.dgs004_10, false, false, false, true, 11, 81, 76, 45);
					evt.eventPlayMovie(DirectionManager.MOVIE.dgs004_10_loop, false, true, false, true, 86, 81, 76, 58);
					evt.eventMovieSlide(76f, 11f, 81f, 86f, 81f, 2, 45);
				}
				else if (num5 == 0 && num4 == 0)
				{
					evt.eventPlayMovie(array2[num2], false, false, false, true, 308, 72, 80, 27);
					evt.eventPlayMovie(array5[num2], false, false, false, true, 164, 72, 80, 49);
					evt.eventPlayMovie(array6[num2], false, true, false, true, 164, 72, 80, 60);
					evt.eventPlayMovie(array2[num3], false, false, false, true, -28, 72, 79, 27);
					evt.eventPlayMovie(array5[num3], false, false, false, true, 116, 72, 79, 48);
					evt.eventPlayMovie(array6[num3], false, true, false, true, 116, 72, 79, 60);
					evt.eventPlayMovie(DirectionManager.MOVIE.dgs004_10, false, false, false, true, 0, 81, 76, 48);
					evt.eventPlayMovie(DirectionManager.MOVIE.dgs004_10_loop, false, true, false, true, 70, 81, 76, 60);
					evt.eventMovieSlide(80f, 308f, 72f, 164f, 72f, 5, 27);
					evt.eventMovieSlide(79f, -28f, 72f, 116f, 72f, 5, 27);
					evt.eventMovieSlide(76f, 0f, 81f, 70f, 81f, 3, 48);
				}
				else if (num5 == 0)
				{
					evt.eventPlayMovie(array2[num2], false, false, false, true, 330, 72, 80, 27);
					evt.eventPlayMovie(array5[num2], false, false, false, true, 186, 72, 80, 54);
					evt.eventPlayMovie(array6[num2], false, true, false, true, 186, 72, 80, 65);
					evt.eventPlayMovie(array3[num3], false, false, false, true, 138, 72, 79, 29);
					evt.eventPlayMovie(array5[num3], false, false, false, true, 138, 72, 79, 53);
					evt.eventPlayMovie(array6[num3], false, true, false, true, 138, 72, 79, 65);
					evt.eventPlayMovie(array2[num4], false, false, false, true, -59, 72, 78, 27);
					evt.eventPlayMovie(array5[num4], false, false, false, true, 89, 72, 78, 52);
					evt.eventPlayMovie(array6[num4], false, true, false, true, 89, 72, 78, 65);
					evt.eventPlayMovie(DirectionManager.MOVIE.dgs004_10, false, false, false, true, -10, 81, 76, 48);
					evt.eventPlayMovie(DirectionManager.MOVIE.dgs004_10_loop, false, true, false, true, 47, 81, 76, 65);
					evt.eventMovieSlide(80f, 330f, 72f, 186f, 72f, 7, 27);
					evt.eventMovieSlide(78f, -59f, 72f, 89f, 72f, 7, 27);
					evt.eventMovieSlide(76f, -10f, 81f, 47f, 81f, 5, 48);
				}
				else
				{
					evt.eventPlayMovie(array2[num2], false, false, false, true, 314, 72, 80, 31);
					evt.eventPlayMovie(array5[num2], false, false, false, true, 210, 72, 80, 57);
					evt.eventPlayMovie(array6[num2], false, true, false, true, 210, 72, 80, 76);
					evt.eventPlayMovie(array4[num3], false, false, false, true, 308, 72, 79, 26);
					evt.eventPlayMovie(array5[num3], false, false, false, true, 164, 72, 79, 56);
					evt.eventPlayMovie(array6[num3], false, true, false, true, 164, 72, 79, 76);
					evt.eventPlayMovie(array4[num4], false, false, false, true, -14, 72, 78, 26);
					evt.eventPlayMovie(array5[num4], false, false, false, true, 116, 72, 78, 55);
					evt.eventPlayMovie(array6[num4], false, true, false, true, 116, 72, 78, 76);
					evt.eventPlayMovie(array2[num5], false, false, false, true, -43, 72, 77, 31);
					evt.eventPlayMovie(array5[num5], false, false, false, true, 70, 72, 77, 54);
					evt.eventPlayMovie(array6[num5], false, true, false, true, 70, 72, 77, 76);
					evt.eventPlayMovie(DirectionManager.MOVIE.dgs004_10, false, false, false, true, 14, 81, 76, 53);
					evt.eventPlayMovie(DirectionManager.MOVIE.dgs004_10_loop, false, true, false, true, 28, 81, 76, 76);
					evt.eventMovieSlide(80f, 314f, 72f, 210f, 72f, 5, 31);
					evt.eventMovieSlide(79f, 308f, 72f, 163f, 72f, 5, 26);
					evt.eventMovieSlide(78f, -14f, 72f, 117f, 72f, 5, 26);
					evt.eventMovieSlide(77f, -43f, 72f, 70f, 72f, 5, 31);
					evt.eventMovieSlide(76f, -14f, 81f, 28f, 81f, 3, 53);
				}
			}
		}
		base.start();
	}

	public override void end()
	{
		if (low == 1 && mode == 1)
		{
			kpr_killMovie(80f);
			kpr_killMovie(79f);
			kpr_killMovie(78f);
			kpr_killMovie(77f);
			kpr_killMovie(76f);
		}
		base.end();
	}

	public override void control()
	{
		base.control();
	}

	public void kpr_killMovie(float layer)
	{
		int num = SGLG.prod.findLayer(layer);
		if (num >= 0)
		{
			SGLG.prod.Kill(num);
		}
	}
}
