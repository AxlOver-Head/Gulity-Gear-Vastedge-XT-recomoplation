public class SGLG_PlugIn_Windows : SGLG_PlugIn_Abstract
{
    public override int test() { return 0; }
    public override int lotKoyaku(int cnt) { return 0; }
    public override void all_clr() { }
    public override void startLot_LeverOn_yaku() { }
    public override void startLot_LeverOn_prod() { }
    public override void startLot_ReelStart() { }
    public override void startLot_Reel1() { }
    public override void startLot_Reel2() { }
    public override void startLot_Reel3() { }
    public override void startLot_Reel3off() { }
    public override void startLot_ReelStop(int _stopNum, int _kind) { }
    public override void startLot_Bet() { }
    public override void startLot_Prod() { }
    public override int get_koyaku_prm(int prm) { return 0; }
    public override void set_koyaku_prm(int id, int prm) { }
    public override char get_dir_cmd(int trg, int ptn) { return '\0'; }
    public override char get_dir_cmd2(int trg, int ptn, int _usGrp, int _usDir) { return '\0'; }
    public override int get_dir_data(int prm) { return 0; }
    public override int get_pdt_data(int prm) { return 0; }
    public override long get_pkd_data_long(int prm) { return 0L; }
    public override int get_pkd_data(int prm) { return 0; }
    public override int set_pdt_data(int id, int prm) { return 0; }
    public override int set_pkd_data_long(int id, long prm) { return 0; }
    public override int set_pkd_data(int id, int prm) { return 0; }
    public override void init_cmd() { }
    public override char get_cmd(int _ptn, int _lay, int _num) { return '\0'; }
    public override short get_pri_data(int prm) { return 0; }
    public override short set_pri_data(int id, int prm) { return 0; }
    public override void set_main_cmd(int _id, int _prm) { }
    public override int get_main_cmd(int _id) { return 0; }
    public override short get_pgm_data(int _id) { return 0; }
    public override short set_pgm_data(int _id, int _prm) { return 0; }
    public override short get_SubCmdBuf(int _num) { return 0; }
    public override short set_SubCmdBuf(int _num, int _prm) { return 0; }
}