using System.Runtime.InteropServices;
using UnityEngine;

public class GGLMemoryWarning : MonoBehaviour
{
	public static int WarnSize = 5242880;

	private AsyncOperation ao;

	[DllImport("javabridge")]
	private static extern bool GetMemoryWarning_(int size);

	[DllImport("javabridge")]
	private static extern float GetDiskSpace_();

	public static bool GetMemoryWarning()
	{
		return false;
	}

	public static float GetDiskSpace()
	{
		return GetDiskSpace_();
	}

	private void Update()
	{
		if (ao != null && ao.isDone)
		{
			ao = null;
		}
		if (GetMemoryWarning() && ao == null)
		{
			ao = Resources.UnloadUnusedAssets();
		}
	}
}
