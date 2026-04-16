public class LEDPanelLine_PanelTop : LEDPanelLine
{
	private static readonly short[] table = new short[3] { 9, 10, 11 };

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
