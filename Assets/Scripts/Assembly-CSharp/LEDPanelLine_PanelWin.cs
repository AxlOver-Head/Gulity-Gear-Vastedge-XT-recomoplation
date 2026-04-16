public class LEDPanelLine_PanelWin : LEDPanelLine
{
	private static readonly short[] table = new short[6] { 3, 4, 5, 6, 7, 8 };

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
