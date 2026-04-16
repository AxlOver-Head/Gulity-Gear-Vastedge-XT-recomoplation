public class Direction47KSY : DirectionBase
{
	public Direction47KSY(DirectionManager _mng, byte _high, byte _low, byte _mode, DirectionManager.DIR _dir)
		: base(_mng, _high, _low, _mode, _dir, DirectionBase.PRIORITY_NORMAL)
	{
	}

	public override void start()
	{
		if (mode == 10)
		{
			evt.eventDisableBefore(mng, 0);
		}
		if (low == 0)
		{
			switch (mode)
			{
			case 1:
				evt.eventPlayMovie(DirectionManager.MOVIE.ksy001_1, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0236, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0252, Sound.CH.SE0, true, 1f, 25);
				evt.eventPlaySound(DirectionManager.SOUND.S1946, Sound.CH.SE0, true, 1f, 45);
				break;
			case 2:
				evt.eventPlayMovie(DirectionManager.MOVIE.ksy002_1, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0237, Sound.CH.SE0, true, 1f, 0);
				break;
			case 3:
				evt.eventPlayMovie(DirectionManager.MOVIE.ksy007_1, true, false, false, false, 0, 0, 100, 0);
				break;
			case 4:
				evt.eventPlayMovie(DirectionManager.MOVIE.ksy004_1, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0246, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0252, Sound.CH.SE0, true, 1f, 15);
				evt.eventPlaySound(DirectionManager.SOUND.S1946, Sound.CH.SE0, true, 1f, 35);
				break;
			case 5:
				evt.eventPlayMovie(DirectionManager.MOVIE.ksy008_1, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0246, Sound.CH.SE0, true, 1f, 0);
				break;
			case 6:
				evt.eventPlayMovie(DirectionManager.MOVIE.ksy003_1, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0238, Sound.CH.SE0, true, 1f, 0);
				break;
			case 7:
				evt.eventPlayMovie(DirectionManager.MOVIE.ksy006_1, true, false, false, false, 0, 0, 100, 0);
				break;
			case 8:
				evt.eventPlayMovie(DirectionManager.MOVIE.ksy005_1, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0247, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0252, Sound.CH.SE0, true, 1f, 12);
				evt.eventPlaySound(DirectionManager.SOUND.S1946, Sound.CH.SE0, true, 1f, 32);
				break;
			case 9:
				evt.eventPlayMovie(DirectionManager.MOVIE.ksy009_1, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0247, Sound.CH.SE0, true, 1f, 0);
				break;
			case 10:
				evt.eventPlayMovie(DirectionManager.MOVIE.ksy011_1, false, true, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0250, Sound.CH.SE0, true, 1f, 0);
				break;
			case 11:
				evt.eventPlayMovie(DirectionManager.MOVIE.ksy012_1, false, true, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0251, Sound.CH.SE0, true, 1f, 0);
				break;
			case 12:
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksy013_a_1, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ksy013_b, DirectionManager.MOVIE.ksy013_a_1, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.ksy013_b_loop, DirectionManager.MOVIE.ksy013_b, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0235, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0522, Sound.CH.SE0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0523, Sound.CH.SE0, true, 1f, 10);
				evt.eventPlaySound(DirectionManager.SOUND.S1653, Sound.CH.VC0, true, 1f, 60);
				evt.eventPlaySound(DirectionManager.SOUND.S0555, Sound.CH.SE0, true, 1f, 129);
				break;
			case 13:
				evt.eventPlayMovie(DirectionManager.MOVIE.ksy010_1, true, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0235, Sound.CH.SE0, true, 1f, 1);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 110, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				break;
			case 14:
				evt.eventPlayMovie(DirectionManager.MOVIE.ksy014_1, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0252, Sound.CH.SE0, true, 1f, 1);
				evt.eventPlaySound(DirectionManager.SOUND.S1946, Sound.CH.SE0, true, 1f, 21);
				break;
			case 15:
				evt.eventPlayMovie(DirectionManager.MOVIE.ksy000_2, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0248, Sound.CH.SE0, true, 1f, 0);
				break;
			case 16:
				evt.eventPlayMovie(DirectionManager.MOVIE.ksy011_2, false, true, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0250, Sound.CH.SE0, true, 1f, 0);
				break;
			case 17:
				evt.eventPlayMovie(DirectionManager.MOVIE.ksy012_2, false, true, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0251, Sound.CH.SE0, true, 1f, 0);
				break;
			case 18:
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksy013_a_2, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ksy013_b, DirectionManager.MOVIE.ksy013_a_2, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.ksy013_b_loop, DirectionManager.MOVIE.ksy013_b, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0235, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0522, Sound.CH.SE0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0523, Sound.CH.SE0, true, 1f, 10);
				evt.eventPlaySound(DirectionManager.SOUND.S1653, Sound.CH.VC0, true, 1f, 60);
				evt.eventPlaySound(DirectionManager.SOUND.S0555, Sound.CH.SE0, true, 1f, 129);
				break;
			case 19:
				evt.eventPlayMovie(DirectionManager.MOVIE.ksy010_2, true, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0235, Sound.CH.SE0, true, 1f, 1);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 110, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				break;
			case 20:
				evt.eventPlayMovie(DirectionManager.MOVIE.ksy014_2, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0252, Sound.CH.SE0, true, 1f, 1);
				evt.eventPlaySound(DirectionManager.SOUND.S1946, Sound.CH.SE0, true, 1f, 21);
				break;
			case 21:
				evt.eventPlayMovie(DirectionManager.MOVIE.ksy000_3, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0249, Sound.CH.SE0, true, 1f, 0);
				break;
			case 22:
				evt.eventPlayMovie(DirectionManager.MOVIE.ksy011_3, false, true, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0250, Sound.CH.SE0, true, 1f, 0);
				break;
			case 23:
				evt.eventPlayMovie(DirectionManager.MOVIE.ksy012_3, false, true, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0251, Sound.CH.SE0, true, 1f, 0);
				break;
			case 24:
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksy013_a_3, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ksy013_b, DirectionManager.MOVIE.ksy013_a_3, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.ksy013_b_loop, DirectionManager.MOVIE.ksy013_b, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0235, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0522, Sound.CH.SE0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0523, Sound.CH.SE0, true, 1f, 10);
				evt.eventPlaySound(DirectionManager.SOUND.S1653, Sound.CH.VC0, true, 1f, 60);
				evt.eventPlaySound(DirectionManager.SOUND.S0555, Sound.CH.SE0, true, 1f, 129);
				break;
			case 25:
				evt.eventPlayMovie(DirectionManager.MOVIE.ksy010_3, true, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0235, Sound.CH.SE0, true, 1f, 1);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 110, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				break;
			case 26:
				evt.eventPlayMovie(DirectionManager.MOVIE.ksy014_3, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0252, Sound.CH.SE0, true, 1f, 1);
				evt.eventPlaySound(DirectionManager.SOUND.S1946, Sound.CH.SE0, true, 1f, 21);
				break;
			case 27:
				evt.eventPlayMovie(DirectionManager.MOVIE.ksy001_2, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0248, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0252, Sound.CH.SE0, true, 1f, 25);
				evt.eventPlaySound(DirectionManager.SOUND.S1946, Sound.CH.SE0, true, 1f, 45);
				break;
			case 28:
				evt.eventPlayMovie(DirectionManager.MOVIE.ksy001_3, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0249, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0252, Sound.CH.SE0, true, 1f, 25);
				evt.eventPlaySound(DirectionManager.SOUND.S1946, Sound.CH.SE0, true, 1f, 45);
				break;
			}
		}
		if (low == 0)
		{
			switch (mode)
			{
			case 1:
				DirectionLedManager.SE_KSY_close_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.GD_KSY_close(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 2:
				DirectionLedManager.GD_KSY_half(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 3:
				DirectionLedManager.OFF_5(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 4:
				DirectionLedManager.SE_KSY_close_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.GD_KSY_close(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 5:
				DirectionLedManager.SE_KSY_close_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.GD_KSY_close(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 6:
				DirectionLedManager.GD_KSY_half(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 7:
				DirectionLedManager.OFF_5(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 8:
				DirectionLedManager.SE_KSY_close_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.GD_KSY_close(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 9:
				DirectionLedManager.SE_KSY_close_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.GD_KSY_close(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 12:
				DirectionLedManager.GH_BZT_bal_entry(DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE));
				DirectionLedManager.OFF_1(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_1));
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.OFF_3(DirectionLedManager.changeLineNum(LEDMainManager.LINE.UNDERPANEL));
				DirectionLedManager.OFF_4(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				DirectionLedManager.OFF_5(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.OFF_6(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				DirectionLedManager.OFF_7(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 13:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.OFF_5(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 15:
				DirectionLedManager.SE_KSY_close_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.GD_KSY_close(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 18:
				DirectionLedManager.GH_BZT_bal_entry(DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE));
				DirectionLedManager.OFF_1(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_1));
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.OFF_3(DirectionLedManager.changeLineNum(LEDMainManager.LINE.UNDERPANEL));
				DirectionLedManager.OFF_4(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				DirectionLedManager.OFF_5(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.OFF_6(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				DirectionLedManager.OFF_7(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 19:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.OFF_5(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 21:
				DirectionLedManager.SE_KSY_close_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.GD_KSY_close(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 24:
				DirectionLedManager.GH_BZT_bal_entry(DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE));
				DirectionLedManager.OFF_1(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_1));
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.OFF_3(DirectionLedManager.changeLineNum(LEDMainManager.LINE.UNDERPANEL));
				DirectionLedManager.OFF_4(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				DirectionLedManager.OFF_5(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.OFF_6(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				DirectionLedManager.OFF_7(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 25:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.OFF_5(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 27:
				DirectionLedManager.SE_KSY_close_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.GD_KSY_close(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 28:
				DirectionLedManager.SE_KSY_close_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.GD_KSY_close(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 29:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.OFF_5(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 30:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.OFF_5(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 31:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.OFF_5(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			}
		}
		if (mode == 13 || mode == 19 || mode == 25)
		{
			ksyAddGame();
		}
		base.start();
	}

	public void ksyAddGame()
	{
		int num = 0;
		int cntARTGameLastADD = MainGameScene.slotGameMan.m_CntARTGameLastADD;
		int num2 = cntARTGameLastADD % 10;
		int num3 = cntARTGameLastADD / 10 % 10;
		int num4 = cntARTGameLastADD / 100 % 10;
		int num5 = cntARTGameLastADD / 1000;
		if (cntARTGameLastADD > 0)
		{
			DirectionManager.IMAGE[] array = new DirectionManager.IMAGE[10]
			{
				DirectionManager.IMAGE.bao4210_num_0,
				DirectionManager.IMAGE.bao4210_num_1,
				DirectionManager.IMAGE.bao4210_num_2,
				DirectionManager.IMAGE.bao4210_num_3_00007,
				DirectionManager.IMAGE.bao4210_num_4_00007,
				DirectionManager.IMAGE.bao4210_num_5_00007,
				DirectionManager.IMAGE.bao4210_num_6_00007,
				DirectionManager.IMAGE.bao4210_num_7_00007,
				DirectionManager.IMAGE.bao4210_num_8_00007,
				DirectionManager.IMAGE.bao4210_num_9_00007
			};
			DirectionManager.MOVIE[] array2 = new DirectionManager.MOVIE[10]
			{
				DirectionManager.MOVIE.bao4210_num_0_add,
				DirectionManager.MOVIE.bao4210_num_1_add,
				DirectionManager.MOVIE.bao4210_num_2_add,
				DirectionManager.MOVIE.bao4210_num_3_add,
				DirectionManager.MOVIE.bao4210_num_4_add,
				DirectionManager.MOVIE.bao4210_num_5_add,
				DirectionManager.MOVIE.bao4210_num_6_add,
				DirectionManager.MOVIE.bao4210_num_7_add,
				DirectionManager.MOVIE.bao4210_num_8_add,
				DirectionManager.MOVIE.bao4210_num_9_add
			};
			if (num5 == 0 && num4 == 0 && num3 == 0)
			{
				evt.eventPlayMovie(DirectionManager.MOVIE.bao4210_1_dummy, true, false, false, true, 128, 88, 80, 0 + num);
				evt.eventPlayImage(array[num2], false, true, 121, 88, 79, 10 + num);
				evt.eventPlayMovie(array2[num2], false, true, true, true, 121, 88, 75, 14 + num);
				evt.eventPlayMovie(DirectionManager.MOVIE.bao4210_total_1, false, false, false, true, 128, 72, 71, 10 + num);
				evt.eventAddMovie(DirectionManager.MOVIE.bao4210_total_1_loop, DirectionManager.MOVIE.bao4210_total_1, false, true, false, true);
			}
			else if (num5 == 0 && num4 == 0)
			{
				evt.eventPlayMovie(DirectionManager.MOVIE.bao4210_2_dummy, true, false, false, true, 128, 88, 80, 0 + num);
				evt.eventPlayImage(array[num2], false, true, 155, 88, 79, 10 + num);
				evt.eventPlayImage(array[num3], false, true, 99, 88, 78, 12 + num);
				evt.eventPlayMovie(array2[num2], false, true, true, true, 155, 88, 75, 12 + num);
				evt.eventPlayMovie(array2[num3], false, true, true, true, 99, 88, 74, 17 + num);
				evt.eventPlayMovie(DirectionManager.MOVIE.bao4210_total_2, false, false, false, true, 128, 72, 71, 10 + num);
				evt.eventAddMovie(DirectionManager.MOVIE.bao4210_total_2_loop, DirectionManager.MOVIE.bao4210_total_2, false, true, false, true);
			}
			else if (num5 == 0)
			{
				evt.eventPlayMovie(DirectionManager.MOVIE.bao4210_3_dummy, true, false, false, true, 128, 88, 80, 0 + num);
				evt.eventPlayImage(array[num2], false, true, 181, 88, 79, 10 + num);
				evt.eventPlayImage(array[num3], false, true, 132, 88, 78, 12 + num);
				evt.eventPlayImage(array[num4], false, true, 84, 88, 77, 14 + num);
				evt.eventPlayMovie(array2[num2], false, true, true, true, 181, 88, 75, 14 + num);
				evt.eventPlayMovie(array2[num3], false, true, true, true, 132, 88, 74, 19 + num);
				evt.eventPlayMovie(array2[num4], false, true, true, true, 84, 88, 73, 24 + num);
				evt.eventPlayMovie(DirectionManager.MOVIE.bao4210_total_3, false, false, false, true, 128, 72, 71, 10 + num);
				evt.eventAddMovie(DirectionManager.MOVIE.bao4210_total_3_loop, DirectionManager.MOVIE.bao4210_total_3, false, true, false, true);
			}
			else
			{
				evt.eventPlayMovie(DirectionManager.MOVIE.bao4210_4_dummy, true, false, false, true, 128, 88, 80, 0 + num);
				evt.eventPlayImage(array[num2], false, true, 217, 88, 79, 11 + num);
				evt.eventPlayImage(array[num3], false, true, 168, 88, 78, 12 + num);
				evt.eventPlayImage(array[num4], false, true, 119, 88, 77, 14 + num);
				evt.eventPlayImage(array[num5], false, true, 70, 88, 76, 15 + num);
				evt.eventPlayMovie(array2[num2], false, true, true, true, 217, 88, 75, 12 + num);
				evt.eventPlayMovie(array2[num3], false, true, true, true, 168, 88, 74, 17 + num);
				evt.eventPlayMovie(array2[num4], false, true, true, true, 119, 88, 73, 22 + num);
				evt.eventPlayMovie(array2[num5], false, true, true, true, 70, 88, 72, 27 + num);
				evt.eventPlayMovie(DirectionManager.MOVIE.bao4210_total_4, false, false, false, true, 128, 72, 71, 10 + num);
				evt.eventAddMovie(DirectionManager.MOVIE.bao4210_total_4_loop, DirectionManager.MOVIE.bao4210_total_4, false, true, false, true);
			}
			if (cntARTGameLastADD <= 10)
			{
				evt.eventPlaySound(DirectionManager.SOUND.S0224, Sound.CH.SE0, false, 1f, num);
			}
			else if (cntARTGameLastADD <= 20)
			{
				evt.eventPlaySound(DirectionManager.SOUND.S0225, Sound.CH.SE0, false, 1f, num);
			}
			else if (cntARTGameLastADD <= 30)
			{
				evt.eventPlaySound(DirectionManager.SOUND.S0226, Sound.CH.SE0, false, 1f, num);
			}
			else if (cntARTGameLastADD <= 50)
			{
				evt.eventPlaySound(DirectionManager.SOUND.S0227, Sound.CH.SE0, false, 1f, num);
			}
			else if (cntARTGameLastADD <= 100)
			{
				evt.eventPlaySound(DirectionManager.SOUND.S0228, Sound.CH.SE0, false, 1f, num);
			}
			else if (cntARTGameLastADD <= 150)
			{
				evt.eventPlaySound(DirectionManager.SOUND.S0229, Sound.CH.SE0, false, 1f, num);
			}
			else if (cntARTGameLastADD <= 200)
			{
				evt.eventPlaySound(DirectionManager.SOUND.S0230, Sound.CH.SE0, false, 1f, num);
			}
			else
			{
				evt.eventPlaySound(DirectionManager.SOUND.S0231, Sound.CH.SE0, false, 1f, num);
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
	}
}
