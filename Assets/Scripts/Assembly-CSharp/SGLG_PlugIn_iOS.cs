using System.Runtime.InteropServices;

public class SGLG_PlugIn_iOS : SGLG_PlugIn_Abstract
{
	public const string dllInportName = "__Internal";

	[DllImport("__Internal")]
	private static extern void _sglgtest();

	[DllImport("__Internal")]
	private static extern int _wn_wcal(int cnt);

	[DllImport("__Internal")]
	private static extern void _all_clr();

	[DllImport("__Internal")]
	private static extern void _startLot_LeverOn_yaku();

	[DllImport("__Internal")]
	private static extern void _startLot_LeverOn_prod();

	[DllImport("__Internal")]
	private static extern void _startLot_ReelStart();

	[DllImport("__Internal")]
	private static extern void _startLot_Reel1();

	[DllImport("__Internal")]
	private static extern void _startLot_Reel2();

	[DllImport("__Internal")]
	private static extern void _startLot_Reel3();

	[DllImport("__Internal")]
	private static extern void _startLot_Reel3off();

	[DllImport("__Internal")]
	private static extern void _startLot_ReelStop(int _stopNum, int _kind);

	[DllImport("__Internal")]
	private static extern void _startLot_Bet();

	[DllImport("__Internal")]
	private static extern void _startLot_Prod();

	[DllImport("__Internal")]
	private static extern int _get_koyaku_prm(int prm);

	[DllImport("__Internal")]
	private static extern void _set_koyaku_prm(int id, int prm);

	[DllImport("__Internal")]
	private static extern char _get_dir_cmd(int trg, int ptn);

	[DllImport("__Internal")]
	private static extern char _get_dir_cmd2(int trg, int ptn, int _usGrp, int _usDir);

	[DllImport("__Internal")]
	private static extern int _get_dir_data(int prm);

	[DllImport("__Internal")]
	private static extern int _get_pdt_data(int prm);

	[DllImport("__Internal")]
	private static extern long _get_pkd_data_long(int prm);

	[DllImport("__Internal")]
	private static extern int _get_pkd_data(int prm);

	[DllImport("__Internal")]
	private static extern int _set_pdt_data(int id, int prm);

	[DllImport("__Internal")]
	private static extern int _set_pkd_data_long(int id, long prm);

	[DllImport("__Internal")]
	private static extern int _set_pkd_data(int id, int prm);

	[DllImport("__Internal")]
	private static extern void _init_cmd();

	[DllImport("__Internal")]
	private static extern char _get_cmd(int _ptn, int _lay, int _num);

	[DllImport("__Internal")]
	private static extern short _get_pri_data(int prm);

	[DllImport("__Internal")]
	private static extern short _set_pri_data(int id, int prm);

	[DllImport("__Internal")]
	private static extern void _set_main_cmd(int _id, int _prm);

	[DllImport("__Internal")]
	private static extern int _get_main_cmd(int _id);

	[DllImport("__Internal")]
	private static extern short _get_pgm_data(int _id);

	[DllImport("__Internal")]
	private static extern short _set_pgm_data(int _id, int _prm);

	[DllImport("__Internal")]
	private static extern short _get_SubCmdBuf(int _num);

	[DllImport("__Internal")]
	private static extern short _set_SubCmdBuf(int _num, int _prm);

	public override int test()
	{
		_sglgtest();
		return 3;
	}

	public override int lotKoyaku(int cnt)
	{
		return _wn_wcal(cnt);
	}

	public override void all_clr()
	{
		_all_clr();
	}

	public override void startLot_LeverOn_yaku()
	{
		_startLot_LeverOn_yaku();
	}

	public override void startLot_LeverOn_prod()
	{
		_startLot_LeverOn_prod();
	}

	public override void startLot_ReelStart()
	{
		_startLot_ReelStart();
	}

	public override void startLot_Reel1()
	{
		_startLot_Reel1();
	}

	public override void startLot_Reel2()
	{
		_startLot_Reel2();
	}

	public override void startLot_Reel3()
	{
		_startLot_Reel3();
	}

	public override void startLot_Reel3off()
	{
		_startLot_Reel3off();
	}

	public override void startLot_ReelStop(int _stopNum, int _kind)
	{
		_startLot_ReelStop(_stopNum, _kind);
	}

	public override void startLot_Bet()
	{
		_startLot_Bet();
	}

	public override void startLot_Prod()
	{
		_startLot_Prod();
	}

	public override int get_koyaku_prm(int prm)
	{
		return _get_koyaku_prm(prm);
	}

	public override void set_koyaku_prm(int id, int prm)
	{
		_set_koyaku_prm(id, prm);
	}

	public override char get_dir_cmd(int trg, int ptn)
	{
		return _get_dir_cmd(trg, ptn);
	}

	public override char get_dir_cmd2(int trg, int ptn, int _usGrp, int _usDir)
	{
		return _get_dir_cmd2(trg, ptn, _usGrp, _usDir);
	}

	public override int get_dir_data(int prm)
	{
		return _get_dir_data(prm);
	}

	public override int get_pdt_data(int prm)
	{
		return _get_pdt_data(prm);
	}

	public override long get_pkd_data_long(int prm)
	{
		return _get_pkd_data_long(prm);
	}

	public override int get_pkd_data(int prm)
	{
		return _get_pkd_data(prm);
	}

	public override int set_pdt_data(int id, int prm)
	{
		return _set_pdt_data(id, prm);
	}

	public override int set_pkd_data_long(int id, long prm)
	{
		return _set_pkd_data_long(id, prm);
	}

	public override int set_pkd_data(int id, int prm)
	{
		return _set_pkd_data(id, prm);
	}

	public override void init_cmd()
	{
		_init_cmd();
	}

	public override char get_cmd(int _ptn, int _lay, int _num)
	{
		return _get_cmd(_ptn, _lay, _num);
	}

	public override short get_pri_data(int prm)
	{
		return _get_pri_data(prm);
	}

	public override short set_pri_data(int id, int prm)
	{
		return _set_pri_data(id, prm);
	}

	public override void set_main_cmd(int _id, int _prm)
	{
		_set_main_cmd(_id, _prm);
	}

	public override int get_main_cmd(int _id)
	{
		return _get_main_cmd(_id);
	}

	public override short get_pgm_data(int _id)
	{
		return _get_pgm_data(_id);
	}

	public override short set_pgm_data(int _id, int _prm)
	{
		return _set_pgm_data(_id, _prm);
	}

	public override short get_SubCmdBuf(int _num)
	{
		return _get_SubCmdBuf(_num);
	}

	public override short set_SubCmdBuf(int _num, int _prm)
	{
		return _set_SubCmdBuf(_num, _prm);
	}
}
