public class LEDPanelLine_PanelRight : LEDPanelLine
{
	private static readonly short[] table = new short[18]
	{
		81, 82, 83, 84, 85, 86, 87, 88, 89, 90,
		91, 92, 93, 94, 95, 96, 97, 98
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
