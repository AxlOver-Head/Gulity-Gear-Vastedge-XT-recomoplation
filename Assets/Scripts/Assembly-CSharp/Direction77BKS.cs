public class Direction77BKS : DirectionBase
{
	private int m_cnt;

	public Direction77BKS(DirectionManager _mng, byte _high, byte _low, byte _mode, DirectionManager.DIR _dir)
		: base(_mng, _high, _low, _mode, _dir, DirectionBase.PRIORITY_NORMAL)
	{
	}

	public override void start()
	{
		m_cnt = 0;
		base.start();
		switch (low)
		{
		case 0:
			switch (mode)
			{
			case 1:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_sol, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_sol_loop, DirectionManager.MOVIE.bks001_sol, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1553, Sound.CH.SE0, true, 1f, 0);
				break;
			case 2:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_sin, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_sin_loop, DirectionManager.MOVIE.bks001_sin, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1553, Sound.CH.SE0, true, 1f, 0);
				break;
			case 3:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_ky, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_ky_loop, DirectionManager.MOVIE.bks001_ky, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1553, Sound.CH.SE0, true, 1f, 0);
				break;
			case 4:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_ano, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_ano_loop, DirectionManager.MOVIE.bks001_ano, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1555, Sound.CH.SE0, true, 1f, 0);
				break;
			case 5:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_gen, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_gen_loop, DirectionManager.MOVIE.bks001_gen, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1554, Sound.CH.SE0, true, 1f, 0);
				break;
			case 6:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_bar, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_bar_loop, DirectionManager.MOVIE.bks001_bar, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1555, Sound.CH.SE0, true, 1f, 0);
				break;
			case 7:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_sly, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_sly_loop, DirectionManager.MOVIE.bks001_sly, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1554, Sound.CH.SE0, true, 1f, 0);
				break;
			case 8:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_chp, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_chp_loop, DirectionManager.MOVIE.bks001_chp, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1554, Sound.CH.SE0, true, 1f, 0);
				break;
			case 9:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_mil, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_mil_loop, DirectionManager.MOVIE.bks001_mil, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1554, Sound.CH.SE0, true, 1f, 0);
				break;
			case 10:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_brg, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_brg_loop, DirectionManager.MOVIE.bks001_brg, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1554, Sound.CH.SE0, true, 1f, 0);
				break;
			case 11:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_zap, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_zap_loop, DirectionManager.MOVIE.bks001_zap, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1554, Sound.CH.SE0, true, 1f, 0);
				break;
			case 12:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_jam, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_jam_loop, DirectionManager.MOVIE.bks001_jam, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1553, Sound.CH.SE0, true, 1f, 0);
				break;
			case 13:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_may, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_may_loop, DirectionManager.MOVIE.bks001_may, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1553, Sound.CH.SE0, true, 1f, 0);
				break;
			case 14:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_jon, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_jon_loop, DirectionManager.MOVIE.bks001_jon, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1553, Sound.CH.SE0, true, 1f, 0);
				break;
			case 15:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_par, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_par_loop, DirectionManager.MOVIE.bks001_par, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1553, Sound.CH.SE0, true, 1f, 0);
				break;
			case 16:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_izu, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_izu_loop, DirectionManager.MOVIE.bks001_izu, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1553, Sound.CH.SE0, true, 1f, 0);
				break;
			case 17:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_syo, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_syo_loop, DirectionManager.MOVIE.bks001_syo, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1553, Sound.CH.SE0, true, 1f, 0);
				break;
			case 18:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_kok, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_kok_loop, DirectionManager.MOVIE.bks001_kok, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1553, Sound.CH.SE0, true, 1f, 0);
				break;
			case 19:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_ti, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_ti_loop, DirectionManager.MOVIE.bks001_ti, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1556, Sound.CH.SE0, true, 1f, 0);
				break;
			case 20:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_dyz, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_dyz_loop, DirectionManager.MOVIE.bks001_dyz, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1556, Sound.CH.SE0, true, 1f, 0);
				break;
			case 21:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_rsol, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_rsol_loop, DirectionManager.MOVIE.bks001_rsol, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1555, Sound.CH.SE0, true, 1f, 0);
				break;
			case 22:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_rsin, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_rsin_loop, DirectionManager.MOVIE.bks001_rsin, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1555, Sound.CH.SE0, true, 1f, 0);
				break;
			case 23:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_rky, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_rky_loop, DirectionManager.MOVIE.bks001_rky, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1555, Sound.CH.SE0, true, 1f, 0);
				break;
			case 93:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_sol, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_sol_loop, DirectionManager.MOVIE.bks001_sol, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1553, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bks003_dou, false, false, false, false, 0, 0, 99, 0);
				break;
			case 94:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_sin, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_sin_loop, DirectionManager.MOVIE.bks001_sin, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1553, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bks003_dou, false, false, false, false, 0, 0, 99, 0);
				break;
			case 95:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_ky, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_ky_loop, DirectionManager.MOVIE.bks001_ky, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1553, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bks003_dou, false, false, false, false, 0, 0, 99, 0);
				break;
			case 96:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_ano, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_ano_loop, DirectionManager.MOVIE.bks001_ano, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1555, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bks003_dou, false, false, false, false, 0, 0, 99, 0);
				break;
			case 97:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_gen, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_gen_loop, DirectionManager.MOVIE.bks001_gen, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1554, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bks003_dou, false, false, false, false, 0, 0, 99, 0);
				break;
			case 98:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_bar, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_bar_loop, DirectionManager.MOVIE.bks001_bar, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1555, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bks003_dou, false, false, false, false, 0, 0, 99, 0);
				break;
			case 99:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_sly, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_sly_loop, DirectionManager.MOVIE.bks001_sly, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1554, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bks003_dou, false, false, false, false, 0, 0, 99, 0);
				break;
			case 100:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_chp, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_chp_loop, DirectionManager.MOVIE.bks001_chp, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1554, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bks003_dou, false, false, false, false, 0, 0, 99, 0);
				break;
			case 101:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_mil, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_mil_loop, DirectionManager.MOVIE.bks001_mil, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1554, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bks003_dou, false, false, false, false, 0, 0, 99, 0);
				break;
			case 102:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_brg, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_brg_loop, DirectionManager.MOVIE.bks001_brg, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1554, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bks003_dou, false, false, false, false, 0, 0, 99, 0);
				break;
			case 103:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_zap, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_zap_loop, DirectionManager.MOVIE.bks001_zap, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1554, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bks003_dou, false, false, false, false, 0, 0, 99, 0);
				break;
			case 104:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_jam, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_jam_loop, DirectionManager.MOVIE.bks001_jam, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1553, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bks003_dou, false, false, false, false, 0, 0, 99, 0);
				break;
			case 105:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_may, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_may_loop, DirectionManager.MOVIE.bks001_may, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1553, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bks003_dou, false, false, false, false, 0, 0, 99, 0);
				break;
			case 106:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_jon, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_jon_loop, DirectionManager.MOVIE.bks001_jon, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1553, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bks003_dou, false, false, false, false, 0, 0, 99, 0);
				break;
			case 107:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_par, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_par_loop, DirectionManager.MOVIE.bks001_par, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1553, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bks003_dou, false, false, false, false, 0, 0, 99, 0);
				break;
			case 108:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_izu, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_izu_loop, DirectionManager.MOVIE.bks001_izu, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1553, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bks003_dou, false, false, false, false, 0, 0, 99, 0);
				break;
			case 109:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_syo, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_syo_loop, DirectionManager.MOVIE.bks001_syo, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1553, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bks003_dou, false, false, false, false, 0, 0, 99, 0);
				break;
			case 110:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_kok, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_kok_loop, DirectionManager.MOVIE.bks001_kok, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1553, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bks003_dou, false, false, false, false, 0, 0, 99, 0);
				break;
			case 111:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_ti, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_ti_loop, DirectionManager.MOVIE.bks001_ti, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1556, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bks003_dou, false, false, false, false, 0, 0, 99, 0);
				break;
			case 112:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_dyz, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_dyz_loop, DirectionManager.MOVIE.bks001_dyz, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1556, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bks003_dou, false, false, false, false, 0, 0, 99, 0);
				break;
			case 113:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_rsol, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_rsol_loop, DirectionManager.MOVIE.bks001_rsol, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1555, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bks003_dou, false, false, false, false, 0, 0, 99, 0);
				break;
			case 114:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_rsin, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_rsin_loop, DirectionManager.MOVIE.bks001_rsin, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1555, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bks003_dou, false, false, false, false, 0, 0, 99, 0);
				break;
			case 115:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_rky, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_rky_loop, DirectionManager.MOVIE.bks001_rky, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1555, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bks003_dou, false, false, false, false, 0, 0, 99, 0);
				break;
			case 116:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_sol, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_sol_loop, DirectionManager.MOVIE.bks001_sol, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1553, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bks003_gin, false, false, false, false, 0, 0, 99, 0);
				break;
			case 117:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_sin, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_sin_loop, DirectionManager.MOVIE.bks001_sin, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1553, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bks003_gin, false, false, false, false, 0, 0, 99, 0);
				break;
			case 118:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_ky, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_ky_loop, DirectionManager.MOVIE.bks001_ky, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1553, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bks003_gin, false, false, false, false, 0, 0, 99, 0);
				break;
			case 119:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_ano, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_ano_loop, DirectionManager.MOVIE.bks001_ano, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1555, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bks003_gin, false, false, false, false, 0, 0, 99, 0);
				break;
			case 120:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_gen, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_gen_loop, DirectionManager.MOVIE.bks001_gen, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1554, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bks003_gin, false, false, false, false, 0, 0, 99, 0);
				break;
			case 121:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_bar, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_bar_loop, DirectionManager.MOVIE.bks001_bar, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1555, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bks003_gin, false, false, false, false, 0, 0, 99, 0);
				break;
			case 122:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_sly, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_sly_loop, DirectionManager.MOVIE.bks001_sly, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1554, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bks003_gin, false, false, false, false, 0, 0, 99, 0);
				break;
			case 123:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_chp, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_chp_loop, DirectionManager.MOVIE.bks001_chp, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1554, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bks003_gin, false, false, false, false, 0, 0, 99, 0);
				break;
			case 124:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_mil, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_mil_loop, DirectionManager.MOVIE.bks001_mil, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1554, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bks003_gin, false, false, false, false, 0, 0, 99, 0);
				break;
			case 125:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_brg, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_brg_loop, DirectionManager.MOVIE.bks001_brg, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1554, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bks003_gin, false, false, false, false, 0, 0, 99, 0);
				break;
			case 126:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_zap, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_zap_loop, DirectionManager.MOVIE.bks001_zap, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1554, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bks003_gin, false, false, false, false, 0, 0, 99, 0);
				break;
			case 127:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_jam, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_jam_loop, DirectionManager.MOVIE.bks001_jam, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1553, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bks003_gin, false, false, false, false, 0, 0, 99, 0);
				break;
			case 128:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_may, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_may_loop, DirectionManager.MOVIE.bks001_may, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1553, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bks003_gin, false, false, false, false, 0, 0, 99, 0);
				break;
			case 129:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_jon, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_jon_loop, DirectionManager.MOVIE.bks001_jon, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1553, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bks003_gin, false, false, false, false, 0, 0, 99, 0);
				break;
			case 130:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_par, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_par_loop, DirectionManager.MOVIE.bks001_par, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1553, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bks003_gin, false, false, false, false, 0, 0, 99, 0);
				break;
			case 131:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_izu, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_izu_loop, DirectionManager.MOVIE.bks001_izu, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1553, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bks003_gin, false, false, false, false, 0, 0, 99, 0);
				break;
			case 132:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_syo, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_syo_loop, DirectionManager.MOVIE.bks001_syo, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1553, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bks003_gin, false, false, false, false, 0, 0, 99, 0);
				break;
			case 133:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_kok, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_kok_loop, DirectionManager.MOVIE.bks001_kok, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1553, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bks003_gin, false, false, false, false, 0, 0, 99, 0);
				break;
			case 134:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_ti, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_ti_loop, DirectionManager.MOVIE.bks001_ti, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1556, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bks003_gin, false, false, false, false, 0, 0, 99, 0);
				break;
			case 135:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_dyz, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_dyz_loop, DirectionManager.MOVIE.bks001_dyz, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1556, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bks003_gin, false, false, false, false, 0, 0, 99, 0);
				break;
			case 136:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_rsol, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_rsol_loop, DirectionManager.MOVIE.bks001_rsol, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1555, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bks003_gin, false, false, false, false, 0, 0, 99, 0);
				break;
			case 137:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_rsin, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_rsin_loop, DirectionManager.MOVIE.bks001_rsin, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1555, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bks003_gin, false, false, false, false, 0, 0, 99, 0);
				break;
			case 138:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_rky, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_rky_loop, DirectionManager.MOVIE.bks001_rky, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1555, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bks003_gin, false, false, false, false, 0, 0, 99, 0);
				break;
			case 139:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_sol, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_sol_loop, DirectionManager.MOVIE.bks001_sol, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1553, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bks003_kin, false, false, false, false, 0, 0, 99, 0);
				break;
			case 140:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_sin, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_sin_loop, DirectionManager.MOVIE.bks001_sin, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1553, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bks003_kin, false, false, false, false, 0, 0, 99, 0);
				break;
			case 141:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_ky, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_ky_loop, DirectionManager.MOVIE.bks001_ky, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1553, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bks003_kin, false, false, false, false, 0, 0, 99, 0);
				break;
			case 142:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_ano, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_ano_loop, DirectionManager.MOVIE.bks001_ano, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1555, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bks003_kin, false, false, false, false, 0, 0, 99, 0);
				break;
			case 143:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_gen, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_gen_loop, DirectionManager.MOVIE.bks001_gen, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1554, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bks003_kin, false, false, false, false, 0, 0, 99, 0);
				break;
			case 144:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_bar, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_bar_loop, DirectionManager.MOVIE.bks001_bar, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1555, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bks003_kin, false, false, false, false, 0, 0, 99, 0);
				break;
			case 145:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_sly, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_sly_loop, DirectionManager.MOVIE.bks001_sly, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1554, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bks003_kin, false, false, false, false, 0, 0, 99, 0);
				break;
			case 146:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_chp, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_chp_loop, DirectionManager.MOVIE.bks001_chp, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1554, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bks003_kin, false, false, false, false, 0, 0, 99, 0);
				break;
			case 147:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_mil, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_mil_loop, DirectionManager.MOVIE.bks001_mil, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1554, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bks003_kin, false, false, false, false, 0, 0, 99, 0);
				break;
			case 148:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_brg, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_brg_loop, DirectionManager.MOVIE.bks001_brg, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1554, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bks003_kin, false, false, false, false, 0, 0, 99, 0);
				break;
			case 149:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_zap, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_zap_loop, DirectionManager.MOVIE.bks001_zap, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1554, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bks003_kin, false, false, false, false, 0, 0, 99, 0);
				break;
			case 150:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_jam, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_jam_loop, DirectionManager.MOVIE.bks001_jam, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1553, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bks003_kin, false, false, false, false, 0, 0, 99, 0);
				break;
			case 151:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_may, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_may_loop, DirectionManager.MOVIE.bks001_may, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1553, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bks003_kin, false, false, false, false, 0, 0, 99, 0);
				break;
			case 152:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_jon, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_jon_loop, DirectionManager.MOVIE.bks001_jon, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1553, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bks003_kin, false, false, false, false, 0, 0, 99, 0);
				break;
			case 153:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_par, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_par_loop, DirectionManager.MOVIE.bks001_par, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1553, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bks003_kin, false, false, false, false, 0, 0, 99, 0);
				break;
			case 154:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_izu, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_izu_loop, DirectionManager.MOVIE.bks001_izu, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1553, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bks003_kin, false, false, false, false, 0, 0, 99, 0);
				break;
			case 155:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_syo, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_syo_loop, DirectionManager.MOVIE.bks001_syo, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1553, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bks003_kin, false, false, false, false, 0, 0, 99, 0);
				break;
			case 156:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_kok, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_kok_loop, DirectionManager.MOVIE.bks001_kok, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1553, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bks003_kin, false, false, false, false, 0, 0, 99, 0);
				break;
			case 157:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_ti, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_ti_loop, DirectionManager.MOVIE.bks001_ti, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1556, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bks003_kin, false, false, false, false, 0, 0, 99, 0);
				break;
			case 158:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_dyz, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_dyz_loop, DirectionManager.MOVIE.bks001_dyz, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1556, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bks003_kin, false, false, false, false, 0, 0, 99, 0);
				break;
			case 159:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_rsol, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_rsol_loop, DirectionManager.MOVIE.bks001_rsol, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1555, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bks003_kin, false, false, false, false, 0, 0, 99, 0);
				break;
			case 160:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_rsin, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_rsin_loop, DirectionManager.MOVIE.bks001_rsin, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1555, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bks003_kin, false, false, false, false, 0, 0, 99, 0);
				break;
			case 161:
				evt.eventPlayMovie(DirectionManager.MOVIE.bks001_rky, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bks001_rky_loop, DirectionManager.MOVIE.bks001_rky, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1555, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bks003_kin, false, false, false, false, 0, 0, 99, 0);
				break;
			case 162:
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bks002_dou, false, false, false, true, 128, 72, 99, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0164, Sound.CH.BGM, true, 1f, 0);
				break;
			case 163:
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bks002_gin, false, false, false, true, 128, 72, 99, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0164, Sound.CH.BGM, true, 1f, 0);
				break;
			case 164:
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bks002_kin, false, false, false, true, 128, 72, 99, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0164, Sound.CH.BGM, true, 1f, 0);
				break;
			}
			break;
		case 1:
			switch (mode)
			{
			case 0:
				evt.eventPlaySound(DirectionManager.SOUND.S0163, Sound.CH.BGM, true, 1f, 0);
				break;
			}
			break;
		case 2:
			switch (mode)
			{
			case 0:
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, true, 128, 119, 90, 23);
				evt.eventSetCanPush(true, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, true);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_add, true, false, true, false, 0, 0, 80, 23);
				evt.eventPlaySound(DirectionManager.SOUND.S0223, Sound.CH.SE0, true, 1f, 23);
				break;
			case 1:
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 90, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 2:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 90, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.yjd003, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.yjd003_loop, DirectionManager.MOVIE.yjd003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0065, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0066, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0556, Sound.CH.SE0, true, 1f, 107);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE1, true, 1f, 127);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 89, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 88, 0);
				break;
			case 10:
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 90, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE1, true, 1f, 6);
				evt.eventPlayMovie(DirectionManager.MOVIE.btd001, false, false, false, true, 128, 72, 89, 11);
				evt.eventAddMovie(DirectionManager.MOVIE.btd001_loop, DirectionManager.MOVIE.btd001, false, true, false, true);
				break;
			case 97:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 90, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_10, false, false, true, false, 0, 0, 85, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_10_loop, DirectionManager.MOVIE.huc008_T_10, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0224, Sound.CH.SE1, true, 1f, 16);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_143();
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 84, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 83, 0);
				break;
			case 98:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 90, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_20, false, false, true, false, 0, 0, 85, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_20_loop, DirectionManager.MOVIE.huc008_T_20, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0225, Sound.CH.SE1, true, 1f, 16);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_143();
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 84, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 83, 0);
				break;
			case 99:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 90, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_30, false, false, true, false, 0, 0, 85, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_30_loop, DirectionManager.MOVIE.huc008_T_30, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0226, Sound.CH.SE1, true, 1f, 16);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_143();
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 84, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 83, 0);
				break;
			case 100:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 90, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_50, false, false, true, false, 0, 0, 85, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_50_loop, DirectionManager.MOVIE.huc008_T_50, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0227, Sound.CH.SE1, true, 1f, 16);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_147();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_149();
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 84, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 83, 0);
				break;
			case 101:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 90, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_100, false, false, true, false, 0, 0, 85, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_100_loop, DirectionManager.MOVIE.huc008_T_100, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0228, Sound.CH.SE1, true, 1f, 16);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_147();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_149();
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 84, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 83, 0);
				break;
			case 102:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 90, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_150, false, false, true, false, 0, 0, 85, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_150_loop, DirectionManager.MOVIE.huc008_T_150, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0229, Sound.CH.SE1, true, 1f, 16);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_147();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_149();
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 84, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 83, 0);
				break;
			case 103:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 90, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_200, false, false, true, false, 0, 0, 85, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_200_loop, DirectionManager.MOVIE.huc008_T_200, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0230, Sound.CH.SE1, true, 1f, 16);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_153();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_155();
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 84, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 83, 0);
				break;
			case 104:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 90, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_300, false, false, true, false, 0, 0, 85, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_300_loop, DirectionManager.MOVIE.huc008_T_300, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0231, Sound.CH.SE1, true, 1f, 16);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_153();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_155();
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 84, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 83, 0);
				break;
			case 105:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 90, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0065, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_50, false, false, true, false, 0, 0, 85, 72);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_50_loop, DirectionManager.MOVIE.huc008_T_50, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 72);
				evt.eventPlaySound(DirectionManager.SOUND.S0227, Sound.CH.SE1, true, 1f, 88);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 84, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 83, 0);
				break;
			case 106:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 90, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0065, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_100, false, false, true, false, 0, 0, 85, 72);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_100_loop, DirectionManager.MOVIE.huc008_T_100, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 72);
				evt.eventPlaySound(DirectionManager.SOUND.S0228, Sound.CH.SE1, true, 1f, 88);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 84, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 83, 0);
				break;
			case 107:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 90, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0065, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_150, false, false, true, false, 0, 0, 85, 72);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_150_loop, DirectionManager.MOVIE.huc008_T_150, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 72);
				evt.eventPlaySound(DirectionManager.SOUND.S0229, Sound.CH.SE1, true, 1f, 88);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 84, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 83, 0);
				break;
			case 108:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 90, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0065, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_200, false, false, true, false, 0, 0, 85, 72);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_200_loop, DirectionManager.MOVIE.huc008_T_200, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 72);
				evt.eventPlaySound(DirectionManager.SOUND.S0230, Sound.CH.SE1, true, 1f, 88);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 84, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 83, 0);
				break;
			case 109:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 90, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0065, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_300, false, false, true, false, 0, 0, 85, 72);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_300_loop, DirectionManager.MOVIE.huc008_T_300, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 72);
				evt.eventPlaySound(DirectionManager.SOUND.S0231, Sound.CH.SE1, true, 1f, 88);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 84, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 83, 0);
				break;
			}
			break;
		}
		if (low == 0)
		{
			switch (mode)
			{
			case 1:
				DirectionLedManager.YK_KBS_blue(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 2:
				DirectionLedManager.YK_KBS_blue(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 3:
				DirectionLedManager.YK_KBS_blue(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 4:
				DirectionLedManager.YK_KBS_red(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 5:
				DirectionLedManager.YK_KBS_green(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 6:
				DirectionLedManager.YK_KBS_red(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 7:
				DirectionLedManager.YK_KBS_green(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 8:
				DirectionLedManager.YK_KBS_green(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 9:
				DirectionLedManager.YK_KBS_green(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 10:
				DirectionLedManager.YK_KBS_green(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 11:
				DirectionLedManager.YK_KBS_green(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 12:
				DirectionLedManager.YK_KBS_blue(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 13:
				DirectionLedManager.YK_KBS_blue(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 14:
				DirectionLedManager.YK_KBS_blue(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 15:
				DirectionLedManager.YK_KBS_blue(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 16:
				DirectionLedManager.YK_KBS_blue(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 17:
				DirectionLedManager.YK_KBS_blue(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 18:
				DirectionLedManager.YK_KBS_blue(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 19:
				DirectionLedManager.YK_KBS_gold(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 20:
				DirectionLedManager.YK_KBS_gold(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 21:
				DirectionLedManager.YK_KBS_red(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 22:
				DirectionLedManager.YK_KBS_red(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 23:
				DirectionLedManager.YK_KBS_red(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 93:
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 94:
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 95:
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 96:
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 97:
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 98:
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 99:
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 100:
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 101:
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 102:
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 103:
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 104:
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 105:
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 106:
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 107:
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 108:
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 109:
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 110:
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 111:
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 112:
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 113:
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 114:
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 115:
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 116:
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 117:
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 118:
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 119:
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 120:
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 121:
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 122:
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 123:
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 124:
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 125:
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 126:
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 127:
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 128:
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 129:
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 130:
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 131:
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 132:
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 133:
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 134:
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 135:
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 136:
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 137:
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 138:
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 139:
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 140:
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 141:
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 142:
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 143:
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 144:
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 145:
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 146:
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 147:
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 148:
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 149:
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 150:
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 151:
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 152:
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 153:
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 154:
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 155:
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 156:
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 157:
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 158:
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 159:
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 160:
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 161:
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 162:
				DirectionLedManager.OFF_7(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 163:
				DirectionLedManager.OFF_7(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 164:
				DirectionLedManager.OFF_7(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 165:
				break;
			case 166:
				break;
			case 167:
				break;
			case 168:
				break;
			case 169:
				break;
			case 170:
				break;
			case 171:
				break;
			case 172:
				break;
			case 173:
				break;
			case 174:
				break;
			case 175:
				break;
			case 176:
				break;
			case 177:
				break;
			case 178:
				break;
			case 179:
				break;
			case 180:
				break;
			case 181:
				break;
			case 182:
				break;
			case 183:
				break;
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
			case 37:
			case 38:
			case 39:
			case 40:
			case 41:
			case 42:
			case 43:
			case 44:
			case 45:
			case 46:
			case 47:
			case 48:
			case 49:
			case 50:
			case 51:
			case 52:
			case 53:
			case 54:
			case 55:
			case 56:
			case 57:
			case 58:
			case 59:
			case 60:
			case 61:
			case 62:
			case 63:
			case 64:
			case 65:
			case 66:
			case 67:
			case 68:
			case 69:
			case 70:
			case 71:
			case 72:
			case 73:
			case 74:
			case 75:
			case 76:
			case 77:
			case 78:
			case 79:
			case 80:
			case 81:
			case 82:
			case 83:
			case 84:
			case 85:
			case 86:
			case 87:
			case 88:
			case 89:
			case 90:
			case 91:
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
		if (evt.m_Active && low == 0)
		{
			if (mode == 162 || mode == 163 || mode == 164)
			{
				if (m_cnt == 0)
				{
					MainGameScene.dirMan.changeStageIntarface(21);
				}
				if (m_cnt == 24)
				{
					MainGameScene.pnlMan.onBe2001_get();
				}
				if (m_cnt == 44)
				{
					MainGameScene.pnlMan.onBe2001_total();
				}
			}
			m_cnt++;
		}
		base.control();
	}
}
