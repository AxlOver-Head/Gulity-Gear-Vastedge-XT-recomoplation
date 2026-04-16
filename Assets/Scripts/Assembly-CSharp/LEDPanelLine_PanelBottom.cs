public class LEDPanelLine_PanelBottom : LEDPanelLine
{
	private static readonly short[] table = new short[21]
	{
		66, 67, 68, 69, 70, 71, 72, 73, 74, 75,
		76, 77, 78, 79, 80, 99, 100, 101, 102, 103,
		104
	};

	protected override LEDPanelPat[] load(string path)
	{
		return load(path, table.Length);
	}

	public override void blendRewrite(byte[] dest)
	{
		for (int i = 0; i < table.Length; i++)
		{
			dest[table[i]] = m_Pattern[m_Current].m_ExecData[i];
		}
	}
}
