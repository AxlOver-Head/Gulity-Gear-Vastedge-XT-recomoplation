using System.Collections.Generic;
using UnityEngine;

public class ReelManager
{
	private const int eREEL_NONE = -1;

	private const int eREEL_LEFT = 0;

	private const int eREEL_CENTER = 1;

	private const int eREEL_RIGHT = 2;

	private static int eREEL_NUM = 3;

	private ReelObject[] m_Reels;

	public bool isReady;

	public int[] pushOrder = new int[3];

	public int pushCount;

	public int[] reelSpeed = new int[3];

	public bool[] reelBlurFlag = new bool[3];

	private List<REEL_FREEZE> reelFreeze = new List<REEL_FREEZE>();

	public bool freezeRunFlag;

	public int freezeRunCount;

	private Texture m_MainTex;

	private Texture m_BlurTex;

	public ReelManager()
	{
		initTex();
		m_Reels = new ReelObject[eREEL_NUM];
		m_Reels[0] = GameObject.Find("/kyoutai/reel/Drum_L").GetComponent<ReelObject>();
		m_Reels[1] = GameObject.Find("/kyoutai/reel/Drum_C").GetComponent<ReelObject>();
		m_Reels[2] = GameObject.Find("/kyoutai/reel/Drum_R").GetComponent<ReelObject>();
		m_Reels[0].thisID = 0;
		m_Reels[1].thisID = 1;
		m_Reels[2].thisID = 2;
		m_Reels[0].mainTex = m_MainTex;
		m_Reels[0].blurTex = m_BlurTex;
		m_Reels[1].mainTex = m_MainTex;
		m_Reels[1].blurTex = m_BlurTex;
		m_Reels[2].mainTex = m_MainTex;
		m_Reels[2].blurTex = m_BlurTex;
		setStep(0, 19);
		setStep(1, 19);
		setStep(2, 19);
	}

	private void initTex()
	{
		m_MainTex = Resources.Load("Textures/SGLG_reel_mini") as Texture;
		m_BlurTex = Resources.Load("Textures/SGLG_reel_mini_blur") as Texture;
	}

	public void setReelSpeed(int _speed)
	{
		reelSpeed[0] = _speed;
		reelSpeed[1] = _speed;
		reelSpeed[2] = _speed;
	}

	public void setReelBulr(bool _flag)
	{
		m_Reels[0].setBlur(_flag);
		m_Reels[1].setBlur(_flag);
		m_Reels[2].setBlur(_flag);
	}

	public void control()
	{
		if (!freezeRunFlag)
		{
			return;
		}
		foreach (REEL_FREEZE item in reelFreeze)
		{
			freezeRunFlag = item.control(freezeRunCount);
			if (item.getEvent() == -2)
			{
			}
		}
		freezeRunCount++;
		if (!freezeRunFlag)
		{
			reelFreeze.Clear();
		}
	}

	public void OnReelStart(int cnt)
	{
		if (cnt == 0)
		{
			m_Reels[0].start((ReelObject.REELSPEED)MainGameScene.m_PlaySaveData.m_configReelSpeed, 1);
			m_Reels[1].start((ReelObject.REELSPEED)MainGameScene.m_PlaySaveData.m_configReelSpeed, 1);
			m_Reels[2].start((ReelObject.REELSPEED)MainGameScene.m_PlaySaveData.m_configReelSpeed, 1);
		}
		else if (cnt >= 1 && 3 >= cnt)
		{
			m_Reels[cnt - 1].start((ReelObject.REELSPEED)MainGameScene.m_PlaySaveData.m_configReelSpeed, 1);
		}
		if (cnt >= 10)
		{
			isReady = true;
		}
		pushOrder[0] = -1;
		pushOrder[1] = -1;
		pushOrder[2] = -1;
		pushCount = 0;
	}

	public void OnReelStop(int num)
	{
		if (num >= 0 && num < eREEL_NUM)
		{
			int state = MainGameScene.slotGameMan.get_koyaku_prm(0);
			int flag = MainGameScene.slotGameMan.get_koyaku_prm(1);
			int num2 = MainGameScene.slotGameMan.get_koyaku_prm(2);
			int num3 = 0;
			pushOrder[pushCount] = num;
			pushCount++;
			if (num2 == 49 && num == 0)
			{
				num2 = 46;
			}
			if (num2 == 48 && num == 1)
			{
				num2 = 47;
			}
			num3 = getStopStep(num2, flag, state, num);
			m_Reels[num].push(num3);
		}
	}

	public void OnAllStop()
	{
		isReady = false;
	}

	public static int getCorrect(int _num)
	{
		int i;
		for (i = _num; i >= 21; i -= 21)
		{
		}
		for (; i < 0; i += 21)
		{
		}
		return i;
	}

	public int getReelStop(int _num)
	{
		int result = -1;
		if (_num >= 0 && 3 > _num)
		{
			result = m_Reels[_num].stopStep;
			result = getCorrect(result);
		}
		return result;
	}

