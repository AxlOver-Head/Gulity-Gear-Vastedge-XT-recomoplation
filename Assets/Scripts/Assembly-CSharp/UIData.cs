using System;
using UnityEngine;

public class UIData : MonoBehaviour
{
	public enum MODE
	{
		INIT = 0,
		STAY = 1,
		MOVE_L = 2,
		MOVE_R = 3,
		BACK = 4,
		END = 5
	}

	public static readonly float MOVE_SPEED = 32f;

	public static readonly float WIDTH = 960f;

	public static readonly float LIMIT_L = 0f - WIDTH;

	public static readonly float LIMIT_R = WIDTH;

	public static readonly int PAGE_MAX = 4;

	public static readonly float FLICK_MOVE = 180f;

	public static readonly float FLICK_START = 64f;

	public static readonly int RIREKI_NUM = 20;

	private MODE m_Mode;

	private GameObject m_BackButton;

	private GameObject m_Arrow_L;

	private GameObject m_Arrow_R;

	private GameObject m_Rireki;

	public GameObject[] m_Panels;

	private UISprite[] m_Titles;

	private UISprite[] m_Pages;

	private UIDataData m_DataData;

	private UIDataBonus m_DataBonus;

	private UIDataRireki[] m_DataRireki;

	private GameObject m_ScrollPanel;

	private UISprite m_Arrow;

	private UIDataSlump m_DataSlump;

	private bool m_Active;

	private int m_Page;

	private float m_Move;

	private float m_Drag;

	private float m_Flick;

	private bool m_IsDrag;

	private bool m_IsFlick;

	private int m_Cnt;

	private void Start()
	{
		m_Active = false;
		m_Mode = MODE.INIT;
		m_Page = 0;
		m_Move = 0f;
		m_Drag = 0f;
		m_Flick = 0f;
		m_IsDrag = false;
		m_IsFlick = false;
		m_BackButton = GameObject.Find("Data(Clone)/Camera/Anchor1_Top/Panel/Button_Back");
		UIButtonMessage component = m_BackButton.GetComponent<UIButtonMessage>();
		component.target = base.gameObject;
		component.functionName = "OnClickBack";
		m_Arrow_L = GameObject.Find("Data(Clone)/Camera/Anchor3_Bottom/Panel/Arrow_L");
		UIButtonMessage component2 = m_Arrow_L.GetComponent<UIButtonMessage>();
		component2.target = base.gameObject;
		component2.functionName = "OnClickArrowL";
		m_Arrow_R = GameObject.Find("Data(Clone)/Camera/Anchor3_Bottom/Panel/Arrow_R");
		UIButtonMessage component3 = m_Arrow_R.GetComponent<UIButtonMessage>();
		component3.target = base.gameObject;
		component3.functionName = "OnClickArrowR";
		setInput(false);
		m_Rireki = GameObject.Find("Data(Clone)/Camera/Anchor1_Top/Panel_3_Rireki/ScrollPanel/Rireki");
		m_ScrollPanel = GameObject.Find("Data(Clone)/Camera/Anchor1_Top/Panel_3_Rireki/ScrollPanel");
		m_Arrow = GameObject.Find("Data(Clone)/Camera/Anchor1_Top/Panel_3_Rireki/Arrow_2").GetComponent<UISprite>();
		m_Panels = new GameObject[PAGE_MAX];
		m_Panels[0] = GameObject.Find("Data(Clone)/Camera/Anchor2_Center/Panel_1_Data");
		m_Panels[1] = GameObject.Find("Data(Clone)/Camera/Anchor2_Center/Panel_2_Bonus");
		m_Panels[2] = GameObject.Find("Data(Clone)/Camera/Anchor1_Top/Panel_3_Rireki");
		m_Panels[3] = GameObject.Find("Data(Clone)/Camera/Anchor2_Center/Panel_4_Slump");
		m_Titles = new UISprite[PAGE_MAX];
		m_Pages = new UISprite[PAGE_MAX];
		for (int i = 0; i < PAGE_MAX; i++)
		{
			m_Titles[i] = GameObject.Find("Data(Clone)/Camera/Anchor1_Top/Panel/Title" + (i + 1)).GetComponent<UISprite>();
			m_Pages[i] = GameObject.Find("Data(Clone)/Camera/Anchor3_Bottom/Panel/Page_" + (i + 1)).GetComponent<UISprite>();
		}
		findData();
		initData();
		findBonus();
		initBonus();
		findRireki();
		initRireki();
		findSlump();
		initSlump();
		setVisibleMain(false);
		updatePosition();
		m_Active = true;
		SGLG.endFade();
		MainGameScene.sndPlay(0, 8, true, 1f);
		m_Cnt = 0;
	}

