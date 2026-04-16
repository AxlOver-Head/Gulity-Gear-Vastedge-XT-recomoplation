using UnityEngine;

public class DebugLog
{
	private const bool isDebug = true;

	public static void showLog(string debuglog)
	{
		Debug.Log("DebugLog : " + debuglog);
	}
}
