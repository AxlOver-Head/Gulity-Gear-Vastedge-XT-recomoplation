public class DirectionYakuEvent
{
	public const int NON = 0;

	public const int CALL = 1;

	public const int REQ = 2;

	public const int LOOP = 3;

	public const int LOOPST = 4;

	public const int WAITF = 5;

	public const int RET = 6;

	public const int SUBC = 7;

	public const int MPLAY = 8;

	public const int MEMW = 9;

	public const int P_ATK = 10;

	public const int E_ATK = 11;

	public const int INIT = 12;

	public int run_frame;

	public int run_kind;

	public int run_param;

	public int run_event;

	public DirectionYakuEvent(int _frame, int _kind, int _param, int _event)
	{
		run_frame = _frame;
		run_kind = _kind;
		run_param = _param;
		run_event = _event;
	}
}
