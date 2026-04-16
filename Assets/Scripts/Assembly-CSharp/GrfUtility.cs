using System;
using System.Text;
using UnityEngine;

public class GrfUtility
{
	public static T addComponentOnce<T>(string name) where T : Component
	{
		GameObject gameObject = GameObject.Find(name);
		if (gameObject == null)
		{
			gameObject = new GameObject(name);
		}
		return addComponentOnce<T>(gameObject);
	}

	public static T addComponentOnce<T>(GameObject obj) where T : Component
	{
		T component = obj.GetComponent<T>();
		return (!(component == null)) ? component : obj.AddComponent<T>();
	}

	public static string getDataSavePath(string filename = "")
	{
		string persistentDataPath = Application.persistentDataPath;
		return persistentDataPath + "/" + filename;
	}

	public static GameObject clone(GameObject obj, Transform parent = null)
	{
		if (obj == null)
		{
			return null;
		}
		GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(obj);
		if (parent != null && gameObject != null)
		{
			Vector3 localPosition = gameObject.transform.localPosition;
			Vector3 localScale = gameObject.transform.localScale;
			Quaternion localRotation = gameObject.transform.localRotation;
			gameObject.transform.parent = parent;
			gameObject.transform.localPosition = localPosition;
			gameObject.transform.localScale = localScale;
			gameObject.transform.localRotation = localRotation;
		}
		return gameObject;
	}

	public static void animationPlay(Animation anime, string name, bool reverse = false)
	{
		AnimationState animationState = anime.GetComponent<Animation>()[name];
		if (reverse)
		{
			animationState.speed = -1f;
			animationState.time = animationState.length;
		}
		else
		{
			animationState.speed = 1f;
			animationState.time = 0f;
		}
		anime.GetComponent<Animation>().Play(name);
	}

	public static bool isAnimationPlaying(Animation anime, string name)
	{
		return anime.IsPlaying(name);
	}

	public static GameObject addEmptyObject(GameObject parent, string objectname)
	{
		GameObject gameObject = new GameObject(objectname);
		gameObject.transform.parent = parent.transform;
		return gameObject;
	}

	public static GameObject addEmptyObject(string parent, string objectname)
	{
		GameObject gameObject = GameObject.Find(parent);
		if (gameObject != null)
		{
			GameObject gameObject2 = new GameObject(objectname);
			gameObject2.transform.parent = gameObject.transform;
			return gameObject2;
		}
		return null;
	}

	public static uint useMemory()
	{
		return UnityEngine.Profiling.Profiler.usedHeapSize / 1048576;
	}

	public static int totalMemory()
	{
		return SystemInfo.systemMemorySize;
	}

	public static int setBuffer(byte[] b, int offset, byte[] v)
	{
		for (int i = 0; i < v.Length; i++)
		{
			b[offset++] = v[i];
		}
		return offset;
	}

	public static int setBuffer(byte[] b, int offset, byte v)
	{
		b[offset++] = v;
		return offset;
	}

	public static int setBuffer(byte[] b, int offset, int v, bool bigEndian)
	{
		byte[] bytes = BitConverter.GetBytes(v);
		if (bigEndian)
		{
			Array.Reverse(bytes);
		}
		for (int i = 0; i < bytes.Length; i++)
		{
			b[offset++] = bytes[i];
		}
		return offset;
	}

	public static string byteToString(byte[] b)
	{
		return Encoding.UTF8.GetString(b);
	}

	public static byte[] stringToByte(string str)
	{
		return Encoding.UTF8.GetBytes(str);
	}

	public static void dump(int max_size, byte[] buf, string text = "")
	{
		string text2 = text;
		int num = 0;
		bool flag = false;
		if (max_size >= buf.Length)
		{
			num = buf.Length;
		}
		else
		{
			num = max_size;
			flag = true;
		}
		for (int i = 0; i < num; i++)
		{
			text2 += string.Format("{0:X2} ", buf[i]);
			if (i != 0 && (i + 1) % 16 == 0)
			{
				text2 += "\n";
			}
		}
		if (flag)
		{
			string text3 = text2;
			text2 = text3 + "\nprint max_size(" + buf.Length + "/" + max_size + ")\n";
		}
	}
}
