using System.Collections.Generic;

public class DirectionYakuData
{
	public List<DirectionYakuEvent> dyEvent = new List<DirectionYakuEvent>
	{
		Capacity = 128
	};

	public int loopFrame;

	public int loopNum;

	public bool loopFlag;

	public bool loopStFlag;

	public int nowFrame;

	public bool initFlag;

	public DirectionYakuData()
	{
		loopFrame = 0;
		loopNum = 255;
		nowFrame = 0;
		initFlag = false;
		loopFlag = false;
		loopStFlag = false;
		dyEvent.Clear();
	}

	public void init()
	{
		loopFrame = 0;
		loopNum = 255;
		nowFrame = 0;
		initFlag = false;
		loopFlag = false;
		loopStFlag = false;
		dyEvent.Clear();
	}

	public void control(YakuManager _yaku, panelManager _pm)
	{
		if (dyEvent.Count == 0)
		{
			return;
		}
		foreach (DirectionYakuEvent item in dyEvent)
		{
			if (nowFrame != item.run_frame)
			{
				continue;
			}
			switch (item.run_event)
			{
			case 8:
				_yaku.start((YakuManager.KIND)item.run_kind, item.run_param);
				break;
			case 3:
				if (loopNum > 0)
				{
					nowFrame = loopFrame;
					if (0 < loopNum && loopNum < 255)
					{
						loopNum--;
					}
					loopFlag = true;
				}
				break;
			case 4:
				if (!loopStFlag)
				{
					loopFrame = nowFrame - 1;
					loopNum = item.run_param;
					loopStFlag = true;
					if (loopNum == 0)
					{
						loopNum = ((loopNum != 0) ? loopNum : 255);
					}
				}
				break;
			case 10:
			case 11:
				_pm.onDamageCmd();
				break;
			case 12:
				initFlag = true;
				break;
			}
		}
		if (initFlag)
		{
			init();
		}
		if (65535 > nowFrame)
		{
			nowFrame++;
		}
		else
		{
			initFlag = true;
		}
	}

	public void setFrame(int _frame)
	{
		nowFrame = _frame;
	}

	public void setLoopFrame(int _frame)
	{
		loopFrame = _frame;
	}

	public void setLoopNum(int _num)
	{
		loopNum = _num;
	}

	public void setEvent(int _frame, int _kind, int _param, int _event)
	{
		dyEvent.Add(new DirectionYakuEvent(_frame, _kind, _param, _event));
	}
}
