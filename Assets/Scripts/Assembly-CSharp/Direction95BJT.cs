public class Direction95BJT : DirectionBase
{
	private int m_cnt;

	public Direction95BJT(DirectionManager _mng, byte _high, byte _low, byte _mode, DirectionManager.DIR _dir)
		: base(_mng, _high, _low, _mode, _dir, DirectionBase.PRIORITY_NORMAL)
	{
	}

	public override void start()
	{
		m_cnt = 0;
		if (isProdStay())
		{
			return;
		}
		int num = mode - 37;
		if (num > 0 && num % 2 == 1)
		{
			byte b = mode;
			if (b == 40 || b == 60 || b == 80 || b == 120 || b == 140 || b == 158)
			{
				setNextLoop(307);
			}
			else
			{
				setNextLoop(100);
			}
		}
		base.start();
		evt.eventDisableBefore(mng, 0);
		makeLestBullets();
		lmpChargeNext();
		if (low == 0)
		{
			switch (mode)
			{
			case 1:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt001_nml, false, false, false, false, 0, 0, 100, 1);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt001_loop, DirectionManager.MOVIE.bjt001_nml, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0150, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0526, Sound.CH.SE0, true, 1f, 15);
				break;
			case 2:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt001_nml2, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt001_loop2, DirectionManager.MOVIE.bjt001_nml2, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0636, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0644, Sound.CH.SE1, true, 1f, 1);
				break;
			case 3:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt003, false, false, false, false, 0, 0, 100, 1);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt003_loop, DirectionManager.MOVIE.bjt003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0505, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE1, true, 1f, 3);
				evt.eventPlaySound(DirectionManager.SOUND.S0152, Sound.CH.BGM, true, 1f, 0);
				break;
			case 4:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt004, false, false, false, false, 0, 0, 100, 1);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt004_loop, DirectionManager.MOVIE.bjt004, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0642, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1232, Sound.CH.VC0, true, 1f, 21);
				evt.eventPlaySound(DirectionManager.SOUND.S0243, Sound.CH.SE0, true, 1f, 55);
				break;
			case 5:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt005, false, false, false, false, 0, 0, 100, 1);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt005_loop, DirectionManager.MOVIE.bjt005, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0643, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1233, Sound.CH.VC0, true, 1f, 0);
				break;
			case 6:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt006, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlaySound(DirectionManager.SOUND.S0434, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1234, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1235, Sound.CH.VC0, true, 1f, 83);
				break;
			case 7:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt007, false, false, false, false, 0, 0, 100, 1);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt007_loop, DirectionManager.MOVIE.bjt007, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0429, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0274, Sound.CH.SE1, true, 1f, 79);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE0, true, 1f, 89);
				evt.eventPlaySound(DirectionManager.SOUND.S0596, Sound.CH.SE1, true, 1f, 124);
				evt.eventPlaySound(DirectionManager.SOUND.S1239, Sound.CH.VC0, true, 1f, 175);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 1, 0);
				break;
			case 8:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt008_1, false, false, false, false, 0, 0, 100, 1);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt008_1_loop, DirectionManager.MOVIE.bjt008_1, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0276, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0875, Sound.CH.VC0, true, 1f, 0);
				break;
			case 9:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt008_white, false, false, false, false, 0, 0, 100, 1);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt008_white_loop, DirectionManager.MOVIE.bjt008_white, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0441, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0896, Sound.CH.VC0, true, 1f, 4);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, true, 128, 119, 94, 9);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, true);
				evt.eventPlaySound(DirectionManager.SOUND.S0223, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_add, false, false, true, false, 0, 0, 93, 0);
				break;
			case 10:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt008_blue, false, false, false, false, 0, 0, 100, 1);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt008_blue_loop, DirectionManager.MOVIE.bjt008_blue, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0441, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0896, Sound.CH.VC0, true, 1f, 4);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, true, 128, 119, 94, 9);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, true);
				evt.eventPlaySound(DirectionManager.SOUND.S0223, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_add, false, false, true, false, 0, 0, 93, 0);
				break;
			case 11:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt008_yellow, false, false, false, false, 0, 0, 100, 1);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt008_yellow_loop, DirectionManager.MOVIE.bjt008_yellow, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0441, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0896, Sound.CH.VC0, true, 1f, 4);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, true, 128, 119, 94, 9);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, true);
				evt.eventPlaySound(DirectionManager.SOUND.S0223, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_add, false, false, true, false, 0, 0, 93, 0);
				break;
			case 12:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt008_green, false, false, false, false, 0, 0, 100, 1);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt008_green_loop, DirectionManager.MOVIE.bjt008_green, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0441, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0896, Sound.CH.VC0, true, 1f, 4);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, true, 128, 119, 94, 9);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, true);
				evt.eventPlaySound(DirectionManager.SOUND.S0223, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_add, false, false, true, false, 0, 0, 93, 0);
				break;
			case 13:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt008_red, false, false, false, false, 0, 0, 100, 1);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt008_red_loop, DirectionManager.MOVIE.bjt008_red, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0441, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0896, Sound.CH.VC0, true, 1f, 4);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, true, 128, 119, 94, 9);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, true);
				evt.eventPlaySound(DirectionManager.SOUND.S0223, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_add, false, false, true, false, 0, 0, 93, 0);
				break;
			case 14:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt008_purple, false, false, false, false, 0, 0, 100, 1);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt008_purple_loop, DirectionManager.MOVIE.bjt008_purple, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0441, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0896, Sound.CH.VC0, true, 1f, 4);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, true, 128, 119, 94, 9);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, true);
				evt.eventPlaySound(DirectionManager.SOUND.S0223, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_add, false, false, true, false, 0, 0, 93, 0);
				break;
			case 15:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt008_rainbow, false, false, false, false, 0, 0, 100, 1);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt008_rainbow_loop, DirectionManager.MOVIE.bjt008_rainbow, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0441, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0896, Sound.CH.VC0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0217, Sound.CH.SE1, true, 1f, 8);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, true, 128, 119, 94, 9);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, true);
				evt.eventPlaySound(DirectionManager.SOUND.S0223, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_add, false, false, true, false, 0, 0, 93, 0);
				break;
			case 16:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt008_white, false, false, false, false, 0, 0, 100, 1);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt008_white_loop, DirectionManager.MOVIE.bjt008_white, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0441, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0865, Sound.CH.VC0, true, 1f, 4);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, true, 128, 119, 94, 9);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, true);
				evt.eventPlaySound(DirectionManager.SOUND.S0234, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_add, false, false, true, false, 0, 0, 93, 0);
				break;
			case 17:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt008_blue, false, false, false, false, 0, 0, 100, 1);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt008_blue_loop, DirectionManager.MOVIE.bjt008_blue, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0441, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0865, Sound.CH.VC0, true, 1f, 4);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, true, 128, 119, 94, 9);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, true);
				evt.eventPlaySound(DirectionManager.SOUND.S0234, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_add, false, false, true, false, 0, 0, 93, 0);
				break;
			case 18:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt008_yellow, false, false, false, false, 0, 0, 100, 1);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt008_yellow_loop, DirectionManager.MOVIE.bjt008_yellow, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0441, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0865, Sound.CH.VC0, true, 1f, 4);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, true, 128, 119, 94, 9);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, true);
				evt.eventPlaySound(DirectionManager.SOUND.S0234, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_add, false, false, true, false, 0, 0, 93, 0);
				break;
			case 19:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt008_green, false, false, false, false, 0, 0, 100, 1);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt008_green_loop, DirectionManager.MOVIE.bjt008_green, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0441, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0865, Sound.CH.VC0, true, 1f, 4);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, true, 128, 119, 94, 9);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, true);
				evt.eventPlaySound(DirectionManager.SOUND.S0234, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_add, false, false, true, false, 0, 0, 93, 0);
				break;
			case 20:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt008_red, false, false, false, false, 0, 0, 100, 1);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt008_red_loop, DirectionManager.MOVIE.bjt008_red, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0441, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0865, Sound.CH.VC0, true, 1f, 4);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, true, 128, 119, 94, 9);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, true);
				evt.eventPlaySound(DirectionManager.SOUND.S0234, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_add, false, false, true, false, 0, 0, 93, 0);
				break;
			case 21:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt008_purple, false, false, false, false, 0, 0, 100, 1);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt008_purple_loop, DirectionManager.MOVIE.bjt008_purple, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0441, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0865, Sound.CH.VC0, true, 1f, 4);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, true, 128, 119, 94, 9);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, true);
				evt.eventPlaySound(DirectionManager.SOUND.S0234, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_add, false, false, true, false, 0, 0, 93, 0);
				break;
			case 22:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt008_rainbow, false, false, false, false, 0, 0, 100, 1);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt008_rainbow_loop, DirectionManager.MOVIE.bjt008_rainbow, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0441, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0865, Sound.CH.VC0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0209, Sound.CH.SE1, true, 1f, 8);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, true, 128, 119, 94, 9);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, true);
				evt.eventPlaySound(DirectionManager.SOUND.S0234, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_add, false, false, true, false, 0, 0, 93, 0);
				break;
			case 23:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt008_white, false, false, false, false, 0, 0, 100, 1);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt008_white_loop, DirectionManager.MOVIE.bjt008_white, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0276, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1018, Sound.CH.VC0, true, 1f, 12);
				evt.eventPlaySound(DirectionManager.SOUND.S0441, Sound.CH.SE0, true, 1f, 36);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, true, 128, 119, 94, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, true);
				evt.eventPlaySound(DirectionManager.SOUND.S0234, Sound.CH.SE1, true, 1f, 36);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_add, false, false, true, false, 0, 0, 93, 36);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt009_add, false, false, true, false, 0, 0, 92, 1);
				evt.eventPlaySound(DirectionManager.SOUND.S0280, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt009_nml, false, false, false, false, 0, 0, 91, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt009_add2, false, false, true, false, 0, 0, 90, 1);
				break;
			case 24:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt008_blue, false, false, false, false, 0, 0, 100, 1);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt008_blue_loop, DirectionManager.MOVIE.bjt008_blue, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0276, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1018, Sound.CH.VC0, true, 1f, 12);
				evt.eventPlaySound(DirectionManager.SOUND.S0441, Sound.CH.SE0, true, 1f, 36);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, true, 128, 119, 94, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, true);
				evt.eventPlaySound(DirectionManager.SOUND.S0234, Sound.CH.SE1, true, 1f, 36);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_add, false, false, true, false, 0, 0, 93, 36);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt009_add, false, false, true, false, 0, 0, 92, 1);
				evt.eventPlaySound(DirectionManager.SOUND.S0280, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt009_nml, false, false, false, false, 0, 0, 91, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt009_add2, false, false, true, false, 0, 0, 90, 1);
				break;
			case 25:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt008_yellow, false, false, false, false, 0, 0, 100, 1);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt008_yellow_loop, DirectionManager.MOVIE.bjt008_yellow, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0276, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1018, Sound.CH.VC0, true, 1f, 12);
				evt.eventPlaySound(DirectionManager.SOUND.S0441, Sound.CH.SE0, true, 1f, 36);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, true, 128, 119, 94, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, true);
				evt.eventPlaySound(DirectionManager.SOUND.S0234, Sound.CH.SE1, true, 1f, 36);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_add, false, false, true, false, 0, 0, 93, 36);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt009_add, false, false, true, false, 0, 0, 92, 1);
				evt.eventPlaySound(DirectionManager.SOUND.S0280, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt009_nml, false, false, false, false, 0, 0, 91, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt009_add2, false, false, true, false, 0, 0, 90, 1);
				break;
			case 26:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt008_green, false, false, false, false, 0, 0, 100, 1);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt008_green_loop, DirectionManager.MOVIE.bjt008_green, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0276, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1018, Sound.CH.VC0, true, 1f, 12);
				evt.eventPlaySound(DirectionManager.SOUND.S0441, Sound.CH.SE0, true, 1f, 36);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, true, 128, 119, 94, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, true);
				evt.eventPlaySound(DirectionManager.SOUND.S0234, Sound.CH.SE1, true, 1f, 36);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_add, false, false, true, false, 0, 0, 93, 36);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt009_add, false, false, true, false, 0, 0, 92, 1);
				evt.eventPlaySound(DirectionManager.SOUND.S0280, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt009_nml, false, false, false, false, 0, 0, 91, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt009_add2, false, false, true, false, 0, 0, 90, 1);
				break;
			case 27:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt008_red, false, false, false, false, 0, 0, 100, 1);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt008_red_loop, DirectionManager.MOVIE.bjt008_red, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0276, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1018, Sound.CH.VC0, true, 1f, 12);
				evt.eventPlaySound(DirectionManager.SOUND.S0441, Sound.CH.SE0, true, 1f, 36);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, true, 128, 119, 94, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, true);
				evt.eventPlaySound(DirectionManager.SOUND.S0234, Sound.CH.SE1, true, 1f, 36);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_add, false, false, true, false, 0, 0, 93, 36);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt009_add, false, false, true, false, 0, 0, 92, 1);
				evt.eventPlaySound(DirectionManager.SOUND.S0280, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt009_nml, false, false, false, false, 0, 0, 91, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt009_add2, false, false, true, false, 0, 0, 90, 1);
				break;
			case 28:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt008_purple, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlaySound(DirectionManager.SOUND.S0276, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1018, Sound.CH.VC0, true, 1f, 12);
				evt.eventPlaySound(DirectionManager.SOUND.S0441, Sound.CH.SE0, true, 1f, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt008_purple_loop, DirectionManager.MOVIE.bjt008_purple, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, true, 128, 119, 94, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, true);
				evt.eventPlaySound(DirectionManager.SOUND.S0234, Sound.CH.SE1, true, 1f, 36);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_add, false, false, true, false, 0, 0, 93, 36);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt009_add, false, false, true, false, 0, 0, 92, 1);
				evt.eventPlaySound(DirectionManager.SOUND.S0280, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt009_nml, false, false, false, false, 0, 0, 91, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt009_add2, false, false, true, false, 0, 0, 90, 1);
				break;
			case 29:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt008_rainbow, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlaySound(DirectionManager.SOUND.S0276, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1018, Sound.CH.VC0, true, 1f, 12);
				evt.eventPlaySound(DirectionManager.SOUND.S0441, Sound.CH.SE0, true, 1f, 36);
				evt.eventPlaySound(DirectionManager.SOUND.S0209, Sound.CH.SE1, true, 1f, 44);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt008_rainbow_loop, DirectionManager.MOVIE.bjt008_rainbow, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, true, 128, 119, 94, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, true);
				evt.eventPlaySound(DirectionManager.SOUND.S0234, Sound.CH.SE1, true, 1f, 36);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_add, false, false, true, false, 0, 0, 93, 36);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt009_add, false, false, true, false, 0, 0, 92, 1);
				evt.eventPlaySound(DirectionManager.SOUND.S0280, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt009_nml, false, false, false, false, 0, 0, 91, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt009_add2, false, false, true, false, 0, 0, 90, 1);
				break;
			case 30:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt008_white, false, false, false, false, 0, 0, 100, 1);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt008_white_loop, DirectionManager.MOVIE.bjt008_white, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0276, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1018, Sound.CH.VC0, true, 1f, 12);
				evt.eventPlaySound(DirectionManager.SOUND.S0441, Sound.CH.SE0, true, 1f, 36);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, true, 128, 119, 94, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, true);
				evt.eventPlaySound(DirectionManager.SOUND.S0234, Sound.CH.SE1, true, 1f, 36);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_add, false, false, true, false, 0, 0, 93, 36);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt009_add, false, false, true, false, 0, 0, 92, 1);
				evt.eventPlaySound(DirectionManager.SOUND.S0280, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt009_nml, false, false, false, false, 0, 0, 91, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt009_add2, false, false, true, false, 0, 0, 90, 1);
				break;
			case 31:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt008_blue, false, false, false, false, 0, 0, 100, 1);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt008_blue_loop, DirectionManager.MOVIE.bjt008_blue, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0276, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1018, Sound.CH.VC0, true, 1f, 12);
				evt.eventPlaySound(DirectionManager.SOUND.S0441, Sound.CH.SE0, true, 1f, 36);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, true, 128, 119, 94, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, true);
				evt.eventPlaySound(DirectionManager.SOUND.S0234, Sound.CH.SE1, true, 1f, 36);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_add, false, false, true, false, 0, 0, 93, 36);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt009_add, false, false, true, false, 0, 0, 92, 1);
				evt.eventPlaySound(DirectionManager.SOUND.S0280, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt009_nml, false, false, false, false, 0, 0, 91, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt009_add2, false, false, true, false, 0, 0, 90, 1);
				break;
			case 32:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt008_yellow, false, false, false, false, 0, 0, 100, 1);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt008_yellow_loop, DirectionManager.MOVIE.bjt008_yellow, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0276, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1018, Sound.CH.VC0, true, 1f, 12);
				evt.eventPlaySound(DirectionManager.SOUND.S0441, Sound.CH.SE0, true, 1f, 36);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, true, 128, 119, 94, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, true);
				evt.eventPlaySound(DirectionManager.SOUND.S0234, Sound.CH.SE1, true, 1f, 36);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_add, false, false, true, false, 0, 0, 93, 36);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt009_add, false, false, true, false, 0, 0, 92, 1);
				evt.eventPlaySound(DirectionManager.SOUND.S0280, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt009_nml, false, false, false, false, 0, 0, 91, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt009_add2, false, false, true, false, 0, 0, 90, 1);
				break;
			case 33:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt008_green, false, false, false, false, 0, 0, 100, 1);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt008_green_loop, DirectionManager.MOVIE.bjt008_green, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0276, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1018, Sound.CH.VC0, true, 1f, 12);
				evt.eventPlaySound(DirectionManager.SOUND.S0441, Sound.CH.SE0, true, 1f, 36);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, true, 128, 119, 94, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, true);
				evt.eventPlaySound(DirectionManager.SOUND.S0234, Sound.CH.SE1, true, 1f, 36);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_add, false, false, true, false, 0, 0, 93, 36);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt009_add, false, false, true, false, 0, 0, 92, 1);
				evt.eventPlaySound(DirectionManager.SOUND.S0280, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt009_nml, false, false, false, false, 0, 0, 91, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt009_add2, false, false, true, false, 0, 0, 90, 1);
				break;
			case 34:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt008_red, false, false, false, false, 0, 0, 100, 1);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt008_red_loop, DirectionManager.MOVIE.bjt008_red, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0276, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1018, Sound.CH.VC0, true, 1f, 12);
				evt.eventPlaySound(DirectionManager.SOUND.S0441, Sound.CH.SE0, true, 1f, 36);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, true, 128, 119, 94, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, true);
				evt.eventPlaySound(DirectionManager.SOUND.S0234, Sound.CH.SE1, true, 1f, 36);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_add, false, false, true, false, 0, 0, 93, 36);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt009_add, false, false, true, false, 0, 0, 92, 1);
				evt.eventPlaySound(DirectionManager.SOUND.S0280, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt009_nml, false, false, false, false, 0, 0, 91, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt009_add2, false, false, true, false, 0, 0, 90, 1);
				break;
			case 35:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt008_purple, false, false, false, false, 0, 0, 100, 1);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt008_purple_loop, DirectionManager.MOVIE.bjt008_purple, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0276, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1018, Sound.CH.VC0, true, 1f, 12);
				evt.eventPlaySound(DirectionManager.SOUND.S0441, Sound.CH.SE0, true, 1f, 36);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, true, 128, 119, 94, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, true);
				evt.eventPlaySound(DirectionManager.SOUND.S0234, Sound.CH.SE1, true, 1f, 36);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_add, false, false, true, false, 0, 0, 93, 36);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt009_add, false, false, true, false, 0, 0, 92, 1);
				evt.eventPlaySound(DirectionManager.SOUND.S0280, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt009_nml, false, false, false, false, 0, 0, 91, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt009_add2, false, false, true, false, 0, 0, 90, 1);
				break;
			case 36:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt008_rainbow, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlaySound(DirectionManager.SOUND.S0276, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1018, Sound.CH.VC0, true, 1f, 12);
				evt.eventPlaySound(DirectionManager.SOUND.S0441, Sound.CH.SE0, true, 1f, 36);
				evt.eventPlaySound(DirectionManager.SOUND.S0209, Sound.CH.SE1, true, 1f, 44);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, true, 128, 119, 94, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, true);
				evt.eventPlaySound(DirectionManager.SOUND.S0234, Sound.CH.SE1, true, 1f, 36);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_add, false, false, true, false, 0, 0, 93, 36);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt009_add, false, false, true, false, 0, 0, 92, 1);
				evt.eventPlaySound(DirectionManager.SOUND.S0280, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt009_nml, false, false, false, false, 0, 0, 91, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt009_add2, false, false, true, false, 0, 0, 90, 1);
				break;
			case 37:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_white, false, false, false, false, 0, 0, 100, 1);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt011_white, DirectionManager.MOVIE.bjt010_white, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt014, DirectionManager.MOVIE.bjt011_white, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0278, Sound.CH.SE0, true, 1f, 78);
				evt.eventPlaySound(DirectionManager.SOUND.S0940, Sound.CH.VC0, true, 1f, 136);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE0, true, 1f, 178);
				evt.eventPlaySound(DirectionManager.SOUND.S1039, Sound.CH.VC1, true, 1f, 178);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 38:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_white, false, false, false, false, 0, 0, 100, 1);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt011_white, DirectionManager.MOVIE.bjt010_white, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt011_loop, DirectionManager.MOVIE.bjt011_white, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0279, Sound.CH.SE0, true, 1f, 78);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 39:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_white, false, false, false, false, 0, 0, 100, 1);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_white, DirectionManager.MOVIE.bjt010_white, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_2_kyotu, DirectionManager.MOVIE.bjt012_white, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_2_kyotu_loop, DirectionManager.MOVIE.bjt012_2_kyotu, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0281, Sound.CH.SE1, true, 1f, 78);
				evt.eventPlaySound(DirectionManager.SOUND.S0274, Sound.CH.SE0, true, 1f, 134);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE1, true, 1f, 153);
				evt.eventPlaySound(DirectionManager.SOUND.S0596, Sound.CH.SE0, true, 1f, 188);
				evt.eventPlaySound(DirectionManager.SOUND.S1022, Sound.CH.VC0, true, 1f, 214);
				evt.eventPlaySound(DirectionManager.SOUND.S0282, Sound.CH.SE1, true, 1f, 224);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 1, 78);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 40:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_white, false, false, false, false, 0, 0, 100, 1);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_white, DirectionManager.MOVIE.bjt010_white, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt013, DirectionManager.MOVIE.bjt012_white, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt013_loop, DirectionManager.MOVIE.bjt013, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0281, Sound.CH.SE1, true, 1f, 78);
				evt.eventPlaySound(DirectionManager.SOUND.S0274, Sound.CH.SE0, true, 1f, 134);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE1, true, 1f, 153);
				evt.eventPlaySound(DirectionManager.SOUND.S0596, Sound.CH.SE0, true, 1f, 188);
				evt.eventPlaySound(DirectionManager.SOUND.S0596, Sound.CH.SE0, true, 1f, 188);
				evt.eventPlaySound(DirectionManager.SOUND.S0174, Sound.CH.BGM, true, 1f, 78);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 41:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_white, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0224, Sound.CH.SE1, true, 1f, 36);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE0, true, 1f, 101);
				evt.eventPlaySound(DirectionManager.SOUND.S1022, Sound.CH.VC0, true, 1f, 120);
				evt.eventPlaySound(DirectionManager.SOUND.S0282, Sound.CH.SE0, true, 1f, 132);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1707();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_10, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_10_loop, DirectionManager.MOVIE.huc008_T_10, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt012_2_kyotu, false, false, false, false, 0, 0, 98, 101);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_2_kyotu_loop, DirectionManager.MOVIE.bjt012_2_kyotu, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 42:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_white, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0224, Sound.CH.SE1, true, 1f, 36);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1707();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_10, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_10_loop, DirectionManager.MOVIE.huc008_T_10, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 43:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_white, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0225, Sound.CH.SE1, true, 1f, 36);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE0, true, 1f, 101);
				evt.eventPlaySound(DirectionManager.SOUND.S1022, Sound.CH.VC0, true, 1f, 120);
				evt.eventPlaySound(DirectionManager.SOUND.S0282, Sound.CH.SE0, false, 1f, 132);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1707();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_20, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_20_loop, DirectionManager.MOVIE.huc008_T_20, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt012_2_kyotu, false, false, false, false, 0, 0, 98, 101);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_2_kyotu_loop, DirectionManager.MOVIE.bjt012_2_kyotu, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 44:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_white, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0225, Sound.CH.SE1, true, 1f, 36);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1707();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_20, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_20_loop, DirectionManager.MOVIE.huc008_T_20, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 45:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_white, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0226, Sound.CH.SE1, true, 1f, 36);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE0, true, 1f, 101);
				evt.eventPlaySound(DirectionManager.SOUND.S1022, Sound.CH.VC0, true, 1f, 120);
				evt.eventPlaySound(DirectionManager.SOUND.S0282, Sound.CH.SE0, false, 1f, 132);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1707();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_30, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_30_loop, DirectionManager.MOVIE.huc008_T_30, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt012_2_kyotu, false, false, false, false, 0, 0, 98, 101);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_2_kyotu_loop, DirectionManager.MOVIE.bjt012_2_kyotu, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 46:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_white, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0226, Sound.CH.SE1, true, 1f, 36);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1707();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_30, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_30_loop, DirectionManager.MOVIE.huc008_T_30, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 47:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_white, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0227, Sound.CH.SE1, true, 1f, 36);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE0, true, 1f, 101);
				evt.eventPlaySound(DirectionManager.SOUND.S1022, Sound.CH.VC0, true, 1f, 120);
				evt.eventPlaySound(DirectionManager.SOUND.S0282, Sound.CH.SE0, false, 1f, 132);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1711();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1713();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_50, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_50_loop, DirectionManager.MOVIE.huc008_T_50, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt012_2_kyotu, false, false, false, false, 0, 0, 98, 101);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_2_kyotu_loop, DirectionManager.MOVIE.bjt012_2_kyotu, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 48:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_white, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0227, Sound.CH.SE1, true, 1f, 36);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1711();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1713();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_50, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_50_loop, DirectionManager.MOVIE.huc008_T_50, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 49:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_white, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0228, Sound.CH.SE1, true, 1f, 36);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE0, true, 1f, 101);
				evt.eventPlaySound(DirectionManager.SOUND.S1022, Sound.CH.VC0, true, 1f, 120);
				evt.eventPlaySound(DirectionManager.SOUND.S0282, Sound.CH.SE0, false, 1f, 132);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1711();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1713();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_100, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_100_loop, DirectionManager.MOVIE.huc008_T_100, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt012_2_kyotu, false, false, false, false, 0, 0, 98, 101);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_2_kyotu_loop, DirectionManager.MOVIE.bjt012_2_kyotu, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 50:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_white, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0228, Sound.CH.SE1, true, 1f, 36);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1711();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1713();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_100, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_100_loop, DirectionManager.MOVIE.huc008_T_100, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 51:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_white, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0229, Sound.CH.SE1, true, 1f, 36);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE0, true, 1f, 101);
				evt.eventPlaySound(DirectionManager.SOUND.S1022, Sound.CH.VC0, true, 1f, 120);
				evt.eventPlaySound(DirectionManager.SOUND.S0282, Sound.CH.SE0, false, 1f, 132);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1711();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1713();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_150, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_150_loop, DirectionManager.MOVIE.huc008_T_150, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt012_2_kyotu, false, false, false, false, 0, 0, 98, 101);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_2_kyotu_loop, DirectionManager.MOVIE.bjt012_2_kyotu, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 52:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_white, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0229, Sound.CH.SE1, true, 1f, 36);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1711();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1713();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_150, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_150_loop, DirectionManager.MOVIE.huc008_T_150, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 53:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_white, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0230, Sound.CH.SE1, true, 1f, 36);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE0, true, 1f, 101);
				evt.eventPlaySound(DirectionManager.SOUND.S1022, Sound.CH.VC0, true, 1f, 120);
				evt.eventPlaySound(DirectionManager.SOUND.S0282, Sound.CH.SE0, false, 1f, 132);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1717();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1719();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_200, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_200_loop, DirectionManager.MOVIE.huc008_T_200, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt012_2_kyotu, false, false, false, false, 0, 0, 98, 101);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_2_kyotu_loop, DirectionManager.MOVIE.bjt012_2_kyotu, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 54:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_white, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0230, Sound.CH.SE1, true, 1f, 36);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1717();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1719();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_200, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_200_loop, DirectionManager.MOVIE.huc008_T_200, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 55:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_white, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0231, Sound.CH.SE1, true, 1f, 36);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE0, true, 1f, 101);
				evt.eventPlaySound(DirectionManager.SOUND.S1022, Sound.CH.VC0, true, 1f, 120);
				evt.eventPlaySound(DirectionManager.SOUND.S0282, Sound.CH.SE0, false, 1f, 132);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1717();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1719();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_300, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_300_loop, DirectionManager.MOVIE.huc008_T_300, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt012_2_kyotu, false, false, false, false, 0, 0, 98, 101);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_2_kyotu_loop, DirectionManager.MOVIE.bjt012_2_kyotu, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 56:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_white, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0231, Sound.CH.SE1, true, 1f, 36);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1717();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1719();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_300, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_300_loop, DirectionManager.MOVIE.huc008_T_300, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 57:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_blue, false, false, false, false, 0, 0, 100, 1);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt011_blue, DirectionManager.MOVIE.bjt010_blue, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt014, DirectionManager.MOVIE.bjt011_blue, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0278, Sound.CH.SE0, true, 1f, 78);
				evt.eventPlaySound(DirectionManager.SOUND.S0940, Sound.CH.VC0, true, 1f, 136);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE0, true, 1f, 178);
				evt.eventPlaySound(DirectionManager.SOUND.S1039, Sound.CH.VC1, true, 1f, 178);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 58:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_blue, false, false, false, false, 0, 0, 100, 1);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt011_blue, DirectionManager.MOVIE.bjt010_blue, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt011_loop, DirectionManager.MOVIE.bjt011_blue, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0279, Sound.CH.SE0, true, 1f, 78);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 59:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_blue, false, false, false, false, 0, 0, 100, 1);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_blue, DirectionManager.MOVIE.bjt010_blue, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_2_kyotu, DirectionManager.MOVIE.bjt012_blue, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_2_kyotu_loop, DirectionManager.MOVIE.bjt012_2_kyotu, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0281, Sound.CH.SE1, true, 1f, 78);
				evt.eventPlaySound(DirectionManager.SOUND.S0274, Sound.CH.SE0, true, 1f, 134);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE1, true, 1f, 153);
				evt.eventPlaySound(DirectionManager.SOUND.S0596, Sound.CH.SE0, true, 1f, 188);
				evt.eventPlaySound(DirectionManager.SOUND.S1022, Sound.CH.VC0, true, 1f, 214);
				evt.eventPlaySound(DirectionManager.SOUND.S0282, Sound.CH.SE1, true, 1f, 224);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 1, 78);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 60:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_blue, false, false, false, false, 0, 0, 100, 1);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_blue, DirectionManager.MOVIE.bjt010_blue, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt013, DirectionManager.MOVIE.bjt012_blue, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt013_loop, DirectionManager.MOVIE.bjt013, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0281, Sound.CH.SE1, true, 1f, 78);
				evt.eventPlaySound(DirectionManager.SOUND.S0274, Sound.CH.SE0, true, 1f, 134);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE1, true, 1f, 153);
				evt.eventPlaySound(DirectionManager.SOUND.S0596, Sound.CH.SE0, true, 1f, 188);
				evt.eventPlaySound(DirectionManager.SOUND.S0596, Sound.CH.SE0, true, 1f, 188);
				evt.eventPlaySound(DirectionManager.SOUND.S0174, Sound.CH.BGM, true, 1f, 78);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 61:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_blue, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0224, Sound.CH.SE1, true, 1f, 36);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE0, true, 1f, 101);
				evt.eventPlaySound(DirectionManager.SOUND.S1022, Sound.CH.VC0, true, 1f, 120);
				evt.eventPlaySound(DirectionManager.SOUND.S0282, Sound.CH.SE0, false, 1f, 132);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1707();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_10, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_10_loop, DirectionManager.MOVIE.huc008_T_10, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt012_2_kyotu, false, false, false, false, 0, 0, 98, 101);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_2_kyotu_loop, DirectionManager.MOVIE.bjt012_2_kyotu, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 62:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_blue, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0224, Sound.CH.SE1, true, 1f, 36);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1707();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_10, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_10_loop, DirectionManager.MOVIE.huc008_T_10, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 63:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_blue, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0225, Sound.CH.SE1, true, 1f, 36);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE0, true, 1f, 101);
				evt.eventPlaySound(DirectionManager.SOUND.S1022, Sound.CH.VC0, true, 1f, 120);
				evt.eventPlaySound(DirectionManager.SOUND.S0282, Sound.CH.SE0, false, 1f, 132);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1707();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_20, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_20_loop, DirectionManager.MOVIE.huc008_T_20, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt012_2_kyotu, false, false, false, false, 0, 0, 98, 101);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_2_kyotu_loop, DirectionManager.MOVIE.bjt012_2_kyotu, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 64:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_blue, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0225, Sound.CH.SE1, true, 1f, 36);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1707();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_20, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_20_loop, DirectionManager.MOVIE.huc008_T_20, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 65:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_blue, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0226, Sound.CH.SE1, true, 1f, 36);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE0, true, 1f, 101);
				evt.eventPlaySound(DirectionManager.SOUND.S1022, Sound.CH.VC0, true, 1f, 120);
				evt.eventPlaySound(DirectionManager.SOUND.S0282, Sound.CH.SE0, false, 1f, 132);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1707();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_30, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_30_loop, DirectionManager.MOVIE.huc008_T_30, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt012_2_kyotu, false, false, false, false, 0, 0, 98, 101);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_2_kyotu_loop, DirectionManager.MOVIE.bjt012_2_kyotu, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 66:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_blue, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0226, Sound.CH.SE1, true, 1f, 36);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1707();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_30, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_30_loop, DirectionManager.MOVIE.huc008_T_30, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 67:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_blue, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0227, Sound.CH.SE1, true, 1f, 36);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE0, true, 1f, 101);
				evt.eventPlaySound(DirectionManager.SOUND.S1022, Sound.CH.VC0, true, 1f, 120);
				evt.eventPlaySound(DirectionManager.SOUND.S0282, Sound.CH.SE0, false, 1f, 132);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1711();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1713();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_50, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_50_loop, DirectionManager.MOVIE.huc008_T_50, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt012_2_kyotu, false, false, false, false, 0, 0, 98, 101);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_2_kyotu_loop, DirectionManager.MOVIE.bjt012_2_kyotu, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 68:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_blue, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0227, Sound.CH.SE1, true, 1f, 36);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1711();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1713();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_50, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_50_loop, DirectionManager.MOVIE.huc008_T_50, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 69:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_blue, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0228, Sound.CH.SE1, true, 1f, 36);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE0, true, 1f, 101);
				evt.eventPlaySound(DirectionManager.SOUND.S1022, Sound.CH.VC0, true, 1f, 120);
				evt.eventPlaySound(DirectionManager.SOUND.S0282, Sound.CH.SE0, false, 1f, 132);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1711();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1713();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_100, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_100_loop, DirectionManager.MOVIE.huc008_T_100, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt012_2_kyotu, false, false, false, false, 0, 0, 98, 101);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_2_kyotu_loop, DirectionManager.MOVIE.bjt012_2_kyotu, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 70:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_blue, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0228, Sound.CH.SE1, true, 1f, 36);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1711();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1713();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_100, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_100_loop, DirectionManager.MOVIE.huc008_T_100, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 71:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_blue, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0229, Sound.CH.SE1, true, 1f, 36);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE0, true, 1f, 101);
				evt.eventPlaySound(DirectionManager.SOUND.S1022, Sound.CH.VC0, true, 1f, 120);
				evt.eventPlaySound(DirectionManager.SOUND.S0282, Sound.CH.SE0, false, 1f, 132);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1711();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1713();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_150, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_150_loop, DirectionManager.MOVIE.huc008_T_150, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt012_2_kyotu, false, false, false, false, 0, 0, 98, 101);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_2_kyotu_loop, DirectionManager.MOVIE.bjt012_2_kyotu, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 72:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_blue, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0229, Sound.CH.SE1, true, 1f, 36);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1711();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1713();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_150, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_150_loop, DirectionManager.MOVIE.huc008_T_150, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 73:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_blue, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0230, Sound.CH.SE1, true, 1f, 36);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE0, true, 1f, 101);
				evt.eventPlaySound(DirectionManager.SOUND.S1022, Sound.CH.VC0, true, 1f, 120);
				evt.eventPlaySound(DirectionManager.SOUND.S0282, Sound.CH.SE0, false, 1f, 132);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1717();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1719();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_200, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_200_loop, DirectionManager.MOVIE.huc008_T_200, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt012_2_kyotu, false, false, false, false, 0, 0, 98, 101);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_2_kyotu_loop, DirectionManager.MOVIE.bjt012_2_kyotu, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 74:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_blue, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0230, Sound.CH.SE1, true, 1f, 36);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1717();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1719();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_200, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_200_loop, DirectionManager.MOVIE.huc008_T_200, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 75:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_blue, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0231, Sound.CH.SE1, true, 1f, 36);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE0, true, 1f, 101);
				evt.eventPlaySound(DirectionManager.SOUND.S1022, Sound.CH.VC0, true, 1f, 120);
				evt.eventPlaySound(DirectionManager.SOUND.S0282, Sound.CH.SE0, false, 1f, 132);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1717();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1719();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_300, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_300_loop, DirectionManager.MOVIE.huc008_T_300, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt012_2_kyotu, false, false, false, false, 0, 0, 98, 101);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_2_kyotu_loop, DirectionManager.MOVIE.bjt012_2_kyotu, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 76:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_blue, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0231, Sound.CH.SE1, true, 1f, 36);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1717();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1719();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_300, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_300_loop, DirectionManager.MOVIE.huc008_T_300, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 77:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_yellow, false, false, false, false, 0, 0, 100, 1);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt011_yellow, DirectionManager.MOVIE.bjt010_yellow, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt014, DirectionManager.MOVIE.bjt011_yellow, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0278, Sound.CH.SE0, true, 1f, 78);
				evt.eventPlaySound(DirectionManager.SOUND.S0940, Sound.CH.VC0, true, 1f, 136);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE0, true, 1f, 178);
				evt.eventPlaySound(DirectionManager.SOUND.S1039, Sound.CH.VC1, true, 1f, 178);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 78:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_yellow, false, false, false, false, 0, 0, 100, 1);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt011_yellow, DirectionManager.MOVIE.bjt010_yellow, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt011_loop, DirectionManager.MOVIE.bjt011_yellow, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0279, Sound.CH.SE0, true, 1f, 78);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 79:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_yellow, false, false, false, false, 0, 0, 100, 1);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_yellow, DirectionManager.MOVIE.bjt010_yellow, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_2_kyotu, DirectionManager.MOVIE.bjt012_yellow, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_2_kyotu_loop, DirectionManager.MOVIE.bjt012_2_kyotu, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0281, Sound.CH.SE1, true, 1f, 78);
				evt.eventPlaySound(DirectionManager.SOUND.S0274, Sound.CH.SE0, true, 1f, 134);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE1, true, 1f, 153);
				evt.eventPlaySound(DirectionManager.SOUND.S0596, Sound.CH.SE0, true, 1f, 188);
				evt.eventPlaySound(DirectionManager.SOUND.S1022, Sound.CH.VC0, true, 1f, 214);
				evt.eventPlaySound(DirectionManager.SOUND.S0282, Sound.CH.SE1, true, 1f, 224);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 1, 78);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 80:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_yellow, false, false, false, false, 0, 0, 100, 1);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_yellow, DirectionManager.MOVIE.bjt010_yellow, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt013, DirectionManager.MOVIE.bjt012_yellow, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt013_loop, DirectionManager.MOVIE.bjt013, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0281, Sound.CH.SE1, true, 1f, 78);
				evt.eventPlaySound(DirectionManager.SOUND.S0274, Sound.CH.SE0, true, 1f, 134);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE1, true, 1f, 153);
				evt.eventPlaySound(DirectionManager.SOUND.S0596, Sound.CH.SE0, true, 1f, 188);
				evt.eventPlaySound(DirectionManager.SOUND.S0596, Sound.CH.SE0, true, 1f, 188);
				evt.eventPlaySound(DirectionManager.SOUND.S0174, Sound.CH.BGM, true, 1f, 78);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 81:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_yellow, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0224, Sound.CH.SE1, true, 1f, 36);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE0, true, 1f, 101);
				evt.eventPlaySound(DirectionManager.SOUND.S1022, Sound.CH.VC0, true, 1f, 120);
				evt.eventPlaySound(DirectionManager.SOUND.S0282, Sound.CH.SE0, false, 1f, 132);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1707();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_10, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_10_loop, DirectionManager.MOVIE.huc008_T_10, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt012_2_kyotu, false, false, false, false, 0, 0, 98, 101);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_2_kyotu_loop, DirectionManager.MOVIE.bjt012_2_kyotu, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 82:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_yellow, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0224, Sound.CH.SE1, true, 1f, 36);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1707();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_10, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_10_loop, DirectionManager.MOVIE.huc008_T_10, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 83:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_yellow, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0225, Sound.CH.SE1, true, 1f, 36);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE0, true, 1f, 101);
				evt.eventPlaySound(DirectionManager.SOUND.S1022, Sound.CH.VC0, true, 1f, 120);
				evt.eventPlaySound(DirectionManager.SOUND.S0282, Sound.CH.SE0, false, 1f, 132);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1707();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_20, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_20_loop, DirectionManager.MOVIE.huc008_T_20, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt012_2_kyotu, false, false, false, false, 0, 0, 98, 101);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_2_kyotu_loop, DirectionManager.MOVIE.bjt012_2_kyotu, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 84:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_yellow, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0225, Sound.CH.SE1, true, 1f, 36);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1707();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_20, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_20_loop, DirectionManager.MOVIE.huc008_T_20, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 85:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_yellow, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0226, Sound.CH.SE1, true, 1f, 36);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE0, true, 1f, 101);
				evt.eventPlaySound(DirectionManager.SOUND.S1022, Sound.CH.VC0, true, 1f, 120);
				evt.eventPlaySound(DirectionManager.SOUND.S0282, Sound.CH.SE0, false, 1f, 132);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1707();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_30, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_30_loop, DirectionManager.MOVIE.huc008_T_30, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt012_2_kyotu, false, false, false, false, 0, 0, 98, 101);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_2_kyotu_loop, DirectionManager.MOVIE.bjt012_2_kyotu, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 86:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_yellow, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0226, Sound.CH.SE1, true, 1f, 36);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1707();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_30, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_30_loop, DirectionManager.MOVIE.huc008_T_30, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 87:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_yellow, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0227, Sound.CH.SE1, true, 1f, 36);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE0, true, 1f, 101);
				evt.eventPlaySound(DirectionManager.SOUND.S1022, Sound.CH.VC0, true, 1f, 120);
				evt.eventPlaySound(DirectionManager.SOUND.S0282, Sound.CH.SE0, false, 1f, 132);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1711();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1713();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_50, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_50_loop, DirectionManager.MOVIE.huc008_T_50, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt012_2_kyotu, false, false, false, false, 0, 0, 98, 101);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_2_kyotu_loop, DirectionManager.MOVIE.bjt012_2_kyotu, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 88:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_yellow, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0227, Sound.CH.SE1, true, 1f, 36);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1711();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1713();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_50, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_50_loop, DirectionManager.MOVIE.huc008_T_50, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 89:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_yellow, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0228, Sound.CH.SE1, true, 1f, 36);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE0, true, 1f, 101);
				evt.eventPlaySound(DirectionManager.SOUND.S1022, Sound.CH.VC0, true, 1f, 120);
				evt.eventPlaySound(DirectionManager.SOUND.S0282, Sound.CH.SE0, false, 1f, 132);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1711();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1713();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_100, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_100_loop, DirectionManager.MOVIE.huc008_T_100, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt012_2_kyotu, false, false, false, false, 0, 0, 98, 101);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_2_kyotu_loop, DirectionManager.MOVIE.bjt012_2_kyotu, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 90:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_yellow, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0228, Sound.CH.SE1, true, 1f, 36);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1711();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1713();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_100, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_100_loop, DirectionManager.MOVIE.huc008_T_100, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 91:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_yellow, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0229, Sound.CH.SE1, true, 1f, 36);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE0, true, 1f, 101);
				evt.eventPlaySound(DirectionManager.SOUND.S1022, Sound.CH.VC0, true, 1f, 120);
				evt.eventPlaySound(DirectionManager.SOUND.S0282, Sound.CH.SE0, false, 1f, 132);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1711();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1713();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_150, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_150_loop, DirectionManager.MOVIE.huc008_T_150, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt012_2_kyotu, false, false, false, false, 0, 0, 98, 101);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_2_kyotu_loop, DirectionManager.MOVIE.bjt012_2_kyotu, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 92:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_yellow, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0229, Sound.CH.SE1, true, 1f, 36);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1711();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1713();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_150, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_150_loop, DirectionManager.MOVIE.huc008_T_150, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 93:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_yellow, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0230, Sound.CH.SE1, true, 1f, 36);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE0, true, 1f, 101);
				evt.eventPlaySound(DirectionManager.SOUND.S1022, Sound.CH.VC0, true, 1f, 120);
				evt.eventPlaySound(DirectionManager.SOUND.S0282, Sound.CH.SE0, false, 1f, 132);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1717();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1719();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_200, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_200_loop, DirectionManager.MOVIE.huc008_T_200, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt012_2_kyotu, false, false, false, false, 0, 0, 98, 101);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_2_kyotu_loop, DirectionManager.MOVIE.bjt012_2_kyotu, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 94:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_yellow, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0230, Sound.CH.SE1, true, 1f, 36);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1717();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1719();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_200, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_200_loop, DirectionManager.MOVIE.huc008_T_200, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 95:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_yellow, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0231, Sound.CH.SE1, true, 1f, 36);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE0, true, 1f, 101);
				evt.eventPlaySound(DirectionManager.SOUND.S1022, Sound.CH.VC0, true, 1f, 120);
				evt.eventPlaySound(DirectionManager.SOUND.S0282, Sound.CH.SE0, false, 1f, 132);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1717();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1719();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_300, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_300_loop, DirectionManager.MOVIE.huc008_T_300, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt012_2_kyotu, false, false, false, false, 0, 0, 98, 101);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_2_kyotu_loop, DirectionManager.MOVIE.bjt012_2_kyotu, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 96:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_yellow, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0231, Sound.CH.SE1, true, 1f, 36);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1717();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1719();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_300, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_300_loop, DirectionManager.MOVIE.huc008_T_300, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 97:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_green, false, false, false, false, 0, 0, 100, 1);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt011_green, DirectionManager.MOVIE.bjt010_green, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt014, DirectionManager.MOVIE.bjt011_green, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0278, Sound.CH.SE0, true, 1f, 78);
				evt.eventPlaySound(DirectionManager.SOUND.S0940, Sound.CH.VC0, true, 1f, 136);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE0, true, 1f, 178);
				evt.eventPlaySound(DirectionManager.SOUND.S1039, Sound.CH.VC1, true, 1f, 178);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 98:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_green, false, false, false, false, 0, 0, 100, 1);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt011_green, DirectionManager.MOVIE.bjt010_green, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt011_loop, DirectionManager.MOVIE.bjt011_green, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0279, Sound.CH.SE0, true, 1f, 78);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 99:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_green, false, false, false, false, 0, 0, 100, 1);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_green, DirectionManager.MOVIE.bjt010_green, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_2_kyotu, DirectionManager.MOVIE.bjt012_green, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_2_kyotu_loop, DirectionManager.MOVIE.bjt012_2_kyotu, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0281, Sound.CH.SE1, true, 1f, 78);
				evt.eventPlaySound(DirectionManager.SOUND.S0274, Sound.CH.SE0, true, 1f, 134);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE1, true, 1f, 153);
				evt.eventPlaySound(DirectionManager.SOUND.S0596, Sound.CH.SE0, true, 1f, 188);
				evt.eventPlaySound(DirectionManager.SOUND.S1022, Sound.CH.VC0, true, 1f, 214);
				evt.eventPlaySound(DirectionManager.SOUND.S0282, Sound.CH.SE1, true, 1f, 224);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 1, 78);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 100:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_green, false, false, false, false, 0, 0, 100, 1);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_green, DirectionManager.MOVIE.bjt010_green, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt013, DirectionManager.MOVIE.bjt012_green, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt013_loop, DirectionManager.MOVIE.bjt013, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0281, Sound.CH.SE1, true, 1f, 78);
				evt.eventPlaySound(DirectionManager.SOUND.S0274, Sound.CH.SE0, true, 1f, 134);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE1, true, 1f, 153);
				evt.eventPlaySound(DirectionManager.SOUND.S0596, Sound.CH.SE0, true, 1f, 188);
				evt.eventPlaySound(DirectionManager.SOUND.S0596, Sound.CH.SE0, true, 1f, 188);
				evt.eventPlaySound(DirectionManager.SOUND.S0174, Sound.CH.BGM, true, 1f, 78);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 101:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_green, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0224, Sound.CH.SE1, true, 1f, 36);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE0, true, 1f, 101);
				evt.eventPlaySound(DirectionManager.SOUND.S1022, Sound.CH.VC0, true, 1f, 120);
				evt.eventPlaySound(DirectionManager.SOUND.S0282, Sound.CH.SE0, false, 1f, 132);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1707();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_10, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_10_loop, DirectionManager.MOVIE.huc008_T_10, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt012_2_kyotu, false, false, false, false, 0, 0, 98, 101);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_2_kyotu_loop, DirectionManager.MOVIE.bjt012_2_kyotu, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 102:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_green, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0224, Sound.CH.SE1, true, 1f, 36);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1707();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_10, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_10_loop, DirectionManager.MOVIE.huc008_T_10, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 103:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_green, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0225, Sound.CH.SE1, true, 1f, 36);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE0, true, 1f, 101);
				evt.eventPlaySound(DirectionManager.SOUND.S1022, Sound.CH.VC0, true, 1f, 120);
				evt.eventPlaySound(DirectionManager.SOUND.S0282, Sound.CH.SE0, false, 1f, 132);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1707();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_20, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_20_loop, DirectionManager.MOVIE.huc008_T_20, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt012_2_kyotu, false, false, false, false, 0, 0, 98, 101);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_2_kyotu_loop, DirectionManager.MOVIE.bjt012_2_kyotu, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 104:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_green, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0225, Sound.CH.SE1, true, 1f, 36);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1707();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_20, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_20_loop, DirectionManager.MOVIE.huc008_T_20, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 105:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_green, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0226, Sound.CH.SE1, true, 1f, 36);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE0, true, 1f, 101);
				evt.eventPlaySound(DirectionManager.SOUND.S1022, Sound.CH.VC0, true, 1f, 120);
				evt.eventPlaySound(DirectionManager.SOUND.S0282, Sound.CH.SE0, false, 1f, 132);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1707();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_30, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_30_loop, DirectionManager.MOVIE.huc008_T_30, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt012_2_kyotu, false, false, false, false, 0, 0, 98, 101);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_2_kyotu_loop, DirectionManager.MOVIE.bjt012_2_kyotu, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 106:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_green, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0226, Sound.CH.SE1, true, 1f, 36);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1707();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_30, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_30_loop, DirectionManager.MOVIE.huc008_T_30, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 107:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_green, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0227, Sound.CH.SE1, true, 1f, 36);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE0, true, 1f, 101);
				evt.eventPlaySound(DirectionManager.SOUND.S1022, Sound.CH.VC0, true, 1f, 120);
				evt.eventPlaySound(DirectionManager.SOUND.S0282, Sound.CH.SE0, false, 1f, 132);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1711();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1713();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_50, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_50_loop, DirectionManager.MOVIE.huc008_T_50, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt012_2_kyotu, false, false, false, false, 0, 0, 98, 101);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_2_kyotu_loop, DirectionManager.MOVIE.bjt012_2_kyotu, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 108:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_green, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0227, Sound.CH.SE1, true, 1f, 36);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1711();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1713();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_50, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_50_loop, DirectionManager.MOVIE.huc008_T_50, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 109:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_green, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0228, Sound.CH.SE1, true, 1f, 36);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE0, true, 1f, 101);
				evt.eventPlaySound(DirectionManager.SOUND.S1022, Sound.CH.VC0, true, 1f, 120);
				evt.eventPlaySound(DirectionManager.SOUND.S0282, Sound.CH.SE0, false, 1f, 132);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1711();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1713();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_100, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_100_loop, DirectionManager.MOVIE.huc008_T_100, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt012_2_kyotu, false, false, false, false, 0, 0, 98, 101);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_2_kyotu_loop, DirectionManager.MOVIE.bjt012_2_kyotu, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 110:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_green, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0228, Sound.CH.SE1, true, 1f, 36);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1711();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1713();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_100, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_100_loop, DirectionManager.MOVIE.huc008_T_100, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 111:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_green, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0229, Sound.CH.SE1, true, 1f, 36);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE0, true, 1f, 101);
				evt.eventPlaySound(DirectionManager.SOUND.S1022, Sound.CH.VC0, true, 1f, 120);
				evt.eventPlaySound(DirectionManager.SOUND.S0282, Sound.CH.SE0, false, 1f, 132);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1711();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1713();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_150, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_150_loop, DirectionManager.MOVIE.huc008_T_150, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt012_2_kyotu, false, false, false, false, 0, 0, 98, 101);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_2_kyotu_loop, DirectionManager.MOVIE.bjt012_2_kyotu, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 112:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_green, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0229, Sound.CH.SE1, true, 1f, 36);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1711();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1713();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_150, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_150_loop, DirectionManager.MOVIE.huc008_T_150, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 113:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_green, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0230, Sound.CH.SE1, true, 1f, 36);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE0, true, 1f, 101);
				evt.eventPlaySound(DirectionManager.SOUND.S1022, Sound.CH.VC0, true, 1f, 120);
				evt.eventPlaySound(DirectionManager.SOUND.S0282, Sound.CH.SE0, false, 1f, 132);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1717();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1719();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_200, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_200_loop, DirectionManager.MOVIE.huc008_T_200, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt012_2_kyotu, false, false, false, false, 0, 0, 98, 101);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_2_kyotu_loop, DirectionManager.MOVIE.bjt012_2_kyotu, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 114:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_green, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0230, Sound.CH.SE1, true, 1f, 36);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1717();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1719();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_200, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_200_loop, DirectionManager.MOVIE.huc008_T_200, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 115:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_green, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0231, Sound.CH.SE1, true, 1f, 36);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE0, true, 1f, 101);
				evt.eventPlaySound(DirectionManager.SOUND.S1022, Sound.CH.VC0, true, 1f, 120);
				evt.eventPlaySound(DirectionManager.SOUND.S0282, Sound.CH.SE0, false, 1f, 132);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1717();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1719();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_300, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_300_loop, DirectionManager.MOVIE.huc008_T_300, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt012_2_kyotu, false, false, false, false, 0, 0, 98, 101);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_2_kyotu_loop, DirectionManager.MOVIE.bjt012_2_kyotu, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 116:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_green, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0231, Sound.CH.SE1, true, 1f, 36);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1717();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1719();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_300, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_300_loop, DirectionManager.MOVIE.huc008_T_300, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 117:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_red, false, false, false, false, 0, 0, 100, 1);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt011_red, DirectionManager.MOVIE.bjt010_red, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt014, DirectionManager.MOVIE.bjt011_red, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0278, Sound.CH.SE0, true, 1f, 78);
				evt.eventPlaySound(DirectionManager.SOUND.S0940, Sound.CH.VC0, true, 1f, 136);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE0, true, 1f, 178);
				evt.eventPlaySound(DirectionManager.SOUND.S1039, Sound.CH.VC1, true, 1f, 178);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 118:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_red, false, false, false, false, 0, 0, 100, 1);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt011_red, DirectionManager.MOVIE.bjt010_red, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt011_loop, DirectionManager.MOVIE.bjt011_red, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0279, Sound.CH.SE0, true, 1f, 78);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 119:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_red, false, false, false, false, 0, 0, 100, 1);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_red, DirectionManager.MOVIE.bjt010_red, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_2_kyotu, DirectionManager.MOVIE.bjt012_red, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_2_kyotu_loop, DirectionManager.MOVIE.bjt012_2_kyotu, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0281, Sound.CH.SE1, true, 1f, 78);
				evt.eventPlaySound(DirectionManager.SOUND.S0274, Sound.CH.SE0, true, 1f, 134);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE1, true, 1f, 153);
				evt.eventPlaySound(DirectionManager.SOUND.S0596, Sound.CH.SE0, true, 1f, 188);
				evt.eventPlaySound(DirectionManager.SOUND.S1022, Sound.CH.VC0, true, 1f, 214);
				evt.eventPlaySound(DirectionManager.SOUND.S0282, Sound.CH.SE1, true, 1f, 224);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 1, 78);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 120:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_red, false, false, false, false, 0, 0, 100, 1);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_red, DirectionManager.MOVIE.bjt010_red, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt013, DirectionManager.MOVIE.bjt012_red, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt013_loop, DirectionManager.MOVIE.bjt013, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0281, Sound.CH.SE1, true, 1f, 78);
				evt.eventPlaySound(DirectionManager.SOUND.S0274, Sound.CH.SE0, true, 1f, 134);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE1, true, 1f, 153);
				evt.eventPlaySound(DirectionManager.SOUND.S0596, Sound.CH.SE0, true, 1f, 188);
				evt.eventPlaySound(DirectionManager.SOUND.S0596, Sound.CH.SE0, true, 1f, 188);
				evt.eventPlaySound(DirectionManager.SOUND.S0174, Sound.CH.BGM, true, 1f, 78);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 121:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_red, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0224, Sound.CH.SE1, true, 1f, 36);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE0, true, 1f, 101);
				evt.eventPlaySound(DirectionManager.SOUND.S1022, Sound.CH.VC0, true, 1f, 120);
				evt.eventPlaySound(DirectionManager.SOUND.S0282, Sound.CH.SE0, false, 1f, 132);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1707();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_10, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_10_loop, DirectionManager.MOVIE.huc008_T_10, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt012_2_kyotu, false, false, false, false, 0, 0, 98, 101);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_2_kyotu_loop, DirectionManager.MOVIE.bjt012_2_kyotu, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 122:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_red, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0224, Sound.CH.SE1, true, 1f, 36);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1707();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_10, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_10_loop, DirectionManager.MOVIE.huc008_T_10, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 123:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_red, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0225, Sound.CH.SE1, true, 1f, 36);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE0, true, 1f, 101);
				evt.eventPlaySound(DirectionManager.SOUND.S1022, Sound.CH.VC0, true, 1f, 120);
				evt.eventPlaySound(DirectionManager.SOUND.S0282, Sound.CH.SE0, false, 1f, 132);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1707();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_20, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_20_loop, DirectionManager.MOVIE.huc008_T_20, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt012_2_kyotu, false, false, false, false, 0, 0, 98, 101);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_2_kyotu_loop, DirectionManager.MOVIE.bjt012_2_kyotu, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 124:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_red, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0225, Sound.CH.SE1, true, 1f, 36);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1707();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_20, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_20_loop, DirectionManager.MOVIE.huc008_T_20, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 125:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_red, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0226, Sound.CH.SE1, true, 1f, 36);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE0, true, 1f, 101);
				evt.eventPlaySound(DirectionManager.SOUND.S1022, Sound.CH.VC0, true, 1f, 120);
				evt.eventPlaySound(DirectionManager.SOUND.S0282, Sound.CH.SE0, false, 1f, 132);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1707();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_30, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_30_loop, DirectionManager.MOVIE.huc008_T_30, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt012_2_kyotu, false, false, false, false, 0, 0, 98, 101);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_2_kyotu_loop, DirectionManager.MOVIE.bjt012_2_kyotu, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 126:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_red, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0226, Sound.CH.SE1, true, 1f, 36);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1707();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_30, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_30_loop, DirectionManager.MOVIE.huc008_T_30, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 127:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_red, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0227, Sound.CH.SE1, true, 1f, 36);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE0, true, 1f, 101);
				evt.eventPlaySound(DirectionManager.SOUND.S1022, Sound.CH.VC0, true, 1f, 120);
				evt.eventPlaySound(DirectionManager.SOUND.S0282, Sound.CH.SE0, false, 1f, 132);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1711();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1713();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_50, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_50_loop, DirectionManager.MOVIE.huc008_T_50, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt012_2_kyotu, false, false, false, false, 0, 0, 98, 101);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_2_kyotu_loop, DirectionManager.MOVIE.bjt012_2_kyotu, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 128:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_red, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0227, Sound.CH.SE1, true, 1f, 36);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1711();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1713();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_50, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_50_loop, DirectionManager.MOVIE.huc008_T_50, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 129:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_red, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0228, Sound.CH.SE1, true, 1f, 36);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE0, true, 1f, 101);
				evt.eventPlaySound(DirectionManager.SOUND.S1022, Sound.CH.VC0, true, 1f, 120);
				evt.eventPlaySound(DirectionManager.SOUND.S0282, Sound.CH.SE0, false, 1f, 132);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1711();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1713();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_100, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_100_loop, DirectionManager.MOVIE.huc008_T_100, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt012_2_kyotu, false, false, false, false, 0, 0, 98, 101);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_2_kyotu_loop, DirectionManager.MOVIE.bjt012_2_kyotu, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 130:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_red, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0228, Sound.CH.SE1, true, 1f, 36);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1711();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1713();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_100, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_100_loop, DirectionManager.MOVIE.huc008_T_100, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 131:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_red, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0229, Sound.CH.SE1, true, 1f, 36);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE0, true, 1f, 101);
				evt.eventPlaySound(DirectionManager.SOUND.S1022, Sound.CH.VC0, true, 1f, 120);
				evt.eventPlaySound(DirectionManager.SOUND.S0282, Sound.CH.SE0, false, 1f, 132);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1711();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1713();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_150, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_150_loop, DirectionManager.MOVIE.huc008_T_150, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt012_2_kyotu, false, false, false, false, 0, 0, 98, 101);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_2_kyotu_loop, DirectionManager.MOVIE.bjt012_2_kyotu, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 132:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_red, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0229, Sound.CH.SE1, true, 1f, 36);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1711();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1713();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_150, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_150_loop, DirectionManager.MOVIE.huc008_T_150, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 133:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_red, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0230, Sound.CH.SE1, true, 1f, 36);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE0, true, 1f, 101);
				evt.eventPlaySound(DirectionManager.SOUND.S1022, Sound.CH.VC0, true, 1f, 120);
				evt.eventPlaySound(DirectionManager.SOUND.S0282, Sound.CH.SE0, false, 1f, 132);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1717();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1719();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_200, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_200_loop, DirectionManager.MOVIE.huc008_T_200, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt012_2_kyotu, false, false, false, false, 0, 0, 98, 101);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_2_kyotu_loop, DirectionManager.MOVIE.bjt012_2_kyotu, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 134:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_red, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0230, Sound.CH.SE1, true, 1f, 36);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1717();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1719();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_200, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_200_loop, DirectionManager.MOVIE.huc008_T_200, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 135:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_red, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0231, Sound.CH.SE1, true, 1f, 36);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE0, true, 1f, 101);
				evt.eventPlaySound(DirectionManager.SOUND.S1022, Sound.CH.VC0, true, 1f, 120);
				evt.eventPlaySound(DirectionManager.SOUND.S0282, Sound.CH.SE0, false, 1f, 132);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1717();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1719();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_300, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_300_loop, DirectionManager.MOVIE.huc008_T_300, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt012_2_kyotu, false, false, false, false, 0, 0, 98, 101);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_2_kyotu_loop, DirectionManager.MOVIE.bjt012_2_kyotu, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 136:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_red, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0231, Sound.CH.SE1, true, 1f, 36);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1717();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1719();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_300, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_300_loop, DirectionManager.MOVIE.huc008_T_300, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 137:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_purple, false, false, false, false, 0, 0, 100, 1);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt011_purple, DirectionManager.MOVIE.bjt010_purple, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt014, DirectionManager.MOVIE.bjt011_purple, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0278, Sound.CH.SE0, true, 1f, 78);
				evt.eventPlaySound(DirectionManager.SOUND.S0940, Sound.CH.VC0, true, 1f, 136);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE0, true, 1f, 178);
				evt.eventPlaySound(DirectionManager.SOUND.S1039, Sound.CH.VC1, true, 1f, 178);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 138:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_purple, false, false, false, false, 0, 0, 100, 1);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt011_purple, DirectionManager.MOVIE.bjt010_purple, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt011_loop, DirectionManager.MOVIE.bjt011_purple, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0279, Sound.CH.SE0, true, 1f, 78);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 139:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_purple, false, false, false, false, 0, 0, 100, 1);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_purple, DirectionManager.MOVIE.bjt010_purple, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_2_kyotu, DirectionManager.MOVIE.bjt012_purple, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_2_kyotu_loop, DirectionManager.MOVIE.bjt012_2_kyotu, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0281, Sound.CH.SE1, true, 1f, 78);
				evt.eventPlaySound(DirectionManager.SOUND.S0274, Sound.CH.SE0, true, 1f, 134);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE1, true, 1f, 153);
				evt.eventPlaySound(DirectionManager.SOUND.S0596, Sound.CH.SE0, true, 1f, 188);
				evt.eventPlaySound(DirectionManager.SOUND.S1022, Sound.CH.VC0, true, 1f, 214);
				evt.eventPlaySound(DirectionManager.SOUND.S0282, Sound.CH.SE1, true, 1f, 224);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 1, 78);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 140:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_purple, false, false, false, false, 0, 0, 100, 1);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_purple, DirectionManager.MOVIE.bjt010_purple, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt013, DirectionManager.MOVIE.bjt012_purple, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt013_loop, DirectionManager.MOVIE.bjt013, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0281, Sound.CH.SE1, true, 1f, 78);
				evt.eventPlaySound(DirectionManager.SOUND.S0274, Sound.CH.SE0, true, 1f, 134);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE1, true, 1f, 153);
				evt.eventPlaySound(DirectionManager.SOUND.S0596, Sound.CH.SE0, true, 1f, 188);
				evt.eventPlaySound(DirectionManager.SOUND.S0596, Sound.CH.SE0, true, 1f, 188);
				evt.eventPlaySound(DirectionManager.SOUND.S0174, Sound.CH.BGM, true, 1f, 78);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 141:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_purple, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0224, Sound.CH.SE1, true, 1f, 36);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE0, true, 1f, 101);
				evt.eventPlaySound(DirectionManager.SOUND.S1022, Sound.CH.VC0, true, 1f, 120);
				evt.eventPlaySound(DirectionManager.SOUND.S0282, Sound.CH.SE0, false, 1f, 132);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1707();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_10, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_10_loop, DirectionManager.MOVIE.huc008_T_10, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt012_2_kyotu, false, false, false, false, 0, 0, 98, 101);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_2_kyotu_loop, DirectionManager.MOVIE.bjt012_2_kyotu, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 142:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_purple, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0224, Sound.CH.SE1, true, 1f, 36);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1707();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_10, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_10_loop, DirectionManager.MOVIE.huc008_T_10, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 143:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_purple, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0225, Sound.CH.SE1, true, 1f, 36);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE0, true, 1f, 101);
				evt.eventPlaySound(DirectionManager.SOUND.S1022, Sound.CH.VC0, true, 1f, 120);
				evt.eventPlaySound(DirectionManager.SOUND.S0282, Sound.CH.SE0, false, 1f, 132);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1707();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_20, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_20_loop, DirectionManager.MOVIE.huc008_T_20, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt012_2_kyotu, false, false, false, false, 0, 0, 98, 101);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_2_kyotu_loop, DirectionManager.MOVIE.bjt012_2_kyotu, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 144:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_purple, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0225, Sound.CH.SE1, true, 1f, 36);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1707();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_20, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_20_loop, DirectionManager.MOVIE.huc008_T_20, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 145:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_purple, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0226, Sound.CH.SE1, true, 1f, 36);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE0, true, 1f, 101);
				evt.eventPlaySound(DirectionManager.SOUND.S1022, Sound.CH.VC0, true, 1f, 120);
				evt.eventPlaySound(DirectionManager.SOUND.S0282, Sound.CH.SE0, false, 1f, 132);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1707();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_30, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_30_loop, DirectionManager.MOVIE.huc008_T_30, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt012_2_kyotu, false, false, false, false, 0, 0, 98, 101);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_2_kyotu_loop, DirectionManager.MOVIE.bjt012_2_kyotu, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 146:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_purple, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0226, Sound.CH.SE1, true, 1f, 36);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1707();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_30, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_30_loop, DirectionManager.MOVIE.huc008_T_30, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 147:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_purple, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0227, Sound.CH.SE1, true, 1f, 36);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE0, true, 1f, 101);
				evt.eventPlaySound(DirectionManager.SOUND.S1022, Sound.CH.VC0, true, 1f, 120);
				evt.eventPlaySound(DirectionManager.SOUND.S0282, Sound.CH.SE0, false, 1f, 132);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1711();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1713();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_50, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_50_loop, DirectionManager.MOVIE.huc008_T_50, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt012_2_kyotu, false, false, false, false, 0, 0, 98, 101);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_2_kyotu_loop, DirectionManager.MOVIE.bjt012_2_kyotu, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 148:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_purple, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0227, Sound.CH.SE1, true, 1f, 36);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1711();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1713();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_50, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_50_loop, DirectionManager.MOVIE.huc008_T_50, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 149:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_purple, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0228, Sound.CH.SE1, true, 1f, 36);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE0, true, 1f, 101);
				evt.eventPlaySound(DirectionManager.SOUND.S1022, Sound.CH.VC0, true, 1f, 120);
				evt.eventPlaySound(DirectionManager.SOUND.S0282, Sound.CH.SE0, false, 1f, 132);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1711();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1713();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_100, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_100_loop, DirectionManager.MOVIE.huc008_T_100, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt012_2_kyotu, false, false, false, false, 0, 0, 98, 101);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_2_kyotu_loop, DirectionManager.MOVIE.bjt012_2_kyotu, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 150:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_purple, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0228, Sound.CH.SE1, true, 1f, 36);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1711();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1713();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_100, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_100_loop, DirectionManager.MOVIE.huc008_T_100, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 151:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_purple, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0229, Sound.CH.SE1, true, 1f, 36);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE0, true, 1f, 101);
				evt.eventPlaySound(DirectionManager.SOUND.S1022, Sound.CH.VC0, true, 1f, 120);
				evt.eventPlaySound(DirectionManager.SOUND.S0282, Sound.CH.SE0, false, 1f, 132);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1711();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1713();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_150, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_150_loop, DirectionManager.MOVIE.huc008_T_150, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt012_2_kyotu, false, false, false, false, 0, 0, 98, 101);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_2_kyotu_loop, DirectionManager.MOVIE.bjt012_2_kyotu, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 152:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_purple, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0229, Sound.CH.SE1, true, 1f, 36);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1711();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1713();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_150, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_150_loop, DirectionManager.MOVIE.huc008_T_150, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 153:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_purple, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0230, Sound.CH.SE1, true, 1f, 36);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE0, true, 1f, 101);
				evt.eventPlaySound(DirectionManager.SOUND.S1022, Sound.CH.VC0, true, 1f, 120);
				evt.eventPlaySound(DirectionManager.SOUND.S0282, Sound.CH.SE0, false, 1f, 132);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1717();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1719();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_200, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_200_loop, DirectionManager.MOVIE.huc008_T_200, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 154:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_purple, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0230, Sound.CH.SE1, true, 1f, 36);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1717();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1719();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_200, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_200_loop, DirectionManager.MOVIE.huc008_T_200, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 155:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_purple, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0231, Sound.CH.SE1, true, 1f, 36);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE0, true, 1f, 101);
				evt.eventPlaySound(DirectionManager.SOUND.S1022, Sound.CH.VC0, true, 1f, 120);
				evt.eventPlaySound(DirectionManager.SOUND.S0282, Sound.CH.SE0, false, 1f, 132);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1717();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1719();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_300, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_300_loop, DirectionManager.MOVIE.huc008_T_300, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt012_2_kyotu, false, false, false, false, 0, 0, 98, 101);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_2_kyotu_loop, DirectionManager.MOVIE.bjt012_2_kyotu, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 156:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_purple, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0231, Sound.CH.SE1, true, 1f, 36);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1717();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1719();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_300, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_300_loop, DirectionManager.MOVIE.huc008_T_300, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 157:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_rainbow, false, false, false, false, 0, 0, 100, 1);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_rainbow, DirectionManager.MOVIE.bjt010_rainbow, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_2_kyotu, DirectionManager.MOVIE.bjt012_rainbow, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_2_kyotu_loop, DirectionManager.MOVIE.bjt012_2_kyotu, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0281, Sound.CH.SE1, true, 1f, 78);
				evt.eventPlaySound(DirectionManager.SOUND.S0274, Sound.CH.SE0, true, 1f, 134);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE1, true, 1f, 153);
				evt.eventPlaySound(DirectionManager.SOUND.S0596, Sound.CH.SE0, true, 1f, 188);
				evt.eventPlaySound(DirectionManager.SOUND.S1022, Sound.CH.VC0, true, 1f, 214);
				evt.eventPlaySound(DirectionManager.SOUND.S0282, Sound.CH.SE1, true, 1f, 224);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 1, 78);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 158:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_rainbow, false, false, false, false, 0, 0, 100, 1);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_rainbow, DirectionManager.MOVIE.bjt010_rainbow, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt013, DirectionManager.MOVIE.bjt012_rainbow, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt013_loop, DirectionManager.MOVIE.bjt013, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0281, Sound.CH.SE1, true, 1f, 78);
				evt.eventPlaySound(DirectionManager.SOUND.S0274, Sound.CH.SE0, true, 1f, 134);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE1, true, 1f, 153);
				evt.eventPlaySound(DirectionManager.SOUND.S0596, Sound.CH.SE0, true, 1f, 188);
				evt.eventPlaySound(DirectionManager.SOUND.S0596, Sound.CH.SE0, true, 1f, 188);
				evt.eventPlaySound(DirectionManager.SOUND.S0174, Sound.CH.BGM, true, 1f, 78);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 159:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_rainbow, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0224, Sound.CH.SE1, true, 1f, 36);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE0, true, 1f, 101);
				evt.eventPlaySound(DirectionManager.SOUND.S1022, Sound.CH.VC0, true, 1f, 120);
				evt.eventPlaySound(DirectionManager.SOUND.S0282, Sound.CH.SE0, false, 1f, 132);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_10, DirectionManager.MOVIE.bjt010_white, false, false, true, false);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1707();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_10, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_10_loop, DirectionManager.MOVIE.huc008_T_10, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt012_2_kyotu, false, false, false, false, 0, 0, 98, 101);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_2_kyotu_loop, DirectionManager.MOVIE.bjt012_2_kyotu, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 160:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_rainbow, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0224, Sound.CH.SE1, true, 1f, 36);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1707();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_10, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_10_loop, DirectionManager.MOVIE.huc008_T_10, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 161:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_rainbow, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0225, Sound.CH.SE1, true, 1f, 36);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE0, true, 1f, 101);
				evt.eventPlaySound(DirectionManager.SOUND.S1022, Sound.CH.VC0, true, 1f, 120);
				evt.eventPlaySound(DirectionManager.SOUND.S0282, Sound.CH.SE0, false, 1f, 132);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1707();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_20, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_20_loop, DirectionManager.MOVIE.huc008_T_20, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt012_2_kyotu, false, false, false, false, 0, 0, 98, 101);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_2_kyotu_loop, DirectionManager.MOVIE.bjt012_2_kyotu, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 162:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_rainbow, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0225, Sound.CH.SE1, true, 1f, 36);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1707();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_20, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_20_loop, DirectionManager.MOVIE.huc008_T_20, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 163:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_rainbow, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0226, Sound.CH.SE1, true, 1f, 36);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE0, true, 1f, 101);
				evt.eventPlaySound(DirectionManager.SOUND.S1022, Sound.CH.VC0, true, 1f, 120);
				evt.eventPlaySound(DirectionManager.SOUND.S0282, Sound.CH.SE0, false, 1f, 132);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1707();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_30, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_30_loop, DirectionManager.MOVIE.huc008_T_30, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt012_2_kyotu, false, false, false, false, 0, 0, 98, 101);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_2_kyotu_loop, DirectionManager.MOVIE.bjt012_2_kyotu, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 164:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_rainbow, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0226, Sound.CH.SE1, true, 1f, 36);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1707();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_30, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_30_loop, DirectionManager.MOVIE.huc008_T_30, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 165:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_rainbow, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0227, Sound.CH.SE1, true, 1f, 36);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE0, true, 1f, 101);
				evt.eventPlaySound(DirectionManager.SOUND.S1022, Sound.CH.VC0, true, 1f, 120);
				evt.eventPlaySound(DirectionManager.SOUND.S0282, Sound.CH.SE0, false, 1f, 132);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1711();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1713();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_50, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_50_loop, DirectionManager.MOVIE.huc008_T_50, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt012_2_kyotu, false, false, false, false, 0, 0, 98, 101);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_2_kyotu_loop, DirectionManager.MOVIE.bjt012_2_kyotu, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 166:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_rainbow, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0227, Sound.CH.SE1, true, 1f, 36);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1711();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1713();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_50, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_50_loop, DirectionManager.MOVIE.huc008_T_50, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 167:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_rainbow, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0228, Sound.CH.SE1, true, 1f, 36);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE0, true, 1f, 101);
				evt.eventPlaySound(DirectionManager.SOUND.S1022, Sound.CH.VC0, true, 1f, 120);
				evt.eventPlaySound(DirectionManager.SOUND.S0282, Sound.CH.SE0, false, 1f, 132);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1711();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1713();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_100, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_100_loop, DirectionManager.MOVIE.huc008_T_100, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt012_2_kyotu, false, false, false, false, 0, 0, 98, 101);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_2_kyotu_loop, DirectionManager.MOVIE.bjt012_2_kyotu, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 168:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_rainbow, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0228, Sound.CH.SE1, true, 1f, 36);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1711();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1713();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_100, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_100_loop, DirectionManager.MOVIE.huc008_T_100, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 169:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_rainbow, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0229, Sound.CH.SE1, true, 1f, 36);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE0, true, 1f, 101);
				evt.eventPlaySound(DirectionManager.SOUND.S1022, Sound.CH.VC0, true, 1f, 120);
				evt.eventPlaySound(DirectionManager.SOUND.S0282, Sound.CH.SE0, false, 1f, 132);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1711();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1713();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_150, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_150_loop, DirectionManager.MOVIE.huc008_T_150, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt012_2_kyotu, false, false, false, false, 0, 0, 98, 101);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_2_kyotu_loop, DirectionManager.MOVIE.bjt012_2_kyotu, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 170:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_rainbow, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0229, Sound.CH.SE1, true, 1f, 36);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1711();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1713();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_150, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_150_loop, DirectionManager.MOVIE.huc008_T_150, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 171:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_rainbow, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0230, Sound.CH.SE1, true, 1f, 36);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE0, true, 1f, 101);
				evt.eventPlaySound(DirectionManager.SOUND.S1022, Sound.CH.VC0, true, 1f, 120);
				evt.eventPlaySound(DirectionManager.SOUND.S0282, Sound.CH.SE0, false, 1f, 132);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1717();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1719();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_300, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_300_loop, DirectionManager.MOVIE.huc008_T_300, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt012_2_kyotu, false, false, false, false, 0, 0, 98, 101);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_2_kyotu_loop, DirectionManager.MOVIE.bjt012_2_kyotu, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 172:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_rainbow, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0230, Sound.CH.SE1, true, 1f, 36);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1717();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1719();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_200, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_200_loop, DirectionManager.MOVIE.huc008_T_200, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 173:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_rainbow, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0231, Sound.CH.SE1, true, 1f, 36);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE0, true, 1f, 101);
				evt.eventPlaySound(DirectionManager.SOUND.S1022, Sound.CH.VC0, true, 1f, 120);
				evt.eventPlaySound(DirectionManager.SOUND.S0282, Sound.CH.SE0, false, 1f, 132);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1717();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1719();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_300, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_300_loop, DirectionManager.MOVIE.huc008_T_300, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt012_2_kyotu, false, false, false, false, 0, 0, 98, 101);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt012_2_kyotu_loop, DirectionManager.MOVIE.bjt012_2_kyotu, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 174:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt010_rainbow, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0277, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0231, Sound.CH.SE1, true, 1f, 36);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1717();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1719();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_300, false, false, true, false, 0, 0, 98, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_300_loop, DirectionManager.MOVIE.huc008_T_300, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 175:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt016, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlaySound(DirectionManager.SOUND.S0286, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				break;
			case 176:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt016_2_nml, false, false, false, false, 0, 0, 100, 1);
				evt.eventPlaySound(DirectionManager.SOUND.S0284, Sound.CH.SE0, true, 1f, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt016_2_nml_loop, DirectionManager.MOVIE.bjt016_2_nml, false, true, false, false);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1666();
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 1, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt016_2_nml2, false, false, true, false, 0, 0, 94, 36);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt016_2_nml2_loop, DirectionManager.MOVIE.bjt016_2_nml2, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt016_2_add, true, false, true, false, 0, 0, 93, 36);
				break;
			case 177:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt018, false, false, false, false, 0, 0, 100, 1);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt018_loop, DirectionManager.MOVIE.bjt018, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0283, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1048, Sound.CH.VC0, true, 1f, 12);
				evt.eventPlaySound(DirectionManager.SOUND.S0548, Sound.CH.SE1, true, 1f, 31);
				evt.eventDisableBefore(mng, 0);
				break;
			case 178:
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt019_nml, false, false, false, false, 0, 0, 100, 1);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt019_nml_loop, DirectionManager.MOVIE.bjt019_nml, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0285, Sound.CH.SE0, true, 1f, 0);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1666();
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 1, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt019_nml2, false, false, true, false, 0, 0, 94, 1);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt019_nml2_loop, DirectionManager.MOVIE.bjt019_nml2, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.bjt019_add, true, false, true, false, 0, 0, 93, 1);
				break;
			case 179:
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt017, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bjt017_loop, DirectionManager.MOVIE.bjt017, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0073, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0608, Sound.CH.SE0, true, 1f, 72);
				evt.eventPlaySound(DirectionManager.SOUND.S0835, Sound.CH.VC0, true, 1f, 75);
				evt.eventPlaySound(DirectionManager.SOUND.S1195, Sound.CH.VC1, true, 1f, 75);
				evt.eventPlaySound(DirectionManager.SOUND.S0274, Sound.CH.SE0, true, 1f, 124);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE1, true, 1f, 138);
				evt.eventPlaySound(DirectionManager.SOUND.S0596, Sound.CH.SE0, true, 1f, 178);
				break;
			}
		}
		if (low == 0)
		{
			switch (mode)
			{
			case 1:
				DirectionLedManager.GD_BTH_gear_stop(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 2:
				DirectionLedManager.GD_BJT_gear_stop(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 3:
				DirectionLedManager.GD_BJT_gear_stop(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 4:
				DirectionLedManager.GD_BJT_gear_stop(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 5:
				DirectionLedManager.GD_BJT_gear_stop(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 6:
				DirectionLedManager.GD_BJT_gear_stop(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 7:
				DirectionLedManager.YK_BJT_HIT_03(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 8:
				DirectionLedManager.GD_BJT_gear_stop(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 9:
				DirectionLedManager.GD_BJT_charge_white_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.OFF_7(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 10:
				DirectionLedManager.GD_BJT_charge_blue_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.OFF_7(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 11:
				DirectionLedManager.GD_BJT_charge_yellow_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.OFF_7(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 12:
				DirectionLedManager.GD_BJT_charge_green_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.OFF_7(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 13:
				DirectionLedManager.GD_BJT_charge_red_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.OFF_7(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 14:
				DirectionLedManager.GD_BJT_charge_purple_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.OFF_7(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 15:
				DirectionLedManager.GD_BJT_charge_rainbow_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.OFF_7(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 16:
				DirectionLedManager.GD_BJT_charge_white_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.OFF_7(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 17:
				DirectionLedManager.GD_BJT_charge_blue_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.OFF_7(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 18:
				DirectionLedManager.GD_BJT_charge_yellow_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.OFF_7(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 19:
				DirectionLedManager.GD_BJT_charge_green_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.OFF_7(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 20:
				DirectionLedManager.GD_BJT_charge_red_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.OFF_7(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 21:
				DirectionLedManager.GD_BJT_charge_purple_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.OFF_7(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 22:
				DirectionLedManager.GD_BJT_charge_rainbow_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.OFF_7(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 23:
				DirectionLedManager.GD_BJT_charge_white_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.OFF_7(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 24:
				DirectionLedManager.GD_BJT_charge_blue_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.OFF_7(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 25:
				DirectionLedManager.GD_BJT_charge_yellow_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.OFF_7(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 26:
				DirectionLedManager.GD_BJT_charge_green_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.OFF_7(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 27:
				DirectionLedManager.GD_BJT_charge_red_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.OFF_7(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 28:
				DirectionLedManager.GD_BJT_charge_purple_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.OFF_7(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 29:
				DirectionLedManager.GD_BJT_charge_rainbow_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.OFF_7(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 37:
				DirectionLedManager.GD_BJT_shoot_white(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 38:
				DirectionLedManager.GD_BJT_shoot_white(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 39:
				DirectionLedManager.GD_BJT_shoot_white(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.YK_BJT_HIT_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 40:
				DirectionLedManager.GD_BJT_shoot_white(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.YK_BJT_HIT_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 41:
				DirectionLedManager.GD_BJT_shoot_white(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 42:
				DirectionLedManager.GD_BJT_shoot_white(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 43:
				DirectionLedManager.GD_BJT_shoot_white(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 44:
				DirectionLedManager.GD_BJT_shoot_white(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 45:
				DirectionLedManager.GD_BJT_shoot_white(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 46:
				DirectionLedManager.GD_BJT_shoot_white(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 47:
				DirectionLedManager.GD_BJT_shoot_white(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 48:
				DirectionLedManager.GD_BJT_shoot_white(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 49:
				DirectionLedManager.GD_BJT_shoot_white(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 50:
				DirectionLedManager.GD_BJT_shoot_white(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 51:
				DirectionLedManager.GD_BJT_shoot_white(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 52:
				DirectionLedManager.GD_BJT_shoot_white(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 53:
				DirectionLedManager.GD_BJT_shoot_white(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 54:
				DirectionLedManager.GD_BJT_shoot_white(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 55:
				DirectionLedManager.GD_BJT_shoot_white(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 56:
				DirectionLedManager.GD_BJT_shoot_white(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 57:
				DirectionLedManager.GD_BJT_shoot_blue(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 58:
				DirectionLedManager.GD_BJT_shoot_blue(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 59:
				DirectionLedManager.GD_BJT_shoot_blue(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.YK_BJT_HIT_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 60:
				DirectionLedManager.GD_BJT_shoot_blue(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.YK_BJT_HIT_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 61:
				DirectionLedManager.GD_BJT_shoot_blue(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 62:
				DirectionLedManager.GD_BJT_shoot_blue(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 63:
				DirectionLedManager.GD_BJT_shoot_blue(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 64:
				DirectionLedManager.GD_BJT_shoot_blue(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 65:
				DirectionLedManager.GD_BJT_shoot_blue(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 66:
				DirectionLedManager.GD_BJT_shoot_blue(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 67:
				DirectionLedManager.GD_BJT_shoot_blue(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 68:
				DirectionLedManager.GD_BJT_shoot_blue(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 69:
				DirectionLedManager.GD_BJT_shoot_blue(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 70:
				DirectionLedManager.GD_BJT_shoot_blue(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 71:
				DirectionLedManager.GD_BJT_shoot_blue(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 72:
				DirectionLedManager.GD_BJT_shoot_blue(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 73:
				DirectionLedManager.GD_BJT_shoot_blue(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 74:
				DirectionLedManager.GD_BJT_shoot_blue(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 75:
				DirectionLedManager.GD_BJT_shoot_blue(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 76:
				DirectionLedManager.GD_BJT_shoot_blue(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 77:
				DirectionLedManager.GD_BJT_shoot_yellow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 78:
				DirectionLedManager.GD_BJT_shoot_yellow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 79:
				DirectionLedManager.GD_BJT_shoot_yellow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.YK_BJT_HIT_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 80:
				DirectionLedManager.GD_BJT_shoot_yellow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.YK_BJT_HIT_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 81:
				DirectionLedManager.GD_BJT_shoot_yellow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 82:
				DirectionLedManager.GD_BJT_shoot_yellow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 83:
				DirectionLedManager.GD_BJT_shoot_yellow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 84:
				DirectionLedManager.GD_BJT_shoot_yellow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 85:
				DirectionLedManager.GD_BJT_shoot_yellow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 86:
				DirectionLedManager.GD_BJT_shoot_yellow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 87:
				DirectionLedManager.GD_BJT_shoot_yellow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 88:
				DirectionLedManager.GD_BJT_shoot_yellow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 89:
				DirectionLedManager.GD_BJT_shoot_yellow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 90:
				DirectionLedManager.GD_BJT_shoot_yellow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 91:
				DirectionLedManager.GD_BJT_shoot_yellow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 92:
				DirectionLedManager.GD_BJT_shoot_yellow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 93:
				DirectionLedManager.GD_BJT_shoot_yellow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 94:
				DirectionLedManager.GD_BJT_shoot_yellow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 95:
				DirectionLedManager.GD_BJT_shoot_yellow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 96:
				DirectionLedManager.GD_BJT_shoot_yellow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 97:
				DirectionLedManager.GD_BJT_shoot_green(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 98:
				DirectionLedManager.GD_BJT_shoot_green(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 99:
				DirectionLedManager.GD_BJT_shoot_green(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.YK_BJT_HIT_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 100:
				DirectionLedManager.GD_BJT_shoot_green(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.YK_BJT_HIT_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 101:
				DirectionLedManager.GD_BJT_shoot_green(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 102:
				DirectionLedManager.GD_BJT_shoot_green(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 103:
				DirectionLedManager.GD_BJT_shoot_green(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 104:
				DirectionLedManager.GD_BJT_shoot_green(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 105:
				DirectionLedManager.GD_BJT_shoot_green(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 106:
				DirectionLedManager.GD_BJT_shoot_green(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 107:
				DirectionLedManager.GD_BJT_shoot_green(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 108:
				DirectionLedManager.GD_BJT_shoot_green(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 109:
				DirectionLedManager.GD_BJT_shoot_green(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 110:
				DirectionLedManager.GD_BJT_shoot_green(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 111:
				DirectionLedManager.GD_BJT_shoot_green(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 112:
				DirectionLedManager.GD_BJT_shoot_green(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 113:
				DirectionLedManager.GD_BJT_shoot_green(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 114:
				DirectionLedManager.GD_BJT_shoot_green(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 115:
				DirectionLedManager.GD_BJT_shoot_green(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 116:
				DirectionLedManager.GD_BJT_shoot_green(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 117:
				DirectionLedManager.GD_BJT_shoot_red(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 118:
				DirectionLedManager.GD_BJT_shoot_red(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 119:
				DirectionLedManager.GD_BJT_shoot_red(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.YK_BJT_HIT_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 120:
				DirectionLedManager.GD_BJT_shoot_red(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.YK_BJT_HIT_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 121:
				DirectionLedManager.GD_BJT_shoot_red(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 122:
				DirectionLedManager.GD_BJT_shoot_red(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 123:
				DirectionLedManager.GD_BJT_shoot_red(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 124:
				DirectionLedManager.GD_BJT_shoot_red(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 125:
				DirectionLedManager.GD_BJT_shoot_red(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 126:
				DirectionLedManager.GD_BJT_shoot_red(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 127:
				DirectionLedManager.GD_BJT_shoot_red(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 128:
				DirectionLedManager.GD_BJT_shoot_red(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 129:
				DirectionLedManager.GD_BJT_shoot_red(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 130:
				DirectionLedManager.GD_BJT_shoot_red(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 131:
				DirectionLedManager.GD_BJT_shoot_red(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 132:
				DirectionLedManager.GD_BJT_shoot_red(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 133:
				DirectionLedManager.GD_BJT_shoot_red(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 134:
				DirectionLedManager.GD_BJT_shoot_red(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 135:
				DirectionLedManager.GD_BJT_shoot_red(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 136:
				DirectionLedManager.GD_BJT_shoot_red(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 137:
				DirectionLedManager.GD_BJT_shoot_purple(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 138:
				DirectionLedManager.GD_BJT_shoot_purple(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 139:
				DirectionLedManager.GD_BJT_shoot_purple(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.YK_BJT_HIT_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 140:
				DirectionLedManager.GD_BJT_shoot_purple(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.YK_BJT_HIT_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 141:
				DirectionLedManager.GD_BJT_shoot_purple(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 142:
				DirectionLedManager.GD_BJT_shoot_purple(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 143:
				DirectionLedManager.GD_BJT_shoot_purple(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 144:
				DirectionLedManager.GD_BJT_shoot_purple(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 145:
				DirectionLedManager.GD_BJT_shoot_purple(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 146:
				DirectionLedManager.GD_BJT_shoot_purple(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 147:
				DirectionLedManager.GD_BJT_shoot_purple(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 148:
				DirectionLedManager.GD_BJT_shoot_purple(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 149:
				DirectionLedManager.GD_BJT_shoot_purple(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 150:
				DirectionLedManager.GD_BJT_shoot_purple(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 151:
				DirectionLedManager.GD_BJT_shoot_purple(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 152:
				DirectionLedManager.GD_BJT_shoot_purple(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 153:
				DirectionLedManager.GD_BJT_shoot_purple(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 154:
				DirectionLedManager.GD_BJT_shoot_purple(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 155:
				DirectionLedManager.GD_BJT_shoot_purple(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 156:
				DirectionLedManager.GD_BJT_shoot_purple(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 157:
				DirectionLedManager.GD_BJT_shoot_rainbow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.YK_BJT_HIT_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 158:
				DirectionLedManager.GD_BJT_shoot_rainbow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.YK_BJT_HIT_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 159:
				DirectionLedManager.GD_BJT_shoot_rainbow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 160:
				DirectionLedManager.GD_BJT_shoot_rainbow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 161:
				DirectionLedManager.GD_BJT_shoot_rainbow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 162:
				DirectionLedManager.GD_BJT_shoot_rainbow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 163:
				DirectionLedManager.GD_BJT_shoot_rainbow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 164:
				DirectionLedManager.GD_BJT_shoot_rainbow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 165:
				DirectionLedManager.GD_BJT_shoot_rainbow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 166:
				DirectionLedManager.GD_BJT_shoot_rainbow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 167:
				DirectionLedManager.GD_BJT_shoot_rainbow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 168:
				DirectionLedManager.GD_BJT_shoot_rainbow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 169:
				DirectionLedManager.GD_BJT_shoot_rainbow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 170:
				DirectionLedManager.GD_BJT_shoot_rainbow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 171:
				DirectionLedManager.GD_BJT_shoot_rainbow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 172:
				DirectionLedManager.GD_BJT_shoot_rainbow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 173:
				DirectionLedManager.GD_BJT_shoot_rainbow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 174:
				DirectionLedManager.GD_BJT_shoot_rainbow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 175:
				DirectionLedManager.GD_BJT_gear_stop(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.OFF_7(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 176:
				DirectionLedManager.BG_GB_end(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_1));
				DirectionLedManager.GD_BJT_gear_stop(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.m_panel_win_GB_end(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 177:
				DirectionLedManager.GD_BJT_gear_stop(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.OFF_7(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 178:
				DirectionLedManager.BG_GB_end(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_1));
				DirectionLedManager.GD_BJT_gear_stop(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.m_panel_win_GB_end(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 179:
				DirectionLedManager.GD_BJT_gear_stop(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.YK_BJT_HIT_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 30:
			case 31:
			case 32:
			case 33:
			case 34:
			case 35:
			case 36:
				break;
			}
		}
	}

	private void setNextLoop(int exe)
	{
		if (MainGameScene.slotGameMan.getBJTChargeNum() <= 0)
		{
			return;
		}
		byte b = 91;
		byte b2 = 0;
		byte b3 = 0;
		int num = MainGameScene.slotGameMan.get_pdt_data(5);
		int num2 = MainGameScene.slotGameMan.get_pkd_data(465);
		int num3 = MainGameScene.slotGameMan.get_pkd_data(466);
		int num4 = MainGameScene.slotGameMan.get_pkd_data(467);
		int num5 = MainGameScene.slotGameMan.get_pkd_data(468);
		int num6 = MainGameScene.slotGameMan.get_pkd_data(567);
		if (num5 == 0)
		{
			int num7 = MainGameScene.slotGameMan.get_pkd_data(476 + num4);
			if (num7 == 1)
			{
				num5 = 1;
			}
		}
		switch (MainGameScene.slotGameMan.get_pkd_data(470 + num4 + 1))
		{
		case 0:
			num = 5;
			if (num5 != 0)
			{
				num = 57;
			}
			break;
		case 1:
			num = 9;
			if (num5 != 0)
			{
				num = 73;
			}
			break;
		case 2:
			num = 13;
			if (num5 != 0)
			{
				num = 89;
			}
			break;
		case 3:
			num = 17;
			if (num5 != 0)
			{
				num = 105;
			}
			break;
		case 4:
			num = 21;
			if (num5 != 0)
			{
				num = 121;
			}
			break;
		case 5:
			num = 25;
			if (num5 != 0)
			{
				num = 137;
			}
			break;
		case 6:
			num = 29;
			if (num5 != 0)
			{
				num = 153;
			}
			break;
		}
		if ((num >= 5 && 8 >= num) || (num >= 31 && 34 >= num))
		{
			b3 = 16;
		}
		else if ((num >= 57 && 72 >= num) || (num >= 169 && 184 >= num))
		{
			b3 = 23;
		}
		else if ((num >= 9 && 12 >= num) || (num >= 35 && 38 >= num))
		{
			b3 = 17;
		}
		else if ((num >= 73 && 88 >= num) || (num >= 185 && 200 >= num))
		{
			b3 = 24;
		}
		else if ((num >= 13 && 16 >= num) || (num >= 39 && 42 >= num))
		{
			b3 = 18;
		}
		else if ((num >= 89 && 104 >= num) || (num >= 201 && 216 >= num))
		{
			b3 = 25;
		}
		else if ((num >= 17 && 20 >= num) || (num >= 43 && 46 >= num))
		{
			b3 = 19;
		}
		else if ((num >= 105 && 120 >= num) || (num >= 217 && 232 >= num))
		{
			b3 = 26;
		}
		else if ((num >= 21 && 24 >= num) || (num >= 47 && 50 >= num))
		{
			b3 = 20;
		}
		else if ((num >= 121 && 136 >= num) || (num >= 233 && 248 >= num))
		{
			b3 = 27;
		}
		else if ((num >= 25 && 28 >= num) || (num >= 51 && 54 >= num))
		{
			b3 = 21;
		}
		else if ((num >= 137 && 152 >= num) || (num >= 249 && 264 >= num))
		{
			b3 = 28;
		}
		else if ((num >= 29 && 30 >= num) || (num >= 55 && 56 >= num))
		{
			b3 = 22;
		}
		else if ((num >= 153 && 168 >= num) || (num >= 265 && 280 >= num))
		{
			b3 = 29;
		}
		evt.eventMakeDirection(m_Dir, b, b2, b3, exe);
	}

	private void makeLestBullets()
	{
		if (low != 0)
		{
			return;
		}
		switch (mode)
		{
		case 9:
		case 10:
		case 11:
		case 12:
		case 13:
		case 14:
		case 15:
		case 16:
		case 17:
		case 18:
		case 19:
		case 20:
		case 21:
		case 22:
		case 23:
		case 24:
		case 25:
		case 26:
		case 27:
		case 28:
		case 29:
		case 30:
		case 31:
		case 32:
		case 33:
		case 34:
		case 35:
		case 36:
		{
			int bJTChargeNum = MainGameScene.slotGameMan.getBJTChargeNum();
			switch (bJTChargeNum - MainGameScene.slotGameMan.get_pkd_data(467))
			{
			case 1:
				evt.eventPlayMovie(DirectionManager.MOVIE.btg_zandan001, false, false, false, true, 128, 110, 99, 0);
				break;
			case 2:
				evt.eventPlayMovie(DirectionManager.MOVIE.btg_zandan002, false, false, false, true, 128, 110, 99, 0);
				break;
			case 3:
				evt.eventPlayMovie(DirectionManager.MOVIE.btg_zandan003, false, false, false, true, 128, 110, 99, 0);
				break;
			case 4:
				evt.eventPlayMovie(DirectionManager.MOVIE.btg_zandan004, false, false, false, true, 128, 110, 99, 0);
				break;
			case 5:
				evt.eventPlayMovie(DirectionManager.MOVIE.btg_zandan005, false, false, false, true, 128, 110, 99, 0);
				break;
			case 6:
				evt.eventPlayMovie(DirectionManager.MOVIE.btg_zandan006, false, false, false, true, 128, 110, 99, 0);
				break;
			}
			break;
		}
		}
	}

	private void lmpChargeNext()
	{
		if (low == 0)
		{
			switch (mode)
			{
			case 16:
			case 17:
			case 18:
			case 19:
			case 20:
			case 21:
			case 22:
			case 23:
			case 24:
			case 25:
			case 26:
			case 27:
			case 28:
			case 29:
			case 30:
			case 31:
			case 32:
			case 33:
			case 34:
			case 35:
			case 36:
				MainGameScene.slotGameMan.lmpBJTCmd(1);
				break;
			}
		}
	}

	private bool isProdStay()
	{
		bool result = false;
		int num = MainGameScene.slotGameMan.m_dirData[9];
		if ((num == 307 && mode == 175) || (num == 309 && mode == 177) || (num == 311 && mode == 179))
		{
			result = true;
		}
		return result;
	}

	public override void end()
	{
		base.end();
	}

	public override void control()
	{
		if (evt.m_Active && low == 0)
		{
			switch (mode)
			{
			case 176:
				if (m_cnt == 0)
				{
					MainGameScene.dirMan.changeStageIntarface(21);
				}
				if (m_cnt == 45)
				{
					MainGameScene.pnlMan.onBe2001_get();
				}
				if (m_cnt == 60)
				{
					MainGameScene.pnlMan.onBe2001_total();
				}
				break;
			case 178:
				if (m_cnt == 0)
				{
					MainGameScene.dirMan.changeStageIntarface(21);
				}
				if (m_cnt == 5)
				{
					MainGameScene.pnlMan.onBe2001_get();
				}
				if (m_cnt == 20)
				{
					MainGameScene.pnlMan.onBe2001_total();
				}
				break;
			}
			m_cnt++;
		}
		base.control();
	}
}
