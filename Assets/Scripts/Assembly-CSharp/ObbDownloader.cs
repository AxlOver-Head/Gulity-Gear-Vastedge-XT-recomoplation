using System;
using System.IO;
using UnityEngine;

public class ObbDownloader
{
	public const int STATE_UNKNOWN = 0;

	public const int STATE_IDLE = 1;

	public const int STATE_FETCHING_URL = 2;

	public const int STATE_CONNECTING = 3;

	public const int STATE_DOWNLOADING = 4;

	public const int STATE_COMPLETED = 5;

	public const int STATE_PAUSED_NETWORK_UNAVAILABLE = 6;

	public const int STATE_PAUSED_BY_REQUEST = 7;

	public const int STATE_PAUSED_WIFI_DISABLED_NEED_CELLULAR_PERMISSION = 8;

	public const int STATE_PAUSED_NEED_CELLULAR_PERMISSION = 9;

	public const int STATE_PAUSED_WIFI_DISABLED = 10;

	public const int STATE_PAUSED_NEED_WIFI = 11;

	public const int STATE_PAUSED_ROAMING = 12;

	public const int STATE_PAUSED_NETWORK_SETUP_FAILURE = 13;

	public const int STATE_PAUSED_SDCARD_UNAVAILABLE = 14;

	public const int STATE_FAILED_UNLICENSED = 15;

	public const int STATE_FAILED_FETCHING_URL = 16;

	public const int STATE_FAILED_SDCARD_FULL = 17;

	public const int STATE_FAILED_CANCELED = 18;

	public const int STATE_FAILED = 19;

	private const string Environment_MEDIA_MOUNTED = "mounted";

	private static AndroidJavaClass detectAndroidJNI;

	private static AndroidJavaClass Environment;

	private static string obb_package;

	private static int obb_version;

