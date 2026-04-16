using UnityEngine;

public class YakuObjChain : YakuObj
{
	public enum KIND
	{
		SHAKE_1 = 0,
		SHAKE_2 = 1,
		SHAKE_3 = 2,
		SHAKE_4 = 3,
		SHAKE_5 = 4,
		SHAKE_6 = 5,
		SHAKE_7 = 6,
		SHAKE_8 = 7,
		SHAKE_9 = 8,
		SHAKE_10 = 9,
		SHAKE_11 = 10,
		SHAKE_12 = 11,
		SHAKE_13 = 12,
		SHAKE_14 = 13,
		SHAKE_15 = 14,
		SHAKE_16 = 15,
		SHAKE_17 = 16,
		SHAKE_18 = 17,
		SHAKE_19 = 18,
		SHAKE_20 = 19,
		SHAKE_21 = 20,
		SHAKE_22 = 21,
		SHAKE_23 = 22,
		SHAKE_24 = 23,
		SHAKE_25 = 24,
		SHAKE_26 = 25,
		SHAKE_27 = 26,
		SHAKE_28 = 27,
		SHAKE_29 = 28,
		SHAKE_30 = 29,
		SHAKE_31 = 30,
		SHAKE_32 = 31,
		SHAKE_33 = 32,
		SHAKE_34 = 33,
		SHAKE_35 = 34,
		SHAKE_36 = 35,
		SHAKE_37 = 36,
		SHAKE_38 = 37,
		SHAKE_39 = 38,
		SHAKE_40 = 39,
		SHAKE_41 = 40,
		SHAKE_42 = 41,
		SHAKE_43 = 42,
		SHAKE_44 = 43,
		SHAKE_45 = 44,
		SHAKE_46 = 45,
		SHAKE_47 = 46,
		SHAKE_48 = 47,
		SHAKE_49 = 48,
		SHAKE_50 = 49,
		SHAKE_51 = 50,
		SHAKE_52 = 51,
		SHAKE_53 = 52,
		SHAKE_54 = 53,
		SHAKE_55 = 54,
		SHAKE_56 = 55,
		SHAKE_57 = 56,
		SHAKE_58 = 57,
		SHAKE_59 = 58,
		SHAKE_60 = 59,
		SHAKE_61 = 60,
		SHAKE_62 = 61,
		SHAKE_63 = 62,
		SHAKE_64 = 63,
		SHAKE_65 = 64,
		SHAKE_66 = 65,
		SHAKE_67 = 66,
		SHAKE_68 = 67,
		SHAKE_69 = 68,
		L_ROLL_1 = 69,
		L_ROLL_2 = 70,
		L_ROLL_3 = 71,
		L_ROLL_4 = 72,
		L_ROLL_5 = 73,
		L_ROLL_6 = 74,
		L_ROLL_7 = 75,
		L_ROLL_8 = 76,
		L_ROLL_9 = 77,
		R_ROLL_1 = 78,
		R_ROLL_2 = 79,
		R_ROLL_3 = 80,
		R_ROLL_4 = 81,
		R_ROLL_5 = 82,
		R_ROLL_6 = 83,
		R_ROLL_7 = 84,
		R_ROLL_8 = 85,
		R_ROLL_9 = 86,
		L_ROLL_SMALL_1 = 87,
		L_ROLL_SMALL_2 = 88,
		L_ROLL_SMALL_3 = 89,
		L_ROLL_SMALL_4 = 90,
		L_ROLL_SMALL_5 = 91,
		L_ROLL_SMALL_6 = 92,
		L_ROLL_SMALL_7 = 93,
		L_ROLL_SMALL_8 = 94,
		R_ROLL_SMALL_1 = 95,
		R_ROLL_SMALL_2 = 96,
		R_ROLL_SMALL_3 = 97,
		R_ROLL_SMALL_4 = 98,
		R_ROLL_SMALL_5 = 99,
		R_ROLL_SMALL_6 = 100,
		R_ROLL_SMALL_7 = 101,
		R_ROLL_SMALL_8 = 102,
		MAX = 103
	}

	private GameObject m_Gear_L;

	private GameObject m_Gear_M;

	private GameObject m_Gear_S;

	private static readonly int SHAKEFRAME = 8;

	private static readonly int ROLLFRAME = 10;

	private static readonly int ROLLFRAMESMALL = ROLLFRAME / 4;

	private static readonly float ANIMEROLL = 60f;

	private static readonly float ANIMEROLLSMALL = 15f;

	private static readonly int ROLLNUM = 4;

	private static readonly int ROLLNUMSMALL = 1;

	private static readonly int SHAKENUM = 1;

	private float m_Angle;

	private string m_Name;

	private string[] anmList = new string[3] { "shake", "move_L", "move_R" };

	public YakuObjChain()
	{
		init();
	}

