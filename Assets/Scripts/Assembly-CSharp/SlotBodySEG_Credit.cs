using UnityEngine;

public class SlotBodySEG_Credit
{
	private const int SEG10_MAX = 6;

	private const int SEG1_MAX = 10;

	private GameObject[] m_SEG10 = new GameObject[6];

	private GameObject[] m_SEG1 = new GameObject[10];

	private int m_medalCnt;

	public void init(int _medal)
	{
		m_SEG10[0] = GameObject.Find("kyoutai/sglg_seg/credit_0");
		m_SEG10[1] = GameObject.Find("kyoutai/sglg_seg/credit_1");
		m_SEG10[2] = GameObject.Find("kyoutai/sglg_seg/credit_2");
		m_SEG10[3] = GameObject.Find("kyoutai/sglg_seg/credit_3");
		m_SEG10[4] = GameObject.Find("kyoutai/sglg_seg/credit_4");
		m_SEG10[5] = GameObject.Find("kyoutai/sglg_seg/credit_5");
		m_SEG1[0] = GameObject.Find("kyoutai/sglg_seg/credit_00");
		m_SEG1[1] = GameObject.Find("kyoutai/sglg_seg/credit_01");
		m_SEG1[2] = GameObject.Find("kyoutai/sglg_seg/credit_02");
		m_SEG1[3] = GameObject.Find("kyoutai/sglg_seg/credit_03");
		m_SEG1[4] = GameObject.Find("kyoutai/sglg_seg/credit_04");
		m_SEG1[5] = GameObject.Find("kyoutai/sglg_seg/credit_05");
		m_SEG1[6] = GameObject.Find("kyoutai/sglg_seg/credit_06");
		m_SEG1[7] = GameObject.Find("kyoutai/sglg_seg/credit_07");
		m_SEG1[8] = GameObject.Find("kyoutai/sglg_seg/credit_08");
		m_SEG1[9] = GameObject.Find("kyoutai/sglg_seg/credit_09");
		allOff();
		m_SEG10[0].SetActive(true);
		m_SEG1[0].SetActive(true);
		m_medalCnt = 0;
		m_medalCnt = _medal;
		int num = _medal / 10;
		int num2 = _medal % 10;
		setSEG10(num, true);
		setSEG1(num2, true);
	}

	public void allOff()
	{
		for (int i = 0; i < 6; i++)
		{
			m_SEG10[i].SetActive(false);
		}
		for (int i = 0; i < 10; i++)
		{
			m_SEG1[i].SetActive(false);
		}
	}

	public void setSEG10(int _num, bool _flag)
	{
		if (_num >= 0 && 6 > _num)
		{
			m_SEG10[_num].SetActive(_flag);
		}
	}

	public void setSEG1(int _num, bool _flag)
	{
		if (_num >= 0 && 10 > _num)
		{
			m_SEG1[_num].SetActive(_flag);
		}
	}

	public void betOn(int _medal)
	{
		int num = _medal / 10;
		int num2 = _medal % 10;
		if (m_medalCnt > _medal)
		{
			allOff();
			m_medalCnt--;
			num = m_medalCnt / 10;
			num2 = m_medalCnt % 10;
			setSEG10(num, true);
			setSEG1(num2, true);
		}
	}

	public void leverOn(int _medal)
	{
		int num = _medal / 10;
		int num2 = _medal % 10;
		if (m_medalCnt > _medal)
		{
			allOff();
			m_medalCnt = _medal;
			num = m_medalCnt / 10;
			num2 = m_medalCnt % 10;
			setSEG10(num, true);
			setSEG1(num2, true);
		}
	}

	public void result(int _medal)
	{
		int num = _medal / 10;
		int num2 = _medal % 10;
		if (m_medalCnt < _medal)
		{
			allOff();
			m_medalCnt++;
			num = m_medalCnt / 10;
			num2 = m_medalCnt % 10;
			setSEG10(num, true);
			setSEG1(num2, true);
		}
	}

	public void debugYaku(bool _flag, int _num)
	{
		int num = _num / 10;
		int num2 = _num % 10;
		if (_flag)
		{
			allOff();
			setSEG10(num, true);
			setSEG1(num2, true);
		}
		else
		{
			num = m_medalCnt / 10;
			num2 = m_medalCnt % 10;
			allOff();
			setSEG10(num, true);
			setSEG1(num2, true);
		}
	}

	public int getMedalCnt()
	{
		return m_medalCnt;
	}

	public void restart(int _medal)
	{
		allOff();
		m_medalCnt = _medal;
		setSEG10(_medal / 10, true);
		setSEG1(_medal % 10, true);
	}
}
