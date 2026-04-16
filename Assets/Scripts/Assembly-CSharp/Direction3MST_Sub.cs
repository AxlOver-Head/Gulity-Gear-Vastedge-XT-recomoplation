public class Direction3MST_Sub
{
	public static readonly int LAYER_BG = 200;

	public static readonly int LAYER_SIN = 190;

	public static readonly int LAYER_KIRA = 185;

	public static readonly int LAYER_SOL = 180;

	public static readonly int LAYER_DAI = 170;

	public static readonly int LAYER_JYD = 160;

	public static readonly float CENTER = 10f;

	public static readonly float POS_BG_X = 54f;

	public static readonly float POS_BG_Y = 0f;

	public static readonly float POS_SIN_X = 206f + CENTER;

	public static readonly float POS_SIN_Y = 70f;

	public static readonly float POS_KIRA_X = 75f;

	public static readonly float POS_KIRA_Y = 50f;

	public static readonly float POS_SOL_X = 106f + CENTER;

	public static readonly float POS_SOL_Y = 68f;

	public static readonly float POS_JYD_X = 93f + CENTER;

	public static readonly float POS_JYD_Y = 92f;

	public static readonly float POS_DAI_X = 40f + CENTER;

	public static readonly float POS_DAI_Y = 0f;

	public static readonly int FRAME_MOVE1 = 540;

	public static readonly int FRAME_MOVE2 = 640;

	public static readonly int FRAME_MOVE3 = 1180;

	public static readonly int FRAME_MOVE4 = 1280;

	private float m_Move_Far;

	private float m_Move_Mid;

	private float m_Move_Nea;

	private int m_BGCount;

	private Production prod;

	private ProductionImg prodImg;

	public Direction3MST_Sub()
	{
		initPosition();
		prod = SGLG.prod;
		prodImg = SGLG.prodImg;
	}

	public void initPosition()
	{
		m_Move_Far = 0f;
		m_Move_Mid = 0f;
		m_Move_Nea = 0f;
		m_BGCount = 0;
	}

	public void control()
	{
		int num = m_BGCount % FRAME_MOVE4;
		if (num < FRAME_MOVE1)
		{
			move1(num);
		}
		else if (num < FRAME_MOVE2)
		{
			move2(num - FRAME_MOVE1);
		}
		else if (num < FRAME_MOVE3)
		{
			move3(num - FRAME_MOVE2);
		}
		else
		{
			move4(num - FRAME_MOVE3);
		}
		if (MainGameScene.slotGameMan.get_pdt_data(45) == 0)
		{
			setPositionBG();
			setPositionSin();
			setPositionKira();
			setPositionSol();
			setPositionDai();
			setPositionJYD();
		}
		m_BGCount++;
	}

	public int getPosBG()
	{
		return (int)(m_Move_Far + POS_BG_X);
	}

	public int getPosSin()
	{
		return (int)(POS_SIN_X + m_Move_Mid);
	}

	public int getPosKira()
	{
		return (int)(POS_KIRA_X + m_Move_Mid);
	}

	public int getPosSol()
	{
		return (int)(POS_SOL_X + m_Move_Nea);
	}

	public int getPosDai()
	{
		return (int)(POS_DAI_X + m_Move_Nea);
	}

	public int getPosJYD()
	{
		return (int)(POS_JYD_X + m_Move_Nea);
	}

	private void setPositionBG()
	{
		int num = prodImg.findLayer(LAYER_BG);
		if (num >= 0)
		{
			float x = m_Move_Far + POS_BG_X;
			float pOS_BG_Y = POS_BG_Y;
			prodImg.SetXY(num, x, pOS_BG_Y);
		}
	}

	private void setPositionSin()
	{
		int num = prod.findLayer(LAYER_SIN);
		if (num >= 0)
		{
			float x = POS_SIN_X + m_Move_Mid;
			float pOS_SIN_Y = POS_SIN_Y;
			prod.SetXY(num, x, pOS_SIN_Y);
		}
	}

	private void setPositionKira()
	{
		int num = prod.findLayer(LAYER_KIRA);
		if (num >= 0)
		{
			float x = POS_KIRA_X + m_Move_Mid;
			float pOS_KIRA_Y = POS_KIRA_Y;
			prod.SetXY(num, x, pOS_KIRA_Y);
		}
	}

	private void setPositionSol()
	{
		int num = prod.findLayer(LAYER_SOL);
		if (num >= 0)
		{
			float x = POS_SOL_X + m_Move_Nea;
			float pOS_SOL_Y = POS_SOL_Y;
			prod.SetXY(num, x, pOS_SOL_Y);
		}
	}

	private void setPositionDai()
	{
		int num = prodImg.findLayer(LAYER_DAI);
		if (num >= 0)
		{
			float x = POS_DAI_X + m_Move_Nea;
			float pOS_DAI_Y = POS_DAI_Y;
			prodImg.SetXY(num, x, pOS_DAI_Y);
		}
	}

	private void setPositionJYD()
	{
		int num = prod.findLayer(LAYER_JYD);
		if (num >= 0)
		{
			float x = POS_JYD_X + m_Move_Nea;
			float pOS_JYD_Y = POS_JYD_Y;
			prod.SetXY(num, x, pOS_JYD_Y);
		}
	}

	private void move1(int cnt)
	{
		float num = 0f;
		float num2 = 0f;
		float num3 = 0f;
		float num4 = -85.759995f;
		float num5 = -95.36f;
		float num6 = -104.96f;
		m_Move_Far = num3 + (num6 - num3) * (float)cnt / (float)FRAME_MOVE1;
		m_Move_Mid = num2 + (num5 - num2) * (float)cnt / (float)FRAME_MOVE1;
		m_Move_Nea = num + (num4 - num) * (float)cnt / (float)FRAME_MOVE1;
	}

	private void move2(int cnt)
	{
		float num = -85.759995f;
		float num2 = -95.36f;
		float num3 = -104.96f;
		float move_Nea = -85.759995f;
		float move_Mid = -95.36f;
		float move_Far = -104.96f;
		m_Move_Far = move_Far;
		m_Move_Mid = move_Mid;
		m_Move_Nea = move_Nea;
	}

	private void move3(int cnt)
	{
		float num = -85.759995f;
		float num2 = -95.36f;
		float num3 = -104.96f;
		float num4 = 0f;
		float num5 = 0f;
		float num6 = 0f;
		m_Move_Far = num3 + (num6 - num3) * (float)cnt / (float)(FRAME_MOVE3 - FRAME_MOVE2);
		m_Move_Mid = num2 + (num5 - num2) * (float)cnt / (float)(FRAME_MOVE3 - FRAME_MOVE2);
		m_Move_Nea = num + (num4 - num) * (float)cnt / (float)(FRAME_MOVE3 - FRAME_MOVE2);
	}

	private void move4(int cnt)
	{
		float num = 0f;
		float num2 = 0f;
		float num3 = 0f;
		float move_Nea = 0f;
		float move_Mid = 0f;
		float move_Far = 0f;
		m_Move_Far = move_Far;
		m_Move_Mid = move_Mid;
		m_Move_Nea = move_Nea;
	}
}
