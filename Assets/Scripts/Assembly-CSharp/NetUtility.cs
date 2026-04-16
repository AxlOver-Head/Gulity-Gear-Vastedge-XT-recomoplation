using System;
using System.Security.Cryptography;
using UnityEngine;

public class NetUtility
{
	private const string _osCode = "a";

	private const byte LSB0 = 1;

	private const byte LSB1 = 2;

	public static string _appCode = "sglg____";

	public static string _version = "01";

	private static byte[] _keyMochidama = GrfUtility.stringToByte("5Jc{x39d82tos)Ou");

	private static byte[] _keyCommit = GrfUtility.stringToByte("4+2F8{G^ksUCqVyV");

	private static byte[] _mailID = new byte[64];

	private static byte[] _mailPass = new byte[64];

	public static void sendGetUniqueID(string url, GameObject targetScript, string method)
	{
		byte[] b = new byte[11];
		int offset = 0;
		offset = GrfUtility.setBuffer(b, offset, GrfUtility.stringToByte(_appCode));
		offset = GrfUtility.setBuffer(b, offset, GrfUtility.stringToByte("a"));
		offset = GrfUtility.setBuffer(b, offset, GrfUtility.stringToByte(_version));
		WWWForm wWWForm = new WWWForm();
		string fieldName = "GET_UNIQUE_ID";
		wWWForm.AddField(fieldName, GrfUtility.byteToString(b));
		SGLG.network.connectForm(url, targetScript, method, wWWForm);
	}

	public static void sendLogin(string url, GameObject targetScript, string method)
	{
		byte[] b = new byte[147];
		int offset = 0;
		offset = GrfUtility.setBuffer(b, offset, GrfUtility.stringToByte(_appCode));
		offset = GrfUtility.setBuffer(b, offset, GrfUtility.stringToByte("a"));
		offset = GrfUtility.setBuffer(b, offset, GrfUtility.stringToByte(_version));
		mailDecrypt();
		offset = GrfUtility.setBuffer(b, offset, PlayUserData.saveData.unique);
		offset = GrfUtility.setBuffer(b, offset, _mailID);
		offset = GrfUtility.setBuffer(b, offset, _mailPass);
		WWWForm wWWForm = new WWWForm();
		string fieldName = "LOGIN";
		wWWForm.AddField(fieldName, Utility.abcEnc(GrfNetUtility.base64Encode(b)));
		SGLG.network.connectForm(url, targetScript, method, wWWForm);
	}

	public static void sendSetGameData(string url, GameObject targetScript, string method, int upflag)
	{
		byte[] b = new byte[24];
		int offset = 0;
		offset = GrfUtility.setBuffer(b, offset, GrfUtility.stringToByte(_appCode));
		offset = GrfUtility.setBuffer(b, offset, GrfUtility.stringToByte("a"));
		offset = GrfUtility.setBuffer(b, offset, GrfUtility.stringToByte(_version));
		offset = GrfUtility.setBuffer(b, offset, GrfUtility.stringToByte(PlayUserData.saveData.getUnique()));
		offset = GrfUtility.setBuffer(b, offset, UserData.saveData.game.motiMedals, true);
		byte b2 = 0;
		if (upflag == 1)
		{
			b2 |= 1;
		}
		if (PlayUserData.saveData.m_kouryakuFlag == 1)
		{
			b2 |= 2;
		}
		offset = GrfUtility.setBuffer(b, offset, b2);
		WWWForm wWWForm = new WWWForm();
		string fieldName = "SET_GAME_DATA";
		wWWForm.AddField(fieldName, Utility.abcEnc(GrfNetUtility.base64Encode(b)));
		SGLG.network.connectForm(url, targetScript, method, wWWForm);
	}

	public static void sendSendPoint(string url, GameObject targetScript, string method)
	{
		byte[] array = new byte[155];
		int offset = 0;
		offset = GrfUtility.setBuffer(array, offset, GrfUtility.stringToByte(_appCode));
		offset = GrfUtility.setBuffer(array, offset, GrfUtility.stringToByte("a"));
		offset = GrfUtility.setBuffer(array, offset, GrfUtility.stringToByte(_version));
		mailDecrypt();
		offset = GrfUtility.setBuffer(array, offset, PlayUserData.saveData.unique);
		offset = GrfUtility.setBuffer(array, offset, _mailID);
		offset = GrfUtility.setBuffer(array, offset, _mailPass);
		offset = GrfUtility.setBuffer(array, offset, PlayUserData.saveData.transactionID, true);
		offset = GrfUtility.setBuffer(array, offset, UserData.saveData.game.motiMedals, true);
		WWWForm wWWForm = new WWWForm();
		string fieldName = "SEND_POINT";
		wWWForm.AddField(fieldName, formatEncode(array, _keyMochidama));
		SGLG.network.connectForm(url, targetScript, method, wWWForm);
	}

	public static void sendCommitPoint(string url, GameObject targetScript, string method)
	{
		byte[] array = new byte[23];
		int offset = 0;
		offset = GrfUtility.setBuffer(array, offset, GrfUtility.stringToByte(_appCode));
		offset = GrfUtility.setBuffer(array, offset, GrfUtility.stringToByte("a"));
		offset = GrfUtility.setBuffer(array, offset, GrfUtility.stringToByte(_version));
		offset = GrfUtility.setBuffer(array, offset, PlayUserData.saveData.unique);
		offset = GrfUtility.setBuffer(array, offset, PlayUserData.saveData.transactionID, true);
		WWWForm wWWForm = new WWWForm();
		string fieldName = "COMMIT_POINT";
		wWWForm.AddField(fieldName, formatEncode(array, _keyCommit));
		SGLG.network.connectForm(url, targetScript, method, wWWForm);
	}

