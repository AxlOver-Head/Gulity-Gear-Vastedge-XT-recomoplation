public class LEDPanelLine_PanelWindow : LEDPanelLine
{
	private static readonly short[] table = new short[54]
	{
		12, 13, 14, 15, 16, 17, 18, 19, 20, 21,
		22, 23, 24, 25, 26, 27, 28, 29, 30, 31,
		32, 33, 34, 35, 36, 37, 38, 39, 40, 41,
		42, 43, 44, 45, 46, 47, 48, 49, 50, 51,
		52, 53, 54, 55, 56, 57, 58, 59, 60, 61,
		62, 63, 64, 65
	};

	protected override LEDPanelPat[] load(string path)
	{
		return load(path, table.Length);
	}

	public override void blendRewrite(byte[] dest)
	{
		if (m_Pattern != null)
		{
			for (int i = 0; i < table.Length; i++)
			{
				dest[table[i]] = m_Pattern[m_Current].m_ExecData[i];
			}
		}
	}
}
