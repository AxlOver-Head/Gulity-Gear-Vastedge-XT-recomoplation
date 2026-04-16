using UnityEngine;

public class YakuObjCube : YakuObj
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
		L_1_A = 69,
		L_1_AB = 70,
		L_1_B = 71,
		L_1_BC = 72,
		L_1_C = 73,
		L_1_CD = 74,
		L_1_D = 75,
		L_1_DA = 76,
		R_1_A = 77,
		R_1_AB = 78,
		R_1_B = 79,
		R_1_BC = 80,
		R_1_C = 81,
		R_1_CD = 82,
		R_1_D = 83,
		R_1_DA = 84,
		L_2_A = 85,
		L_2_AB = 86,
		L_2_B = 87,
		L_2_BC = 88,
		L_2_C = 89,
		L_2_CD = 90,
		L_2_D = 91,
		L_2_DA = 92,
		R_2_A = 93,
		R_2_AB = 94,
		R_2_B = 95,
		R_2_BC = 96,
		R_2_C = 97,
		R_2_CD = 98,
		R_2_D = 99,
		R_2_DA = 100,
		L_3_A = 101,
		L_3_AB = 102,
		L_3_B = 103,
		L_3_BC = 104,
		L_3_C = 105,
		L_3_CD = 106,
		L_3_D = 107,
		L_3_DA = 108,
		R_3_A = 109,
		R_3_AB = 110,
		R_3_B = 111,
		R_3_BC = 112,
		R_3_C = 113,
		R_3_CD = 114,
		R_3_D = 115,
		R_3_DA = 116,
		R_5_A = 117,
		MAX = 118
	}

	public enum DIR
	{
		A = 0,
		AB = 1,
		B = 2,
		BC = 3,
		C = 4,
		CD = 5,
		D = 6,
		DA = 7
	}

	public DIR m_Direction;

	public readonly float FAST_SPEED = 30f;

	public readonly float SLOW_SPEED = 15f;

	private float m_TotalAngle;

	private int m_RollDir = -1;

	private float m_RolledAngle;

	private float m_StartAngle;

	private float m_Angle;

	private int m_NowShakeNum;

	private int m_DestShakeNum;

	private static readonly int ANM_SHAKE_A;

	private static readonly int ANM_SHAKE_B = 1;

	private static readonly int ANM_SHAKE_C = 2;

	private static readonly int ANM_SHAKE_D = 3;

	private string[] anmList = new string[4] { "A_shake", "B_shake", "C_shake", "D_shake" };

	public YakuObjCube()
	{
		init();
	}

	public new void init()
	{
		obj = GameObject.Find("kyoutai/sglg_CG");
		anm = obj.GetComponent<Animation>();
		m_Direction = DIR.A;
		m_Angle = 0f;
		base.init();
	}

	private void _start(int _id)
	{
		m_Active = true;
		m_ID = _id;
		m_Cnt = 0;
	}

	public override void start(int _id)
	{
		if (!(anm == null) && _id >= 0 && _id < 118)
		{
			m_TotalAngle = 0f;
			m_RolledAngle = 0f;
			m_StartAngle = obj.transform.rotation.z;
			DIR direction = m_Direction;
			switch ((KIND)_id)
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
				m_NowShakeNum = 0;
				m_DestShakeNum = (_id + 1) * 2;
				float num = (int)direction * 45;
				float angle = m_Angle;
				float num2 = angle - num;
				m_TotalAngle = 0f - num2 - 45f;
				_start(_id);
				break;
			}
			case KIND.L_1_A:
			case KIND.L_1_AB:
			case KIND.L_1_B:
			case KIND.L_1_BC:
			case KIND.L_1_C:
			case KIND.L_1_CD:
			case KIND.L_1_D:
			case KIND.L_1_DA:
				direction = (DIR)(0 + _id - 69);
				firstLeftRoll();
				LeftRollAdd(direction);
				m_Direction = direction;
				_start(_id);
				break;
			case KIND.L_2_A:
			case KIND.L_2_AB:
			case KIND.L_2_B:
			case KIND.L_2_BC:
			case KIND.L_2_C:
			case KIND.L_2_CD:
			case KIND.L_2_D:
			case KIND.L_2_DA:
				direction = (DIR)(0 + _id - 85);
				firstLeftRoll();
				LeftRoll(direction);
				LeftRollAdd(direction);
				m_Direction = direction;
				_start(_id);
				break;
			case KIND.L_3_A:
			case KIND.L_3_AB:
			case KIND.L_3_B:
			case KIND.L_3_BC:
			case KIND.L_3_C:
			case KIND.L_3_CD:
			case KIND.L_3_D:
			case KIND.L_3_DA:
				direction = (DIR)(0 + _id - 101);
				firstLeftRoll();
				LeftRoll(direction);
				LeftRoll(direction);
				LeftRollAdd(direction);
				m_Direction = direction;
				_start(_id);
				break;
			case KIND.R_1_A:
			case KIND.R_1_AB:
			case KIND.R_1_B:
			case KIND.R_1_BC:
			case KIND.R_1_C:
			case KIND.R_1_CD:
			case KIND.R_1_D:
			case KIND.R_1_DA:
				direction = (DIR)(0 + _id - 77);
				firstRightRoll();
				RightRollAdd(direction);
				m_Direction = direction;
				_start(_id);
				break;
			case KIND.R_2_A:
			case KIND.R_2_AB:
			case KIND.R_2_B:
			case KIND.R_2_BC:
			case KIND.R_2_C:
			case KIND.R_2_CD:
			case KIND.R_2_D:
			case KIND.R_2_DA:
				direction = (DIR)(0 + _id - 93);
				firstRightRoll();
				RightRoll(direction);
				RightRollAdd(direction);
				m_Direction = direction;
				_start(_id);
				break;
			case KIND.R_3_A:
			case KIND.R_3_AB:
			case KIND.R_3_B:
			case KIND.R_3_BC:
			case KIND.R_3_C:
			case KIND.R_3_CD:
			case KIND.R_3_D:
			case KIND.R_3_DA:
				direction = (DIR)(0 + _id - 109);
				firstRightRoll();
				RightRoll(direction);
				RightRoll(direction);
				RightRollAdd(direction);
				m_Direction = direction;
				_start(_id);
				break;
			case KIND.R_5_A:
				direction = (DIR)(0 + _id - 117);
				firstRightRoll();
				RightRoll(direction);
				RightRoll(direction);
				RightRoll(direction);
				RightRoll(direction);
				RightRollAdd(direction);
				m_Direction = direction;
				_start(_id);
				break;
			}
			if (m_TotalAngle < 0f)
			{
				m_RollDir = -1;
			}
			else
			{
				m_RollDir = 1;
			}
		}
	}

	private void firstLeftRoll()
	{
		DIR direction = m_Direction;
		float num = (int)direction * 45;
		float angle = m_Angle;
		float num2 = num - angle;
		m_TotalAngle += num2;
	}

	private void firstRightRoll()
	{
		DIR direction = m_Direction;
		float num = (int)direction * 45;
		float angle = m_Angle;
		float num2 = angle - num;
		m_TotalAngle -= num2;
	}

	private void RightRoll(DIR dir)
	{
		m_TotalAngle -= 360f;
	}

	private void RightRollAdd(DIR dir)
	{
		float num;
		for (num = 360f - (float)(dir - m_Direction) * 45f; num <= 0f; num += 360f)
		{
		}
		m_TotalAngle -= num;
	}

	private void LeftRoll(DIR dir)
	{
		m_TotalAngle += 360f;
	}

	private void LeftRollAdd(DIR dir)
	{
		float num;
		for (num = (float)(dir - m_Direction) * 45f; num <= 0f; num += 360f)
		{
		}
		m_TotalAngle += num;
	}

	private void controlShake(KIND _id)
	{
		if (m_RolledAngle >= Mathf.Abs(m_TotalAngle))
		{
			m_NowShakeNum++;
			if (m_NowShakeNum >= m_DestShakeNum)
			{
				m_Active = false;
				return;
			}
			m_TotalAngle = 0f;
			m_RolledAngle = 0f;
			m_StartAngle = obj.transform.rotation.z;
			if (m_NowShakeNum % 2 == 1)
			{
				m_RollDir = 1;
				m_TotalAngle = 45f;
			}
			else
			{
				m_RollDir = -1;
				m_TotalAngle = -45f;
			}
		}
		float num = (float)m_RollDir * FAST_SPEED;
		m_RolledAngle += Mathf.Abs(num);
		if (m_RolledAngle >= Mathf.Abs(m_TotalAngle))
		{
			num = ((m_RollDir >= 0) ? (num - (m_RolledAngle - m_TotalAngle)) : (num + (m_RolledAngle + m_TotalAngle)));
		}
		m_Angle += num;
		while (m_Angle >= 360f)
		{
			m_Angle -= 360f;
		}
		while (m_Angle < 0f)
		{
			m_Angle += 360f;
		}
		obj.transform.Rotate(0f, 0f, num);
	}

	private void controlRoll(KIND _id)
	{
		if (m_RolledAngle >= Mathf.Abs(m_TotalAngle))
		{
			m_Active = false;
			return;
		}
		float num = ((m_ID == 117) ? ((!(m_RolledAngle >= 1440f)) ? ((float)m_RollDir * FAST_SPEED) : ((float)m_RollDir * SLOW_SPEED)) : ((!(m_RolledAngle >= 720f)) ? ((float)m_RollDir * FAST_SPEED) : ((float)m_RollDir * SLOW_SPEED)));
		m_RolledAngle += Mathf.Abs(num);
		if (m_RolledAngle >= Mathf.Abs(m_TotalAngle))
		{
			num = ((m_RollDir >= 0) ? (num - (m_RolledAngle - m_TotalAngle)) : (num + (m_RolledAngle + m_TotalAngle)));
		}
		m_Angle += num;
		while (m_Angle >= 360f)
		{
			m_Angle -= 360f;
		}
		while (m_Angle < 0f)
		{
			m_Angle += 360f;
		}
		obj.transform.Rotate(0f, 0f, num);
	}

	public override void control()
	{
		if (m_Active)
		{
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
				controlShake((KIND)m_ID);
				break;
			case KIND.L_1_A:
			case KIND.L_1_AB:
			case KIND.L_1_B:
			case KIND.L_1_BC:
			case KIND.L_1_C:
			case KIND.L_1_CD:
			case KIND.L_1_D:
			case KIND.L_1_DA:
			case KIND.R_1_A:
			case KIND.R_1_AB:
			case KIND.R_1_B:
			case KIND.R_1_BC:
			case KIND.R_1_C:
			case KIND.R_1_CD:
			case KIND.R_1_D:
			case KIND.R_1_DA:
			case KIND.L_2_A:
			case KIND.L_2_AB:
			case KIND.L_2_B:
			case KIND.L_2_BC:
			case KIND.L_2_C:
			case KIND.L_2_CD:
			case KIND.L_2_D:
			case KIND.L_2_DA:
			case KIND.R_2_A:
			case KIND.R_2_AB:
			case KIND.R_2_B:
			case KIND.R_2_BC:
			case KIND.R_2_C:
			case KIND.R_2_CD:
			case KIND.R_2_D:
			case KIND.R_2_DA:
			case KIND.L_3_A:
			case KIND.L_3_AB:
			case KIND.L_3_B:
			case KIND.L_3_BC:
			case KIND.L_3_C:
			case KIND.L_3_CD:
			case KIND.L_3_D:
			case KIND.L_3_DA:
			case KIND.R_3_A:
			case KIND.R_3_AB:
			case KIND.R_3_B:
			case KIND.R_3_BC:
			case KIND.R_3_C:
			case KIND.R_3_CD:
			case KIND.R_3_D:
			case KIND.R_3_DA:
			case KIND.R_5_A:
				controlRoll((KIND)m_ID);
				break;
			}
			base.control();
		}
	}
}
