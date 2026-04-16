public class Direction16KBS : DirectionBase
{
	public Direction16KBS(DirectionManager _mng, byte _high, byte _low, byte _mode, DirectionManager.DIR _dir)
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
				evt.eventPlayMovie(DirectionManager.MOVIE.kbs005_haikei, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kbs005_haikei_loop, DirectionManager.MOVIE.kbs005_haikei, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0123, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kbs001_1, false, false, false, false, 0, 0, 99, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kbs001_1_loop, DirectionManager.MOVIE.kbs001_1, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0569, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0570, Sound.CH.SE0, false, 1f, 51);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, true, 128, 119, 90, 51);
				evt.eventSetCanPush(true, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, true);
				evt.eventPlaySound(DirectionManager.SOUND.S0223, Sound.CH.SE0, true, 1f, 51);
				break;
			case 2:
				evt.eventStopDirectionBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kbs002_1, false, false, false, false, 0, 0, 99, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kbs003_sly, DirectionManager.MOVIE.kbs002_1, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kbs003_sly_loop, DirectionManager.MOVIE.kbs003_sly, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0571, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0572, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S1381, Sound.CH.VC0, true, 1f, 49);
				evt.eventPlaySound(DirectionManager.SOUND.S0124, Sound.CH.BGM, true, 1f, 148);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_ng, true, false, false, true, 128, 119, 90, 0);
				evt.eventSetCanPush(false, 0);
				break;
			case 3:
				evt.eventStopDirectionBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kbs002_2, false, false, false, false, 0, 0, 99, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kbs003_chi, DirectionManager.MOVIE.kbs002_2, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kbs003_chi_loop, DirectionManager.MOVIE.kbs003_chi, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0571, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0572, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S1431, Sound.CH.VC0, true, 1f, 44);
				evt.eventPlaySound(DirectionManager.SOUND.S0124, Sound.CH.BGM, true, 1f, 143);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_ng, true, false, false, true, 128, 119, 90, 0);
				evt.eventSetCanPush(false, 0);
				break;
			case 4:
				evt.eventStopDirectionBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kbs002_3, false, false, false, false, 0, 0, 99, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kbs003_mil, DirectionManager.MOVIE.kbs002_3, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kbs003_mil_loop, DirectionManager.MOVIE.kbs003_mil, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0571, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0572, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S1481, Sound.CH.VC0, true, 1f, 47);
				evt.eventPlaySound(DirectionManager.SOUND.S0124, Sound.CH.BGM, true, 1f, 117);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_ng, true, false, false, true, 128, 119, 90, 0);
				evt.eventSetCanPush(false, 0);
				break;
			case 5:
				evt.eventStopDirectionBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kbs002_4, false, false, false, false, 0, 0, 99, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kbs003_bri, DirectionManager.MOVIE.kbs002_4, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kbs003_bri_loop, DirectionManager.MOVIE.kbs003_bri, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0571, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0572, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S1530, Sound.CH.VC0, true, 1f, 51);
				evt.eventPlaySound(DirectionManager.SOUND.S0124, Sound.CH.BGM, true, 1f, 127);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_ng, true, false, false, true, 128, 119, 90, 0);
				evt.eventSetCanPush(false, 0);
				break;
			case 6:
				evt.eventStopDirectionBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kbs002_1, false, false, false, false, 0, 0, 99, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kbs003_sly, DirectionManager.MOVIE.kbs002_1, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kbs003_sly_loop, DirectionManager.MOVIE.kbs003_sly, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0571, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0572, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S1381, Sound.CH.VC0, true, 1f, 49);
				evt.eventPlaySound(DirectionManager.SOUND.S0124, Sound.CH.BGM, true, 1f, 148);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 90, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 7:
				evt.eventStopDirectionBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kbs002_2, false, false, false, false, 0, 0, 99, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kbs003_chi, DirectionManager.MOVIE.kbs002_2, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kbs003_chi_loop, DirectionManager.MOVIE.kbs003_chi, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0571, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0572, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S1431, Sound.CH.VC0, true, 1f, 44);
				evt.eventPlaySound(DirectionManager.SOUND.S0124, Sound.CH.BGM, true, 1f, 143);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 90, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 8:
				evt.eventStopDirectionBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kbs002_3, false, false, false, false, 0, 0, 99, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kbs003_mil, DirectionManager.MOVIE.kbs002_3, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kbs003_mil_loop, DirectionManager.MOVIE.kbs003_mil, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0571, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0572, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S1481, Sound.CH.VC0, true, 1f, 47);
				evt.eventPlaySound(DirectionManager.SOUND.S0124, Sound.CH.BGM, true, 1f, 117);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 90, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 9:
				evt.eventStopDirectionBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kbs002_4, false, false, false, false, 0, 0, 99, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kbs003_bri, DirectionManager.MOVIE.kbs002_4, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kbs003_bri_loop, DirectionManager.MOVIE.kbs003_bri, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0571, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0572, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S1530, Sound.CH.VC0, true, 1f, 51);
				evt.eventPlaySound(DirectionManager.SOUND.S0124, Sound.CH.BGM, true, 1f, 127);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 90, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 10:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.yjd008, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.yjd008_loop, DirectionManager.MOVIE.yjd008, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0065, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0066, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0205, Sound.CH.BGM, false, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S0556, Sound.CH.SE0, true, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S0358, Sound.CH.SE1, true, 1f, 110);
				break;
			case 11:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kbs005_haikei, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kbs005_haikei_loop, DirectionManager.MOVIE.kbs005_haikei, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0123, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kbs001_2, false, false, false, false, 0, 0, 99, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kbs001_2_loop, DirectionManager.MOVIE.kbs001_2, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0569, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0570, Sound.CH.SE0, false, 1f, 51);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, true, 128, 119, 90, 51);
				evt.eventSetCanPush(true, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, true);
				evt.eventPlaySound(DirectionManager.SOUND.S0223, Sound.CH.SE0, true, 1f, 51);
				break;
			case 12:
				evt.eventStopDirectionBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kbs004_1, false, false, false, false, 0, 0, 99, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kbs003_chi, DirectionManager.MOVIE.kbs004_1, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kbs003_chi_loop, DirectionManager.MOVIE.kbs003_chi, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0571, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0572, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S1431, Sound.CH.VC0, true, 1f, 44);
				evt.eventPlaySound(DirectionManager.SOUND.S0124, Sound.CH.BGM, true, 1f, 143);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_ng, true, false, false, true, 128, 119, 90, 0);
				evt.eventSetCanPush(false, 0);
				break;
			case 13:
				evt.eventStopDirectionBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kbs004_2, false, false, false, false, 0, 0, 99, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kbs003_mil, DirectionManager.MOVIE.kbs004_2, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kbs003_mil_loop, DirectionManager.MOVIE.kbs003_mil, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0571, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0572, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S1481, Sound.CH.VC0, true, 1f, 47);
				evt.eventPlaySound(DirectionManager.SOUND.S0124, Sound.CH.BGM, true, 1f, 117);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_ng, true, false, false, true, 128, 119, 90, 0);
				evt.eventSetCanPush(false, 0);
				break;
			case 14:
				evt.eventStopDirectionBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kbs004_3, false, false, false, false, 0, 0, 99, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kbs003_bri, DirectionManager.MOVIE.kbs004_3, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kbs003_bri_loop, DirectionManager.MOVIE.kbs003_bri, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0571, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0572, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S1530, Sound.CH.VC0, true, 1f, 51);
				evt.eventPlaySound(DirectionManager.SOUND.S0124, Sound.CH.BGM, true, 1f, 127);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_ng, true, false, false, true, 128, 119, 90, 0);
				evt.eventSetCanPush(false, 0);
				break;
			case 15:
				evt.eventStopDirectionBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kbs004_4, false, false, false, false, 0, 0, 99, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kbs003_zap, DirectionManager.MOVIE.kbs004_4, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kbs003_zap_loop, DirectionManager.MOVIE.kbs003_zap, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0571, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0572, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S1581, Sound.CH.VC0, true, 1f, 65);
				evt.eventPlaySound(DirectionManager.SOUND.S0124, Sound.CH.BGM, true, 1f, 124);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_ng, true, false, false, true, 128, 119, 90, 0);
				evt.eventSetCanPush(false, 0);
				break;
			case 16:
				evt.eventStopDirectionBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kbs004_1, false, false, false, false, 0, 0, 99, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kbs003_chi, DirectionManager.MOVIE.kbs004_1, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kbs003_chi_loop, DirectionManager.MOVIE.kbs003_chi, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0571, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0572, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S1431, Sound.CH.VC0, true, 1f, 44);
				evt.eventPlaySound(DirectionManager.SOUND.S0124, Sound.CH.BGM, true, 1f, 143);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 90, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 17:
				evt.eventStopDirectionBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kbs004_2, false, false, false, false, 0, 0, 99, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kbs003_mil, DirectionManager.MOVIE.kbs004_2, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kbs003_mil_loop, DirectionManager.MOVIE.kbs003_mil, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0571, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0572, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S1481, Sound.CH.VC0, true, 1f, 47);
				evt.eventPlaySound(DirectionManager.SOUND.S0124, Sound.CH.BGM, true, 1f, 117);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 90, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 18:
				evt.eventStopDirectionBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kbs004_3, false, false, false, false, 0, 0, 99, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kbs003_bri, DirectionManager.MOVIE.kbs004_3, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kbs003_bri_loop, DirectionManager.MOVIE.kbs003_bri, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0571, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0572, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S1530, Sound.CH.VC0, true, 1f, 51);
				evt.eventPlaySound(DirectionManager.SOUND.S0124, Sound.CH.BGM, true, 1f, 127);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 90, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 19:
				evt.eventStopDirectionBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kbs004_4, false, false, false, false, 0, 0, 99, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kbs003_zap, DirectionManager.MOVIE.kbs004_4, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kbs003_zap_loop, DirectionManager.MOVIE.kbs003_zap, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0571, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0572, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S1581, Sound.CH.VC0, true, 1f, 65);
				evt.eventPlaySound(DirectionManager.SOUND.S0124, Sound.CH.BGM, true, 1f, 124);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 90, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 20:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.yjd008, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.yjd008_loop, DirectionManager.MOVIE.yjd008, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0065, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0066, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0205, Sound.CH.BGM, false, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S0556, Sound.CH.SE0, true, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S0358, Sound.CH.SE1, true, 1f, 110);
				break;
			case 21:
				evt.eventStopDirectionBefore(mng, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kbs005_haikei_loop, DirectionManager.MOVIE.kbs005_haikei, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0123, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kbs001_3, false, false, false, false, 0, 0, 99, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kbs001_3_loop, DirectionManager.MOVIE.kbs001_3, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0569, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0570, Sound.CH.SE0, false, 1f, 51);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, true, 128, 119, 90, 51);
				evt.eventSetCanPush(true, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, true);
				evt.eventPlaySound(DirectionManager.SOUND.S0223, Sound.CH.SE0, true, 1f, 51);
				break;
			case 22:
				evt.eventStopDirectionBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kbs006_2, false, false, false, false, 0, 0, 99, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kbs003_mil, DirectionManager.MOVIE.kbs006_2, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kbs003_mil_loop, DirectionManager.MOVIE.kbs003_mil, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0571, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0572, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S1481, Sound.CH.VC0, true, 1f, 47);
				evt.eventPlaySound(DirectionManager.SOUND.S0124, Sound.CH.BGM, true, 1f, 117);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_ng, true, false, false, true, 128, 119, 90, 0);
				evt.eventSetCanPush(false, 0);
				break;
			case 23:
				evt.eventStopDirectionBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kbs006_4, false, false, false, false, 0, 0, 99, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kbs003_bri, DirectionManager.MOVIE.kbs006_4, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kbs003_bri_loop, DirectionManager.MOVIE.kbs003_bri, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0571, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0572, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S1530, Sound.CH.VC0, true, 1f, 51);
				evt.eventPlaySound(DirectionManager.SOUND.S0124, Sound.CH.BGM, true, 1f, 127);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_ng, true, false, false, true, 128, 119, 90, 0);
				evt.eventSetCanPush(false, 0);
				break;
			case 24:
				evt.eventStopDirectionBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kbs006_2, false, false, false, false, 0, 0, 99, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kbs003_mil, DirectionManager.MOVIE.kbs006_2, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kbs003_mil_loop, DirectionManager.MOVIE.kbs003_mil, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0571, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0572, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S1481, Sound.CH.VC0, true, 1f, 51);
				evt.eventPlaySound(DirectionManager.SOUND.S0124, Sound.CH.BGM, true, 1f, 117);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 90, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 25:
				evt.eventStopDirectionBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kbs006_4, false, false, false, false, 0, 0, 99, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kbs003_bri, DirectionManager.MOVIE.kbs006_4, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kbs003_bri_loop, DirectionManager.MOVIE.kbs003_bri, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0571, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0572, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S1530, Sound.CH.VC0, true, 1f, 65);
				evt.eventPlaySound(DirectionManager.SOUND.S0124, Sound.CH.BGM, true, 1f, 127);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 90, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 26:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.yjd008, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.yjd008_loop, DirectionManager.MOVIE.yjd008, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0065, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0066, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0205, Sound.CH.BGM, false, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S0556, Sound.CH.SE0, true, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S0358, Sound.CH.SE1, true, 1f, 110);
				break;
			case 27:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kbs005_haikei, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kbs005_haikei_loop, DirectionManager.MOVIE.kbs005_haikei, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0123, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kbs001_4, false, false, false, false, 0, 0, 99, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kbs001_4_loop, DirectionManager.MOVIE.kbs001_4, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0569, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0570, Sound.CH.SE0, false, 1f, 51);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, true, 128, 119, 90, 51);
				evt.eventSetCanPush(true, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, true);
				evt.eventPlaySound(DirectionManager.SOUND.S0223, Sound.CH.SE0, true, 1f, 51);
				break;
			case 28:
				evt.eventStopDirectionBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kbs007_2, false, false, false, false, 0, 0, 99, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kbs003_bri, DirectionManager.MOVIE.kbs007_2, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kbs003_bri_loop, DirectionManager.MOVIE.kbs003_bri, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0571, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0572, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S1530, Sound.CH.VC0, true, 1f, 65);
				evt.eventPlaySound(DirectionManager.SOUND.S0124, Sound.CH.BGM, true, 1f, 127);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_ng, true, false, false, true, 128, 119, 90, 0);
				evt.eventSetCanPush(false, 0);
				break;
			case 29:
				evt.eventStopDirectionBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kbs007_4, false, false, false, false, 0, 0, 99, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kbs003_zap, DirectionManager.MOVIE.kbs007_4, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kbs003_zap_loop, DirectionManager.MOVIE.kbs003_zap, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0571, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0572, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S1581, Sound.CH.VC0, true, 1f, 65);
				evt.eventPlaySound(DirectionManager.SOUND.S0124, Sound.CH.BGM, true, 1f, 124);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_ng, true, false, false, true, 128, 119, 90, 0);
				evt.eventSetCanPush(false, 0);
				break;
			case 30:
				evt.eventStopDirectionBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kbs007_2, false, false, false, false, 0, 0, 99, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kbs003_bri, DirectionManager.MOVIE.kbs007_2, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kbs003_bri_loop, DirectionManager.MOVIE.kbs003_bri, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0571, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0572, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S1530, Sound.CH.VC0, true, 1f, 65);
				evt.eventPlaySound(DirectionManager.SOUND.S0124, Sound.CH.BGM, true, 1f, 127);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 90, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 31:
				evt.eventStopDirectionBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kbs007_4, false, false, false, false, 0, 0, 99, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kbs003_zap, DirectionManager.MOVIE.kbs007_4, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kbs003_zap_loop, DirectionManager.MOVIE.kbs003_zap, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0571, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0572, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S1581, Sound.CH.VC0, true, 1f, 65);
				evt.eventPlaySound(DirectionManager.SOUND.S0124, Sound.CH.BGM, true, 1f, 124);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 90, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 32:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.yjd008, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.yjd008_loop, DirectionManager.MOVIE.yjd008, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0065, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0066, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0205, Sound.CH.BGM, false, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S0556, Sound.CH.SE0, true, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S0358, Sound.CH.SE1, true, 1f, 110);
				break;
			case 33:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kbs005_haikei, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kbs005_haikei_loop, DirectionManager.MOVIE.kbs005_haikei, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0123, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kbs001_5, false, false, false, false, 0, 0, 99, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kbs001_5_loop, DirectionManager.MOVIE.kbs001_5, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0569, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0570, Sound.CH.SE0, false, 1f, 51);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, true, 128, 119, 90, 51);
				evt.eventSetCanPush(true, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, true);
				evt.eventPlaySound(DirectionManager.SOUND.S0223, Sound.CH.SE0, true, 1f, 51);
				break;
			case 34:
				evt.eventStopDirectionBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kbs008_4, false, false, false, false, 0, 0, 99, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kbs003_zap, DirectionManager.MOVIE.kbs008_4, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kbs003_zap_loop, DirectionManager.MOVIE.kbs003_zap, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0571, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0572, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S1581, Sound.CH.VC0, true, 1f, 65);
				evt.eventPlaySound(DirectionManager.SOUND.S0124, Sound.CH.BGM, true, 1f, 124);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_ng, true, false, false, true, 128, 119, 90, 0);
				evt.eventSetCanPush(false, 0);
				break;
			case 35:
				evt.eventStopDirectionBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kbs008_4, false, false, false, false, 0, 0, 99, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kbs003_zap, DirectionManager.MOVIE.kbs008_4, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kbs003_zap_loop, DirectionManager.MOVIE.kbs003_zap, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0571, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0572, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S1581, Sound.CH.VC0, true, 1f, 65);
				evt.eventPlaySound(DirectionManager.SOUND.S0124, Sound.CH.BGM, true, 1f, 124);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 90, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 36:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.yjd008, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.yjd008_loop, DirectionManager.MOVIE.yjd008, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0065, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0066, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0205, Sound.CH.BGM, false, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S0556, Sound.CH.SE0, true, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S0358, Sound.CH.SE1, true, 1f, 110);
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