	public int getReelStep(int _num)
	{
		int result = -1;
		if (_num >= 0 && 3 > _num)
		{
			result = m_Reels[_num].nowStep;
			result = getCorrect(result);
		}
		return result;
	}

	public int getReelStopStep(int _num)
	{
		int result = -1;
		if (_num >= 0 && 3 > _num)
		{
			result = m_Reels[_num].stopStep;
			result = getCorrect(result);
		}
		return result;
	}

	public int getReelPushStep(int _num)
	{
		int result = -1;
		if (_num >= 0 && 3 > _num)
		{
			result = m_Reels[_num].pushStep;
			result = getCorrect(result);
		}
		return result;
	}

	public void setStep(int _num, int _prm)
	{
		if (_num >= 0 && 3 > _num)
		{
			m_Reels[_num].setStep(_prm);
		}
	}

	public bool isMove(int num)
	{
		if (num < 0 || num >= eREEL_NUM)
		{
			return false;
		}
		return m_Reels[num].isMove();
	}

	public bool isFreeze(int num)
	{
		if (num < 0 || num >= eREEL_NUM)
		{
			return false;
		}
		return m_Reels[num].state == ReelObject.MOVESTATE.FREEZE;
	}

	public int getStopStep(int koyaku, int flag, int state, int now)
	{
		string text = "RES036";
		int num = 0;
		switch (state)
		{
		case 1:
			switch (koyaku)
			{
			case 0:
				text = "RES001";
				break;
			case 1:
				text = "RES002";
				break;
			case 2:
				text = "RES003";
				break;
			case 3:
				text = "RES004";
				break;
			case 4:
				text = "RES005";
				break;
			case 5:
				text = "RES006";
				break;
			case 6:
				text = "RES007";
				break;
			case 7:
				text = "RES008";
				break;
			case 8:
				text = "RES009";
				break;
			case 9:
				text = "RES010";
				break;
			case 10:
				text = "RES011";
				break;
			case 11:
				text = "RES012";
				break;
			case 12:
				text = "RES013";
				break;
			case 13:
				text = "RES014";
				break;
			case 14:
				text = "RES015";
				break;
			case 15:
				text = "RES016";
				break;
			case 16:
				text = "RES017";
				break;
			case 17:
				text = "RES018";
				break;
			case 18:
				text = "RES019";
				break;
			case 19:
				text = "RES020";
				break;
			case 20:
				text = "RES021";
				break;
			case 21:
				text = "RES022";
				break;
			case 22:
				text = "RES023";
				break;
			case 23:
				text = "RES024";
				break;
			case 24:
				text = "RES025";
				break;
			case 25:
				text = "RES026";
				break;
			case 26:
				text = "RES027";
				break;
			case 27:
				text = "RES028";
				break;
			case 28:
				text = "RES029";
				break;
			case 29:
				text = "RES030";
				break;
			case 30:
				text = "RES031";
				break;
			case 31:
				text = "RES032";
				break;
			case 32:
				text = "RES033";
				break;
			case 33:
				text = "RES034";
				break;
			case 34:
				text = "RES035";
				break;
			}
			break;
		case 2:
			switch (koyaku)
			{
			case 50:
				text = "RES108";
				break;
			case 51:
				text = "RES109";
				break;
			}
			break;
		default:
			switch (flag)
			{
			case 1:
				switch (koyaku)
				{
				case 0:
					text = "RES037";
					break;
				case 1:
					text = "RES039";
					break;
				case 2:
					text = "RES041";
					break;
				case 3:
					text = "RES043";
					break;
				case 4:
					text = "RES045";
					break;
				case 5:
					text = "RES047";
					break;
				case 34:
					text = "RES077";
					break;
				case 35:
					text = "RES079";
					break;
				case 36:
					text = "RES081";
					break;
				case 37:
					text = "RES083";
					break;
				case 38:
					text = "RES085";
					break;
				case 39:
					text = "RES087";
					break;
				case 40:
					text = "RES089";
					break;
				case 41:
					text = "RES091";
					break;
				case 42:
					text = "RES093";
					break;
				case 43:
					text = "RES095";
					break;
				case 44:
					text = "RES097";
					break;
				case 45:
					text = "RES099";
					break;
				case 46:
					text = "RES101";
					break;
				case 47:
					text = "RES103";
					break;
				case 48:
					text = "RES105";
					break;
				case 49:
					text = "RES107";
					break;
				}
				break;
			case 2:
				text = "RES110";
				break;
			default:
				switch (koyaku)
				{
				case 0:
					text = "RES036";
					break;
				case 1:
					text = "RES038";
					break;
				case 2:
					text = "RES040";
					break;
				case 3:
					text = "RES042";
					break;
				case 4:
					text = "RES044";
					break;
				case 5:
					text = "RES046";
					break;
				case 6:
					text = "RES048";
					break;
				case 7:
					text = "RES049";
					break;
				case 8:
					text = "RES050";
					break;
				case 9:
					text = "RES055";
					break;
				case 10:
					text = "RES056";
					break;
				case 11:
					text = "RES057";
					break;
				case 12:
					text = "RES058";
					break;
				case 13:
					text = "RES051";
					break;
				case 14:
					text = "RES052";
					break;
				case 15:
					text = "RES053";
					break;
				case 16:
					text = "RES054";
					break;
				case 17:
					text = "RES059";
					break;
				case 18:
					text = "RES060";
					break;
				case 19:
					text = "RES061";
					break;
				case 20:
					text = "RES062";
					break;
				case 21:
					text = "RES063";
					break;
				case 22:
					text = "RES064";
					break;
				case 23:
					text = "RES065";
					break;
				case 24:
					text = "RES066";
					break;
				case 25:
					text = "RES067";
					break;
				case 26:
					text = "RES068";
					break;
				case 27:
					text = "RES069";
					break;
				case 28:
					text = "RES070";
					break;
				case 29:
					text = "RES071";
					break;
				case 30:
					text = "RES072";
					break;
				case 31:
					text = "RES073";
					break;
				case 32:
					text = "RES074";
					break;
				case 33:
					text = "RES075";
					break;
				case 34:
					text = "RES076";
					break;
				case 35:
					text = "RES078";
					break;
				case 36:
					text = "RES080";
					break;
				case 37:
					text = "RES082";
					break;
				case 38:
					text = "RES084";
					break;
				case 39:
					text = "RES086";
					break;
				case 40:
					text = "RES088";
					break;
				case 41:
					text = "RES089";
					break;
				case 42:
					text = "RES092";
					break;
				case 43:
					text = "RES094";
					break;
				case 44:
					text = "RES096";
					break;
				case 45:
					text = "RES098";
					break;
				case 46:
					text = "RES100";
					break;
				case 47:
					text = "RES102";
					break;
				case 48:
					text = "RES105";
					break;
				case 49:
					text = "RES107";
					break;
				}
				break;
			}
			break;
		}
		if (pushOrder[0] == 0)
		{
			text = ((pushOrder[1] != 1) ? (text + "1") : (text + "0"));
		}
		else if (pushOrder[0] == 1)
		{
			text = ((pushOrder[1] != 0) ? (text + "3") : (text + "2"));
		}
		else if (pushOrder[0] == 2)
		{
			text = ((pushOrder[1] != 0) ? (text + "5") : (text + "4"));
		}
		byte[] array = SGLG.readBinary(text + ".dat");
		int pushStep_OnStop = m_Reels[0].getPushStep_OnStop();
		int pushStep_OnStop2 = m_Reels[1].getPushStep_OnStop();
		int pushStep_OnStop3 = m_Reels[2].getPushStep_OnStop();
		int num2 = pushStep_OnStop * 441;
		int num3 = pushStep_OnStop2 * 21;
		int num4 = pushStep_OnStop3 * 1;
		int num5 = (num2 + num3 + num4) * 9;
		int num6 = num5 / 8;
		int num7 = num5 % 8;
		int num8 = num7;
		int num9;
		switch (now)
		{
		case 0:
			num9 = 0;
			break;
		case 1:
			num9 = 3;
			break;
		default:
			num9 = 6;
			break;
		}
		num7 = num8 + num9;
		int num10;
		if (num7 < 8)
		{
			num10 = ((6 > num7 || num7 > 7) ? array[num6] : ((array[num6 + 1] << 8) | array[num6]));
		}
		else
		{
			num10 = array[num6 + 1];
			num7 -= 8;
		}
		num10 >>= num7;
		return num10 & 7;
	}

