public class PushButtonManager
{
	private bool isCanPush;

	private bool isPush;

	private bool isPopUp;

	public void control()
	{
		if (!isPush)
		{
			return;
		}
		if (!isCanPush)
		{
			isPush = false;
			return;
		}
		switch (MainGameScene.slotMan.m_State)
		{
		case SlotBodyManager.STATE.STANDBY:
		case SlotBodyManager.STATE.LEVER_WAIT:
		case SlotBodyManager.STATE.REEL_MOVE1:
		case SlotBodyManager.STATE.REEL_MOVE2:
		case SlotBodyManager.STATE.REEL_MOVE3:
		{
			isPush = false;
			int line = DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_7M);
			DirectionLedManager.OFF_6m(line);
			int pUSHbtnStatus = MainGameScene.slotGameMan.getPUSHbtnStatus();
			int line2 = DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_9M);
			if (MainGameScene.slotGameMan.get_pdt_data(1) == 74)
			{
				if (MainGameScene.slotGameMan.m_pushRendaFrame != 0)
				{
					DirectionPanelLED.runMac2App(MainGameScene.slotGameMan.getPUSHbtnStatus(), 7);
					DirectionPanelLED.runMac2App(MainGameScene.slotGameMan.getPUSHbtnStatus(), 9);
				}
				switch (pUSHbtnStatus)
				{
				case 1:
				case 15:
					DirectionLedManager.push_around_flash_white(line2);
					break;
				case 16:
				case 17:
					DirectionLedManager.push_around_flash_blue(line2);
					break;
				case 18:
				case 19:
					DirectionLedManager.push_around_flash_red(line2);
					break;
				case 31:
				case 33:
					DirectionLedManager.push_around_on_rainbow_BZT(line2);
					break;
				}
			}
			else
			{
				switch ((pUSHbtnStatus != 0) ? (pUSHbtnStatus + 7) : 8)
				{
				case 0:
					DirectionLedManager.OFF_8m(line2);
					break;
				case 1:
					DirectionLedManager.push_around_white(line2);
					break;
				case 2:
					DirectionLedManager.push_around_blue(line2);
					break;
				case 3:
					DirectionLedManager.push_around_yellow(line2);
					break;
				case 4:
					DirectionLedManager.push_around_green(line2);
					break;
				case 5:
					DirectionLedManager.push_around_red(line2);
					break;
				case 6:
					DirectionLedManager.push_around_purple(line2);
					break;
				case 7:
					DirectionLedManager.push_around_rainbow(line2);
					break;
				case 8:
					DirectionLedManager.push_around_flash_white(line2);
					break;
				case 9:
					DirectionLedManager.push_around_flash_blue(line2);
					break;
				case 10:
					DirectionLedManager.push_around_flash_yellow(line2);
					break;
				case 11:
					DirectionLedManager.push_around_flash_green(line2);
					break;
				case 12:
					DirectionLedManager.push_around_flash_red(line2);
					break;
				case 13:
					DirectionLedManager.push_around_flash_purple(line2);
					break;
				case 14:
					DirectionLedManager.push_around_flash_rainbow(line2);
					break;
				case 15:
					DirectionLedManager.push_around_blink_white(line2);
					break;
				case 16:
					DirectionLedManager.push_around_blink_blue_01(line2);
					break;
				case 17:
					DirectionLedManager.push_around_blink_blue_02(line2);
					break;
				case 18:
					DirectionLedManager.push_around_blink_red_01(line2);
					break;
				case 19:
					DirectionLedManager.push_around_blink_red_02(line2);
					break;
				case 20:
					DirectionLedManager.push_around_on_rainbow(line2);
					break;
				case 21:
					DirectionLedManager.push_around_flash_white(line2);
					break;
				case 22:
					DirectionLedManager.push_around_flash_blue(line2);
					break;
				case 23:
					DirectionLedManager.push_around_flash_yellow(line2);
					break;
				case 24:
					DirectionLedManager.push_around_flash_green(line2);
					break;
				case 25:
					DirectionLedManager.push_around_flash_red(line2);
					break;
				case 26:
					DirectionLedManager.push_around_flash_purple(line2);
					break;
				case 27:
					DirectionLedManager.push_around_flash_rainbow(line2);
					break;
				case 28:
					DirectionLedManager.push_around_flash_white(line2);
					break;
				case 29:
					DirectionLedManager.push_around_flash_blue(line2);
					break;
				case 30:
					DirectionLedManager.push_around_flash_red(line2);
					break;
				case 31:
					DirectionLedManager.push_around_on_rainbow_BZT(line2);
					break;
				case 32:
					DirectionLedManager.push_around_flash_white(line2);
					break;
				case 33:
					DirectionLedManager.push_around_on_rainbow(line2);
					break;
				}
			}
			MainGameScene.slotGameMan.startLot_Push();
			if (getPopUp())
			{
				MainGameScene.yakuMan.start(YakuManager.KIND.PUSH, 2);
			}
			else
			{
				MainGameScene.yakuMan.start(YakuManager.KIND.PUSH, 3);
			}
			break;
		}
		default:
			isPush = false;
			break;
		}
	}

	public void setPush(bool _state)
	{
		isPush = _state;
	}

	public void setCanPush(bool _state)
	{
		isCanPush = _state;
		if (MainGameScene.slotGameMan.get_pdt_data(1) != 74)
		{
			if (!isCanPush)
			{
				return;
			}
			DirectionPanelLED.runMac2App(MainGameScene.slotGameMan.getPUSHbtnStatus(), 7);
			DirectionPanelLED.runMac2App(MainGameScene.slotGameMan.getPUSHbtnStatus(), 9);
		}
		if (MainGameScene.slotGameMan.getPUSHbtnStatus() == 5 && MainGameScene.slotGameMan.get_pdt_data(1) != 88)
		{
			if (isCanPush && !getPopUp())
			{
				MainGameScene.yakuMan.start(YakuManager.KIND.PUSH, 0);
				setPopUp(true);
			}
		}
		else if (isCanPush && getPopUp())
		{
			MainGameScene.yakuMan.start(YakuManager.KIND.PUSH, 1);
			setPopUp(false);
		}
	}

	public void setPopUp(bool _state)
	{
		isPopUp = _state;
	}

	public bool getPush()
	{
		return isPush;
	}

	public bool getCanPush()
	{
		return isCanPush;
	}

	public bool getPopUp()
	{
		return isPopUp;
	}

	public void canselPopUp()
	{
		if (getPopUp())
		{
			MainGameScene.yakuMan.start(YakuManager.KIND.PUSH, 1);
			setPopUp(false);
		}
	}
}
