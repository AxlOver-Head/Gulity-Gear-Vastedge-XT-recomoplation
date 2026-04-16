public class Direction13KPR : DirectionBase
{
	private struct PR_POS
	{
		public int m_add_pos_y;

		public int m_angle;
	}

	private struct BUBBLE_POS
	{
		public int m_status;

		public int m_pos_x;

		public int m_pos_y;

		public int m_target_pos_x;

		public int m_target_pos_y;

		public int m_tmp_pos_x;

		public int m_tmp_pos_y;

		public int m_angle;

		public int m_timer;
	}

	private struct quad_t
	{
		public int x0;

		public int y0;

		public int x1;

		public int y1;

		public int x2;

		public int y2;

		public int x3;

		public int y3;
	}

	public const int LAYER_3RD_LIGHT = 54;

	public const int LAYER_3RD_SELECT = 55;

	public const int LAYER_1ST_LIGHT1 = 60;

	public const int LAYER_MARK_NEAR1 = 65;

	public const int LAYER_MARK_NEAR2 = 66;

	public const int LAYER_MARK_NEAR3 = 67;

	public const int LAYER_MARK_NEAR4 = 68;

	public const int LAYER_MARK_NEAR5 = 69;

	public const int LAYER_1ST_BABLE1 = 70;

	public const int LAYER_1ST_BABLE2 = 71;

	public const int LAYER_1ST_BABLE3 = 72;

	public const int LAYER_1ST_BABLE4 = 73;

	public const int LAYER_1ST_BABLE5 = 74;

	public const int LAYER_1ST_MARK1 = 75;

	public const int LAYER_1ST_MARK2 = 76;

	public const int LAYER_1ST_MARK3 = 77;

	public const int LAYER_1ST_MARK4 = 78;

	public const int LAYER_1ST_MARK5 = 79;

	public const int LAYER_BABLE_NEAR1 = 80;

	public const int LAYER_BABLE_NEAR2 = 81;

	public const int LAYER_BABLE_NEAR3 = 82;

	public const int LAYER_BABLE_NEAR4 = 83;

	public const int LAYER_BABLE_NEAR5 = 84;

	public const int LAYER_PARA_LIGHT = 86;

	public const int LAYER_PARA_ADD = 87;

	public const int LAYER_PARA = 88;

	public const int LAYER_BONI = 89;

	public const int LAYER_BABLE_FAR1 = 90;

	public const int LAYER_BABLE_FAR2 = 91;

	public const int LAYER_BABLE_FAR3 = 92;

	public const int LAYER_BABLE_FAR4 = 93;

	public const int LAYER_BABLE_FAR5 = 94;

	public const int LAYER_MARK_FAR1 = 95;

	public const int LAYER_MARK_FAR2 = 96;

	public const int LAYER_MARK_FAR3 = 97;

	public const int LAYER_MARK_FAR4 = 98;

	public const int LAYER_MARK_FAR5 = 99;

	public const int LAYER_BACK_LIGHT = 100;

	public const int LAYER_BACK = 101;

	public const int FRONT_1ST_LIGHT = 60;

	public const int FRONT_MARK_NEAR = 65;

	public const int FRONT_1ST_BABLE = 70;

	public const int FRONT_1ST_MARK = 75;

	public const int FRONT_BABLE_NEAR = 80;

	public const int FRONT_BABLE_FAR = 90;

	public const int FRONT_MARK_FAR = 95;

	public const int PR_POS_ANGLE_ADD = 6;

	public const int PR_POS_ADD_Y = 5;

	public const int BUBBLE_COUNT = 5;

	public const int BUBBLE_POS_ANGLE_ADD = 6;

	public const int BUBBLE_POS_ADD_Y = 5;

	public const int BUBBLE_ROT_MOVE_FRM = 30;

	public const int BUBBLE_ROT_START_ANGLE = 45;

	public const int BUBBLE_ROT_ANGLE_INTERVAL = 72;

	public const int BUBBLE_ROT_CENTER_X = 400;

	public const int BUBBLE_ROT_CENTER_Y = 437;

	public const float BUBBLE_ROT_RADIUS_X = 93f;

	public const float BUBBLE_ROT_RADIUS_Y = 12f;

	public const float BUBBLE_STOP_RADIUS_X = 23.25f;

	public const float BUBBLE_STOP_RADIUS_Y = 3f;

	public const int BUBBLE_ROT_ANGLE_ADD = 6;

	public const float BUBBLE_ROT_START_ANGLE_ADD = 1f;

	public const int BUBBLE_ROT_STOP_FRM = 30;

	public const int BUBBLE_ROT_SCALE = 50;

	public const int BUBBLE_POS_OFFSET_Y = 20;

	public const int NORMAL = 0;

	public const int ROT_START = 1;

	public const int ROT = 2;

	public const int STOP = 3;

	public const int END = 4;

	private bool[] m_NearBhFlag = new bool[5] { true, true, true, true, true };

	private bool[] m_FarBhFlag = new bool[5];

	private int frameCnt;

	private static int[] stateCnt = new int[5];

	private static int[] m_clistalOldPosX = new int[5];

	private static int[] m_clistalOldPosY = new int[5];

	private static float[] m_clistalSizeW = new float[5];

	private static float[] m_clistalSizeH = new float[5];

	private static int[] m_moveTotalX = new int[5];

	private static int[] m_moveTotalY = new int[5];

	public int[] SinTable = new int[451]
	{
		0, 174, 348, 523, 697, 871, 1045, 1218, 1391, 1564,
		1736, 1908, 2079, 2249, 2419, 2588, 2756, 2923, 3090, 3255,
		3420, 3583, 3746, 3907, 4067, 4226, 4383, 4539, 4694, 4848,
		5000, 5150, 5299, 5446, 5591, 5735, 5877, 6018, 6156, 6293,
		6427, 6560, 6691, 6819, 6946, 7071, 7193, 7313, 7431, 7547,
		7660, 7771, 7880, 7986, 8090, 8191, 8290, 8386, 8480, 8571,
		8660, 8746, 8829, 8910, 8987, 9063, 9135, 9205, 9271, 9335,
		9396, 9455, 9510, 9563, 9612, 9659, 9702, 9743, 9781, 9816,
		9848, 9876, 9902, 9925, 9945, 9961, 9975, 9986, 9993, 9998,
		10000, 9998, 9993, 9986, 9975, 9961, 9945, 9925, 9902, 9876,
		9848, 9816, 9781, 9743, 9702, 9659, 9612, 9563, 9510, 9455,
		9396, 9335, 9271, 9205, 9135, 9063, 8987, 8910, 8829, 8746,
		8660, 8571, 8480, 8386, 8290, 8191, 8090, 7986, 7880, 7771,
		7660, 7547, 7431, 7313, 7193, 7071, 6946, 6819, 6691, 6560,
		6427, 6293, 6156, 6018, 5877, 5735, 5591, 5446, 5299, 5150,
		5000, 4848, 4694, 4539, 4383, 4226, 4067, 3907, 3746, 3583,
		3420, 3255, 3090, 2923, 2756, 2588, 2419, 2249, 2079, 1908,
		1736, 1564, 1391, 1218, 1045, 871, 697, 523, 348, 174,
		0, -174, -348, -523, -697, -871, -1045, -1218, -1391, -1564,
		-1736, -1908, -2079, -2249, -2419, -2588, -2756, -2923, -3090, -3255,
		-3420, -3583, -3746, -3907, -4067, -4226, -4383, -4539, -4694, -4848,
		-5000, -5150, -5299, -5446, -5591, -5735, -5877, -6018, -6156, -6293,
		-6427, -6560, -6691, -6819, -6946, -7071, -7193, -7313, -7431, -7547,
		-7660, -7771, -7880, -7986, -8090, -8191, -8290, -8386, -8480, -8571,
		-8660, -8746, -8829, -8910, -8987, -9063, -9135, -9205, -9271, -9335,
		-9396, -9455, -9510, -9563, -9612, -9659, -9702, -9743, -9781, -9816,
		-9848, -9876, -9902, -9925, -9945, -9961, -9975, -9986, -9993, -9998,
		-10000, -9998, -9993, -9986, -9975, -9961, -9945, -9925, -9902, -9876,
		-9848, -9816, -9781, -9743, -9702, -9659, -9612, -9563, -9510, -9455,
		-9396, -9335, -9271, -9205, -9135, -9063, -8987, -8910, -8829, -8746,
		-8660, -8571, -8480, -8386, -8290, -8191, -8090, -7986, -7880, -7771,
		-7660, -7547, -7431, -7313, -7193, -7071, -6946, -6819, -6691, -6560,
		-6427, -6293, -6156, -6018, -5877, -5735, -5591, -5446, -5299, -5150,
		-5000, -4848, -4694, -4539, -4383, -4226, -4067, -3907, -3746, -3583,
		-3420, -3255, -3090, -2923, -2756, -2588, -2419, -2249, -2079, -1908,
		-1736, -1564, -1391, -1218, -1045, -871, -697, -523, -348, -174,
		0, 174, 348, 523, 697, 871, 1045, 1218, 1391, 1564,
		1736, 1908, 2079, 2249, 2419, 2588, 2756, 2923, 3090, 3255,
		3420, 3583, 3746, 3907, 4067, 4226, 4383, 4539, 4694, 4848,
		5000, 5150, 5299, 5446, 5591, 5735, 5877, 6018, 6156, 6293,
		6427, 6560, 6691, 6819, 6946, 7071, 7193, 7313, 7431, 7547,
		7660, 7771, 7880, 7986, 8090, 8191, 8290, 8386, 8480, 8571,
		8660, 8746, 8829, 8910, 8987, 9063, 9135, 9205, 9271, 9335,
		9396, 9455, 9510, 9563, 9612, 9659, 9702, 9743, 9781, 9816,
		9848, 9876, 9902, 9925, 9945, 9961, 9975, 9986, 9993, 9998,
		10000
	};

	private static PR_POS g_PR_pos = default(PR_POS);

	private static BUBBLE_POS[] g_bubble_pos = new BUBBLE_POS[5];

	private int[] src_layerTbl_1 = new int[5] { 90, 91, 92, 93, 94 };

	private int[] dest_layerTbl_1 = new int[5] { 80, 81, 82, 83, 84 };

	private int[] src_layerTbl_1_mark = new int[5] { 95, 96, 97, 98, 99 };

	private int[] dest_layerTbl_1_mark = new int[5] { 65, 66, 67, 68, 69 };

	private int[] src_layerTbl_2 = new int[5] { 80, 81, 82, 83, 84 };

	private int[] dest_layerTbl_2 = new int[5] { 90, 91, 92, 93, 94 };

	private int[] src_layerTbl_2_mark = new int[5] { 65, 66, 67, 68, 69 };

	private int[] dest_layerTbl_2_mark = new int[5] { 95, 96, 97, 98, 99 };

	private int[] posX_tbl = new int[5] { 35, 66, 128, 193, 226 };

	private int[] posY_tbl = new int[5] { 42, 84, 118, 84, 42 };

	public int[] g_random_seed = new int[4] { 123456789, 362436069, 521288629, 88675123 };

	public Direction13KPR(DirectionManager _mng, byte _high, byte _low, byte _mode, DirectionManager.DIR _dir)
		: base(_mng, _high, _low, _mode, _dir, DirectionBase.PRIORITY_NORMAL)
	{
	}

	private int GetSin(int n)
	{
		n %= 360;
		if (n < 0)
		{
			n += 360;
		}
		n = 360 - n;
		return SinTable[n];
	}

	private int GetCos(int n)
	{
		n %= 360;
		if (n < 0)
		{
			n += 360;
		}
		n = 360 - n;
		return SinTable[n + 90];
	}

	public void SetPRAddPosY(int _add_y)
	{
		g_PR_pos.m_add_pos_y = _add_y;
	}

	public int GetPRAddPosY()
	{
		return g_PR_pos.m_add_pos_y;
	}

	public void SetPRAngle(int _angle)
	{
		g_PR_pos.m_angle = _angle;
	}

	public int GetPRAngle()
	{
		return g_PR_pos.m_angle;
	}

	public void RenewPRAngle()
	{
		g_PR_pos.m_angle += 6;
		g_PR_pos.m_angle = LOOP_CYCLE(0, g_PR_pos.m_angle, 360);
		SetPRAddPosY(5 * GetSin(g_PR_pos.m_angle) / 10000);
	}

	public void SetPRPos()
	{
	}

	public void PRPosMain()
	{
		RenewPRAngle();
	}

	public void SetBubbleStatus(int _idx, int _status)
	{
		g_bubble_pos[_idx].m_status = _status;
		stateCnt[_idx] = 0;
		frameCnt = 0;
	}

	public int GetBubbleStatus(int _idx)
	{
		return g_bubble_pos[_idx].m_status;
	}

	public void SetBubblePosX(int _idx, int _pos_x)
	{
		g_bubble_pos[_idx].m_pos_x = _pos_x;
	}

	public int GetBubblePosX(int _idx)
	{
		return g_bubble_pos[_idx].m_pos_x;
	}

	public void SetBubblePosY(int _idx, int _pos_y)
	{
		g_bubble_pos[_idx].m_pos_y = _pos_y;
	}

	public int GetBubblePosY(int _idx)
	{
		return g_bubble_pos[_idx].m_pos_y;
	}

	public void SetBubbleTargetPosX(int _idx, int _pos_x)
	{
		g_bubble_pos[_idx].m_target_pos_x = _pos_x;
	}

	public int GetBubbleTargetPosX(int _idx)
	{
		return g_bubble_pos[_idx].m_target_pos_x;
	}

	public void SetBubbleTargetPosY(int _idx, int _pos_y)
	{
		g_bubble_pos[_idx].m_target_pos_y = _pos_y;
	}

	public int GetBubbleTargetPosY(int _idx)
	{
		return g_bubble_pos[_idx].m_target_pos_y;
	}

	public void SetBubbleTempPosX(int _idx, int _pos_x)
	{
		g_bubble_pos[_idx].m_tmp_pos_x = _pos_x;
	}

	public int GetBubbleTempPosX(int _idx)
	{
		return g_bubble_pos[_idx].m_tmp_pos_x;
	}

	public void SetBubbleTempPosY(int _idx, int _pos_y)
	{
		g_bubble_pos[_idx].m_tmp_pos_y = _pos_y;
	}

	public int GetBubbleTempPosY(int _idx)
	{
		return g_bubble_pos[_idx].m_tmp_pos_y;
	}

	public void SetBubbleAngle(int _idx, int _angle)
	{
		g_bubble_pos[_idx].m_angle = _angle;
	}

	public int GetBubbleAngle(int _idx)
	{
		return g_bubble_pos[_idx].m_angle;
	}

	public void RenewBubbleAngle(int _idx, int _add)
	{
		g_bubble_pos[_idx].m_angle -= _add;
		g_bubble_pos[_idx].m_angle = LOOP_CYCLE(-360, g_bubble_pos[_idx].m_angle, 0);
	}

	public void ClearBubbleMoveTimer(int _idx)
	{
		g_bubble_pos[_idx].m_timer = 0;
	}

	public int GetBubbleMoveTimer(int _idx)
	{
		return g_bubble_pos[_idx].m_timer;
	}

	public void RenewBubbleMoveTimer(int _idx)
	{
		g_bubble_pos[_idx].m_timer++;
	}

	public void BubbleScale(int _idx)
	{
	}

	public void SetBubbleBehavior(int _idx)
	{
		if (CHECK_RANGE(-180, GetBubbleAngle(_idx), 0))
		{
			int id = SGLG.prodImg.findLayer(src_layerTbl_1[_idx]);
			SGLG.prodImg.SetLayer(id, dest_layerTbl_1[_idx]);
			int id2 = SGLG.prod.findLayer(src_layerTbl_1_mark[_idx]);
			SGLG.prod.SetLayer(id2, dest_layerTbl_1_mark[_idx]);
			m_NearBhFlag[_idx] = true;
			m_FarBhFlag[_idx] = false;
		}
		else
		{
			int id3 = SGLG.prodImg.findLayer(src_layerTbl_2[_idx]);
			SGLG.prodImg.SetLayer(id3, dest_layerTbl_2[_idx]);
			int id4 = SGLG.prod.findLayer(src_layerTbl_2_mark[_idx]);
			SGLG.prod.SetLayer(id4, dest_layerTbl_2_mark[_idx]);
			m_NearBhFlag[_idx] = false;
			m_FarBhFlag[_idx] = true;
		}
	}

	public void SetBubblePos(int _idx)
	{
		switch (GetBubbleStatus(_idx))
		{
		case 0:
			break;
		case 1:
		{
			float num = GET_TIME_RATE(GetBubbleMoveTimer(_idx), 0, 30);
			if (!CHECK_RANGE_EQU(0, (int)num, 1))
			{
				SetBubbleStatus(_idx, 2);
				SetBubblePosX(_idx, GetBubbleTargetPosX(_idx));
				SetBubblePosY(_idx, GetBubbleTargetPosY(_idx) + 20);
			}
			BubbleScale(_idx);
			break;
		}
		case 2:
		case 3:
			BubbleScale(_idx);
			break;
		case 4:
			break;
		}
	}

	public void BubblePosMain(int _idx)
	{
		switch (GetBubbleStatus(_idx))
		{
		case 0:
			RenewBubbleAngle(_idx, 6);
			SetBubblePosX(_idx, posX_tbl[_idx] - 128);
			SetBubblePosY(_idx, posY_tbl[_idx] + 5 * GetSin(GetBubbleAngle(_idx)) / 10000 - 72);
			break;
		case 1:
			SetBubblePosX(_idx, 93 * GetCos(GetBubbleAngle(_idx)) / 10000);
			SetBubblePosY(_idx, 12 * GetSin(GetBubbleAngle(_idx)) / 10000 - m_moveTotalY[_idx]);
			if (frameCnt % 3 == 0)
			{
				if (_idx == 2)
				{
					m_moveTotalY[_idx] = ((19 > m_moveTotalY[_idx] || m_moveTotalY[_idx] > 21) ? (m_moveTotalY[_idx] + 1) : 0);
				}
				else
				{
					m_moveTotalY[_idx] = ((19 > m_moveTotalY[_idx] || m_moveTotalY[_idx] > 21) ? (m_moveTotalY[_idx] - 1) : 0);
				}
			}
			else if (frameCnt % 3 == 1)
			{
				if (_idx == 2)
				{
					m_moveTotalY[_idx] = ((19 > m_moveTotalY[_idx] || m_moveTotalY[_idx] > 21) ? m_moveTotalY[_idx] : 0);
				}
				if (_idx == 1 || _idx == 3)
				{
					m_moveTotalY[_idx] = ((19 > m_moveTotalY[_idx] || m_moveTotalY[_idx] > 21) ? m_moveTotalY[_idx] : 0);
				}
				else
				{
					m_moveTotalY[_idx] = ((19 > m_moveTotalY[_idx] || m_moveTotalY[_idx] > 21) ? (m_moveTotalY[_idx] - 1) : 0);
				}
			}
			else if (frameCnt % 3 == 2)
			{
				if (_idx == 2)
				{
					m_moveTotalY[_idx] = ((19 > m_moveTotalY[_idx] || m_moveTotalY[_idx] > 21) ? (m_moveTotalY[_idx] + 1) : 0);
				}
				if (_idx == 1 || _idx == 3)
				{
					m_moveTotalY[_idx] = ((19 > m_moveTotalY[_idx] || m_moveTotalY[_idx] > 21) ? (m_moveTotalY[_idx] - 1) : 0);
				}
				else
				{
					m_moveTotalY[_idx] = ((19 > m_moveTotalY[_idx] || m_moveTotalY[_idx] > 21) ? (m_moveTotalY[_idx] - 2) : 0);
				}
			}
			RenewBubbleAngle(_idx, 1);
			RenewBubbleMoveTimer(_idx);
			SetBubbleTargetPosX(_idx, 93 * GetCos(GetBubbleAngle(_idx)) / 10000);
			SetBubbleTargetPosY(_idx, 12 * GetSin(GetBubbleAngle(_idx)) / 10000);
			break;
		case 2:
			RenewBubbleAngle(_idx, 6);
			SetBubblePosX(_idx, 93 * GetCos(GetBubbleAngle(_idx)) / 10000);
			SetBubblePosY(_idx, 12 * GetSin(GetBubbleAngle(_idx)) / 10000 + 20);
			break;
		case 3:
		{
			RenewBubbleAngle(_idx, 6);
			RenewBubbleMoveTimer(_idx);
			float num = GET_TIME_RATE(GetBubbleMoveTimer(_idx), 0, 30);
			if (CHECK_RANGE_EQU(0, (int)num, 0))
			{
				m_moveTotalY[_idx]--;
				SetBubblePosX(_idx, (int)LINER_INTERPOLATION(93f, 23.25f, num) * GetCos(GetBubbleAngle(_idx)) / 10000);
				SetBubblePosY(_idx, (int)LINER_INTERPOLATION(12f, 3f, num) * GetSin(GetBubbleAngle(_idx)) / 10000 + m_moveTotalY[_idx] + 20);
			}
			else if (CHECK_RANGE_EQU(0, (int)num, 0))
			{
				m_moveTotalY[_idx] -= 2;
				SetBubblePosX(_idx, (int)LINER_INTERPOLATION(93f, 23.25f, num) * GetCos(GetBubbleAngle(_idx)) / 10000);
				SetBubblePosY(_idx, (int)LINER_INTERPOLATION(12f, 3f, num) * GetSin(GetBubbleAngle(_idx)) / 10000 + m_moveTotalY[_idx] + 20);
			}
			else if (CHECK_RANGE_EQU(0, (int)num, 1))
			{
				m_moveTotalY[_idx] -= 4;
				SetBubblePosX(_idx, (int)LINER_INTERPOLATION(93f, 23.25f, num) * GetCos(GetBubbleAngle(_idx)) / 10000);
				SetBubblePosY(_idx, (int)LINER_INTERPOLATION(12f, 3f, num) * GetSin(GetBubbleAngle(_idx)) / 10000 + m_moveTotalY[_idx] + 20);
			}
			else
			{
				SetBubbleStatus(_idx, 4);
			}
			break;
		}
		}
	}

	public void DispBubblePatternNear(int _idx)
	{
		if (m_NearBhFlag[_idx])
		{
			switch (GetBubbleStatus(_idx))
			{
			case 0:
				SGLG.prod.SetXY(SGLG.prod.findLayer(70 + _idx), GetBubblePosX(_idx), GetBubblePosY(_idx));
				SGLG.prodImg.SetXY(SGLG.prodImg.findLayer(75 + _idx), GetBubblePosX(_idx), GetBubblePosY(_idx));
				break;
			case 1:
				SGLG.prodImg.SetXY(SGLG.prodImg.findLayer(65 + _idx), GetBubblePosX(_idx), GetBubblePosY(_idx));
				SGLG.prodImg.SetXY(SGLG.prodImg.findLayer(70 + _idx), GetBubblePosX(_idx), GetBubblePosY(_idx));
				SGLG.prodImg.SetXY(SGLG.prodImg.findLayer(80 + _idx), GetBubblePosX(_idx), GetBubblePosY(_idx));
				break;
			case 2:
				SGLG.prodImg.SetXY(SGLG.prodImg.findLayer(65 + _idx), GetBubblePosX(_idx), GetBubblePosY(_idx));
				SGLG.prodImg.SetXY(SGLG.prodImg.findLayer(70 + _idx), GetBubblePosX(_idx), GetBubblePosY(_idx));
				SGLG.prodImg.SetXY(SGLG.prodImg.findLayer(80 + _idx), GetBubblePosX(_idx), GetBubblePosY(_idx));
				break;
			case 3:
				SGLG.prodImg.SetXY(SGLG.prodImg.findLayer(80 + _idx), GetBubblePosX(_idx), GetBubblePosY(_idx));
				break;
			}
			m_clistalOldPosX[_idx] = GetBubblePosX(_idx);
			m_clistalOldPosY[_idx] = GetBubblePosY(_idx);
		}
	}

	public void DispBubblePatternFar(int _idx)
	{
		if (m_FarBhFlag[_idx])
		{
			switch (GetBubbleStatus(_idx))
			{
			case 1:
				SGLG.prodImg.SetXY(SGLG.prodImg.findLayer(95 + _idx), GetBubblePosX(_idx), GetBubblePosY(_idx));
				SGLG.prodImg.SetXY(SGLG.prodImg.findLayer(90 + _idx), GetBubblePosX(_idx), GetBubblePosY(_idx));
				break;
			case 2:
				SGLG.prodImg.SetXY(SGLG.prodImg.findLayer(95 + _idx), GetBubblePosX(_idx), GetBubblePosY(_idx));
				SGLG.prodImg.SetXY(SGLG.prodImg.findLayer(90 + _idx), GetBubblePosX(_idx), GetBubblePosY(_idx));
				break;
			}
			m_clistalOldPosX[_idx] = GetBubblePosX(_idx);
			m_clistalOldPosY[_idx] = GetBubblePosY(_idx);
		}
	}

	public void Init13KPR()
	{
		g_PR_pos = default(PR_POS);
		g_bubble_pos[0] = default(BUBBLE_POS);
		g_bubble_pos[1] = default(BUBBLE_POS);
		g_bubble_pos[2] = default(BUBBLE_POS);
		g_bubble_pos[3] = default(BUBBLE_POS);
		g_bubble_pos[4] = default(BUBBLE_POS);
		m_clistalOldPosX = new int[5];
		m_clistalOldPosY = new int[5];
		m_clistalSizeW[0] = 1f;
		m_clistalSizeW[1] = 1f;
		m_clistalSizeW[2] = 1f;
		m_clistalSizeW[3] = 1f;
		m_clistalSizeW[4] = 1f;
		m_clistalSizeH[0] = 1f;
		m_clistalSizeH[1] = 1f;
		m_clistalSizeH[2] = 1f;
		m_clistalSizeH[3] = 1f;
		m_clistalSizeH[4] = 1f;
		SetPRAngle(ARC_Random() % 360);
		for (int i = 0; i < 5; i++)
		{
			SetBubbleAngle(i, ARC_Random() % 360);
			m_moveTotalX[i] = 0;
			m_moveTotalY[i] = 0;
		}
		frameCnt = 0;
		m_NearBhFlag = new bool[5] { true, true, true, true, true };
		m_FarBhFlag = new bool[5];
	}

	public void Main13KPR()
	{
		PRPosMain();
		for (int i = 0; i < 5; i++)
		{
			switch (GetBubbleStatus(i))
			{
			case 1:
			case 2:
				SetBubbleBehavior(i);
				break;
			}
			BubblePosMain(i);
		}
	}

	public void Init13KPRRot()
	{
		int num = 45;
		for (int i = 0; i < 5; i++)
		{
			SetBubbleStatus(i, 1);
			SetBubbleAngle(i, num);
			num -= 72;
			SetBubbleBehavior(i);
		}
		frameCnt = 0;
		for (int i = 0; i < 5; i++)
		{
			m_moveTotalX[i] = 0;
		}
		m_moveTotalY[0] = 30;
		m_moveTotalY[1] = 20;
		m_moveTotalY[2] = -20;
		m_moveTotalY[3] = 20;
		m_moveTotalY[4] = 30;
		m_NearBhFlag = new bool[5] { true, true, true, true, true };
		m_FarBhFlag = new bool[5];
	}

	public void Init13KPRStop()
	{
		for (int i = 0; i < 5; i++)
		{
			SetBubbleStatus(i, 3);
			ClearBubbleMoveTimer(i);
		}
		frameCnt = 0;
		for (int i = 0; i < 5; i++)
		{
			m_moveTotalX[i] = 0;
			m_moveTotalY[i] = 0;
		}
		m_NearBhFlag = new bool[5] { true, true, true, true, true };
		m_FarBhFlag = new bool[5];
	}

	public override void start()
	{
		if (low == 0)
		{
			switch (mode)
			{
			case 1:
			case 10:
			case 13:
			case 15:
			case 19:
			case 21:
			case 23:
			case 25:
			case 27:
			case 29:
			case 38:
			case 41:
			case 44:
			case 46:
			case 48:
			case 50:
			case 52:
			case 54:
			case 56:
			case 58:
			case 60:
			case 62:
			case 64:
			case 66:
			case 86:
			case 89:
			case 91:
			case 94:
				Init13KPR();
				break;
			case 2:
			case 11:
			case 14:
			case 16:
			case 20:
			case 22:
			case 24:
			case 26:
			case 28:
			case 30:
			case 39:
			case 42:
			case 45:
			case 47:
			case 49:
			case 51:
			case 53:
			case 55:
			case 57:
			case 59:
			case 61:
			case 63:
			case 65:
			case 67:
			case 87:
			case 90:
			case 92:
			case 95:
				kpr_killMovie(60f);
				kpr_killImage(75f);
				kpr_killImage(76f);
				kpr_killImage(77f);
				kpr_killImage(78f);
				kpr_killImage(79f);
				Init13KPRRot();
				break;
			case 3:
			case 4:
			case 5:
			case 6:
			case 7:
			case 8:
			case 12:
			case 17:
			case 18:
			case 31:
			case 32:
			case 33:
			case 34:
			case 35:
			case 36:
			case 40:
			case 43:
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
			case 88:
			case 93:
			{
				int num = 0;
				for (num = 0; num < 5; num++)
				{
					int[] array = new int[5] { 90, 91, 92, 93, 94 };
					int[] array2 = new int[5] { 80, 81, 82, 83, 84 };
					int id = SGLG.prodImg.findLayer(array[num]);
					SGLG.prodImg.SetLayer(id, array2[num]);
					int[] array3 = new int[5] { 95, 96, 97, 98, 99 };
					int[] array4 = new int[5] { 65, 66, 67, 68, 69 };
					int id2 = SGLG.prod.findLayer(array3[num]);
					SGLG.prod.SetLayer(id2, array4[num]);
				}
				kpr_killMovie(70f);
				kpr_killMovie(71f);
				kpr_killMovie(72f);
				kpr_killMovie(73f);
				kpr_killMovie(74f);
				kpr_killMovie(60f);
				kpr_killImage(75f);
				kpr_killImage(76f);
				kpr_killImage(77f);
				kpr_killImage(78f);
				kpr_killImage(79f);
				kpr_killMovie(65f);
				kpr_killMovie(66f);
				kpr_killMovie(67f);
				kpr_killMovie(68f);
				kpr_killMovie(69f);
				kpr_killMovie(95f);
				kpr_killMovie(96f);
				kpr_killMovie(97f);
				kpr_killMovie(98f);
				kpr_killMovie(99f);
				Init13KPRStop();
				break;
			}
			}
		}
		BubblePosMain(0);
		BubblePosMain(1);
		BubblePosMain(2);
		BubblePosMain(3);
		BubblePosMain(4);
		int bubblePosX = GetBubblePosX(0);
		int bubblePosX2 = GetBubblePosX(1);
		int bubblePosX3 = GetBubblePosX(2);
		int bubblePosX4 = GetBubblePosX(3);
		int bubblePosX5 = GetBubblePosX(4);
		int bubblePosY = GetBubblePosY(0);
		int bubblePosY2 = GetBubblePosY(1);
		int bubblePosY3 = GetBubblePosY(2);
		int bubblePosY4 = GetBubblePosY(3);
		int bubblePosY5 = GetBubblePosY(4);
		if (low == 0)
		{
			switch (mode)
			{
			case 1:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01, false, false, 0, 0, 101, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0564, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1840, Sound.CH.VC0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0112, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_par_lp, false, false, false, true, 128, 63, 88, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_par_lp_add, false, false, true, true, 128, 63, 87, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_batu_lp, false, false, bubblePosX, bubblePosY, 75, 5);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_bikk_lp, false, false, bubblePosX2, bubblePosY2, 76, 7);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_chance_lp, false, false, bubblePosX3, bubblePosY3, 77, 9);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_cation_lp, false, false, bubblePosX4, bubblePosY4, 78, 11);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_hoh_lp, false, false, bubblePosX5, bubblePosY5, 79, 13);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_batu_add4, true, false, true, false, 0, 0, 60, 5);
				break;
			case 2:
				evt.eventStopDirectionBefore(mng, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0565, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr002_light_para, false, false, true, true, 128, 63, 86, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 80, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 81, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 82, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 83, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 84, 0);
				break;
			case 3:
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 158);
				evt.eventPlaySound(DirectionManager.SOUND.S0566, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1842, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0352, Sound.CH.SE1, true, 1f, 22);
				evt.eventPlaySound(DirectionManager.SOUND.S0210, Sound.CH.SE0, true, 1f, 22);
				evt.eventPlaySound(DirectionManager.SOUND.S1843, Sound.CH.VC1, true, 1f, 45);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_a, false, false, false, false, 0, 0, 61, 15);
				evt.eventAddMovie(DirectionManager.MOVIE.kpr004_a_loop, DirectionManager.MOVIE.kpr004_a, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_light, true, false, true, false, 0, 0, 60, 12);
				break;
			case 4:
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 158);
				evt.eventPlaySound(DirectionManager.SOUND.S0566, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1842, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0352, Sound.CH.SE1, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0210, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S1845, Sound.CH.VC1, true, 1f, 45);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_b, false, false, false, false, 0, 0, 61, 15);
				evt.eventAddMovie(DirectionManager.MOVIE.kpr004_b_loop, DirectionManager.MOVIE.kpr004_b, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_light, true, false, true, false, 0, 0, 60, 12);
				break;
			case 5:
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 175);
				evt.eventPlaySound(DirectionManager.SOUND.S0566, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1842, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0353, Sound.CH.SE1, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0211, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S1847, Sound.CH.VC1, true, 1f, 45);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_par_lp, false, false, false, true, 128, 63, 99, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_chance, false, false, false, false, 0, 0, 61, 15);
				evt.eventAddMovie(DirectionManager.MOVIE.kpr004_chance_loop, DirectionManager.MOVIE.kpr004_chance, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_light, true, false, true, false, 0, 0, 60, 12);
				break;
			case 6:
				evt.eventStopSound(Sound.CH.BGM, 21);
				evt.eventPlaySound(DirectionManager.SOUND.S0116, Sound.CH.BGM, true, 1f, 115);
				evt.eventPlaySound(DirectionManager.SOUND.S0566, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1842, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0353, Sound.CH.SE1, true, 1f, 21);
				evt.eventPlaySound(DirectionManager.SOUND.S0212, Sound.CH.SE0, true, 1f, 21);
				evt.eventPlaySound(DirectionManager.SOUND.S1853, Sound.CH.VC1, true, 1f, 45);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_cation, false, false, false, false, 0, 0, 61, 15);
				evt.eventAddMovie(DirectionManager.MOVIE.kpr004_cation_loop, DirectionManager.MOVIE.kpr004_cation, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_light, true, false, true, false, 0, 0, 60, 12);
				break;
			case 7:
				evt.eventStopSound(Sound.CH.BGM, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0117, Sound.CH.BGM, true, 1f, 85);
				evt.eventPlaySound(DirectionManager.SOUND.S0566, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1842, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0399, Sound.CH.SE1, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S1857, Sound.CH.VC1, true, 1f, 45);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_hoh, false, false, false, false, 0, 0, 61, 15);
				evt.eventAddMovie(DirectionManager.MOVIE.kpr004_hoh_loop, DirectionManager.MOVIE.kpr004_hoh, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_light, true, false, true, false, 0, 0, 60, 12);
				break;
			case 8:
				evt.eventStopSound(Sound.CH.BGM, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0566, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1842, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0353, Sound.CH.SE1, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0215, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_cat, false, false, false, false, 0, 0, 61, 15);
				evt.eventAddMovie(DirectionManager.MOVIE.kpr004_cat_loop, DirectionManager.MOVIE.kpr004_cat, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_light, true, false, true, false, 0, 0, 60, 12);
				break;
			case 9:
				evt.eventPlayMovie(DirectionManager.MOVIE.push_c, false, true, false, false, 0, 0, 52, 23);
				evt.eventSetCanPush(true, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_c_add, true, false, true, false, 0, 0, 51, 23);
				evt.eventPlaySound(DirectionManager.SOUND.S0223, Sound.CH.SE0, true, 1f, 23);
				break;
			case 10:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01, false, false, 0, 0, 101, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0564, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1840, Sound.CH.VC0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0112, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_par_lp, false, false, false, true, 128, 63, 88, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_par_lp_add, false, false, true, true, 128, 63, 87, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_batu_lp, false, false, bubblePosX, bubblePosY, 75, 5);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_bikk_lp, false, false, bubblePosX2, bubblePosY2, 76, 7);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_chance_lp, false, false, bubblePosX3, bubblePosY3, 77, 9);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_cation_lp, false, false, bubblePosX4, bubblePosY4, 78, 11);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_jg_lp, false, false, bubblePosX5, bubblePosY5, 79, 13);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_batu_add4, true, false, true, false, 0, 0, 60, 5);
				break;
			case 11:
				evt.eventStopDirectionBefore(mng, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0565, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr002_light_para, false, false, true, true, 128, 63, 86, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 80, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 81, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 82, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 83, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 84, 0);
				break;
			case 12:
				evt.eventStopSound(Sound.CH.BGM, 22);
				evt.eventPlaySound(DirectionManager.SOUND.S0118, Sound.CH.BGM, true, 1f, 122);
				evt.eventPlaySound(DirectionManager.SOUND.S0566, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1842, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0400, Sound.CH.SE1, true, 1f, 22);
				evt.eventPlaySound(DirectionManager.SOUND.S1859, Sound.CH.VC1, true, 1f, 45);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_jg, false, false, false, false, 0, 0, 61, 15);
				evt.eventAddMovie(DirectionManager.MOVIE.kpr004_jg_loop, DirectionManager.MOVIE.kpr004_jg, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_light, true, false, true, false, 0, 0, 60, 12);
				break;
			case 13:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01, false, false, 0, 0, 101, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0564, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1840, Sound.CH.VC0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0112, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_par_lp, false, false, false, true, 128, 63, 88, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_par_lp_add, false, false, true, true, 128, 63, 87, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_batu_lp, false, false, bubblePosX, bubblePosY, 75, 5);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_bikk_lp, false, false, bubblePosX2, bubblePosY2, 76, 7);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_chance_lp, false, false, bubblePosX3, bubblePosY3, 77, 9);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_jg_lp, false, false, bubblePosX4, bubblePosY4, 78, 11);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_hoh_lp, false, false, bubblePosX5, bubblePosY5, 79, 13);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_batu_add4, true, false, true, false, 0, 0, 60, 5);
				break;
			case 14:
				evt.eventStopDirectionBefore(mng, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0565, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr002_light_para, false, false, true, true, 128, 63, 86, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 80, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 81, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 82, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 83, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 84, 0);
				break;
			case 15:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01, false, false, 0, 0, 101, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0564, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1840, Sound.CH.VC0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0112, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_par_lp, false, false, false, true, 128, 63, 88, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_par_lp_add, false, false, true, true, 128, 63, 87, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_batu_lp, false, false, bubblePosX, bubblePosY, 75, 5);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_bikk_lp, false, false, bubblePosX2, bubblePosY2, 76, 7);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_chance_lp, false, false, bubblePosX3, bubblePosY3, 77, 9);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_bd_lp, false, false, bubblePosX4, bubblePosY4, 78, 11);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_bonus_lp, false, false, bubblePosX5, bubblePosY5, 79, 13);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_batu_add4, true, false, true, false, 0, 0, 60, 5);
				break;
			case 16:
				evt.eventStopDirectionBefore(mng, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0565, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr002_light_para, false, false, true, true, 128, 63, 86, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 80, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 81, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 82, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 83, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 84, 0);
				break;
			case 17:
				evt.eventStopSound(Sound.CH.BGM, 22);
				evt.eventPlaySound(DirectionManager.SOUND.S0566, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1842, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0402, Sound.CH.SE1, true, 1f, 22);
				evt.eventPlaySound(DirectionManager.SOUND.S1852, Sound.CH.VC1, true, 1f, 50);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_bd, false, false, false, false, 0, 0, 61, 15);
				evt.eventAddMovie(DirectionManager.MOVIE.kpr004_bd_loop, DirectionManager.MOVIE.kpr004_bd, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_light, true, false, true, false, 0, 0, 60, 12);
				break;
			case 18:
				evt.eventStopSound(Sound.CH.BGM, 22);
				evt.eventPlaySound(DirectionManager.SOUND.S0135, Sound.CH.BGM, true, 1f, 119);
				evt.eventPlaySound(DirectionManager.SOUND.S0566, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1842, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0401, Sound.CH.SE1, true, 1f, 22);
				evt.eventPlaySound(DirectionManager.SOUND.S1849, Sound.CH.VC1, true, 1f, 50);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_bonus, false, false, false, false, 0, 0, 61, 15);
				evt.eventAddMovie(DirectionManager.MOVIE.kpr004_bonus_loop, DirectionManager.MOVIE.kpr004_bonus, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_light, true, false, true, false, 0, 0, 60, 12);
				break;
			case 19:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01, false, false, 0, 0, 101, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0564, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1840, Sound.CH.VC0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0112, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_par_lp, false, false, false, true, 128, 63, 88, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_par_lp_add, false, false, true, true, 128, 63, 87, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_batu_lp, false, false, bubblePosX, bubblePosY, 75, 5);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_bikk_lp, false, false, bubblePosX2, bubblePosY2, 76, 7);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_cation_lp, false, false, bubblePosX3, bubblePosY3, 77, 9);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_jg_lp, false, false, bubblePosX4, bubblePosY4, 78, 11);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_hoh_lp, false, false, bubblePosX5, bubblePosY5, 79, 13);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_batu_add4, true, false, true, false, 0, 0, 60, 5);
				break;
			case 20:
				evt.eventStopDirectionBefore(mng, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0565, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr002_light_para, false, false, true, true, 128, 63, 86, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 80, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 81, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 82, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 83, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 84, 0);
				break;
			case 21:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01, false, false, 0, 0, 101, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0564, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1840, Sound.CH.VC0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0112, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_par_lp, false, false, false, true, 128, 63, 88, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_par_lp_add, false, false, true, true, 128, 63, 87, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_batu_lp, false, false, bubblePosX, bubblePosY, 75, 5);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_chance_lp, false, false, bubblePosX2, bubblePosY2, 76, 7);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_cation_lp, false, false, bubblePosX3, bubblePosY3, 77, 9);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_jg_lp, false, false, bubblePosX4, bubblePosY4, 78, 11);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_hoh_lp, false, false, bubblePosX5, bubblePosY5, 79, 13);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_batu_add4, true, false, true, false, 0, 0, 60, 5);
				break;
			case 22:
				evt.eventStopDirectionBefore(mng, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0565, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr002_light_para, false, false, true, true, 128, 63, 86, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 80, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 81, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 82, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 83, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 84, 0);
				break;
			case 23:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01, false, false, 0, 0, 101, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0564, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1840, Sound.CH.VC0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0112, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_par_lp, false, false, false, true, 128, 63, 88, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_par_lp_add, false, false, true, true, 128, 63, 87, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_batu_lp, false, false, bubblePosX, bubblePosY, 75, 5);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_cation_lp, false, false, bubblePosX2, bubblePosY2, 76, 7);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_jg_lp, false, false, bubblePosX3, bubblePosY3, 77, 9);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_hoh_lp, false, false, bubblePosX4, bubblePosY4, 78, 11);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_bd_lp, false, false, bubblePosX5, bubblePosY5, 79, 13);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_batu_add4, true, false, true, false, 0, 0, 60, 5);
				break;
			case 24:
				evt.eventStopDirectionBefore(mng, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0565, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr002_light_para, false, false, true, true, 128, 63, 86, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 80, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 81, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 82, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 83, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 84, 0);
				break;
			case 25:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01, false, false, 0, 0, 101, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0564, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1840, Sound.CH.VC0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0112, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_par_lp, false, false, false, true, 128, 63, 88, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_par_lp_add, false, false, true, true, 128, 63, 87, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_batu_lp, false, false, bubblePosX, bubblePosY, 75, 5);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_cation_lp, false, false, bubblePosX2, bubblePosY2, 76, 7);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_jg_lp, false, false, bubblePosX3, bubblePosY3, 77, 9);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_hoh_lp, false, false, bubblePosX4, bubblePosY4, 78, 11);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_bonus_lp, false, false, bubblePosX5, bubblePosY5, 79, 13);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_batu_add4, true, false, true, false, 0, 0, 60, 5);
				break;
			case 26:
				evt.eventStopDirectionBefore(mng, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0565, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr002_light_para, false, false, true, true, 128, 63, 86, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 80, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 81, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 82, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 83, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 84, 0);
				break;
			case 27:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01, false, false, 0, 0, 101, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0564, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1840, Sound.CH.VC0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0112, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_par_lp, false, false, false, true, 128, 63, 88, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_par_lp_add, false, false, true, true, 128, 63, 87, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_batu_lp, false, false, bubblePosX, bubblePosY, 75, 5);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_jg_lp, false, false, bubblePosX2, bubblePosY2, 76, 7);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_hoh_lp, false, false, bubblePosX3, bubblePosY3, 77, 9);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_bd_lp, false, false, bubblePosX4, bubblePosY4, 78, 11);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_bonus_lp, false, false, bubblePosX5, bubblePosY5, 79, 13);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_batu_add4, true, false, true, false, 0, 0, 60, 5);
				break;
			case 28:
				evt.eventStopDirectionBefore(mng, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0565, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr002_light_para, false, false, true, true, 128, 63, 86, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 80, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 81, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 82, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 83, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 84, 0);
				break;
			case 29:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01, false, false, 0, 0, 101, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0564, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1841, Sound.CH.VC0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0195, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_bon, false, false, false, true, 83, 35, 89, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_par_lp, false, false, false, true, 128, 63, 88, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_par_lp_add, false, false, true, true, 128, 63, 87, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_bikk_lp, false, false, bubblePosX, bubblePosY, 75, 5);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_chance_lp, false, false, bubblePosX2, bubblePosY2, 76, 7);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_cation_lp, false, false, bubblePosX3, bubblePosY3, 77, 9);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_jg_lp, false, false, bubblePosX4, bubblePosY4, 78, 11);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_hoh_lp, false, false, bubblePosX5, bubblePosY5, 79, 13);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_batu_add4, true, false, true, false, 0, 0, 60, 5);
				break;
			case 30:
				evt.eventStopDirectionBefore(mng, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0565, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr002_light_para, false, false, true, true, 128, 63, 86, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 80, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 81, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 82, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 83, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 84, 0);
				break;
			case 31:
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 158);
				evt.eventPlaySound(DirectionManager.SOUND.S0566, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1842, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0352, Sound.CH.SE1, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0210, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S1845, Sound.CH.VC1, true, 1f, 45);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_b_bony, false, false, false, false, 0, 0, 61, 15);
				evt.eventAddMovie(DirectionManager.MOVIE.kpr004_b_bony_loop, DirectionManager.MOVIE.kpr004_b_bony, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_light, true, false, true, false, 0, 0, 60, 12);
				break;
			case 32:
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 175);
				evt.eventPlaySound(DirectionManager.SOUND.S0566, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1842, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0353, Sound.CH.SE1, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0211, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S1847, Sound.CH.VC1, true, 1f, 45);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_chance_bony, false, false, false, false, 0, 0, 61, 15);
				evt.eventAddMovie(DirectionManager.MOVIE.kpr004_chance_bony_loop, DirectionManager.MOVIE.kpr004_chance_bony, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_light, true, false, true, false, 0, 0, 60, 12);
				break;
			case 33:
				evt.eventStopSound(Sound.CH.BGM, 21);
				evt.eventPlaySound(DirectionManager.SOUND.S0116, Sound.CH.BGM, true, 1f, 115);
				evt.eventPlaySound(DirectionManager.SOUND.S0566, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1842, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0353, Sound.CH.SE1, true, 1f, 21);
				evt.eventPlaySound(DirectionManager.SOUND.S0212, Sound.CH.SE0, true, 1f, 21);
				evt.eventPlaySound(DirectionManager.SOUND.S1853, Sound.CH.VC1, true, 1f, 45);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_cation_bony, false, false, false, false, 0, 0, 61, 15);
				evt.eventAddMovie(DirectionManager.MOVIE.kpr004_cation_bony_loop, DirectionManager.MOVIE.kpr004_cation_bony, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_light, true, false, true, false, 0, 0, 60, 12);
				break;
			case 34:
				evt.eventStopSound(Sound.CH.BGM, 22);
				evt.eventPlaySound(DirectionManager.SOUND.S0118, Sound.CH.BGM, true, 1f, 122);
				evt.eventPlaySound(DirectionManager.SOUND.S0566, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1842, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0400, Sound.CH.SE1, true, 1f, 22);
				evt.eventPlaySound(DirectionManager.SOUND.S1859, Sound.CH.VC1, true, 1f, 45);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_jg_bony, false, false, false, false, 0, 0, 61, 15);
				evt.eventAddMovie(DirectionManager.MOVIE.kpr004_jg_bony_loop, DirectionManager.MOVIE.kpr004_jg_bony, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_light, true, false, true, false, 0, 0, 60, 12);
				break;
			case 35:
				evt.eventStopSound(Sound.CH.BGM, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0117, Sound.CH.BGM, true, 1f, 85);
				evt.eventPlaySound(DirectionManager.SOUND.S0566, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1842, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0399, Sound.CH.SE1, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S1857, Sound.CH.VC1, true, 1f, 45);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_hoh_bony, false, false, false, false, 0, 0, 61, 15);
				evt.eventAddMovie(DirectionManager.MOVIE.kpr004_hoh_bony_loop, DirectionManager.MOVIE.kpr004_hoh_bony, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_light, true, false, true, false, 0, 0, 60, 12);
				break;
			case 36:
				evt.eventStopSound(Sound.CH.BGM, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0566, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1842, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0353, Sound.CH.SE1, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0215, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_cat_bony, false, false, false, false, 0, 0, 61, 15);
				evt.eventAddMovie(DirectionManager.MOVIE.kpr004_cat_bony_loop, DirectionManager.MOVIE.kpr004_cat_bony, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_light, true, false, true, false, 0, 0, 60, 12);
				break;
			case 37:
				evt.eventPlayMovie(DirectionManager.MOVIE.push_c, false, true, false, false, 0, 0, 52, 23);
				evt.eventSetCanPush(true, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_c_add, true, false, true, false, 0, 0, 51, 23);
				evt.eventPlaySound(DirectionManager.SOUND.S0223, Sound.CH.SE0, true, 1f, 23);
				break;
			case 38:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01, false, false, 0, 0, 101, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0564, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1841, Sound.CH.VC0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0195, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_bon, false, false, false, true, 83, 35, 89, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_par_lp, false, false, false, true, 128, 63, 88, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_par_lp_add, false, false, true, true, 128, 63, 87, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_bikk_lp, false, false, bubblePosX, bubblePosY, 75, 5);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_chance_lp, false, false, bubblePosX2, bubblePosY2, 76, 7);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_jg_lp, false, false, bubblePosX3, bubblePosY3, 77, 9);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_hoh_lp, false, false, bubblePosX4, bubblePosY4, 78, 11);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_bd_lp, false, false, bubblePosX5, bubblePosY5, 79, 13);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_batu_add4, true, false, true, false, 0, 0, 60, 5);
				break;
			case 39:
				evt.eventStopDirectionBefore(mng, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0565, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr002_light_para, false, false, true, true, 128, 63, 86, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 80, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 81, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 82, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 83, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 84, 0);
				break;
			case 40:
				evt.eventStopSound(Sound.CH.BGM, 22);
				evt.eventPlaySound(DirectionManager.SOUND.S0566, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1842, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0402, Sound.CH.SE1, true, 1f, 22);
				evt.eventPlaySound(DirectionManager.SOUND.S1852, Sound.CH.VC1, true, 1f, 50);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_bd_bony, false, false, false, false, 0, 0, 61, 15);
				evt.eventAddMovie(DirectionManager.MOVIE.kpr004_bd_bony_loop, DirectionManager.MOVIE.kpr004_bd_bony, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_light, true, false, true, false, 0, 0, 60, 12);
				break;
			case 41:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01, false, false, 0, 0, 101, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0564, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1841, Sound.CH.VC0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0195, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_bon, false, false, false, true, 83, 35, 89, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_par_lp, false, false, false, true, 128, 63, 88, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_par_lp_add, false, false, true, true, 128, 63, 87, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_bikk_lp, false, false, bubblePosX, bubblePosY, 75, 5);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_chance_lp, false, false, bubblePosX2, bubblePosY2, 76, 7);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_jg_lp, false, false, bubblePosX3, bubblePosY3, 77, 9);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_hoh_lp, false, false, bubblePosX4, bubblePosY4, 78, 11);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_bonus_lp, false, false, bubblePosX5, bubblePosY5, 79, 13);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_batu_add4, true, false, true, false, 0, 0, 60, 5);
				break;
			case 42:
				evt.eventStopDirectionBefore(mng, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0565, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr002_light_para, false, false, true, true, 128, 63, 86, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 80, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 81, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 82, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 83, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 84, 0);
				break;
			case 43:
				evt.eventStopSound(Sound.CH.BGM, 22);
				evt.eventPlaySound(DirectionManager.SOUND.S0135, Sound.CH.BGM, true, 1f, 119);
				evt.eventPlaySound(DirectionManager.SOUND.S0566, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1842, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0401, Sound.CH.SE1, true, 1f, 22);
				evt.eventPlaySound(DirectionManager.SOUND.S1849, Sound.CH.VC1, true, 1f, 50);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_bonus_bony, false, false, false, false, 0, 0, 61, 15);
				evt.eventAddMovie(DirectionManager.MOVIE.kpr004_bonus_bony_loop, DirectionManager.MOVIE.kpr004_bonus_bony, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_light, true, false, true, false, 0, 0, 60, 12);
				break;
			case 44:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01, false, false, 0, 0, 101, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0564, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1841, Sound.CH.VC0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0195, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_bon, false, false, false, true, 83, 35, 89, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_par_lp, false, false, false, true, 128, 63, 88, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_par_lp_add, false, false, true, true, 128, 63, 87, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_bikk_lp, false, false, bubblePosX, bubblePosY, 75, 5);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_cation_lp, false, false, bubblePosX2, bubblePosY2, 76, 7);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_jg_lp, false, false, bubblePosX3, bubblePosY3, 77, 9);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_hoh_lp, false, false, bubblePosX4, bubblePosY4, 78, 11);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_bd_lp, false, false, bubblePosX5, bubblePosY5, 79, 13);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_batu_add4, true, false, true, false, 0, 0, 60, 5);
				break;
			case 45:
				evt.eventStopDirectionBefore(mng, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0565, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr002_light_para, false, false, true, true, 128, 63, 86, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 80, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 81, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 82, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 83, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 84, 0);
				break;
			case 46:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01, false, false, 0, 0, 101, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0564, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1841, Sound.CH.VC0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0195, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_bon, false, false, false, true, 83, 35, 89, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_par_lp, false, false, false, true, 128, 63, 88, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_par_lp_add, false, false, true, true, 128, 63, 87, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_bikk_lp, false, false, bubblePosX, bubblePosY, 75, 5);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_cation_lp, false, false, bubblePosX2, bubblePosY2, 76, 7);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_jg_lp, false, false, bubblePosX3, bubblePosY3, 77, 9);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_hoh_lp, false, false, bubblePosX4, bubblePosY4, 78, 11);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_bonus_lp, false, false, bubblePosX5, bubblePosY5, 79, 13);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_batu_add4, true, false, true, false, 0, 0, 60, 5);
				break;
			case 47:
				evt.eventStopDirectionBefore(mng, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0565, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr002_light_para, false, false, true, true, 128, 63, 86, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 80, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 81, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 82, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 83, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 84, 0);
				break;
			case 48:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01, false, false, 0, 0, 101, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0564, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1841, Sound.CH.VC0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0195, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_bon, false, false, false, true, 83, 35, 89, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_par_lp, false, false, false, true, 128, 63, 88, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_par_lp_add, false, false, true, true, 128, 63, 87, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_bikk_lp, false, false, bubblePosX, bubblePosY, 75, 5);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_jg_lp, false, false, bubblePosX2, bubblePosY2, 76, 7);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_hoh_lp, false, false, bubblePosX3, bubblePosY3, 77, 9);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_bd_lp, false, false, bubblePosX4, bubblePosY4, 78, 11);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_bonus_lp, false, false, bubblePosX5, bubblePosY5, 79, 13);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_batu_add4, true, false, true, false, 0, 0, 60, 5);
				break;
			case 49:
				evt.eventStopDirectionBefore(mng, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0565, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr002_light_para, false, false, true, true, 128, 63, 86, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 80, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 81, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 82, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 83, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 84, 0);
				break;
			case 50:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01, false, false, 0, 0, 101, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0564, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1841, Sound.CH.VC0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0195, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_bon, false, false, false, true, 83, 35, 89, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_par_lp, false, false, false, true, 128, 63, 88, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_par_lp_add, false, false, true, true, 128, 63, 87, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_chance_lp, false, false, bubblePosX, bubblePosY, 75, 5);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_cation_lp, false, false, bubblePosX2, bubblePosY2, 76, 7);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_jg_lp, false, false, bubblePosX3, bubblePosY3, 77, 9);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_hoh_lp, false, false, bubblePosX4, bubblePosY4, 78, 11);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_bd_lp, false, false, bubblePosX5, bubblePosY5, 79, 13);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_batu_add4, true, false, true, false, 0, 0, 60, 5);
				break;
			case 51:
				evt.eventStopDirectionBefore(mng, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0565, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr002_light_para, false, false, true, true, 128, 63, 86, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 80, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 81, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 82, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 83, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 84, 0);
				break;
			case 52:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01, false, false, 0, 0, 101, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0564, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1841, Sound.CH.VC0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0195, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_bon, false, false, false, true, 83, 35, 89, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_par_lp, false, false, false, true, 128, 63, 88, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_par_lp_add, false, false, true, true, 128, 63, 87, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_chance_lp, false, false, bubblePosX, bubblePosY, 75, 5);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_cation_lp, false, false, bubblePosX2, bubblePosY2, 76, 7);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_jg_lp, false, false, bubblePosX3, bubblePosY3, 77, 9);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_hoh_lp, false, false, bubblePosX4, bubblePosY4, 78, 11);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_bonus_lp, false, false, bubblePosX5, bubblePosY5, 79, 13);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_batu_add4, true, false, true, false, 0, 0, 60, 5);
				break;
			case 53:
				evt.eventStopDirectionBefore(mng, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0565, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr002_light_para, false, false, true, true, 128, 63, 86, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 80, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 81, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 82, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 83, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 84, 0);
				break;
			case 54:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01, false, false, 0, 0, 101, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0564, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1841, Sound.CH.VC0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0195, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_bon, false, false, false, true, 83, 35, 89, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_par_lp, false, false, false, true, 128, 63, 88, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_par_lp_add, false, false, true, true, 128, 63, 87, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_chance_lp, false, false, bubblePosX, bubblePosY, 75, 5);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_jg_lp, false, false, bubblePosX2, bubblePosY2, 76, 7);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_hoh_lp, false, false, bubblePosX3, bubblePosY3, 77, 9);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_bd_lp, false, false, bubblePosX4, bubblePosY4, 78, 11);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_bonus_lp, false, false, bubblePosX5, bubblePosY5, 79, 13);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_batu_add4, true, false, true, false, 0, 0, 60, 5);
				break;
			case 55:
				evt.eventStopDirectionBefore(mng, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0565, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr002_light_para, false, false, true, true, 128, 63, 86, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 80, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 81, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 82, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 83, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 84, 0);
				break;
			case 56:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01, false, false, 0, 0, 101, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0564, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1841, Sound.CH.VC0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0195, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_bon, false, false, false, true, 83, 35, 89, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_par_lp, false, false, false, true, 128, 63, 88, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_par_lp_add, false, false, true, true, 128, 63, 87, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_cation_lp, false, false, bubblePosX, bubblePosY, 75, 5);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_jg_lp, false, false, bubblePosX2, bubblePosY2, 76, 7);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_hoh_lp, false, false, bubblePosX3, bubblePosY3, 77, 9);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_bd_lp, false, false, bubblePosX4, bubblePosY4, 78, 11);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_bonus_lp, false, false, bubblePosX5, bubblePosY5, 79, 13);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_batu_add4, true, false, true, false, 0, 0, 60, 5);
				break;
			case 57:
				evt.eventStopDirectionBefore(mng, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0565, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr002_light_para, false, false, true, true, 128, 63, 86, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 80, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 81, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 82, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 83, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 84, 0);
				break;
			case 58:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01, false, false, 0, 0, 101, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0564, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1841, Sound.CH.VC0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0195, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_bon, false, false, false, true, 83, 35, 89, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_par_lp, false, false, false, true, 128, 63, 88, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_par_lp_add, false, false, true, true, 128, 63, 87, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_jg_lp, false, false, bubblePosX, bubblePosY, 75, 5);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_hoh_lp, false, false, bubblePosX2, bubblePosY2, 76, 7);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_jg_lp, false, false, bubblePosX3, bubblePosY3, 77, 9);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_hoh_lp, false, false, bubblePosX4, bubblePosY4, 78, 11);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_bd_lp, false, false, bubblePosX5, bubblePosY5, 79, 13);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_batu_add4, true, false, true, false, 0, 0, 60, 5);
				break;
			case 59:
				evt.eventStopDirectionBefore(mng, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0565, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr002_light_para, false, false, true, true, 128, 63, 86, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 80, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 81, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 82, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 83, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 84, 0);
				break;
			case 60:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01, false, false, 0, 0, 101, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0564, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0567, Sound.CH.SE1, true, 1f, 16);
				evt.eventPlaySound(DirectionManager.SOUND.S1841, Sound.CH.VC0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0195, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_bon, false, false, false, true, 83, 35, 89, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_par_lp, false, false, false, true, 128, 63, 88, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_par_lp_add, false, false, true, true, 128, 63, 87, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_jg_lp, false, false, bubblePosX, bubblePosY, 75, 5);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_jg_lp, false, false, bubblePosX2, bubblePosY2, 76, 7);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_jg_lp, false, false, bubblePosX3, bubblePosY3, 77, 9);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_jg_lp, false, false, bubblePosX4, bubblePosY4, 78, 11);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_jg_lp, false, false, bubblePosX5, bubblePosY5, 79, 13);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_batu_add4, true, false, true, false, 0, 0, 60, 5);
				break;
			case 61:
				evt.eventStopDirectionBefore(mng, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0565, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr002_light_para, false, false, true, true, 128, 63, 86, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 80, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 81, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 82, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 83, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 84, 0);
				break;
			case 62:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01, false, false, 0, 0, 101, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0564, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0567, Sound.CH.SE1, true, 1f, 16);
				evt.eventPlaySound(DirectionManager.SOUND.S1841, Sound.CH.VC0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0195, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_bon, false, false, false, true, 83, 35, 89, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_par_lp, false, false, false, true, 128, 63, 88, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_par_lp_add, false, false, true, true, 128, 63, 87, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_hoh_lp, false, false, bubblePosX, bubblePosY, 75, 5);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_hoh_lp, false, false, bubblePosX2, bubblePosY2, 76, 7);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_hoh_lp, false, false, bubblePosX3, bubblePosY3, 77, 9);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_hoh_lp, false, false, bubblePosX4, bubblePosY4, 78, 11);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_hoh_lp, false, false, bubblePosX5, bubblePosY5, 79, 13);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_batu_add4, true, false, true, false, 0, 0, 60, 5);
				break;
			case 63:
				evt.eventStopDirectionBefore(mng, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0565, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr002_light_para, false, false, true, true, 128, 63, 86, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 80, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 81, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 82, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 83, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 84, 0);
				break;
			case 64:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01, false, false, 0, 0, 101, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0564, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0567, Sound.CH.SE1, true, 1f, 16);
				evt.eventPlaySound(DirectionManager.SOUND.S1841, Sound.CH.VC0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0195, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_bon, false, false, false, true, 83, 35, 89, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_par_lp, false, false, false, true, 128, 63, 88, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_par_lp_add, false, false, true, true, 128, 63, 87, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_bd_lp, false, false, bubblePosX, bubblePosY, 75, 5);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_bd_lp, false, false, bubblePosX2, bubblePosY2, 76, 7);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_bd_lp, false, false, bubblePosX3, bubblePosY3, 77, 9);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_bd_lp, false, false, bubblePosX4, bubblePosY4, 78, 11);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_bd_lp, false, false, bubblePosX5, bubblePosY5, 79, 13);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_batu_add4, true, false, true, false, 0, 0, 60, 5);
				break;
			case 65:
				evt.eventStopDirectionBefore(mng, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0565, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr002_light_para, false, false, true, true, 128, 63, 86, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 80, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 81, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 82, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 83, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 84, 0);
				break;
			case 66:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01, false, false, 0, 0, 101, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0564, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0567, Sound.CH.SE1, true, 1f, 16);
				evt.eventPlaySound(DirectionManager.SOUND.S1841, Sound.CH.VC0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0195, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_bon, false, false, false, true, 83, 35, 89, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_par_lp, false, false, false, true, 128, 63, 88, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_par_lp_add, false, false, true, true, 128, 63, 87, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_bonus_lp, false, false, bubblePosX, bubblePosY, 75, 5);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_bonus_lp, false, false, bubblePosX2, bubblePosY2, 76, 7);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_bonus_lp, false, false, bubblePosX3, bubblePosY3, 77, 9);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_bonus_lp, false, false, bubblePosX4, bubblePosY4, 78, 11);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_bonus_lp, false, false, bubblePosX5, bubblePosY5, 79, 13);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_batu_add4, true, false, true, false, 0, 0, 60, 5);
				break;
			case 67:
				evt.eventStopDirectionBefore(mng, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0565, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr002_light_para, false, false, true, true, 128, 63, 86, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 80, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 81, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 82, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 83, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 84, 0);
				break;
			case 68:
				evt.eventDisableBefore(mng, 0);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 158);
				evt.eventPlaySound(DirectionManager.SOUND.S0566, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1842, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0352, Sound.CH.SE1, true, 1f, 22);
				evt.eventPlaySound(DirectionManager.SOUND.S0210, Sound.CH.SE0, true, 1f, 22);
				evt.eventPlaySound(DirectionManager.SOUND.S1843, Sound.CH.VC1, true, 1f, 45);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_a, false, false, false, false, 0, 0, 61, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kpr004_a_loop, DirectionManager.MOVIE.kpr004_a, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_light, true, false, true, false, 0, 0, 60, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_c_hit, false, false, false, true, 128, 74, 52, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_c_hit_add, false, false, true, false, 0, 0, 51, 0);
				break;
			case 69:
				evt.eventDisableBefore(mng, 0);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 158);
				evt.eventPlaySound(DirectionManager.SOUND.S0566, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1842, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0352, Sound.CH.SE1, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0210, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S1845, Sound.CH.VC1, true, 1f, 45);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_b, false, false, false, false, 0, 0, 61, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kpr004_b_loop, DirectionManager.MOVIE.kpr004_b, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_light, true, false, true, false, 0, 0, 60, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_c_hit, false, false, false, true, 128, 74, 52, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_c_hit_add, false, false, true, false, 0, 0, 51, 0);
				break;
			case 70:
				evt.eventDisableBefore(mng, 0);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 175);
				evt.eventPlaySound(DirectionManager.SOUND.S0566, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1842, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0353, Sound.CH.SE1, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0211, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S1847, Sound.CH.VC1, true, 1f, 45);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_chance, false, false, false, false, 0, 0, 61, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kpr004_chance_loop, DirectionManager.MOVIE.kpr004_chance, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_light, true, false, true, false, 0, 0, 60, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_c_hit, false, false, false, true, 128, 74, 52, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_c_hit_add, false, false, true, false, 0, 0, 51, 0);
				break;
			case 71:
				evt.eventDisableBefore(mng, 0);
				evt.eventStopSound(Sound.CH.BGM, 21);
				evt.eventPlaySound(DirectionManager.SOUND.S0116, Sound.CH.BGM, true, 1f, 115);
				evt.eventPlaySound(DirectionManager.SOUND.S0566, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1842, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0353, Sound.CH.SE1, true, 1f, 21);
				evt.eventPlaySound(DirectionManager.SOUND.S0212, Sound.CH.SE0, true, 1f, 21);
				evt.eventPlaySound(DirectionManager.SOUND.S1853, Sound.CH.VC1, true, 1f, 45);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_cation, false, false, false, false, 0, 0, 61, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kpr004_cation_loop, DirectionManager.MOVIE.kpr004_cation, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_light, true, false, true, false, 0, 0, 60, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_c_hit, false, false, false, true, 128, 74, 52, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_c_hit_add, false, false, true, false, 0, 0, 51, 0);
				break;
			case 72:
				evt.eventDisableBefore(mng, 0);
				evt.eventStopSound(Sound.CH.BGM, 22);
				evt.eventPlaySound(DirectionManager.SOUND.S0118, Sound.CH.BGM, true, 1f, 122);
				evt.eventPlaySound(DirectionManager.SOUND.S0566, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1842, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0400, Sound.CH.SE1, true, 1f, 22);
				evt.eventPlaySound(DirectionManager.SOUND.S1859, Sound.CH.VC1, true, 1f, 45);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_jg, false, false, false, false, 0, 0, 61, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kpr004_jg_loop, DirectionManager.MOVIE.kpr004_jg, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_light, true, false, true, false, 0, 0, 60, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_c_hit, false, false, false, true, 128, 74, 52, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_c_hit_add, false, false, true, false, 0, 0, 51, 0);
				break;
			case 73:
				evt.eventDisableBefore(mng, 0);
				evt.eventStopSound(Sound.CH.BGM, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0117, Sound.CH.BGM, true, 1f, 85);
				evt.eventPlaySound(DirectionManager.SOUND.S0566, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1842, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0399, Sound.CH.SE1, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S1857, Sound.CH.VC1, true, 1f, 45);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_hoh, false, false, false, false, 0, 0, 61, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kpr004_hoh_loop, DirectionManager.MOVIE.kpr004_hoh, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_light, true, false, true, false, 0, 0, 60, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_c_hit, false, false, false, true, 128, 74, 52, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_c_hit_add, false, false, true, false, 0, 0, 51, 0);
				break;
			case 74:
				evt.eventDisableBefore(mng, 0);
				evt.eventStopSound(Sound.CH.BGM, 22);
				evt.eventPlaySound(DirectionManager.SOUND.S0566, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1842, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0402, Sound.CH.SE1, true, 1f, 22);
				evt.eventPlaySound(DirectionManager.SOUND.S1852, Sound.CH.VC1, true, 1f, 50);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_bd, false, false, false, false, 0, 0, 61, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kpr004_bd_loop, DirectionManager.MOVIE.kpr004_bd, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_light, true, false, true, false, 0, 0, 60, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_c_hit, false, false, false, true, 128, 74, 52, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_c_hit_add, false, false, true, false, 0, 0, 51, 0);
				break;
			case 75:
				evt.eventDisableBefore(mng, 0);
				evt.eventStopSound(Sound.CH.BGM, 22);
				evt.eventPlaySound(DirectionManager.SOUND.S0135, Sound.CH.BGM, true, 1f, 119);
				evt.eventPlaySound(DirectionManager.SOUND.S0566, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1842, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0401, Sound.CH.SE1, true, 1f, 22);
				evt.eventPlaySound(DirectionManager.SOUND.S1849, Sound.CH.VC1, true, 1f, 50);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_bonus, false, false, false, false, 0, 0, 61, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kpr004_bonus_loop, DirectionManager.MOVIE.kpr004_bonus, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_light, true, false, true, false, 0, 0, 60, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_c_hit, false, false, false, true, 128, 74, 52, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_c_hit_add, false, false, true, false, 0, 0, 51, 0);
				break;
			case 76:
				evt.eventDisableBefore(mng, 0);
				evt.eventStopSound(Sound.CH.BGM, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0566, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1842, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0353, Sound.CH.SE1, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0215, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_cat, false, false, false, false, 0, 0, 61, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kpr004_cat_loop, DirectionManager.MOVIE.kpr004_cat, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_light, true, false, true, false, 0, 0, 60, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_c_hit, false, false, false, true, 128, 74, 52, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_c_hit_add, false, false, true, false, 0, 0, 51, 0);
				break;
			case 77:
				evt.eventDisableBefore(mng, 0);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 158);
				evt.eventPlaySound(DirectionManager.SOUND.S0566, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1842, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0352, Sound.CH.SE1, true, 1f, 22);
				evt.eventPlaySound(DirectionManager.SOUND.S0210, Sound.CH.SE0, true, 1f, 22);
				evt.eventPlaySound(DirectionManager.SOUND.S1843, Sound.CH.VC1, true, 1f, 45);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_a_bony, false, false, false, false, 0, 0, 61, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kpr004_a_bony_loop, DirectionManager.MOVIE.kpr004_a_bony, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_light, true, false, true, false, 0, 0, 60, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_c_hit, false, false, false, true, 128, 74, 52, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_c_hit_add, false, false, true, false, 0, 0, 51, 0);
				break;
			case 78:
				evt.eventDisableBefore(mng, 0);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 158);
				evt.eventPlaySound(DirectionManager.SOUND.S0566, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1842, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0352, Sound.CH.SE1, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0210, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S1845, Sound.CH.VC1, true, 1f, 45);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_b_bony, false, false, false, false, 0, 0, 61, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kpr004_b_bony_loop, DirectionManager.MOVIE.kpr004_b_bony, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_light, true, false, true, false, 0, 0, 60, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_c_hit, false, false, false, true, 128, 74, 52, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_c_hit_add, false, false, true, false, 0, 0, 51, 0);
				break;
			case 79:
				evt.eventDisableBefore(mng, 0);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 175);
				evt.eventPlaySound(DirectionManager.SOUND.S0566, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1842, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0353, Sound.CH.SE1, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0211, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S1847, Sound.CH.VC1, true, 1f, 45);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_chance_bony, false, false, false, false, 0, 0, 61, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kpr004_chance_bony_loop, DirectionManager.MOVIE.kpr004_chance_bony, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_light, true, false, true, false, 0, 0, 60, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_c_hit, false, false, false, true, 128, 74, 52, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_c_hit_add, false, false, true, false, 0, 0, 51, 0);
				break;
			case 80:
				evt.eventDisableBefore(mng, 0);
				evt.eventStopSound(Sound.CH.BGM, 21);
				evt.eventPlaySound(DirectionManager.SOUND.S0116, Sound.CH.BGM, true, 1f, 115);
				evt.eventPlaySound(DirectionManager.SOUND.S0566, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1842, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0353, Sound.CH.SE1, true, 1f, 21);
				evt.eventPlaySound(DirectionManager.SOUND.S0212, Sound.CH.SE0, true, 1f, 21);
				evt.eventPlaySound(DirectionManager.SOUND.S1853, Sound.CH.VC1, true, 1f, 45);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_cation_bony, false, false, false, false, 0, 0, 61, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kpr004_cation_bony_loop, DirectionManager.MOVIE.kpr004_cation_bony, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_light, true, false, true, false, 0, 0, 60, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_c_hit, false, false, false, true, 128, 74, 52, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_c_hit_add, false, false, true, false, 0, 0, 51, 0);
				break;
			case 81:
				evt.eventDisableBefore(mng, 0);
				evt.eventStopSound(Sound.CH.BGM, 22);
				evt.eventPlaySound(DirectionManager.SOUND.S0118, Sound.CH.BGM, true, 1f, 122);
				evt.eventPlaySound(DirectionManager.SOUND.S0566, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1842, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0400, Sound.CH.SE1, true, 1f, 22);
				evt.eventPlaySound(DirectionManager.SOUND.S1859, Sound.CH.VC1, true, 1f, 45);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_jg_bony, false, false, false, false, 0, 0, 61, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kpr004_jg_bony_loop, DirectionManager.MOVIE.kpr004_jg_bony, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_light, true, false, true, false, 0, 0, 60, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_c_hit, false, false, false, true, 128, 74, 52, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_c_hit_add, false, false, true, false, 0, 0, 51, 0);
				break;
			case 82:
				evt.eventDisableBefore(mng, 0);
				evt.eventStopSound(Sound.CH.BGM, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0117, Sound.CH.BGM, true, 1f, 85);
				evt.eventPlaySound(DirectionManager.SOUND.S0566, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1842, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0399, Sound.CH.SE1, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S1857, Sound.CH.VC1, true, 1f, 45);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_hoh_bony, false, false, false, false, 0, 0, 61, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kpr004_hoh_bony_loop, DirectionManager.MOVIE.kpr004_hoh_bony, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_light, true, false, true, false, 0, 0, 60, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_c_hit, false, false, false, true, 128, 74, 52, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_c_hit_add, false, false, true, false, 0, 0, 51, 0);
				break;
			case 83:
				evt.eventDisableBefore(mng, 0);
				evt.eventStopSound(Sound.CH.BGM, 22);
				evt.eventPlaySound(DirectionManager.SOUND.S0566, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1842, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0402, Sound.CH.SE1, true, 1f, 22);
				evt.eventPlaySound(DirectionManager.SOUND.S1852, Sound.CH.VC1, true, 1f, 50);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_bd_bony, false, false, false, false, 0, 0, 61, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kpr004_bd_bony_loop, DirectionManager.MOVIE.kpr004_bd_bony, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_light, true, false, true, false, 0, 0, 60, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_c_hit, false, false, false, true, 128, 74, 52, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_c_hit_add, false, false, true, false, 0, 0, 51, 0);
				break;
			case 84:
				evt.eventDisableBefore(mng, 0);
				evt.eventStopSound(Sound.CH.BGM, 22);
				evt.eventPlaySound(DirectionManager.SOUND.S0135, Sound.CH.BGM, true, 1f, 119);
				evt.eventPlaySound(DirectionManager.SOUND.S0566, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1842, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0401, Sound.CH.SE1, true, 1f, 22);
				evt.eventPlaySound(DirectionManager.SOUND.S1849, Sound.CH.VC1, true, 1f, 50);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_bonus_bony, false, false, false, false, 0, 0, 61, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kpr004_bonus_bony_loop, DirectionManager.MOVIE.kpr004_bonus_bony, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_light, true, false, true, false, 0, 0, 60, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_c_hit, false, false, false, true, 128, 74, 52, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_c_hit_add, false, false, true, false, 0, 0, 51, 0);
				break;
			case 85:
				evt.eventDisableBefore(mng, 0);
				evt.eventStopSound(Sound.CH.BGM, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0566, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1842, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0353, Sound.CH.SE1, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0215, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_cat_bony, false, false, false, false, 0, 0, 61, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kpr004_cat_bony_loop, DirectionManager.MOVIE.kpr004_cat_bony, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_light, true, false, true, false, 0, 0, 60, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_c_hit, false, false, false, true, 128, 74, 52, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_c_hit_add, false, false, true, false, 0, 0, 51, 0);
				break;
			case 86:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01, false, false, 0, 0, 101, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0564, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1840, Sound.CH.VC0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0112, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_par_lp, false, false, false, true, 128, 63, 88, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_par_lp_add, false, false, true, true, 128, 63, 87, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_batu_lp, false, false, bubblePosX, bubblePosY, 75, 5);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_push_lp, false, false, bubblePosX2, bubblePosY2, 76, 7);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_chance_lp, false, false, bubblePosX3, bubblePosY3, 77, 9);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_hoh_lp, false, false, bubblePosX4, bubblePosY4, 78, 11);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_bonus_lp, false, false, bubblePosX5, bubblePosY5, 79, 13);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_batu_add4, true, false, true, false, 0, 0, 60, 5);
				break;
			case 87:
				evt.eventStopDirectionBefore(mng, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0565, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr002_light_para, false, false, true, true, 128, 63, 86, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 80, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 81, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 82, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 83, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 84, 0);
				break;
			case 88:
				evt.eventPlaySound(DirectionManager.SOUND.S0566, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0566, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0353, Sound.CH.SE1, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S1860, Sound.CH.VC1, true, 1f, 45);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_push, false, false, false, false, 0, 0, 61, 15);
				evt.eventAddMovie(DirectionManager.MOVIE.kpr004_push_loop, DirectionManager.MOVIE.kpr004_push, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_light, true, false, true, false, 0, 0, 60, 12);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, true, 128, 119, 52, 23);
				evt.eventSetCanPush(true, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, true);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_add, true, false, true, false, 0, 0, 51, 23);
				evt.eventPlaySound(DirectionManager.SOUND.S0223, Sound.CH.SE0, true, 1f, 23);
				break;
			case 89:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01, false, false, 0, 0, 101, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0564, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1840, Sound.CH.VC0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0112, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_par_lp, false, false, false, true, 128, 63, 88, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_par_lp_add, false, false, true, true, 128, 63, 87, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_bikk_lp, false, false, bubblePosX, bubblePosY, 75, 5);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_push_lp, false, false, bubblePosX2, bubblePosY2, 76, 7);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_chance_lp, false, false, bubblePosX3, bubblePosY3, 77, 9);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_hoh_lp, false, false, bubblePosX4, bubblePosY4, 78, 11);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_bonus_lp, false, false, bubblePosX5, bubblePosY5, 79, 13);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_batu_add4, true, false, true, false, 0, 0, 60, 5);
				break;
			case 90:
				evt.eventStopDirectionBefore(mng, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0565, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr002_light_para, false, false, true, true, 128, 63, 86, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 80, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 81, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 82, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 83, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 84, 0);
				break;
			case 91:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01, false, false, 0, 0, 101, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0564, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1841, Sound.CH.VC0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0195, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_bon, false, false, false, true, 83, 35, 89, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_par_lp, false, false, false, true, 128, 63, 88, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_par_lp_add, false, false, true, true, 128, 63, 87, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_hoh_lp, false, false, bubblePosX, bubblePosY, 75, 5);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_push_lp, false, false, bubblePosX2, bubblePosY2, 76, 7);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_hoh_lp, false, false, bubblePosX3, bubblePosY3, 77, 9);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_push_lp, false, false, bubblePosX4, bubblePosY4, 78, 11);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_bonus_lp, false, false, bubblePosX5, bubblePosY5, 79, 13);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_batu_add4, true, false, true, false, 0, 0, 60, 5);
				break;
			case 92:
				evt.eventStopDirectionBefore(mng, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0565, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr002_light_para, false, false, true, true, 128, 63, 86, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 80, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 81, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 82, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 83, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 84, 0);
				break;
			case 93:
				evt.eventPlaySound(DirectionManager.SOUND.S0566, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0566, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0353, Sound.CH.SE1, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S1860, Sound.CH.VC1, true, 1f, 45);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_push_bony, false, false, false, false, 0, 0, 61, 15);
				evt.eventAddMovie(DirectionManager.MOVIE.kpr004_push_bony_loop, DirectionManager.MOVIE.kpr004_push_bony, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr004_light, true, false, true, false, 0, 0, 60, 12);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, true, 128, 119, 52, 23);
				evt.eventSetCanPush(true, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, true);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_add, true, false, true, false, 0, 0, 51, 23);
				evt.eventPlaySound(DirectionManager.SOUND.S0223, Sound.CH.SE0, true, 1f, 23);
				break;
			case 94:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01, false, false, 0, 0, 101, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0564, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0567, Sound.CH.SE1, true, 1f, 16);
				evt.eventPlaySound(DirectionManager.SOUND.S1841, Sound.CH.VC0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0195, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_bon, false, false, false, true, 83, 35, 89, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_par_lp, false, false, false, true, 128, 63, 88, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_par_lp_add, false, false, true, true, 128, 63, 87, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_push_lp, false, false, bubblePosX, bubblePosY, 75, 5);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_push_lp, false, false, bubblePosX2, bubblePosY2, 76, 7);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_push_lp, false, false, bubblePosX3, bubblePosY3, 77, 9);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_push_lp, false, false, bubblePosX4, bubblePosY4, 78, 11);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr001_a01_push_lp, false, false, bubblePosX5, bubblePosY5, 79, 13);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr001_a01_batu_add4, true, false, true, false, 0, 0, 60, 5);
				break;
			case 95:
				evt.eventStopDirectionBefore(mng, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0565, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kpr002_light_para, false, false, true, true, 128, 63, 86, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 80, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 81, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 82, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 83, 0);
				evt.eventPlayImage(DirectionManager.IMAGE.kpr003_light, false, false, 0, 0, 84, 0);
				break;
			case 96:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_10, false, false, true, false, 0, 0, 90, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_10_loop, DirectionManager.MOVIE.huc008_T_10, false, true, true, false);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0224, Sound.CH.SE0, false, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 52, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 51, 0);
				break;
			case 97:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_20, false, false, true, false, 0, 0, 90, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_20_loop, DirectionManager.MOVIE.huc008_T_20, false, true, true, false);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0225, Sound.CH.SE0, false, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 52, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 51, 0);
				break;
			case 98:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_30, false, false, true, false, 0, 0, 90, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_30_loop, DirectionManager.MOVIE.huc008_T_30, false, true, true, false);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0226, Sound.CH.SE0, false, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 52, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 51, 0);
				break;
			case 99:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_50, false, false, true, false, 0, 0, 90, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_50_loop, DirectionManager.MOVIE.huc008_T_50, false, true, true, false);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0227, Sound.CH.SE0, false, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 52, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 51, 0);
				break;
			case 100:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_100, false, false, true, false, 0, 0, 90, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_100_loop, DirectionManager.MOVIE.huc008_T_100, false, true, true, false);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0228, Sound.CH.SE0, false, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 52, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 51, 0);
				break;
			case 101:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_150, false, false, true, false, 0, 0, 90, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_150_loop, DirectionManager.MOVIE.huc008_T_150, false, true, true, false);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0229, Sound.CH.SE0, false, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 52, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 51, 0);
				break;
			case 102:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_200, false, false, true, false, 0, 0, 90, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_200_loop, DirectionManager.MOVIE.huc008_T_200, false, true, true, false);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0230, Sound.CH.SE0, false, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 52, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 51, 0);
				break;
			case 103:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_300, false, false, true, false, 0, 0, 90, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_300_loop, DirectionManager.MOVIE.huc008_T_300, false, true, true, false);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0231, Sound.CH.SE0, false, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 52, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 51, 0);
				break;
			case 104:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_50, false, false, true, false, 0, 0, 90, 72);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_50_loop, DirectionManager.MOVIE.huc008_T_50, false, true, true, false);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0065, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 72);
				evt.eventPlaySound(DirectionManager.SOUND.S0227, Sound.CH.SE0, false, 1f, 72);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1402();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1403();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1404();
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 52, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 51, 0);
				break;
			case 105:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_100, false, false, true, false, 0, 0, 90, 72);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_100_loop, DirectionManager.MOVIE.huc008_T_100, false, true, true, false);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0065, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 72);
				evt.eventPlaySound(DirectionManager.SOUND.S0228, Sound.CH.SE0, false, 1f, 72);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1402();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1403();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1404();
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 52, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 51, 0);
				break;
			case 106:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_150, false, false, true, false, 0, 0, 90, 72);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_150_loop, DirectionManager.MOVIE.huc008_T_150, false, true, true, false);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0065, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 72);
				evt.eventPlaySound(DirectionManager.SOUND.S0229, Sound.CH.SE0, false, 1f, 72);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1402();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1403();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1404();
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 52, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 51, 0);
				break;
			case 107:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_200, false, false, true, false, 0, 0, 90, 72);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_200_loop, DirectionManager.MOVIE.huc008_T_200, false, true, true, false);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0065, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 72);
				evt.eventPlaySound(DirectionManager.SOUND.S0230, Sound.CH.SE0, false, 1f, 72);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1402();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1403();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1404();
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 52, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 51, 0);
				break;
			case 108:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_300, false, false, true, false, 0, 0, 90, 72);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_300_loop, DirectionManager.MOVIE.huc008_T_300, false, true, true, false);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0065, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 72);
				evt.eventPlaySound(DirectionManager.SOUND.S0231, Sound.CH.SE0, false, 1f, 72);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1402();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1403();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1404();
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 52, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 51, 0);
				break;
			}
		}
		if (low == 0)
		{
			switch (mode)
			{
			}
		}
		base.start();
	}

	public override void end()
	{
		if (low == 0)
		{
			switch (mode)
			{
			case 1:
			case 10:
			case 13:
			case 15:
			case 19:
			case 21:
			case 23:
			case 25:
			case 27:
			case 29:
			case 38:
			case 41:
			case 44:
			case 46:
			case 48:
			case 50:
			case 52:
			case 54:
			case 56:
			case 58:
			case 60:
			case 62:
			case 64:
			case 66:
			case 86:
			case 89:
			case 91:
			case 94:
				kpr_killMovie(65f);
				kpr_killMovie(66f);
				kpr_killMovie(67f);
				kpr_killMovie(68f);
				kpr_killMovie(69f);
				kpr_killMovie(70f);
				kpr_killMovie(71f);
				kpr_killMovie(72f);
				kpr_killMovie(73f);
				kpr_killMovie(74f);
				kpr_killImage(75f);
				kpr_killImage(76f);
				kpr_killImage(77f);
				kpr_killImage(78f);
				kpr_killImage(79f);
				kpr_killImage(80f);
				kpr_killImage(81f);
				kpr_killImage(82f);
				kpr_killImage(83f);
				kpr_killImage(84f);
				kpr_killImage(90f);
				kpr_killImage(91f);
				kpr_killImage(92f);
				kpr_killImage(93f);
				kpr_killImage(94f);
				kpr_killMovie(95f);
				kpr_killMovie(96f);
				kpr_killMovie(97f);
				kpr_killMovie(98f);
				kpr_killMovie(99f);
				break;
			case 2:
			case 11:
			case 14:
			case 16:
			case 20:
			case 22:
			case 24:
			case 26:
			case 28:
			case 30:
			case 39:
			case 42:
			case 45:
			case 47:
			case 49:
			case 51:
			case 53:
			case 55:
			case 57:
			case 59:
			case 61:
			case 63:
			case 65:
			case 67:
			case 87:
			case 90:
			case 92:
			case 95:
				kpr_killMovie(65f);
				kpr_killMovie(66f);
				kpr_killMovie(67f);
				kpr_killMovie(68f);
				kpr_killMovie(69f);
				kpr_killMovie(70f);
				kpr_killMovie(71f);
				kpr_killMovie(72f);
				kpr_killMovie(73f);
				kpr_killMovie(74f);
				kpr_killImage(75f);
				kpr_killImage(76f);
				kpr_killImage(77f);
				kpr_killImage(78f);
				kpr_killImage(79f);
				kpr_killMovie(95f);
				kpr_killMovie(96f);
				kpr_killMovie(97f);
				kpr_killMovie(98f);
				kpr_killMovie(99f);
				break;
			case 3:
			case 4:
			case 5:
			case 6:
			case 7:
			case 8:
			case 9:
			case 12:
			case 17:
			case 18:
			case 31:
			case 32:
			case 33:
			case 34:
			case 35:
			case 36:
			case 37:
			case 40:
			case 43:
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
			case 88:
			case 93:
				kpr_killMovie(54f);
				kpr_killMovie(55f);
				kpr_killMovie(65f);
				kpr_killMovie(66f);
				kpr_killMovie(67f);
				kpr_killMovie(68f);
				kpr_killMovie(69f);
				kpr_killMovie(70f);
				kpr_killMovie(71f);
				kpr_killMovie(72f);
				kpr_killMovie(73f);
				kpr_killMovie(74f);
				kpr_killImage(75f);
				kpr_killImage(76f);
				kpr_killImage(77f);
				kpr_killImage(78f);
				kpr_killImage(79f);
				kpr_killImage(80f);
				kpr_killImage(81f);
				kpr_killImage(82f);
				kpr_killImage(83f);
				kpr_killImage(84f);
				kpr_killMovie(86f);
				kpr_killMovie(87f);
				kpr_killMovie(88f);
				kpr_killMovie(89f);
				kpr_killImage(90f);
				kpr_killImage(91f);
				kpr_killImage(92f);
				kpr_killImage(93f);
				kpr_killImage(94f);
				kpr_killMovie(95f);
				kpr_killMovie(96f);
				kpr_killMovie(97f);
				kpr_killMovie(98f);
				kpr_killMovie(99f);
				kpr_killMovie(100f);
				kpr_killImage(101f);
				break;
			}
		}
		base.end();
	}

	public override void control()
	{
		Main13KPR();
		SetPRPos();
		SetBubblePos(0);
		SetBubblePos(1);
		SetBubblePos(2);
		SetBubblePos(3);
		SetBubblePos(4);
		DispBubblePatternNear(0);
		DispBubblePatternNear(1);
		DispBubblePatternNear(2);
		DispBubblePatternNear(3);
		DispBubblePatternNear(4);
		DispBubblePatternFar(0);
		DispBubblePatternFar(1);
		DispBubblePatternFar(2);
		DispBubblePatternFar(3);
		DispBubblePatternFar(4);
		if (low == 0)
		{
			switch (mode)
			{
			case 2:
			case 9:
			case 11:
			case 14:
			case 16:
			case 20:
			case 22:
			case 24:
			case 26:
			case 28:
			case 30:
			case 37:
			case 39:
			case 42:
			case 45:
			case 47:
			case 49:
			case 51:
			case 53:
			case 55:
			case 57:
			case 59:
			case 61:
			case 63:
			case 65:
			case 67:
			case 87:
			case 90:
			case 92:
			case 95:
				if (frameCnt == 2)
				{
					kpr_killMovie(70f);
					kpr_killMovie(71f);
					kpr_killMovie(72f);
					kpr_killMovie(73f);
					kpr_killMovie(74f);
				}
				break;
			}
		}
		base.control();
		frameCnt = ((frameCnt <= 1048576) ? (frameCnt + 1) : 0);
	}

	public void kpr_killMovie(float layer)
	{
		int num = SGLG.prod.findLayer(layer);
		if (num >= 0)
		{
			SGLG.prod.Kill(num);
		}
	}

	public void kpr_killImage(float layer)
	{
		evt.eventStopImageLayer(layer, 0);
	}

	public int CLIP_RANGE(int _min, int _a, int _max)
	{
		return (_a > _max) ? (_a = _max) : ((_a >= _min) ? _a : (_a = _min));
	}

	public int CLIP_RANGE_EQU(int _min, int _a, int _max)
	{
		return (_a >= _max) ? (_a = _max) : ((_a > _min) ? _a : (_a = _min));
	}

	public int LOOP_RANGE(int min, int a, int max)
	{
		return (a > max) ? (a = min) : ((a >= min) ? a : (a = max));
	}

	public int LOOP_RANGE_EQU(int min, int a, int max)
	{
		return (a >= max) ? (a = min) : ((a > min) ? a : (a = max));
	}

	public int LOOP_RANGE_DETAIL(int min, int a, int max)
	{
		return (a > max) ? (a = a - max + min) : ((a >= min) ? a : (a = a + max - min));
	}

	public int LOOP_CYCLE(int min, int a, int max)
	{
		return (max < min) ? (a = min) : ((a > max) ? (a = min + (a - max - 1) % (max - min + 1)) : ((a >= min) ? a : (a = max - (min - a - 1) % (max - min + 1))));
	}

	public bool CHECK_RANGE(int min, int a, int max)
	{
		return min < a && a < max;
	}

	public bool CHECK_RANGE_EQU(int min, int a, int max)
	{
		return min <= a && a <= max;
	}

	public bool CHECK_NEAR_ZERO(int a, float gosa)
	{
		return 0f - gosa <= (float)a && (float)a <= gosa;
	}

	public float LINER_INTERPOLATION(float min, float max, float now)
	{
		return (1f - now) * min + now * max;
	}

	public float GET_INTERPOLATION_PER(float min, float max, float now)
	{
		return (now - min) / (max - min);
	}

	public float GET_TIME_RATE(int t, int s, int e)
	{
		return (s > t || t > e) ? (-1f) : (((float)t - (float)s) / ((float)e - (float)s));
	}

	public float GET_TIME_RATE_DOWN(int t, int s, int e)
	{
		return (s > t || t > e) ? (-1f) : (((float)e - (float)t) / ((float)e - (float)s));
	}

	public int ARC_Random()
	{
		return Sys_Random(g_random_seed);
	}

	private int Sys_Random(int[] _seed)
	{
		int num = _seed[0];
		int num2 = _seed[1];
		int num3 = _seed[2];
		int num4 = _seed[3];
		int num5 = num ^ (num << 11);
		num = num2;
		num2 = num3;
		num3 = num4;
		num4 = num4 ^ (num4 >> 19) ^ (num5 ^ (num5 >> 8));
		_seed[0] = num;
		_seed[1] = num2;
		_seed[2] = num3;
		_seed[3] = num4;
		return num4;
	}
}
