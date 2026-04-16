public class SaveData
{
	public uint SerVerTime;

	public uint AppTimer;

	public GameData game = new GameData();

	public HallData hall = new HallData();

	public void clear()
	{
		SerVerTime = 0u;
		AppTimer = 0u;
		game.clear();
		hall.clear();
	}
}