	public new void init()
	{
		obj = GameObject.Find("kyoutai/sglg_chain_LR");
		anm = obj.GetComponent<Animation>();
		m_Gear_L = GameObject.Find("kyoutai/sglg_gear_dai_LR");
		m_Gear_M = GameObject.Find("kyoutai/sglg_gear_tyu_LR/gear_cyu");
		m_Gear_S = GameObject.Find("kyoutai/sglg_gear_tyu_LR/gia_tyu_naka");
		base.init();
	}

	public override void start(int _id)
	{
		if (anm == null || _id < 0)
		{
			return;
		}
		switch (_id)
		{
		case 0:
		case 1:
		case 2:
		case 3:
		case 4:
		case 5:
		case 6:
		case 7:
		case 8:
		case 9:
		case 10:
		case 11:
		case 12:
		case 13:
		case 14:
		case 15:
		case 16:
		case 17:
		case 18:
		case 19:
		case 20:
		case 21:
		case 22:
		case 23:
		case 24:
		case 25:
		case 26:
		case 27:
		case 28:
		case 29:
		case 30:
		case 31:
		case 32:
		case 33:
		case 34:
		case 35:
		case 36:
		case 37:
		case 38:
		case 39:
		case 40:
		case 41:
		case 42:
		case 43:
		case 44:
		case 45:
		case 46:
		case 47:
		case 48:
		case 49:
		case 50:
		case 51:
		case 52:
		case 53:
		case 54:
		case 55:
		case 56:
		case 57:
		case 58:
		case 59:
		case 60:
		case 61:
		case 62:
		case 63:
		case 64:
		case 65:
		case 66:
		case 67:
		case 68:
		{
			int num3 = _id + 1;
			int num4 = num3 * SHAKENUM - 1;
			start(_id, anmList[0]);
			m_Name = anmList[0];
			for (int j = 0; j < num4; j++)
			{
				anm.PlayQueued(anmList[0]);
			}
			break;
		}
		case 69:
		case 70:
		case 71:
		case 72:
		case 73:
		case 74:
		case 75:
		case 76:
		case 77:
		{
			int num9 = _id - 69 + 1;
			int num10 = num9 * ROLLNUM - 1;
			start(_id, anmList[1]);
			for (int m = 0; m < num10; m++)
			{
				anm.PlayQueued(anmList[1]);
			}
			m_Name = anmList[1];
			m_Angle = (float)num9 * ANIMEROLL;
			break;
		}
		case 78:
		case 79:
		case 80:
		case 81:
		case 82:
		case 83:
		case 84:
		case 85:
		case 86:
		{
			int num5 = _id - 78 + 1;
			int num6 = num5 * ROLLNUM - 1;
			start(_id, anmList[2]);
			for (int k = 0; k < num6; k++)
			{
				anm.PlayQueued(anmList[2]);
			}
			m_Name = anmList[2];
			m_Angle = (float)num5 * ANIMEROLL;
			break;
		}
		case 87:
		case 88:
		case 89:
		case 90:
		case 91:
		case 92:
		case 93:
		case 94:
		{
			int num7 = _id - 87 + 1;
			int num8 = num7 * ROLLNUMSMALL - 1;
			start(_id, anmList[1]);
			for (int l = 0; l < num8; l++)
			{
				anm.PlayQueued(anmList[1]);
			}
			m_Name = anmList[1];
			m_Angle = (float)num7 * ANIMEROLLSMALL;
			break;
		}
		case 95:
		case 96:
		case 97:
		case 98:
		case 99:
		case 100:
		case 101:
		case 102:
		{
			int num = _id - 95 + 1;
			int num2 = num * ROLLNUMSMALL - 1;
			start(_id, anmList[2]);
			for (int i = 0; i < num2; i++)
			{
				anm.PlayQueued(anmList[2]);
			}
			m_Name = anmList[2];
			m_Angle = (float)num * ANIMEROLLSMALL;
			break;
		}
		}
	}

