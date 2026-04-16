using UnityEngine;

public class Utility : MonoBehaviour
{
	private static string _key = "0011223344674567";

	public static string abcEnc(string str)
	{
		str = str.Replace("+", "_");
		str = str.Replace("/", "-");
		str = str.Replace("=", ".");
		return str;
	}

	public static string abcDec(string str)
	{
		str = str.Replace("_", "+");
		str = str.Replace("-", "/");
		str = str.Replace(".", "=");
		return str;
	}

	public static void mailEncryptID(string id, int max, int max_aes)
	{
		for (int i = id.Length; i < max; i++)
		{
			id += " ";
		}
		GrfCryptography.setNoIV();
		byte[] key = GrfUtility.stringToByte(_key);
		byte[] array = GrfCryptography.encrypt(GrfUtility.stringToByte(id), key);
	}

	public static void mailEncryptPass(string pass, int max, int max_aes)
	{
		for (int i = pass.Length; i < max; i++)
		{
			pass += " ";
		}
		GrfCryptography.setNoIV();
		byte[] key = GrfUtility.stringToByte(_key);
		byte[] array = GrfCryptography.encrypt(GrfUtility.stringToByte(pass), key);
	}

	public static void mailDecrypt(out string id, out string pass, bool trim)
	{
		GrfCryptography.setNoIV();
		byte[] array = GrfUtility.stringToByte(_key);
		byte[] loginAdd = PlayUserData.saveData.m_loginAdd;
		byte[] loginPass = PlayUserData.saveData.m_loginPass;
		if (loginAdd == null || loginPass == null)
		{
			id = string.Empty;
			pass = string.Empty;
			return;
		}
		id = GrfUtility.byteToString(loginAdd);
		pass = GrfUtility.byteToString(loginPass);
		if (trim)
		{
			id = id.Trim();
			pass = pass.Trim();
		}
	}
}
