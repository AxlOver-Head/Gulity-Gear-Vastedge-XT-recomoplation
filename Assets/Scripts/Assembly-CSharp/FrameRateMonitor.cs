using UnityEngine;

public class FrameRateMonitor : MonoBehaviour
{
	private static readonly float INTERVAL = 0.5f;

	private static float oldTime;

	private static int frameCnt;

	public static float frameRate;

	private void Start()
	{
		oldTime = Time.realtimeSinceStartup;
	}

	private void Update()
	{
		frameCnt++;
		float num = Time.realtimeSinceStartup - oldTime;
		if (num >= INTERVAL)
		{
			frameRate = (float)frameCnt / num;
			oldTime = Time.realtimeSinceStartup;
			frameCnt = 0;
		}
	}
}