	public override void control()
	{
		if (!m_Active)
		{
			return;
		}
		switch ((KIND)m_ID)
		{
		case KIND.SHAKE_1:
		case KIND.SHAKE_2:
		case KIND.SHAKE_3:
		case KIND.SHAKE_4:
		case KIND.SHAKE_5:
		case KIND.SHAKE_6:
		case KIND.SHAKE_7:
		case KIND.SHAKE_8:
		case KIND.SHAKE_9:
		case KIND.SHAKE_10:
		case KIND.SHAKE_11:
		case KIND.SHAKE_12:
		case KIND.SHAKE_13:
		case KIND.SHAKE_14:
		case KIND.SHAKE_15:
		case KIND.SHAKE_16:
		case KIND.SHAKE_17:
		case KIND.SHAKE_18:
		case KIND.SHAKE_19:
		case KIND.SHAKE_20:
		case KIND.SHAKE_21:
		case KIND.SHAKE_22:
		case KIND.SHAKE_23:
		case KIND.SHAKE_24:
		case KIND.SHAKE_25:
		case KIND.SHAKE_26:
		case KIND.SHAKE_27:
		case KIND.SHAKE_28:
		case KIND.SHAKE_29:
		case KIND.SHAKE_30:
		case KIND.SHAKE_31:
		case KIND.SHAKE_32:
		case KIND.SHAKE_33:
		case KIND.SHAKE_34:
		case KIND.SHAKE_35:
		case KIND.SHAKE_36:
		case KIND.SHAKE_37:
		case KIND.SHAKE_38:
		case KIND.SHAKE_39:
		case KIND.SHAKE_40:
		case KIND.SHAKE_41:
		case KIND.SHAKE_42:
		case KIND.SHAKE_43:
		case KIND.SHAKE_44:
		case KIND.SHAKE_45:
		case KIND.SHAKE_46:
		case KIND.SHAKE_47:
		case KIND.SHAKE_48:
		case KIND.SHAKE_49:
		case KIND.SHAKE_50:
		case KIND.SHAKE_51:
		case KIND.SHAKE_52:
		case KIND.SHAKE_53:
		case KIND.SHAKE_54:
		case KIND.SHAKE_55:
		case KIND.SHAKE_56:
		case KIND.SHAKE_57:
		case KIND.SHAKE_58:
		case KIND.SHAKE_59:
		case KIND.SHAKE_60:
		case KIND.SHAKE_61:
		case KIND.SHAKE_62:
		case KIND.SHAKE_63:
		case KIND.SHAKE_64:
		case KIND.SHAKE_65:
		case KIND.SHAKE_66:
		case KIND.SHAKE_67:
		case KIND.SHAKE_68:
		case KIND.SHAKE_69:
		{
			if (!anm.isPlaying)
			{
				m_Active = false;
				m_Cnt = 0;
				break;
			}
			float num2 = ANIMEROLL / (float)ROLLFRAME;
			if (m_Cnt % 8 >= 4)
			{
				num2 = 0f - num2;
			}
			m_Gear_L.transform.Rotate(0f, 0f, num2);
			m_Gear_M.transform.Rotate(0f, 0f, num2);
			m_Gear_S.transform.Rotate(0f, 0f, 0f - num2);
			break;
		}
		case KIND.L_ROLL_1:
		case KIND.L_ROLL_2:
		case KIND.L_ROLL_3:
		case KIND.L_ROLL_4:
		{
			if (!anm.isPlaying)
			{
				m_Active = false;
				m_Cnt = 0;
				break;
			}
			float num5 = (0f - ANIMEROLL) / (float)ROLLFRAME;
			m_Gear_L.transform.Rotate(0f, 0f, num5);
			m_Gear_M.transform.Rotate(0f, 0f, num5);
			m_Gear_S.transform.Rotate(0f, 0f, 0f - num5);
			break;
		}
		case KIND.R_ROLL_1:
		case KIND.R_ROLL_2:
		case KIND.R_ROLL_3:
		case KIND.R_ROLL_4:
		{
			if (!anm.isPlaying)
			{
				m_Active = false;
				m_Cnt = 0;
				break;
			}
			float num3 = ANIMEROLL / (float)ROLLFRAME;
			m_Gear_L.transform.Rotate(0f, 0f, num3);
			m_Gear_M.transform.Rotate(0f, 0f, num3);
			m_Gear_S.transform.Rotate(0f, 0f, 0f - num3);
			break;
		}
		case KIND.L_ROLL_SMALL_1:
		case KIND.L_ROLL_SMALL_2:
		case KIND.L_ROLL_SMALL_3:
		case KIND.L_ROLL_SMALL_4:
		case KIND.L_ROLL_SMALL_5:
		case KIND.L_ROLL_SMALL_6:
		case KIND.L_ROLL_SMALL_7:
		case KIND.L_ROLL_SMALL_8:
		{
			if (!anm.isPlaying)
			{
				m_Active = false;
				m_Cnt = 0;
				break;
			}
			float num4 = (0f - ANIMEROLLSMALL) / (float)ROLLFRAMESMALL;
			m_Gear_L.transform.Rotate(0f, 0f, num4);
			m_Gear_M.transform.Rotate(0f, 0f, num4);
			m_Gear_S.transform.Rotate(0f, 0f, 0f - num4);
			break;
		}
		case KIND.R_ROLL_SMALL_1:
		case KIND.R_ROLL_SMALL_2:
		case KIND.R_ROLL_SMALL_3:
		case KIND.R_ROLL_SMALL_4:
		case KIND.R_ROLL_SMALL_5:
		case KIND.R_ROLL_SMALL_6:
		case KIND.R_ROLL_SMALL_7:
		case KIND.R_ROLL_SMALL_8:
		{
			if (!anm.isPlaying)
			{
				m_Active = false;
				m_Cnt = 0;
				break;
			}
			float num = ANIMEROLLSMALL / (float)ROLLFRAMESMALL;
			m_Gear_L.transform.Rotate(0f, 0f, num);
			m_Gear_M.transform.Rotate(0f, 0f, num);
			m_Gear_S.transform.Rotate(0f, 0f, 0f - num);
			break;
		}
		}
		base.control();
	}
}
