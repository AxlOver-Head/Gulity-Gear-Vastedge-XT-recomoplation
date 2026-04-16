using UnityEngine;

public class GGLRealTimeClock : MonoBehaviour
{
	private static float m_realtime;

	public static float deltaTime;

	public static float deltaTimeCopy;

	public double RealTimeClock()
	{
		return Time.realtimeSinceStartup;
	}

	private void Awake()
	{
	}

	private void Update()
	{
		deltaTime = Time.realtimeSinceStartup - m_realtime;
		deltaTime = ((!(deltaTime < 0f)) ? deltaTime : (1f / (float)Application.targetFrameRate));
		m_realtime = Time.realtimeSinceStartup;
	}

	private void OnApplicationPause(bool b)
	{
		if (!b)
		{
			if (deltaTimeCopy != 0f)
			{
				m_realtime = Time.realtimeSinceStartup - deltaTimeCopy;
				deltaTime = deltaTimeCopy;
			}
		}
		else
		{
			deltaTimeCopy = deltaTime;
		}
	}
}
