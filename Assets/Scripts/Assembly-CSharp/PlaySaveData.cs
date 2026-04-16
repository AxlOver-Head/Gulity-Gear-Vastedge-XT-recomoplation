using System.Text;

public class PlaySaveData
{
	public enum AutoPlay
	{
		BONUS_START = 0,
		ART_START = 1,
		ART_END = 2,
		BONUS_OR_ART_START = 3,
		OFF = 4
	}

	private const int LOGIN_ADD_MAX = 64;

	private const int LOGIN_PASS_MAX = 64;

	private const int UNIQUE_ID_MAX = 8;

	public uint SerVerTime;

	public uint AppTimer;

	public byte m_loginFlag;

	public byte[] m_loginAdd;

	public byte[] m_loginPass;

	public int m_loginAddNum;

	public int m_loginPassNum;

	public byte m_seisanComitFlag;

	public int m_seisanRuiMai;

	public byte m_reviewFlag;

	public byte m_autoLevel;

	public byte m_autoSettei = 4;

	public byte m_configOshi;

	public byte m_configReelSpeed;

	public byte m_configReelWait;

	public byte m_configReelBlur;

	public byte m_configDataSize;

	public byte[] unique;

	public int uniqueNum;

	public int transactionID;

	public byte m_kyouseiFlag;

	public byte m_kouryakuFlag;

	public void set()
	{
	}

	public void get()
	{
	}

	public void setUnique(string _str)
	{
		byte[] bytes = Encoding.ASCII.GetBytes(_str);
		uniqueNum = bytes.Length;
		if (uniqueNum <= 8)
		{
			byte[] array = new byte[8 - uniqueNum];
			bytes.CopyTo(unique, 0);
			array.CopyTo(unique, bytes.Length);
		}
	}

	public void setAdd(string _str)
	{
		byte[] bytes = Encoding.ASCII.GetBytes(_str);
		m_loginAddNum = bytes.Length;
		if (m_loginAddNum <= 64)
		{
			byte[] array = new byte[64 - m_loginAddNum];
			bytes.CopyTo(m_loginAdd, 0);
			array.CopyTo(m_loginAdd, bytes.Length);
		}
	}

	public void setPass(string _str)
	{
		byte[] bytes = Encoding.ASCII.GetBytes(_str);
		m_loginPassNum = bytes.Length;
		if (m_loginPassNum <= 64)
		{
			byte[] array = new byte[64 - m_loginPassNum];
			bytes.CopyTo(m_loginPass, 0);
			array.CopyTo(m_loginPass, bytes.Length);
		}
	}

	public string getUnique()
	{
		if (unique[0] == 0 && unique[1] == 0 && unique[2] == 0 && unique[3] == 0)
		{
			return string.Empty;
		}
		string text = Encoding.ASCII.GetString(unique);
		return text.TrimEnd(default(char));
	}

	public string getPass()
	{
		if (m_loginPass[0] == 0 && m_loginPass[1] == 0 && m_loginPass[2] == 0 && m_loginPass[3] == 0)
		{
			return string.Empty;
		}
		string text = Encoding.ASCII.GetString(m_loginPass);
		return text.TrimEnd(default(char));
	}

	public string getAdd()
	{
		if (m_loginAdd[0] == 0 && m_loginAdd[1] == 0 && m_loginAdd[2] == 0 && m_loginAdd[3] == 0)
		{
			return string.Empty;
		}
		string text = Encoding.ASCII.GetString(m_loginAdd);
		return text.TrimEnd(default(char));
	}

	public void clear()
	{
		m_loginFlag = 0;
		m_loginAdd = new byte[64];
		m_loginPass = new byte[64];
		m_loginAddNum = 0;
		m_loginPassNum = 0;
		m_seisanComitFlag = 0;
		m_seisanRuiMai = 0;
		m_reviewFlag = 0;
		m_autoLevel = 0;
		m_autoSettei = 4;
		m_configOshi = 0;
		m_configReelSpeed = 0;
		m_configReelWait = 0;
		m_configReelBlur = 0;
		m_configDataSize = 0;
		unique = new byte[8];
		uniqueNum = 0;
		transactionID = 0;
		m_kyouseiFlag = 0;
		m_kouryakuFlag = 0;
		for (int i = 0; i < 64; i++)
		{
			m_loginAdd[i] = 0;
		}
		for (int j = 0; j < 64; j++)
		{
			m_loginPass[j] = 0;
		}
		for (int k = 0; k < 8; k++)
		{
			unique[k] = 0;
		}
	}

	public void setAuto(byte _auto)
	{
		m_autoSettei = _auto;
	}
}
