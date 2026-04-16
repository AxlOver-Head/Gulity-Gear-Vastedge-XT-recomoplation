using System;
using System.IO;
using System.Security.Cryptography;

public class GrfCryptography
{
	public static CipherMode cipherMode = CipherMode.CBC;

	public static PaddingMode paddingMode = PaddingMode.PKCS7;

	private static byte[] _iv = new byte[16];

	public static byte[] generateKey()
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.GenerateKey();
		return rijndaelManaged.Key;
	}

	public static byte[] generateIV()
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.GenerateIV();
		return rijndaelManaged.IV;
	}

	public static byte[] encrypt(byte[] source, byte[] key, byte[] iv = null)
	{
		try
		{
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.Mode = cipherMode;
			rijndaelManaged.Padding = paddingMode;
			byte[] result;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(key, (iv != null) ? iv : _iv), CryptoStreamMode.Write))
				{
					cryptoStream.Write(source, 0, source.Length);
					cryptoStream.FlushFinalBlock();
					result = memoryStream.ToArray();
				}
			}
			return result;
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static byte[] decrypt(byte[] source, byte[] key, byte[] iv = null)
	{
		try
		{
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.Mode = cipherMode;
			rijndaelManaged.Padding = paddingMode;
			byte[] result;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(key, (iv != null) ? iv : _iv), CryptoStreamMode.Write))
				{
					cryptoStream.Write(source, 0, source.Length);
					cryptoStream.FlushFinalBlock();
					result = memoryStream.ToArray();
				}
			}
			return result;
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static void setNoIV()
	{
		cipherMode = CipherMode.ECB;
	}

	public static void setDefault()
	{
		cipherMode = CipherMode.CBC;
		paddingMode = PaddingMode.PKCS7;
	}
}
