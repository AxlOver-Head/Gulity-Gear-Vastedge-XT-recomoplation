using System.Collections.Generic;

public class DirectionLedData
{
	public int lineId;

	public LEDMainManager.LINE mainLine;

	public LEDPanelManager.LINE panelLine;

	public int loopFrame;

	public int loopNum;

	public bool loopFlag;

	public int nowFrame;

	public List<DirectionLedEvent> dlEvent = new List<DirectionLedEvent>
	{
		Capacity = 128
	};

	private bool initFlag;

	public DirectionLedData(int _lineId, LEDMainManager.LINE _line)
	{
		initFlag = false;
		loopFrame = 0;
		loopNum = 255;
		nowFrame = 0;
		loopFlag = false;
		dlEvent.Clear();
		lineId = _lineId;
		mainLine = _line;
	}

	public DirectionLedData(int _lineId, LEDPanelManager.LINE _line)
	{
		initFlag = false;
		loopFrame = 0;
		loopNum = 255;
		nowFrame = 0;
		loopFlag = false;
		dlEvent.Clear();
		lineId = _lineId;
		panelLine = _line;
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

	public void setEvent(int _frame, int _event, int _param)
	{
		dlEvent.Add(new DirectionLedEvent(_frame, _event, _param));
	}

	public void init()
	{
		initFlag = false;
		loopFrame = 0;
		loopNum = 255;
		nowFrame = 0;
		loopFlag = false;
		dlEvent.Clear();
	}

	public void control(LEDMainManager _lmm, LEDPanelManager _lpm)
	{
		if (dlEvent.Count == 0)
		{
			return;
		}
		foreach (DirectionLedEvent item in dlEvent)
		{
			if (nowFrame != item.runFrame)
			{
				continue;
			}
			switch (item.runEvent)
			{
			case 0:
				if (lineId < 17)
				{
					_lmm.kstart(mainLine, item.runParam, true);
				}
				else
				{
					_lpm.kstart(panelLine, item.runParam, true);
				}
				break;
			case 1:
				if (lineId < 17)
				{
					_lmm.start(mainLine, item.runParam, true);
				}
				else
				{
					_lpm.start(panelLine, item.runParam, true);
				}
				break;
			case 2:
				if (loopNum > 0)
				{
					nowFrame = loopFrame;
					if (0 < loopNum && loopNum < 255)
					{
						loopNum--;
					}
				}
				break;
			case 3:
				if (!loopFlag)
				{
					loopFrame = nowFrame - 1;
					loopNum = item.runParam;
					loopFlag = true;
					if (loopNum == 0)
					{
						loopNum = ((loopNum != 0) ? loopNum : 255);
					}
				}
				break;
			case 4:
				initFlag = true;
				if (lineId < 17)
				{
					_lmm.stop(mainLine);
				}
				else
				{
					_lpm.stop(panelLine);
				}
				break;
			case 5:
				initFlag = true;
				if (lineId < 17)
				{
					_lmm.stop(mainLine);
				}
				else
				{
					_lpm.stop(panelLine);
				}
				break;
			}
		}
		if (initFlag)
		{
			init();
		}
		nowFrame++;
	}
}
