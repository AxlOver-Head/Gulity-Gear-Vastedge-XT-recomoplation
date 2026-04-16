public class Direction83LED : DirectionBase
{
	public Direction83LED(DirectionManager _mng, byte _high, byte _low, byte _mode, DirectionManager.DIR _dir)
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
			}
		}
		if (low == 0)
		{
			switch (mode)
			{
			case 1:
				DirectionLedManager.m_panel_waku_01(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 2:
				break;
			case 3:
				DirectionLedManager.m_panel_waku_04(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 4:
				DirectionLedManager.m_panel_waku_05(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
				break;
			case 5:
				DirectionLedManager.m_panel_waku_06(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
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
