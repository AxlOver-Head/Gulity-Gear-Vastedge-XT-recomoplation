public class MainObjAuto : TouchableObj
{
	public static bool touched;

	public static int touchCnt;

	public static bool touchedInOneFrame;

	public static readonly int AUTO_FRAME = 30;

	public static void init()
	{
		touched = false;
		touchCnt = 0;
		touchedInOneFrame = false;
	}

	public static bool isExec()
	{
		if (MainGameScene.restartFlag)
		{
			return true;
		}
		return touched && ((touchCnt == 0 && !touchedInOneFrame) || touchCnt >= AUTO_FRAME);
	}

	public static bool isExecAuto()
	{
		if (MainGameScene.restartFlag)
		{
			return true;
		}
		return touched && touchCnt >= AUTO_FRAME;
	}

	private void Update()
	{
		if (MainGameScene.m_PlaySaveData.m_autoSettei != 4)
		{
			touched = true;
			touchCnt = AUTO_FRAME;
		}
	}

	public override void Pushed(int cmd)
	{
		if (!((float)SGLGInput.BASE_H - SGLGInput.y <= (float)(((!MainGameScene.m_DataPanel.isCompactMode()) ? 140 : 40) + 40)))
		{
			touched = true;
			touchCnt = 0;
			if (MainGameScene.m_PlaySaveData.m_autoSettei != 4)
			{
				MainGameScene.EndAutoPlay();
			}
		}
	}

	public override void Held(int cmd)
	{
		touchCnt++;
	}

	public override void Upped(int cmd)
	{
		if (MainGameScene.m_PlaySaveData.m_autoSettei == 4)
		{
			touched = false;
		}
		touchCnt = 0;
	}
}
