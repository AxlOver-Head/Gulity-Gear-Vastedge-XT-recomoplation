using System;
using UnityEngine;

public class UIDataPanel : MonoBehaviour
{
	private const float SLIDE_OFFSET = 1024f;

	private const int BONUS_STAR = 20;

	private const float BONUS_SPD = 4f;

	private bool m_IsCompactMode;

	private int m_NormalPanelMode;

	private GameObject m_ObjPanelNormal;

	private GameObject m_ObjPanelCompact;

	private GameObject[] m_ObjPanelNormal_Data = new GameObject[4];

	private GameObject[] m_ObjData2PerNum = new GameObject[3];

	private GameObject m_ObjGameNum;

	private GameObject m_ObjRireki;

	private GameObject m_ObjBonus;

	private UISprite[] m_SprMedal_Compact = new UISprite[6];

	private UISprite[] m_SprGameNumTotal_Compact = new UISprite[5];

	private UISprite[] m_SprGameNumNow_Compact = new UISprite[5];

	private UISprite[] m_SprMedal_Normal = new UISprite[6];

	private UISprite[] m_SprGameNum_Normal = new UISprite[5];

	private UISprite[] m_SprBB = new UISprite[3];

	private UISprite[] m_SprRB = new UISprite[3];

	private UISprite[] m_SprART = new UISprite[3];

	private UISprite[] m_SprBB_Per = new UISprite[5];

	private UISprite[] m_SprRB_Per = new UISprite[5];

	private UISprite[] m_SprART_Per = new UISprite[5];

	private UISprite[] m_SprBB_Prev = new UISprite[3];

	private UISprite[] m_SprRB_Prev = new UISprite[3];

	private UISprite[] m_SprART_Prev = new UISprite[3];

	private UISprite[] m_SprBonus = new UISprite[3];

	public static readonly int RIREKI_TSUBU_NUM = 10;

	private GameObject[,] m_ObjRireki_Tsubu = new GameObject[5, RIREKI_TSUBU_NUM + 1];

	private UISprite[] m_SprRireki_Kind = new UISprite[5];

	private bool[,] m_FlagRireki = new bool[5, RIREKI_TSUBU_NUM + 1];

	private UISprite m_SprLED;

	private int m_MachineNum;

	private int m_GameNumNow;

	private int m_GameNumTotal;

	private int m_BBNum;

	private int m_RBNum;

	private int m_ARTNum;

	private int m_MedalNum;

	private int[] m_BonusRireki = new int[5];

	private int[] m_BonusRirekiKind = new int[5];

	private int m_GameNumTotal_Prev;

	private int m_BBNum_Prev;

	private int m_RBNum_Prev;

	private int m_ARTNum_Prev;

	private int[] m_BonusRireki_Prev = new int[5];

	private int[] m_BonusRirekiKind_Prev = new int[5];

	private int m_BlinkCount;

	private float m_ResetCount;

	private bool m_IsBB;

	private bool m_IsRB;

	private bool m_IsART;

	private bool m_IsBonus;

	private int m_BonusCount;

	private int m_LedCnt;

	private UICamera UICam;

	private bool m_ButtonActive;

	private GameObject getObj(string path)
	{
		return GameObject.Find("DataPanel/Camera/Anchor/Panel/" + path);
	}

	private UISprite getSpr(string path)
	{
		return getObj(path).GetComponent<UISprite>();
	}

	public bool isCompactMode()
	{
		return m_IsCompactMode;
	}

