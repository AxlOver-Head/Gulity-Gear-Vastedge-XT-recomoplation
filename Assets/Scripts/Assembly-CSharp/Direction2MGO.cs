public class Direction2MGO : DirectionBase
{
	public Direction2MGO(DirectionManager _mng, byte _high, byte _low, byte _mode, DirectionManager.DIR _dir)
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
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0128, Sound.CH.BGM, false, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.mgo001, false, true, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1179, Sound.CH.VC0, true, 1f, 0);
				break;
			case 2:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.mgo002_blue, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mgo002_blue_loop, DirectionManager.MOVIE.mgo002_blue, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0243, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1181, Sound.CH.VC0, true, 1f, 16);
				evt.eventPlaySound(DirectionManager.SOUND.S0360, Sound.CH.SE0, true, 1f, 45);
				break;
			case 3:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.mgo003_blue, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mgo003_blue_loop, DirectionManager.MOVIE.mgo003_blue, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0363, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2002, Sound.CH.VC0, true, 1f, 0);
				break;
			case 4:
				evt.eventDisableBefore(mng, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.mgo004, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0364, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2003, Sound.CH.VC0, true, 1f, 25);
				evt.eventPlaySound(DirectionManager.SOUND.S0137, Sound.CH.BGM, false, 1f, 89);
				evt.eventPlayMovie(DirectionManager.MOVIE.mgo004_blue, true, false, false, false, 0, 0, 99, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.mgo004_add, true, false, false, false, 0, 0, 98, 0);
				break;
			case 5:
				evt.eventDisableBefore(mng, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0073, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0074, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.mgo008, false, false, false, false, 0, 0, 100, 72);
				evt.eventAddMovie(DirectionManager.MOVIE.mgo008_loop, DirectionManager.MOVIE.mgo008, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0367, Sound.CH.SE0, true, 1f, 81);
				evt.eventPlaySound(DirectionManager.SOUND.S0368, Sound.CH.SE0, true, 1f, 98);
				evt.eventPlaySound(DirectionManager.SOUND.S0816, Sound.CH.VC0, true, 1f, 107);
				evt.eventPlaySound(DirectionManager.SOUND.S0191, Sound.CH.BGM, false, 1f, 135);
				break;
			case 6:
				evt.eventDisableBefore(mng, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.mgo005, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0365, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2004, Sound.CH.VC0, true, 1f, 5);
				evt.eventPlaySound(DirectionManager.SOUND.S1182, Sound.CH.VC0, true, 1f, 38);
				evt.eventPlaySound(DirectionManager.SOUND.S0218, Sound.CH.SE0, true, 1f, 105);
				evt.eventPlayMovie(DirectionManager.MOVIE.mgo005_add, true, false, false, false, 0, 0, 99, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.mgo004_blue, true, false, false, false, 0, 0, 98, 0);
				break;
			case 7:
				evt.eventDisableBefore(mng, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.mgo006, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mgo006_loop, DirectionManager.MOVIE.mgo006, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0366, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2005, Sound.CH.VC0, true, 1f, 5);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE0, true, 1f, 24);
				evt.eventPlaySound(DirectionManager.SOUND.S1183, Sound.CH.VC0, true, 1f, 82);
				evt.eventPlaySound(DirectionManager.SOUND.S0221, Sound.CH.SE0, true, 1f, 179);
				evt.eventPlaySound(DirectionManager.SOUND.S0136, Sound.CH.BGM, false, 1f, 179);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_186();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_188();
				evt.eventPlayMovie(DirectionManager.MOVIE.mgo006_add, true, false, false, false, 0, 0, 99, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.mgo004_blue, true, false, false, false, 0, 0, 98, 0);
				break;
			case 8:
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, true, 128, 119, 90, 23);
				evt.eventSetCanPush(true, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, true);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_add, true, false, true, false, 0, 0, 80, 23);
				evt.eventPlaySound(DirectionManager.SOUND.S0223, Sound.CH.SE0, true, 1f, 23);
				break;
			case 9:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.mgo002_green, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mgo002_green_loop, DirectionManager.MOVIE.mgo002_green, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0243, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1181, Sound.CH.VC0, true, 1f, 16);
				evt.eventPlaySound(DirectionManager.SOUND.S0361, Sound.CH.SE0, true, 1f, 45);
				break;
			case 10:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.mgo003_green, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mgo003_green_loop, DirectionManager.MOVIE.mgo003_green, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0363, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2002, Sound.CH.VC0, true, 1f, 0);
				break;
			case 11:
				evt.eventDisableBefore(mng, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.mgo004, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0364, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2003, Sound.CH.VC0, true, 1f, 25);
				evt.eventPlaySound(DirectionManager.SOUND.S0137, Sound.CH.BGM, false, 1f, 89);
				evt.eventPlayMovie(DirectionManager.MOVIE.mgo004_green, true, false, false, false, 0, 0, 99, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.mgo004_add, true, false, false, false, 0, 0, 98, 0);
				break;
			case 12:
				evt.eventDisableBefore(mng, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.mgo005, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0365, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2004, Sound.CH.VC0, true, 1f, 5);
				evt.eventPlaySound(DirectionManager.SOUND.S1182, Sound.CH.VC0, true, 1f, 38);
				evt.eventPlaySound(DirectionManager.SOUND.S0218, Sound.CH.SE0, true, 1f, 105);
				evt.eventPlayMovie(DirectionManager.MOVIE.mgo005_add, true, false, false, false, 0, 0, 99, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.mgo004_green, true, false, false, false, 0, 0, 98, 0);
				break;
			case 13:
				evt.eventDisableBefore(mng, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.mgo006, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mgo006_loop, DirectionManager.MOVIE.mgo006, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0366, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2005, Sound.CH.VC0, true, 1f, 5);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE0, true, 1f, 24);
				evt.eventPlaySound(DirectionManager.SOUND.S1183, Sound.CH.VC0, true, 1f, 82);
				evt.eventPlaySound(DirectionManager.SOUND.S0221, Sound.CH.SE0, true, 1f, 179);
				evt.eventPlaySound(DirectionManager.SOUND.S0136, Sound.CH.BGM, false, 1f, 179);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_186();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_188();
				evt.eventPlayMovie(DirectionManager.MOVIE.mgo006_add, true, false, false, false, 0, 0, 99, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.mgo004_green, true, false, false, false, 0, 0, 98, 0);
				break;
			case 14:
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, true, 128, 119, 90, 23);
				evt.eventSetCanPush(true, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, true);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_add, true, false, true, false, 0, 0, 80, 23);
				evt.eventPlaySound(DirectionManager.SOUND.S0223, Sound.CH.SE0, true, 1f, 23);
				break;
			case 15:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.mgo002_red, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mgo002_red_loop, DirectionManager.MOVIE.mgo002_red, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0243, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1181, Sound.CH.VC0, true, 1f, 16);
				evt.eventPlaySound(DirectionManager.SOUND.S0362, Sound.CH.SE0, true, 1f, 45);
				break;
			case 16:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.mgo003_red, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mgo003_red_loop, DirectionManager.MOVIE.mgo003_red, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0363, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2002, Sound.CH.VC0, true, 1f, 0);
				break;
			case 17:
				evt.eventDisableBefore(mng, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.mgo004, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0364, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2003, Sound.CH.VC0, true, 1f, 25);
				evt.eventPlaySound(DirectionManager.SOUND.S0137, Sound.CH.BGM, false, 1f, 89);
				evt.eventPlayMovie(DirectionManager.MOVIE.mgo004_red, true, false, false, false, 0, 0, 99, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.mgo004_add, true, false, false, false, 0, 0, 98, 0);
				break;
			case 18:
				evt.eventDisableBefore(mng, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.mgo005, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0365, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2004, Sound.CH.VC0, true, 1f, 5);
				evt.eventPlaySound(DirectionManager.SOUND.S1182, Sound.CH.VC0, true, 1f, 38);
				evt.eventPlaySound(DirectionManager.SOUND.S0218, Sound.CH.SE0, true, 1f, 105);
				evt.eventPlayMovie(DirectionManager.MOVIE.mgo005_add, true, false, false, false, 0, 0, 99, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.mgo004_red, true, false, false, false, 0, 0, 98, 0);
				break;
			case 19:
				evt.eventDisableBefore(mng, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.mgo006, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mgo006_loop, DirectionManager.MOVIE.mgo006, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0366, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2005, Sound.CH.VC0, true, 1f, 5);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE0, true, 1f, 24);
				evt.eventPlaySound(DirectionManager.SOUND.S1183, Sound.CH.VC0, true, 1f, 82);
				evt.eventPlaySound(DirectionManager.SOUND.S0221, Sound.CH.SE0, true, 1f, 179);
				evt.eventPlaySound(DirectionManager.SOUND.S0136, Sound.CH.BGM, false, 1f, 179);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_186();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_188();
				evt.eventPlayMovie(DirectionManager.MOVIE.mgo006_add, true, false, false, false, 0, 0, 99, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.mgo004_red, true, false, false, false, 0, 0, 98, 0);
				break;
			case 20:
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, true, 128, 119, 90, 23);
				evt.eventSetCanPush(true, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, true);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_add, true, false, true, false, 0, 0, 80, 23);
				evt.eventPlaySound(DirectionManager.SOUND.S0223, Sound.CH.SE0, true, 1f, 23);
				break;
			case 21:
				evt.eventDisableBefore(mng, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0128, Sound.CH.BGM, false, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.mgo001, false, true, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2001, Sound.CH.VC0, true, 1f, 0);
				break;
			case 22:
				evt.eventDisableBefore(mng, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.mgo009, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mgo009_loop, DirectionManager.MOVIE.mgo009, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0222, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0864, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2006, Sound.CH.VC0, true, 1f, 63);
				break;
			case 23:
				evt.eventDisableBefore(mng, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.mgo0010, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mgo0010_loop, DirectionManager.MOVIE.mgo0010, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0369, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0818, Sound.CH.VC0, true, 1f, 40);
				evt.eventPlaySound(DirectionManager.SOUND.S0370, Sound.CH.SE0, true, 1f, 46);
				evt.eventPlaySound(DirectionManager.SOUND.S0220, Sound.CH.SE0, true, 1f, 67);
				evt.eventPlaySound(DirectionManager.SOUND.S0135, Sound.CH.BGM, false, 1f, 67);
				break;
			case 24:
				evt.eventDisableBefore(mng, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.mgo004, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0364, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2003, Sound.CH.VC0, true, 1f, 25);
				evt.eventPlaySound(DirectionManager.SOUND.S0137, Sound.CH.BGM, false, 1f, 89);
				evt.eventPlayMovie(DirectionManager.MOVIE.mgo004_blue, true, false, false, false, 0, 0, 99, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.mgo004_add, true, false, false, false, 0, 0, 98, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 90, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 25:
				evt.eventDisableBefore(mng, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.mgo004, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0364, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2003, Sound.CH.VC0, true, 1f, 25);
				evt.eventPlaySound(DirectionManager.SOUND.S0137, Sound.CH.BGM, false, 1f, 89);
				evt.eventPlayMovie(DirectionManager.MOVIE.mgo004_green, true, false, false, false, 0, 0, 99, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.mgo004_add, true, false, false, false, 0, 0, 98, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 90, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 26:
				evt.eventDisableBefore(mng, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.mgo004, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0364, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2003, Sound.CH.VC0, true, 1f, 25);
				evt.eventPlaySound(DirectionManager.SOUND.S0137, Sound.CH.BGM, false, 1f, 89);
				evt.eventPlayMovie(DirectionManager.MOVIE.mgo004_red, true, false, false, false, 0, 0, 99, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.mgo004_add, true, false, false, false, 0, 0, 98, 0);
				break;
			case 27:
				evt.eventDisableBefore(mng, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0073, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0074, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.mgo006, false, false, false, false, 0, 0, 100, 72);
				evt.eventAddMovie(DirectionManager.MOVIE.mgo006_loop, DirectionManager.MOVIE.mgo006, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0366, Sound.CH.SE0, true, 1f, 72);
				evt.eventPlaySound(DirectionManager.SOUND.S2005, Sound.CH.VC0, true, 1f, 77);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE0, true, 1f, 96);
				evt.eventPlaySound(DirectionManager.SOUND.S1183, Sound.CH.VC0, true, 1f, 154);
				evt.eventPlaySound(DirectionManager.SOUND.S0221, Sound.CH.SE0, true, 1f, 251);
				evt.eventPlaySound(DirectionManager.SOUND.S0136, Sound.CH.BGM, false, 1f, 251);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_186();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_188();
				evt.eventPlayMovie(DirectionManager.MOVIE.mgo006_add, true, false, false, false, 0, 0, 99, 72);
				evt.eventPlayMovie(DirectionManager.MOVIE.mgo004_blue, true, false, false, false, 0, 0, 98, 72);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 90, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 28:
				evt.eventDisableBefore(mng, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0073, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0074, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.mgo006, false, false, false, false, 0, 0, 100, 72);
				evt.eventAddMovie(DirectionManager.MOVIE.mgo006_loop, DirectionManager.MOVIE.mgo006, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0366, Sound.CH.SE0, true, 1f, 72);
				evt.eventPlaySound(DirectionManager.SOUND.S2005, Sound.CH.VC0, true, 1f, 77);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE0, true, 1f, 96);
				evt.eventPlaySound(DirectionManager.SOUND.S1183, Sound.CH.VC0, true, 1f, 154);
				evt.eventPlaySound(DirectionManager.SOUND.S0221, Sound.CH.SE0, true, 1f, 251);
				evt.eventPlaySound(DirectionManager.SOUND.S0136, Sound.CH.BGM, false, 1f, 251);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_186();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_188();
				evt.eventPlayMovie(DirectionManager.MOVIE.mgo006_add, true, false, false, false, 0, 0, 99, 72);
				evt.eventPlayMovie(DirectionManager.MOVIE.mgo004_green, true, false, false, false, 0, 0, 98, 72);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 90, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 29:
				evt.eventDisableBefore(mng, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0073, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0074, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.mgo006, false, false, false, false, 0, 0, 100, 72);
				evt.eventAddMovie(DirectionManager.MOVIE.mgo006_loop, DirectionManager.MOVIE.mgo006, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0366, Sound.CH.SE0, true, 1f, 72);
				evt.eventPlaySound(DirectionManager.SOUND.S2005, Sound.CH.VC0, true, 1f, 77);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE0, true, 1f, 96);
				evt.eventPlaySound(DirectionManager.SOUND.S1183, Sound.CH.VC0, true, 1f, 154);
				evt.eventPlaySound(DirectionManager.SOUND.S0221, Sound.CH.SE0, true, 1f, 251);
				evt.eventPlaySound(DirectionManager.SOUND.S0136, Sound.CH.BGM, false, 1f, 251);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_186();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_188();
				evt.eventPlayMovie(DirectionManager.MOVIE.mgo006_add, true, false, false, false, 0, 0, 99, 72);
				evt.eventPlayMovie(DirectionManager.MOVIE.mgo004_red, true, false, false, false, 0, 0, 98, 72);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 90, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 30:
				evt.eventDisableBefore(mng, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0128, Sound.CH.BGM, false, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.mgo001_st, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mgo001, DirectionManager.MOVIE.mgo001_st, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0245, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1179, Sound.CH.VC0, true, 1f, 30);
				break;
			}
		}
		if (low == 0)
		{
			switch (mode)
			{
			case 1:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
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
				DirectionLedManager.GD_hatten_HIT(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.LG_hatten_HIT(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				DirectionLedManager.m_panel_slash_MGO_01(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_4M));
				break;
			case 8:
				break;
			case 9:
				DirectionLedManager.GD_MGO_green(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 10:
				break;
			case 11:
				break;
			case 12:
				break;
			case 13:
				DirectionLedManager.GD_hatten_HIT(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.LG_hatten_HIT(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				DirectionLedManager.m_panel_slash_MGO_01(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_4M));
				break;
			case 14:
				break;
			case 15:
				DirectionLedManager.GD_MGO_red(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 16:
				break;
			case 17:
				break;
			case 18:
				break;
			case 19:
				DirectionLedManager.GD_hatten_HIT(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.LG_hatten_HIT(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				DirectionLedManager.m_panel_slash_MGO_01(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_4M));
				break;
			case 20:
				break;
			case 21:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				break;
			case 22:
				break;
			case 23:
				DirectionLedManager.GD_hatten_HIT(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.LG_hatten_HIT(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				DirectionLedManager.m_panel_slash_MGO_03(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_4M));
				break;
			case 24:
				break;
			case 25:
				break;
			case 26:
				break;
			case 27:
				DirectionLedManager.GD_hatten_JYD_HIT(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.LG_hatten_JYD_HIT(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				DirectionLedManager.m_panel_slash_MGO_02(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_4M));
				break;
			case 28:
				DirectionLedManager.GD_hatten_JYD_HIT(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.LG_hatten_JYD_HIT(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				DirectionLedManager.m_panel_slash_MGO_02(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_4M));
				break;
			case 29:
				DirectionLedManager.GD_hatten_JYD_HIT(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.LG_hatten_JYD_HIT(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				DirectionLedManager.m_panel_slash_MGO_02(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_4M));
				break;
			case 30:
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
