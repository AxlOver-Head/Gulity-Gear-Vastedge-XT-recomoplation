using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using UnityEngine;

public class GGLFileRef
{
	public struct Extension
	{
		public FieldInfo f;

		public Type t;

		public object obj;

		public int mode;

		public bool ret;
	}

	private const int MODE_read = 0;

	private const int MODE_size = 1;

	private const int MODE_buffer = 2;

	private BinaryReader m_reader;

	private BinaryWriter m_writer;

	private int m_classSize;

	private ArrayList m_arrayList = new ArrayList();

	private ArrayList m_objList = new ArrayList();

	private byte[] m_buffer;

	private int m_bufferIdx;

	private Type[][] m_type;

	private FieldInfo[][] m_field;

	private object[] m_object;

	private string m_filename;

	private GameObject _delegateObj;

	private string _methodName;

	public Extension extension;

	public void bufferClear()
	{
		m_buffer = null;
		m_bufferIdx = 0;
		if (m_type != null)
		{
			for (int i = 0; i < m_type.Length; i++)
			{
				for (int j = 0; j < m_type[i].Length; j++)
				{
					m_type[i][j] = null;
				}
			}
			m_type = null;
		}
		if (m_field != null)
		{
			for (int k = 0; k < m_field.Length; k++)
			{
				for (int l = 0; l < m_field[k].Length; l++)
				{
					m_field[k][l] = null;
				}
			}
			m_field = null;
		}
		if (m_object != null)
		{
			for (int m = 0; m < m_object.Length; m++)
			{
				m_object[m] = null;
			}
			m_object = null;
		}
		extension.ret = false;
	}

	public void classAnalyzer(string filename, object obj)
	{
		m_filename = filename;
		bufferClear();
		m_classSize = 0;
		m_arrayList.Clear();
		m_objList.Clear();
		ArrayList arrayList = new ArrayList();
		arrayList.Clear();
		fields(arrayList, obj);
		arrayList.Sort();
		m_arrayList.Add(arrayList);
		m_objList.Add(obj);
		classSize(arrayList, obj);
		m_buffer = new byte[m_classSize];
		int num = ((m_arrayList.Count != m_objList.Count) ? (-1) : m_arrayList.Count);
		if (num == -1)
		{
			return;
		}
		m_type = new Type[num][];
		m_field = new FieldInfo[num][];
		m_object = new object[num];
		for (int i = 0; i < num; i++)
		{
			ArrayList arrayList2 = (ArrayList)m_arrayList[i];
			m_object[i] = m_objList[i];
			m_type[i] = new Type[arrayList2.Count];
			m_field[i] = new FieldInfo[arrayList2.Count];
			for (int j = 0; j < arrayList2.Count; j++)
			{
				m_field[i][j] = m_object[i].GetType().GetField((string)arrayList2[j]);
				m_type[i][j] = m_field[i][j].GetValue(m_object[i]).GetType();
			}
		}
	}

	public bool load()
	{
		closeWriter();
		uint num = 0u;
		if (m_classSize <= 0)
		{
			return false;
		}
		try
		{
			FileStream fileStream = new FileStream(m_filename, FileMode.Open, FileAccess.Read);
			m_reader = new BinaryReader(fileStream);
			num = m_reader.ReadUInt32();
			list(m_arrayList, 0);
			fileStream.Close();
		}
		catch (Exception)
		{
			delete(m_filename);
			return false;
		}
		if (m_classSize != getFileSize(m_filename) - 4)
		{
			return false;
		}
		byte[] array = new byte[m_classSize];
		try
		{
			FileStream fileStream2 = new FileStream(m_filename, FileMode.Open, FileAccess.Read);
			BinaryReader binaryReader = new BinaryReader(fileStream2);
			binaryReader.ReadUInt32();
			binaryReader.Read(array, 0, array.Length);
			fileStream2.Close();
			if (num != getCRC16(array))
			{
				delete(m_filename);
				array = null;
				return false;
			}
		}
		catch (Exception)
		{
			delete(m_filename);
			array = null;
			return false;
		}
		return true;
	}

