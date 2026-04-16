public class GameData
{
	public MachineData machine0 = new MachineData();

	public MachineData machine1 = new MachineData();

	public MachineData machine2 = new MachineData();

	public MachineData machine3 = new MachineData();

	public MachineData machine4 = new MachineData();

	public MachineData machine5 = new MachineData();

	public MachineData machine6 = new MachineData();

	public MachineData machine7 = new MachineData();

	public MachineData machine8 = new MachineData();

	public MachineData machine9 = new MachineData();

	public int selectMachine;

	public int motiMedals;

	public MachineData getMachineData(int idx)
	{
		switch (idx)
		{
		case 0:
			return machine0;
		case 1:
			return machine1;
		case 2:
			return machine2;
		case 3:
			return machine3;
		case 4:
			return machine4;
		case 5:
			return machine5;
		case 6:
			return machine6;
		case 7:
			return machine7;
		case 8:
			return machine8;
		case 9:
			return machine9;
		default:
			return null;
		}
	}

	public void clear()
	{
		machine0.clear();
		machine1.clear();
		machine2.clear();
		machine3.clear();
		machine4.clear();
		machine5.clear();
		machine6.clear();
		machine7.clear();
		machine8.clear();
		machine9.clear();
		selectMachine = 0;
		motiMedals = 0;
	}
}