	public UISprite[] setUISprite(string _base, string[] _name)
	{
		UISprite[] array = new UISprite[_name.Length];
		for (int i = 0; i < _name.Length; i++)
		{
			array[i] = GameObject.Find(_base + _name[i]).GetComponent<UISprite>();
		}
		return array;
	}

	private void findData()
	{
		m_DataData = new UIDataData(this);
	}

	private void findBonus()
	{
		m_DataBonus = new UIDataBonus(this);
	}

	private void findRireki()
	{
		m_DataRireki = new UIDataRireki[RIREKI_NUM];
		for (int i = 0; i < RIREKI_NUM; i++)
		{
			m_DataRireki[i] = new UIDataRireki(i, this);
		}
	}

	private void findSlump()
	{
		m_DataSlump = new UIDataSlump(this);
	}

	public void setSpriteNum(int keta, int data, UISprite spr, bool erase_zero)
	{
		int num = 1;
		for (int i = 0; i < keta; i++)
		{
			num *= 10;
		}
		if (erase_zero && Mathf.Abs(data) < num)
		{
			spr.color = new Color(1f, 1f, 1f, 0f);
			return;
		}
		string text = "data_num_b_";
		if (data < 0)
		{
			text = "data_num_r_";
		}
		int num2 = data / num % 10;
		if (num2 < 0)
		{
			num2 = -num2;
		}
		spr.spriteName = text + num2;
	}

	public void setSpriteComma(int data, UISprite spr)
	{
		if (data <= -1000)
		{
			spr.spriteName = "data_num_r_c";
		}
		else if (data < 1000)
		{
			spr.color = new Color(1f, 1f, 1f, 0f);
		}
	}

	public void setSpriteMinus(int data, UISprite spr, int allKeta)
	{
		if (data >= 0)
		{
			spr.color = new Color(1f, 1f, 1f, 0f);
			return;
		}
		int num = -data;
		int num2 = 1;
		int i;
		for (i = 1; i < allKeta; i++)
		{
			if (num2 * 10 > num)
			{
				break;
			}
			num2 *= 10;
		}
		int num3 = allKeta - i;
		if (num < 1000)
		{
			num3++;
		}
		float num4 = (float)num3 * 28f;
		spr.gameObject.transform.localPosition = new Vector3(spr.gameObject.transform.localPosition.x + num4, spr.gameObject.transform.localPosition.y, spr.gameObject.transform.localPosition.z);
	}

	public void setSpriteKakuritsu(int data, UISprite spr, int allKeta)
	{
		int num = 1;
		int i;
		for (i = 1; i < allKeta; i++)
		{
			if (num * 10 > data)
			{
				break;
			}
			num *= 10;
		}
		int num2 = allKeta - i;
		float num3 = (float)num2 * 28f;
		spr.gameObject.transform.localPosition = new Vector3(spr.gameObject.transform.localPosition.x + num3, spr.gameObject.transform.localPosition.y, spr.gameObject.transform.localPosition.z);
	}

	public void setSpriteGraphNum(int keta, int data, UISprite spr, bool erase_zero)
	{
		int num = 1;
		for (int i = 0; i < keta; i++)
		{
			num *= 10;
		}
		if (erase_zero && Mathf.Abs(data) < num)
		{
			spr.color = new Color(1f, 1f, 1f, 0f);
			return;
		}
		int num2 = data / num % 10;
		if (num2 < 0)
		{
			num2 = -num2;
		}
		string text = "data_graph_num_";
		spr.spriteName = text + num2;
	}

