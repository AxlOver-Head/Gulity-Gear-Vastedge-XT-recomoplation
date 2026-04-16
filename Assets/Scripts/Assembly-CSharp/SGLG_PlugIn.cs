using UnityEngine;

public class SGLG_PlugIn
{
	private static SGLG_PlugIn_Abstract pluginInstance;

public static void init()
{
    if (Application.platform == RuntimePlatform.OSXEditor)
    {
        pluginInstance = new SGLG_PlugIn_MacOS();
    }
    else if (Application.platform == RuntimePlatform.WindowsEditor
          || Application.platform == RuntimePlatform.WindowsPlayer)
    {
        pluginInstance = new SGLG_PlugIn_Windows(); // ← stub, no native DLL
    }
    else if (Application.platform == RuntimePlatform.Android)
    {
        pluginInstance = new SGLG_PlugIn_Android();
    }
    else if (Application.platform == RuntimePlatform.IPhonePlayer)
    {
        pluginInstance = new SGLG_PlugIn_iOS();
    }

    if (pluginInstance == null)
        Debug.LogError($"SGLG_PlugIn: No implementation for platform: {Application.platform}");
	}

	public static int test()
	{
		return pluginInstance.test();
	}

	public static int lotKoyaku(int cnt)
	{
		return pluginInstance.lotKoyaku(cnt);
	}

	public static void all_clr()
	{
		pluginInstance.all_clr();
	}

	public static void startLot_LeverOn_yaku()
	{
		pluginInstance.startLot_LeverOn_yaku();
	}

	public static void startLot_LeverOn_prod()
	{
		pluginInstance.startLot_LeverOn_prod();
	}

	public static void startLot_ReelStart()
	{
		pluginInstance.startLot_ReelStart();
	}

	public static void startLot_Reel1()
	{
		pluginInstance.startLot_Reel1();
	}

	public static void startLot_Reel2()
	{
		pluginInstance.startLot_Reel2();
	}

	public static void startLot_Reel3()
	{
		pluginInstance.startLot_Reel3();
	}

	public static void startLot_Reel3off()
	{
		pluginInstance.startLot_Reel3off();
	}

	public static void startLot_ReelStop(int _stopNum, int _kind)
	{
		pluginInstance.startLot_ReelStop(_stopNum, _kind);
	}

	public static void startLot_Bet()
	{
		pluginInstance.startLot_Bet();
	}

	public static void startLot_Prod()
	{
		pluginInstance.startLot_Prod();
	}

	public static int get_koyaku_prm(int prm)
	{
		return pluginInstance.get_koyaku_prm(prm);
	}

	public static void set_koyaku_prm(int id, int prm)
	{
		pluginInstance.set_koyaku_prm(id, prm);
	}

	public static char get_dir_cmd(int trg, int ptn)
	{
		return pluginInstance.get_dir_cmd(trg, ptn);
	}

	public static char get_dir_cmd2(int trg, int ptn, int _usGrp, int _usDir)
	{
		return pluginInstance.get_dir_cmd2(trg, ptn, _usGrp, _usDir);
	}

	public static int get_dir_data(int prm)
	{
		return pluginInstance.get_dir_data(prm);
	}

	public static int get_pdt_data(int prm)
	{
		return pluginInstance.get_pdt_data(prm);
	}

	public static long get_pkd_data_long(int prm)
	{
		return pluginInstance.get_pkd_data_long(prm);
	}

	public static int get_pkd_data(int prm)
	{
		return pluginInstance.get_pkd_data(prm);
	}

	public static int set_pdt_data(int id, int prm)
	{
		return pluginInstance.set_pdt_data(id, prm);
	}

	public static int set_pkd_data_long(int id, long prm)
	{
		return pluginInstance.set_pkd_data_long(id, prm);
	}

	public static int set_pkd_data(int id, int prm)
	{
		return pluginInstance.set_pkd_data(id, prm);
	}

	public static void init_cmd()
	{
		pluginInstance.init_cmd();
	}

	public static char get_cmd(int _ptn, int _lay, int _num)
	{
		return pluginInstance.get_cmd(_ptn, _lay, _num);
	}

	public static short get_pri_data(int prm)
	{
		return pluginInstance.get_pri_data(prm);
	}

	public static short set_pri_data(int id, int prm)
	{
		return pluginInstance.set_pri_data(id, prm);
	}

	public static void set_main_cmd(int _id, int _prm)
	{
		pluginInstance.set_main_cmd(_id, _prm);
	}

	public static int get_main_cmd(int _id)
	{
		return pluginInstance.get_main_cmd(_id);
	}

	public static short get_pgm_data(int _id)
	{
		return pluginInstance.get_pgm_data(_id);
	}

	public static short set_pgm_data(int _id, int _prm)
	{
		return pluginInstance.set_pgm_data(_id, _prm);
	}

	public static short get_SubCmdBuf(int _num)
	{
		return pluginInstance.get_SubCmdBuf(_num);
	}

	public static short set_SubCmdBuf(int _num, int _prm)
	{
		return pluginInstance.set_SubCmdBuf(_num, _prm);
	}
}
