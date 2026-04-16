using System;
using System.IO;
using UnityEngine;

public class GGLFile
{
	public static bool loadFile(string filename, byte[] bytes)
	{
		bool flag = false;
		try
		{
			FileStream fileStream = new FileStream(filename, FileMode.Open, FileAccess.Read);
			BinaryReader binaryReader = new BinaryReader(fileStream);
			uint num = (uint)binaryReader.ReadInt32();
			byte b = (byte)(num & 0xFF);
			binaryReader.Read(bytes, 0, bytes.Length);
			for (int i = 0; i < bytes.Length; i++)
			{
				bytes[i] ^= b;
			}
			flag = ((num == getCRC16(bytes)) ? true : false);
			fileStream.Close();
			return flag;
		}
		catch (Exception)
		{
			return false;
		}
	}

	public static bool saveFile(string filename, byte[] bytes)
	{
		try
		{
			FileStream fileStream = new FileStream(filename, FileMode.Create, FileAccess.Write);
			BinaryWriter binaryWriter = new BinaryWriter(fileStream);
			uint cRC = getCRC16(bytes);
			byte[] array = new byte[bytes.Length];
			byte b = (byte)(cRC & 0xFF);
			for (int i = 0; i < bytes.Length; i++)
			{
				array[i] = bytes[i];
				array[i] ^= b;
			}
			binaryWriter.Write(cRC);
			binaryWriter.Write(array);
			fileStream.Close();
		}
		catch (Exception)
		{
			return false;
		}
		return true;
	}

	public static uint getCRC16(byte[] bytes)
	{
		uint num = 65535u;
		for (int i = 0; i < bytes.Length; i++)
		{
			num ^= bytes[i];
			for (int j = 0; j < 8; j++)
			{
				num = (((num & 1) == 0) ? (num >> 1) : ((num >> 1) ^ 0x8408));
			}
		}
		return num & 0xFFFF;
	}

	public static string filePath(string filename)
	{
		string text;
		if (Application.platform != RuntimePlatform.IPhonePlayer)
		{
			text = ((Application.platform != RuntimePlatform.Android) ? Application.dataPath.Substring(0, Application.dataPath.Length - 7) : Application.persistentDataPath);
		}
		else
		{
			text = Application.dataPath.Substring(0, Application.dataPath.Length - 5);
			text = text.Substring(0, text.LastIndexOf('/')) + "/Documents";
		}
		return text + "/" + filename;
	}
}
