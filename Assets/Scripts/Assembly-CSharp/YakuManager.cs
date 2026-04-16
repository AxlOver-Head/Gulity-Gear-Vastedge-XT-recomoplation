using UnityEngine;

public class YakuManager
{
	public enum KIND
	{
		LEVER = 0,
		BUTTON_L = 1,
		BUTTON_C = 2,
		BUTTON_R = 3,
		MAXBET = 4,
		PUSH = 5,
		LOGO = 6,
		CHAIN = 7,
		JYD = 8,
		CUBE = 9,
		NUM = 10
	}

	public YakuObj[] yakuObjs;

	public void init()
	{
		yakuObjs = new YakuObj[10];
		yakuObjs[0] = new YakuObjLever();
		yakuObjs[1] = new YakuObjStopButtons("L");
		yakuObjs[2] = new YakuObjStopButtons("C");
		yakuObjs[3] = new YakuObjStopButtons("R");
		yakuObjs[4] = new YakuObjMaxBet();
		yakuObjs[5] = new YakuObjPushButton();
		yakuObjs[6] = new YakuObjLogo();
		yakuObjs[7] = new YakuObjChain();
		yakuObjs[8] = new YakuObjJYD();
		yakuObjs[9] = new YakuObjCube();
	}

	public void start(KIND _line, int _id)
	{
		if (_line >= KIND.LEVER && _line < KIND.NUM)
		{
			yakuObjs[(int)_line].start(_id);
		}
	}

	public void pause()
	{
		Time.timeScale = 0f;
	}

	public void resume()
	{
		Time.timeScale = 1f;
	}

	public void control()
	{
		for (int i = 0; i < 10; i++)
		{
			yakuObjs[i].control();
		}
	}

	public void returnJYD()
	{
		if (yakuObjs[8].getID() == 0)
		{
			start(KIND.JYD, 5);
		}
	}

	public void returnCube()
	{
		YakuObjCube yakuObjCube = (YakuObjCube)yakuObjs[9];
		bool flag = false;
		if (MainGameScene.slotGameMan.get_pdt_data(1) == 86)
		{
			switch (MainGameScene.slotGameMan.get_pdt_data(5))
			{
			case 207:
			case 208:
			case 209:
			case 210:
			case 219:
			case 220:
			case 221:
			case 222:
			case 231:
			case 232:
			case 233:
			case 234:
			case 243:
			case 244:
			case 245:
			case 246:
				return;
			}
			flag = true;
		}
		switch (MainGameScene.slotGameMan.m_dirData[46])
		{
		default:
			if (yakuObjCube.m_Direction != YakuObjCube.DIR.A || flag)
			{
				start(KIND.CUBE, 69);
			}
			break;
		case 3:
			if (yakuObjCube.m_Direction != YakuObjCube.DIR.B || flag)
			{
				start(KIND.CUBE, 71);
			}
			break;
		case 24:
		case 25:
		case 26:
		case 27:
		case 28:
		case 29:
			if (yakuObjCube.m_Direction != YakuObjCube.DIR.C || flag)
			{
				start(KIND.CUBE, 73);
			}
			break;
		case 4:
		case 5:
		case 6:
		case 7:
		case 9:
		case 10:
		case 15:
		case 16:
		case 17:
		case 18:
		case 20:
		case 22:
		case 23:
		case 30:
			if (yakuObjCube.m_Direction != YakuObjCube.DIR.D || flag)
			{
				start(KIND.CUBE, 75);
			}
			break;
		case 19:
			if ((MainGameScene.slotGameMan.ulDedamaLotState & 0x10000) != 0L && (yakuObjCube.m_Direction != YakuObjCube.DIR.D || flag))
			{
				start(KIND.CUBE, 75);
			}
			break;
		}
	}

	public void returnCubeRestart()
	{
		YakuObjCube yakuObjCube = (YakuObjCube)yakuObjs[9];
		bool flag = false;
		switch (MainGameScene.slotGameMan.m_dirData[45])
		{
		default:
			if (yakuObjCube.m_Direction != YakuObjCube.DIR.A || flag)
			{
				start(KIND.CUBE, 69);
			}
			break;
		case 3:
			if (yakuObjCube.m_Direction != YakuObjCube.DIR.B || flag)
			{
				start(KIND.CUBE, 71);
			}
			break;
		case 24:
		case 25:
		case 26:
		case 27:
		case 28:
		case 29:
			if (yakuObjCube.m_Direction != YakuObjCube.DIR.C || flag)
			{
				start(KIND.CUBE, 73);
			}
			break;
		case 4:
		case 5:
		case 6:
		case 7:
		case 9:
		case 10:
		case 15:
		case 16:
		case 17:
		case 18:
		case 20:
		case 22:
		case 23:
		case 30:
			if (yakuObjCube.m_Direction != YakuObjCube.DIR.D || flag)
			{
				start(KIND.CUBE, 75);
			}
			break;
		case 19:
			if ((MainGameScene.slotGameMan.ulDedamaLotState & 0x10000) != 0L && (yakuObjCube.m_Direction != YakuObjCube.DIR.D || flag))
			{
				start(KIND.CUBE, 75);
			}
			break;
		}
	}
}