	private void Start()
	{
		m_IsCompactMode = true;
		m_NormalPanelMode = 0;
		m_MachineNum = 9;
		m_GameNumNow = 0;
		m_GameNumTotal = 0;
		m_BBNum = 0;
		m_RBNum = 0;
		m_ARTNum = 0;
		m_MedalNum = -1000;
		m_BonusRireki[0] = 50;
		m_BonusRireki[1] = 600;
		m_BonusRireki[2] = 150;
		m_BonusRireki[3] = 202;
		m_BonusRireki[4] = 901;
		m_BonusRirekiKind[0] = 0;
		m_BonusRirekiKind[1] = 1;
		m_BonusRirekiKind[2] = 2;
		m_BonusRirekiKind[3] = 2;
		m_BonusRirekiKind[4] = 0;
		m_GameNumTotal_Prev = 0;
		m_BBNum_Prev = 0;
		m_RBNum_Prev = 0;
		m_ARTNum_Prev = 0;
		m_BonusRireki_Prev[0] = 234;
		m_BonusRireki_Prev[1] = 452;
		m_BonusRireki_Prev[2] = 892;
		m_BonusRireki_Prev[3] = 0;
		m_BonusRireki_Prev[4] = 0;
		m_BonusRirekiKind_Prev[0] = 2;
		m_BonusRirekiKind_Prev[1] = 1;
		m_BonusRirekiKind_Prev[2] = 1;
		m_BonusRirekiKind_Prev[3] = 0;
		m_BonusRirekiKind_Prev[4] = 0;
		m_LedCnt = 0;
		MainGameScene.m_DataPanel = this;
		MainGameScene.m_DataPanelObj = base.gameObject;
		UICam = GameObject.Find("DataPanel/Camera").GetComponent<UICamera>();
		m_ObjPanelNormal = getObj("Normal");
		m_ObjPanelCompact = getObj("Compact");
		m_ObjPanelNormal_Data[0] = getObj("Normal/Data_1");
		m_ObjPanelNormal_Data[1] = getObj("Normal/Data_2");
		m_ObjPanelNormal_Data[2] = getObj("Normal/Data_3");
		m_ObjPanelNormal_Data[3] = getObj("Normal/Data_4");
		m_ObjData2PerNum[0] = getObj("Normal/Data_2/BBNum");
		m_ObjData2PerNum[1] = getObj("Normal/Data_2/RBNum");
		m_ObjData2PerNum[2] = getObj("Normal/Data_2/ARTNum");
		m_ObjGameNum = getObj("Normal/GameNum");
		m_ObjRireki = getObj("Normal/Rireki");
		m_ObjBonus = getObj("Normal/Data_4/bonus");
		for (int i = 0; i < 5; i++)
		{
			m_ObjRireki_Tsubu[i, 0] = getObj(string.Format("Normal/Rireki/Line{0}/Base", i + 1));
			m_SprRireki_Kind[i] = getSpr(string.Format("Normal/Rireki/Line{0}/Base/Base", i + 1));
			m_FlagRireki[i, 0] = false;
			for (int j = 1; j < RIREKI_TSUBU_NUM + 1; j++)
			{
				m_ObjRireki_Tsubu[i, j] = getObj(string.Format("Normal/Rireki/Line{0}/Tsubu_{1}", i + 1, j - 1));
				m_FlagRireki[i, j] = false;
			}
		}
		m_SprGameNum_Normal[0] = getSpr("Normal/GameNum/G_10000");
		m_SprGameNum_Normal[1] = getSpr("Normal/GameNum/G_01000");
		m_SprGameNum_Normal[2] = getSpr("Normal/GameNum/G_00100");
		m_SprGameNum_Normal[3] = getSpr("Normal/GameNum/G_00010");
		m_SprGameNum_Normal[4] = getSpr("Normal/GameNum/G_00001");
		m_SprMedal_Normal[0] = getSpr("Normal/Data_1/MedalNum/Medal_minus");
		m_SprMedal_Normal[1] = getSpr("Normal/Data_1/MedalNum/Medal_10000");
		m_SprMedal_Normal[2] = getSpr("Normal/Data_1/MedalNum/Medal_01000");
		m_SprMedal_Normal[3] = getSpr("Normal/Data_1/MedalNum/Medal_00100");
		m_SprMedal_Normal[4] = getSpr("Normal/Data_1/MedalNum/Medal_00010");
		m_SprMedal_Normal[5] = getSpr("Normal/Data_1/MedalNum/Medal_00001");
		m_SprMedal_Compact[0] = getSpr("Compact/Medal/num_minus");
		m_SprMedal_Compact[1] = getSpr("Compact/Medal/num_10000");
		m_SprMedal_Compact[2] = getSpr("Compact/Medal/num_01000");
		m_SprMedal_Compact[3] = getSpr("Compact/Medal/num_00100");
		m_SprMedal_Compact[4] = getSpr("Compact/Medal/num_00010");
		m_SprMedal_Compact[5] = getSpr("Compact/Medal/num_00001");
		m_SprGameNumNow_Compact[0] = getSpr("Compact/GameNow/num_10000");
		m_SprGameNumNow_Compact[1] = getSpr("Compact/GameNow/num_01000");
		m_SprGameNumNow_Compact[2] = getSpr("Compact/GameNow/num_00100");
		m_SprGameNumNow_Compact[3] = getSpr("Compact/GameNow/num_00010");
		m_SprGameNumNow_Compact[4] = getSpr("Compact/GameNow/num_00001");
		m_SprGameNumTotal_Compact[0] = getSpr("Compact/GameTotal/num_010000");
		m_SprGameNumTotal_Compact[1] = getSpr("Compact/GameTotal/num_001000");
		m_SprGameNumTotal_Compact[2] = getSpr("Compact/GameTotal/num_000100");
		m_SprGameNumTotal_Compact[3] = getSpr("Compact/GameTotal/num_000010");
		m_SprGameNumTotal_Compact[4] = getSpr("Compact/GameTotal/num_000001");
		m_SprBB[0] = getSpr("Normal/Data_1/BBNum/BB_00100");
		m_SprBB[1] = getSpr("Normal/Data_1/BBNum/BB_00010");
		m_SprBB[2] = getSpr("Normal/Data_1/BBNum/BB_00001");
		m_SprRB[0] = getSpr("Normal/Data_1/RBNum/RB_00100");
		m_SprRB[1] = getSpr("Normal/Data_1/RBNum/RB_00010");
		m_SprRB[2] = getSpr("Normal/Data_1/RBNum/RB_00001");
		m_SprART[0] = getSpr("Normal/Data_1/ARTNum/ART_00100");
		m_SprART[1] = getSpr("Normal/Data_1/ARTNum/ART_00010");
		m_SprART[2] = getSpr("Normal/Data_1/ARTNum/ART_00001");
		m_SprBB_Per[0] = getSpr("Normal/Data_2/BBNum/BB_10000");
		m_SprBB_Per[1] = getSpr("Normal/Data_2/BBNum/BB_01000");
		m_SprBB_Per[2] = getSpr("Normal/Data_2/BBNum/BB_00100");
		m_SprBB_Per[3] = getSpr("Normal/Data_2/BBNum/BB_00010");
		m_SprBB_Per[4] = getSpr("Normal/Data_2/BBNum/BB_00001");
		m_SprRB_Per[0] = getSpr("Normal/Data_2/RBNum/RB_10000");
		m_SprRB_Per[1] = getSpr("Normal/Data_2/RBNum/RB_01000");
		m_SprRB_Per[2] = getSpr("Normal/Data_2/RBNum/RB_00100");
		m_SprRB_Per[3] = getSpr("Normal/Data_2/RBNum/RB_00010");
		m_SprRB_Per[4] = getSpr("Normal/Data_2/RBNum/RB_00001");
		m_SprART_Per[0] = getSpr("Normal/Data_2/ARTNum/ART_10000");
		m_SprART_Per[1] = getSpr("Normal/Data_2/ARTNum/ART_01000");
		m_SprART_Per[2] = getSpr("Normal/Data_2/ARTNum/ART_00100");
		m_SprART_Per[3] = getSpr("Normal/Data_2/ARTNum/ART_00010");
		m_SprART_Per[4] = getSpr("Normal/Data_2/ARTNum/ART_00001");
		m_SprBB_Prev[0] = getSpr("Normal/Data_3/BBNum/BB_00100");
		m_SprBB_Prev[1] = getSpr("Normal/Data_3/BBNum/BB_00010");
		m_SprBB_Prev[2] = getSpr("Normal/Data_3/BBNum/BB_00001");
		m_SprRB_Prev[0] = getSpr("Normal/Data_3/RBNum/RB_00100");
		m_SprRB_Prev[1] = getSpr("Normal/Data_3/RBNum/RB_00010");
		m_SprRB_Prev[2] = getSpr("Normal/Data_3/RBNum/RB_00001");
		m_SprART_Prev[0] = getSpr("Normal/Data_3/ARTNum/ART_00100");
		m_SprART_Prev[1] = getSpr("Normal/Data_3/ARTNum/ART_00010");
		m_SprART_Prev[2] = getSpr("Normal/Data_3/ARTNum/ART_00001");
		m_SprBonus[0] = getSpr("Normal/Data_4/bonus");
		m_SprBonus[1] = getSpr("Normal/Data_4/star_1");
		m_SprBonus[2] = getSpr("Normal/Data_4/star_2");
		m_SprLED = getSpr("Normal/LED");
		m_BlinkCount = 0;
		m_ResetCount = 0f;
		m_ButtonActive = false;
		m_IsBB = false;
		m_IsRB = false;
		m_IsART = false;
		m_IsBonus = false;
		m_BonusCount = 0;
		m_ObjPanelCompact.transform.localPosition += new Vector3(1024f, 0f, 0f);
		m_IsCompactMode = false;
		SetDataPanelCompactMode(MainGameScene.m_PlaySaveData.m_configDataSize == 1);
		m_NormalPanelMode = 0;
		m_ObjPanelNormal_Data[1].transform.localPosition += new Vector3(1024f, 0f, 0f);
		m_ObjPanelNormal_Data[2].transform.localPosition += new Vector3(1024f, 0f, 0f);
		m_ObjPanelNormal_Data[3].transform.localPosition += new Vector3(1024f, 0f, 0f);
	}