	public bool save()
	{
		if (!saveAnalyzer())
		{
			return false;
		}
		if (!saveWrite())
		{
			return false;
		}
		return true;
	}

	public bool saveAnalyzer()
	{
		if (m_classSize <= 0)
		{
			return false;
		}
		m_bufferIdx = 0;
		for (int i = 0; i < m_field.Length; i++)
		{
			for (int j = 0; j < m_field[i].Length; j++)
			{
				analyzer(m_field[i][j], m_type[i][j], m_object[i], 2);
			}
		}
		return true;
	}

	public bool saveWrite()
	{
		if (m_classSize <= 0)
		{
			return false;
		}
		try
		{
			FileStream fileStream = new FileStream(m_filename, FileMode.Create, FileAccess.Write);
			m_writer = new BinaryWriter(fileStream);
			m_writer.Write(getCRC16(m_buffer));
			m_writer.Write(m_buffer, 0, m_buffer.Length);
			fileStream.Close();
		}
		catch (Exception)
		{
			return false;
		}
		return true;
	}

	public void closeWriter()
	{
	}

	public int getClassSize()
	{
		return m_classSize;
	}

	public long getFileSize(string filename)
	{
		try
		{
			FileInfo fileInfo = new FileInfo(filename);
			return fileInfo.Length;
		}
		catch (Exception)
		{
			return 0L;
		}
	}

	public uint getCRC16(byte[] bytes)
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

	public bool chcekCRC16(string filename, int crc16)
	{
		byte[] array = read(filename);
		if (array != null)
		{
			if (crc16 == getCRC16(array))
			{
				array = null;
				return true;
			}
			array = null;
		}
		return false;
	}

