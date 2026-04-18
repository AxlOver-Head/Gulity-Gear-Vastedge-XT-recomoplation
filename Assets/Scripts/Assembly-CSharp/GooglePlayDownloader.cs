using System;
using System.IO;
using UnityEngine;

public class GooglePlayDownloader
{
	private const string Environment_MEDIA_MOUNTED = "mounted";

	private static AndroidJavaClass detectAndroidJNI;

	private static AndroidJavaClass Environment;

	private static string obb_package;

	private static int obb_version;

	static GooglePlayDownloader()
	{
		if (!RunningOnAndroid())
		{
			return;
		}
		Environment = new AndroidJavaClass("android.os.Environment");
		using (AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.unity3d.plugin.downloader.UnityDownloaderService"))
		{
			androidJavaClass.SetStatic("BASE64_PUBLIC_KEY", "=+CKc9WbAEqMYugTYCOyRNIUN4U7N5zI+W72muZBVJiJQkdJo6PVu3yhUrnZKVlAA97CSY9qB1VNdmVd1ShhcY7rKjjPPJdXLT3Ilq+ec3ILcqhZsDzo14enRhy+R00DJONTc6c7PFh7dqRO/IToua1KLr+td8bd7ec19SENQ/UdV9qxzlJXd1Orxauioicq9/Wd9SEqPfnWsqlp5fZ8assff7Ibo1kNaxn/ZH5V/q0PBJsr6FfChtYjEW9azEcOy/gGsZcTo+rWnOmzG/FPp17wIDAQAB");
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

	public static string GetExpansionFilePath()
	{
		populateOBBData();
		/*
		if (Environment.CallStatic<string>("getExternalStorageState", new object[0]) != "mounted")
		{
			return null;
		}
		using (AndroidJavaObject androidJavaObject = Environment.CallStatic<AndroidJavaObject>("getExternalStorageDirectory", new object[0]))
		{
			string arg = androidJavaObject.Call<string>("getPath", new object[0]);
			return string.Format("{0}/{1}/{2}", arg, "Android/obb", obb_package);
		}
		*/
		// Now goes to local path
		string path = Directory.GetCurrentDirectory();
		return string.Format("{0}/Assets/Obb", path);
	}

	public static string GetMainOBBPath(int version)
	{
		populateOBBData();
		return string.Format("main.{0}.{1}", version, obb_package);
	}

	public static string GetMainOBBPath()
	{
		populateOBBData();
		return string.Format("main.{0}.{1}", obb_version, obb_package);
	}

	public static string GetMainOBBPath(string expansionFilePath)
	{
		populateOBBData();
		if (expansionFilePath == null)
		{
			return null;
		}
		string text = string.Format("{0}/main.{1}.{2}", expansionFilePath, obb_version, obb_package);
		if (!File.Exists(text))
		{
			return null;
		}
		return text;
	}

	public static string GetPatchOBBPath(int version)
	{
		populateOBBData();
		return string.Format("patch.{0}.{1}", version, obb_package);
	}

	public static string GetPatchOBBPath()
	{
		populateOBBData();
		return string.Format("patch.{0}.{1}", obb_version, obb_package);
	}

	public static string GetPatchOBBPath(string expansionFilePath)
	{
		populateOBBData();
		if (expansionFilePath == null)
		{
			return null;
		}
		string text = string.Format("{0}/patch.{1}.{2}", expansionFilePath, obb_version, obb_package);
		if (!File.Exists(text))
		{
			return null;
		}
		return text;
	}

	public static void FetchOBB()
	{
		using (AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
		{
			AndroidJavaObject androidJavaObject = androidJavaClass.GetStatic<AndroidJavaObject>("currentActivity");
			AndroidJavaObject androidJavaObject2 = new AndroidJavaObject("android.content.Intent", androidJavaObject, new AndroidJavaClass("com.unity3d.plugin.downloader.UnityDownloaderActivity"));
			int num = 65536;
			androidJavaObject2.Call<AndroidJavaObject>("addFlags", new object[1] { num });
			androidJavaObject2.Call<AndroidJavaObject>("putExtra", new object[2]
			{
				"unityplayer.Activity",
				androidJavaObject.Call<AndroidJavaObject>("getClass", new object[0]).Call<string>("getName", new object[0])
			});
			androidJavaObject.Call("startActivity", androidJavaObject2);
			if (AndroidJNI.ExceptionOccurred() != IntPtr.Zero)
			{
				AndroidJNI.ExceptionDescribe();
				AndroidJNI.ExceptionClear();
			}
		}

	}

	private static void populateOBBData()
	{
		if (obb_version != 0)
		{
			return;
		}
		/* old and outdated
		using (AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
		{
			AndroidJavaObject androidJavaObject = androidJavaClass.GetStatic<AndroidJavaObject>("currentActivity");
			obb_package = androidJavaObject.Call<string>("getPackageName", new object[0]);
			AndroidJavaObject androidJavaObject2 = androidJavaObject.Call<AndroidJavaObject>("getPackageManager", new object[0]).Call<AndroidJavaObject>("getPackageInfo", new object[2] { obb_package, 0 });
			obb_version = SGLG.OBB_VERSION;
		}
		Now comes with game locally*/
		obb_package = "com.dtechno.slotguilty.obb";
		obb_version = SGLG.OBB_VERSION;
	}
}