	private void Update()
	{
		m_BlinkCount++;
		if (m_BlinkCount > 40)
		{
			m_BlinkCount = 0;
		}
		m_GameNumNow = MainGameScene.slotGameMan.gameCount;
		m_GameNumTotal = MainGameScene.slotGameMan.totalGameCount;
		m_MedalNum = MainGameScene.slotGameMan.m_mochiMedal;
		m_BBNum = MainGameScene.slotGameMan.data.hisData.bnsPBCnt + MainGameScene.slotGameMan.data.hisData.bnsGBCnt + MainGameScene.slotGameMan.data.hisData.bnsSGBCnt;
		m_RBNum = MainGameScene.slotGameMan.data.hisData.bnsRBCnt;
		m_ARTNum = MainGameScene.slotGameMan.data.hisData.artCnt;
		m_BBNum_Prev = MainGameScene.slotGameMan.data.hisData.bnsBBCntYesterDay;
		m_RBNum_Prev = MainGameScene.slotGameMan.data.hisData.bnsRBCntYesterDay;
		m_ARTNum_Prev = MainGameScene.slotGameMan.data.hisData.artCntYesterDay;
		for (int i = 0; i < 5; i++)
		{
			m_BonusRireki_Prev[i] = (m_BonusRireki[i] = MainGameScene.slotGameMan.data.hisData.LogGameCount[i]);
			m_BonusRirekiKind_Prev[i] = (m_BonusRirekiKind[i] = MainGameScene.slotGameMan.data.hisData.LogTousenYaku[i]);
		}
		m_MachineNum = MainGameScene.slotGameMan.selectMachine;
		m_GameNumTotal_Prev = m_GameNumTotal;
		if (m_BBNum > 999)
		{
			m_BBNum = 999;
		}
		if (m_RBNum > 999)
		{
			m_RBNum = 999;
		}
		if (m_ARTNum > 999)
		{
			m_ARTNum = 999;
		}
		if (m_BBNum_Prev > 999)
		{
			m_BBNum_Prev = 999;
		}
		if (m_RBNum_Prev > 999)
		{
			m_RBNum_Prev = 999;
		}
		if (m_ARTNum_Prev > 999)
		{
			m_ARTNum_Prev = 999;
		}
		if (m_MedalNum > 99999)
		{
			m_MedalNum = 99999;
		}
		if (m_GameNumNow > 99999)
		{
			m_GameNumNow = 99999;
		}
		if (m_GameNumTotal > 99999)
		{
			m_GameNumTotal = 99999;
		}
		if (m_GameNumTotal_Prev > 99999)
		{
			m_GameNumTotal_Prev = 99999;
		}
		updateLED();
		update_panel();
		updateBonus();
	}

