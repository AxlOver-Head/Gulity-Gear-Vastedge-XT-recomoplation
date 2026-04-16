public class Sim_MachineSaveData
{
	public uint SerVerTime;

	public uint AppTimer;

	public MachineData machine = new MachineData();

	public int settei;

	public int dispSettei = 6;

	public int m_Current;

	public int[] m_Slump_game = new int[SlumpDataSim.GAME_MAX / SlumpDataSim.SAVE_GAME];

	public int[] m_Slump_medal = new int[SlumpDataSim.GAME_MAX / SlumpDataSim.SAVE_GAME];

	public void set()
	{
		if (MainGameScene.slotGameMan != null && MainGameScene.slotGameMan.m_SlumpDataSim != null)
		{
			m_Current = MainGameScene.slotGameMan.m_SlumpDataSim.m_Current;
			for (int i = 0; i < m_Current; i++)
			{
				m_Slump_game[i] = MainGameScene.slotGameMan.m_SlumpDataSim.m_Slump[i].game;
				m_Slump_medal[i] = MainGameScene.slotGameMan.m_SlumpDataSim.m_Slump[i].medal;
			}
		}
	}

	public void setState()
	{
	}

	public void get()
	{
		if (MainGameScene.slotGameMan != null && MainGameScene.slotGameMan.m_SlumpDataSim != null)
		{
			for (int i = 0; i < m_Current; i++)
			{
				MainGameScene.slotGameMan.m_SlumpDataSim.addData(m_Slump_game[i], m_Slump_medal[i]);
			}
		}
	}

	public void clear()
	{
		SerVerTime = 0u;
		AppTimer = 0u;
		machine.clear();
		settei = 0;
		dispSettei = 6;
		m_Current = 0;
		m_Slump_game = new int[SlumpDataSim.GAME_MAX / SlumpDataSim.SAVE_GAME];
		m_Slump_medal = new int[SlumpDataSim.GAME_MAX / SlumpDataSim.SAVE_GAME];
	}
}