	public bool isStopTiming(int idx, int target)
	{
		for (int i = target - 2; i <= target; i++)
		{
			int num = i;
			num = getCorrect(num);
			if (getReelStep(idx) == num)
			{
				return true;
			}
		}
		return false;
	}

	public bool isSameStep(int idx, int target)
	{
		return target == getReelStep(idx);
	}

	public void initFreeze()
	{
		freezeRunFlag = false;
		reelFreeze.Clear();
	}

	public void startFreeze()
	{
		freezeRunFlag = true;
		freezeRunCount = 0;
	}

	public void FreezeReelAct1()
	{
		initFreeze();
		reelFreeze.Add(new REEL_FREEZE(0, 0, m_Reels[0], 0, -1, 78, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(1, 0, m_Reels[1], 0, -1, 78, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(2, 0, m_Reels[2], 0, -1, 78, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(3, 78, m_Reels[0], 2, -1, 486, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(4, 78, m_Reels[1], 2, -1, 486, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(5, 78, m_Reels[2], 2, -1, 486, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(6, 522, m_Reels[0], 2, -1, -1, -1, 7));
		reelFreeze.Add(new REEL_FREEZE(7, 543, m_Reels[1], 2, -1, -1, -1, 6));
		reelFreeze.Add(new REEL_FREEZE(8, 564, m_Reels[2], 2, -1, -1, -1, 11));
		reelFreeze.Add(new REEL_FREEZE(9, 585, m_Reels[0], 0, -1, 30, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(10, 585, m_Reels[1], 0, -1, 30, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(11, 585, m_Reels[2], 0, -1, 30, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(12, 615, m_Reels[0], 1, -1, 45, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(13, 625, m_Reels[1], 1, -1, 45, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(14, 635, m_Reels[2], 1, -1, 45, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(15, 660, m_Reels[0], 4, -1, -1, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(15, 660, m_Reels[1], 4, -1, -1, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(15, 660, m_Reels[2], 4, -1, -1, -1, -1));
		startFreeze();
	}

	public void FreezeReelAct2()
	{
		initFreeze();
		reelFreeze.Add(new REEL_FREEZE(0, 0, m_Reels[0], 0, -1, 30, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(1, 0, m_Reels[1], 0, -1, 30, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(2, 0, m_Reels[2], 0, -1, 30, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(3, 30, m_Reels[0], 3, -1, -1, 5, -1));
		reelFreeze.Add(new REEL_FREEZE(4, 51, m_Reels[0], 0, -1, 10, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(5, 51, m_Reels[1], 0, -1, 10, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(6, 51, m_Reels[2], 0, -1, 10, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(7, 61, m_Reels[0], 1, -1, 30, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(8, 70, m_Reels[1], 1, -1, 20, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(9, 80, m_Reels[2], 1, -1, 10, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(10, 90, m_Reels[0], 4, -1, -1, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(10, 90, m_Reels[1], 4, -1, -1, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(10, 90, m_Reels[2], 4, -1, -1, -1, -1));
		startFreeze();
	}

	public void FreezeReelAct3()
	{
		initFreeze();
		reelFreeze.Add(new REEL_FREEZE(0, 0, m_Reels[0], 0, -1, 30, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(1, 0, m_Reels[1], 0, -1, 30, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(2, 0, m_Reels[2], 0, -1, 30, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(3, 30, m_Reels[0], 3, -1, -1, 5, -1));
		reelFreeze.Add(new REEL_FREEZE(4, 51, m_Reels[0], 0, -1, 10, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(5, 51, m_Reels[1], 0, -1, 10, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(6, 51, m_Reels[2], 0, -1, 10, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(7, 61, m_Reels[0], 0, -1, 30, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(8, 61, m_Reels[1], 0, -1, 30, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(9, 61, m_Reels[2], 0, -1, 30, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(10, 91, m_Reels[2], 3, -1, -1, 5, -1));
		reelFreeze.Add(new REEL_FREEZE(11, 112, m_Reels[0], 0, -1, 10, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(12, 112, m_Reels[1], 0, -1, 10, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(13, 112, m_Reels[2], 0, -1, 10, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(14, 122, m_Reels[0], 1, -1, 30, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(15, 132, m_Reels[1], 1, -1, 20, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(16, 142, m_Reels[2], 1, -1, 10, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(17, 152, m_Reels[0], 4, -1, -1, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(17, 152, m_Reels[1], 4, -1, -1, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(17, 152, m_Reels[2], 4, -1, -1, -1, -1));
		startFreeze();
	}

	public void FreezeReelAct4()
	{
		initFreeze();
		reelFreeze.Add(new REEL_FREEZE(0, 0, m_Reels[0], 0, -1, 30, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(1, 0, m_Reels[1], 0, -1, 30, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(2, 0, m_Reels[2], 0, -1, 30, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(3, 30, m_Reels[0], 3, -1, -1, 5, -1));
		reelFreeze.Add(new REEL_FREEZE(4, 51, m_Reels[0], 0, -1, 10, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(5, 51, m_Reels[1], 0, -1, 10, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(6, 51, m_Reels[2], 0, -1, 10, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(7, 61, m_Reels[0], 0, -1, 30, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(8, 61, m_Reels[1], 0, -1, 30, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(9, 61, m_Reels[2], 0, -1, 30, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(10, 91, m_Reels[2], 3, -1, -1, 5, -1));
		reelFreeze.Add(new REEL_FREEZE(11, 112, m_Reels[0], 0, -1, 10, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(12, 112, m_Reels[1], 0, -1, 10, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(13, 112, m_Reels[2], 0, -1, 10, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(14, 122, m_Reels[0], 0, -1, 30, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(15, 122, m_Reels[1], 0, -1, 30, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(16, 122, m_Reels[2], 0, -1, 30, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(17, 152, m_Reels[0], 3, -1, -1, 8, -1));
		reelFreeze.Add(new REEL_FREEZE(18, 152, m_Reels[1], 3, -1, -1, 8, -1));
		reelFreeze.Add(new REEL_FREEZE(19, 152, m_Reels[2], 3, -1, -1, 8, -1));
		reelFreeze.Add(new REEL_FREEZE(20, 173, m_Reels[0], 0, -1, 10, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(21, 173, m_Reels[1], 0, -1, 10, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(22, 173, m_Reels[2], 0, -1, 10, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(23, 183, m_Reels[0], 1, -1, 30, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(24, 193, m_Reels[1], 1, -1, 20, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(25, 203, m_Reels[2], 1, -1, 10, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(26, 213, m_Reels[0], 4, -1, -1, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(26, 213, m_Reels[1], 4, -1, -1, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(26, 213, m_Reels[2], 4, -1, -1, -1, -1));
		startFreeze();
	}

	public void FreezeReelAct5()
	{
		initFreeze();
		reelFreeze.Add(new REEL_FREEZE(0, 0, m_Reels[0], 0, -1, 30, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(1, 0, m_Reels[1], 0, -1, 30, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(2, 0, m_Reels[2], 0, -1, 30, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(3, 30, m_Reels[0], 3, -1, -1, 5, -1));
		reelFreeze.Add(new REEL_FREEZE(4, 51, m_Reels[0], 0, -1, 10, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(5, 51, m_Reels[1], 0, -1, 10, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(6, 51, m_Reels[2], 0, -1, 10, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(7, 61, m_Reels[0], 0, -1, 30, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(8, 61, m_Reels[1], 0, -1, 30, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(9, 61, m_Reels[2], 0, -1, 30, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(10, 91, m_Reels[2], 3, -1, -1, 5, -1));
		reelFreeze.Add(new REEL_FREEZE(11, 112, m_Reels[0], 0, -1, 10, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(12, 112, m_Reels[1], 0, -1, 10, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(13, 112, m_Reels[2], 0, -1, 10, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(14, 122, m_Reels[0], 0, -1, 30, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(15, 122, m_Reels[1], 0, -1, 30, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(16, 122, m_Reels[2], 0, -1, 30, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(17, 152, m_Reels[0], 3, -1, -1, 8, -1));
		reelFreeze.Add(new REEL_FREEZE(18, 152, m_Reels[1], 3, -1, -1, 8, -1));
		reelFreeze.Add(new REEL_FREEZE(19, 152, m_Reels[2], 3, -1, -1, 8, -1));
		reelFreeze.Add(new REEL_FREEZE(20, 173, m_Reels[0], 0, -1, 10, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(21, 173, m_Reels[1], 0, -1, 10, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(22, 173, m_Reels[2], 0, -1, 10, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(23, 188, m_Reels[0], 0, -1, 78, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(24, 188, m_Reels[1], 0, -1, 78, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(25, 188, m_Reels[2], 0, -1, 78, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(26, 266, m_Reels[0], 2, -1, 496, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(27, 266, m_Reels[1], 2, -1, 496, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(28, 266, m_Reels[2], 2, -1, 496, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(29, 710, m_Reels[0], 2, -1, -1, -1, 7));
		reelFreeze.Add(new REEL_FREEZE(30, 731, m_Reels[1], 2, -1, -1, -1, 6));
		reelFreeze.Add(new REEL_FREEZE(31, 752, m_Reels[2], 2, -1, -1, -1, 11));
		reelFreeze.Add(new REEL_FREEZE(32, 773, m_Reels[0], 0, -1, 50, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(33, 773, m_Reels[1], 0, -1, 40, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(34, 773, m_Reels[2], 0, -1, 30, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(35, 803, m_Reels[0], 1, -1, 45, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(36, 813, m_Reels[1], 1, -1, 45, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(37, 823, m_Reels[2], 1, -1, 45, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(38, 848, m_Reels[0], 4, -1, -1, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(38, 848, m_Reels[1], 4, -1, -1, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(38, 848, m_Reels[2], 4, -1, -1, -1, -1));
		startFreeze();
	}

	public void FreezeReelAct6()
	{
		initFreeze();
		reelFreeze.Add(new REEL_FREEZE(0, 0, m_Reels[0], 0, -1, 1, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(1, 0, m_Reels[1], 0, -1, 1, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(2, 0, m_Reels[2], 0, -1, 1, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(3, 1, m_Reels[0], 3, -1, -1, 3, -1));
		reelFreeze.Add(new REEL_FREEZE(4, 13, m_Reels[1], 3, -1, -1, 3, -1));
		reelFreeze.Add(new REEL_FREEZE(5, 25, m_Reels[2], 3, -1, -1, 3, -1));
		reelFreeze.Add(new REEL_FREEZE(6, 37, m_Reels[0], 0, -1, 15, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(7, 37, m_Reels[1], 0, -1, 15, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(8, 37, m_Reels[2], 0, -1, 15, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(9, 52, m_Reels[0], 1, -1, 30, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(10, 62, m_Reels[1], 1, -1, 20, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(11, 72, m_Reels[2], 1, -1, 10, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(12, 82, m_Reels[0], 4, -1, -1, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(12, 82, m_Reels[1], 4, -1, -1, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(12, 82, m_Reels[2], 4, -1, -1, -1, -1));
		startFreeze();
	}

	public void FreezeReelAct7()
	{
		initFreeze();
		reelFreeze.Add(new REEL_FREEZE(0, 0, m_Reels[0], 0, -1, 1, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(1, 0, m_Reels[1], 0, -1, 1, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(2, 0, m_Reels[2], 0, -1, 1, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(3, 1, m_Reels[0], 3, -1, -1, 3, -1));
		reelFreeze.Add(new REEL_FREEZE(4, 13, m_Reels[1], 3, -1, -1, 3, -1));
		reelFreeze.Add(new REEL_FREEZE(5, 25, m_Reels[2], 3, -1, -1, 3, -1));
		reelFreeze.Add(new REEL_FREEZE(6, 37, m_Reels[0], 0, -1, 15, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(7, 37, m_Reels[1], 0, -1, 15, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(8, 37, m_Reels[2], 0, -1, 15, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(9, 52, m_Reels[2], 3, -1, -1, 3, -1));
		reelFreeze.Add(new REEL_FREEZE(10, 64, m_Reels[1], 3, -1, -1, 3, -1));
		reelFreeze.Add(new REEL_FREEZE(11, 76, m_Reels[0], 3, -1, -1, 3, -1));
		reelFreeze.Add(new REEL_FREEZE(12, 98, m_Reels[0], 0, -1, 15, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(13, 98, m_Reels[1], 0, -1, 15, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(15, 98, m_Reels[2], 0, -1, 15, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(16, 114, m_Reels[0], 1, -1, 30, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(17, 124, m_Reels[1], 1, -1, 20, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(18, 134, m_Reels[2], 1, -1, 10, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(19, 144, m_Reels[0], 4, -1, -1, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(19, 144, m_Reels[1], 4, -1, -1, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(19, 144, m_Reels[2], 4, -1, -1, -1, -1));
		startFreeze();
	}

	public void FreezeReelAct8()
	{
		initFreeze();
		reelFreeze.Add(new REEL_FREEZE(0, 0, m_Reels[0], 0, -1, 1, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(1, 0, m_Reels[1], 0, -1, 1, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(2, 0, m_Reels[2], 0, -1, 1, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(3, 1, m_Reels[0], 3, -1, -1, 3, -1));
		reelFreeze.Add(new REEL_FREEZE(4, 13, m_Reels[1], 3, -1, -1, 3, -1));
		reelFreeze.Add(new REEL_FREEZE(5, 25, m_Reels[2], 3, -1, -1, 3, -1));
		reelFreeze.Add(new REEL_FREEZE(6, 37, m_Reels[0], 0, -1, 15, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(7, 37, m_Reels[1], 0, -1, 15, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(8, 37, m_Reels[2], 0, -1, 15, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(9, 52, m_Reels[2], 3, -1, -1, 3, -1));
		reelFreeze.Add(new REEL_FREEZE(10, 64, m_Reels[1], 3, -1, -1, 3, -1));
		reelFreeze.Add(new REEL_FREEZE(11, 76, m_Reels[0], 3, -1, -1, 3, -1));
		reelFreeze.Add(new REEL_FREEZE(12, 98, m_Reels[0], 0, -1, 15, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(13, 98, m_Reels[1], 0, -1, 15, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(15, 98, m_Reels[2], 0, -1, 15, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(16, 113, m_Reels[0], 3, 0, -1, 3, -1));
		reelFreeze.Add(new REEL_FREEZE(17, 113, m_Reels[1], 3, 0, -1, 3, -1));
		reelFreeze.Add(new REEL_FREEZE(18, 113, m_Reels[2], 3, 0, -1, 3, -1));
		reelFreeze.Add(new REEL_FREEZE(19, 125, m_Reels[0], 0, -1, 15, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(20, 125, m_Reels[1], 0, -1, 15, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(21, 125, m_Reels[2], 0, -1, 15, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(22, 140, m_Reels[0], 2, -1, -1, 3, -1));
		reelFreeze.Add(new REEL_FREEZE(23, 140, m_Reels[1], 1, -1, -1, 3, -1));
		reelFreeze.Add(new REEL_FREEZE(24, 140, m_Reels[2], 2, -1, -1, 3, -1));
		reelFreeze.Add(new REEL_FREEZE(25, 203, m_Reels[0], 2, -1, -1, -1, 1));
		reelFreeze.Add(new REEL_FREEZE(26, 203, m_Reels[1], 1, -1, -1, -1, 17));
		reelFreeze.Add(new REEL_FREEZE(27, 203, m_Reels[2], 2, -1, -1, -1, 4));
		reelFreeze.Add(new REEL_FREEZE(28, 224, m_Reels[0], 0, -1, 15, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(29, 224, m_Reels[1], 0, -1, 15, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(30, 224, m_Reels[2], 0, -1, 15, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(31, 239, m_Reels[0], 4, -1, -1, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(31, 239, m_Reels[1], 4, -1, -1, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(31, 239, m_Reels[2], 4, -1, -1, -1, -1));
		startFreeze();
	}

	public void FreezeReelAct9()
	{
		initFreeze();
		reelFreeze.Add(new REEL_FREEZE(0, 0, m_Reels[0], 0, -1, 15, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(1, 0, m_Reels[1], 0, -1, 15, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(2, 0, m_Reels[2], 0, -1, 15, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(3, 15, m_Reels[0], 2, 3, 480, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(4, 15, m_Reels[1], 2, 3, 480, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(5, 15, m_Reels[2], 2, 3, 480, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(6, 495, m_Reels[0], 0, -1, 15, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(7, 495, m_Reels[1], 0, -1, 15, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(8, 495, m_Reels[2], 0, -1, 15, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(9, 510, m_Reels[0], 1, -1, 30, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(10, 520, m_Reels[1], 1, -1, 20, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(11, 530, m_Reels[2], 1, -1, 10, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(12, 540, m_Reels[0], 4, -1, -1, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(12, 540, m_Reels[1], 4, -1, -1, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(12, 540, m_Reels[2], 4, -1, -1, -1, -1));
		startFreeze();
	}

	public void FreezeReelAct10()
	{
		initFreeze();
		reelFreeze.Add(new REEL_FREEZE(0, 0, m_Reels[0], 0, -1, 15, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(1, 0, m_Reels[1], 0, -1, 15, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(2, 0, m_Reels[2], 0, -1, 15, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(3, 15, m_Reels[0], 3, -1, -1, 3, -1));
		reelFreeze.Add(new REEL_FREEZE(4, 15, m_Reels[1], 3, -1, -1, 3, -1));
		reelFreeze.Add(new REEL_FREEZE(5, 15, m_Reels[2], 3, -1, -1, 3, -1));
		reelFreeze.Add(new REEL_FREEZE(6, 27, m_Reels[0], 0, -1, 60, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(7, 27, m_Reels[1], 0, -1, 60, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(8, 27, m_Reels[2], 0, -1, 60, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(9, 87, m_Reels[0], 0, -1, 60, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(10, 87, m_Reels[1], 0, -1, 60, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(11, 87, m_Reels[2], 0, -1, 60, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(12, 147, m_Reels[0], 1, -1, 30, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(13, 157, m_Reels[1], 1, -1, 20, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(14, 167, m_Reels[2], 1, -1, 10, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(15, 177, m_Reels[0], 4, -1, -1, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(15, 177, m_Reels[1], 4, -1, -1, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(15, 177, m_Reels[2], 4, -1, -1, -1, -1));
		startFreeze();
	}

	public void FreezeReelAct11()
	{
		initFreeze();
		reelFreeze.Add(new REEL_FREEZE(0, 0, m_Reels[0], 0, -1, 15, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(1, 0, m_Reels[1], 0, -1, 15, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(2, 0, m_Reels[2], 0, -1, 15, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(3, 15, m_Reels[0], 3, -1, -1, 3, -1));
		reelFreeze.Add(new REEL_FREEZE(4, 15, m_Reels[1], 3, -1, -1, 3, -1));
		reelFreeze.Add(new REEL_FREEZE(5, 15, m_Reels[2], 3, -1, -1, 3, -1));
		reelFreeze.Add(new REEL_FREEZE(6, 27, m_Reels[0], 0, -1, 60, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(7, 27, m_Reels[1], 0, -1, 60, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(8, 27, m_Reels[2], 0, -1, 60, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(9, 87, m_Reels[0], 2, -1, -1, 3, -1));
		reelFreeze.Add(new REEL_FREEZE(10, 87, m_Reels[1], 1, -1, -1, 4, -1));
		reelFreeze.Add(new REEL_FREEZE(11, 87, m_Reels[2], 2, -1, -1, 5, -1));
		reelFreeze.Add(new REEL_FREEZE(12, 150, m_Reels[0], 2, -1, -1, -1, 19));
		reelFreeze.Add(new REEL_FREEZE(13, 171, m_Reels[1], 1, -1, -1, -1, 19));
		reelFreeze.Add(new REEL_FREEZE(14, 192, m_Reels[2], 2, -1, -1, -1, 20));
		reelFreeze.Add(new REEL_FREEZE(15, 213, m_Reels[0], 0, -1, 290, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(16, 213, m_Reels[1], 0, -1, 290, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(17, 213, m_Reels[2], 0, -1, 290, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(18, 503, m_Reels[0], 1, -1, 30, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(19, 513, m_Reels[1], 1, -1, 20, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(20, 523, m_Reels[2], 1, -1, 10, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(21, 533, m_Reels[0], 4, -1, -1, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(21, 533, m_Reels[1], 4, -1, -1, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(21, 533, m_Reels[2], 4, -1, -1, -1, -1));
		startFreeze();
	}

	public void FreezeReelAct12()
	{
		initFreeze();
		reelFreeze.Add(new REEL_FREEZE(0, 0, m_Reels[0], 0, -1, 15, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(1, 0, m_Reels[1], 0, -1, 15, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(2, 0, m_Reels[2], 0, -1, 15, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(3, 15, m_Reels[0], 3, -1, -1, 3, -1));
		reelFreeze.Add(new REEL_FREEZE(4, 15, m_Reels[1], 3, -1, -1, 3, -1));
		reelFreeze.Add(new REEL_FREEZE(5, 15, m_Reels[2], 3, -1, -1, 3, -1));
		reelFreeze.Add(new REEL_FREEZE(6, 27, m_Reels[0], 0, -1, 60, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(7, 27, m_Reels[1], 0, -1, 60, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(8, 27, m_Reels[2], 0, -1, 60, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(9, 87, m_Reels[0], 2, -1, -1, 3, -1));
		reelFreeze.Add(new REEL_FREEZE(10, 87, m_Reels[1], 1, -1, -1, 4, -1));
		reelFreeze.Add(new REEL_FREEZE(11, 87, m_Reels[2], 2, -1, -1, 5, -1));
		reelFreeze.Add(new REEL_FREEZE(12, 150, m_Reels[0], 2, -1, -1, -1, 19));
		reelFreeze.Add(new REEL_FREEZE(13, 171, m_Reels[1], 1, -1, -1, -1, 19));
		reelFreeze.Add(new REEL_FREEZE(14, 192, m_Reels[2], 2, -1, -1, -1, 19));
		reelFreeze.Add(new REEL_FREEZE(15, 213, m_Reels[0], 0, -1, 290, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(16, 213, m_Reels[1], 0, -1, 290, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(17, 213, m_Reels[2], 0, -1, 290, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(18, 503, m_Reels[0], 1, -1, 30, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(19, 513, m_Reels[1], 1, -1, 20, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(20, 523, m_Reels[2], 1, -1, 10, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(21, 533, m_Reels[0], 4, -1, -1, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(21, 533, m_Reels[1], 4, -1, -1, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(21, 533, m_Reels[2], 4, -1, -1, -1, -1));
		startFreeze();
	}

	public void FreezeReelAct8_1()
	{
		initFreeze();
		reelFreeze.Add(new REEL_FREEZE(0, 0, m_Reels[0], 1, 3, -1, -1, 3));
		reelFreeze.Add(new REEL_FREEZE(1, 0, m_Reels[1], 2, 3, -1, -1, 15));
		reelFreeze.Add(new REEL_FREEZE(2, 0, m_Reels[2], 1, 3, -1, -1, 6));
		reelFreeze.Add(new REEL_FREEZE(3, 21, m_Reels[0], 0, -1, 73, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(4, 21, m_Reels[1], 0, -1, 73, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(5, 21, m_Reels[2], 0, -1, 73, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(6, 94, m_Reels[0], 3, 0, -1, 3, -1));
		reelFreeze.Add(new REEL_FREEZE(7, 94, m_Reels[1], 3, 0, -1, 3, -1));
		reelFreeze.Add(new REEL_FREEZE(8, 94, m_Reels[2], 3, 0, -1, 3, -1));
		reelFreeze.Add(new REEL_FREEZE(9, 107, m_Reels[0], 0, -1, 73, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(10, 107, m_Reels[1], 0, -1, 73, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(11, 107, m_Reels[2], 0, -1, 73, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(12, 179, m_Reels[0], 2, 3, -1, -1, 1));
		reelFreeze.Add(new REEL_FREEZE(13, 179, m_Reels[1], 1, 3, -1, -1, 17));
		reelFreeze.Add(new REEL_FREEZE(14, 179, m_Reels[2], 2, 3, -1, -1, 4));
		reelFreeze.Add(new REEL_FREEZE(15, 200, m_Reels[0], 0, -1, 100, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(16, 200, m_Reels[1], 0, -1, 100, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(17, 200, m_Reels[2], 0, -1, 100, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(21, 200, m_Reels[0], 4, -1, -1, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(21, 200, m_Reels[1], 4, -1, -1, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(21, 200, m_Reels[2], 4, -1, -1, -1, -1));
		startFreeze();
	}

	public void FreezeReelAct8_3()
	{
		initFreeze();
		reelFreeze.Add(new REEL_FREEZE(0, 0, m_Reels[0], 0, -1, 30, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(1, 0, m_Reels[1], 0, -1, 30, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(2, 0, m_Reels[2], 0, -1, 30, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(3, 30, m_Reels[0], 0, -1, 90, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(4, 30, m_Reels[1], 0, -1, 90, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(5, 30, m_Reels[2], 0, -1, 90, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(6, 120, m_Reels[0], 0, -1, 60, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(7, 120, m_Reels[1], 0, -1, 60, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(8, 120, m_Reels[2], 0, -1, 60, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(9, 180, m_Reels[0], 1, -1, 30, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(10, 190, m_Reels[1], 1, -1, 20, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(11, 200, m_Reels[2], 1, -1, 10, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(12, 210, m_Reels[0], 4, -1, -1, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(12, 210, m_Reels[1], 4, -1, -1, -1, -1));
		reelFreeze.Add(new REEL_FREEZE(12, 210, m_Reels[2], 4, -1, -1, -1, -1));
		startFreeze();
	}
}
