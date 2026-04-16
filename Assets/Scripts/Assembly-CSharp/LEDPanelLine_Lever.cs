public class LEDPanelLine_Lever : LEDPanelLine
{
	private static readonly short[] table = new short[3] { 0, 1, 2 };

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
