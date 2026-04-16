using UnityEngine;

public class SlotBodySEG_Pay
{
	private const int SEG10_MAX = 2;

	private const int SEG1_MAX = 10;

	private GameObject[] m_SEG10 = new GameObject[2];

	private GameObject[] m_SEG1 = new GameObject[10];

	private int m_medalCnt;

	public void init()
	{
		m_SEG10[0] = GameObject.Find("kyoutai/sglg_seg/pay_0");
		m_SEG10[1] = GameObject.Find("kyoutai/sglg_seg/pay_1");
		m_SEG1[0] = GameObject.Find("kyoutai/sglg_seg/pay_00");
		m_SEG1[1] = GameObject.Find("kyoutai/sglg_seg/pay_01");
		m_SEG1[2] = GameObject.Find("kyoutai/sglg_seg/pay_02");
		m_SEG1[3] = GameObject.Find("kyoutai/sglg_seg/pay_03");
		m_SEG1[4] = GameObject.Find("kyoutai/sglg_seg/pay_04");
		m_SEG1[5] = GameObject.Find("kyoutai/sglg_seg/pay_05");
		m_SEG1[6] = GameObject.Find("kyoutai/sglg_seg/pay_06");
		m_SEG1[7] = GameObject.Find("kyoutai/sglg_seg/pay_07");
		m_SEG1[8] = GameObject.Find("kyoutai/sglg_seg/pay_08");
		m_SEG1[9] = GameObject.Find("kyoutai/sglg_seg/pay_09");
		allOff();
		m_medalCnt = 0;
	}

	public void allOff()
	{
		for (int i = 0; i < 2; i++)
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
		if (_num >= 0 && 2 > _num)
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

	public void betOn()
	{
		allOff();
		m_medalCnt = 0;
	}

	public bool result(int _medal)
	{
		bool flag = false;
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
			flag = true;
		}
		return flag;
	}
}