	private void OnClickEvent_Data()
	{
		if (m_ButtonActive && !SGLG.isFading)
		{
			MainGameScene.gotoDataScene();
		}
	}

	private void OnClickEvent_Menu()
	{
		if (m_ButtonActive && !SGLG.isFading)
		{
			MainGameScene.gotoMenuScene();
		}
	}

	private void ToggleDataPanelMode()
	{
		SetDataPanelCompactMode(!m_IsCompactMode);
	}

	public void SetDataPanelCompactMode(bool flag)
	{
		if (m_IsCompactMode != flag)
		{
			m_IsCompactMode = flag;
			if (m_IsCompactMode)
			{
				m_ObjPanelNormal.transform.localPosition += new Vector3(1024f, 0f, 0f);
				m_ObjPanelCompact.transform.localPosition -= new Vector3(1024f, 0f, 0f);
			}
			else
			{
				m_ObjPanelNormal.transform.localPosition -= new Vector3(1024f, 0f, 0f);
				m_ObjPanelCompact.transform.localPosition += new Vector3(1024f, 0f, 0f);
			}
			update_panel();
		}
	}

	private void OnClickEvent_NormalPanel()
	{
		if (SGLG.gameMode == SGLG.GAMEMODE.SIMULATION)
		{
			SetDataPanelNormalMode((m_NormalPanelMode + 1) % 2);
		}
		else
		{
			SetDataPanelNormalMode((m_NormalPanelMode + 1) % 3);
		}
	}

	private void SetDataPanelNormalMode(int mode)
	{
		if (m_NormalPanelMode != mode)
		{
			m_ObjPanelNormal_Data[m_NormalPanelMode].transform.localPosition += new Vector3(1024f, 0f, 0f);
			if (m_NormalPanelMode != 3)
			{
				m_ObjGameNum.transform.localPosition += new Vector3(1024f, 0f, 0f);
				m_ObjRireki.transform.localPosition += new Vector3(1024f, 0f, 0f);
			}
			m_ObjPanelNormal_Data[mode].transform.localPosition -= new Vector3(1024f, 0f, 0f);
			if (mode != 3)
			{
				m_ObjGameNum.transform.localPosition -= new Vector3(1024f, 0f, 0f);
				m_ObjRireki.transform.localPosition -= new Vector3(1024f, 0f, 0f);
			}
			switch (mode)
			{
			case 0:
				m_ResetCount = 0f;
				break;
			case 1:
				m_ResetCount = 6f;
				break;
			case 2:
				m_ResetCount = 6f;
				break;
			case 3:
				m_ResetCount = 6f;
				break;
			}
			m_NormalPanelMode = mode;
			update_panel();
		}
	}

	private void updateBonus()
	{
		if (MainGameScene.slotGameMan.getBonusState() != -1)
		{
			if (!m_IsBonus)
			{
				m_IsBonus = true;
				m_BonusCount = 0;
				SetDataPanelNormalMode(3);
			}
			switch (MainGameScene.slotGameMan.getBonusState())
			{
			case 0:
			case 2:
			case 3:
				m_IsBB = true;
				m_IsRB = false;
				m_IsART = false;
				break;
			case 1:
				m_IsBB = false;
				m_IsRB = true;
				m_IsART = false;
				break;
			case 4:
				m_IsBB = false;
				m_IsRB = false;
				m_IsART = true;
				break;
			}
			float x = m_ObjBonus.transform.localPosition.x;
			float y = m_ObjBonus.transform.localPosition.y;
			float z = m_ObjBonus.transform.localPosition.z;
			x -= 4f;
			if (x <= -310f)
			{
				x = 310f;
			}
			m_ObjBonus.transform.localPosition = new Vector3(x, y, z);
			switch (m_BonusCount % 40)
			{
			case 0:
				m_SprBonus[1].color = new Color(1f, 1f, 1f, 1f);
				m_SprBonus[2].color = new Color(1f, 1f, 1f, 0f);
				break;
			case 20:
				m_SprBonus[1].color = new Color(1f, 1f, 1f, 0f);
				m_SprBonus[2].color = new Color(1f, 1f, 1f, 1f);
				break;
			}
			m_BonusCount++;
		}
		else
		{
			if (m_IsBonus)
			{
				m_IsBonus = false;
				m_BonusCount = 0;
				SetDataPanelNormalMode(0);
			}
			m_IsBB = false;
			m_IsRB = false;
			m_IsART = false;
		}
	}

	private void updateLED()
	{
		int num = 2;
		int num2 = 40;
		float num3 = ((MainGameScene.slotGameMan.getBonusState() == -1) ? Mathf.Sin((float)(m_LedCnt * num) * ((float)Math.PI / 180f)) : Mathf.Sin((float)(m_LedCnt * num2) * ((float)Math.PI / 180f)));
		m_SprLED.color = new Color(1f, 1f, 1f, 1f - num3);
		m_LedCnt++;
	}

