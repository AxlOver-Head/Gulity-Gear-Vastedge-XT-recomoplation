public abstract class SGLG_PlugIn_Abstract
{
	public abstract int test();

	public abstract int lotKoyaku(int cnt);

	public abstract void all_clr();

	public abstract void startLot_LeverOn_yaku();

	public abstract void startLot_LeverOn_prod();

	public abstract void startLot_ReelStart();

	public abstract void startLot_Reel1();

	public abstract void startLot_Reel2();

	public abstract void startLot_Reel3();

	public abstract void startLot_Reel3off();

	public abstract void startLot_ReelStop(int _stopNum, int _kind);

	public abstract void startLot_Bet();

	public abstract void startLot_Prod();

	public abstract int get_koyaku_prm(int prm);

	public abstract void set_koyaku_prm(int id, int prm);

	public abstract char get_dir_cmd(int trg, int ptn);

	public abstract char get_dir_cmd2(int trg, int ptn, int _usGrp, int _usDir);

	public abstract int get_dir_data(int prm);

	public abstract int get_pdt_data(int prm);

	public abstract long get_pkd_data_long(int prm);

	public abstract int get_pkd_data(int prm);

	public abstract int set_pdt_data(int id, int prm);

	public abstract int set_pkd_data_long(int id, long prm);

	public abstract int set_pkd_data(int id, int prm);

	public abstract void init_cmd();

	public abstract char get_cmd(int _ptn, int _lay, int _num);

	public abstract short get_pri_data(int prm);

	public abstract short set_pri_data(int id, int prm);

	public abstract void set_main_cmd(int _id, int _prm);

	public abstract int get_main_cmd(int _id);

	public abstract short get_pgm_data(int _id);

	public abstract short set_pgm_data(int _id, int _prm);

	public abstract short get_SubCmdBuf(int _num);

	public abstract short set_SubCmdBuf(int _num, int _prm);
}
