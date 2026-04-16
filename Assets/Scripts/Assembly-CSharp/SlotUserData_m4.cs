using System.IO;
using UnityEngine;

public class SlotUserData_m4 : MonoBehaviour
{
	public static bool bGUIDebugDisp = true;

	public static double REAL_TIMER;

	public static string ReleaseDateTime = "2013/6/17 0:00";

	public static SlotSaveData saveData = new SlotSaveData();

	private static GGLFileRef m_fileRef = new GGLFileRef();

	private static string m_filename = string.Empty;

	private static int m_saveRequest = 0;

	private static bool m_initAwake = false;

	public static bool m_bPause = false;

	private void Awake()
	{
		if (!m_initAwake)
		{
			m_filename = GGLFile.filePath("SlotUserData_m4.sav");
			saveData.clear();
			m_fileRef.classAnalyzer(m_filename, saveData);
			if (!load())
			{
				saveData.clear();
				if (save())
				{
				}
			}
			else if (SlotUserData.saveData.AppTimer > SlotUserData.saveData.SerVerTime)
			{
				SlotUserData.saveData.SerVerTime = SlotUserData.saveData.AppTimer;
			}
			m_initAwake = true;
		}
		m_bPause = false;
	}

	private void Start()
	{
	}

	private void Update()
	{
		if (m_saveRequest > 0)
		{
			m_saveRequest--;
			if (m_saveRequest == 0)
			{
				m_fileRef.saveWrite();
				m_saveRequest = 0;
			}
		}
	}

	public static void init()
	{
		if (!m_initAwake)
		{
			m_filename = GGLFile.filePath("SlotUserData_m4.sav");
			saveData.clear();
			m_fileRef.classAnalyzer(m_filename, saveData);
			if (!load())
			{
				saveData.clear();
				if (save())
				{
				}
			}
			else if (SlotUserData.saveData.AppTimer > SlotUserData.saveData.SerVerTime)
			{
				SlotUserData.saveData.SerVerTime = SlotUserData.saveData.AppTimer;
			}
			m_initAwake = true;
		}
		m_bPause = false;
	}

	public static bool load()
	{
		return m_fileRef.load();
	}

	public static bool save()
	{
		m_saveRequest = 0;
		m_fileRef.saveWrite();
		return m_fileRef.save();
	}

	public static void clear()
	{
		saveData.clear();
		save();
	}

	public static void saveRequest()
	{
		if (m_fileRef.saveAnalyzer())
		{
			m_saveRequest = Application.targetFrameRate + 1;
		}
	}

	public static string getTimestamp(string path)
	{
		return File.GetCreationTime(path).ToString();
	}

	public static void close()
	{
		m_fileRef.closeWriter();
	}
}
