public class LEDPanelLine_PushAround : LEDPanelLine
{
	private static readonly short[] table = new short[30]
	{
		108, 109, 110, 111, 112, 113, 114, 115, 116, 117,
		118, 119, 120, 121, 122, 123, 124, 125, 126, 127,
		128, 129, 130, 131, 132, 133, 134, 135, 136, 137
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