	public void delete(string filename)
	{
		try
		{
			FileInfo fileInfo = new FileInfo(filename);
			if (fileInfo.Exists)
			{
				if ((fileInfo.Attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
				{
					fileInfo.Attributes = FileAttributes.Normal;
				}
				fileInfo.Delete();
			}
		}
		catch (Exception)
		{
		}
	}

	private void classSize(ArrayList list, object obj)
	{
		foreach (string item in list)
		{
			FieldInfo field = obj.GetType().GetField(item);
			Type type = field.GetValue(obj).GetType();
			if (!analyzer(field, type, obj, 1))
			{
				ArrayList arrayList = new ArrayList();
				arrayList.Clear();
				fields(arrayList, field.GetValue(obj));
				arrayList.Sort();
				m_arrayList.Add(arrayList);
				m_objList.Add(field.GetValue(obj));
				classSize(arrayList, field.GetValue(obj));
			}
		}
	}

	private void list(ArrayList list, int mode)
	{
		int num = ((m_arrayList.Count != m_objList.Count) ? (-1) : m_arrayList.Count);
		if (num == -1)
		{
			return;
		}
		for (int i = 0; i < num; i++)
		{
			ArrayList arrayList = (ArrayList)m_arrayList[i];
			object obj = m_objList[i];
			for (int j = 0; j < arrayList.Count; j++)
			{
				FieldInfo field = obj.GetType().GetField((string)arrayList[j]);
				Type type = field.GetValue(obj).GetType();
				analyzer(field, type, obj, mode);
			}
		}
	}

	private void fields(ArrayList list, object obj)
	{
		FieldInfo[] array = obj.GetType().GetFields();
		FieldInfo[] array2 = array;
		foreach (FieldInfo fieldInfo in array2)
		{
			if (!isSkipField(fieldInfo))
			{
				list.Add(fieldInfo.Name);
			}
		}
	}

	private bool isSkipField(FieldInfo f)
	{
		if (f.IsLiteral)
		{
			return true;
		}
		if (f.IsPrivate)
		{
			return true;
		}
		return false;
	}

	private byte[] read(string filename)
	{
		try
		{
			int num = (int)getFileSize(filename);
			byte[] array = new byte[num];
			if (array == null)
			{
				return null;
			}
			FileStream fileStream = new FileStream(filename, FileMode.Open, FileAccess.Read);
			BinaryReader binaryReader = new BinaryReader(fileStream);
			binaryReader.Read(array, 0, array.Length);
			fileStream.Close();
			return array;
		}
		catch (Exception)
		{
			return null;
		}
	}

	private void setBuffer(byte[] b)
	{
		for (int i = 0; i < b.Length; i++)
		{
			m_buffer[m_bufferIdx++] = b[i];
		}
	}

	public bool analyzerEx(FieldInfo f, Type t, object obj, int mode)
	{
		if (isSkipField(f))
		{
			return true;
		}
		bool result = false;
		try
		{
			result = analyzer(f, t, obj, mode, false);
		}
		catch (Exception)
		{
		}
		return result;
	}

	private bool analyzer(FieldInfo f, Type t, object obj, int mode, bool recursion = true)
	{
		byte[] array = null;
		if (t == typeof(sbyte))
		{
			switch (mode)
			{
			case 0:
				f.SetValue(obj, m_reader.ReadSByte());
				break;
			case 1:
				m_classSize += Marshal.SizeOf(typeof(sbyte));
				break;
			case 2:
				m_buffer[m_bufferIdx++] = BitConverter.GetBytes((sbyte)f.GetValue(obj))[0];
				break;
			}
		}
		else if (t == typeof(short))
		{
			switch (mode)
			{
			case 0:
				f.SetValue(obj, m_reader.ReadInt16());
				break;
			case 1:
				m_classSize += Marshal.SizeOf(typeof(short));
				break;
			case 2:
				setBuffer(BitConverter.GetBytes((short)f.GetValue(obj)));
				break;
			}
		}
		else if (t == typeof(int))
		{
			switch (mode)
			{
			case 0:
				f.SetValue(obj, m_reader.ReadInt32());
				break;
			case 1:
				m_classSize += Marshal.SizeOf(typeof(int));
				break;
			case 2:
				setBuffer(BitConverter.GetBytes((int)f.GetValue(obj)));
				break;
			}
		}
		else if (t == typeof(bool))
		{
			switch (mode)
			{
			case 0:
				f.SetValue(obj, m_reader.ReadBoolean());
				break;
			case 1:
				m_classSize += Marshal.SizeOf(typeof(sbyte));
				break;
			case 2:
				setBuffer(BitConverter.GetBytes((bool)f.GetValue(obj)));
				break;
			}
		}
		else if (t == typeof(float))
		{
			switch (mode)
			{
			case 0:
				f.SetValue(obj, m_reader.ReadSingle());
				break;
			case 1:
				m_classSize += Marshal.SizeOf(typeof(float));
				break;
			case 2:
				setBuffer(BitConverter.GetBytes((float)f.GetValue(obj)));
				break;
			}
		}
		else if (t == typeof(double))
		{
			switch (mode)
			{
			case 0:
				f.SetValue(obj, m_reader.ReadDouble());
				break;
			case 1:
				m_classSize += Marshal.SizeOf(typeof(double));
				break;
			case 2:
				setBuffer(BitConverter.GetBytes((double)f.GetValue(obj)));
				break;
			}
		}
		else if (t == typeof(byte))
		{
			switch (mode)
			{
			case 0:
				f.SetValue(obj, m_reader.ReadByte());
				break;
			case 1:
				m_classSize += Marshal.SizeOf(typeof(byte));
				break;
			case 2:
				m_buffer[m_bufferIdx++] = BitConverter.GetBytes((byte)f.GetValue(obj))[0];
				break;
			}
		}
		else if (t == typeof(ushort))
		{
			switch (mode)
			{
			case 0:
				f.SetValue(obj, m_reader.ReadUInt16());
				break;
			case 1:
				m_classSize += Marshal.SizeOf(typeof(ushort));
				break;
			case 2:
				setBuffer(BitConverter.GetBytes((ushort)f.GetValue(obj)));
				break;
			}
		}
		else if (t == typeof(uint))
		{
			switch (mode)
			{
			case 0:
				f.SetValue(obj, m_reader.ReadUInt32());
				break;
			case 1:
				m_classSize += Marshal.SizeOf(typeof(uint));
				break;
			case 2:
				setBuffer(BitConverter.GetBytes((uint)f.GetValue(obj)));
				break;
			}
		}
		else if (t == typeof(byte[]))
		{
			byte[] array2 = (byte[])f.GetValue(obj);
			switch (mode)
			{
			case 0:
			{
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = m_reader.ReadByte();
				}
				break;
			}
			case 1:
				m_classSize += Marshal.SizeOf(typeof(byte)) * array2.Length;
				break;
			case 2:
			{
				for (int i = 0; i < array2.Length; i++)
				{
					m_buffer[m_bufferIdx++] = array2[i];
				}
				break;
			}
			}
		}
		else if (t == typeof(int[]))
		{
			int[] array3 = (int[])f.GetValue(obj);
			switch (mode)
			{
			case 0:
			{
				for (int m = 0; m < array3.Length; m++)
				{
					array3[m] = m_reader.ReadInt32();
				}
				break;
			}
			case 1:
				m_classSize += Marshal.SizeOf(typeof(int)) * array3.Length;
				break;
			case 2:
			{
				for (int k = 0; k < array3.Length; k++)
				{
					array = BitConverter.GetBytes(array3[k]);
					for (int l = 0; l < array.Length; l++)
					{
						m_buffer[m_bufferIdx++] = array[l];
					}
				}
				break;
			}
			}
		}
		else if (t == typeof(bool[]))
		{
			bool[] array4 = (bool[])f.GetValue(obj);
			switch (mode)
			{
			case 0:
			{
				for (int num2 = 0; num2 < array4.Length; num2++)
				{
					array4[num2] = m_reader.ReadBoolean();
				}
				break;
			}
			case 1:
				m_classSize += Marshal.SizeOf(typeof(bool)) * array4.Length;
				break;
			case 2:
			{
				for (int n = 0; n < array4.Length; n++)
				{
					array = BitConverter.GetBytes(array4[n]);
					for (int num = 0; num < array.Length; num++)
					{
						m_buffer[m_bufferIdx++] = array[num];
					}
				}
				break;
			}
			}
		}
		else
		{
			if (t != typeof(float[]))
			{
				if (recursion && _delegateObj != null && _methodName != null)
				{
					extension.ret = false;
					extension.f = f;
					extension.t = t;
					extension.obj = obj;
					extension.mode = mode;
					_delegateObj.SendMessage(_methodName);
					return extension.ret;
				}
				return false;
			}
			float[] array5 = (float[])f.GetValue(obj);
			switch (mode)
			{
			case 0:
			{
				for (int num5 = 0; num5 < array5.Length; num5++)
				{
					array5[num5] = m_reader.ReadSingle();
				}
				break;
			}
			case 1:
				m_classSize += Marshal.SizeOf(typeof(float)) * array5.Length;
				break;
			case 2:
			{
				for (int num3 = 0; num3 < array5.Length; num3++)
				{
					array = BitConverter.GetBytes(array5[num3]);
					for (int num4 = 0; num4 < array.Length; num4++)
					{
						m_buffer[m_bufferIdx++] = array[num4];
					}
				}
				break;
			}
			}
		}
		return true;
	}

	public void setExtensionMethod(GameObject delegateObj, string methodName)
	{
		_delegateObj = delegateObj;
		_methodName = methodName;
	}
}