	private void update_panel()
	{
		bool flag = false;
		int num = ((m_MedalNum >= 0) ? m_MedalNum : (-m_MedalNum));
		if (m_IsCompactMode)
		{
			flag = false;
			m_SprMedal_Compact[0].enabled = false;
			bool flag2 = flag || num / 10000 % 10 > 0;
			m_SprMedal_Compact[1].enabled = flag2;
			flag2 = flag2 || num / 1000 % 10 > 0;
			m_SprMedal_Compact[2].enabled = flag2;
			flag2 = flag2 || num / 100 % 10 > 0;
			m_SprMedal_Compact[3].enabled = flag2;
			flag2 = flag2 || num / 10 % 10 > 0;
			m_SprMedal_Compact[4].enabled = flag2;
			flag2 = flag2 || num % 10 >= 0;
			m_SprMedal_Compact[5].enabled = flag2;
			flag = flag2;
			m_SprMedal_Compact[1].spriteName = "panel_r_su_" + num / 10000;
			m_SprMedal_Compact[2].spriteName = "panel_r_su_" + num / 1000 % 10;
			m_SprMedal_Compact[3].spriteName = "panel_r_su_" + num / 100 % 10;
			m_SprMedal_Compact[4].spriteName = "panel_r_su_" + num / 10 % 10;
			m_SprMedal_Compact[5].spriteName = "panel_r_su_" + num % 10;
			if (m_MedalNum < 0)
			{
				for (int num2 = 5; num2 >= 0; num2--)
				{
					if (!m_SprMedal_Compact[num2].enabled)
					{
						m_SprMedal_Compact[num2].enabled = true;
						m_SprMedal_Compact[num2].spriteName = "panel_r2_su_m";
						break;
					}
				}
			}
			flag2 = false || m_GameNumNow / 10000 % 10 > 0;
			m_SprGameNumNow_Compact[0].enabled = flag2;
			flag2 = flag2 || m_GameNumNow / 1000 % 10 > 0;
			m_SprGameNumNow_Compact[1].enabled = flag2;
			flag2 = flag2 || m_GameNumNow / 100 % 10 > 0;
			m_SprGameNumNow_Compact[2].enabled = flag2;
			flag2 = flag2 || m_GameNumNow / 10 % 10 > 0;
			m_SprGameNumNow_Compact[3].enabled = flag2;
			flag2 = flag2 || m_GameNumNow % 10 >= 0;
			m_SprGameNumNow_Compact[4].enabled = flag2;
			flag = flag2;
			m_SprGameNumNow_Compact[0].spriteName = "panel_y_su_" + m_GameNumNow / 10000;
			m_SprGameNumNow_Compact[1].spriteName = "panel_y_su_" + m_GameNumNow / 1000 % 10;
			m_SprGameNumNow_Compact[2].spriteName = "panel_y_su_" + m_GameNumNow / 100 % 10;
			m_SprGameNumNow_Compact[3].spriteName = "panel_y_su_" + m_GameNumNow / 10 % 10;
			m_SprGameNumNow_Compact[4].spriteName = "panel_y_su_" + m_GameNumNow % 10;
			flag2 = false || m_GameNumTotal / 10000 % 10 > 0;
			m_SprGameNumTotal_Compact[0].enabled = flag2;
			flag2 = flag2 || m_GameNumTotal / 1000 % 10 > 0;
			m_SprGameNumTotal_Compact[1].enabled = flag2;
			flag2 = flag2 || m_GameNumTotal / 100 % 10 > 0;
			m_SprGameNumTotal_Compact[2].enabled = flag2;
			flag2 = flag2 || m_GameNumTotal / 10 % 10 > 0;
			m_SprGameNumTotal_Compact[3].enabled = flag2;
			flag2 = flag2 || m_GameNumTotal % 10 >= 0;
			m_SprGameNumTotal_Compact[4].enabled = flag2;
			flag = flag2;
			m_SprGameNumTotal_Compact[0].spriteName = "panel_g_su_" + m_GameNumTotal / 10000 % 10;
			m_SprGameNumTotal_Compact[1].spriteName = "panel_g_su_" + m_GameNumTotal / 1000 % 10;
			m_SprGameNumTotal_Compact[2].spriteName = "panel_g_su_" + m_GameNumTotal / 100 % 10;
			m_SprGameNumTotal_Compact[3].spriteName = "panel_g_su_" + m_GameNumTotal / 10 % 10;
			m_SprGameNumTotal_Compact[4].spriteName = "panel_g_su_" + m_GameNumTotal % 10;
			return;
		}
		if (m_ResetCount > 0f)
		{
			m_ResetCount -= SGLG.deltaTime;
			if (m_ResetCount <= 0f)
			{
				SetDataPanelNormalMode(0);
			}
		}
		switch (m_NormalPanelMode)
		{
		case 0:
		{
			bool flag2 = false || m_GameNumNow / 10000 % 10 > 0;
			m_SprGameNum_Normal[0].enabled = flag2;
			flag2 = flag2 || m_GameNumNow / 1000 % 10 > 0;
			m_SprGameNum_Normal[1].enabled = flag2;
			flag2 = flag2 || m_GameNumNow / 100 % 10 > 0;
			m_SprGameNum_Normal[2].enabled = flag2;
			flag2 = flag2 || m_GameNumNow / 10 % 10 > 0;
			m_SprGameNum_Normal[3].enabled = flag2;
			flag2 = flag2 || m_GameNumNow % 10 >= 0;
			m_SprGameNum_Normal[4].enabled = flag2;
			flag = flag2;
			m_SprGameNum_Normal[0].spriteName = "panel_g_su_" + m_GameNumNow / 10000 % 10;
			m_SprGameNum_Normal[1].spriteName = "panel_g_su_" + m_GameNumNow / 1000 % 10;
			m_SprGameNum_Normal[2].spriteName = "panel_g_su_" + m_GameNumNow / 100 % 10;
			m_SprGameNum_Normal[3].spriteName = "panel_g_su_" + m_GameNumNow / 10 % 10;
			m_SprGameNum_Normal[4].spriteName = "panel_g_su_" + m_GameNumNow % 10;
			flag2 = (false || m_BBNum / 100 % 10 > 0) && (!m_IsBB || (m_IsBB && m_BlinkCount < 20));
			m_SprBB[0].enabled = flag2;
			flag2 = (flag2 || m_BBNum / 10 % 10 > 0) && (!m_IsBB || (m_IsBB && m_BlinkCount < 20));
			m_SprBB[1].enabled = flag2;
			flag2 = (flag2 || m_BBNum % 10 >= 0) && (!m_IsBB || (m_IsBB && m_BlinkCount < 20));
			m_SprBB[2].enabled = flag2;
			flag = flag2;
			m_SprBB[0].spriteName = "panel_r_su_" + m_BBNum / 100 % 10;
			m_SprBB[1].spriteName = "panel_r_su_" + m_BBNum / 10 % 10;
			m_SprBB[2].spriteName = "panel_r_su_" + m_BBNum % 10;
			flag2 = (false || m_RBNum / 100 % 10 > 0) && (!m_IsRB || (m_IsRB && m_BlinkCount < 20));
			m_SprRB[0].enabled = flag2;
			flag2 = (flag2 || m_RBNum / 10 % 10 > 0) && (!m_IsRB || (m_IsRB && m_BlinkCount < 20));
			m_SprRB[1].enabled = flag2;
			flag2 = (flag2 || m_RBNum % 10 >= 0) && (!m_IsRB || (m_IsRB && m_BlinkCount < 20));
			m_SprRB[2].enabled = flag2;
			flag = flag2;
			m_SprRB[0].spriteName = "panel_y_su_" + m_RBNum / 100 % 10;
			m_SprRB[1].spriteName = "panel_y_su_" + m_RBNum / 10 % 10;
			m_SprRB[2].spriteName = "panel_y_su_" + m_RBNum % 10;
			flag2 = (false || m_ARTNum / 100 % 10 > 0) && (!m_IsART || (m_IsART && m_BlinkCount < 20));
			m_SprART[0].enabled = flag2;
			flag2 = (flag2 || m_ARTNum / 10 % 10 > 0) && (!m_IsART || (m_IsART && m_BlinkCount < 20));
			m_SprART[1].enabled = flag2;
			flag2 = (flag2 || m_ARTNum % 10 >= 0) && (!m_IsART || (m_IsART && m_BlinkCount < 20));
			m_SprART[2].enabled = flag2;
			flag = flag2;
			m_SprART[0].spriteName = "panel_b_su_" + m_ARTNum / 100 % 10;
			m_SprART[1].spriteName = "panel_b_su_" + m_ARTNum / 10 % 10;
			m_SprART[2].spriteName = "panel_b_su_" + m_ARTNum % 10;
			flag = false;
			m_SprMedal_Normal[0].enabled = false;
			flag2 = flag || num / 10000 % 10 > 0;
			m_SprMedal_Normal[1].enabled = flag2;
			flag2 = flag2 || num / 1000 % 10 > 0;
			m_SprMedal_Normal[2].enabled = flag2;
			flag2 = flag2 || num / 100 % 10 > 0;
			m_SprMedal_Normal[3].enabled = flag2;
			flag2 = flag2 || num / 10 % 10 > 0;
			m_SprMedal_Normal[4].enabled = flag2;
			flag2 = flag2 || num % 10 >= 0;
			m_SprMedal_Normal[5].enabled = flag2;
			flag = flag2;
			string text = ((m_MedalNum < 0) ? "panel_r_su_" : "panel_g_su_");
			m_SprMedal_Normal[1].spriteName = text + num / 10000;
			m_SprMedal_Normal[2].spriteName = text + num / 1000 % 10;
			m_SprMedal_Normal[3].spriteName = text + num / 100 % 10;
			m_SprMedal_Normal[4].spriteName = text + num / 10 % 10;
			m_SprMedal_Normal[5].spriteName = text + num % 10;
			if (m_MedalNum >= 0)
			{
				break;
			}
			for (int num6 = 5; num6 >= 0; num6--)
			{
				if (!m_SprMedal_Normal[num6].enabled)
				{
					m_SprMedal_Normal[num6].enabled = true;
					m_SprMedal_Normal[num6].spriteName = "panel_r2_su_m";
					break;
				}
			}
			break;
		}
		case 1:
		{
			bool flag2 = false || m_GameNumTotal / 10000 % 10 > 0;
			m_SprGameNum_Normal[0].enabled = flag2;
			flag2 = flag2 || m_GameNumTotal / 1000 % 10 > 0;
			m_SprGameNum_Normal[1].enabled = flag2;
			flag2 = flag2 || m_GameNumTotal / 100 % 10 > 0;
			m_SprGameNum_Normal[2].enabled = flag2;
			flag2 = flag2 || m_GameNumTotal / 10 % 10 > 0;
			m_SprGameNum_Normal[3].enabled = flag2;
			flag2 = flag2 || m_GameNumTotal % 10 >= 0;
			m_SprGameNum_Normal[4].enabled = flag2;
			flag = flag2;
			m_SprGameNum_Normal[0].spriteName = "panel_g_su_" + m_GameNumTotal / 10000 % 10;
			m_SprGameNum_Normal[1].spriteName = "panel_g_su_" + m_GameNumTotal / 1000 % 10;
			m_SprGameNum_Normal[2].spriteName = "panel_g_su_" + m_GameNumTotal / 100 % 10;
			m_SprGameNum_Normal[3].spriteName = "panel_g_su_" + m_GameNumTotal / 10 % 10;
			m_SprGameNum_Normal[4].spriteName = "panel_g_su_" + m_GameNumTotal % 10;
			int num3 = ((m_BBNum > 0) ? (m_GameNumTotal / m_BBNum) : 0);
			int num4 = ((m_RBNum > 0) ? (m_GameNumTotal / m_RBNum) : 0);
			int num5 = ((m_ARTNum > 0) ? (m_GameNumTotal / m_ARTNum) : 0);
			num3 = ((num3 <= 999) ? num3 : 999);
			num4 = ((num4 <= 999) ? num4 : 999);
			num5 = ((num5 <= 999) ? num5 : 999);
			if (num3 > 0)
			{
				m_ObjData2PerNum[0].SetActive(true);
				m_SprBB_Per[0].spriteName = "panel_r_su_1";
				m_SprBB_Per[1].spriteName = "panel_r2_su_s";
				flag2 = false || num3 / 100 % 10 > 0;
				m_SprBB_Per[2].enabled = flag2;
				flag2 = flag2 || num3 / 10 % 10 > 0;
				m_SprBB_Per[3].enabled = flag2;
				flag2 = flag2 || num3 % 10 >= 0;
				m_SprBB_Per[4].enabled = flag2;
				flag = flag2;
				m_SprBB_Per[2].spriteName = "panel_r_su_" + num3 / 100 % 10;
				m_SprBB_Per[3].spriteName = "panel_r_su_" + ((num3 / 10) & 0xA);
				m_SprBB_Per[4].spriteName = "panel_r_su_" + num3 % 10;
			}
			else
			{
				m_SprBB_Per[0].enabled = false;
				m_SprBB_Per[1].enabled = false;
				m_SprBB_Per[2].enabled = false;
				m_SprBB_Per[3].enabled = false;
				m_SprBB_Per[4].enabled = true;
				m_SprBB_Per[4].spriteName = "panel_r2_su_m";
			}
			if (num4 > 0)
			{
				m_ObjData2PerNum[1].SetActive(true);
				m_SprRB_Per[0].spriteName = "panel_y_su_1";
				m_SprRB_Per[1].spriteName = "panel_y2_su_s";
				flag2 = false || num4 / 100 % 10 > 0;
				m_SprRB_Per[2].enabled = flag2;
				flag2 = flag2 || num4 / 10 % 10 > 0;
				m_SprRB_Per[3].enabled = flag2;
				flag2 = flag2 || num4 % 10 >= 0;
				m_SprRB_Per[4].enabled = flag2;
				flag = flag2;
				m_SprRB_Per[2].spriteName = "panel_y_su_" + num4 / 100 % 10;
				m_SprRB_Per[3].spriteName = "panel_y_su_" + ((num4 / 10) & 0xA);
				m_SprRB_Per[4].spriteName = "panel_y_su_" + num4 % 10;
			}
			else
			{
				m_SprRB_Per[0].enabled = false;
				m_SprRB_Per[1].enabled = false;
				m_SprRB_Per[2].enabled = false;
				m_SprRB_Per[3].enabled = false;
				m_SprRB_Per[4].enabled = true;
				m_SprRB_Per[4].spriteName = "panel_y2_su_m";
			}
			if (num5 > 0)
			{
				m_ObjData2PerNum[2].SetActive(true);
				m_SprART_Per[0].spriteName = "panel_b_su_1";
				m_SprART_Per[1].spriteName = "panel_b2_su_s";
				flag2 = false || num5 / 100 % 10 > 0;
				m_SprART_Per[2].enabled = flag2;
				flag2 = flag2 || num5 / 10 % 10 > 0;
				m_SprART_Per[3].enabled = flag2;
				flag2 = flag2 || num5 % 10 >= 0;
				m_SprART_Per[4].enabled = flag2;
				flag = flag2;
				m_SprART_Per[2].spriteName = "panel_b_su_" + num5 / 100 % 10;
				m_SprART_Per[3].spriteName = "panel_b_su_" + ((num5 / 10) & 0xA);
				m_SprART_Per[4].spriteName = "panel_b_su_" + num5 % 10;
			}
			else
			{
				m_SprART_Per[0].enabled = false;
				m_SprART_Per[1].enabled = false;
				m_SprART_Per[2].enabled = false;
				m_SprART_Per[3].enabled = false;
				m_SprART_Per[4].enabled = true;
				m_SprART_Per[4].spriteName = "panel_b_su_m";
			}
			break;
		}
		case 2:
		{
			bool flag2 = false || m_GameNumTotal_Prev / 10000 % 10 > 0;
			m_SprGameNum_Normal[0].enabled = flag2;
			flag2 = flag2 || m_GameNumTotal_Prev / 1000 % 10 > 0;
			m_SprGameNum_Normal[1].enabled = flag2;
			flag2 = flag2 || m_GameNumTotal_Prev / 100 % 10 > 0;
			m_SprGameNum_Normal[2].enabled = flag2;
			flag2 = flag2 || m_GameNumTotal_Prev / 10 % 10 > 0;
			m_SprGameNum_Normal[3].enabled = flag2;
			flag2 = flag2 || m_GameNumTotal_Prev % 10 >= 0;
			m_SprGameNum_Normal[4].enabled = flag2;
			flag = flag2;
			m_SprGameNum_Normal[0].spriteName = "panel_g_su_" + m_GameNumTotal_Prev / 10000 % 10;
			m_SprGameNum_Normal[1].spriteName = "panel_g_su_" + m_GameNumTotal_Prev / 1000 % 10;
			m_SprGameNum_Normal[2].spriteName = "panel_g_su_" + m_GameNumTotal_Prev / 100 % 10;
			m_SprGameNum_Normal[3].spriteName = "panel_g_su_" + m_GameNumTotal_Prev / 10 % 10;
			m_SprGameNum_Normal[4].spriteName = "panel_g_su_" + m_GameNumTotal_Prev % 10;
			flag2 = false || m_BBNum_Prev / 100 % 10 > 0;
			m_SprBB_Prev[0].enabled = flag2;
			flag2 = flag2 || m_BBNum_Prev / 10 % 10 > 0;
			m_SprBB_Prev[1].enabled = flag2;
			flag2 = flag2 || m_BBNum_Prev % 10 >= 0;
			m_SprBB_Prev[2].enabled = flag2;
			flag = flag2;
			m_SprBB_Prev[0].spriteName = "panel_r_su_" + m_BBNum_Prev / 100 % 10;
			m_SprBB_Prev[1].spriteName = "panel_r_su_" + m_BBNum_Prev / 10 % 10;
			m_SprBB_Prev[2].spriteName = "panel_r_su_" + m_BBNum_Prev % 10;
			flag2 = false || m_RBNum_Prev / 100 % 10 > 0;
			m_SprRB_Prev[0].enabled = flag2;
			flag2 = flag2 || m_RBNum_Prev / 10 % 10 > 0;
			m_SprRB_Prev[1].enabled = flag2;
			flag2 = flag2 || m_RBNum_Prev % 10 >= 0;
			m_SprRB_Prev[2].enabled = flag2;
			flag = flag2;
			m_SprRB_Prev[0].spriteName = "panel_y_su_" + m_RBNum_Prev / 100 % 10;
			m_SprRB_Prev[1].spriteName = "panel_y_su_" + m_RBNum_Prev / 10 % 10;
			m_SprRB_Prev[2].spriteName = "panel_y_su_" + m_RBNum_Prev % 10;
			flag2 = false || m_ARTNum_Prev / 100 % 10 > 0;
			m_SprART_Prev[0].enabled = flag2;
			flag2 = flag2 || m_ARTNum_Prev / 10 % 10 > 0;
			m_SprART_Prev[1].enabled = flag2;
			flag2 = flag2 || m_ARTNum_Prev % 10 >= 0;
			m_SprART_Prev[2].enabled = flag2;
			flag = flag2;
			m_SprART_Prev[0].spriteName = "panel_b_su_" + m_ARTNum_Prev / 100 % 10;
			m_SprART_Prev[1].spriteName = "panel_b_su_" + m_ARTNum_Prev / 10 % 10;
			m_SprART_Prev[2].spriteName = "panel_b_su_" + m_ARTNum_Prev % 10;
			break;
		}
		}
		update_rireki_data();
	}

