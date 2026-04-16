public class MainObjPushButton : TouchableObj
{
	public static bool touched;

	public static bool isExec()
	{
		if (!touched)
		{
			return false;
		}
		touched = false;
		return true;
	}

	private void Update()
	{
	}

	public override void Pushed(int cmd)
	{
		touched = true;
	}

	public override void Held(int cmd)
	{
	}

	public override void Upped(int cmd)
	{
	}
}