	public void setSpriteGraphMinus(int data, UISprite spr, int allKeta)
	{
		if (data >= 0)
		{
			spr.color = new Color(1f, 1f, 1f, 0f);
			return;
		}
		int num = -data;
		int num2 = 1;
		int i;
		for (i = 1; i < allKeta; i++)
		{
			if (num2 * 10 > num)
			{
				break;
			}
			num2 *= 10;
		}
		int num3 = allKeta - i;
		float num4 = (float)num3 * 24f;
		spr.gameObject.transform.localPosition = new Vector3(spr.gameObject.transform.localPosition.x + num4, spr.gameObject.transform.localPosition.y, spr.gameObject.transform.localPosition.z);
	}

	private void initData()
	{
		int totalGameCount = MainGameScene.slotGameMan.totalGameCount;
		int gameCount = MainGameScene.slotGameMan.gameCount;
		int gameCountArt = MainGameScene.slotGameMan.gameCountArt;
		int mochiMedal = MainGameScene.slotGameMan.m_mochiMedal;
		int inMedal = MainGameScene.slotGameMan.m_inMedal;
		int outMedal = MainGameScene.slotGameMan.m_outMedal;
		int num = outMedal - inMedal;
		int data_ = ((outMedal > 0) ? (outMedal * 10000 / inMedal) : 0);
		int data_2 = MainGameScene.slotGameMan.m_kaidoData[622] * 20;
		int data_3 = num * 20;
		m_DataData.setData(totalGameCount, gameCount, gameCountArt, mochiMedal, inMedal, outMedal, num, data_, data_2, data_3);
	}

	private void initBonus()
	{
		int bnsPBCnt = MainGameScene.slotGameMan.data.hisData.bnsPBCnt;
		int bnsSGBCnt = MainGameScene.slotGameMan.data.hisData.bnsSGBCnt;
		int bnsGBCnt = MainGameScene.slotGameMan.data.hisData.bnsGBCnt;
		int bnsRBCnt = MainGameScene.slotGameMan.data.hisData.bnsRBCnt;
		int data_ = ((bnsPBCnt + bnsSGBCnt + bnsGBCnt + bnsRBCnt > 0) ? (MainGameScene.slotGameMan.totalGameCount / (bnsPBCnt + bnsSGBCnt + bnsGBCnt + bnsRBCnt)) : 0);
		int artCnt = MainGameScene.slotGameMan.data.hisData.artCnt;
		int data_2 = ((artCnt > 0) ? (MainGameScene.slotGameMan.totalGameCount / artCnt) : 0);
		int artGameMax = MainGameScene.slotGameMan.artGameMax;
		m_DataBonus.setData(bnsPBCnt, bnsSGBCnt, bnsGBCnt, bnsRBCnt, data_, artCnt, data_2, artGameMax);
	}

	private void initRireki()
	{
		for (int i = 0; i < RIREKI_NUM; i++)
		{
			m_DataRireki[i].setData(MainGameScene.slotGameMan.data.hisData.LogTousenYaku[i], MainGameScene.slotGameMan.data.hisData.LogDouziYaku[i], MainGameScene.slotGameMan.data.hisData.LogGameCount[i]);
		}
	}

	private void initSlump()
	{
		m_DataSlump.setData(MainGameScene.slotGameMan.m_SlumpData);
	}

	private void setVisibleMain(bool _flag)
	{
		MainGameScene.setVisibleMain(_flag);
	}

	private void OnClickBack()
	{
		setInput(false);
		SGLG.startFade_Fast();
		m_Mode = MODE.END;
		MainGameScene.sndStop();
	}

	private void OnClickArrowL()
	{
		setInput(false);
		m_Mode = MODE.MOVE_R;
	}

	private void OnClickArrowR()
	{
		setInput(false);
		m_Mode = MODE.MOVE_L;
	}

	private void OnDataPress()
	{
		if (!m_IsDrag && !m_IsFlick && (m_Mode == MODE.STAY || m_Mode == MODE.BACK))
		{
			setInput(false);
			m_Drag = SGLGInput.x;
			m_IsDrag = true;
		}
	}