	private void update_rireki_data()
	{
		string[] array = new string[5] { "panel_rireki_r", "panel_rireki_y", "panel_rireki_r", "panel_rireki_r", "panel_rireki_b" };
		for (int i = 0; i < 5; i++)
		{
			int num = 0;
			switch (m_NormalPanelMode)
			{
			default:
				return;
			case 0:
			case 1:
				num = m_BonusRireki[i];
				break;
			case 2:
				num = m_BonusRireki_Prev[i];
				break;
			}
			for (int j = 0; j < RIREKI_TSUBU_NUM + 1; j++)
			{
				if (!m_FlagRireki[i, j])
				{
					m_ObjRireki_Tsubu[i, j].transform.localPosition += new Vector3(1024f, 0f, 0f);
					m_FlagRireki[i, j] = true;
				}
			}
			if (num <= 0)
			{
				continue;
			}
			m_SprRireki_Kind[i].spriteName = array[m_BonusRirekiKind[i]];
			if (m_FlagRireki[i, 0])
			{
				m_ObjRireki_Tsubu[i, 0].transform.localPosition -= new Vector3(1024f, 0f, 0f);
				m_FlagRireki[i, 0] = false;
			}
			for (int k = 1; k < RIREKI_TSUBU_NUM; k++)
			{
				if ((num - 1) / 100 >= k - 1 && m_FlagRireki[i, k])
				{
					m_ObjRireki_Tsubu[i, k].transform.localPosition -= new Vector3(1024f, 0f, 0f);
					m_FlagRireki[i, k] = false;
				}
			}
			bool num2;
			if (num > 900)
			{
				num2 = m_BlinkCount < 20;
			}
			else
			{
				if (num <= 800)
				{
					continue;
				}
				num2 = m_FlagRireki[i, RIREKI_TSUBU_NUM];
			}
			if (num2)
			{
				m_ObjRireki_Tsubu[i, RIREKI_TSUBU_NUM].transform.localPosition -= new Vector3(1024f, 0f, 0f);
				m_FlagRireki[i, RIREKI_TSUBU_NUM] = false;
			}
		}
	}

	public void setCollisionActive(bool _flag)
	{
		m_ButtonActive = _flag;
		UICam.enabled = _flag;
	}
}
