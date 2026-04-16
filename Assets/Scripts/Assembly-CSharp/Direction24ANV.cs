public class Direction24ANV : DirectionBase
{
	private static int[] table_x = new int[3] { 64, 128, 192 };

	private static int[] layerTbl = new int[3] { 70, 80, 90 };

	private static int[] effTbl = new int[3] { 64, 128, 192 };

	public Direction24ANV(DirectionManager _mng, byte _high, byte _low, byte _mode, DirectionManager.DIR _dir)
		: base(_mng, _high, _low, _mode, _dir, DirectionBase.PRIORITY_NORMAL)
	{
	}

	public override void start()
	{
		base.start();
		evt.eventStopDirectionBefore(mng, 0);
		if (low == 0)
		{
			switch (mode)
			{
			case 1:
				appear(0, 0, 0);
				appear(0, 1, 1);
				appear(0, 2, 2);
				break;
			case 2:
				success(0, 0, 0);
				loop(0, 1, 1);
				break;
			case 3:
				success(0, 1, 1);
				break;
			case 4:
				success(0, 2, 2);
				break;
			case 11:
				failed();
				loop(0, 1, 1);
				break;
			case 12:
				failed();
				break;
			case 13:
				appear(0, 0, 0);
				appear(0, 1, 2);
				appear(0, 2, 1);
				break;
			case 14:
				success(0, 0, 0);
				loop(0, 2, 1);
				break;
			case 15:
				success(0, 2, 1);
				break;
			case 16:
				success(0, 1, 2);
				break;
			case 17:
				failed();
				loop(0, 2, 1);
				break;
			case 19:
				failed();
				break;
			case 20:
				appear(0, 0, 1);
				appear(0, 1, 0);
				appear(0, 2, 2);
				break;
			case 21:
				success(0, 1, 0);
				loop(0, 0, 1);
				break;
			case 22:
				success(0, 0, 1);
				break;
			case 23:
				success(0, 2, 2);
				break;
			case 24:
				failed();
				loop(0, 0, 1);
				break;
			case 25:
				failed();
				break;
			case 26:
				appear(0, 0, 2);
				appear(0, 1, 0);
				appear(0, 2, 1);
				break;
			case 27:
				success(0, 1, 0);
				loop(0, 2, 1);
				break;
			case 28:
				success(0, 2, 1);
				break;
			case 29:
				success(0, 0, 2);
				break;
			case 30:
				failed();
				loop(0, 2, 1);
				break;
			case 31:
				failed();
				break;
			case 32:
				appear(0, 0, 1);
				appear(0, 1, 2);
				appear(0, 2, 0);
				break;
			case 33:
				success(0, 2, 0);
				loop(0, 0, 1);
				break;
			case 34:
				success(0, 0, 1);
				break;
			case 35:
				success(0, 1, 2);
				break;
			case 36:
				failed();
				loop(0, 0, 1);
				break;
			case 37:
				failed();
				break;
			case 38:
				appear(0, 0, 2);
				appear(0, 1, 1);
				appear(0, 2, 0);
				break;
			case 39:
				success(0, 2, 0);
				loop(0, 1, 1);
				break;
			case 40:
				success(0, 1, 1);
				break;
			case 41:
				success(0, 0, 2);
				break;
			case 42:
				failed();
				loop(0, 1, 1);
				break;
			case 43:
				failed();
				break;
			case 44:
				appear(1, 0, 0);
				appear(1, 1, 1);
				appear(1, 2, 2);
				break;
			case 45:
				success(1, 0, 0);
				loop(1, 1, 1);
				break;
			case 46:
				success(1, 1, 1);
				break;
			case 47:
				success(1, 2, 2);
				break;
			case 48:
				failed();
				loop(1, 1, 1);
				break;
			case 49:
				failed();
				break;
			case 50:
				appear(1, 0, 0);
				appear(1, 1, 2);
				appear(1, 2, 1);
				break;
			case 51:
				success(1, 0, 0);
				loop(1, 2, 1);
				break;
			case 52:
				success(1, 2, 1);
				break;
			case 53:
				success(1, 1, 2);
				break;
			case 54:
				failed();
				loop(1, 2, 1);
				break;
			case 55:
				failed();
				break;
			case 57:
				appear(1, 0, 1);
				appear(1, 1, 0);
				appear(1, 2, 2);
				break;
			case 58:
				success(1, 1, 0);
				loop(1, 0, 1);
				break;
			case 59:
				success(1, 0, 1);
				break;
			case 60:
				success(1, 2, 2);
				break;
			case 61:
				failed();
				loop(1, 0, 1);
				break;
			case 62:
				failed();
				break;
			case 63:
				appear(1, 0, 2);
				appear(1, 1, 0);
				appear(1, 2, 1);
				break;
			case 64:
				success(1, 1, 0);
				loop(1, 2, 1);
				break;
			case 65:
				success(1, 2, 1);
				break;
			case 66:
				success(1, 0, 2);
				break;
			case 67:
				failed();
				loop(1, 2, 1);
				break;
			case 68:
				failed();
				break;
			case 69:
				appear(1, 0, 1);
				appear(1, 1, 2);
				appear(1, 2, 0);
				break;
			case 70:
				success(1, 2, 0);
				loop(1, 0, 1);
				break;
			case 71:
				success(1, 0, 1);
				break;
			case 72:
				success(1, 1, 2);
				break;
			case 73:
				failed();
				loop(1, 0, 1);
				break;
			case 74:
				failed();
				break;
			case 75:
				appear(1, 0, 2);
				appear(1, 1, 1);
				appear(1, 2, 0);
				break;
			case 76:
				success(1, 2, 0);
				loop(1, 1, 1);
				break;
			case 77:
				success(1, 1, 1);
				break;
			case 78:
				success(1, 0, 2);
				break;
			case 79:
				failed();
				loop(1, 1, 1);
				break;
			case 80:
				failed();
				break;
			case 81:
				appear(2, 0, 0);
				appear(2, 1, 1);
				appear(2, 2, 2);
				break;
			case 82:
				success(2, 0, 0);
				loop(2, 1, 1);
				break;
			case 83:
				success(2, 1, 1);
				break;
			case 84:
				success(2, 2, 2);
				break;
			case 85:
				failed();
				loop(2, 1, 1);
				break;
			case 86:
				failed();
				break;
			case 87:
				appear(2, 0, 0);
				appear(2, 1, 2);
				appear(2, 2, 1);
				break;
			case 88:
				success(2, 0, 0);
				loop(2, 2, 1);
				break;
			case 89:
				success(2, 2, 1);
				break;
			case 90:
				success(2, 1, 2);
				break;
			case 91:
				failed();
				loop(2, 2, 1);
				break;
			case 93:
				failed();
				break;
			case 94:
				appear(2, 0, 1);
				appear(2, 1, 0);
				appear(2, 2, 2);
				break;
			case 95:
				success(2, 1, 0);
				loop(2, 0, 1);
				break;
			case 96:
				success(2, 0, 1);
				break;
			case 97:
				success(2, 2, 2);
				break;
			case 98:
				failed();
				loop(2, 0, 1);
				break;
			case 99:
				failed();
				break;
			case 100:
				appear(2, 0, 2);
				appear(2, 1, 0);
				appear(2, 2, 1);
				break;
			case 101:
				success(2, 1, 0);
				loop(2, 2, 1);
				break;
			case 102:
				success(2, 2, 1);
				break;
			case 103:
				success(2, 0, 2);
				break;
			case 104:
				failed();
				loop(2, 2, 1);
				break;
			case 105:
				failed();
				break;
			case 106:
				appear(2, 0, 1);
				appear(2, 1, 2);
				appear(2, 2, 0);
				break;
			case 107:
				success(2, 2, 0);
				loop(2, 0, 1);
				break;
			case 108:
				success(2, 0, 1);
				break;
			case 109:
				success(2, 1, 2);
				break;
			case 110:
				failed();
				loop(2, 0, 1);
				break;
			case 111:
				failed();
				break;
			case 112:
				appear(2, 0, 2);
				appear(2, 1, 1);
				appear(2, 2, 0);
				break;
			case 113:
				success(2, 2, 0);
				loop(2, 1, 1);
				break;
			case 114:
				success(2, 1, 1);
				break;
			case 115:
				success(2, 0, 2);
				break;
			case 116:
				failed();
				loop(2, 1, 1);
				break;
			case 117:
				failed();
				break;
			}
		}
		if (low == 0)
		{
			switch (mode)
			{
			case 1:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.anv000_bg, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0558, Sound.CH.SE0, true, 1f, 0);
				break;
			case 2:
				evt.eventPlaySound(DirectionManager.SOUND.S0559, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2021, Sound.CH.VC0, true, 1f, 10);
				break;
			case 3:
				evt.eventPlaySound(DirectionManager.SOUND.S0559, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2021, Sound.CH.VC0, true, 1f, 10);
				break;
			case 4:
				evt.eventPlayMovie(DirectionManager.MOVIE.anv0010, false, false, false, true, 128, 72, 60, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S0559, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2023, Sound.CH.VC0, true, 1f, 10);
				evt.eventPlaySound(DirectionManager.SOUND.S0241, Sound.CH.SE0, true, 1f, 30);
				break;
			case 5:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.anv027_char, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 222, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh006_sly, false, false, false, false, 0, 0, 90, 29);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh006_sly_loop, DirectionManager.MOVIE.ksh006_sly, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 29);
				evt.eventPlaySound(DirectionManager.SOUND.S1395, Sound.CH.VC0, true, 1f, 78);
				evt.eventPlaySound(DirectionManager.SOUND.S0511, Sound.CH.SE1, true, 1f, 96);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 116);
				evt.eventPlaySound(DirectionManager.SOUND.S1381, Sound.CH.VC1, true, 1f, 126);
				evt.eventPlaySound(DirectionManager.SOUND.S0184, Sound.CH.BGM, true, 1f, 225);
				break;
			case 6:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.anv027_char, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 238, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh003_chp, false, false, false, false, 0, 0, 99, 29);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh003_chp_loop, DirectionManager.MOVIE.ksh003_chp, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 29);
				evt.eventPlaySound(DirectionManager.SOUND.S0512, Sound.CH.SE1, true, 1f, 78);
				evt.eventPlaySound(DirectionManager.SOUND.S1442, Sound.CH.VC0, true, 1f, 78);
				evt.eventPlaySound(DirectionManager.SOUND.S0513, Sound.CH.SE0, true, 1f, 92);
				evt.eventPlaySound(DirectionManager.SOUND.S0514, Sound.CH.SE1, true, 1f, 124);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 141);
				evt.eventPlaySound(DirectionManager.SOUND.S1431, Sound.CH.VC1, true, 1f, 142);
				evt.eventPlaySound(DirectionManager.SOUND.S0185, Sound.CH.BGM, true, 1f, 241);
				break;
			case 7:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.anv027_char, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 214, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh005_mil, false, false, false, false, 0, 0, 99, 29);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh005_mil_loop, DirectionManager.MOVIE.ksh005_mil, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 29);
				evt.eventPlaySound(DirectionManager.SOUND.S0515, Sound.CH.SE1, true, 1f, 93);
				evt.eventPlaySound(DirectionManager.SOUND.S1492, Sound.CH.VC0, true, 1f, 93);
				evt.eventPlaySound(DirectionManager.SOUND.S0516, Sound.CH.SE0, true, 1f, 132);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 145);
				evt.eventPlaySound(DirectionManager.SOUND.S1481, Sound.CH.VC1, true, 1f, 147);
				evt.eventPlaySound(DirectionManager.SOUND.S0186, Sound.CH.BGM, true, 1f, 218);
				break;
			case 8:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.anv027_char, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 220, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh002_bri, false, false, false, false, 0, 0, 99, 29);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh002_bri_loop, DirectionManager.MOVIE.ksh002_bri, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 29);
				evt.eventPlaySound(DirectionManager.SOUND.S1544, Sound.CH.VC0, true, 1f, 79);
				evt.eventPlaySound(DirectionManager.SOUND.S0517, Sound.CH.SE1, true, 1f, 89);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 132);
				evt.eventPlaySound(DirectionManager.SOUND.S1530, Sound.CH.VC1, true, 1f, 147);
				evt.eventPlaySound(DirectionManager.SOUND.S0187, Sound.CH.BGM, true, 1f, 223);
				break;
			case 9:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.anv027_char, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 178, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh007_zap, false, false, false, false, 0, 0, 99, 29);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh007_zap_loop, DirectionManager.MOVIE.ksh007_zap, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 29);
				evt.eventPlaySound(DirectionManager.SOUND.S0518, Sound.CH.SE1, true, 1f, 77);
				evt.eventPlaySound(DirectionManager.SOUND.S1581, Sound.CH.VC0, true, 1f, 122);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 134);
				evt.eventPlaySound(DirectionManager.SOUND.S0188, Sound.CH.BGM, true, 1f, 181);
				break;
			case 10:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.anv027_char, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.anv027_ano, DirectionManager.MOVIE.anv027_char, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 230, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh001_ano, false, false, false, false, 0, 0, 99, 29);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh001_ano_loop, DirectionManager.MOVIE.ksh001_ano, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 29);
				evt.eventPlaySound(DirectionManager.SOUND.S0520, Sound.CH.SE1, true, 1f, 71);
				evt.eventPlaySound(DirectionManager.SOUND.S0521, Sound.CH.SE0, true, 1f, 93);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 140);
				evt.eventPlaySound(DirectionManager.SOUND.S1611, Sound.CH.VC0, true, 1f, 148);
				evt.eventPlaySound(DirectionManager.SOUND.S0190, Sound.CH.BGM, true, 1f, 233);
				break;
			case 13:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.anv000_bg, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0558, Sound.CH.SE0, true, 1f, 0);
				break;
			case 14:
				evt.eventPlaySound(DirectionManager.SOUND.S0559, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2021, Sound.CH.VC0, true, 1f, 10);
				break;
			case 15:
				evt.eventPlaySound(DirectionManager.SOUND.S0559, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2021, Sound.CH.VC0, true, 1f, 10);
				break;
			case 16:
				evt.eventPlayMovie(DirectionManager.MOVIE.anv0010, false, false, false, true, 128, 72, 60, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S0559, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2023, Sound.CH.VC0, true, 1f, 10);
				evt.eventPlaySound(DirectionManager.SOUND.S0241, Sound.CH.SE0, true, 1f, 30);
				break;
			case 20:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.anv000_bg, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0558, Sound.CH.SE0, true, 1f, 0);
				break;
			case 21:
				evt.eventPlaySound(DirectionManager.SOUND.S0559, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2021, Sound.CH.VC0, true, 1f, 10);
				break;
			case 22:
				evt.eventPlaySound(DirectionManager.SOUND.S0559, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2021, Sound.CH.VC0, true, 1f, 10);
				break;
			case 23:
				evt.eventPlayMovie(DirectionManager.MOVIE.anv0010, false, false, false, true, 128, 72, 60, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S0559, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2023, Sound.CH.VC0, true, 1f, 10);
				evt.eventPlaySound(DirectionManager.SOUND.S0241, Sound.CH.SE0, true, 1f, 30);
				break;
			case 26:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.anv000_bg, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0558, Sound.CH.SE0, true, 1f, 0);
				break;
			case 27:
				evt.eventPlaySound(DirectionManager.SOUND.S0559, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2021, Sound.CH.VC0, true, 1f, 10);
				break;
			case 28:
				evt.eventPlaySound(DirectionManager.SOUND.S0559, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2021, Sound.CH.VC0, true, 1f, 10);
				break;
			case 29:
				evt.eventPlayMovie(DirectionManager.MOVIE.anv0010, false, false, false, true, 128, 72, 60, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S0559, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2023, Sound.CH.VC0, true, 1f, 10);
				evt.eventPlaySound(DirectionManager.SOUND.S0241, Sound.CH.SE0, true, 1f, 30);
				break;
			case 32:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.anv000_bg, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0558, Sound.CH.SE0, true, 1f, 0);
				break;
			case 33:
				evt.eventPlaySound(DirectionManager.SOUND.S0559, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2021, Sound.CH.VC0, true, 1f, 10);
				break;
			case 34:
				evt.eventPlaySound(DirectionManager.SOUND.S0559, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2021, Sound.CH.VC0, true, 1f, 10);
				break;
			case 35:
				evt.eventPlayMovie(DirectionManager.MOVIE.anv0010, false, false, false, true, 128, 72, 60, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S0559, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2023, Sound.CH.VC0, true, 1f, 10);
				evt.eventPlaySound(DirectionManager.SOUND.S0241, Sound.CH.SE0, true, 1f, 30);
				break;
			case 38:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.anv000_bg, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0558, Sound.CH.SE0, true, 1f, 0);
				break;
			case 39:
				evt.eventPlaySound(DirectionManager.SOUND.S0559, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2021, Sound.CH.VC0, true, 1f, 10);
				break;
			case 40:
				evt.eventPlaySound(DirectionManager.SOUND.S0559, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2021, Sound.CH.VC0, true, 1f, 10);
				break;
			case 41:
				evt.eventPlayMovie(DirectionManager.MOVIE.anv0010, false, false, false, true, 128, 72, 60, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S0559, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2023, Sound.CH.VC0, true, 1f, 10);
				evt.eventPlaySound(DirectionManager.SOUND.S0241, Sound.CH.SE0, true, 1f, 30);
				break;
			case 44:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.anv000_bg, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0558, Sound.CH.SE0, true, 1f, 0);
				break;
			case 45:
				evt.eventPlaySound(DirectionManager.SOUND.S0559, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2021, Sound.CH.VC0, true, 1f, 10);
				break;
			case 46:
				evt.eventPlaySound(DirectionManager.SOUND.S0559, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2021, Sound.CH.VC0, true, 1f, 10);
				break;
			case 47:
				evt.eventPlayMovie(DirectionManager.MOVIE.anv0011, false, false, false, true, 128, 72, 60, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S0559, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2023, Sound.CH.VC0, true, 1f, 10);
				evt.eventPlaySound(DirectionManager.SOUND.S0241, Sound.CH.SE0, true, 1f, 30);
				break;
			case 50:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.anv000_bg, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0558, Sound.CH.SE0, true, 1f, 0);
				break;
			case 51:
				evt.eventPlaySound(DirectionManager.SOUND.S0559, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2021, Sound.CH.VC0, true, 1f, 10);
				break;
			case 52:
				evt.eventPlaySound(DirectionManager.SOUND.S0559, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2021, Sound.CH.VC0, true, 1f, 10);
				break;
			case 53:
				evt.eventPlayMovie(DirectionManager.MOVIE.anv0011, false, false, false, true, 128, 72, 60, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S0559, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2023, Sound.CH.VC0, true, 1f, 10);
				evt.eventPlaySound(DirectionManager.SOUND.S0241, Sound.CH.SE0, true, 1f, 30);
				break;
			case 57:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.anv000_bg, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0558, Sound.CH.SE0, true, 1f, 0);
				break;
			case 58:
				evt.eventPlaySound(DirectionManager.SOUND.S0559, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2021, Sound.CH.VC0, true, 1f, 10);
				break;
			case 59:
				evt.eventPlaySound(DirectionManager.SOUND.S0559, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2021, Sound.CH.VC0, true, 1f, 10);
				break;
			case 60:
				evt.eventPlayMovie(DirectionManager.MOVIE.anv0011, false, false, false, true, 128, 72, 60, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S0559, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2023, Sound.CH.VC0, true, 1f, 10);
				evt.eventPlaySound(DirectionManager.SOUND.S0241, Sound.CH.SE0, true, 1f, 30);
				break;
			case 63:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.anv000_bg, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0558, Sound.CH.SE0, true, 1f, 0);
				break;
			case 64:
				evt.eventPlaySound(DirectionManager.SOUND.S0559, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2021, Sound.CH.VC0, true, 1f, 10);
				break;
			case 65:
				evt.eventPlaySound(DirectionManager.SOUND.S0559, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2021, Sound.CH.VC0, true, 1f, 10);
				break;
			case 66:
				evt.eventPlayMovie(DirectionManager.MOVIE.anv0011, false, false, false, true, 128, 72, 60, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S0559, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2023, Sound.CH.VC0, true, 1f, 10);
				evt.eventPlaySound(DirectionManager.SOUND.S0241, Sound.CH.SE0, true, 1f, 30);
				break;
			case 69:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.anv000_bg, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0558, Sound.CH.SE0, true, 1f, 0);
				break;
			case 70:
				evt.eventPlaySound(DirectionManager.SOUND.S0559, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2021, Sound.CH.VC0, true, 1f, 10);
				break;
			case 71:
				evt.eventPlaySound(DirectionManager.SOUND.S0559, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2021, Sound.CH.VC0, true, 1f, 10);
				break;
			case 72:
				evt.eventPlayMovie(DirectionManager.MOVIE.anv0011, false, false, false, true, 128, 72, 60, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S0559, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2023, Sound.CH.VC0, true, 1f, 10);
				evt.eventPlaySound(DirectionManager.SOUND.S0241, Sound.CH.SE0, true, 1f, 30);
				break;
			case 75:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.anv000_bg, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0558, Sound.CH.SE0, true, 1f, 0);
				break;
			case 76:
				evt.eventPlaySound(DirectionManager.SOUND.S0559, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2021, Sound.CH.VC0, true, 1f, 10);
				break;
			case 77:
				evt.eventPlaySound(DirectionManager.SOUND.S0559, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2021, Sound.CH.VC0, true, 1f, 10);
				break;
			case 78:
				evt.eventPlayMovie(DirectionManager.MOVIE.anv0011, false, false, false, true, 128, 72, 60, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S0559, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2023, Sound.CH.VC0, true, 1f, 10);
				evt.eventPlaySound(DirectionManager.SOUND.S0241, Sound.CH.SE0, true, 1f, 30);
				break;
			case 81:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.anv000_bg, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0558, Sound.CH.SE0, true, 1f, 0);
				break;
			case 82:
				evt.eventPlaySound(DirectionManager.SOUND.S0559, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2021, Sound.CH.VC0, true, 1f, 10);
				break;
			case 83:
				evt.eventPlaySound(DirectionManager.SOUND.S0559, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2021, Sound.CH.VC0, true, 1f, 10);
				break;
			case 84:
				evt.eventPlayMovie(DirectionManager.MOVIE.anv0011, false, false, false, true, 128, 72, 60, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S0559, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2023, Sound.CH.VC0, true, 1f, 10);
				evt.eventPlaySound(DirectionManager.SOUND.S0241, Sound.CH.SE0, true, 1f, 30);
				break;
			case 87:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.anv000_bg, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0558, Sound.CH.SE0, true, 1f, 0);
				break;
			case 88:
				evt.eventPlaySound(DirectionManager.SOUND.S0559, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2021, Sound.CH.VC0, true, 1f, 10);
				break;
			case 89:
				evt.eventPlaySound(DirectionManager.SOUND.S0559, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2021, Sound.CH.VC0, true, 1f, 10);
				break;
			case 90:
				evt.eventPlayMovie(DirectionManager.MOVIE.anv0011, false, false, false, true, 128, 72, 60, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S0559, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2023, Sound.CH.VC0, true, 1f, 10);
				evt.eventPlaySound(DirectionManager.SOUND.S0241, Sound.CH.SE0, true, 1f, 30);
				break;
			case 94:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.anv000_bg, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0558, Sound.CH.SE0, true, 1f, 0);
				break;
			case 95:
				evt.eventPlaySound(DirectionManager.SOUND.S0559, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2021, Sound.CH.VC0, true, 1f, 10);
				break;
			case 96:
				evt.eventPlaySound(DirectionManager.SOUND.S0559, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2021, Sound.CH.VC0, true, 1f, 10);
				break;
			case 97:
				evt.eventPlayMovie(DirectionManager.MOVIE.anv0011, false, false, false, true, 128, 72, 60, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S0559, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2023, Sound.CH.VC0, true, 1f, 10);
				evt.eventPlaySound(DirectionManager.SOUND.S0241, Sound.CH.SE0, true, 1f, 30);
				break;
			case 100:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.anv000_bg, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0558, Sound.CH.SE0, true, 1f, 0);
				break;
			case 101:
				evt.eventPlaySound(DirectionManager.SOUND.S0559, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2021, Sound.CH.VC0, true, 1f, 10);
				break;
			case 102:
				evt.eventPlaySound(DirectionManager.SOUND.S0559, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2021, Sound.CH.VC0, true, 1f, 10);
				break;
			case 103:
				evt.eventPlayMovie(DirectionManager.MOVIE.anv0011, false, false, false, true, 128, 72, 60, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S0559, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2023, Sound.CH.VC0, true, 1f, 10);
				evt.eventPlaySound(DirectionManager.SOUND.S0241, Sound.CH.SE0, true, 1f, 30);
				break;
			case 106:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.anv000_bg, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0558, Sound.CH.SE0, true, 1f, 0);
				break;
			case 107:
				evt.eventPlaySound(DirectionManager.SOUND.S0559, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2021, Sound.CH.VC0, true, 1f, 10);
				break;
			case 108:
				evt.eventPlaySound(DirectionManager.SOUND.S0559, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2021, Sound.CH.VC0, true, 1f, 10);
				break;
			case 109:
				evt.eventPlayMovie(DirectionManager.MOVIE.anv0011, false, false, false, true, 128, 72, 60, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S0559, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2023, Sound.CH.VC0, true, 1f, 10);
				evt.eventPlaySound(DirectionManager.SOUND.S0241, Sound.CH.SE0, true, 1f, 30);
				break;
			case 112:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.anv000_bg, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0558, Sound.CH.SE0, true, 1f, 0);
				break;
			case 113:
				evt.eventPlaySound(DirectionManager.SOUND.S0559, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2021, Sound.CH.VC0, true, 1f, 10);
				break;
			case 114:
				evt.eventPlaySound(DirectionManager.SOUND.S0559, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2021, Sound.CH.VC0, true, 1f, 10);
				break;
			case 115:
				evt.eventPlayMovie(DirectionManager.MOVIE.anv0011, false, false, false, true, 128, 72, 60, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S0559, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2023, Sound.CH.VC0, true, 1f, 10);
				evt.eventPlaySound(DirectionManager.SOUND.S0241, Sound.CH.SE0, true, 1f, 30);
				break;
			case 118:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.anv022, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.anv022_loop, DirectionManager.MOVIE.anv022, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0541, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2017, Sound.CH.VC0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0542, Sound.CH.SE0, true, 1f, 25);
				break;
			case 119:
				evt.eventPlayImage(DirectionManager.IMAGE.anv000_bg, false, false, 0, 0, 110, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.anv023, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.anv023_add, false, false, true, false, 0, 0, 90, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0560, Sound.CH.SE0, true, 1f, 0);
				break;
			case 120:
				evt.eventPlayImage(DirectionManager.IMAGE.anv000_bg, false, false, 0, 0, 110, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.anv024, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.anv024_add, false, false, true, false, 0, 0, 90, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0560, Sound.CH.SE0, true, 1f, 0);
				break;
			case 121:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.anv025, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0561, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0548, Sound.CH.SE0, true, 1f, 37);
				evt.eventPlaySound(DirectionManager.SOUND.S0849, Sound.CH.VC0, true, 1f, 52);
				break;
			case 122:
				evt.eventPlayMovie(DirectionManager.MOVIE.anv026, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0562, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2029, Sound.CH.VC0, true, 1f, 10);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE0, true, 1f, 37);
				evt.eventPlayMovie(DirectionManager.MOVIE.anv026_add, true, false, true, false, 0, 0, 90, 2);
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
			case 16:
				break;
			case 17:
				break;
			case 19:
				break;
			case 20:
				break;
			case 21:
				break;
			case 22:
				break;
			case 23:
				break;
			case 24:
				break;
			case 25:
				break;
			case 26:
				break;
			case 27:
				break;
			case 28:
				break;
			case 29:
				break;
			case 30:
				break;
			case 31:
				break;
			case 32:
				break;
			case 33:
				break;
			case 34:
				break;
			case 35:
				break;
			case 36:
				break;
			case 37:
				break;
			case 38:
				break;
			case 39:
				break;
			case 40:
				break;
			case 41:
				break;
			case 42:
				break;
			case 43:
				break;
			case 44:
				break;
			case 45:
				break;
			case 46:
				break;
			case 47:
				break;
			case 48:
				break;
			case 49:
				break;
			case 50:
				break;
			case 51:
				break;
			case 52:
				break;
			case 53:
				break;
			case 54:
				break;
			case 55:
				break;
			case 57:
				break;
			case 58:
				break;
			case 59:
				break;
			case 60:
				break;
			case 61:
				break;
			case 62:
				break;
			case 63:
				break;
			case 64:
				break;
			case 65:
				break;
			case 66:
				break;
			case 67:
				break;
			case 68:
				break;
			case 69:
				break;
			case 70:
				break;
			case 71:
				break;
			case 72:
				break;
			case 73:
				break;
			case 74:
				break;
			case 75:
				break;
			case 76:
				break;
			case 77:
				break;
			case 78:
				break;
			case 79:
				break;
			case 80:
				break;
			case 81:
				break;
			case 82:
				break;
			case 83:
				break;
			case 84:
				break;
			case 85:
				break;
			case 86:
				break;
			case 87:
				break;
			case 88:
				break;
			case 89:
				break;
			case 90:
				break;
			case 91:
				break;
			case 93:
				break;
			case 94:
				break;
			case 95:
				break;
			case 96:
				break;
			case 97:
				break;
			case 98:
				break;
			case 99:
				break;
			case 100:
				break;
			case 101:
				break;
			case 102:
				break;
			case 103:
				break;
			case 104:
				break;
			case 105:
				break;
			case 106:
				break;
			case 107:
				break;
			case 108:
				break;
			case 109:
				break;
			case 110:
				break;
			case 111:
				break;
			case 112:
				break;
			case 113:
				break;
			case 114:
				break;
			case 115:
				break;
			case 116:
				break;
			case 117:
				break;
			case 118:
				break;
			case 119:
				break;
			case 120:
				break;
			case 121:
				break;
			case 122:
				break;
			case 18:
			case 56:
			case 92:
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

	private void loop(int color, int place, int order)
	{
		if (SGLG.prodAnime.find(43) < 0)
		{
			int ptnID = -1;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			switch (color)
			{
			case 0:
				ptnID = 3;
				break;
			case 1:
				ptnID = 2;
				break;
			case 2:
				ptnID = 1;
				break;
			}
			num = table_x[place];
			num2 = 72;
			num3 = effTbl[place];
			num4 = layerTbl[order];
			evt.eventAddAnimeWithLayerAndPosition(DirectionManager.ANIME.ANV001_b02_loop, ptnID, DirectionManager.ANIME.ANV001_b02, num4, false, true, false, true, num, num2);
		}
	}

	private void failed()
	{
		evt.eventPlayAnime(DirectionManager.ANIME.ANV005, 0, false, false, false, false, 128, 72, 60, 0);
	}

	private void success(int color, int place, int order)
	{
		int num = -1;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		switch (color)
		{
		case 0:
			num = 3;
			break;
		case 1:
			num = 2;
			break;
		case 2:
			num = 1;
			break;
		}
		num2 = table_x[place];
		num3 = 72;
		num4 = effTbl[place];
		num5 = layerTbl[order];
		if (num >= 0)
		{
			switch (order)
			{
			case 0:
				evt.eventPlayAnime(DirectionManager.ANIME.ANV002_a01, num, true, false, true, true, num2, num3, num5, 0);
				evt.eventPlayAnime(DirectionManager.ANIME.HNV002_a01, num, true, false, true, true, num4, num3, num5 - 1, 0);
				break;
			case 1:
				evt.eventPlayAnime(DirectionManager.ANIME.ANV003_b02, num, true, false, true, true, num2, num3, num5, 0);
				evt.eventPlayAnime(DirectionManager.ANIME.HNV003_b02, num, true, false, true, true, num4, num3, num5 - 1, 0);
				break;
			case 2:
				evt.eventPlayAnime(DirectionManager.ANIME.ANV004_c03, num, true, false, true, true, num2, num3, num5, 0);
				evt.eventPlayAnime(DirectionManager.ANIME.HNV004_c03, num, true, false, true, true, num4, num3, num5 - 1, 0);
				break;
			}
		}
	}

	private void appear(int color, int place, int order)
	{
		int num = -1;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		switch (color)
		{
		case 0:
			num = 3;
			break;
		case 1:
			num = 2;
			break;
		case 2:
			num = 1;
			break;
		}
		num2 = table_x[place];
		num3 = 72;
		num4 = layerTbl[order];
		if (num >= 0)
		{
			switch (order)
			{
			case 0:
				evt.eventPlayAnime(DirectionManager.ANIME.ANV001_a01, num, false, false, false, true, num2, num3, num4, 0);
				evt.eventAddAnimeWithLayerAndPosition(DirectionManager.ANIME.ANV001_a01_loop, num, DirectionManager.ANIME.ANV001_a01, num4, false, true, false, true, num2, num3);
				break;
			case 1:
				evt.eventPlayAnime(DirectionManager.ANIME.ANV001_b02, num, false, false, false, true, num2, num3, num4, 0);
				evt.eventAddAnimeWithLayerAndPosition(DirectionManager.ANIME.ANV001_b02_loop, num, DirectionManager.ANIME.ANV001_b02, num4, false, true, false, true, num2, num3);
				break;
			case 2:
				evt.eventPlayAnime(DirectionManager.ANIME.ANV001_c03, num, false, false, false, true, num2, num3, num4, 0);
				break;
			}
		}
	}
}