	private void OnDataRelease()
	{
		if (m_IsDrag && (m_Mode == MODE.STAY || m_Mode == MODE.BACK))
		{
			m_Drag = 0f;
			m_Flick = 0f;
			m_IsDrag = false;
			m_IsFlick = false;
		}
	}

	private void setInput(bool _flag)
	{
		BoxCollider component = m_BackButton.GetComponent<BoxCollider>();
		BoxCollider component2 = m_Arrow_L.GetComponent<BoxCollider>();
		BoxCollider component3 = m_Arrow_R.GetComponent<BoxCollider>();
		component.enabled = _flag;
		component2.enabled = _flag;
		component3.enabled = _flag;
	}

	private void updatePosition()
	{
		float move = m_Move;
		switch (m_Page)
		{
		case 0:
			m_Panels[0].transform.localPosition = new Vector3(move + WIDTH * 0f, m_Panels[0].transform.localPosition.y, m_Panels[0].transform.localPosition.z);
			m_Panels[1].transform.localPosition = new Vector3(move + WIDTH * 1f, m_Panels[1].transform.localPosition.y, m_Panels[1].transform.localPosition.z);
			m_Panels[2].transform.localPosition = new Vector3(move + WIDTH * 2f, m_Panels[2].transform.localPosition.y, m_Panels[2].transform.localPosition.z);
			m_Panels[3].transform.localPosition = new Vector3(move - WIDTH * 1f, m_Panels[3].transform.localPosition.y, m_Panels[3].transform.localPosition.z);
			break;
		case 1:
			m_Panels[0].transform.localPosition = new Vector3(move - WIDTH * 1f, m_Panels[0].transform.localPosition.y, m_Panels[0].transform.localPosition.z);
			m_Panels[1].transform.localPosition = new Vector3(move + WIDTH * 0f, m_Panels[1].transform.localPosition.y, m_Panels[1].transform.localPosition.z);
			m_Panels[2].transform.localPosition = new Vector3(move + WIDTH * 1f, m_Panels[2].transform.localPosition.y, m_Panels[2].transform.localPosition.z);
			m_Panels[3].transform.localPosition = new Vector3(move + WIDTH * 2f, m_Panels[3].transform.localPosition.y, m_Panels[3].transform.localPosition.z);
			break;
		case 2:
			m_Panels[0].transform.localPosition = new Vector3(move - WIDTH * 2f, m_Panels[0].transform.localPosition.y, m_Panels[0].transform.localPosition.z);
			m_Panels[1].transform.localPosition = new Vector3(move - WIDTH * 1f, m_Panels[1].transform.localPosition.y, m_Panels[1].transform.localPosition.z);
			m_Panels[2].transform.localPosition = new Vector3(move + WIDTH * 0f, m_Panels[2].transform.localPosition.y, m_Panels[2].transform.localPosition.z);
			m_Panels[3].transform.localPosition = new Vector3(move + WIDTH * 1f, m_Panels[3].transform.localPosition.y, m_Panels[3].transform.localPosition.z);
			break;
		case 3:
			m_Panels[0].transform.localPosition = new Vector3(move + WIDTH * 1f, m_Panels[0].transform.localPosition.y, m_Panels[0].transform.localPosition.z);
			m_Panels[1].transform.localPosition = new Vector3(move - WIDTH * 2f, m_Panels[1].transform.localPosition.y, m_Panels[1].transform.localPosition.z);
			m_Panels[2].transform.localPosition = new Vector3(move - WIDTH * 1f, m_Panels[2].transform.localPosition.y, m_Panels[2].transform.localPosition.z);
			m_Panels[3].transform.localPosition = new Vector3(move + WIDTH * 0f, m_Panels[3].transform.localPosition.y, m_Panels[3].transform.localPosition.z);
			break;
		}
	}

	private void rirekiMove()
	{
		if (m_IsFlick)
		{
			UIDragPanelContents component = m_Rireki.GetComponent<UIDragPanelContents>();
			component.enabled = false;
		}
	}

	private void rirekiMoveEnd()
	{
		UIDragPanelContents component = m_Rireki.GetComponent<UIDragPanelContents>();
		component.enabled = true;
	}