	static ObbDownloader()
	{
		if (!RunningOnAndroid())
		{
			return;
		}
		Environment = new AndroidJavaClass("android.os.Environment");
		using (AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.atclib.obb.UnityDownloaderService"))
		{
			androidJavaClass.SetStatic("BASE64_PUBLIC_KEY", "MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAzlDwjez6PK2ugUPFq0VkiMdeAKfHxmtJisQmXyLgbJSXP66V0XUrmvMlyVi253r+CKc9WbAEqMYugTYCOyRNIUN4U7N5zI+W72muZBVJiJQkdJo6PVu3yhUrnZKVlAA97CSY9qB1VNdmVd1ShhcY7rKjjPPJdXLT3Ilq+ec3ILcqhZsDzo14enRhy+R00DJONTc6c7PFh7dqRO/IToua1KLr+td8bd7ec19SENQ/UdV9qxzlJXd1Orxauioicq9/Wd9SEqPfnWsqlp5fZ8assff7Ibo1kNaxn/ZH5V/q0PBJsr6FfChtYjEW9azEcOy/gGsZcTo+rWnOmzG/FPp17wIDAQAB");
			androidJavaClass.SetStatic("SALT", new byte[20]
			{
				1, 43, 244, 255, 54, 98, 156, 244, 43, 2,
				248, 252, 9, 5, 150, 148, 223, 45, 255, 84
			});
		}
	}

	public static bool RunningOnAndroid()
	{
		if (detectAndroidJNI == null)
		{
			detectAndroidJNI = new AndroidJavaClass("android.os.Build");
		}
		return detectAndroidJNI.GetRawClass() != IntPtr.Zero;
	}

	public static bool IsRequiredDownload()
	{
		string expansionFilePath = GetExpansionFilePath();
		string mainOBBPath = GetMainOBBPath(expansionFilePath);
		string patchOBBPath = GetPatchOBBPath(expansionFilePath);
		Debug.LogError("expPath : " + expansionFilePath);
		Debug.LogError("mainPath : " + mainOBBPath);
		Debug.LogError("patchPath : " + patchOBBPath);
		return mainOBBPath == null || patchOBBPath == null;
	}

	public static string GetExpansionFilePath()
	{
		populateOBBData();
		if (Environment.CallStatic<string>("getExternalStorageState", new object[0]) != "mounted")
		{
			return null;
		}
		using (AndroidJavaObject androidJavaObject = Environment.CallStatic<AndroidJavaObject>("getExternalStorageDirectory", new object[0]))
		{
			string arg = androidJavaObject.Call<string>("getPath", new object[0]);
			return string.Format("{0}/{1}/{2}", arg, "Android/obb", obb_package);
		}
	}

	public static string GetMainOBBPath(int version)
	{
		populateOBBData();
		return string.Format("main.{0}.{1}.obb", version, obb_package);
	}

	public static string GetMainOBBPath()
	{
		populateOBBData();
		return string.Format("main.{0}.{1}.obb", obb_version, obb_package);
	}

	public static string GetMainOBBPath(string expansionFilePath)
	{
		populateOBBData();
		if (expansionFilePath == null)
		{
			return null;
		}
		string text = string.Format("{0}/main.{1}.{2}.obb", expansionFilePath, obb_version, obb_package);
		if (!File.Exists(text))
		{
			return null;
		}
		return text;
	}

	public static string GetPatchOBBPath(int version)
	{
		populateOBBData();
		return string.Format("patch.{0}.{1}.obb", version, obb_package);
	}

	public static string GetPatchOBBPath()
	{
		populateOBBData();
		return string.Format("patch.{0}.{1}.obb", obb_version, obb_package);
	}

	public static string GetPatchOBBPath(string expansionFilePath)
	{
		populateOBBData();
		if (expansionFilePath == null)
		{
			return null;
		}
		string text = string.Format("{0}/patch.{1}.{2}.obb", expansionFilePath, obb_version, obb_package);
		if (!File.Exists(text))
		{
			return null;
		}
		return text;
	}

	public static void FetchOBB()
	{
		using (AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.atclib.obb.Downloader"))
		{
			AndroidJavaObject androidJavaObject = androidJavaClass.CallStatic<AndroidJavaObject>("getInstance", new object[0]);
			androidJavaObject.Call("startDL");
		}
	}

	private static void populateOBBData()
	{
		if (obb_version != 0)
		{
			return;
		}
		using (AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
		{
			AndroidJavaObject androidJavaObject = androidJavaClass.GetStatic<AndroidJavaObject>("currentActivity");
			obb_package = androidJavaObject.Call<string>("getPackageName", new object[0]);
			AndroidJavaObject androidJavaObject2 = androidJavaObject.Call<AndroidJavaObject>("getPackageManager", new object[0]).Call<AndroidJavaObject>("getPackageInfo", new object[2] { obb_package, 0 });
			obb_version = SGLG.OBB_VERSION;
		}
	}

	public static int getState()
	{
		using (AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.atclib.obb.Downloader"))
		{
			AndroidJavaObject androidJavaObject = androidJavaClass.CallStatic<AndroidJavaObject>("getInstance", new object[0]);
			return androidJavaObject.Call<int>("getState", new object[0]);
		}
	}

	public static string getPerstr()
	{
		using (AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.atclib.obb.Downloader"))
		{
			AndroidJavaObject androidJavaObject = androidJavaClass.CallStatic<AndroidJavaObject>("getInstance", new object[0]);
			return androidJavaObject.Call<string>("getPerstr", new object[0]);
		}
	}

	public static void OnStart()
	{
		callMethod("onStart");
	}

	public static void OnStop()
	{
		callMethod("onStop");
	}

	public static void OnResume()
	{
		callMethod("onResume");
	}

	public static void OnPause()
	{
		callMethod("onPause");
	}

	public static void OnDestroy()
	{
		callMethod("onDestroy");
	}

	private static void callMethod(string method)
	{
		using (AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.atclib.obb.Downloader"))
		{
			AndroidJavaObject androidJavaObject = androidJavaClass.CallStatic<AndroidJavaObject>("getInstance", new object[0]);
			androidJavaObject.Call(method);
		}
	}

	public static long getOverallTotal()
	{
		using (AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.atclib.obb.Downloader"))
		{
			AndroidJavaObject androidJavaObject = androidJavaClass.CallStatic<AndroidJavaObject>("getInstance", new object[0]);
			return androidJavaObject.Call<long>("getOverallTotal", new object[0]);
		}
	}

	public static long getOverallProgress()
	{
		using (AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.atclib.obb.Downloader"))
		{
			AndroidJavaObject androidJavaObject = androidJavaClass.CallStatic<AndroidJavaObject>("getInstance", new object[0]);
			return androidJavaObject.Call<long>("getOverallProgress", new object[0]);
		}
	}
}
