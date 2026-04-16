public class Direction14MAP : DirectionBase
{
	private static int[,] destinationPos = new int[5, 2]
	{
		{ 45, 42 },
		{ 131, 111 },
		{ 127, 28 },
		{ 194, 38 },
		{ 210, 99 }
	};

	private static int[,] solPos = new int[14, 2]
	{
		{ 111, 28 },
		{ 48, 98 },
		{ 90, 66 },
		{ 44, 34 },
		{ 128, 72 },
		{ 131, 103 },
		{ 128, 72 },
		{ 162, 62 },
		{ 126, 20 },
		{ 128, 72 },
		{ 194, 30 },
		{ 128, 72 },
		{ 209, 91 },
		{ 128, 72 }
	};

	private static int[] solFrame = new int[13]
	{
		6, 14, 14, 3, 14, 3, 14, 14, 3, 14,
		3, 14, 3
	};

	private static int[,] destinationID = new int[52, 5]
	{
		{ 4, 5, 9, 3, 8 },
		{ 4, 5, 9, 6, 7 },
		{ 4, 9, 5, 3, 8 },
		{ 4, 9, 5, 6, 7 },
		{ 4, 5, 3, 8, 6 },
		{ 4, 5, 3, 8, 7 },
		{ 4, 9, 3, 8, 6 },
		{ 4, 9, 3, 8, 7 },
		{ 4, 3, 8, 6, 7 },
		{ 5, 9, 3, 8, 6 },
		{ 5, 9, 3, 8, 7 },
		{ 5, 3, 8, 6, 7 },
		{ 2, 5, 9, 3, 8 },
		{ 2, 5, 9, 6, 7 },
		{ 2, 9, 5, 3, 8 },
		{ 2, 9, 5, 6, 7 },
		{ 2, 5, 3, 8, 6 },
		{ 2, 5, 3, 8, 7 },
		{ 2, 9, 3, 8, 6 },
		{ 2, 9, 3, 8, 7 },
		{ 2, 3, 8, 6, 7 },
		{ 5, 9, 3, 8, 6 },
		{ 5, 9, 3, 8, 7 },
		{ 5, 3, 8, 6, 7 },
		{ 2, 4, 9, 3, 8 },
		{ 2, 4, 9, 6, 7 },
		{ 2, 4, 3, 8, 6 },
		{ 2, 4, 3, 8, 7 },
		{ 2, 9, 3, 8, 6 },
		{ 2, 9, 3, 8, 7 },
		{ 2, 3, 8, 6, 7 },
		{ 4, 9, 3, 8, 6 },
		{ 4, 9, 3, 8, 7 },
		{ 4, 3, 8, 6, 7 },
		{ 9, 3, 8, 6, 7 },
		{ 3, 8, 3, 8, 6 },
		{ 3, 8, 3, 8, 7 },
		{ 3, 3, 3, 3, 3 },
		{ 8, 8, 8, 8, 8 },
		{ 6, 6, 6, 6, 6 },
		{ 7, 7, 7, 7, 7 },
		{ 9, 3, 8, 6, 7 },
		{ 3, 8, 3, 8, 6 },
		{ 3, 8, 3, 8, 7 },
		{ 1, 4, 5, 3, 8 },
		{ 1, 5, 9, 3, 8 },
		{ 4, 5, 1, 3, 8 },
		{ 1, 5, 9, 3, 8 },
		{ 1, 9, 5, 3, 8 },
		{ 9, 5, 1, 3, 8 },
		{ 1, 9, 3, 8, 6 },
		{ 1, 9, 3, 8, 7 }
	};

	private static bool isCat = false;

	private static int destination = 0;

	private static int bg = 0;

	public Direction14MAP(DirectionManager _mng, byte _high, byte _low, byte _mode, DirectionManager.DIR _dir)
		: base(_mng, _high, _low, _mode, _dir, DirectionBase.PRIORITY_NORMAL)
	{
	}

	public void setStartChara()
	{
		if (mode == 133 || mode == 138 || mode == 141)
		{
			evt.eventPlayMovie(DirectionManager.MOVIE.kmp_cat_stop, false, true, false, true, solPos[1, 0], solPos[1, 1], 100, 0);
			evt.eventMovieSlide(100f, solPos[0, 0], solPos[0, 1], solPos[1, 0], solPos[1, 1], solFrame[0], 13);
			evt.eventMovieChangeScale(100f, 2f, 2f, 2f, 2f, 0, 0);
			evt.eventMovieChangeScale(100f, 2f, 2f, 1f, 1f, solFrame[0], 13);
		}
		else
		{
			evt.eventPlayMovie(DirectionManager.MOVIE.kmp_sol_r_s, false, true, false, true, solPos[1, 0], solPos[1, 1], 100, 0);
			evt.eventMovieSlide(100f, solPos[0, 0], solPos[0, 1], solPos[1, 0], solPos[1, 1], solFrame[0], 13);
			evt.eventMovieChangeScale(100f, 2f, 2f, 2f, 2f, 0, 0);
			evt.eventMovieChangeScale(100f, 2f, 2f, 1f, 1f, solFrame[0], 13);
		}
	}

	private void setStartBG()
	{
		switch (mode)
		{
		case 111:
		case 114:
		case 118:
		case 121:
		case 124:
		case 127:
		case 130:
		case 133:
		case 138:
		case 141:
			evt.eventPlayMovie(DirectionManager.MOVIE.kmp_start_r, true, false, false, false, 0, 0, 90, 0);
			evt.eventPlayImage(DirectionManager.IMAGE.kmp_bg_r, false, true, 0, 0, 115, 0);
			bg = 1;
			break;
		default:
			evt.eventPlayMovie(DirectionManager.MOVIE.kmp_start_n, true, false, false, false, 0, 0, 90, 0);
			evt.eventPlayImage(DirectionManager.IMAGE.kmp_bg_n, false, true, 0, 0, 115, 0);
			bg = 0;
			break;
		}
		evt.eventImageChangeScale(115f, 3f, 3f, 1f, 1f, solFrame[0], 13);
		evt.eventImageSlide(115f, 256f, 144f, 128f, 72f, solFrame[0], 13);
	}

	private void setStartDest()
	{
		int num = -1;
		switch (mode)
		{
		case 1:
			num = 0;
			break;
		case 9:
			num = 1;
			break;
		case 14:
			num = 2;
			break;
		case 17:
			num = 3;
			break;
		case 20:
			num = 4;
			break;
		case 23:
			num = 5;
			break;
		case 26:
			num = 6;
			break;
		case 29:
			num = 7;
			break;
		case 32:
			num = 8;
			break;
		case 35:
			num = 9;
			break;
		case 38:
			num = 10;
			break;
		case 41:
			num = 11;
			break;
		case 44:
			num = 12;
			break;
		case 48:
			num = 13;
			break;
		case 51:
			num = 14;
			break;
		case 54:
			num = 15;
			break;
		case 57:
			num = 16;
			break;
		case 60:
			num = 17;
			break;
		case 63:
			num = 18;
			break;
		case 66:
			num = 19;
			break;
		case 69:
			num = 20;
			break;
		case 72:
			num = 21;
			break;
		case 75:
			num = 22;
			break;
		case 78:
			num = 23;
			break;
		case 81:
			num = 24;
			break;
		case 84:
			num = 25;
			break;
		case 87:
			num = 26;
			break;
		case 90:
			num = 27;
			break;
		case 93:
			num = 28;
			break;
		case 96:
			num = 29;
			break;
		case 99:
			num = 30;
			break;
		case 102:
			num = 31;
			break;
		case 105:
			num = 32;
			break;
		case 108:
			num = 33;
			break;
		case 111:
			num = 34;
			break;
		case 114:
			num = 35;
			break;
		case 118:
			num = 36;
			break;
		case 121:
			num = 37;
			break;
		case 124:
			num = 38;
			break;
		case 127:
			num = 39;
			break;
		case 130:
			num = 40;
			break;
		case 133:
			num = 41;
			break;
		case 138:
			num = 42;
			break;
		case 141:
			num = 43;
			break;
		case 144:
			num = 44;
			break;
		case 148:
			num = 45;
			break;
		case 151:
			num = 46;
			break;
		case 154:
			num = 47;
			break;
		case 157:
			num = 48;
			break;
		case 160:
			num = 49;
			break;
		case 163:
			num = 50;
			break;
		case 166:
			num = 51;
			break;
		}
		if (num >= 0 && num < destinationID.Length)
		{
			destination = num;
			for (int i = 0; i < 5; i++)
			{
				evt.eventPlayImage((DirectionManager.IMAGE)(2 + destinationID[num, i] - 1), false, true, destinationPos[i, 0] * 3, destinationPos[i, 1] * 3, 105 + i, 0);
				evt.eventImageChangeScale(105 + i, 3f, 3f, 3f, 3f, 0, 0);
				evt.eventImageChangeScale(105 + i, 3f, 3f, 1f, 1f, solFrame[0], 13);
				evt.eventImageSlide(105 + i, destinationPos[i, 0] * 3, destinationPos[i, 1] * 3, destinationPos[i, 0], destinationPos[i, 1], solFrame[0], 13);
			}
		}
	}

	private void setStartSound()
	{
		evt.eventPlaySound(DirectionManager.SOUND.S0111, Sound.CH.BGM, true, 1f, 0);
		if (mode == 111 || mode == 114 || mode == 118 || mode == 121)
		{
			evt.eventPlaySound(DirectionManager.SOUND.S0574, Sound.CH.SE0, true, 1f, 0);
			evt.eventPlaySound(DirectionManager.SOUND.S0575, Sound.CH.SE0, true, 1f, 0);
		}
		else if (mode == 124 || mode == 127 || mode == 130)
		{
			evt.eventPlaySound(DirectionManager.SOUND.S0574, Sound.CH.SE0, true, 1f, 0);
			evt.eventPlaySound(DirectionManager.SOUND.S0575, Sound.CH.SE0, true, 1f, 0);
			evt.eventPlaySound(DirectionManager.SOUND.S0567, Sound.CH.SE0, true, 1f, 19);
		}
		else if (mode == 133 || mode == 138 || mode == 141)
		{
			evt.eventPlaySound(DirectionManager.SOUND.S0574, Sound.CH.SE0, true, 1f, 0);
			evt.eventPlaySound(DirectionManager.SOUND.S0575, Sound.CH.SE0, true, 1f, 0);
			evt.eventPlaySound(DirectionManager.SOUND.S0215, Sound.CH.SE0, true, 1f, 19);
		}
		else
		{
			evt.eventPlaySound(DirectionManager.SOUND.S0574, Sound.CH.SE0, true, 1f, 0);
		}
	}

	private void killCharaMovie()
	{
		evt.eventKillMovie(DirectionManager.MOVIE.kmp_cat_stop, 0);
		evt.eventKillMovie(DirectionManager.MOVIE.kmp_sol_r, 0);
		evt.eventKillMovie(DirectionManager.MOVIE.kmp_sol_r_s, 0);
		evt.eventKillMovie(DirectionManager.MOVIE.kmp_sol_l, 0);
		evt.eventKillMovie(DirectionManager.MOVIE.kmp_sol_l_s, 0);
	}

	public void setKeizoku1Chara()
	{
		evt.eventImageChangeScale(115f, 1f, 1f, 1f, 1f, 0, 0);
		evt.eventImageSlide(115f, 128f, 72f, 128f, 72f, 0, 0);
		killCharaMovie();
		for (int i = 0; i < 5; i++)
		{
			evt.eventImageChangeScale(105 + i, 1f, 1f, 1f, 1f, 0, 0);
			evt.eventImageSlide(105 + i, destinationPos[i, 0], destinationPos[i, 1], destinationPos[i, 0], destinationPos[i, 1], 0, 0);
		}
		if (isCat)
		{
			evt.eventPlayMovie(DirectionManager.MOVIE.kmp_cat_stop, false, true, false, true, solPos[1, 0], solPos[1, 1], 100, 0);
			evt.eventMovieSlide(100f, solPos[1, 0], solPos[1, 1], solPos[2, 0], solPos[2, 1], solFrame[1], 0);
		}
		else
		{
			evt.eventPlayMovie(DirectionManager.MOVIE.kmp_sol_r, false, true, false, true, solPos[1, 0], solPos[1, 1], 100, 0);
			evt.eventMovieSlide(100f, solPos[1, 0], solPos[1, 1], solPos[2, 0], solPos[2, 1], solFrame[1], 0);
			evt.eventPlayMovie(DirectionManager.MOVIE.kmp_sol_r_s, false, true, false, true, solPos[2, 0], solPos[2, 1], 100, solFrame[1]);
		}
	}

	public void setKeizoku2Chara()
	{
		evt.eventImageChangeScale(115f, 1f, 1f, 1f, 1f, 0, 0);
		evt.eventImageSlide(115f, 128f, 72f, 128f, 72f, 0, 0);
		killCharaMovie();
		for (int i = 0; i < 5; i++)
		{
			evt.eventImageChangeScale(105 + i, 1f, 1f, 1f, 1f, 0, 0);
			evt.eventImageSlide(105 + i, destinationPos[i, 0], destinationPos[i, 1], destinationPos[i, 0], destinationPos[i, 1], 0, 0);
		}
		if (isCat)
		{
			evt.eventPlayMovie(DirectionManager.MOVIE.kmp_cat_stop, false, true, false, true, solPos[2, 0], solPos[2, 1], 100, 0);
			evt.eventMovieSlide(100f, solPos[2, 0], solPos[2, 1], solPos[7, 0], solPos[7, 1], solFrame[6], 0);
		}
		else
		{
			evt.eventPlayMovie(DirectionManager.MOVIE.kmp_sol_r, false, true, false, true, solPos[2, 0], solPos[2, 1], 100, 0);
			evt.eventMovieSlide(100f, solPos[2, 0], solPos[2, 1], solPos[7, 0], solPos[7, 1], solFrame[6], 0);
			evt.eventPlayMovie(DirectionManager.MOVIE.kmp_sol_r_s, false, true, false, true, solPos[7, 0], solPos[7, 1], 100, solFrame[6]);
		}
	}

	public void setDest(int kind, int pos)
	{
		evt.eventImageChangeScale(115f, 1f, 1f, 1f, 1f, 0, 0);
		evt.eventImageSlide(115f, 128f, 72f, 128f, 72f, 0, 0);
		killCharaMovie();
		for (int i = 0; i < 5; i++)
		{
			evt.eventImageChangeScale(105 + i, 1f, 1f, 1f, 1f, 0, 0);
			evt.eventImageSlide(105 + i, destinationPos[i, 0], destinationPos[i, 1], destinationPos[i, 0], destinationPos[i, 1], 0, 0);
		}
		int num = -1;
		bool flag = false;
		bool flag2 = false;
		switch (pos)
		{
		case 1:
			num = 3;
			break;
		case 2:
			num = 5;
			break;
		case 3:
			num = 8;
			break;
		case 4:
			num = 10;
			break;
		case 5:
			num = 12;
			break;
		}
		if (num < 0 || num >= solPos.Length)
		{
			return;
		}
		if (pos == 1 || pos == 3)
		{
			flag = true;
		}
		if (pos >= 3)
		{
			flag2 = true;
		}
		int num2 = ((!flag2) ? 2 : 7);
		if (isCat)
		{
			evt.eventPlayMovie(DirectionManager.MOVIE.kmp_cat_stop, false, true, false, true, solPos[num2, 0], solPos[num2, 1], 100, 0);
			evt.eventMovieSlide(100f, solPos[num2, 0], solPos[num2, 1], solPos[num, 0], solPos[num, 1], solFrame[num - 1], 0);
		}
		else
		{
			evt.eventPlayMovie((!flag) ? DirectionManager.MOVIE.kmp_sol_r : DirectionManager.MOVIE.kmp_sol_l, false, true, false, true, solPos[num2, 0], solPos[num2, 1], 100, 0);
			evt.eventMovieSlide(100f, solPos[num2, 0], solPos[num2, 1], solPos[num, 0], solPos[num, 1], solFrame[num - 1], 0);
			evt.eventPlayMovie((!flag) ? DirectionManager.MOVIE.kmp_sol_r_s : DirectionManager.MOVIE.kmp_sol_l_s, false, true, false, true, solPos[num, 0], solPos[num, 1], 100, solFrame[num - 1]);
		}
		if (kind != 1)
		{
			if (isCat)
			{
				evt.eventPlayMovie(DirectionManager.MOVIE.kmp_cat_f, true, false, false, true, solPos[num, 0], solPos[num, 1], 100, 40);
				evt.eventMovieSlide(100f, solPos[num, 0], solPos[num, 1], solPos[num + 1, 0], solPos[num + 1, 1], solFrame[num], 40);
				evt.eventMovieChangeScale(100f, 1f, 1f, 2.75f, 2.75f, solFrame[num], 40);
			}
			else
			{
				evt.eventPlayMovie((!flag) ? DirectionManager.MOVIE.kmp_sol_r_f : DirectionManager.MOVIE.kmp_sol_l_f, true, false, false, true, solPos[num, 0], solPos[num, 1], 100, 40);
				evt.eventMovieSlide(100f, solPos[num, 0], solPos[num, 1], solPos[num + 1, 0], solPos[num + 1, 1], solFrame[num], 40);
				evt.eventMovieChangeScale(100f, 1f, 1f, 2.75f, 2.75f, solFrame[num], 40);
			}
			evt.eventPlayMovie((DirectionManager.MOVIE)(736 + kind - 2), true, false, true, true, destinationPos[pos - 1, 0], destinationPos[pos - 1, 1], 103, solFrame[num - 1]);
			float num3 = destinationPos[pos - 1, 0];
			float num4 = destinationPos[pos - 1, 1];
			for (int j = 0; j < 5; j++)
			{
				evt.eventImageSlide(105 + j, destinationPos[j, 0], destinationPos[j, 1], 128f - (num3 - (float)destinationPos[j, 0]) * 2.734f, 72f - (num4 - (float)destinationPos[j, 1]) * 2.734f, 6, 40);
				evt.eventImageChangeScale(105 + j, 1f, 1f, 2.734f, 2.734f, 6, 40);
				evt.eventStopImage((DirectionManager.IMAGE)(2 + destinationID[destination, j] - 1), 47);
			}
			evt.eventImageChangeScale(115f, 1f, 1f, 2.734f, 2.734f, 6, 40);
			evt.eventImageSlide(115f, 128f, 72f, 128f - (num3 - 128f) * 2.734f, 72f - (num4 - 72f) * 2.734f, 6, 40);
			evt.eventPlayImage((DirectionManager.IMAGE)(11 + kind - 1), false, true, 128, 72, 105 + kind - 1, 47);
			evt.eventImageChangeScale(105 + kind - 1, 0.7675f, 0.7675f, 0.7675f, 0.7675f, 1, 47);
			evt.eventPlayMovie(DirectionManager.MOVIE.kmp_deside_2, false, true, true, true, 128, 72, 99, 47);
		}
	}

	public override void start()
	{
		base.start();
		if (low != 0)
		{
			return;
		}
		switch (mode)
		{
		case 1:
		case 9:
		case 14:
		case 17:
		case 20:
		case 23:
		case 26:
		case 29:
		case 32:
		case 35:
		case 38:
		case 41:
		case 44:
		case 48:
		case 51:
		case 54:
		case 57:
		case 60:
		case 63:
		case 66:
		case 69:
		case 72:
		case 75:
		case 78:
		case 81:
		case 84:
		case 87:
		case 90:
		case 93:
		case 96:
		case 99:
		case 102:
		case 105:
		case 108:
		case 111:
		case 114:
		case 118:
		case 121:
		case 124:
		case 127:
		case 130:
		case 133:
		case 138:
		case 141:
		case 144:
		case 148:
		case 151:
		case 154:
		case 157:
		case 160:
		case 163:
		case 166:
			if (mode == 133 || mode == 138 || mode == 141)
			{
				isCat = true;
			}
			else
			{
				isCat = false;
			}
			setStartChara();
			setStartBG();
			setStartDest();
			setStartSound();
			break;
		case 169:
			evt.eventStopDirectionBefore(mng, 0);
			setDest(4, 1);
			evt.eventPlaySound(DirectionManager.SOUND.S0576, Sound.CH.SE0, false, 1f, 0);
			evt.eventPlaySound(DirectionManager.SOUND.S0577, Sound.CH.SE0, false, 1f, 15);
			evt.eventPlaySound(DirectionManager.SOUND.S0578, Sound.CH.SE0, false, 1f, 40);
			evt.eventPlaySound(DirectionManager.SOUND.S0352, Sound.CH.SE0, false, 1f, 45);
			evt.eventPlaySound(DirectionManager.SOUND.S0210, Sound.CH.SE0, false, 1f, 45);
			evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 60);
			break;
		case 170:
			evt.eventStopDirectionBefore(mng, 0);
			setDest(5, 2);
			evt.eventPlaySound(DirectionManager.SOUND.S0576, Sound.CH.SE0, false, 1f, 0);
			evt.eventPlaySound(DirectionManager.SOUND.S0577, Sound.CH.SE0, false, 1f, 15);
			evt.eventPlaySound(DirectionManager.SOUND.S0578, Sound.CH.SE0, false, 1f, 40);
			evt.eventPlaySound(DirectionManager.SOUND.S0353, Sound.CH.SE0, false, 1f, 45);
			evt.eventPlaySound(DirectionManager.SOUND.S0211, Sound.CH.SE0, false, 1f, 45);
			evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 65);
			break;
		case 171:
			evt.eventStopDirectionBefore(mng, 0);
			setDest(9, 3);
			evt.eventPlaySound(DirectionManager.SOUND.S0576, Sound.CH.SE0, false, 1f, 0);
			evt.eventPlaySound(DirectionManager.SOUND.S0577, Sound.CH.SE0, false, 1f, 15);
			evt.eventPlaySound(DirectionManager.SOUND.S0578, Sound.CH.SE0, false, 1f, 40);
			evt.eventPlaySound(DirectionManager.SOUND.S0353, Sound.CH.SE0, false, 1f, 45);
			evt.eventPlaySound(DirectionManager.SOUND.S0212, Sound.CH.SE0, false, 1f, 45);
			evt.eventStopSound(Sound.CH.BGM, 45);
			evt.eventPlaySound(DirectionManager.SOUND.S0116, Sound.CH.SE0, false, 1f, 75);
			break;
		case 172:
			evt.eventStopDirectionBefore(mng, 0);
			setDest(3, 4);
			evt.eventPlaySound(DirectionManager.SOUND.S0576, Sound.CH.SE0, false, 1f, 0);
			evt.eventPlaySound(DirectionManager.SOUND.S0577, Sound.CH.SE0, false, 1f, 15);
			evt.eventPlaySound(DirectionManager.SOUND.S0578, Sound.CH.SE0, false, 1f, 40);
			evt.eventPlaySound(DirectionManager.SOUND.S0400, Sound.CH.SE0, false, 1f, 45);
			evt.eventStopSound(Sound.CH.BGM, 45);
			evt.eventPlaySound(DirectionManager.SOUND.S0118, Sound.CH.SE0, false, 1f, 80);
			break;
		case 173:
			evt.eventStopDirectionBefore(mng, 0);
			setDest(8, 5);
			evt.eventPlaySound(DirectionManager.SOUND.S0576, Sound.CH.SE0, false, 1f, 0);
			evt.eventPlaySound(DirectionManager.SOUND.S0577, Sound.CH.SE0, false, 1f, 15);
			evt.eventPlaySound(DirectionManager.SOUND.S0578, Sound.CH.SE0, false, 1f, 40);
			evt.eventPlaySound(DirectionManager.SOUND.S0399, Sound.CH.SE0, false, 1f, 45);
			evt.eventStopSound(Sound.CH.BGM, 45);
			evt.eventPlaySound(DirectionManager.SOUND.S0117, Sound.CH.SE0, false, 1f, 78);
			break;
		case 174:
			evt.eventStopDirectionBefore(mng, 0);
			setDest(6, 4);
			evt.eventPlaySound(DirectionManager.SOUND.S0576, Sound.CH.SE0, false, 1f, 0);
			evt.eventPlaySound(DirectionManager.SOUND.S0577, Sound.CH.SE0, false, 1f, 15);
			evt.eventPlaySound(DirectionManager.SOUND.S0578, Sound.CH.SE0, false, 1f, 40);
			evt.eventPlaySound(DirectionManager.SOUND.S0402, Sound.CH.SE0, false, 1f, 45);
			evt.eventStopSound(Sound.CH.BGM, 45);
			break;
		case 175:
			evt.eventStopDirectionBefore(mng, 0);
			setDest(7, 5);
			evt.eventPlaySound(DirectionManager.SOUND.S0576, Sound.CH.SE0, false, 1f, 0);
			evt.eventPlaySound(DirectionManager.SOUND.S0577, Sound.CH.SE0, false, 1f, 15);
			evt.eventPlaySound(DirectionManager.SOUND.S0578, Sound.CH.SE0, false, 1f, 40);
			evt.eventPlaySound(DirectionManager.SOUND.S0401, Sound.CH.SE0, false, 1f, 45);
			evt.eventStopSound(Sound.CH.BGM, 45);
			evt.eventPlaySound(DirectionManager.SOUND.S0135, Sound.CH.SE0, false, 1f, 96);
			break;
		case 176:
			evt.eventStopDirectionBefore(mng, 0);
			setDest(9, 2);
			evt.eventPlaySound(DirectionManager.SOUND.S0576, Sound.CH.SE0, false, 1f, 0);
			evt.eventPlaySound(DirectionManager.SOUND.S0577, Sound.CH.SE0, false, 1f, 15);
			evt.eventPlaySound(DirectionManager.SOUND.S0578, Sound.CH.SE0, false, 1f, 40);
			evt.eventPlaySound(DirectionManager.SOUND.S0353, Sound.CH.SE0, false, 1f, 45);
			evt.eventPlaySound(DirectionManager.SOUND.S0212, Sound.CH.SE0, false, 1f, 45);
			evt.eventStopSound(Sound.CH.BGM, 45);
			evt.eventPlaySound(DirectionManager.SOUND.S0116, Sound.CH.SE0, false, 1f, 75);
			break;
		case 177:
			evt.eventStopDirectionBefore(mng, 0);
			setDest(5, 3);
			evt.eventPlaySound(DirectionManager.SOUND.S0576, Sound.CH.SE0, false, 1f, 0);
			evt.eventPlaySound(DirectionManager.SOUND.S0577, Sound.CH.SE0, false, 1f, 15);
			evt.eventPlaySound(DirectionManager.SOUND.S0578, Sound.CH.SE0, false, 1f, 40);
			evt.eventPlaySound(DirectionManager.SOUND.S0353, Sound.CH.SE0, false, 1f, 45);
			evt.eventPlaySound(DirectionManager.SOUND.S0211, Sound.CH.SE0, false, 1f, 45);
			evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 65);
			break;
		case 178:
			evt.eventStopDirectionBefore(mng, 0);
			setDest(3, 3);
			evt.eventPlaySound(DirectionManager.SOUND.S0576, Sound.CH.SE0, false, 1f, 0);
			evt.eventPlaySound(DirectionManager.SOUND.S0577, Sound.CH.SE0, false, 1f, 15);
			evt.eventPlaySound(DirectionManager.SOUND.S0578, Sound.CH.SE0, false, 1f, 40);
			evt.eventPlaySound(DirectionManager.SOUND.S0400, Sound.CH.SE0, false, 1f, 45);
			evt.eventStopSound(Sound.CH.BGM, 45);
			evt.eventPlaySound(DirectionManager.SOUND.S0118, Sound.CH.SE0, false, 1f, 80);
			break;
		case 179:
			evt.eventStopDirectionBefore(mng, 0);
			setDest(8, 4);
			evt.eventPlaySound(DirectionManager.SOUND.S0576, Sound.CH.SE0, false, 1f, 0);
			evt.eventPlaySound(DirectionManager.SOUND.S0577, Sound.CH.SE0, false, 1f, 15);
			evt.eventPlaySound(DirectionManager.SOUND.S0578, Sound.CH.SE0, false, 1f, 40);
			evt.eventPlaySound(DirectionManager.SOUND.S0399, Sound.CH.SE0, false, 1f, 45);
			evt.eventStopSound(Sound.CH.BGM, 45);
			evt.eventPlaySound(DirectionManager.SOUND.S0117, Sound.CH.SE0, false, 1f, 78);
			break;
		case 180:
			evt.eventStopDirectionBefore(mng, 0);
			setDest(6, 5);
			evt.eventPlaySound(DirectionManager.SOUND.S0576, Sound.CH.SE0, false, 1f, 0);
			evt.eventPlaySound(DirectionManager.SOUND.S0577, Sound.CH.SE0, false, 1f, 15);
			evt.eventPlaySound(DirectionManager.SOUND.S0578, Sound.CH.SE0, false, 1f, 40);
			evt.eventPlaySound(DirectionManager.SOUND.S0402, Sound.CH.SE0, false, 1f, 45);
			evt.eventStopSound(Sound.CH.BGM, 45);
			break;
		case 181:
			evt.eventStopDirectionBefore(mng, 0);
			setDest(3, 2);
			evt.eventPlaySound(DirectionManager.SOUND.S0576, Sound.CH.SE0, false, 1f, 0);
			evt.eventPlaySound(DirectionManager.SOUND.S0577, Sound.CH.SE0, false, 1f, 15);
			evt.eventPlaySound(DirectionManager.SOUND.S0578, Sound.CH.SE0, false, 1f, 40);
			evt.eventPlaySound(DirectionManager.SOUND.S0400, Sound.CH.SE0, false, 1f, 45);
			evt.eventStopSound(Sound.CH.BGM, 45);
			evt.eventPlaySound(DirectionManager.SOUND.S0118, Sound.CH.SE0, false, 1f, 80);
			break;
		case 182:
			evt.eventStopDirectionBefore(mng, 0);
			setDest(8, 3);
			evt.eventPlaySound(DirectionManager.SOUND.S0576, Sound.CH.SE0, false, 1f, 0);
			evt.eventPlaySound(DirectionManager.SOUND.S0577, Sound.CH.SE0, false, 1f, 15);
			evt.eventPlaySound(DirectionManager.SOUND.S0578, Sound.CH.SE0, false, 1f, 40);
			evt.eventPlaySound(DirectionManager.SOUND.S0399, Sound.CH.SE0, false, 1f, 45);
			evt.eventStopSound(Sound.CH.BGM, 45);
			evt.eventPlaySound(DirectionManager.SOUND.S0117, Sound.CH.SE0, false, 1f, 78);
			break;
		case 183:
			evt.eventStopDirectionBefore(mng, 0);
			setDest(5, 1);
			evt.eventPlaySound(DirectionManager.SOUND.S0576, Sound.CH.SE0, false, 1f, 0);
			evt.eventPlaySound(DirectionManager.SOUND.S0577, Sound.CH.SE0, false, 1f, 15);
			evt.eventPlaySound(DirectionManager.SOUND.S0578, Sound.CH.SE0, false, 1f, 40);
			evt.eventPlaySound(DirectionManager.SOUND.S0353, Sound.CH.SE0, false, 1f, 45);
			evt.eventPlaySound(DirectionManager.SOUND.S0211, Sound.CH.SE0, false, 1f, 45);
			evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 65);
			break;
		case 184:
			evt.eventStopDirectionBefore(mng, 0);
			setDest(1, 1);
			evt.eventPlaySound(DirectionManager.SOUND.S0576, Sound.CH.SE0, false, 1f, 0);
			break;
		case 185:
			evt.eventStopDirectionBefore(mng, 0);
			setDest(4, 2);
			evt.eventPlaySound(DirectionManager.SOUND.S0576, Sound.CH.SE0, false, 1f, 0);
			evt.eventPlaySound(DirectionManager.SOUND.S0577, Sound.CH.SE0, false, 1f, 15);
			evt.eventPlaySound(DirectionManager.SOUND.S0578, Sound.CH.SE0, false, 1f, 40);
			evt.eventPlaySound(DirectionManager.SOUND.S0352, Sound.CH.SE0, false, 1f, 45);
			evt.eventPlaySound(DirectionManager.SOUND.S0210, Sound.CH.SE0, false, 1f, 45);
			evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 60);
			break;
		case 186:
			evt.eventStopDirectionBefore(mng, 0);
			setDest(1, 3);
			evt.eventPlaySound(DirectionManager.SOUND.S0576, Sound.CH.SE0, false, 1f, 0);
			break;
		case 187:
			evt.eventStopDirectionBefore(mng, 0);
			setDest(2, 1);
			evt.eventPlaySound(DirectionManager.SOUND.S0576, Sound.CH.SE0, false, 1f, 0);
			evt.eventPlaySound(DirectionManager.SOUND.S0577, Sound.CH.SE0, false, 1f, 15);
			evt.eventPlaySound(DirectionManager.SOUND.S0578, Sound.CH.SE0, false, 1f, 40);
			evt.eventPlaySound(DirectionManager.SOUND.S0352, Sound.CH.SE0, false, 1f, 45);
			evt.eventPlaySound(DirectionManager.SOUND.S0210, Sound.CH.SE0, false, 1f, 45);
			evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 60);
			break;
		case 188:
			evt.eventStopDirectionBefore(mng, 0);
			setDest(9, 1);
			evt.eventPlaySound(DirectionManager.SOUND.S0576, Sound.CH.SE0, false, 1f, 0);
			evt.eventPlaySound(DirectionManager.SOUND.S0577, Sound.CH.SE0, false, 1f, 15);
			evt.eventPlaySound(DirectionManager.SOUND.S0578, Sound.CH.SE0, false, 1f, 40);
			evt.eventPlaySound(DirectionManager.SOUND.S0353, Sound.CH.SE0, false, 1f, 45);
			evt.eventPlaySound(DirectionManager.SOUND.S0212, Sound.CH.SE0, false, 1f, 45);
			evt.eventStopSound(Sound.CH.BGM, 45);
			evt.eventPlaySound(DirectionManager.SOUND.S0116, Sound.CH.SE0, false, 1f, 75);
			break;
		case 189:
			evt.eventStopDirectionBefore(mng, 0);
			setDest(3, 1);
			evt.eventPlaySound(DirectionManager.SOUND.S0576, Sound.CH.SE0, false, 1f, 0);
			evt.eventPlaySound(DirectionManager.SOUND.S0577, Sound.CH.SE0, false, 1f, 15);
			evt.eventPlaySound(DirectionManager.SOUND.S0578, Sound.CH.SE0, false, 1f, 40);
			evt.eventPlaySound(DirectionManager.SOUND.S0400, Sound.CH.SE0, false, 1f, 45);
			evt.eventStopSound(Sound.CH.BGM, 45);
			evt.eventPlaySound(DirectionManager.SOUND.S0118, Sound.CH.SE0, false, 1f, 80);
			break;
		case 190:
			evt.eventStopDirectionBefore(mng, 0);
			setDest(8, 2);
			evt.eventPlaySound(DirectionManager.SOUND.S0576, Sound.CH.SE0, false, 1f, 0);
			evt.eventPlaySound(DirectionManager.SOUND.S0577, Sound.CH.SE0, false, 1f, 15);
			evt.eventPlaySound(DirectionManager.SOUND.S0578, Sound.CH.SE0, false, 1f, 40);
			evt.eventPlaySound(DirectionManager.SOUND.S0399, Sound.CH.SE0, false, 1f, 45);
			evt.eventStopSound(Sound.CH.BGM, 45);
			evt.eventPlaySound(DirectionManager.SOUND.S0117, Sound.CH.SE0, false, 1f, 78);
			break;
		case 191:
			evt.eventStopDirectionBefore(mng, 0);
			setDest(3, 5);
			evt.eventPlaySound(DirectionManager.SOUND.S0576, Sound.CH.SE0, false, 1f, 0);
			evt.eventPlaySound(DirectionManager.SOUND.S0577, Sound.CH.SE0, false, 1f, 15);
			evt.eventPlaySound(DirectionManager.SOUND.S0578, Sound.CH.SE0, false, 1f, 40);
			evt.eventPlaySound(DirectionManager.SOUND.S0400, Sound.CH.SE0, false, 1f, 45);
			evt.eventStopSound(Sound.CH.BGM, 45);
			evt.eventPlaySound(DirectionManager.SOUND.S0118, Sound.CH.SE0, false, 1f, 80);
			break;
		case 192:
			evt.eventStopDirectionBefore(mng, 0);
			setDest(6, 4);
			evt.eventPlaySound(DirectionManager.SOUND.S0576, Sound.CH.SE0, false, 1f, 0);
			evt.eventPlaySound(DirectionManager.SOUND.S0577, Sound.CH.SE0, false, 1f, 15);
			evt.eventPlaySound(DirectionManager.SOUND.S0578, Sound.CH.SE0, false, 1f, 40);
			evt.eventPlaySound(DirectionManager.SOUND.S0402, Sound.CH.SE0, false, 1f, 45);
			evt.eventStopSound(Sound.CH.BGM, 45);
			break;
		case 193:
			evt.eventStopDirectionBefore(mng, 0);
			setDest(7, 5);
			evt.eventPlaySound(DirectionManager.SOUND.S0576, Sound.CH.SE0, false, 1f, 0);
			evt.eventPlaySound(DirectionManager.SOUND.S0577, Sound.CH.SE0, false, 1f, 15);
			evt.eventPlaySound(DirectionManager.SOUND.S0578, Sound.CH.SE0, false, 1f, 40);
			evt.eventPlaySound(DirectionManager.SOUND.S0401, Sound.CH.SE0, false, 1f, 45);
			evt.eventStopSound(Sound.CH.BGM, 45);
			evt.eventPlaySound(DirectionManager.SOUND.S0135, Sound.CH.SE0, false, 1f, 96);
			break;
		case 194:
			evt.eventStopDirectionBefore(mng, 0);
			setDest(6, 5);
			evt.eventPlaySound(DirectionManager.SOUND.S0576, Sound.CH.SE0, false, 1f, 0);
			evt.eventPlaySound(DirectionManager.SOUND.S0577, Sound.CH.SE0, false, 1f, 15);
			evt.eventPlaySound(DirectionManager.SOUND.S0578, Sound.CH.SE0, false, 1f, 40);
			evt.eventPlaySound(DirectionManager.SOUND.S0402, Sound.CH.SE0, false, 1f, 45);
			evt.eventStopSound(Sound.CH.BGM, 45);
			break;
		case 195:
			evt.eventStopDirectionBefore(mng, 0);
			setKeizoku1Chara();
			evt.eventPlaySound(DirectionManager.SOUND.S0576, Sound.CH.SE0, true, 1f, 0);
			break;
		case 196:
			evt.eventStopDirectionBefore(mng, 0);
			setKeizoku2Chara();
			evt.eventPlaySound(DirectionManager.SOUND.S0576, Sound.CH.SE0, true, 1f, 0);
			evt.eventPlaySound(DirectionManager.SOUND.S0579, Sound.CH.SE0, true, 1f, 15);
			break;
		case 197:
			evt.eventStopDirectionBefore(mng, 0);
			setKeizoku1Chara();
			evt.eventPlaySound(DirectionManager.SOUND.S0576, Sound.CH.SE0, true, 1f, 0);
			break;
		case 198:
			evt.eventStopDirectionBefore(mng, 0);
			setKeizoku2Chara();
			evt.eventPlaySound(DirectionManager.SOUND.S0576, Sound.CH.SE0, true, 1f, 0);
			evt.eventPlaySound(DirectionManager.SOUND.S0579, Sound.CH.SE0, true, 1f, 15);
			break;
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
