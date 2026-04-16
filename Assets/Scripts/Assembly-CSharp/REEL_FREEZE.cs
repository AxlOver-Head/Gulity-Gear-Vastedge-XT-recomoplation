public class REEL_FREEZE
{
	public const int EV_NONE = -1;

	public const int EV_WAIT = 0;

	public const int EV_PLUS = 1;

	public const int EV_MINUS = 2;

	public const int EV_SHAKE = 3;

	public const int EV_END = 4;

	public int number;

	public int eventID;

	public int start;

	public int speed;

	public int frame;

	public int loop;

	public int step;

	public int cnt;

	public ReelObject reel;

	public int run_event;

	public bool moveFlag;

	public REEL_FREEZE(int _number, int _start, ReelObject _reel, int _event, int _speed, int _frame, int _loop, int _step)
	{
		number = _number;
		eventID = _event;
		reel = _reel;
		start = (int)((float)_start * (ReelObject.REEL_FPS / 30f));
		speed = _speed;
		frame = (int)((float)_frame * (ReelObject.REEL_FPS / 30f));
		loop = _loop;
		step = _step;
	}

	public bool control(int count)
	{
		bool result = true;
		if (count == start)
		{
			reel.fEventSet(eventID, number);
			cnt = 0;
		}
		if (reel.fGetNumber() == number)
		{
			run_event = reel.fEventGet();
			switch (run_event)
			{
			case -1:
				result = true;
				break;
			case 0:
				result = true;
				reel.fWaitProc(frame, cnt);
				cnt++;
				break;
			case 1:
				result = true;
				reel.fPlusProc(speed, loop, frame, step, cnt);
				cnt++;
				break;
			case 2:
				result = true;
				reel.fMinusProc(speed, loop, frame, step, cnt);
				cnt++;
				break;
			case 3:
				result = true;
				reel.fShakeProc(speed, loop);
				cnt++;
				break;
			case 4:
				result = false;
				reel.fEndProc();
				cnt++;
				break;
			}
		}
		else
		{
			run_event = -2;
		}
		return result;
	}

	public int getEvent()
	{
		return run_event;
	}

	public ReelObject getReel()
	{
		return reel;
	}

	public bool getMove()
	{
		return moveFlag;
	}
}
