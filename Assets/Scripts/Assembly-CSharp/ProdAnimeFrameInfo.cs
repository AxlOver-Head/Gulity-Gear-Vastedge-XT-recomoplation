public class ProdAnimeFrameInfo
{
	private static ProdAnimeFrameInfo[][][] table;

	public int m_NameLayer;

	public float m_X;

	public float m_Y;

	public float m_ScaleX;

	public float m_ScaleY;

	public float m_Rotate;

	public float m_Alpha;

	public byte m_Flip;

	public ProdAnimeFrameInfo(int layer, float alpha, float x, float y, float sx, float sy, int rot, byte flip)
	{
		m_NameLayer = layer;
		m_X = x;
		m_Y = y;
		m_ScaleX = sx;
		m_ScaleY = sy;
		m_Rotate = rot;
		m_Alpha = alpha;
		m_Flip = flip;
	}

	public static ProdAnimeFrameInfo[] getFrameInfo(int playID, int cnt)
	{
		return table[playID][cnt];
	}

	public static int getTotalFrame(int playID)
	{
		return table[playID].Length;
	}

	public static void init()
	{
		table = new ProdAnimeFrameInfo[MainResourceAnime.fileList.Length][][];
		for (int i = 0; i < table.Length; i++)
		{
			table[i] = new ProdAnimeFrameInfo[MainResourceAnime.animeFrames[i]][];
			for (int j = 0; j < table[i].Length; j++)
			{
				table[i][j] = new ProdAnimeFrameInfo[MainResourceAnime.spriteNum[i]];
			}
		}
		ProdAnimeFrameInfoSetter.setFrameInfo(table);
	}
}
