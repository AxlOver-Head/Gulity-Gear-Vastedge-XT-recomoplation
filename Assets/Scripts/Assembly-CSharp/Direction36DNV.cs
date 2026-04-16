public class Direction36DNV : DirectionBase
{
	public static int[,] posTbl = new int[6, 3]
	{
		{ 64, 128, 192 },
		{ 64, 192, 128 },
		{ 128, 64, 192 },
		{ 128, 192, 64 },
		{ 192, 64, 128 },
		{ 192, 128, 64 }
	};

	public static int posMax = 6;

	public bool isFailedVoice;

	private static int[] table_x = new int[3] { 64, 128, 192 };

	private static int[] layerTbl = new int[4] { -50, -40, -31, -30 };

	private DirectionManager.SOUND[] sndID = new DirectionManager.SOUND[4]
	{
		DirectionManager.SOUND.S0993,
		DirectionManager.SOUND.S0995,
		DirectionManager.SOUND.S0997,
		DirectionManager.SOUND.S1032
	};

	public Direction36DNV(DirectionManager _mng, byte _high, byte _low, byte _mode, DirectionManager.DIR _dir)
		: base(_mng, _high, _low, _mode, _dir, DirectionBase.PRIORITY_NAVI)
	{
	}

	public override void start()
	{
		base.start();
		evt.eventStopDirectionBefore(mng, 0);
		isFailedVoice = false;
		if (low == 0)
		{
			switch (mode)
			{
			case 1:
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
				killRing();
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
				killRing();
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
				killRing();
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
				killRing();
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
				killRing();
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
				killRing();
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
				killRing();
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
				killRing();
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
				killRing();
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
				killRing();
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
				killRing();
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
				killRing();
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
				killRing();
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
				killRing();
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
				killRing();
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
				killRing();
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
				killRing();
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
				killRing();
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
				appear_nml(3, 0, 0);
				appear_nml(3, 1, 1);
				appear_nml(3, 2, 2);
				break;
			case 110:
				success_nml(3, 0, 0);
				next_nml(3, 1, 1);
				break;
			case 111:
				success_nml(3, 1, 1);
				next_nml(3, 2, 2);
				break;
			case 112:
				killRing();
				success_nml(3, 2, 2);
				break;
			case 113:
				failedSound();
				failed_nml(3, 1, 1, 1);
				failed_nml(3, 2, 2, 1);
				break;
			case 114:
				failedSound();
				failed_nml(3, 0, 0, 0);
				failed_nml(3, 1, 1, 0);
				failed_nml(3, 2, 2, 0);
				break;
			case 115:
				appear_nml(3, 0, 0);
				appear_nml(3, 1, 2);
				appear_nml(3, 2, 1);
				break;
			case 116:
				success_nml(3, 0, 0);
				next_nml(3, 2, 1);
				break;
			case 117:
				success_nml(3, 2, 1);
				next_nml(3, 1, 2);
				break;
			case 118:
				killRing();
				success_nml(3, 1, 2);
				break;
			case 119:
				failedSound();
				failed_nml(3, 1, 2, 1);
				failed_nml(3, 2, 1, 1);
				break;
			case 120:
				failedSound();
				failed_nml(3, 0, 0, 0);
				failed_nml(3, 1, 2, 0);
				failed_nml(3, 2, 1, 0);
				break;
			case 121:
				appear_nml(3, 0, 1);
				appear_nml(3, 1, 0);
				appear_nml(3, 2, 2);
				break;
			case 122:
				success_nml(3, 1, 0);
				next_nml(3, 0, 1);
				break;
			case 123:
				success_nml(3, 0, 1);
				next_nml(3, 2, 2);
				break;
			case 124:
				killRing();
				success_nml(3, 2, 2);
				break;
			case 125:
				failedSound();
				failed_nml(3, 0, 1, 1);
				failed_nml(3, 2, 2, 1);
				break;
			case 126:
				failedSound();
				failed_nml(3, 0, 1, 0);
				failed_nml(3, 1, 0, 0);
				failed_nml(3, 2, 2, 0);
				break;
			case 127:
				appear_nml(3, 0, 2);
				appear_nml(3, 1, 0);
				appear_nml(3, 2, 1);
				break;
			case 128:
				success_nml(3, 1, 0);
				next_nml(3, 2, 1);
				break;
			case 129:
				success_nml(3, 2, 1);
				next_nml(3, 0, 2);
				break;
			case 130:
				killRing();
				success_nml(3, 0, 2);
				break;
			case 131:
				failedSound();
				failed_nml(3, 0, 2, 1);
				failed_nml(3, 2, 1, 1);
				break;
			case 132:
				failedSound();
				failed_nml(3, 0, 2, 0);
				failed_nml(3, 1, 0, 0);
				failed_nml(3, 2, 1, 0);
				break;
			case 133:
				appear_nml(3, 0, 1);
				appear_nml(3, 1, 2);
				appear_nml(3, 2, 0);
				break;
			case 134:
				success_nml(3, 2, 0);
				next_nml(3, 0, 1);
				break;
			case 135:
				success_nml(3, 0, 1);
				next_nml(3, 1, 2);
				break;
			case 136:
				killRing();
				success_nml(3, 1, 2);
				break;
			case 137:
				failedSound();
				failed_nml(3, 0, 1, 1);
				failed_nml(3, 1, 2, 1);
				break;
			case 138:
				failedSound();
				failed_nml(3, 0, 1, 0);
				failed_nml(3, 1, 2, 0);
				failed_nml(3, 2, 0, 0);
				break;
			case 139:
				appear_nml(3, 0, 2);
				appear_nml(3, 1, 1);
				appear_nml(3, 2, 0);
				break;
			case 140:
				success_nml(3, 2, 0);
				next_nml(3, 1, 1);
				break;
			case 141:
				success_nml(3, 1, 1);
				next_nml(3, 0, 2);
				break;
			case 142:
				killRing();
				success_nml(3, 0, 2);
				break;
			case 143:
				failedSound();
				failed_nml(3, 0, 2, 1);
				failed_nml(3, 1, 1, 1);
				break;
			case 144:
				failedSound();
				failed_nml(3, 0, 2, 0);
				failed_nml(3, 1, 1, 0);
				failed_nml(3, 2, 0, 0);
				break;
			}
		}
		if (!isFailedVoice)
		{
			naviVoice();
		}
		if (low == 0)
		{
			switch (mode)
			{
			case 1:
				DirectionLedManager.m_panel_NV_r_L(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 2:
				DirectionLedManager.m_panel_NV_r_C(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 3:
				DirectionLedManager.m_panel_NV_r_R(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 4:
				DirectionLedManager.m_panel_NV_r_get(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 5:
				DirectionLedManager.OFF_1m(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 6:
				DirectionLedManager.OFF_1m(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 7:
				DirectionLedManager.m_panel_NV_r_L(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 8:
				DirectionLedManager.m_panel_NV_r_R(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 9:
				DirectionLedManager.m_panel_NV_r_C(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 10:
				DirectionLedManager.m_panel_NV_r_get(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 11:
				DirectionLedManager.OFF_1m(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 12:
				DirectionLedManager.OFF_1m(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 13:
				DirectionLedManager.m_panel_NV_r_C(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 14:
				DirectionLedManager.m_panel_NV_r_L(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 15:
				DirectionLedManager.m_panel_NV_r_R(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 16:
				DirectionLedManager.m_panel_NV_r_get(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 17:
				DirectionLedManager.OFF_1m(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 18:
				DirectionLedManager.OFF_1m(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 19:
				DirectionLedManager.m_panel_NV_r_R(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 20:
				DirectionLedManager.m_panel_NV_r_L(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 21:
				DirectionLedManager.m_panel_NV_r_C(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 22:
				DirectionLedManager.m_panel_NV_r_get(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 23:
				DirectionLedManager.OFF_1m(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 24:
				DirectionLedManager.OFF_1m(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 25:
				DirectionLedManager.m_panel_NV_r_C(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 26:
				DirectionLedManager.m_panel_NV_r_R(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 27:
				DirectionLedManager.m_panel_NV_r_L(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 28:
				DirectionLedManager.m_panel_NV_r_get(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 29:
				DirectionLedManager.OFF_1m(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 30:
				DirectionLedManager.OFF_1m(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 31:
				DirectionLedManager.m_panel_NV_r_R(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 32:
				DirectionLedManager.m_panel_NV_r_C(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 33:
				DirectionLedManager.m_panel_NV_r_L(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 34:
				DirectionLedManager.m_panel_NV_r_get(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 35:
				DirectionLedManager.OFF_1m(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 36:
				DirectionLedManager.OFF_1m(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 37:
				DirectionLedManager.m_panel_NV_r_L(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 38:
				DirectionLedManager.m_panel_NV_r_C(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 39:
				DirectionLedManager.m_panel_NV_r_R(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 40:
				DirectionLedManager.m_panel_NV_r_get(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 41:
				DirectionLedManager.OFF_1m(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 42:
				DirectionLedManager.OFF_1m(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 43:
				DirectionLedManager.m_panel_NV_r_L(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 44:
				DirectionLedManager.m_panel_NV_r_R(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 45:
				DirectionLedManager.m_panel_NV_r_C(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 46:
				DirectionLedManager.m_panel_NV_r_get(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 47:
				DirectionLedManager.OFF_1m(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 48:
				DirectionLedManager.OFF_1m(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 49:
				DirectionLedManager.m_panel_NV_r_C(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 50:
				DirectionLedManager.m_panel_NV_r_L(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 51:
				DirectionLedManager.m_panel_NV_r_R(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 52:
				DirectionLedManager.m_panel_NV_r_get(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 53:
				DirectionLedManager.OFF_1m(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 54:
				DirectionLedManager.OFF_1m(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 55:
				DirectionLedManager.m_panel_NV_r_R(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 56:
				DirectionLedManager.m_panel_NV_r_L(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 57:
				DirectionLedManager.m_panel_NV_r_C(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 58:
				DirectionLedManager.m_panel_NV_r_get(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 59:
				DirectionLedManager.OFF_1m(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 60:
				DirectionLedManager.OFF_1m(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 61:
				DirectionLedManager.m_panel_NV_r_C(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 62:
				DirectionLedManager.m_panel_NV_r_R(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 63:
				DirectionLedManager.m_panel_NV_r_L(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 64:
				DirectionLedManager.m_panel_NV_r_get(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 65:
				DirectionLedManager.OFF_1m(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 66:
				DirectionLedManager.OFF_1m(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 67:
				DirectionLedManager.m_panel_NV_r_R(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 68:
				DirectionLedManager.m_panel_NV_r_C(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 69:
				DirectionLedManager.m_panel_NV_r_L(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 70:
				DirectionLedManager.m_panel_NV_r_get(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 71:
				DirectionLedManager.OFF_1m(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 72:
				DirectionLedManager.OFF_1m(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 73:
				DirectionLedManager.m_panel_NV_r_L(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 74:
				DirectionLedManager.m_panel_NV_r_C(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 75:
				DirectionLedManager.m_panel_NV_r_R(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 76:
				DirectionLedManager.m_panel_NV_r_get(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 77:
				DirectionLedManager.OFF_1m(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 78:
				DirectionLedManager.OFF_1m(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 79:
				DirectionLedManager.m_panel_NV_r_L(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 80:
				DirectionLedManager.m_panel_NV_r_R(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 81:
				DirectionLedManager.m_panel_NV_r_C(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 82:
				DirectionLedManager.m_panel_NV_r_get(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 83:
				DirectionLedManager.OFF_1m(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 84:
				DirectionLedManager.OFF_1m(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 85:
				DirectionLedManager.m_panel_NV_r_C(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 86:
				DirectionLedManager.m_panel_NV_r_L(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 87:
				DirectionLedManager.m_panel_NV_r_R(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 88:
				DirectionLedManager.m_panel_NV_r_get(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 89:
				DirectionLedManager.OFF_1m(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 90:
				DirectionLedManager.OFF_1m(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 91:
				DirectionLedManager.m_panel_NV_r_R(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 92:
				DirectionLedManager.m_panel_NV_r_L(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 93:
				DirectionLedManager.m_panel_NV_r_C(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 94:
				DirectionLedManager.m_panel_NV_r_get(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 95:
				DirectionLedManager.OFF_1m(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 96:
				DirectionLedManager.OFF_1m(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 97:
				DirectionLedManager.m_panel_NV_r_C(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 98:
				DirectionLedManager.m_panel_NV_r_R(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 99:
				DirectionLedManager.m_panel_NV_r_L(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 100:
				DirectionLedManager.m_panel_NV_r_get(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 101:
				DirectionLedManager.OFF_1m(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 102:
				DirectionLedManager.OFF_1m(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 103:
				DirectionLedManager.m_panel_NV_r_R(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 104:
				DirectionLedManager.m_panel_NV_r_C(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 105:
				DirectionLedManager.m_panel_NV_r_L(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 106:
				DirectionLedManager.m_panel_NV_r_get(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 107:
				DirectionLedManager.OFF_1m(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 108:
				DirectionLedManager.OFF_1m(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 109:
				DirectionLedManager.m_panel_NV_r_L(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 110:
				DirectionLedManager.m_panel_NV_r_C(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 111:
				DirectionLedManager.m_panel_NV_r_R(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 112:
				DirectionLedManager.m_panel_NV_r_get(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 113:
				DirectionLedManager.OFF_1m(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 114:
				DirectionLedManager.OFF_1m(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 115:
				DirectionLedManager.m_panel_NV_r_L(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 116:
				DirectionLedManager.m_panel_NV_r_R(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 117:
				DirectionLedManager.m_panel_NV_r_C(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 118:
				DirectionLedManager.m_panel_NV_r_get(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 119:
				DirectionLedManager.OFF_1m(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 120:
				DirectionLedManager.OFF_1m(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 121:
				DirectionLedManager.m_panel_NV_r_C(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 122:
				DirectionLedManager.m_panel_NV_r_L(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 123:
				DirectionLedManager.m_panel_NV_r_R(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 124:
				DirectionLedManager.m_panel_NV_r_get(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 125:
				DirectionLedManager.OFF_1m(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 126:
				DirectionLedManager.OFF_1m(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 127:
				DirectionLedManager.m_panel_NV_r_R(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 128:
				DirectionLedManager.m_panel_NV_r_L(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 129:
				DirectionLedManager.m_panel_NV_r_C(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 130:
				DirectionLedManager.m_panel_NV_r_get(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 131:
				DirectionLedManager.OFF_1m(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 132:
				DirectionLedManager.OFF_1m(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 133:
				DirectionLedManager.m_panel_NV_r_C(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 134:
				DirectionLedManager.m_panel_NV_r_R(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 135:
				DirectionLedManager.m_panel_NV_r_L(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 136:
				DirectionLedManager.m_panel_NV_r_get(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 137:
				DirectionLedManager.OFF_1m(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 138:
				DirectionLedManager.OFF_1m(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 139:
				DirectionLedManager.m_panel_NV_r_R(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 140:
				DirectionLedManager.m_panel_NV_r_C(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 141:
				DirectionLedManager.m_panel_NV_r_L(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 142:
				DirectionLedManager.m_panel_NV_r_get(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 143:
				DirectionLedManager.OFF_1m(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 144:
				DirectionLedManager.OFF_1m(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
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
		case 3:
			num = 30 + order;
			break;
		}
		num2 = table_x[place];
		num3 = 110;
		num4 = layerTbl[order];
		if (num >= 0)
		{
			if (order == 0)
			{
				evt.eventPlayAnime(DirectionManager.ANIME.DNV001_a, num, false, false, false, true, num2, num3, num4, 0);
				evt.eventAddAnimeWithLayerAndPosition(DirectionManager.ANIME.DNV001_b, num, DirectionManager.ANIME.DNV001_a, num4, false, true, false, true, num2, num3);
			}
			else
			{
				evt.eventPlayAnime(DirectionManager.ANIME.DNV002_a, num, false, false, false, true, num2, num3, num4, 0);
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
		case 3:
			num = 30 + order;
			break;
		}
		num2 = table_x[place];
		num3 = 110;
		num4 = layerTbl[order];
		if (num >= 0)
		{
			evt.eventPlayAnime(DirectionManager.ANIME.DNV001_c, num, true, false, false, true, num2, num3, num4, 0);
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
		case 3:
			num = 30 + order;
			break;
		}
		num2 = table_x[place];
		num3 = 110;
		num4 = layerTbl[order];
		if (num >= 0)
		{
			evt.eventPlayAnime(DirectionManager.ANIME.DNV002_b, num, false, false, false, true, num2, num3, num4, 0);
			evt.eventAddAnimeWithLayerAndPosition(DirectionManager.ANIME.DNV001_b, num, DirectionManager.ANIME.DNV002_b, num4, false, true, false, true, num2, num3);
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
		case 3:
			num = 30 + order;
			break;
		}
		num2 = table_x[place];
		num3 = 110;
		num4 = layerTbl[order];
		if (num >= 0)
		{
			if (no == order)
			{
				evt.eventPlayAnime(DirectionManager.ANIME.DNV001_d, num, true, false, false, true, num2, num3, num4, 0);
			}
			else
			{
				evt.eventPlayAnime(DirectionManager.ANIME.DNV002_d, num, true, false, false, true, num2, num3, num4, 0);
			}
		}
	}

	private void killRing()
	{
	}

	private void failedSound()
	{
		isFailedVoice = true;
		evt.eventPlaySound(DirectionManager.SOUND.S1000, Sound.CH.VC0, true, 1f, 5);
		killRing();
	}

	public void naviVoice()
	{
		int num = -1;
		int num2 = MainGameScene.slotGameMan.m_dirData[101];
		int num3 = MainGameScene.slotGameMan.get_koyaku_prm(2);
		int num4 = MainGameScene.slotGameMan.get_koyaku_prm(0);
		switch (MainGameScene.slotMan.m_NowProdState)
		{
		case 3:
		case 4:
			num = 0;
			break;
		case 7:
			num = 1;
			break;
		case 11:
			num = 2;
			break;
		case 15:
			num = 3;
			break;
		}
		if (num >= 0 && 3 > num)
		{
			int num5 = MainGameScene.lotMan.reelStopNum(num);
			if (num5 >= 0 && 3 > num5)
			{
				evt.eventPlaySound(sndID[num5], Sound.CH.VC1, true, 1f, 0);
			}
		}
		else if (num == 3 && ((num3 >= 39 && 44 >= num3) || num4 == 1))
		{
			evt.eventPlaySound(sndID[num], Sound.CH.VC1, true, 1f, 0);
		}
	}
}
