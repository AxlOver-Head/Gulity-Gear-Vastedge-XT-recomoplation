public class Direction29HNV : DirectionBase
{
	private static int nowOrder = 0;

	private static int orderCnt = 0;

	private int thisOrder;

	public int chara = -1;

	public bool isFailedVoice;

	private static int[] cmd_appear_navi = new int[3] { -1, -1, -1 };

	private static int[] cmd_aploop_navi = new int[3] { -1, -1, -1 };

	private static int[] table_x = new int[3] { 64, 128, 192 };

	private static int[] layerTbl = new int[4] { -50, -40, -31, -30 };

	private static DirectionManager.SOUND[][] sndID = new DirectionManager.SOUND[9][]
	{
		new DirectionManager.SOUND[4]
		{
			DirectionManager.SOUND.S1787,
			DirectionManager.SOUND.S1788,
			DirectionManager.SOUND.S1789,
			DirectionManager.SOUND.S1790
		},
		new DirectionManager.SOUND[4]
		{
			DirectionManager.SOUND.S1767,
			DirectionManager.SOUND.S1768,
			DirectionManager.SOUND.S1769,
			DirectionManager.SOUND.S1790
		},
		new DirectionManager.SOUND[4]
		{
			DirectionManager.SOUND.S1723,
			DirectionManager.SOUND.S1724,
			DirectionManager.SOUND.S1725,
			DirectionManager.SOUND.S1726
		},
		new DirectionManager.SOUND[4]
		{
			DirectionManager.SOUND.S1353,
			DirectionManager.SOUND.S1354,
			DirectionManager.SOUND.S1355,
			DirectionManager.SOUND.S1356
		},
		new DirectionManager.SOUND[4]
		{
			DirectionManager.SOUND.S1275,
			DirectionManager.SOUND.S1277,
			DirectionManager.SOUND.S1279,
			DirectionManager.SOUND.S1285
		},
		new DirectionManager.SOUND[4]
		{
			DirectionManager.SOUND.S1276,
			DirectionManager.SOUND.S1278,
			DirectionManager.SOUND.S1280,
			DirectionManager.SOUND.S1286
		},
		new DirectionManager.SOUND[4]
		{
			DirectionManager.SOUND.S0992,
			DirectionManager.SOUND.S0994,
			DirectionManager.SOUND.S0996,
			DirectionManager.SOUND.S0876
		},
		new DirectionManager.SOUND[4]
		{
			DirectionManager.SOUND.S0993,
			DirectionManager.SOUND.S0995,
			DirectionManager.SOUND.S0997,
			DirectionManager.SOUND.S0876
		},
		new DirectionManager.SOUND[4]
		{
			DirectionManager.SOUND.S1970,
			DirectionManager.SOUND.S1969,
			DirectionManager.SOUND.S1968,
			DirectionManager.SOUND.S0876
		}
	};

	public Direction29HNV(DirectionManager _mng, byte _high, byte _low, byte _mode, DirectionManager.DIR _dir)
		: base(_mng, _high, _low, _mode, _dir, DirectionBase.PRIORITY_NAVI)
	{
	}

	private void initParam()
	{
		cmd_appear_navi[0] = -1;
		cmd_appear_navi[1] = -1;
		cmd_appear_navi[2] = -1;
		cmd_aploop_navi[0] = -1;
		cmd_aploop_navi[1] = -1;
		cmd_aploop_navi[2] = -1;
		orderCnt = 0;
	}

	public override void start()
	{
		base.start();
		isFailedVoice = false;
		controlStopDirection();
		switch (low)
		{
		case 0:
			switch (mode)
			{
			case 1:
				initParam();
				appear_nml(0, 0, 0);
				appear_nml(0, 1, 1);
				appear_nml(0, 2, 2);
				break;
			case 2:
				success_nml(0, 0, 0);
				next_nml(0, 1, 1);
				break;
			case 3:
				success_nml(0, 1, 1);
				next_nml(0, 2, 2);
				break;
			case 4:
				success_nml(0, 2, 2);
				break;
			case 5:
				failedSound();
				failed_nml(0, 1, 1, 1);
				failed_nml(0, 2, 2, 1);
				break;
			case 6:
				failedSound();
				failed_nml(0, 0, 0, 0);
				failed_nml(0, 1, 1, 0);
				failed_nml(0, 2, 2, 0);
				break;
			case 7:
				initParam();
				appear_nml(0, 0, 0);
				appear_nml(0, 1, 2);
				appear_nml(0, 2, 1);
				break;
			case 8:
				success_nml(0, 0, 0);
				next_nml(0, 2, 1);
				break;
			case 9:
				success_nml(0, 2, 1);
				next_nml(0, 1, 2);
				break;
			case 10:
				success_nml(0, 1, 2);
				break;
			case 11:
				failedSound();
				failed_nml(0, 1, 2, 1);
				failed_nml(0, 2, 1, 1);
				break;
			case 12:
				failedSound();
				failed_nml(0, 0, 0, 0);
				failed_nml(0, 1, 2, 0);
				failed_nml(0, 2, 1, 0);
				break;
			case 13:
				initParam();
				appear_nml(0, 0, 1);
				appear_nml(0, 1, 0);
				appear_nml(0, 2, 2);
				break;
			case 14:
				success_nml(0, 1, 0);
				next_nml(0, 0, 1);
				break;
			case 15:
				success_nml(0, 0, 1);
				next_nml(0, 2, 2);
				break;
			case 16:
				success_nml(0, 2, 2);
				break;
			case 17:
				failedSound();
				failed_nml(0, 0, 1, 1);
				failed_nml(0, 2, 2, 1);
				break;
			case 18:
				failedSound();
				failed_nml(0, 0, 1, 0);
				failed_nml(0, 1, 0, 0);
				failed_nml(0, 2, 2, 0);
				break;
			case 19:
				initParam();
				appear_nml(0, 0, 2);
				appear_nml(0, 1, 0);
				appear_nml(0, 2, 1);
				break;
			case 20:
				success_nml(0, 1, 0);
				next_nml(0, 2, 1);
				break;
			case 21:
				success_nml(0, 2, 1);
				next_nml(0, 0, 2);
				break;
			case 22:
				success_nml(0, 0, 2);
				break;
			case 23:
				failedSound();
				failed_nml(0, 0, 2, 1);
				failed_nml(0, 2, 1, 1);
				break;
			case 24:
				failedSound();
				failed_nml(0, 0, 2, 0);
				failed_nml(0, 1, 0, 0);
				failed_nml(0, 2, 1, 0);
				break;
			case 25:
				initParam();
				appear_nml(0, 0, 1);
				appear_nml(0, 1, 2);
				appear_nml(0, 2, 0);
				break;
			case 26:
				success_nml(0, 2, 0);
				next_nml(0, 0, 1);
				break;
			case 27:
				success_nml(0, 0, 1);
				next_nml(0, 1, 2);
				break;
			case 28:
				success_nml(0, 1, 2);
				break;
			case 29:
				failedSound();
				failed_nml(0, 0, 1, 1);
				failed_nml(0, 1, 2, 1);
				break;
			case 30:
				failedSound();
				failed_nml(0, 0, 1, 0);
				failed_nml(0, 1, 2, 0);
				failed_nml(0, 2, 0, 0);
				break;
			case 31:
				initParam();
				appear_nml(0, 0, 2);
				appear_nml(0, 1, 1);
				appear_nml(0, 2, 0);
				break;
			case 32:
				success_nml(0, 2, 0);
				next_nml(0, 1, 1);
				break;
			case 33:
				success_nml(0, 1, 1);
				next_nml(0, 0, 2);
				break;
			case 34:
				success_nml(0, 0, 2);
				break;
			case 35:
				failedSound();
				failed_nml(0, 0, 2, 1);
				failed_nml(0, 1, 1, 1);
				break;
			case 36:
				failedSound();
				failed_nml(0, 0, 2, 0);
				failed_nml(0, 1, 1, 0);
				failed_nml(0, 2, 0, 0);
				break;
			case 37:
				initParam();
				appear_nml(1, 0, 0);
				appear_nml(1, 1, 1);
				appear_nml(1, 2, 2);
				break;
			case 38:
				success_nml(1, 0, 0);
				next_nml(1, 1, 1);
				break;
			case 39:
				success_nml(1, 1, 1);
				next_nml(1, 2, 2);
				break;
			case 40:
				success_nml(1, 2, 2);
				break;
			case 41:
				failedSound();
				failed_nml(1, 1, 1, 1);
				failed_nml(1, 2, 2, 1);
				break;
			case 42:
				failedSound();
				failed_nml(1, 0, 0, 0);
				failed_nml(1, 1, 1, 0);
				failed_nml(1, 2, 2, 0);
				break;
			case 43:
				initParam();
				appear_nml(1, 0, 0);
				appear_nml(1, 1, 2);
				appear_nml(1, 2, 1);
				break;
			case 44:
				success_nml(1, 0, 0);
				next_nml(1, 2, 1);
				break;
			case 45:
				success_nml(1, 2, 1);
				next_nml(1, 1, 2);
				break;
			case 46:
				success_nml(1, 1, 2);
				break;
			case 47:
				failedSound();
				failed_nml(1, 1, 2, 1);
				failed_nml(1, 2, 1, 1);
				break;
			case 48:
				failedSound();
				failed_nml(1, 0, 0, 0);
				failed_nml(1, 1, 2, 0);
				failed_nml(1, 2, 1, 0);
				break;
			case 49:
				initParam();
				appear_nml(1, 0, 1);
				appear_nml(1, 1, 0);
				appear_nml(1, 2, 2);
				break;
			case 50:
				success_nml(1, 1, 0);
				next_nml(1, 0, 1);
				break;
			case 51:
				success_nml(1, 0, 1);
				next_nml(1, 2, 2);
				break;
			case 52:
				success_nml(1, 2, 2);
				break;
			case 53:
				failedSound();
				failed_nml(1, 0, 1, 1);
				failed_nml(1, 2, 2, 1);
				break;
			case 54:
				failedSound();
				failed_nml(1, 0, 1, 0);
				failed_nml(1, 1, 0, 0);
				failed_nml(1, 2, 2, 0);
				break;
			case 55:
				initParam();
				appear_nml(1, 0, 2);
				appear_nml(1, 1, 0);
				appear_nml(1, 2, 1);
				break;
			case 56:
				success_nml(1, 1, 0);
				next_nml(1, 2, 1);
				break;
			case 57:
				success_nml(1, 2, 1);
				next_nml(1, 0, 2);
				break;
			case 58:
				success_nml(1, 0, 2);
				break;
			case 59:
				failedSound();
				failed_nml(1, 0, 2, 1);
				failed_nml(1, 2, 1, 1);
				break;
			case 60:
				failedSound();
				failed_nml(1, 0, 2, 0);
				failed_nml(1, 1, 0, 0);
				failed_nml(1, 2, 1, 0);
				break;
			case 61:
				initParam();
				appear_nml(1, 0, 1);
				appear_nml(1, 1, 2);
				appear_nml(1, 2, 0);
				break;
			case 62:
				success_nml(1, 2, 0);
				next_nml(1, 0, 1);
				break;
			case 63:
				success_nml(1, 0, 1);
				next_nml(1, 1, 2);
				break;
			case 64:
				success_nml(1, 1, 2);
				break;
			case 65:
				failedSound();
				failed_nml(1, 0, 1, 1);
				failed_nml(1, 1, 2, 1);
				break;
			case 66:
				failedSound();
				failed_nml(1, 0, 1, 0);
				failed_nml(1, 1, 2, 0);
				failed_nml(1, 2, 0, 0);
				break;
			case 67:
				initParam();
				appear_nml(1, 0, 2);
				appear_nml(1, 1, 1);
				appear_nml(1, 2, 0);
				break;
			case 68:
				success_nml(1, 2, 0);
				next_nml(1, 1, 1);
				break;
			case 69:
				success_nml(1, 1, 1);
				next_nml(1, 0, 2);
				break;
			case 70:
				success_nml(1, 0, 2);
				break;
			case 71:
				failedSound();
				failed_nml(1, 0, 2, 1);
				failed_nml(1, 1, 1, 1);
				break;
			case 72:
				failedSound();
				failed_nml(1, 0, 2, 0);
				failed_nml(1, 1, 1, 0);
				failed_nml(1, 2, 0, 0);
				break;
			case 73:
				initParam();
				appear_nml(2, 0, 0);
				appear_nml(2, 1, 1);
				appear_nml(2, 2, 2);
				break;
			case 74:
				success_nml(2, 0, 0);
				next_nml(2, 1, 1);
				break;
			case 75:
				success_nml(2, 1, 1);
				next_nml(2, 2, 2);
				break;
			case 76:
				success_nml(2, 2, 2);
				break;
			case 77:
				failedSound();
				failed_nml(2, 1, 1, 1);
				failed_nml(2, 2, 2, 1);
				break;
			case 78:
				failedSound();
				failed_nml(2, 0, 0, 0);
				failed_nml(2, 1, 1, 0);
				failed_nml(2, 2, 2, 0);
				break;
			case 79:
				initParam();
				appear_nml(2, 0, 0);
				appear_nml(2, 1, 2);
				appear_nml(2, 2, 1);
				break;
			case 80:
				success_nml(2, 0, 0);
				next_nml(2, 2, 1);
				break;
			case 81:
				success_nml(2, 2, 1);
				next_nml(2, 1, 2);
				break;
			case 82:
				success_nml(2, 1, 2);
				break;
			case 83:
				failedSound();
				failed_nml(2, 1, 2, 1);
				failed_nml(2, 2, 1, 1);
				break;
			case 84:
				failedSound();
				failed_nml(2, 0, 0, 0);
				failed_nml(2, 1, 2, 0);
				failed_nml(2, 2, 1, 0);
				break;
			case 85:
				initParam();
				appear_nml(2, 0, 1);
				appear_nml(2, 1, 0);
				appear_nml(2, 2, 2);
				break;
			case 86:
				success_nml(2, 1, 0);
				next_nml(2, 0, 1);
				break;
			case 87:
				success_nml(2, 0, 1);
				next_nml(2, 2, 2);
				break;
			case 88:
				success_nml(2, 2, 2);
				break;
			case 89:
				failedSound();
				failed_nml(2, 0, 1, 1);
				failed_nml(2, 2, 2, 1);
				break;
			case 90:
				failedSound();
				failed_nml(2, 0, 1, 0);
				failed_nml(2, 1, 0, 0);
				failed_nml(2, 2, 2, 0);
				break;
			case 91:
				initParam();
				appear_nml(2, 0, 2);
				appear_nml(2, 1, 0);
				appear_nml(2, 2, 1);
				break;
			case 92:
				success_nml(2, 1, 0);
				next_nml(2, 2, 1);
				break;
			case 93:
				success_nml(2, 2, 1);
				next_nml(2, 0, 2);
				break;
			case 94:
				success_nml(2, 0, 2);
				break;
			case 95:
				failedSound();
				failed_nml(2, 0, 2, 1);
				failed_nml(2, 2, 1, 1);
				break;
			case 96:
				failedSound();
				failed_nml(2, 0, 2, 0);
				failed_nml(2, 1, 0, 0);
				failed_nml(2, 2, 1, 0);
				break;
			case 97:
				initParam();
				appear_nml(2, 0, 1);
				appear_nml(2, 1, 2);
				appear_nml(2, 2, 0);
				break;
			case 98:
				success_nml(2, 2, 0);
				next_nml(2, 0, 1);
				break;
			case 99:
				success_nml(2, 0, 1);
				next_nml(2, 1, 2);
				break;
			case 100:
				success_nml(2, 1, 2);
				break;
			case 101:
				failedSound();
				failed_nml(2, 0, 1, 1);
				failed_nml(2, 1, 2, 1);
				break;
			case 102:
				failedSound();
				failed_nml(2, 0, 1, 0);
				failed_nml(2, 1, 2, 0);
				failed_nml(2, 2, 0, 0);
				break;
			case 103:
				initParam();
				appear_nml(2, 0, 2);
				appear_nml(2, 1, 1);
				appear_nml(2, 2, 0);
				break;
			case 104:
				success_nml(2, 2, 0);
				next_nml(2, 1, 1);
				break;
			case 105:
				success_nml(2, 1, 1);
				next_nml(2, 0, 2);
				break;
			case 106:
				success_nml(2, 0, 2);
				break;
			case 107:
				failedSound();
				failed_nml(2, 0, 2, 1);
				failed_nml(2, 1, 1, 1);
				break;
			case 108:
				failedSound();
				failed_nml(2, 0, 2, 0);
				failed_nml(2, 1, 1, 0);
				failed_nml(2, 2, 0, 0);
				break;
			case 109:
				initParam();
				appear_blk(3, 0, 0);
				appear_blk(3, 1, 1);
				appear_blk(3, 2, 2);
				break;
			case 110:
				success_blk(3, 0, 0);
				next_blk(3, 1, 1);
				break;
			case 111:
				success_blk(3, 1, 1);
				next_blk(3, 2, 2);
				break;
			case 112:
				success_blk(3, 2, 2);
				break;
			case 113:
				failedSound();
				failed_blk(3, 1, 1, 1);
				failed_blk(3, 2, 2, 1);
				break;
			case 114:
				failedSound();
				failed_blk(3, 0, 0, 0);
				failed_blk(3, 1, 1, 0);
				failed_blk(3, 2, 2, 0);
				break;
			case 115:
				initParam();
				appear_blk(3, 0, 0);
				appear_blk(3, 1, 2);
				appear_blk(3, 2, 1);
				break;
			case 116:
				success_blk(3, 0, 0);
				next_blk(3, 2, 1);
				break;
			case 117:
				success_blk(3, 2, 1);
				next_blk(3, 1, 2);
				break;
			case 118:
				success_blk(3, 1, 2);
				break;
			case 119:
				failedSound();
				failed_blk(3, 1, 2, 1);
				failed_blk(3, 2, 1, 1);
				break;
			case 120:
				failedSound();
				failed_blk(3, 0, 0, 0);
				failed_blk(3, 1, 2, 0);
				failed_blk(3, 2, 1, 0);
				break;
			case 121:
				initParam();
				appear_blk(3, 0, 1);
				appear_blk(3, 1, 0);
				appear_blk(3, 2, 2);
				break;
			case 122:
				success_blk(3, 1, 0);
				next_blk(3, 0, 1);
				break;
			case 123:
				success_blk(3, 0, 1);
				next_blk(3, 2, 2);
				break;
			case 124:
				success_blk(3, 2, 2);
				break;
			case 125:
				failedSound();
				failed_blk(3, 0, 1, 1);
				failed_blk(3, 2, 2, 1);
				break;
			case 126:
				failedSound();
				failed_blk(3, 0, 1, 0);
				failed_blk(3, 1, 0, 0);
				failed_blk(3, 2, 2, 0);
				break;
			case 127:
				initParam();
				appear_blk(3, 0, 2);
				appear_blk(3, 1, 0);
				appear_blk(3, 2, 1);
				break;
			case 128:
				success_blk(3, 1, 0);
				next_blk(3, 2, 1);
				break;
			case 129:
				success_blk(3, 2, 1);
				next_blk(3, 0, 2);
				break;
			case 130:
				success_blk(3, 0, 2);
				break;
			case 131:
				failedSound();
				failed_blk(3, 0, 2, 1);
				failed_blk(3, 2, 1, 1);
				break;
			case 132:
				failedSound();
				failed_blk(3, 0, 2, 0);
				failed_blk(3, 1, 0, 0);
				failed_blk(3, 2, 1, 0);
				break;
			case 133:
				initParam();
				appear_blk(3, 0, 1);
				appear_blk(3, 1, 2);
				appear_blk(3, 2, 0);
				break;
			case 134:
				success_blk(3, 2, 0);
				next_blk(3, 0, 1);
				break;
			case 135:
				success_blk(3, 0, 1);
				next_blk(3, 1, 2);
				break;
			case 136:
				success_blk(3, 1, 2);
				break;
			case 137:
				failedSound();
				failed_blk(3, 0, 1, 1);
				failed_blk(3, 1, 2, 1);
				break;
			case 138:
				failedSound();
				failed_blk(3, 0, 1, 0);
				failed_blk(3, 1, 2, 0);
				failed_blk(3, 2, 0, 0);
				break;
			case 139:
				initParam();
				appear_blk(3, 0, 2);
				appear_blk(3, 1, 1);
				appear_blk(3, 2, 0);
				break;
			case 140:
				success_blk(3, 2, 0);
				next_blk(3, 1, 1);
				break;
			case 141:
				success_blk(3, 1, 1);
				next_blk(3, 0, 2);
				break;
			case 142:
				success_blk(3, 0, 2);
				break;
			case 143:
				failedSound();
				failed_blk(3, 0, 2, 1);
				failed_blk(3, 1, 1, 1);
				break;
			case 144:
				failedSound();
				failed_blk(3, 0, 2, 0);
				failed_blk(3, 1, 1, 0);
				failed_blk(3, 2, 0, 0);
				break;
			case 145:
				initParam();
				appear_ex(4, 0, 0);
				appear_ex(4, 1, 1);
				appear_ex(4, 2, 2);
				break;
			case 146:
				success_ex(4, 0, 0);
				break;
			case 147:
				success_ex(4, 1, 1);
				break;
			case 148:
				success_ex(4, 2, 2);
				break;
			case 149:
				success_ex(4, 2, 2);
				break;
			case 150:
				success_ex(4, 1, 1);
				break;
			case 151:
				success_ex(4, 1, 1);
				break;
			case 152:
				success_ex(4, 0, 0);
				break;
			case 153:
				success_ex(4, 2, 2);
				break;
			case 154:
				success_ex(4, 2, 2);
				break;
			case 155:
				success_ex(4, 0, 0);
				break;
			case 156:
				success_ex(4, 2, 2);
				break;
			case 157:
				success_ex(4, 0, 0);
				break;
			case 158:
				success_ex(4, 1, 1);
				break;
			case 159:
				success_ex(4, 1, 1);
				break;
			case 160:
				success_ex(4, 0, 0);
				break;
			case 161:
				initParam();
				appear_mini(5, 0, 0);
				appear_mini(5, 1, 1);
				appear_mini(5, 2, 2);
				break;
			case 162:
				success_mini(5, 0, 0);
				next_mini(5, 1, 1);
				break;
			case 163:
				success_mini(5, 1, 1);
				next_mini(5, 2, 2);
				break;
			case 164:
				success_mini(5, 2, 2);
				break;
			case 165:
				failedSound();
				failed_mini(5, 1, 1, 1);
				failed_mini(5, 2, 2, 1);
				break;
			case 166:
				failedSound();
				failed_mini(5, 0, 0, 0);
				failed_mini(5, 1, 1, 0);
				failed_mini(5, 2, 2, 0);
				break;
			case 167:
				initParam();
				appear_mini(5, 0, 0);
				appear_mini(5, 1, 2);
				appear_mini(5, 2, 1);
				break;
			case 168:
				success_mini(5, 0, 0);
				next_mini(5, 2, 1);
				break;
			case 169:
				success_mini(5, 2, 1);
				next_mini(5, 1, 2);
				break;
			case 170:
				success_mini(5, 1, 2);
				break;
			case 171:
				failedSound();
				failed_mini(5, 1, 2, 1);
				failed_mini(5, 2, 1, 1);
				break;
			case 172:
				failedSound();
				failed_mini(5, 0, 0, 0);
				failed_mini(5, 1, 2, 0);
				failed_mini(5, 2, 1, 0);
				break;
			case 173:
				initParam();
				appear_mini(5, 0, 1);
				appear_mini(5, 1, 0);
				appear_mini(5, 2, 2);
				break;
			case 174:
				success_mini(5, 1, 0);
				next_mini(5, 0, 1);
				break;
			case 175:
				success_mini(5, 0, 1);
				next_mini(5, 2, 2);
				break;
			case 176:
				success_mini(5, 2, 2);
				break;
			case 177:
				failedSound();
				failed_mini(5, 0, 1, 1);
				failed_mini(5, 2, 2, 1);
				break;
			case 178:
				failedSound();
				failed_mini(5, 0, 1, 0);
				failed_mini(5, 1, 0, 0);
				failed_mini(5, 2, 2, 0);
				break;
			case 179:
				initParam();
				appear_mini(5, 0, 2);
				appear_mini(5, 1, 0);
				appear_mini(5, 2, 1);
				break;
			case 180:
				success_mini(5, 1, 0);
				next_mini(5, 2, 1);
				break;
			case 181:
				success_mini(5, 2, 1);
				next_mini(5, 0, 2);
				break;
			case 182:
				success_mini(5, 0, 2);
				break;
			case 183:
				failedSound();
				failed_mini(5, 0, 2, 1);
				failed_mini(5, 2, 1, 1);
				break;
			case 184:
				failedSound();
				failed_mini(5, 0, 2, 0);
				failed_mini(5, 1, 0, 0);
				failed_mini(5, 2, 1, 0);
				break;
			case 185:
				initParam();
				appear_mini(5, 0, 1);
				appear_mini(5, 1, 2);
				appear_mini(5, 2, 0);
				break;
			case 186:
				success_mini(5, 2, 0);
				next_mini(5, 0, 1);
				break;
			case 187:
				success_mini(5, 0, 1);
				next_mini(5, 1, 2);
				break;
			case 188:
				success_mini(5, 1, 2);
				break;
			case 189:
				failedSound();
				failed_mini(5, 0, 1, 1);
				failed_mini(5, 1, 2, 1);
				break;
			case 190:
				failedSound();
				failed_mini(5, 0, 1, 0);
				failed_mini(5, 1, 2, 0);
				failed_mini(5, 2, 0, 0);
				break;
			case 191:
				initParam();
				appear_mini(5, 0, 2);
				appear_mini(5, 1, 1);
				appear_mini(5, 2, 0);
				break;
			case 192:
				success_mini(5, 2, 0);
				next_mini(5, 1, 1);
				break;
			case 193:
				success_mini(5, 1, 1);
				next_mini(5, 0, 2);
				break;
			case 194:
				success_mini(5, 0, 2);
				break;
			case 195:
				failedSound();
				failed_mini(5, 0, 2, 1);
				failed_mini(5, 1, 1, 1);
				break;
			case 196:
				failedSound();
				failed_mini(5, 0, 2, 0);
				failed_mini(5, 1, 1, 0);
				failed_mini(5, 2, 0, 0);
				break;
			case 197:
				initParam();
				appear_mini(6, 0, 0);
				appear_mini(6, 1, 1);
				appear_mini(6, 2, 2);
				break;
			case 198:
				success_mini(6, 0, 0);
				next_mini(6, 1, 1);
				break;
			case 199:
				success_mini(6, 1, 1);
				next_mini(6, 2, 2);
				break;
			case 200:
				success_mini(6, 2, 2);
				break;
			case 201:
				failedSound();
				failed_mini(6, 1, 1, 1);
				failed_mini(6, 2, 2, 1);
				break;
			case 202:
				failedSound();
				failed_mini(6, 0, 0, 0);
				failed_mini(6, 1, 1, 0);
				failed_mini(6, 2, 2, 0);
				break;
			case 203:
				initParam();
				appear_mini(6, 0, 0);
				appear_mini(6, 1, 2);
				appear_mini(6, 2, 1);
				break;
			case 204:
				success_mini(6, 0, 0);
				next_mini(6, 2, 1);
				break;
			case 205:
				success_mini(6, 2, 1);
				next_mini(6, 1, 2);
				break;
			case 206:
				success_mini(6, 1, 2);
				break;
			case 207:
				failedSound();
				failed_mini(6, 1, 2, 1);
				failed_mini(6, 2, 1, 1);
				break;
			case 208:
				failedSound();
				failed_mini(6, 0, 0, 0);
				failed_mini(6, 1, 2, 0);
				failed_mini(6, 2, 1, 0);
				break;
			case 209:
				initParam();
				appear_mini(6, 0, 1);
				appear_mini(6, 1, 0);
				appear_mini(6, 2, 2);
				break;
			case 210:
				success_mini(6, 1, 0);
				next_mini(6, 0, 1);
				break;
			case 211:
				success_mini(6, 0, 1);
				next_mini(6, 2, 2);
				break;
			case 212:
				success_mini(6, 2, 2);
				break;
			case 213:
				failedSound();
				failed_mini(6, 0, 1, 1);
				failed_mini(6, 2, 2, 1);
				break;
			case 214:
				failedSound();
				failed_mini(6, 0, 1, 0);
				failed_mini(6, 1, 0, 0);
				failed_mini(6, 2, 2, 0);
				break;
			case 215:
				initParam();
				appear_mini(6, 0, 2);
				appear_mini(6, 1, 0);
				appear_mini(6, 2, 1);
				break;
			case 216:
				success_mini(6, 1, 0);
				next_mini(6, 2, 1);
				break;
			case 217:
				success_mini(6, 2, 1);
				next_mini(6, 0, 2);
				break;
			case 218:
				success_mini(6, 0, 2);
				break;
			case 219:
				failedSound();
				failed_mini(6, 0, 2, 1);
				failed_mini(6, 2, 1, 1);
				break;
			case 220:
				failedSound();
				failed_mini(6, 0, 2, 0);
				failed_mini(6, 1, 0, 0);
				failed_mini(6, 2, 1, 0);
				break;
			case 221:
				initParam();
				appear_mini(6, 0, 1);
				appear_mini(6, 1, 2);
				appear_mini(6, 2, 0);
				break;
			case 222:
				success_mini(6, 2, 0);
				next_mini(6, 0, 1);
				break;
			case 223:
				success_mini(6, 0, 1);
				next_mini(6, 1, 2);
				break;
			case 224:
				success_mini(6, 1, 2);
				break;
			case 225:
				failedSound();
				failed_mini(6, 0, 1, 1);
				failed_mini(6, 1, 2, 1);
				break;
			case 226:
				failedSound();
				failed_mini(6, 0, 1, 0);
				failed_mini(6, 1, 2, 0);
				failed_mini(6, 2, 0, 0);
				break;
			case 227:
				initParam();
				appear_mini(6, 0, 2);
				appear_mini(6, 1, 1);
				appear_mini(6, 2, 0);
				break;
			case 228:
				success_mini(6, 2, 0);
				next_mini(6, 1, 1);
				break;
			case 229:
				success_mini(6, 1, 1);
				next_mini(6, 0, 2);
				break;
			case 230:
				success_mini(6, 0, 2);
				break;
			case 231:
				failedSound();
				failed_mini(6, 0, 2, 1);
				failed_mini(6, 1, 1, 1);
				break;
			case 232:
				failedSound();
				failed_mini(6, 0, 2, 0);
				failed_mini(6, 1, 1, 0);
				failed_mini(6, 2, 0, 0);
				break;
			case 233:
				initParam();
				appear_mini(7, 0, 0);
				appear_mini(7, 1, 1);
				appear_mini(7, 2, 2);
				break;
			case 234:
				success_mini(7, 0, 0);
				next_mini(7, 1, 1);
				break;
			case 235:
				success_mini(7, 1, 1);
				next_mini(7, 2, 2);
				break;
			case 236:
				success_mini(7, 2, 2);
				break;
			case 237:
				failedSound();
				failed_mini(7, 1, 1, 1);
				failed_mini(7, 2, 2, 1);
				break;
			case 238:
				failedSound();
				failed_mini(7, 0, 0, 0);
				failed_mini(7, 1, 1, 0);
				failed_mini(7, 2, 2, 0);
				break;
			case 239:
				initParam();
				appear_mini(7, 0, 0);
				appear_mini(7, 1, 2);
				appear_mini(7, 2, 1);
				break;
			case 240:
				success_mini(7, 0, 0);
				next_mini(7, 2, 1);
				break;
			case 241:
				success_mini(7, 2, 1);
				next_mini(7, 1, 2);
				break;
			case 242:
				success_mini(7, 1, 2);
				break;
			case 243:
				failedSound();
				failed_mini(7, 1, 2, 1);
				failed_mini(7, 2, 1, 1);
				break;
			case 244:
				failedSound();
				failed_mini(7, 0, 0, 0);
				failed_mini(7, 1, 2, 0);
				failed_mini(7, 2, 1, 0);
				break;
			case 245:
				initParam();
				appear_mini(7, 0, 1);
				appear_mini(7, 1, 0);
				appear_mini(7, 2, 2);
				break;
			case 246:
				success_mini(7, 1, 0);
				next_mini(7, 0, 1);
				break;
			case 247:
				success_mini(7, 0, 1);
				next_mini(7, 2, 2);
				break;
			case 248:
				success_mini(7, 2, 2);
				break;
			case 249:
				failedSound();
				failed_mini(7, 0, 1, 1);
				failed_mini(7, 2, 2, 1);
				break;
			case 250:
				failedSound();
				failed_mini(7, 0, 1, 0);
				failed_mini(7, 1, 0, 0);
				failed_mini(7, 2, 2, 0);
				break;
			case 251:
				initParam();
				appear_mini(7, 0, 2);
				appear_mini(7, 1, 0);
				appear_mini(7, 2, 1);
				break;
			case 252:
				success_mini(7, 1, 0);
				next_mini(7, 2, 1);
				break;
			case 253:
				success_mini(7, 2, 1);
				next_mini(7, 0, 2);
				break;
			case 254:
				success_mini(7, 0, 2);
				break;
			case byte.MaxValue:
				failedSound();
				failed_mini(7, 0, 2, 1);
				failed_mini(7, 2, 1, 1);
				break;
			}
			break;
		case 1:
			switch (mode)
			{
			case 0:
				failedSound();
				failed_mini(7, 0, 2, 0);
				failed_mini(7, 1, 0, 0);
				failed_mini(7, 2, 1, 0);
				break;
			case 1:
				initParam();
				appear_mini(7, 0, 1);
				appear_mini(7, 1, 2);
				appear_mini(7, 2, 0);
				break;
			case 2:
				success_mini(7, 2, 0);
				next_mini(7, 0, 1);
				break;
			case 3:
				success_mini(7, 0, 1);
				next_mini(7, 1, 2);
				break;
			case 4:
				success_mini(7, 1, 2);
				break;
			case 5:
				failedSound();
				failed_mini(7, 0, 1, 1);
				failed_mini(7, 1, 2, 1);
				break;
			case 6:
				failedSound();
				failed_mini(7, 0, 1, 0);
				failed_mini(7, 1, 2, 0);
				failed_mini(7, 2, 0, 0);
				break;
			case 7:
				initParam();
				appear_mini(7, 0, 2);
				appear_mini(7, 1, 1);
				appear_mini(7, 2, 0);
				break;
			case 8:
				success_mini(7, 2, 0);
				next_mini(7, 1, 1);
				break;
			case 9:
				success_mini(7, 1, 1);
				next_mini(7, 0, 2);
				break;
			case 10:
				success_mini(7, 0, 2);
				break;
			case 11:
				failedSound();
				failed_mini(7, 0, 2, 1);
				failed_mini(7, 1, 1, 1);
				break;
			case 12:
				failedSound();
				failed_mini(7, 0, 2, 0);
				failed_mini(7, 1, 1, 0);
				failed_mini(7, 2, 0, 0);
				break;
			case 13:
				initParam();
				appear_ex(8, 0, 0);
				appear_ex(8, 1, 1);
				appear_ex(8, 2, 2);
				break;
			case 14:
				success_ex(8, 0, 0);
				break;
			case 15:
				success_ex(8, 1, 1);
				break;
			case 16:
				success_ex(8, 2, 2);
				break;
			case 17:
				success_ex(8, 2, 2);
				break;
			case 18:
				success_ex(8, 1, 1);
				break;
			case 19:
				success_ex(8, 1, 1);
				break;
			case 20:
				success_ex(8, 0, 0);
				break;
			case 21:
				success_ex(8, 2, 2);
				break;
			case 22:
				success_ex(8, 2, 2);
				break;
			case 23:
				success_ex(8, 0, 0);
				break;
			case 24:
				success_ex(8, 2, 2);
				break;
			case 25:
				success_ex(8, 0, 0);
				break;
			case 26:
				success_ex(8, 1, 1);
				break;
			case 27:
				success_ex(8, 1, 1);
				break;
			case 28:
				success_ex(8, 0, 0);
				break;
			case 29:
				initParam();
				evt.m_Priority = DirectionBase.PRIORITY_NORMAL;
				break;
			case 30:
				initParam();
				evt.m_Priority = DirectionBase.PRIORITY_NORMAL;
				break;
			case 31:
				initParam();
				evt.m_Priority = DirectionBase.PRIORITY_NORMAL;
				break;
			case 32:
				initParam();
				evt.m_Priority = DirectionBase.PRIORITY_NORMAL;
				break;
			case 33:
				initParam();
				evt.m_Priority = DirectionBase.PRIORITY_NORMAL;
				break;
			case 34:
				initParam();
				evt.m_Priority = DirectionBase.PRIORITY_NORMAL;
				break;
			case 35:
				initParam();
				evt.m_Priority = DirectionBase.PRIORITY_NORMAL;
				break;
			case 36:
				initParam();
				evt.m_Priority = DirectionBase.PRIORITY_NORMAL;
				break;
			case 37:
				initParam();
				evt.m_Priority = DirectionBase.PRIORITY_NORMAL;
				break;
			case 38:
				initParam();
				evt.m_Priority = DirectionBase.PRIORITY_NORMAL;
				break;
			case 39:
				initParam();
				evt.m_Priority = DirectionBase.PRIORITY_NORMAL;
				break;
			case 40:
				initParam();
				evt.m_Priority = DirectionBase.PRIORITY_NORMAL;
				break;
			case 41:
				initParam();
				evt.m_Priority = DirectionBase.PRIORITY_NORMAL;
				break;
			case 42:
				initParam();
				evt.m_Priority = DirectionBase.PRIORITY_NORMAL;
				break;
			case 43:
				initParam();
				evt.m_Priority = DirectionBase.PRIORITY_NORMAL;
				break;
			case 44:
				initParam();
				evt.m_Priority = DirectionBase.PRIORITY_NORMAL;
				break;
			case 45:
				initParam();
				evt.m_Priority = DirectionBase.PRIORITY_NORMAL;
				break;
			case 46:
				initParam();
				evt.m_Priority = DirectionBase.PRIORITY_NORMAL;
				break;
			case 47:
				initParam();
				evt.m_Priority = DirectionBase.PRIORITY_NORMAL;
				break;
			case 48:
				initParam();
				evt.m_Priority = DirectionBase.PRIORITY_NORMAL;
				break;
			case 49:
				initParam();
				evt.m_Priority = DirectionBase.PRIORITY_NORMAL;
				break;
			case 50:
				initParam();
				evt.m_Priority = DirectionBase.PRIORITY_NORMAL;
				break;
			case 51:
				initParam();
				evt.m_Priority = DirectionBase.PRIORITY_NORMAL;
				break;
			case 52:
				initParam();
				evt.m_Priority = DirectionBase.PRIORITY_NORMAL;
				break;
			}
			break;
		}
		if (!isFailedVoice)
		{
			naviVoice();
		}
		switch (low)
		{
		case 0:
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
			case 18:
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
			case 56:
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
			case 92:
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
			case 123:
				break;
			case 124:
				break;
			case 125:
				break;
			case 126:
				break;
			case 127:
				break;
			case 128:
				break;
			case 129:
				break;
			case 130:
				break;
			case 131:
				break;
			case 132:
				break;
			case 133:
				break;
			case 134:
				break;
			case 135:
				break;
			case 136:
				break;
			case 137:
				break;
			case 138:
				break;
			case 139:
				break;
			case 140:
				break;
			case 141:
				break;
			case 142:
				break;
			case 143:
				break;
			case 144:
				break;
			case 145:
				break;
			case 146:
				break;
			case 147:
				break;
			case 148:
				break;
			case 149:
				break;
			case 150:
				break;
			case 151:
				break;
			case 152:
				break;
			case 153:
				break;
			case 154:
				break;
			case 155:
				break;
			case 156:
				break;
			case 157:
				break;
			case 158:
				break;
			case 159:
				break;
			case 160:
				break;
			case 161:
				break;
			case 162:
				break;
			case 163:
				break;
			case 164:
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
			case 184:
				break;
			case 185:
				break;
			case 186:
				break;
			case 187:
				break;
			case 188:
				break;
			case 189:
				break;
			case 190:
				break;
			case 191:
				break;
			case 192:
				break;
			case 193:
				break;
			case 194:
				break;
			case 195:
				break;
			case 196:
				break;
			case 197:
				break;
			case 198:
				break;
			case 199:
				break;
			case 200:
				break;
			case 201:
				break;
			case 202:
				break;
			case 203:
				break;
			case 204:
				break;
			case 205:
				break;
			case 206:
				break;
			case 207:
				break;
			case 208:
				break;
			case 209:
				break;
			case 210:
				break;
			case 211:
				break;
			case 212:
				break;
			case 213:
				break;
			case 214:
				break;
			case 215:
				break;
			case 216:
				break;
			case 217:
				break;
			case 218:
				break;
			case 219:
				break;
			case 220:
				break;
			case 221:
				break;
			case 222:
				break;
			case 223:
				break;
			case 224:
				break;
			case 225:
				break;
			case 226:
				break;
			case 227:
				break;
			case 228:
				break;
			case 229:
				break;
			case 230:
				break;
			case 231:
				break;
			case 232:
				break;
			case 233:
				break;
			case 234:
				break;
			case 235:
				break;
			case 236:
				break;
			case 237:
				break;
			case 238:
				break;
			case 239:
				break;
			case 240:
				break;
			case 241:
				break;
			case 242:
				break;
			case 243:
				break;
			case 244:
				break;
			case 245:
				break;
			case 246:
				break;
			case 247:
				break;
			case 248:
				break;
			case 249:
				break;
			case 250:
				break;
			case 251:
				break;
			case 252:
				break;
			case 253:
				break;
			case 254:
				break;
			case byte.MaxValue:
				break;
			}
			break;
		case 1:
			switch (mode)
			{
			case 0:
				break;
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
			case 18:
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
				evt.eventPlayMovie(DirectionManager.MOVIE.hnv010_replay, false, false, false, true, 218, 110, 50, 0);
				break;
			case 30:
				evt.eventPlayMovie(DirectionManager.MOVIE.hnv011_replay, true, false, false, true, 218, 110, 50, 0);
				break;
			case 31:
				evt.eventPlayMovie(DirectionManager.MOVIE.hnv010_bel, false, false, false, true, 218, 110, 50, 0);
				break;
			case 32:
				evt.eventPlayMovie(DirectionManager.MOVIE.hnv011_bel, true, false, false, true, 218, 110, 50, 0);
				break;
			case 33:
				evt.eventPlayMovie(DirectionManager.MOVIE.hnv010_cherry, false, false, false, true, 218, 110, 50, 0);
				break;
			case 34:
				evt.eventPlayMovie(DirectionManager.MOVIE.hnv011_cherry, true, false, false, true, 218, 110, 50, 0);
				break;
			case 35:
				evt.eventPlayMovie(DirectionManager.MOVIE.hnv010_suika, false, false, false, true, 218, 110, 50, 0);
				break;
			case 36:
				evt.eventPlayMovie(DirectionManager.MOVIE.hnv011_suika, true, false, false, true, 218, 110, 50, 0);
				break;
			case 37:
				evt.eventPlayMovie(DirectionManager.MOVIE.hnv010_chance, false, false, false, true, 218, 110, 50, 0);
				break;
			case 38:
				evt.eventPlayMovie(DirectionManager.MOVIE.hnv011_chance, true, false, false, true, 218, 110, 50, 0);
				break;
			case 39:
				evt.eventPlayMovie(DirectionManager.MOVIE.hnv012_bar_right, false, false, false, true, 128, 104, -1, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hnv012_bar_right_loop, DirectionManager.MOVIE.hnv012_bar_right, false, true, false, true);
				break;
			case 40:
				evt.eventDisable(mng, DirectionManager.DIR.LEVER_2, 0);
				evt.eventDisable(mng, DirectionManager.DIR.REEL_2, 0);
				break;
			case 41:
				evt.eventPlayMovie(DirectionManager.MOVIE.hnv012_bar_left, false, false, false, true, 128, 104, -1, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hnv012_bar_left_loop, DirectionManager.MOVIE.hnv012_bar_left, false, true, false, true);
				break;
			case 42:
				evt.eventDisable(mng, DirectionManager.DIR.LEVER_2, 0);
				evt.eventDisable(mng, DirectionManager.DIR.REEL_2, 0);
				break;
			case 43:
				evt.eventDisable(mng, DirectionManager.DIR.LEVER_2, 0);
				evt.eventDisable(mng, DirectionManager.DIR.REEL_2, 0);
				break;
			case 44:
				evt.eventDisable(mng, DirectionManager.DIR.LEVER_2, 0);
				evt.eventDisable(mng, DirectionManager.DIR.REEL_2, 0);
				break;
			case 45:
				evt.eventDisable(mng, DirectionManager.DIR.LEVER_2, 0);
				evt.eventDisable(mng, DirectionManager.DIR.REEL_2, 0);
				break;
			case 46:
				evt.eventDisable(mng, DirectionManager.DIR.LEVER_2, 0);
				evt.eventDisable(mng, DirectionManager.DIR.REEL_2, 0);
				break;
			case 47:
				evt.eventPlayMovie(DirectionManager.MOVIE.hnv012_red7_left, false, false, false, true, 128, 104, -1, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hnv012_red7_left_loop, DirectionManager.MOVIE.hnv012_red7_left, false, true, false, true);
				evt.eventPlayMovie(DirectionManager.MOVIE.hnv012_red7_left_add, false, false, true, false, 0, 0, -2, 0);
				break;
			case 48:
				evt.eventDisable(mng, DirectionManager.DIR.LEVER_2, 0);
				evt.eventDisable(mng, DirectionManager.DIR.REEL_2, 0);
				break;
			case 49:
				evt.eventPlayMovie(DirectionManager.MOVIE.hnv012_red7_right, false, false, false, true, 128, 104, -1, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hnv012_red7_right_loop, DirectionManager.MOVIE.hnv012_red7_right, false, true, false, true);
				evt.eventPlayMovie(DirectionManager.MOVIE.hnv012_red7_left_add, false, false, true, false, 0, 0, -2, 0);
				break;
			case 50:
				evt.eventDisable(mng, DirectionManager.DIR.LEVER_2, 0);
				evt.eventDisable(mng, DirectionManager.DIR.REEL_2, 0);
				break;
			case 51:
				evt.eventPlayMovie(DirectionManager.MOVIE.hnv013, false, false, false, true, 128, 115, -1, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hnv013_add, false, false, true, true, 128, 115, -2, 0);
				break;
			case 52:
				break;
			}
			break;
		}
	}

	public void naviVoice()
	{
		int num = MainGameScene.slotGameMan.m_dirData[101];
		if (low == 1 && mode >= 39 && 51 >= mode)
		{
			if (mode == 39 || mode == 41)
			{
				chara = 0;
			}
			else if (mode == 51)
			{
				chara = 2;
			}
			else
			{
				if (mode != 47 && mode != 49)
				{
					return;
				}
				chara = 1;
			}
			switch (chara)
			{
			case 0:
				evt.eventPlaySound(DirectionManager.SOUND.S1294, Sound.CH.VC1, false, 1f, 0);
				break;
			case 1:
				evt.eventPlaySound(DirectionManager.SOUND.S1011, Sound.CH.VC1, false, 1f, 0);
				break;
			case 2:
				evt.eventPlaySound(DirectionManager.SOUND.S1795, Sound.CH.VC1, false, 1f, 0);
				break;
			}
		}
		else if (low == 1 && mode >= 29 && 38 >= mode)
		{
			if (mode == 29 || mode == 31 || mode == 33 || mode == 35 || mode == 37)
			{
				evt.eventPlaySound(DirectionManager.SOUND.S0650, Sound.CH.VC1, false, 1f, 0);
			}
		}
		else if (low == 0 && mode >= 145 && 160 >= mode)
		{
			if (mode == 145)
			{
				evt.eventPlaySound(DirectionManager.SOUND.S0328, Sound.CH.VC1, false, 1f, 0);
			}
			else
			{
				evt.eventPlaySound(DirectionManager.SOUND.S0329, Sound.CH.VC1, false, 1f, 0);
			}
		}
		else if (low == 1 && mode >= 13 && 28 >= mode)
		{
			if (mode == 145)
			{
				evt.eventPlaySound(DirectionManager.SOUND.S0298, Sound.CH.VC1, false, 1f, 0);
			}
			else
			{
				evt.eventPlaySound(DirectionManager.SOUND.S0299, Sound.CH.VC1, false, 1f, 0);
			}
		}
		else
		{
			if (low == 1 && mode >= 53)
			{
				return;
			}
			int num2 = num - 16;
			int num3 = -1;
			int num4 = -1;
			int num5 = MainGameScene.slotGameMan.get_koyaku_prm(2);
			int num6 = MainGameScene.slotGameMan.get_koyaku_prm(0);
			if (num2 >= 0)
			{
				if (num2 >= 0 && 3 >= num2)
				{
					num3 = 6;
				}
				else if (num2 >= 4 && 6 >= num2)
				{
					num3 = 4;
				}
				else if (num2 >= 7 && 10 >= num2)
				{
					num3 = 3;
				}
				else if (num2 >= 11 && 14 >= num2)
				{
					num3 = 2;
				}
				else if (num2 >= 15 && 17 >= num2)
				{
					num3 = 1;
				}
				else if (num2 >= 18 && 21 >= num2)
				{
					num3 = 0;
				}
				else if (num2 >= 22 && 24 >= num2)
				{
					num3 = 8;
				}
				else if (num2 >= 25 && 28 >= num2)
				{
					num3 = 6;
				}
			}
			else if ((num5 >= 39 && 44 >= num5) || num6 == 1)
			{
				num3 = 6;
			}
			else if (num5 >= 1 && 33 >= num5)
			{
				num3 = 4;
			}
			if (num3 < 0 || 9 <= num3)
			{
				return;
			}
			switch (MainGameScene.slotMan.m_NowProdState)
			{
			case 3:
			case 4:
				num4 = 0;
				break;
			case 7:
				num4 = 1;
				break;
			case 11:
				num4 = 2;
				break;
			case 15:
				num4 = 3;
				break;
			}
			if (num4 >= 0 && 3 > num4)
			{
				int num7 = MainGameScene.lotMan.reelStopNum(num4);
				if (num7 >= 0 && 3 > num7)
				{
					evt.eventPlaySound(sndID[num3][num7], Sound.CH.VC1, false, 1f, 0);
				}
			}
			else if (num4 == 3 && num3 != 8 && ((num5 >= 39 && 44 >= num5) || num6 == 1))
			{
				evt.eventPlaySound(sndID[num3][num4], Sound.CH.VC1, false, 1f, 0);
			}
		}
	}

	public override void end()
	{
		base.end();
	}

	public override void control()
	{
		if (thisOrder == 0)
		{
			if (nowOrder > 0 && orderCnt == 0)
			{
				evt.setCommandUnuse(cmd_appear_navi[0]);
				evt.setCommandUnuse(cmd_aploop_navi[0]);
				orderCnt = 1;
			}
			if (nowOrder > 1 && orderCnt == 1)
			{
				evt.setCommandUnuse(cmd_appear_navi[1]);
				evt.setCommandUnuse(cmd_aploop_navi[1]);
				orderCnt = 2;
			}
			if (nowOrder > 2 && orderCnt == 2)
			{
				evt.setCommandUnuse(cmd_appear_navi[2]);
				evt.setCommandUnuse(cmd_aploop_navi[2]);
				orderCnt = 3;
			}
		}
		base.control();
	}

	private void appear_nml(int kind, int place, int order)
	{
		int num = -1;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		switch (kind)
		{
		case 0:
			num = 20 + order;
			break;
		case 1:
			num = 10 + order;
			break;
		case 2:
			num = 0 + order;
			break;
		}
		num2 = table_x[place];
		num3 = 110;
		num4 = layerTbl[order];
		if (num >= 0)
		{
			if (order == 0)
			{
				cmd_appear_navi[order] = evt.eventPlayAnime(DirectionManager.ANIME.HNV001_a, num, false, false, false, true, num2, num3, num4, 0);
				cmd_aploop_navi[order] = evt.eventAddAnimeWithLayerAndPosition(DirectionManager.ANIME.HNV001_b, num, DirectionManager.ANIME.HNV001_a, num4, false, true, false, true, num2, num3);
			}
			else
			{
				cmd_appear_navi[order] = evt.eventPlayAnime(DirectionManager.ANIME.HNV002_a, num, false, false, false, true, num2, num3, num4, 0);
			}
		}
	}

	private void success_nml(int kind, int place, int order)
	{
		int num = -1;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		switch (kind)
		{
		case 0:
			num = 20 + order;
			break;
		case 1:
			num = 10 + order;
			break;
		case 2:
			num = 0 + order;
			break;
		}
		num2 = table_x[place];
		num3 = 110;
		num4 = layerTbl[order];
		if (num >= 0)
		{
			evt.eventPlayAnime(DirectionManager.ANIME.HNV001_c, num, true, false, false, true, num2, num3, num4, 0);
		}
	}

	private void next_nml(int kind, int place, int order)
	{
		int num = -1;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		switch (kind)
		{
		case 0:
			num = 20 + order;
			break;
		case 1:
			num = 10 + order;
			break;
		case 2:
			num = 0 + order;
			break;
		}
		num2 = table_x[place];
		num3 = 110;
		num4 = layerTbl[order];
		if (num >= 0)
		{
			evt.eventPlayAnime(DirectionManager.ANIME.HNV002_b, num, false, false, false, true, num2, num3, num4, 0);
			evt.eventAddAnimeWithLayerAndPosition(DirectionManager.ANIME.HNV001_b, num, DirectionManager.ANIME.HNV002_b, num4, false, true, false, true, num2, num3);
		}
	}

	private void failed_nml(int kind, int place, int order, int no)
	{
		int num = -1;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		switch (kind)
		{
		case 0:
			num = 20 + order;
			break;
		case 1:
			num = 10 + order;
			break;
		case 2:
			num = 0 + order;
			break;
		}
		num2 = table_x[place];
		num3 = 110;
		num4 = layerTbl[order];
		if (num >= 0)
		{
			if (no == order)
			{
				evt.eventPlayAnime(DirectionManager.ANIME.HNV001_d, num, true, false, false, true, num2, num3, num4, 0);
			}
			else
			{
				evt.eventPlayAnime(DirectionManager.ANIME.HNV002_d, num, true, false, false, true, num2, num3, num4, 0);
			}
		}
	}

	private void appear_blk(int kind, int place, int order)
	{
		int num = -1;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		num = 30 + order;
		num2 = table_x[place];
		num3 = 110;
		num4 = layerTbl[order];
		if (num >= 0)
		{
			if (order == 0)
			{
				cmd_appear_navi[order] = evt.eventPlayAnime(DirectionManager.ANIME.HNV003_c, num, false, false, false, true, num2, num3, num4, 0);
				cmd_aploop_navi[order] = evt.eventAddAnimeWithLayerAndPosition(DirectionManager.ANIME.HNV003_a, num, DirectionManager.ANIME.HNV003_c, num4, false, true, false, true, num2, num3);
			}
			else
			{
				cmd_appear_navi[order] = evt.eventPlayAnime(DirectionManager.ANIME.HNV002_a, num, false, false, false, true, num2, num3, num4, 0);
			}
		}
	}

	private void success_blk(int kind, int place, int order)
	{
		int num = -1;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		num = 30 + order;
		num2 = table_x[place];
		num3 = 110;
		num4 = layerTbl[order];
		if (num >= 0)
		{
			evt.eventPlayAnime(DirectionManager.ANIME.HNV003_b, num, true, false, false, true, num2, num3, num4, 0);
		}
	}

	private void next_blk(int kind, int place, int order)
	{
		int num = -1;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		num = 30 + order;
		num2 = table_x[place];
		num3 = 110;
		num4 = layerTbl[order];
		if (num >= 0)
		{
			evt.eventPlayAnime(DirectionManager.ANIME.HNV004_a, num, false, false, false, true, num2, num3, num4, 0);
			evt.eventAddAnimeWithLayerAndPosition(DirectionManager.ANIME.HNV003_a, num, DirectionManager.ANIME.HNV004_a, num4, false, true, false, true, num2, num3);
		}
	}

	private void failed_blk(int kind, int place, int order, int no)
	{
		int num = -1;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		num = 30 + order;
		num2 = table_x[place];
		num3 = 110;
		num4 = layerTbl[order];
		if (num >= 0)
		{
			if (no == order)
			{
				evt.eventPlayAnime(DirectionManager.ANIME.HNV004_b, num, true, false, false, true, num2, num3, num4, 0);
			}
			else
			{
				evt.eventPlayAnime(DirectionManager.ANIME.HNV002_d, num, true, false, false, true, num2, num3, num4, 0);
			}
		}
	}

	private void appear_mini(int kind, int place, int order)
	{
		int num = -1;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		switch (kind)
		{
		case 5:
			num = 20 + order;
			break;
		case 6:
			num = 10 + order;
			break;
		case 7:
			num = 0 + order;
			break;
		}
		num2 = table_x[place];
		num3 = 110;
		num4 = layerTbl[order];
		if (num >= 0)
		{
			if (order == 0)
			{
				cmd_appear_navi[order] = evt.eventPlayAnime(DirectionManager.ANIME.HNV005_a, num, false, false, false, true, num2, num3, num4, 0);
				cmd_aploop_navi[order] = evt.eventAddAnimeWithLayerAndPosition(DirectionManager.ANIME.HNV005_b, num, DirectionManager.ANIME.HNV005_a, num4, false, true, false, true, num2, num3);
			}
			else
			{
				cmd_appear_navi[order] = evt.eventPlayAnime(DirectionManager.ANIME.HNV006_a, num, false, false, false, true, num2, num3, num4, 0);
			}
		}
	}

	private void success_mini(int kind, int place, int order)
	{
		int num = -1;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		switch (kind)
		{
		case 5:
			num = 20 + order;
			break;
		case 6:
			num = 10 + order;
			break;
		case 7:
			num = 0 + order;
			break;
		}
		num2 = table_x[place];
		num3 = 110;
		num4 = layerTbl[order];
		if (num >= 0)
		{
			evt.eventPlayAnime(DirectionManager.ANIME.HNV005_c, num, true, false, false, true, num2, num3, num4, 0);
		}
	}

	private void next_mini(int kind, int place, int order)
	{
		int num = -1;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		switch (kind)
		{
		case 5:
			num = 20 + order;
			break;
		case 6:
			num = 10 + order;
			break;
		case 7:
			num = 0 + order;
			break;
		}
		num2 = table_x[place];
		num3 = 110;
		num4 = layerTbl[order];
		if (num >= 0)
		{
			evt.eventPlayAnime(DirectionManager.ANIME.HNV006_b, num, false, false, false, true, num2, num3, num4, 0);
			evt.eventAddAnimeWithLayerAndPosition(DirectionManager.ANIME.HNV005_b, num, DirectionManager.ANIME.HNV006_b, num4, false, true, false, true, num2, num3);
		}
	}

	private void failed_mini(int kind, int place, int order, int no)
	{
		int num = -1;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		switch (kind)
		{
		case 5:
			num = 20 + order;
			break;
		case 6:
			num = 10 + order;
			break;
		case 7:
			num = 0 + order;
			break;
		}
		num2 = table_x[place];
		num3 = 110;
		num4 = layerTbl[order];
		if (num >= 0)
		{
			if (no == order)
			{
				evt.eventPlayAnime(DirectionManager.ANIME.HNV005_d, num, true, false, false, true, num2, num3, num4, 0);
			}
			else
			{
				evt.eventPlayAnime(DirectionManager.ANIME.HNV006_d, num, true, false, false, true, num2, num3, num4, 0);
			}
		}
	}

	private void appear_ex(int kind, int place, int order)
	{
		int num = -1;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		switch (kind)
		{
		case 4:
			num = 43;
			break;
		case 8:
			num = 54;
			break;
		}
		num2 = table_x[place];
		num3 = 110;
		num4 = layerTbl[order];
		if (num >= 0)
		{
			evt.eventPlayAnime(DirectionManager.ANIME.HNV005_a, num, false, false, false, true, num2, num3, num4, 0);
			evt.eventAddAnimeWithLayerAndPosition(DirectionManager.ANIME.HNV005_b, num, DirectionManager.ANIME.HNV005_a, num4, false, true, false, true, num2, num3);
		}
	}

	private void success_ex(int kind, int place, int order)
	{
		int num = -1;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		switch (kind)
		{
		case 4:
			num = 43;
			break;
		case 8:
			num = 54;
			break;
		}
		num2 = table_x[place];
		num3 = 110;
		num4 = layerTbl[order];
		if (num >= 0)
		{
			evt.eventPlayAnime(DirectionManager.ANIME.HNV005_c, num, true, false, false, true, num2, num3, num4, 0);
		}
	}

	private void failedSound()
	{
		isFailedVoice = true;
		evt.eventPlaySound(DirectionManager.SOUND.S1000, Sound.CH.VC1, false, 1f, 5);
	}

	private void controlStopDirection()
	{
		switch (low)
		{
		case 0:
			switch (mode)
			{
			case 1:
			case 7:
			case 13:
			case 19:
			case 25:
			case 31:
			case 37:
			case 43:
			case 49:
			case 55:
			case 61:
			case 67:
			case 73:
			case 79:
			case 85:
			case 91:
			case 97:
			case 103:
			case 109:
			case 115:
			case 121:
			case 127:
			case 133:
			case 139:
			case 145:
			case 161:
			case 167:
			case 173:
			case 179:
			case 185:
			case 191:
			case 197:
			case 203:
			case 209:
			case 215:
			case 221:
			case 227:
			case 233:
			case 239:
			case 245:
			case 251:
				nowOrder = (thisOrder = 0);
				break;
			case 2:
			case 6:
			case 8:
			case 12:
			case 14:
			case 18:
			case 20:
			case 24:
			case 26:
			case 30:
			case 32:
			case 36:
			case 38:
			case 42:
			case 44:
			case 48:
			case 50:
			case 54:
			case 56:
			case 60:
			case 62:
			case 66:
			case 68:
			case 72:
			case 74:
			case 78:
			case 80:
			case 84:
			case 86:
			case 90:
			case 92:
			case 96:
			case 98:
			case 102:
			case 104:
			case 108:
			case 110:
			case 114:
			case 116:
			case 120:
			case 122:
			case 126:
			case 128:
			case 132:
			case 134:
			case 138:
			case 140:
			case 144:
			case 146:
			case 151:
			case 156:
			case 162:
			case 166:
			case 168:
			case 172:
			case 174:
			case 178:
			case 180:
			case 184:
			case 186:
			case 190:
			case 192:
			case 196:
			case 198:
			case 202:
			case 204:
			case 208:
			case 210:
			case 214:
			case 216:
			case 220:
			case 222:
			case 226:
			case 228:
			case 232:
			case 234:
			case 238:
			case 240:
			case 244:
			case 246:
			case 250:
			case 252:
				nowOrder = (thisOrder = 1);
				break;
			case 3:
			case 5:
			case 9:
			case 11:
			case 15:
			case 17:
			case 21:
			case 23:
			case 27:
			case 29:
			case 33:
			case 35:
			case 39:
			case 41:
			case 45:
			case 47:
			case 51:
			case 53:
			case 57:
			case 59:
			case 63:
			case 65:
			case 69:
			case 71:
			case 75:
			case 77:
			case 81:
			case 83:
			case 87:
			case 89:
			case 93:
			case 95:
			case 99:
			case 101:
			case 105:
			case 107:
			case 111:
			case 113:
			case 117:
			case 119:
			case 123:
			case 125:
			case 129:
			case 131:
			case 135:
			case 137:
			case 141:
			case 143:
			case 147:
			case 149:
			case 152:
			case 154:
			case 157:
			case 159:
			case 163:
			case 165:
			case 169:
			case 171:
			case 175:
			case 177:
			case 181:
			case 183:
			case 187:
			case 189:
			case 193:
			case 195:
			case 199:
			case 201:
			case 205:
			case 207:
			case 211:
			case 213:
			case 217:
			case 219:
			case 223:
			case 225:
			case 229:
			case 231:
			case 235:
			case 237:
			case 241:
			case 243:
			case 247:
			case 249:
			case 253:
			case byte.MaxValue:
				nowOrder = (thisOrder = 2);
				break;
			case 4:
			case 10:
			case 16:
			case 22:
			case 28:
			case 34:
			case 40:
			case 46:
			case 52:
			case 58:
			case 64:
			case 70:
			case 76:
			case 82:
			case 88:
			case 94:
			case 100:
			case 106:
			case 112:
			case 118:
			case 124:
			case 130:
			case 136:
			case 142:
			case 148:
			case 150:
			case 153:
			case 155:
			case 158:
			case 160:
			case 164:
			case 170:
			case 176:
			case 182:
			case 188:
			case 194:
			case 200:
			case 206:
			case 212:
			case 218:
			case 224:
			case 230:
			case 236:
			case 242:
			case 248:
			case 254:
				nowOrder = (thisOrder = 3);
				break;
			}
			break;
		case 1:
			switch (mode)
			{
			case 1:
			case 7:
			case 13:
				nowOrder = (thisOrder = 0);
				break;
			case 0:
			case 2:
			case 6:
			case 8:
			case 12:
			case 14:
			case 19:
			case 24:
				nowOrder = (thisOrder = 1);
				break;
			case 3:
			case 5:
			case 9:
			case 11:
			case 15:
			case 17:
			case 20:
			case 22:
			case 25:
			case 27:
				nowOrder = (thisOrder = 2);
				break;
			case 4:
			case 10:
			case 16:
			case 18:
			case 21:
			case 23:
			case 26:
			case 28:
				nowOrder = (thisOrder = 3);
				break;
			}
			break;
		}
	}
}
