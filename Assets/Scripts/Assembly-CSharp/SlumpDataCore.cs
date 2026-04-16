public class SlumpDataCore
{
	public bool active;

	public int game;

	public int medal;

	public SlumpDataCore()
	{
		active = false;
		game = 0;
		medal = 0;
	}

	public void setData(int _game, int _medal)
	{
		active = true;
		game = _game;
		medal = _medal;
	}
}