	private static void byteArrayToGameData(byte[] b, int offset, bool update)
	{
		byte[] array = new byte[8];
		byte b2 = 0;
		byte[] array2 = new byte[2];
		byte[] array3 = new byte[8];
		int num = 0;
		byte b3 = 0;
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = b[offset++];
		}
		b2 = b[offset++];
		for (int j = 0; j < array2.Length; j++)
		{
			array2[j] = b[offset++];
		}
		for (int k = 0; k < array3.Length; k++)
		{
			array3[k] = b[offset++];
		}
		byte[] array4 = new byte[4];
		for (int l = 0; l < 4; l++)
		{
			array4[l] = b[offset + l];
		}
		Array.Reverse(array4);
		num = BitConverter.ToInt32(array4, 0);
		offset += 4;
		b3 = b[offset++];
		if ((byte)(b3 & 1) == 1)
		{
			UserData.saveData.game.motiMedals = num;
			PlayUserData.saveData.m_kouryakuFlag = (byte)((b3 & 2) >> 1);
		}
		PlayUserData.saveData.m_kyouseiFlag = (byte)(b3 & 1);
		UserData.save();
		PlayUserData.save();
	}

	public static bool parseGetUniqueID(byte[] buf)
	{
		string text = GrfUtility.byteToString(buf);
		string text2 = "UNIQUE_ID=";
		bool result = false;
		if (text.StartsWith(text2))
		{
			string text3 = text.Substring(text2.Length);
			if (text3.Length != 8)
			{
				return result;
			}
			byte[] array = GrfUtility.stringToByte(text3);
			for (int i = 0; i < 8; i++)
			{
				PlayUserData.saveData.unique[i] = array[i];
			}
			PlayUserData.save();
			result = true;
		}
		return result;
	}

	public static bool parseLogin(byte[] buf)
	{
		string text = GrfUtility.byteToString(buf);
		string text2 = "RESPONSE=";
		bool result = false;
		if (text.StartsWith(text2))
		{
			string str = text.Substring(text2.Length);
			if (isOK(str))
			{
				result = true;
			}
		}
		return result;
	}

	public static bool parseSetGameData(byte[] buf, bool update)
	{
		string text = GrfUtility.byteToString(buf);
		string text2 = "GAME_DATA=";
		bool result = false;
		if (text.StartsWith(text2))
		{
			string str = text.Substring(text2.Length);
			byte[] array = GrfUtility.stringToByte(str);
			if (array == null)
			{
				return false;
			}
			Debug.Log(" str : " + text);
			byteArrayToGameData(GrfNetUtility.base64Decode(Utility.abcDec(GrfUtility.byteToString(array))), 0, update);
			result = true;
		}
		return result;
	}

	public static bool parsePoint(byte[] buf)
	{
		string text = GrfUtility.byteToString(buf);
		string text2 = "RESPONSE=";
		bool result = false;
		if (text.StartsWith(text2))
		{
			string str = text.Substring(text2.Length);
			if (isOK(str))
			{
				result = true;
			}
		}
		return result;
	}

	public static bool parseCommit(byte[] buf)
	{
		string text = GrfUtility.byteToString(buf);
		string text2 = "RESPONSE=";
		bool result = false;
		if (text.StartsWith(text2))
		{
			string str = text.Substring(text2.Length);
			if (isOK(str))
			{
				result = true;
			}
		}
		return result;
	}

	private static string formatEncode(byte[] buf, byte[] key)
	{
		GrfCryptography.cipherMode = CipherMode.ECB;
		byte[] b = GrfCryptography.encrypt(buf, key);
		string str = GrfNetUtility.base64Encode(b);
		return Utility.abcEnc(str);
	}

	private static byte[] formatDecode(byte[] buf, byte[] key)
	{
		GrfCryptography.cipherMode = CipherMode.ECB;
		string str = Utility.abcDec(GrfUtility.byteToString(buf));
		byte[] source = GrfNetUtility.base64Decode(str);
		return GrfCryptography.decrypt(source, key);
	}

	private static bool isOK(string str)
	{
		return str.StartsWith("OK") ? true : false;
	}

	public static string redirectURL(string str)
	{
		string text = "REDIRECT=";
		if (str.StartsWith(text))
		{
			return str.Substring(text.Length);
		}
		return string.Empty;
	}

	private static void mailDecrypt()
	{
		string id;
		string pass;
		Utility.mailDecrypt(out id, out pass, false);
		byte[] array = GrfUtility.stringToByte(id);
		byte[] array2 = GrfUtility.stringToByte(pass);
		if (array.Length == 0)
		{
			for (int i = 0; i < _mailID.Length; i++)
			{
				_mailID[i] = 0;
			}
		}
		else
		{
			for (int j = 0; j < _mailID.Length; j++)
			{
				_mailID[j] = array[j];
			}
		}
		if (array2.Length == 0)
		{
			for (int k = 0; k < _mailPass.Length; k++)
			{
				_mailPass[k] = 0;
			}
		}
		else
		{
			for (int l = 0; l < _mailPass.Length; l++)
			{
				_mailPass[l] = array2[l];
			}
		}
	}
}
