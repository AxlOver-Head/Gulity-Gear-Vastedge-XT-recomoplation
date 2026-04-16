using UnityEngine;

public class Rnd : MonoBehaviour
{
	public const int RAND_BUF_SIZE = 16;

	private static uint dwMakeRand;

	private static uint pRandBufRead_idx;

	private static uint pRandBufWrite_idx;

	private static uint[] dwRandBuf = new uint[16];

	private static uint ulRandWorkX;

	private static uint ulRandWorkY;

	private static uint ulRandWorkZ;

	private static uint ulRandWorkW;

	private static uint ulRandWorkT;

	private void Awake()
	{
		CommonInitRand();
	}

	private void Start()
	{
	}

	private void Update()
	{
		CommonMakeNewRand();
	}

	private void CommonInitRand()
	{
		pRandBufRead_idx = 0u;
		pRandBufWrite_idx = 0u;
		ulRandWorkX = 123456789u;
		ulRandWorkY = 362436069u;
		ulRandWorkZ = 521288629u;
		ulRandWorkW = 88675123u;
		ulRandWorkT = 0u;
	}

	private static void CommonMakeNewRand()
	{
		ulRandWorkT = ulRandWorkX ^ (ulRandWorkX << 11);
		ulRandWorkX = ulRandWorkY;
		ulRandWorkY = ulRandWorkZ;
		ulRandWorkZ = ulRandWorkW;
		ulRandWorkW = ulRandWorkW ^ (ulRandWorkW >> 19) ^ (ulRandWorkT ^ (ulRandWorkT >> 8));
	}

	public static uint CommonGetRand_16B()
	{
		uint result;
		if (pRandBufRead_idx != pRandBufWrite_idx)
		{
			result = dwRandBuf[pRandBufRead_idx];
			pRandBufRead_idx++;
			if (pRandBufRead_idx > 15)
			{
				pRandBufRead_idx = 0u;
			}
		}
		else
		{
			result = ulRandWorkW >> 16;
		}
		CommonMakeNewRand();
		return result;
	}

	public static ushort CommonGetRand_15B()
	{
		uint num = CommonGetRand_16B();
		num >>= 1;
		return (ushort)num;
	}
}
