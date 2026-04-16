using System;
using System.Text;
using UnityEngine;

public class GrfNetUtility
{
	public static bool isNetwork()
	{
		if (Application.internetReachability == NetworkReachability.NotReachable)
		{
			return false;
		}
		return true;
	}

	public static string base64Encode(byte[] b)
	{
		return Convert.ToBase64String(b);
	}

	public static byte[] base64Decode(string str)
	{
		return Convert.FromBase64String(str);
	}

	public static string urlEncode(string str)
	{
		return urlEncode(str, Encoding.UTF8);
	}

	public static string urlEncode(string str, Encoding enc)
	{
		return WWW.EscapeURL(str, enc);
	}

	public static string urlDecode(string str)
	{
		return urlDecode(str, Encoding.UTF8);
	}

	public static string urlDecode(string str, Encoding enc)
	{
		return WWW.UnEscapeURL(str, enc);
	}
}
