public class DirectionLedEvent
{
	public const int DLE_KPLAY = 0;

	public const int DLE_HPLAY = 1;

	public const int DLE_LOOP = 2;

	public const int DLE_LOOPST = 3;

	public const int DLE_LOFF = 4;

	public const int DLE_STOP = 5;

	public const int DLE_WAITF = 6;

	public int runFrame;

	public int runEvent;

	public int runParam;

	public DirectionLedEvent(int _frame, int _event, int _param)
	{
		runFrame = _frame;
		runEvent = _event;
		runParam = _param;
	}
}