	private void updatePage()
	{
		for (int i = 0; i < PAGE_MAX; i++)
		{
			if (i == m_Page)
			{
				m_Titles[i].color = new Color(1f, 1f, 1f, 1f);
				m_Pages[i].spriteName = "data_cursor_on";
			}
			else
			{
				m_Titles[i].color = new Color(1f, 1f, 1f, 0f);
				m_Pages[i].spriteName = "data_cursor_off";
			}
		}
	}

	private void updateRirekiArrow()
	{
		GameObject gameObject = m_Panels[2];
		float x = gameObject.transform.localPosition.x;
		float num = 4f;
		float num2 = Mathf.Sin((float)m_Cnt * num * ((float)Math.PI / 180f));
		if (m_ScrollPanel.transform.localPosition.y >= 430f)
		{
			num2 = 1f;
		}
		m_Arrow.color = new Color(1f, 1f, 1f, 1f - num2);
		m_Cnt++;
	}

	private void Update()
	{
		if (!m_Active)
		{
			return;
		}
		switch (m_Mode)
		{
		case MODE.INIT:
			if (!SGLG.isFading)
			{
				m_Mode = MODE.STAY;
				setInput(true);
			}
			break;
		case MODE.STAY:
			if (Input.GetKey(KeyCode.Escape))
			{
				OnClickBack();
			}
			else if (m_IsFlick)
			{
				m_Move = SGLGInput.x - m_Flick;
				updatePosition();
				rirekiMove();
			}
			else if (m_IsDrag)
			{
				float num = SGLGInput.x - m_Drag;
				if (num >= FLICK_START)
				{
					m_Flick = m_Drag + FLICK_START;
					m_IsFlick = true;
				}
				else if (num <= 0f - FLICK_START)
				{
					m_Flick = m_Drag - FLICK_START;
					m_IsFlick = true;
				}
			}
			else if (m_Move != 0f)
			{
				if (m_Move >= FLICK_MOVE)
				{
					m_Mode = MODE.MOVE_R;
				}
				else if (m_Move <= 0f - FLICK_MOVE)
				{
					m_Mode = MODE.MOVE_L;
				}
				else
				{
					m_Mode = MODE.BACK;
				}
			}
			else
			{
				m_Move = 0f;
				updatePosition();
				setInput(true);
			}
			break;
		case MODE.MOVE_L:
			m_Move -= MOVE_SPEED * 60f * SGLG.deltaTime;
			if (m_Move <= LIMIT_L)
			{
				m_Move = 0f;
				m_Page++;
				if (m_Page >= PAGE_MAX)
				{
					m_Page = 0;
				}
				m_Mode = MODE.STAY;
				setInput(true);
				updatePage();
				rirekiMoveEnd();
			}
			updatePosition();
			break;
		case MODE.MOVE_R:
			m_Move += MOVE_SPEED * 60f * SGLG.deltaTime;
			if (m_Move >= LIMIT_R)
			{
				m_Move = 0f;
				m_Page--;
				if (m_Page < 0)
				{
					m_Page = PAGE_MAX - 1;
				}
				m_Mode = MODE.STAY;
				setInput(true);
				updatePage();
				rirekiMoveEnd();
			}
			updatePosition();
			break;
		case MODE.BACK:
		{
			bool flag = false;
			if (m_Move < 0f)
			{
				m_Move += MOVE_SPEED * 60f * SGLG.deltaTime;
				if (m_Move >= 0f)
				{
					m_Move = 0f;
					flag = true;
				}
			}
			else
			{
				m_Move -= MOVE_SPEED * 60f * SGLG.deltaTime;
				if (m_Move <= 0f)
				{
					m_Move = 0f;
					flag = true;
				}
			}
			updatePosition();
			if (flag)
			{
				m_Mode = MODE.STAY;
				setInput(true);
				rirekiMoveEnd();
			}
			break;
		}
		case MODE.END:
			if (SGLG.isFadeOutComplete())
			{
				setVisibleMain(true);
				MainGameScene.backFromDataScene();
				UnityEngine.Object.Destroy(base.gameObject);
				Resources.UnloadUnusedAssets();
			}
			break;
		}
		updateRirekiArrow();
	}
}
