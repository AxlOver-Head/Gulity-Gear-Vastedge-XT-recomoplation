public class Direction86YTG : DirectionBase
{
	public Direction86YTG(DirectionManager _mng, byte _high, byte _low, byte _mode, DirectionManager.DIR _dir)
		: base(_mng, _high, _low, _mode, _dir, DirectionBase.PRIORITY_NORMAL)
	{
	}

	public override void start()
	{
		base.start();
		if (low == 0)
		{
			switch (mode)
			{
			case 1:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ytg001_a, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0440, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1017, Sound.CH.VC0, true, 1f, 25);
				evt.eventPlaySound(DirectionManager.SOUND.S0067, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0068, Sound.CH.SE1, true, 1f, 16);
				MainGameScene.yakuMan.start(YakuManager.KIND.CUBE, 77);
				break;
			case 2:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ytg001_b, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg001_b_loop, DirectionManager.MOVIE.ytg001_b, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0441, Sound.CH.SE0, true, 1f, 0);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1409();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1410();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1411();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1412();
				break;
			case 3:
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, true, 128, 119, 90, 9);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, true);
				evt.eventPlaySound(DirectionManager.SOUND.S0223, Sound.CH.SE0, true, 1f, 5);
				evt.eventPlaySound(DirectionManager.SOUND.S1012, Sound.CH.VC0, true, 1f, 14);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_add, false, false, true, false, 0, 0, 80, 0);
				break;
			case 4:
				evt.eventPlayMovie(DirectionManager.MOVIE.push_b, false, false, false, false, 0, 0, 90, 9);
				evt.eventAddMovie(DirectionManager.MOVIE.push_b_loop, DirectionManager.MOVIE.push_b, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0233, Sound.CH.SE0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S1012, Sound.CH.VC0, true, 1f, 14);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_b_add, false, false, true, false, 0, 0, 80, 0);
				break;
			case 6:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ytg001_c, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg001_c, DirectionManager.MOVIE.ytg001_c, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0442, Sound.CH.SE0, true, 1f, 0);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1413();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1414();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1415();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1416();
				break;
			case 7:
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, true, 128, 119, 90, 9);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, true);
				evt.eventPlaySound(DirectionManager.SOUND.S0223, Sound.CH.SE0, true, 1f, 5);
				evt.eventPlaySound(DirectionManager.SOUND.S1012, Sound.CH.VC0, true, 1f, 14);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_add, false, false, true, false, 0, 0, 80, 0);
				break;
			case 8:
				evt.eventPlayMovie(DirectionManager.MOVIE.push_b, false, false, false, false, 0, 0, 90, 9);
				evt.eventAddMovie(DirectionManager.MOVIE.push_b_loop, DirectionManager.MOVIE.push_b, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0233, Sound.CH.SE0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S1012, Sound.CH.VC0, true, 1f, 14);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_b_add, false, false, true, false, 0, 0, 80, 0);
				break;
			case 10:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ytg006, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg002, DirectionManager.MOVIE.ytg006, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0443, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0890, Sound.CH.VC0, true, 1f, 73);
				evt.eventPlaySound(DirectionManager.SOUND.S0067, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0068, Sound.CH.SE1, true, 1f, 58);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1417();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1418();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1419();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1420();
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 90, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 11:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ytg006, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003, DirectionManager.MOVIE.ytg006, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003_loop, DirectionManager.MOVIE.ytg003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0443, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0891, Sound.CH.VC0, true, 1f, 100);
				evt.eventPlaySound(DirectionManager.SOUND.S0067, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0092, Sound.CH.SE0, true, 1f, 58);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1421();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1422();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1423();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1424();
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 90, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 12:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ytg006, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003, DirectionManager.MOVIE.ytg006, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003_loop, DirectionManager.MOVIE.ytg003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0443, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0893, Sound.CH.VC0, true, 1f, 90);
				evt.eventPlaySound(DirectionManager.SOUND.S0067, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0070, Sound.CH.SE0, true, 1f, 38);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1425();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1426();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1427();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1428();
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 90, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 13:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ytg006, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003, DirectionManager.MOVIE.ytg006, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003_loop, DirectionManager.MOVIE.ytg003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0443, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0891, Sound.CH.VC0, true, 1f, 128);
				evt.eventPlaySound(DirectionManager.SOUND.S0067, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0071, Sound.CH.SE0, true, 1f, 48);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1429();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1430();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1431();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1432();
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 90, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 14:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ytg006, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003, DirectionManager.MOVIE.ytg006, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003_loop, DirectionManager.MOVIE.ytg003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0443, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0894, Sound.CH.VC0, true, 1f, 90);
				evt.eventPlaySound(DirectionManager.SOUND.S0067, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0071, Sound.CH.SE0, true, 1f, 43);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1433();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1434();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1435();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1436();
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 90, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 15:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0891, Sound.CH.VC0, true, 1f, 124);
				evt.eventPlaySound(DirectionManager.SOUND.S0067, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0092, Sound.CH.SE0, true, 1f, 94);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1437();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1438();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1439();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1440();
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 90, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 16:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0891, Sound.CH.VC0, true, 1f, 170);
				evt.eventPlaySound(DirectionManager.SOUND.S0067, Sound.CH.SE1, true, 1f, 36);
				evt.eventPlaySound(DirectionManager.SOUND.S0071, Sound.CH.SE0, true, 1f, 90);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1441();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1442();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1443();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1444();
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 90, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 17:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ytg006, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003, DirectionManager.MOVIE.ytg006, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003_loop, DirectionManager.MOVIE.ytg003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0443, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0891, Sound.CH.VC0, true, 1f, 100);
				evt.eventPlaySound(DirectionManager.SOUND.S0067, Sound.CH.SE1, false, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0092, Sound.CH.SE0, false, 1f, 58);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1446();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1447();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1448();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1449();
				evt.eventPlayMovie(DirectionManager.MOVIE.btd003, false, false, false, true, 128, 72, 95, 77);
				evt.eventAddMovie(DirectionManager.MOVIE.btd003_loop, DirectionManager.MOVIE.btd003, false, true, false, true);
				evt.eventPlaySound(DirectionManager.SOUND.S0257, Sound.CH.SE1, true, 1f, 70);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 90, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 18:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ytg006, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003, DirectionManager.MOVIE.ytg006, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003_loop, DirectionManager.MOVIE.ytg003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0443, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0067, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0092, Sound.CH.SE0, true, 1f, 58);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1450();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1451();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1452();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1453();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_10, false, false, true, false, 0, 0, 95, 77);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_10_loop, DirectionManager.MOVIE.huc008_T_10, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0224, Sound.CH.SE1, true, 1f, 70);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 90, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 19:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ytg006, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003, DirectionManager.MOVIE.ytg006, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003_loop, DirectionManager.MOVIE.ytg003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0443, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0067, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0092, Sound.CH.SE0, true, 1f, 58);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1454();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1455();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1456();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1457();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_20, false, false, true, false, 0, 0, 95, 77);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_20_loop, DirectionManager.MOVIE.huc008_T_20, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0225, Sound.CH.SE1, true, 1f, 70);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 90, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 20:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ytg006, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003, DirectionManager.MOVIE.ytg006, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003_loop, DirectionManager.MOVIE.ytg003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0443, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0067, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0092, Sound.CH.SE0, true, 1f, 58);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1458();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1459();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1460();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1461();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_30, false, false, true, false, 0, 0, 95, 77);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_30_loop, DirectionManager.MOVIE.huc008_T_30, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0226, Sound.CH.SE1, true, 1f, 70);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 90, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 21:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ytg006, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003, DirectionManager.MOVIE.ytg006, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003_loop, DirectionManager.MOVIE.ytg003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0443, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0067, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0092, Sound.CH.SE0, true, 1f, 58);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1462();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1463();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1464();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1465();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_50, false, false, true, false, 0, 0, 95, 77);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_50_loop, DirectionManager.MOVIE.huc008_T_50, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0227, Sound.CH.SE1, true, 1f, 70);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 90, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 22:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ytg006, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003, DirectionManager.MOVIE.ytg006, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003_loop, DirectionManager.MOVIE.ytg003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0443, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0067, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0092, Sound.CH.SE0, true, 1f, 58);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1466();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1467();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1468();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1469();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_100, false, false, true, false, 0, 0, 95, 77);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_100_loop, DirectionManager.MOVIE.huc008_T_100, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0228, Sound.CH.SE1, true, 1f, 70);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 90, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 23:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ytg006, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003, DirectionManager.MOVIE.ytg006, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003_loop, DirectionManager.MOVIE.ytg003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0443, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0067, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0092, Sound.CH.SE0, true, 1f, 58);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1470();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1471();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1472();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1473();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_150, false, false, true, false, 0, 0, 95, 77);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_150_loop, DirectionManager.MOVIE.huc008_T_150, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0229, Sound.CH.SE1, true, 1f, 70);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 90, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 24:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ytg006, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003, DirectionManager.MOVIE.ytg006, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003_loop, DirectionManager.MOVIE.ytg003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0443, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0067, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0092, Sound.CH.SE0, true, 1f, 58);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1474();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1475();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1476();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1477();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_200, false, false, true, false, 0, 0, 95, 77);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_200_loop, DirectionManager.MOVIE.huc008_T_200, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0230, Sound.CH.SE1, true, 1f, 70);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 90, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 25:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ytg006, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003, DirectionManager.MOVIE.ytg006, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003_loop, DirectionManager.MOVIE.ytg003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0443, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0067, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0092, Sound.CH.SE0, true, 1f, 58);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1478();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1479();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1480();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1481();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_300, false, false, true, false, 0, 0, 95, 77);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_300_loop, DirectionManager.MOVIE.huc008_T_300, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0231, Sound.CH.SE1, true, 1f, 70);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 90, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 26:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0891, Sound.CH.VC0, true, 1f, 124);
				evt.eventPlaySound(DirectionManager.SOUND.S0067, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0092, Sound.CH.SE0, true, 1f, 94);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1482();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1483();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1484();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1485();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1486();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_50, false, false, true, false, 0, 0, 95, 77);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_50_loop, DirectionManager.MOVIE.huc008_T_50, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0227, Sound.CH.SE1, true, 1f, 70);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 90, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 27:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0891, Sound.CH.VC0, true, 1f, 124);
				evt.eventPlaySound(DirectionManager.SOUND.S0067, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0092, Sound.CH.SE0, true, 1f, 94);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1482();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1487();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1488();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1489();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1490();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_100, false, false, true, false, 0, 0, 95, 77);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_100_loop, DirectionManager.MOVIE.huc008_T_100, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0228, Sound.CH.SE1, true, 1f, 70);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 90, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 28:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0891, Sound.CH.VC0, true, 1f, 124);
				evt.eventPlaySound(DirectionManager.SOUND.S0067, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0092, Sound.CH.SE0, true, 1f, 94);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1482();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1491();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1492();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1493();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1494();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_150, false, false, true, false, 0, 0, 95, 77);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_150_loop, DirectionManager.MOVIE.huc008_T_150, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0229, Sound.CH.SE1, true, 1f, 70);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 90, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 29:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0891, Sound.CH.VC0, true, 1f, 124);
				evt.eventPlaySound(DirectionManager.SOUND.S0067, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0092, Sound.CH.SE0, true, 1f, 94);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1482();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1495();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1496();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1497();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1498();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_200, false, false, true, false, 0, 0, 95, 77);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_200_loop, DirectionManager.MOVIE.huc008_T_200, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0230, Sound.CH.SE1, true, 1f, 70);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 90, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 30:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0891, Sound.CH.VC0, true, 1f, 124);
				evt.eventPlaySound(DirectionManager.SOUND.S0067, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0092, Sound.CH.SE0, true, 1f, 94);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1482();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1499();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1500();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1501();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1502();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_300, false, false, true, false, 0, 0, 95, 77);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_300_loop, DirectionManager.MOVIE.huc008_T_300, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0231, Sound.CH.SE1, true, 1f, 70);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 90, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 31:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ytg006, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg002, DirectionManager.MOVIE.ytg006, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0443, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0890, Sound.CH.VC0, true, 1f, 73);
				evt.eventPlaySound(DirectionManager.SOUND.S0067, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0068, Sound.CH.SE1, true, 1f, 58);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1417();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1418();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1419();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1420();
				break;
			case 32:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ytg006, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003, DirectionManager.MOVIE.ytg006, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003_loop, DirectionManager.MOVIE.ytg003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0443, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0891, Sound.CH.VC0, true, 1f, 100);
				evt.eventPlaySound(DirectionManager.SOUND.S0067, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0092, Sound.CH.SE0, true, 1f, 58);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1421();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1422();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1423();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1424();
				break;
			case 33:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ytg006, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003, DirectionManager.MOVIE.ytg006, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003_loop, DirectionManager.MOVIE.ytg003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0443, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0893, Sound.CH.VC0, true, 1f, 90);
				evt.eventPlaySound(DirectionManager.SOUND.S0067, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0070, Sound.CH.SE0, true, 1f, 38);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1425();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1426();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1427();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1428();
				break;
			case 34:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ytg006, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003, DirectionManager.MOVIE.ytg006, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003_loop, DirectionManager.MOVIE.ytg003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0443, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0891, Sound.CH.VC0, true, 1f, 128);
				evt.eventPlaySound(DirectionManager.SOUND.S0067, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0071, Sound.CH.SE0, true, 1f, 48);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1429();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1430();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1431();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1432();
				break;
			case 35:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ytg006, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003, DirectionManager.MOVIE.ytg006, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003_loop, DirectionManager.MOVIE.ytg003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0443, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0894, Sound.CH.VC0, true, 1f, 90);
				evt.eventPlaySound(DirectionManager.SOUND.S0067, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0071, Sound.CH.SE0, true, 1f, 43);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1433();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1434();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1435();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1436();
				break;
			case 36:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ytg006, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg005, DirectionManager.MOVIE.ytg006, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0443, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0444, Sound.CH.SE0, true, 1f, 67);
				evt.eventPlaySound(DirectionManager.SOUND.S0895, Sound.CH.VC0, true, 1f, 71);
				evt.eventPlaySound(DirectionManager.SOUND.S0218, Sound.CH.SE0, true, 1f, 82);
				evt.eventPlaySound(DirectionManager.SOUND.S0067, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0068, Sound.CH.SE1, true, 1f, 35);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1508();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1509();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1510();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1511();
				break;
			case 37:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ytg006, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg005, DirectionManager.MOVIE.ytg006, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0443, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0444, Sound.CH.SE0, true, 1f, 67);
				evt.eventPlaySound(DirectionManager.SOUND.S0895, Sound.CH.VC0, true, 1f, 71);
				evt.eventPlaySound(DirectionManager.SOUND.S0218, Sound.CH.SE0, true, 1f, 82);
				evt.eventPlaySound(DirectionManager.SOUND.S0067, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0068, Sound.CH.SE1, true, 1f, 40);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1512();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1513();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1514();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1515();
				break;
			case 38:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ytg006, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg005, DirectionManager.MOVIE.ytg006, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0443, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0444, Sound.CH.SE0, true, 1f, 67);
				evt.eventPlaySound(DirectionManager.SOUND.S0895, Sound.CH.VC0, true, 1f, 71);
				evt.eventPlaySound(DirectionManager.SOUND.S0218, Sound.CH.SE0, true, 1f, 82);
				evt.eventPlaySound(DirectionManager.SOUND.S0067, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0068, Sound.CH.SE1, true, 1f, 45);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1516();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1517();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1518();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1519();
				break;
			case 39:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ytg006, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg005, DirectionManager.MOVIE.ytg006, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0443, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0444, Sound.CH.SE0, true, 1f, 67);
				evt.eventPlaySound(DirectionManager.SOUND.S0895, Sound.CH.VC0, true, 1f, 71);
				evt.eventPlaySound(DirectionManager.SOUND.S0218, Sound.CH.SE0, true, 1f, 82);
				evt.eventPlaySound(DirectionManager.SOUND.S0067, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0068, Sound.CH.SE1, true, 1f, 53);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1520();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1521();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1522();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1523();
				break;
			case 40:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ytg006, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003, DirectionManager.MOVIE.ytg006, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003_loop, DirectionManager.MOVIE.ytg003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0443, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0891, Sound.CH.VC0, true, 1f, 100);
				evt.eventPlaySound(DirectionManager.SOUND.S0067, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0092, Sound.CH.SE1, true, 1f, 58);
				evt.eventPlayMovie(DirectionManager.MOVIE.btd003, false, false, false, true, 128, 72, 95, 77);
				evt.eventAddMovie(DirectionManager.MOVIE.btd003_loop, DirectionManager.MOVIE.btd003, false, true, false, true);
				evt.eventPlaySound(DirectionManager.SOUND.S0257, Sound.CH.SE1, true, 1f, 70);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1437();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1438();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1439();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1440();
				break;
			case 41:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ytg006, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003, DirectionManager.MOVIE.ytg006, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003_loop, DirectionManager.MOVIE.ytg003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0443, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0067, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0092, Sound.CH.SE0, true, 1f, 58);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_10, false, false, true, false, 0, 0, 95, 77);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_10_loop, DirectionManager.MOVIE.huc008_T_10, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0224, Sound.CH.SE1, true, 1f, 70);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1437();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1438();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1439();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1440();
				break;
			case 42:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ytg006, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003, DirectionManager.MOVIE.ytg006, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003_loop, DirectionManager.MOVIE.ytg003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0443, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0067, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0092, Sound.CH.SE0, true, 1f, 58);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_20, false, false, true, false, 0, 0, 95, 77);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_20_loop, DirectionManager.MOVIE.huc008_T_20, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0225, Sound.CH.SE1, true, 1f, 70);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1437();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1438();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1439();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1440();
				break;
			case 43:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ytg006, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003, DirectionManager.MOVIE.ytg006, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003_loop, DirectionManager.MOVIE.ytg003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0443, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0067, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0092, Sound.CH.SE0, true, 1f, 58);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_30, false, false, true, false, 0, 0, 95, 77);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_30_loop, DirectionManager.MOVIE.huc008_T_30, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0226, Sound.CH.SE1, true, 1f, 70);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1437();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1438();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1439();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1440();
				break;
			case 44:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ytg006, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003, DirectionManager.MOVIE.ytg006, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003_loop, DirectionManager.MOVIE.ytg003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0443, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0067, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0092, Sound.CH.SE0, true, 1f, 58);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_50, false, false, true, false, 0, 0, 95, 77);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_50_loop, DirectionManager.MOVIE.huc008_T_50, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0227, Sound.CH.SE1, true, 1f, 70);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1437();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1438();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1439();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1440();
				break;
			case 45:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ytg006, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003, DirectionManager.MOVIE.ytg006, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003_loop, DirectionManager.MOVIE.ytg003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0443, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0067, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0092, Sound.CH.SE0, true, 1f, 58);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_100, false, false, true, false, 0, 0, 95, 77);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_100_loop, DirectionManager.MOVIE.huc008_T_100, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0228, Sound.CH.SE1, true, 1f, 70);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1437();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1438();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1439();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1440();
				break;
			case 46:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ytg006, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003, DirectionManager.MOVIE.ytg006, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003_loop, DirectionManager.MOVIE.ytg003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0443, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0067, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0092, Sound.CH.SE0, true, 1f, 58);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_150, false, false, true, false, 0, 0, 95, 77);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_150_loop, DirectionManager.MOVIE.huc008_T_150, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0229, Sound.CH.SE1, true, 1f, 70);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1437();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1438();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1439();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1440();
				break;
			case 47:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ytg006, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003, DirectionManager.MOVIE.ytg006, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003_loop, DirectionManager.MOVIE.ytg003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0443, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0067, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0092, Sound.CH.SE0, true, 1f, 58);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_200, false, false, true, false, 0, 0, 95, 77);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_200_loop, DirectionManager.MOVIE.huc008_T_200, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0230, Sound.CH.SE1, true, 1f, 70);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1437();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1438();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1439();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1440();
				break;
			case 48:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ytg006, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003, DirectionManager.MOVIE.ytg006, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003_loop, DirectionManager.MOVIE.ytg003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0443, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0067, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0092, Sound.CH.SE0, true, 1f, 58);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_300, false, false, true, false, 0, 0, 95, 77);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_300_loop, DirectionManager.MOVIE.huc008_T_300, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0231, Sound.CH.SE1, true, 1f, 70);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1437();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1438();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1439();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1440();
				break;
			case 49:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ytg001_a2, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0440, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0896, Sound.CH.VC0, true, 1f, 25);
				break;
			case 50:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ytg006, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg002, DirectionManager.MOVIE.ytg006, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0443, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0890, Sound.CH.VC0, true, 1f, 73);
				evt.eventPlaySound(DirectionManager.SOUND.S0067, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0068, Sound.CH.SE1, true, 1f, 58);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_b_hit, true, false, false, false, 0, 0, 90, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_b_hit_add, true, false, true, false, 0, 0, 80, 0);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1417();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1418();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1419();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1420();
				break;
			case 51:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ytg006, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003, DirectionManager.MOVIE.ytg006, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003_loop, DirectionManager.MOVIE.ytg003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0443, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0891, Sound.CH.VC0, true, 1f, 100);
				evt.eventPlaySound(DirectionManager.SOUND.S0067, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0092, Sound.CH.SE0, true, 1f, 58);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_b_hit, true, false, false, false, 0, 0, 90, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_b_hit_add, true, false, true, false, 0, 0, 80, 0);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1421();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1422();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1423();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1424();
				break;
			case 52:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ytg006, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003, DirectionManager.MOVIE.ytg006, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003_loop, DirectionManager.MOVIE.ytg003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0443, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0893, Sound.CH.VC0, true, 1f, 90);
				evt.eventPlaySound(DirectionManager.SOUND.S0067, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0070, Sound.CH.SE0, true, 1f, 38);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_b_hit, true, false, false, false, 0, 0, 90, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_b_hit_add, true, false, true, false, 0, 0, 80, 0);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1425();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1426();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1427();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1428();
				break;
			case 53:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ytg006, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003, DirectionManager.MOVIE.ytg006, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003_loop, DirectionManager.MOVIE.ytg003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0443, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0891, Sound.CH.VC0, true, 1f, 128);
				evt.eventPlaySound(DirectionManager.SOUND.S0067, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0071, Sound.CH.SE0, true, 1f, 48);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_b_hit, true, false, false, false, 0, 0, 90, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_b_hit_add, true, false, true, false, 0, 0, 80, 0);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1429();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1430();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1431();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1432();
				break;
			case 54:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ytg006, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003, DirectionManager.MOVIE.ytg006, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003_loop, DirectionManager.MOVIE.ytg003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0443, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0894, Sound.CH.VC0, true, 1f, 90);
				evt.eventPlaySound(DirectionManager.SOUND.S0067, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0071, Sound.CH.SE0, true, 1f, 43);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1433();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1434();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1435();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1436();
				evt.eventPlayMovie(DirectionManager.MOVIE.push_b_hit, true, false, false, false, 0, 0, 90, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_b_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 55:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0891, Sound.CH.VC0, true, 1f, 124);
				evt.eventPlaySound(DirectionManager.SOUND.S0067, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0092, Sound.CH.SE0, true, 1f, 94);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1437();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1438();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1439();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1440();
				evt.eventPlayMovie(DirectionManager.MOVIE.push_b_hit, true, false, false, false, 0, 0, 90, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_b_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 56:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0891, Sound.CH.VC0, true, 1f, 170);
				evt.eventPlaySound(DirectionManager.SOUND.S0067, Sound.CH.SE1, true, 1f, 36);
				evt.eventPlaySound(DirectionManager.SOUND.S0071, Sound.CH.SE0, true, 1f, 90);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1441();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1442();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1443();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1444();
				evt.eventPlayMovie(DirectionManager.MOVIE.push_b_hit, true, false, false, false, 0, 0, 90, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_b_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 57:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ytg006, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003, DirectionManager.MOVIE.ytg006, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003_loop, DirectionManager.MOVIE.ytg003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0443, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0891, Sound.CH.VC0, true, 1f, 100);
				evt.eventPlaySound(DirectionManager.SOUND.S0067, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0092, Sound.CH.SE0, true, 1f, 58);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1446();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1447();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1448();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1449();
				evt.eventPlayMovie(DirectionManager.MOVIE.btd003, false, false, false, true, 128, 72, 95, 77);
				evt.eventAddMovie(DirectionManager.MOVIE.btd003_loop, DirectionManager.MOVIE.btd003, false, true, false, true);
				evt.eventPlaySound(DirectionManager.SOUND.S0257, Sound.CH.SE1, true, 1f, 70);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_b_hit, true, false, false, false, 0, 0, 90, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_b_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 58:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ytg006, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003, DirectionManager.MOVIE.ytg006, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003_loop, DirectionManager.MOVIE.ytg003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0443, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0067, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0092, Sound.CH.SE0, true, 1f, 58);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1450();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1451();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1452();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1453();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_10, false, false, true, false, 0, 0, 95, 77);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_10_loop, DirectionManager.MOVIE.huc008_T_10, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0224, Sound.CH.SE1, true, 1f, 70);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_b_hit, true, false, false, false, 0, 0, 90, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_b_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 59:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ytg006, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003, DirectionManager.MOVIE.ytg006, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003_loop, DirectionManager.MOVIE.ytg003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0443, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0067, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0092, Sound.CH.SE0, true, 1f, 58);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1450();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1451();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1452();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1453();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_20, false, false, true, false, 0, 0, 95, 77);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_20_loop, DirectionManager.MOVIE.huc008_T_20, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0225, Sound.CH.SE1, true, 1f, 70);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_b_hit, true, false, false, false, 0, 0, 90, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_b_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 60:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ytg006, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003, DirectionManager.MOVIE.ytg006, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003_loop, DirectionManager.MOVIE.ytg003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0443, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0067, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0092, Sound.CH.SE0, true, 1f, 58);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1450();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1451();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1452();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1453();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_30, false, false, true, false, 0, 0, 95, 77);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_30_loop, DirectionManager.MOVIE.huc008_T_30, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0226, Sound.CH.SE1, true, 1f, 70);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_b_hit, true, false, false, false, 0, 0, 90, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_b_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 61:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ytg006, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003, DirectionManager.MOVIE.ytg006, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003_loop, DirectionManager.MOVIE.ytg003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0443, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0067, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0092, Sound.CH.SE0, true, 1f, 58);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1450();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1451();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1452();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1453();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_50, false, false, true, false, 0, 0, 95, 77);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_50_loop, DirectionManager.MOVIE.huc008_T_50, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0227, Sound.CH.SE1, true, 1f, 70);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_b_hit, true, false, false, false, 0, 0, 90, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_b_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 62:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ytg006, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003, DirectionManager.MOVIE.ytg006, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003_loop, DirectionManager.MOVIE.ytg003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0443, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0067, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0092, Sound.CH.SE0, true, 1f, 58);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1450();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1451();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1452();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1453();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_100, false, false, true, false, 0, 0, 95, 77);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_100_loop, DirectionManager.MOVIE.huc008_T_100, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0228, Sound.CH.SE1, true, 1f, 70);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_b_hit, true, false, false, false, 0, 0, 90, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_b_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 63:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ytg006, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003, DirectionManager.MOVIE.ytg006, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003_loop, DirectionManager.MOVIE.ytg003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0443, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0067, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0092, Sound.CH.SE0, true, 1f, 58);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1450();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1451();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1452();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1453();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_150, false, false, true, false, 0, 0, 95, 77);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_150_loop, DirectionManager.MOVIE.huc008_T_150, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0229, Sound.CH.SE1, true, 1f, 70);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_b_hit, true, false, false, false, 0, 0, 90, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_b_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 64:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ytg006, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003, DirectionManager.MOVIE.ytg006, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003_loop, DirectionManager.MOVIE.ytg003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0443, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0067, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0092, Sound.CH.SE0, true, 1f, 58);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1450();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1451();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1452();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1453();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_200, false, false, true, false, 0, 0, 95, 77);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_200_loop, DirectionManager.MOVIE.huc008_T_200, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0230, Sound.CH.SE1, true, 1f, 70);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_b_hit, true, false, false, false, 0, 0, 90, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_b_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 65:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ytg006, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003, DirectionManager.MOVIE.ytg006, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003_loop, DirectionManager.MOVIE.ytg003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0443, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0067, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0092, Sound.CH.SE0, true, 1f, 58);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1450();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1451();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1452();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1453();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_300, false, false, true, false, 0, 0, 95, 77);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_300_loop, DirectionManager.MOVIE.huc008_T_300, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0231, Sound.CH.SE1, true, 1f, 70);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_b_hit, true, false, false, false, 0, 0, 90, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_b_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 66:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1450();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1451();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1452();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1453();
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0891, Sound.CH.VC0, true, 1f, 124);
				evt.eventPlaySound(DirectionManager.SOUND.S0067, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0092, Sound.CH.SE0, true, 1f, 94);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_50, false, false, true, false, 0, 0, 95, 77);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_50_loop, DirectionManager.MOVIE.huc008_T_50, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0227, Sound.CH.SE1, true, 1f, 70);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_b_hit, true, false, false, false, 0, 0, 90, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_b_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 67:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1450();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1451();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1452();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1453();
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0891, Sound.CH.VC0, true, 1f, 124);
				evt.eventPlaySound(DirectionManager.SOUND.S0067, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0092, Sound.CH.SE0, true, 1f, 94);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_100, false, false, true, false, 0, 0, 95, 77);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_100_loop, DirectionManager.MOVIE.huc008_T_100, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0228, Sound.CH.SE1, true, 1f, 70);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_b_hit, true, false, false, false, 0, 0, 90, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_b_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 68:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1450();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1451();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1452();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1453();
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0891, Sound.CH.VC0, true, 1f, 124);
				evt.eventPlaySound(DirectionManager.SOUND.S0067, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0092, Sound.CH.SE0, true, 1f, 94);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_150, false, false, true, false, 0, 0, 95, 77);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_150_loop, DirectionManager.MOVIE.huc008_T_150, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0229, Sound.CH.SE1, true, 1f, 70);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_b_hit, true, false, false, false, 0, 0, 90, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_b_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 69:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1450();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1451();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1452();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1453();
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0891, Sound.CH.VC0, true, 1f, 124);
				evt.eventPlaySound(DirectionManager.SOUND.S0067, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0092, Sound.CH.SE0, true, 1f, 94);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_200, false, false, true, false, 0, 0, 95, 77);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_200_loop, DirectionManager.MOVIE.huc008_T_200, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0230, Sound.CH.SE1, true, 1f, 70);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_b_hit, true, false, false, false, 0, 0, 90, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_b_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 70:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1450();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1451();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1452();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1453();
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ytg003, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0891, Sound.CH.VC0, true, 1f, 124);
				evt.eventPlaySound(DirectionManager.SOUND.S0067, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0092, Sound.CH.SE0, true, 1f, 94);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_300, false, false, true, false, 0, 0, 95, 77);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_300_loop, DirectionManager.MOVIE.huc008_T_300, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0231, Sound.CH.SE1, true, 1f, 70);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_b_hit, true, false, false, false, 0, 0, 90, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_b_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			}
		}
		if (low == 0)
		{
			switch (mode)
			{
			case 1:
				DirectionLedManager.CG_YTG_lever(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				DirectionLedManager.GD_YTG_lever(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 2:
				DirectionLedManager.CG_YTG_charge_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				DirectionLedManager.GD_YTG_charge_1(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 3:
				break;
			case 4:
				break;
			case 6:
				DirectionLedManager.CG_YTG_charge_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				DirectionLedManager.GD_YTG_charge_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 7:
				break;
			case 8:
				break;
			case 10:
				DirectionLedManager.CG_YTG_lose(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				DirectionLedManager.GD_YTG_fire(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 11:
				DirectionLedManager.CG_YTG_rainbow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				DirectionLedManager.GD_YTG_fire(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 12:
				DirectionLedManager.CG_YTG_JST(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				DirectionLedManager.GD_YTG_fire(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 13:
				DirectionLedManager.CG_YTG_BD(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				DirectionLedManager.GD_YTG_fire(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 14:
				DirectionLedManager.CG_YTG_HOH(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				DirectionLedManager.GD_YTG_fire(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 15:
				DirectionLedManager.CG_YTG_JYD_rainbow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				break;
			case 16:
				DirectionLedManager.CG_YTG_JYD_BD(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				break;
			case 17:
				DirectionLedManager.CG_YTG_BONUS(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				DirectionLedManager.GD_YTG_fire(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.YK_YTG_add_BONUS(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 18:
				DirectionLedManager.CG_YTG_rainbow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				DirectionLedManager.GD_YTG_fire(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 19:
				DirectionLedManager.CG_YTG_rainbow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				DirectionLedManager.GD_YTG_fire(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 20:
				DirectionLedManager.CG_YTG_rainbow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				DirectionLedManager.GD_YTG_fire(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 21:
				DirectionLedManager.CG_YTG_rainbow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				DirectionLedManager.GD_YTG_fire(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 22:
				DirectionLedManager.CG_YTG_rainbow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				DirectionLedManager.GD_YTG_fire(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 23:
				DirectionLedManager.CG_YTG_rainbow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				DirectionLedManager.GD_YTG_fire(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 24:
				DirectionLedManager.CG_YTG_rainbow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				DirectionLedManager.GD_YTG_fire(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 25:
				DirectionLedManager.CG_YTG_rainbow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				DirectionLedManager.GD_YTG_fire(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 26:
				DirectionLedManager.CG_YTG_JYD_rainbow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				break;
			case 27:
				DirectionLedManager.CG_YTG_JYD_rainbow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				break;
			case 28:
				DirectionLedManager.CG_YTG_JYD_rainbow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				break;
			case 29:
				DirectionLedManager.CG_YTG_JYD_rainbow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				break;
			case 30:
				DirectionLedManager.CG_YTG_JYD_rainbow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				break;
			case 31:
				DirectionLedManager.CG_YTG_lose(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				DirectionLedManager.GD_YTG_fire(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 32:
				DirectionLedManager.CG_YTG_rainbow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				DirectionLedManager.GD_YTG_fire(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 33:
				DirectionLedManager.CG_YTG_JST(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				DirectionLedManager.GD_YTG_fire(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 34:
				DirectionLedManager.CG_YTG_BD(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				DirectionLedManager.GD_YTG_fire(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 35:
				DirectionLedManager.CG_YTG_HOH(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				DirectionLedManager.GD_YTG_fire(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 36:
				DirectionLedManager.CG_YTG_next(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				DirectionLedManager.GD_YTG_fire(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 37:
				DirectionLedManager.CG_YTG_next(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				DirectionLedManager.GD_YTG_fire(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 38:
				DirectionLedManager.CG_YTG_next(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				DirectionLedManager.GD_YTG_fire(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 39:
				DirectionLedManager.CG_YTG_next(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				DirectionLedManager.GD_YTG_fire(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 40:
				DirectionLedManager.CG_YTG_BONUS(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				DirectionLedManager.GD_YTG_fire(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.YK_YTG_add_BONUS(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 41:
				DirectionLedManager.CG_YTG_rainbow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				DirectionLedManager.GD_YTG_fire(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 42:
				DirectionLedManager.CG_YTG_rainbow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				DirectionLedManager.GD_YTG_fire(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 43:
				DirectionLedManager.CG_YTG_rainbow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				DirectionLedManager.GD_YTG_fire(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 44:
				DirectionLedManager.CG_YTG_rainbow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				DirectionLedManager.GD_YTG_fire(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 45:
				DirectionLedManager.CG_YTG_rainbow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				DirectionLedManager.GD_YTG_fire(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 46:
				DirectionLedManager.CG_YTG_rainbow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				DirectionLedManager.GD_YTG_fire(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 47:
				DirectionLedManager.CG_YTG_rainbow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				DirectionLedManager.GD_YTG_fire(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 48:
				DirectionLedManager.CG_YTG_rainbow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				DirectionLedManager.GD_YTG_fire(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 49:
				DirectionLedManager.CG_YTG_lever(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				DirectionLedManager.GD_YTG_lever(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 50:
				DirectionLedManager.CG_YTG_lose(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				DirectionLedManager.GD_YTG_fire(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 51:
				DirectionLedManager.CG_YTG_rainbow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				DirectionLedManager.GD_YTG_fire(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 52:
				DirectionLedManager.CG_YTG_JST(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				DirectionLedManager.GD_YTG_fire(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 53:
				DirectionLedManager.CG_YTG_BD(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				DirectionLedManager.GD_YTG_fire(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 54:
				DirectionLedManager.CG_YTG_HOH(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				DirectionLedManager.GD_YTG_fire(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 55:
				DirectionLedManager.CG_YTG_JYD_rainbow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				break;
			case 56:
				DirectionLedManager.CG_YTG_JYD_BD(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				break;
			case 57:
				DirectionLedManager.CG_YTG_BONUS(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				DirectionLedManager.GD_YTG_fire(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.YK_YTG_add_BONUS(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 58:
				DirectionLedManager.CG_YTG_rainbow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				DirectionLedManager.GD_YTG_fire(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 59:
				DirectionLedManager.CG_YTG_rainbow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				DirectionLedManager.GD_YTG_fire(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 60:
				DirectionLedManager.CG_YTG_rainbow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				DirectionLedManager.GD_YTG_fire(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 61:
				DirectionLedManager.CG_YTG_rainbow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				DirectionLedManager.GD_YTG_fire(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 62:
				DirectionLedManager.CG_YTG_rainbow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				DirectionLedManager.GD_YTG_fire(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 63:
				DirectionLedManager.CG_YTG_rainbow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				DirectionLedManager.GD_YTG_fire(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 64:
				DirectionLedManager.CG_YTG_rainbow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				DirectionLedManager.GD_YTG_fire(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 65:
				DirectionLedManager.CG_YTG_rainbow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				DirectionLedManager.GD_YTG_fire(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 66:
				DirectionLedManager.CG_YTG_JYD_rainbow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				break;
			case 67:
				DirectionLedManager.CG_YTG_JYD_rainbow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				break;
			case 68:
				DirectionLedManager.CG_YTG_JYD_rainbow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				break;
			case 69:
				DirectionLedManager.CG_YTG_JYD_rainbow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				break;
			case 70:
				DirectionLedManager.CG_YTG_JYD_rainbow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				break;
			case 5:
			case 9:
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
	}
}
