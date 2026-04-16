public class Direction41ISS : DirectionBase
{
	private int m_cnt;

	public Direction41ISS(DirectionManager _mng, byte _high, byte _low, byte _mode, DirectionManager.DIR _dir)
		: base(_mng, _high, _low, _mode, _dir, DirectionBase.PRIORITY_NORMAL)
	{
	}

	public override void start()
	{
		m_cnt = 0;
		if (low == 0)
		{
			switch (mode)
			{
			case 1:
				evt.eventPlayMovie(DirectionManager.MOVIE.iss002, true, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0258, Sound.CH.SE0, false, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0557, Sound.CH.SE1, false, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1948, Sound.CH.VC0, false, 1f, 4);
				evt.eventKillAnime(DirectionManager.ANIME.standby, 49);
				break;
			case 2:
				evt.eventPlayMovie(DirectionManager.MOVIE.iss002, true, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0258, Sound.CH.SE0, false, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0557, Sound.CH.SE1, false, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1948, Sound.CH.VC0, false, 1f, 4);
				evt.eventKillAnime(DirectionManager.ANIME.standby, 49);
				break;
			}
		}
		if (low == 0)
		{
			switch (mode)
			{
			case 1:
				DirectionLedManager.YK_letsrock(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 2:
				DirectionLedManager.YK_letsrock(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			}
		}
		if (low == 0)
		{
			byte b = mode;
			if (b == 2)
			{
				int num = 45;
				int num2 = MainGameScene.slotGameMan.get_pkd_data(486);
				int num3 = num2 % 10;
				int num4 = num2 / 10 % 10;
				int num5 = num2 / 100 % 10;
				int num6 = num2 / 1000;
				if (num2 > 0)
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
					if (num6 == 0 && num5 == 0 && num4 == 0)
					{
						evt.eventPlayMovie(DirectionManager.MOVIE.bao4210_1_dummy, true, false, false, true, 128, 88, 80, 0 + num);
						evt.eventPlayImage(array[num3], false, true, 121, 88, 79, 10 + num);
						evt.eventPlayMovie(array2[num3], false, true, true, true, 121, 88, 75, 14 + num);
						evt.eventPlayMovie(DirectionManager.MOVIE.bao4210_total_1, false, false, false, true, 128, 72, 71, 10 + num);
						evt.eventAddMovie(DirectionManager.MOVIE.bao4210_total_1_loop, DirectionManager.MOVIE.bao4210_total_1, false, true, false, true);
					}
					else if (num6 == 0 && num5 == 0)
					{
						evt.eventPlayMovie(DirectionManager.MOVIE.bao4210_2_dummy, true, false, false, true, 128, 88, 80, 0 + num);
						evt.eventPlayImage(array[num3], false, true, 155, 88, 79, 10 + num);
						evt.eventPlayImage(array[num4], false, true, 99, 88, 78, 12 + num);
						evt.eventPlayMovie(array2[num3], false, true, true, true, 155, 88, 75, 12 + num);
						evt.eventPlayMovie(array2[num4], false, true, true, true, 99, 88, 74, 17 + num);
						evt.eventPlayMovie(DirectionManager.MOVIE.bao4210_total_2, false, false, false, true, 128, 72, 71, 10 + num);
						evt.eventAddMovie(DirectionManager.MOVIE.bao4210_total_2_loop, DirectionManager.MOVIE.bao4210_total_2, false, true, false, true);
					}
					else if (num6 == 0)
					{
						evt.eventPlayMovie(DirectionManager.MOVIE.bao4210_3_dummy, true, false, false, true, 128, 88, 80, 0 + num);
						evt.eventPlayImage(array[num3], false, true, 181, 88, 79, 10 + num);
						evt.eventPlayImage(array[num4], false, true, 132, 88, 78, 12 + num);
						evt.eventPlayImage(array[num5], false, true, 84, 88, 77, 14 + num);
						evt.eventPlayMovie(array2[num3], false, true, true, true, 181, 88, 75, 14 + num);
						evt.eventPlayMovie(array2[num4], false, true, true, true, 132, 88, 74, 19 + num);
						evt.eventPlayMovie(array2[num5], false, true, true, true, 84, 88, 73, 24 + num);
						evt.eventPlayMovie(DirectionManager.MOVIE.bao4210_total_3, false, false, false, true, 128, 72, 71, 10 + num);
						evt.eventAddMovie(DirectionManager.MOVIE.bao4210_total_3_loop, DirectionManager.MOVIE.bao4210_total_3, false, true, false, true);
					}
					else
					{
						evt.eventPlayMovie(DirectionManager.MOVIE.bao4210_4_dummy, true, false, false, true, 128, 88, 80, 0 + num);
						evt.eventPlayImage(array[num3], false, true, 217, 88, 79, 11 + num);
						evt.eventPlayImage(array[num4], false, true, 168, 88, 78, 12 + num);
						evt.eventPlayImage(array[num5], false, true, 119, 88, 77, 14 + num);
						evt.eventPlayImage(array[num6], false, true, 70, 88, 76, 15 + num);
						evt.eventPlayMovie(array2[num3], false, true, true, true, 217, 88, 75, 12 + num);
						evt.eventPlayMovie(array2[num4], false, true, true, true, 168, 88, 74, 17 + num);
						evt.eventPlayMovie(array2[num5], false, true, true, true, 119, 88, 73, 22 + num);
						evt.eventPlayMovie(array2[num6], false, true, true, true, 70, 88, 72, 27 + num);
						evt.eventPlayMovie(DirectionManager.MOVIE.bao4210_total_4, false, false, false, true, 128, 72, 71, 10 + num);
						evt.eventAddMovie(DirectionManager.MOVIE.bao4210_total_4_loop, DirectionManager.MOVIE.bao4210_total_4, false, true, false, true);
					}
					if (num2 <= 10)
					{
						evt.eventPlaySound(DirectionManager.SOUND.S0224, Sound.CH.SE0, false, 1f, num);
					}
					else if (num2 <= 20)
					{
						evt.eventPlaySound(DirectionManager.SOUND.S0225, Sound.CH.SE0, false, 1f, num);
					}
					else if (num2 <= 30)
					{
						evt.eventPlaySound(DirectionManager.SOUND.S0226, Sound.CH.SE0, false, 1f, num);
					}
					else if (num2 <= 50)
					{
						evt.eventPlaySound(DirectionManager.SOUND.S0227, Sound.CH.SE0, false, 1f, num);
					}
					else if (num2 <= 100)
					{
						evt.eventPlaySound(DirectionManager.SOUND.S0228, Sound.CH.SE0, false, 1f, num);
					}
					else if (num2 <= 150)
					{
						evt.eventPlaySound(DirectionManager.SOUND.S0229, Sound.CH.SE0, false, 1f, num);
					}
					else if (num2 <= 200)
					{
						evt.eventPlaySound(DirectionManager.SOUND.S0230, Sound.CH.SE0, false, 1f, num);
					}
					else
					{
						evt.eventPlaySound(DirectionManager.SOUND.S0231, Sound.CH.SE0, false, 1f, num);
					}
				}
			}
		}
		base.start();
	}

	public override void end()
	{
		int num = SGLG.prod.findLayer(2f);
		if (num >= 0)
		{
			SGLG.prod.Kill(num);
		}
		iss_killMovie(80f);
		iss_killMovie(75f);
		iss_killMovie(74f);
		iss_killMovie(73f);
		iss_killMovie(72f);
		iss_killMovie(71f);
		iss_killImage(79f);
		iss_killImage(78f);
		iss_killImage(77f);
		iss_killImage(76f);
		base.end();
	}

	public override void control()
	{
		if (evt.m_Active)
		{
			if (low == 0)
			{
				byte b = mode;
				if ((b == 1 || b == 2) && m_cnt == 49)
				{
					mng.changeStageIntarface(5);
				}
			}
			m_cnt++;
		}
		base.control();
	}

	public void iss_killMovie(float layer)
	{
		int num = SGLG.prod.findLayer(layer);
		if (num >= 0)
		{
			SGLG.prod.Kill(num);
		}
	}

	public void iss_killImage(float layer)
	{
		int num = SGLG.prodImg.findLayer(layer);
		if (num >= 0)
		{
			SGLG.prodImg.Kill(num);
		}
	}
}
