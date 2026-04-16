using System.Collections.Generic;
using UnityEngine;

public class ProdAnimeSprite : MonoBehaviour
{
	public bool loop;

	public bool additiveMode;

	public int totalFrame = -1;

	public bool isActive;

	public bool isPrep;

	public bool isPause;

	public Vector3 posVec = Vector3.zero;

	public Vector3 sclVec = Vector3.zero;

	public int m_Cnt;

	public int m_PlayID = -1;

	public int m_ProdID = -1;

	public List<Transform> children_Trans = new List<Transform>
	{
		Capacity = 16
	};

	public List<UISprite> children_Sprite = new List<UISprite>
	{
		Capacity = 16
	};

	public List<Vector3> pixelSize = new List<Vector3>
	{
		Capacity = 16
	};

	private static string[] nameList1 = new string[5] { "a", "b", "c", "d", "e" };

	private static string[] nameList2 = new string[6] { "c1", "c2", "c3", "c9", "c1", "c4" };

	private static string[] KWS_CharaTbl = new string[18]
	{
		"mob", "sol", "sin", "kai", "izu", "par", "may", "jam", "gn4", "ano",
		"z13", "sly", "chi", "mil", "bri", "zap", "diz", "dyn"
	};

	private static string[][] KWSSpriteTable = new string[3][]
	{
		new string[255]
		{
			"SOL_01_01_002", "SOL_01_01_003", "SOL_01_01_004", "SOL_01_01_005", "SOL_01_01_006", "SOL_01_01_007", "SOL_01_01_008", "SOL_01_01_009", "SOL_01_01_010", "SOL_01_01_011",
			"SOL_01_01_012", "SOL_01_01_013", "SOL_01_01_014", "SOL_01_01_015", "SOL_01_01_016", "SOL_01_01_017", "SOL_01_01_018", "SOL_01_01_019", "SOL_01_01_020", "SOL_01_01_021",
			"SOL_01_01_022", "SOL_01_01_023", "SOL_01_01_024", "SOL_01_01_025", "SOL_01_01_026", "SOL_01_01_027", "SOL_01_01_028", "SOL_01_01_029", "SOL_01_01_030", "SOL_01_01_031",
			"SOL_01_02_032", "SOL_01_02_033", "SOL_01_02_034", "SOL_01_02_035", "SOL_01_02_036", "SOL_01_02_037", "SOL_01_03_038", "SOL_01_03_039", "SOL_01_04_040", "SOL_01_04_041",
			"SIN_01_01_054", "SIN_01_01_055", "SIN_01_01_056", "SIN_01_01_057", "SIN_01_01_058", "SIN_01_01_059", "SIN_01_01_060", "SIN_01_01_061", "SIN_01_01_062", "SIN_01_01_063",
			"SIN_01_01_064", "SIN_01_01_065", "SIN_01_01_066", "SIN_01_01_067", "SIN_01_01_068", "SIN_01_01_069", "SIN_01_01_070", "SIN_01_01_071", "SIN_01_01_072", "SIN_01_01_073",
			"SIN_01_01_074", "SIN_01_01_075", "SIN_01_01_076", "SIN_01_01_077", "SIN_01_01_078", "SIN_01_01_079", "SIN_01_01_080", "SIN_01_01_081", "SIN_01_01_082", "SIN_01_01_083",
			"SIN_01_02_084", "SIN_01_02_085", "SIN_01_02_086", "SIN_01_02_087", "SIN_01_02_088", "SIN_01_03_089", "SIN_01_03_090", "SIN_01_03_091", "SIN_01_04_092", "SIN_01_04_093",
			"KY_01_01_106", "KY_01_01_107", "KY_01_01_108", "KY_01_01_109", "KY_01_01_110", "KY_01_01_111", "KY_01_01_112", "KY_01_01_113", "KY_01_01_114", "KY_01_01_115",
			"KY_01_01_116", "KY_01_01_117", "KY_01_01_118", "KY_01_02_119", "KY_01_02_120", "KY_01_02_121", "KY_01_03_122", "KY_01_03_123", "KY_01_04_124", "KY_01_04_125",
			"IZU_01_01_132", "IZU_01_01_133", "IZU_01_01_134", "IZU_01_01_135", "IZU_01_01_136", "IZU_01_01_137", "IZU_01_01_138", "IZU_01_01_139", "IZU_01_01_140", "IZU_01_01_141",
			"IZU_01_01_142", "IZU_01_01_143", "IZU_01_01_144", "IZU_01_01_145", "IZU_01_01_146", "IZU_01_01_147", "IZU_01_01_148", "IZU_01_01_149", "IZU_01_01_150", "IZU_01_01_151",
			"IZU_01_02_152", "IZU_01_02_153", "IZU_01_02_154", "IZU_01_02_155", "IZU_01_02_156", "IZU_01_03_157", "IZU_01_03_158", "IZU_01_03_159", "IZU_01_04_160", "IZU_01_04_161",
			"DRP_01_01_171", "DRP_01_01_172", "DRP_01_01_173", "DRP_01_01_174", "DRP_01_01_175", "DRP_01_01_176", "DRP_01_01_177", "DRP_01_01_178", "DRP_01_01_179", "DRP_01_01_180",
			"DRP_01_01_181", "DRP_01_01_182", "DRP_01_01_183", "DRP_01_01_184", "DRP_01_01_185", "DRP_01_01_186", "DRP_01_01_187", "DRP_01_01_188", "DRP_01_01_189", "DRP_01_01_190",
			"DRP_01_02_191", "DRP_01_02_192", "DRP_01_02_193", "DRP_01_02_194", "DRP_01_02_195", "DRP_01_03_196", "DRP_01_03_197", "DRP_01_03_198", "DRP_01_04_199", "DRP_01_04_200",
			"MAY_01_01_210", "MAY_01_01_211", "MAY_01_01_212", "MAY_01_01_213", "MAY_01_01_214", "MAY_01_01_215", "MAY_01_01_216", "MAY_01_01_217", "MAY_01_01_218", "MAY_01_01_219",
			"MAY_01_01_220", "MAY_01_01_221", "MAY_01_01_222", "MAY_01_02_223", "MAY_01_02_224", "MAY_01_02_225", "MAY_01_03_226", "MAY_01_03_227", "MAY_01_04_228", "MAY_01_04_229",
			"JAM_01_01_236", "JAM_01_01_237", "JAM_01_01_238", "JAM_01_01_239", "JAM_01_01_240", "JAM_01_01_241", "JAM_01_01_242", "JAM_01_01_243", "JAM_01_01_244", "JAM_01_01_245",
			"JAM_01_01_246", "JAM_01_01_247", "JAM_01_01_248", "JAM_01_02_249", "JAM_01_02_250", "JAM_01_02_251", "JAM_01_03_252", "JAM_01_03_253", "JAM_01_04_254", "JAM_01_04_255",
			"CHR_01_01_262", "CHR_01_01_263", "CHR_01_01_264", "CHR_01_01_265", "CHR_01_01_266", "CHR_01_01_267", "CHR_01_01_268", "CHR_01_01_269", "CHR_01_01_270", "CHR_01_01_271",
			"CHR_01_01_272", "CHR_01_01_273", "CHR_01_01_274", "CHR_01_02_275", "CHR_01_02_276", "CHR_01_02_277", "CHR_01_03_278", "CHR_01_03_279", "CHR_01_04_280", "CHR_01_04_281",
			"BAR_01_03_288", "BAR_01_03_289", "BAR_01_03_290", "BAR_01_03_291", "BAR_01_04_294", "BAR_01_04_293", "BAR_01_04_296", "BAR_01_04_297", "BAR_01_04_295", "BAR_01_03_292",
			"MAN_01_03_314", "MAN_01_03_315", "MAN_01_03_316", "MAN_01_03_317", "MAN_01_03_318", "MAN_01_04_319", "MAN_01_04_320", "MAN_01_04_321", "MAN_01_04_322", "MAN_01_04_323",
			"SLA_01_01_340", "SLA_01_01_341", "SLA_01_01_342", "SLA_01_01_343", "SLA_01_01_344", "SLA_01_01_345", "SLA_01_01_346", "SLA_01_01_347", "SLA_01_01_348", "SLA_01_01_349",
			"SLA_01_01_350", "SLA_01_01_351", "SLA_01_01_352", "SLA_01_02_353", "SLA_01_02_354"
		},
		new string[256]
		{
			"SLA_01_02_355", "SLA_01_03_356", "SLA_01_03_357", "SLA_01_04_358", "SLA_01_04_359", "CHI_01_01_366", "CHI_01_01_367", "CHI_01_01_368", "CHI_01_01_369", "CHI_01_01_370",
			"CHI_01_01_371", "CHI_01_01_372", "CHI_01_01_373", "CHI_01_01_374", "CHI_01_01_375", "CHI_01_01_376", "CHI_01_01_377", "CHI_01_01_378", "CHI_01_02_379", "CHI_01_02_380",
			"CHI_01_02_381", "CHI_01_03_382", "CHI_01_03_383", "CHI_01_04_384", "CHI_01_04_385", "MIL_01_01_392", "MIL_01_01_393", "MIL_01_01_394", "MIL_01_01_395", "MIL_01_01_396",
			"MIL_01_01_397", "MIL_01_01_398", "MIL_01_01_399", "MIL_01_01_400", "MIL_01_01_401", "MIL_01_01_402", "MIL_01_01_403", "MIL_01_01_404", "MIL_01_02_405", "MIL_01_02_406",
			"MIL_01_02_407", "MIL_01_03_408", "MIL_01_03_409", "MIL_01_04_410", "MIL_01_04_411", "BRI_01_01_418", "BRI_01_01_419", "BRI_01_01_420", "BRI_01_01_421", "BRI_01_01_422",
			"BRI_01_01_423", "BRI_01_01_424", "BRI_01_01_425", "BRI_01_01_426", "BRI_01_01_427", "BRI_01_01_428", "BRI_01_01_429", "BRI_01_01_430", "BRI_01_02_431", "BRI_01_02_432",
			"BRI_01_02_433", "BRI_01_03_434", "BRI_01_03_435", "BRI_01_04_436", "BRI_01_04_437", "ZAP_01_01_444", "ZAP_01_01_445", "ZAP_01_01_446", "ZAP_01_01_447", "ZAP_01_01_448",
			"ZAP_01_01_449", "ZAP_01_01_450", "ZAP_01_01_451", "ZAP_01_01_452", "ZAP_01_01_453", "ZAP_01_01_454", "ZAP_01_01_455", "ZAP_01_01_456", "ZAP_01_02_457", "ZAP_01_02_458",
			"ZAP_01_02_459", "ZAP_01_03_460", "ZAP_01_03_461", "ZAP_01_04_462", "ZAP_01_04_463", "DIZ_01_03_470", "DIZ_01_03_471", "DIZ_01_03_472", "DIZ_01_03_473", "DIZ_01_03_474",
			"DIZ_01_04_475", "DIZ_01_04_476", "DIZ_01_04_477", "DIZ_01_04_478", "DIZ_01_04_479", "SOL_01_01_500", "SOL_01_01_504", "SOL_01_01_508", "SOL_01_01_512", "SOL_01_01_533",
			"SOL_01_01_537", "SOL_01_01_541", "SOL_01_01_545", "SOL_01_01_566", "SOL_01_01_570", "SOL_01_01_574", "SOL_01_01_578", "SOL_01_01_599", "SOL_01_01_603", "SOL_01_01_607",
			"SOL_01_01_611", "SOL_01_01_632", "SOL_01_01_636", "SOL_01_01_640", "SOL_01_01_644", "SOL_01_01_681", "SOL_01_01_685", "SOL_01_01_689", "SOL_01_01_693", "SOL_01_01_697",
			"SOL_01_01_701", "SOL_01_01_705", "SOL_01_01_709", "SIN_01_01_501", "SIN_01_01_505", "SIN_01_01_509", "SIN_01_01_513", "SIN_01_01_534", "SIN_01_01_538", "SIN_01_01_542",
			"SIN_01_01_546", "SIN_01_01_567", "SIN_01_01_571", "SIN_01_01_575", "SIN_01_01_579", "SIN_01_01_600", "SIN_01_01_604", "SIN_01_01_608", "SIN_01_01_612", "SIN_01_01_633",
			"SIN_01_01_637", "SIN_01_01_641", "SIN_01_01_645", "SIN_01_01_682", "SIN_01_01_686", "SIN_01_01_690", "SIN_01_01_694", "SIN_01_01_698", "SIN_01_01_702", "SIN_01_01_706",
			"SIN_01_01_710", "SIN_01_01_502", "SIN_01_01_506", "SIN_01_01_510", "SIN_01_01_514", "SIN_01_01_535", "SIN_01_01_539", "SIN_01_01_543", "SIN_01_01_547", "SIN_01_01_568",
			"SIN_01_01_572", "SIN_01_01_576", "SIN_01_01_580", "SIN_01_01_601", "SIN_01_01_605", "SIN_01_01_609", "SIN_01_01_613", "SIN_01_01_634", "SIN_01_01_638", "SIN_01_01_642",
			"SIN_01_01_646", "SIN_01_01_683", "SIN_01_01_687", "SIN_01_01_691", "SIN_01_01_695", "SIN_01_01_699", "SIN_01_01_703", "SIN_01_01_707", "SIN_01_01_711", "SIN_01_01_484",
			"SIN_01_01_488", "SIN_01_01_492", "SIN_01_01_496", "SIN_01_01_517", "SIN_01_01_521", "SIN_01_01_525", "SIN_01_01_529", "SIN_01_01_550", "SIN_01_01_554", "SIN_01_01_558",
			"SIN_01_01_562", "SIN_01_01_583", "SIN_01_01_587", "SIN_01_01_591", "SIN_01_01_595", "SIN_01_01_616", "SIN_01_01_620", "SIN_01_01_624", "SIN_01_01_628", "SIN_01_01_649",
			"SIN_01_01_653", "SIN_01_01_657", "SIN_01_01_661", "SIN_01_01_665", "SIN_01_01_669", "SIN_01_01_673", "SIN_01_01_677", "SOL_01_01_485", "SOL_01_01_489", "SOL_01_01_493",
			"SOL_01_01_497", "SOL_01_01_518", "SOL_01_01_522", "SOL_01_01_526", "SOL_01_01_530", "SOL_01_01_551", "SOL_01_01_555", "SOL_01_01_559", "SOL_01_01_563", "SOL_01_01_584",
			"SOL_01_01_588", "SOL_01_01_592", "SOL_01_01_596", "SOL_01_01_617", "SOL_01_01_621", "SOL_01_01_625", "SOL_01_01_629", "SOL_01_01_650", "SOL_01_01_654", "SOL_01_01_658",
			"SOL_01_01_662", "SOL_01_01_666", "SOL_01_01_670", "SOL_01_01_674", "SOL_01_01_678", "SOL_01_01_486", "SOL_01_01_490", "SOL_01_01_494", "SOL_01_01_498", "SOL_01_01_519",
			"SOL_01_01_523", "SOL_01_01_527", "SOL_01_01_531", "SOL_01_01_552", "SOL_01_01_556", "SOL_01_01_560", "SOL_01_01_564", "SOL_01_01_585", "SOL_01_01_589", "SOL_01_01_593",
			"SOL_01_01_597", "SOL_01_01_618", "SOL_01_01_622", "SOL_01_01_626", "SOL_01_01_630", "SOL_01_01_651"
		},
		new string[7] { "SOL_01_01_655", "SOL_01_01_659", "SOL_01_01_663", "SOL_01_01_667", "SOL_01_01_671", "SOL_01_01_675", "SOL_01_01_679" }
	};

	public void OnDestroy()
	{
		children_Trans.Clear();
		children_Trans = null;
		children_Sprite.Clear();
		children_Sprite = null;
		pixelSize.Clear();
		pixelSize = null;
	}

	public void SetFile(int playID, int prodID)
	{
		m_ProdID = prodID;
		base.gameObject.name = "anmSpr_" + m_ProdID;
		ProdAnimeFrameInfo[] frameInfo = ProdAnimeFrameInfo.getFrameInfo(playID, 0);
		if (frameInfo == null)
		{
			return;
		}
		totalFrame = ProdAnimeFrameInfo.getTotalFrame(playID);
		GameObject gameObject = null;
		for (int i = 0; i < frameInfo.Length; i++)
		{
			gameObject = null;
			gameObject = GameObject.Find(base.gameObject.name + "/" + findSpriteDirectory(playID, frameInfo[i].m_NameLayer) + frameInfo[i].m_NameLayer);
			if (gameObject == null)
			{
				break;
			}
			Transform component = gameObject.GetComponent<Transform>();
			UISprite component2 = gameObject.GetComponent<UISprite>();
			if (component == null)
			{
			}
			if (component2 == null)
			{
			}
			children_Trans.Add(component);
			children_Sprite.Add(component2);
			Vector3 item = new Vector3(component.localScale.x, component.localScale.y, component.localScale.z);
			pixelSize.Add(item);
		}
		m_PlayID = playID;
	}

	public void initFromOther(ProdAnimeSprite spr)
	{
		for (int i = 0; i < children_Sprite.Count; i++)
		{
			children_Sprite[i].spriteName = spr.children_Sprite[i].spriteName;
		}
	}

	public void Prepare()
	{
		isActive = false;
		isPrep = true;
		m_Cnt = 0;
	}

	public void Pause(bool _flag)
	{
		isPause = true;
	}

	public void updatePosition(float x, float y, float z)
	{
		posVec.x = x;
		posVec.y = 0f - y;
		posVec.z = -9f + z / 100f;
		base.gameObject.transform.localPosition = posVec;
	}

	public void updateScale(float x, float y)
	{
		sclVec.x = x;
		sclVec.y = y;
		sclVec.z = 1f;
		base.gameObject.transform.localScale = sclVec;
	}

	public void Play()
	{
		isActive = true;
		isPrep = false;
	}

	public void Stop()
	{
		isActive = false;
		isPrep = false;
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(false);
		}
	}

	public int getCurrentFrame()
	{
		return m_Cnt;
	}

	public bool isEnd()
	{
		if (loop)
		{
			return false;
		}
		return m_Cnt >= totalFrame - 1;
	}

	public void control()
	{
		if (!isActive)
		{
			return;
		}
		ProdAnimeFrameInfo[] frameInfo = ProdAnimeFrameInfo.getFrameInfo(m_PlayID, m_Cnt);
		if (frameInfo == null)
		{
			return;
		}
		for (int i = 0; i < frameInfo.Length; i++)
		{
			children_Trans[i].localPosition = new Vector3(frameInfo[i].m_X, 0f - frameInfo[i].m_Y, children_Trans[i].localPosition.z);
			float num = pixelSize[i].x * frameInfo[i].m_ScaleX;
			float num2 = pixelSize[i].y * frameInfo[i].m_ScaleY;
			byte flip = frameInfo[i].m_Flip;
			if ((byte)((flip >> 1) & 1) == 1)
			{
				num = 0f - num;
			}
			if ((byte)(flip & 1) == 1)
			{
				num2 = 0f - num2;
			}
			children_Trans[i].localScale = new Vector3(num, num2, 1f);
			children_Trans[i].localRotation = Quaternion.Euler(0f, 0f, frameInfo[i].m_Rotate);
			children_Sprite[i].alpha = frameInfo[i].m_Alpha;
		}
		m_Cnt++;
		if (m_Cnt >= totalFrame)
		{
			if (loop)
			{
				m_Cnt = 0;
			}
			else
			{
				m_Cnt--;
			}
		}
	}

	public void changePattern(int playID, int ptnID)
	{
		if (children_Sprite != null)
		{
			switch (playID)
			{
			case 40:
			case 41:
			case 42:
			case 43:
			case 44:
			case 45:
			case 46:
			case 47:
				changePattern_24ANV(playID, ptnID);
				break;
			case 0:
			case 1:
			case 2:
			case 3:
			case 4:
			case 5:
			case 6:
			case 7:
			case 8:
			case 9:
			case 10:
			case 11:
			case 12:
			case 13:
			case 14:
			case 15:
			case 16:
			case 17:
			case 18:
			case 19:
			case 20:
				changePattern_29HNV(playID, ptnID);
				break;
			case 25:
			case 26:
			case 27:
				changePattern_87YFC(playID, ptnID);
				break;
			case 28:
			case 29:
			case 30:
			case 31:
			case 32:
			case 33:
			case 34:
			case 35:
				changePattern_36DNV(playID, ptnID);
				break;
			case 49:
			case 50:
				changePattern_KWS(playID, ptnID);
				break;
			case 36:
			case 37:
			case 38:
			case 39:
				changePattern_KWD(playID, ptnID);
				break;
			case 21:
			case 22:
			case 23:
			case 24:
			case 48:
				break;
			}
		}
	}

	private bool checkSpriteName(int _id, string name)
	{
		return children_Sprite[_id].spriteName == name;
	}

	private void changeSpriteName(int _id, string name)
	{
		children_Sprite[_id].spriteName = name;
	}

	private void changePattern_87YFC(int playID, int ptnID)
	{
		if (ptnID == 1)
		{
			m_Cnt = totalFrame - 1;
		}
	}

	private void changePattern_24ANV(int playID, int ptnID)
	{
		for (int i = 0; i < children_Sprite.Count; i++)
		{
			if (checkSpriteName(i, "2401_c_flo_a01_c3_c2"))
			{
				changeSpriteName(i, "2401_c_flo_a01_c" + ptnID + "_c2");
			}
			else if (checkSpriteName(i, "2401_c_flo_a03_c3_c2"))
			{
				changeSpriteName(i, "2401_c_flo_a03_c" + ptnID + "_c2");
			}
			else if (checkSpriteName(i, "2401_c_flo_a06_c3_c2"))
			{
				changeSpriteName(i, "2401_c_flo_a06_c" + ptnID + "_c2");
			}
			else if (checkSpriteName(i, "2401_c_flo_a08_c3_c2"))
			{
				changeSpriteName(i, "2401_c_flo_a08_c" + ptnID + "_c2");
			}
			else if (checkSpriteName(i, "2401_c_flo_b01_c3_c2"))
			{
				changeSpriteName(i, "2401_c_flo_b01_c" + ptnID + "_c2");
			}
			else if (checkSpriteName(i, "2401_c_flo_b03_c3_c2"))
			{
				changeSpriteName(i, "2401_c_flo_b03_c" + ptnID + "_c2");
			}
			else if (checkSpriteName(i, "2401_c_flo_b06_c3_c2"))
			{
				changeSpriteName(i, "2401_c_flo_b06_c" + ptnID + "_c2");
			}
			else if (checkSpriteName(i, "2401_c_flo_b07_c3_c2"))
			{
				changeSpriteName(i, "2401_c_flo_b07_c" + ptnID + "_c2");
			}
			else if (checkSpriteName(i, "2401_c_flo_c01_c3_c2"))
			{
				changeSpriteName(i, "2401_c_flo_c01_c" + ptnID + "_c2");
			}
			else if (checkSpriteName(i, "2401_c_flo_c03_c3_c2"))
			{
				changeSpriteName(i, "2401_c_flo_c03_c" + ptnID + "_c2");
			}
			else if (checkSpriteName(i, "2401_c_flo_c06_c3_c2"))
			{
				changeSpriteName(i, "2401_c_flo_c06_c" + ptnID + "_c2");
			}
			else if (checkSpriteName(i, "2401_c_flo_c08_c3_c2"))
			{
				changeSpriteName(i, "2401_c_flo_c08_c" + ptnID + "_c2");
			}
		}
	}

	private void changePattern_29HNV(int playID, int ptnID)
	{
		int num = ptnID / 10;
		int num2 = ptnID % 10;
		for (int i = 0; i < children_Sprite.Count; i++)
		{
			if (checkSpriteName(i, "2900_o_l_a01_c3"))
			{
				changeSpriteName(i, "2900_o_l_" + nameList1[num2] + "01_" + nameList2[num]);
			}
			else if (checkSpriteName(i, "2900_o_l_a02_c3"))
			{
				changeSpriteName(i, "2900_o_l_" + nameList1[num2] + "02_" + nameList2[num]);
			}
			else if (checkSpriteName(i, "2900_o_l_a03_c3"))
			{
				changeSpriteName(i, "2900_o_l_" + nameList1[num2] + "03_" + nameList2[num]);
			}
			else if (checkSpriteName(i, "2900_o_u_a01_c3"))
			{
				changeSpriteName(i, "2900_o_u_a01_" + nameList2[num]);
			}
			else if (checkSpriteName(i, "2900_o_u_a02_c3"))
			{
				changeSpriteName(i, "2900_o_u_a02_" + nameList2[num]);
			}
			else if (checkSpriteName(i, "2900_o_u_a03_c3"))
			{
				changeSpriteName(i, "2900_o_u_a03_" + nameList2[num]);
			}
			else if (checkSpriteName(i, "2900_o_u_b01_c3"))
			{
				changeSpriteName(i, "2900_o_u_b01_" + nameList2[num]);
			}
			else if (checkSpriteName(i, "2900_o_u_b02_c3"))
			{
				changeSpriteName(i, "2900_o_u_b02_" + nameList2[num]);
			}
			else if (checkSpriteName(i, "2900_o_u_c01_c3"))
			{
				changeSpriteName(i, "2900_o_u_c01_" + nameList2[num]);
			}
			else if (checkSpriteName(i, "2900_o_u_c02_c3"))
			{
				changeSpriteName(i, "2900_o_u_c02_" + nameList2[num]);
			}
			else if (checkSpriteName(i, "2900_o_u_d01_c3"))
			{
				changeSpriteName(i, "2900_o_u_d01_" + nameList2[num]);
			}
			else if (checkSpriteName(i, "2900_o_u_d02_c3"))
			{
				changeSpriteName(i, "2900_o_u_d02_" + nameList2[num]);
			}
			else if (checkSpriteName(i, "2900_o_u_d03_c3"))
			{
				changeSpriteName(i, "2900_o_u_d03_" + nameList2[num]);
			}
			else if (checkSpriteName(i, "2900_o_u_d04_c3"))
			{
				changeSpriteName(i, "2900_o_u_d04_" + nameList2[num]);
			}
			else if (checkSpriteName(i, "2900_o_u_d05_c3"))
			{
				changeSpriteName(i, "2900_o_u_d05_" + nameList2[num]);
			}
			else if (checkSpriteName(i, "2900_o_u_d06_c3"))
			{
				changeSpriteName(i, "2900_o_u_d06_" + nameList2[num]);
			}
			else if (checkSpriteName(i, "2900_o_u_d07_c3"))
			{
				changeSpriteName(i, "2900_o_u_d07_" + nameList2[num]);
			}
			else if (checkSpriteName(i, "2901_o_l_a01_c3"))
			{
				changeSpriteName(i, "2901_o_l_" + nameList1[num2] + "01_" + nameList2[num]);
			}
			else if (checkSpriteName(i, "2901_o_l_a02_c3"))
			{
				changeSpriteName(i, "2901_o_l_" + nameList1[num2] + "02_" + nameList2[num]);
			}
			else if (checkSpriteName(i, "2901_o_l_a03_c3"))
			{
				changeSpriteName(i, "2901_o_l_" + nameList1[num2] + "03_" + nameList2[num]);
			}
			else if (checkSpriteName(i, "2901_o_u_a01_c3"))
			{
				changeSpriteName(i, "2901_o_u_a01_" + nameList2[num]);
			}
			else if (checkSpriteName(i, "2901_o_u_a02_c3"))
			{
				changeSpriteName(i, "2901_o_u_a02_" + nameList2[num]);
			}
			else if (checkSpriteName(i, "2901_o_u_a03_c3"))
			{
				changeSpriteName(i, "2901_o_u_a03_" + nameList2[num]);
			}
			else if (checkSpriteName(i, "2901_o_u_b01_c3"))
			{
				changeSpriteName(i, "2901_o_u_b01_" + nameList2[num]);
			}
			else if (checkSpriteName(i, "2901_o_u_b02_c3"))
			{
				changeSpriteName(i, "2901_o_u_b02_" + nameList2[num]);
			}
			else if (checkSpriteName(i, "2901_o_u_c01_c3"))
			{
				changeSpriteName(i, "2901_o_u_c01_" + nameList2[num]);
			}
			else if (checkSpriteName(i, "2901_o_u_c02_c3"))
			{
				changeSpriteName(i, "2901_o_u_c02_" + nameList2[num]);
			}
			else if (checkSpriteName(i, "2901_o_u_d01_c3"))
			{
				changeSpriteName(i, "2901_o_u_d01_" + nameList2[num]);
			}
			else if (checkSpriteName(i, "2901_o_u_d02_c3"))
			{
				changeSpriteName(i, "2901_o_u_d02_" + nameList2[num]);
			}
			else if (checkSpriteName(i, "2901_o_u_d03_c3"))
			{
				changeSpriteName(i, "2901_o_u_d03_" + nameList2[num]);
			}
			else if (checkSpriteName(i, "2901_o_u_d04_c3"))
			{
				changeSpriteName(i, "2901_o_u_d04_" + nameList2[num]);
			}
			else if (checkSpriteName(i, "2901_o_u_d05_c3"))
			{
				changeSpriteName(i, "2901_o_u_d05_" + nameList2[num]);
			}
			else if (checkSpriteName(i, "2901_o_u_d06_c3"))
			{
				changeSpriteName(i, "2901_o_u_d06_" + nameList2[num]);
			}
			else if (checkSpriteName(i, "2901_o_u_d07_c3"))
			{
				changeSpriteName(i, "2901_o_u_d07_" + nameList2[num]);
			}
		}
	}

	private void changePattern_36DNV(int playID, int ptnID)
	{
		int num = ptnID / 10;
		int num2 = ptnID % 10;
		for (int i = 0; i < children_Sprite.Count; i++)
		{
			if (checkSpriteName(i, "3600_o_l_a01"))
			{
				changeSpriteName(i, "3600_o_l_" + nameList1[num2] + "01");
			}
			else if (checkSpriteName(i, "3600_o_l_a02"))
			{
				changeSpriteName(i, "3600_o_l_" + nameList1[num2] + "02");
			}
			else if (checkSpriteName(i, "3600_o_l_a03"))
			{
				changeSpriteName(i, "3600_o_l_" + nameList1[num2] + "03");
			}
			else if (checkSpriteName(i, "3600_o_l_a04"))
			{
				changeSpriteName(i, "3600_o_l_" + nameList1[num2] + "04");
			}
			else if (checkSpriteName(i, "3600_o_l_a05"))
			{
				changeSpriteName(i, "3600_o_l_" + nameList1[num2] + "05");
			}
			else if (checkSpriteName(i, "3600_o_l_a06"))
			{
				changeSpriteName(i, "3600_o_l_" + nameList1[num2] + "06");
			}
			else if (checkSpriteName(i, "3600_o_l_a07"))
			{
				changeSpriteName(i, "3600_o_l_" + nameList1[num2] + "07");
			}
			else if (checkSpriteName(i, "3600_o_l_a08"))
			{
				changeSpriteName(i, "3600_o_l_" + nameList1[num2] + "08");
			}
			else if (checkSpriteName(i, "3600_o_l_a09"))
			{
				changeSpriteName(i, "3600_o_l_" + nameList1[num2] + "09");
			}
			else if (checkSpriteName(i, "3600_o_l_a10"))
			{
				changeSpriteName(i, "3600_o_l_" + nameList1[num2] + "10");
			}
			else if (checkSpriteName(i, "3600_o_l_a11"))
			{
				changeSpriteName(i, "3600_o_l_" + nameList1[num2] + "11");
			}
			else if (checkSpriteName(i, "3600_o_l_a12"))
			{
				changeSpriteName(i, "3600_o_l_" + nameList1[num2] + "12");
			}
			else if (checkSpriteName(i, "3600_o_l_a13"))
			{
				changeSpriteName(i, "3600_o_l_" + nameList1[num2] + "13");
			}
			else if (checkSpriteName(i, "3600_o_u_a01_c3"))
			{
				changeSpriteName(i, "3600_o_u_a01_" + nameList2[num]);
			}
			else if (checkSpriteName(i, "3600_o_u_a02_c3"))
			{
				changeSpriteName(i, "3600_o_u_a02_" + nameList2[num]);
			}
			else if (checkSpriteName(i, "3600_o_u_a03_c3"))
			{
				changeSpriteName(i, "3600_o_u_a03_" + nameList2[num]);
			}
			else if (checkSpriteName(i, "3600_o_u_b01_c3"))
			{
				changeSpriteName(i, "3600_o_u_b01_" + nameList2[num]);
			}
			else if (checkSpriteName(i, "3600_o_u_b02_c3"))
			{
				changeSpriteName(i, "3600_o_u_b02_" + nameList2[num]);
			}
			else if (checkSpriteName(i, "3600_o_u_c01_c3"))
			{
				changeSpriteName(i, "3600_o_u_c01_" + nameList2[num]);
			}
			else if (checkSpriteName(i, "3600_o_u_c02_c3"))
			{
				changeSpriteName(i, "3600_o_u_c02_" + nameList2[num]);
			}
			else if (checkSpriteName(i, "3600_o_u_c03_c3"))
			{
				changeSpriteName(i, "3600_o_u_c03_" + nameList2[num]);
			}
			else if (checkSpriteName(i, "3600_o_u_c04_c3"))
			{
				changeSpriteName(i, "3600_o_u_c04_" + nameList2[num]);
			}
			else if (checkSpriteName(i, "3600_o_u_c05_c3"))
			{
				changeSpriteName(i, "3600_o_u_c05_" + nameList2[num]);
			}
			else if (checkSpriteName(i, "3600_o_u_c06_c3"))
			{
				changeSpriteName(i, "3600_o_u_c06_" + nameList2[num]);
			}
		}
	}

	private void changePattern_KWS(int playID, int ptnID)
	{
		int num = ptnID % 100;
		int num2 = ptnID / 100 + 1;
		for (int i = 0; i < children_Sprite.Count; i++)
		{
			if (checkSpriteName(i, "4300_o_u_a00_c1"))
			{
				changeSpriteName(i, "4300_o_u_a00_c" + num2);
			}
			else if (checkSpriteName(i, "4300_o_u_b00_c1"))
			{
				changeSpriteName(i, "4300_o_u_b00_c" + num2);
			}
			else if (checkSpriteName(i, "4300_c_sol_A"))
			{
				changeSpriteName(i, "4300_c_" + KWS_CharaTbl[num] + "_A");
			}
			else if (checkSpriteName(i, "4300_c_sol_B"))
			{
				changeSpriteName(i, "4300_c_" + KWS_CharaTbl[num] + "_B");
			}
		}
	}

	private void changePattern_KWD(int playID, int ptnID)
	{
		int num = ptnID / 1000;
		int num2 = ptnID % 1000;
		if (num == 0)
		{
			num2--;
		}
		for (int i = 0; i < children_Sprite.Count; i++)
		{
			if (checkSpriteName(i, "SOL_01_01_002_A"))
			{
				changeSpriteName(i, KWSSpriteTable[num][num2] + "_A");
			}
			else if (checkSpriteName(i, "SOL_01_01_002_B"))
			{
				changeSpriteName(i, KWSSpriteTable[num][num2] + "_B");
			}
		}
	}

	private string findSpriteDirectory(int playID, int nameNum)
	{
		string result = string.Empty;
		switch (playID)
		{
		case 0:
			switch (nameNum)
			{
			case 21:
				result = "Panel00/";
				break;
			case 23:
			case 24:
			case 25:
				result = "Panel01/";
				break;
			case 27:
			case 28:
			case 29:
			case 30:
			case 31:
			case 32:
			case 33:
			case 34:
			case 36:
			case 37:
				result = "Panel02/";
				break;
			}
			break;
		case 1:
			switch (nameNum)
			{
			case 21:
				result = "Panel00/";
				break;
			case 23:
			case 27:
			case 28:
			case 29:
			case 30:
			case 36:
			case 37:
				result = "Panel01/";
				break;
			}
			break;
		case 2:
			switch (nameNum)
			{
			case 24:
			case 25:
				result = "Panel00/";
				break;
			case 26:
			case 27:
			case 29:
			case 30:
			case 31:
			case 32:
			case 33:
			case 34:
			case 35:
			case 36:
			case 37:
			case 38:
			case 39:
			case 40:
			case 41:
			case 43:
			case 44:
			case 46:
			case 47:
			case 48:
			case 49:
			case 50:
			case 51:
			case 52:
			case 53:
			case 54:
				result = "Panel01/";
				break;
			}
			break;
		case 3:
			switch (nameNum)
			{
			case 15:
			case 16:
			case 17:
				result = "Panel00/";
				break;
			case 18:
			case 19:
			case 20:
			case 21:
			case 22:
			case 23:
			case 24:
			case 25:
			case 26:
			case 27:
			case 28:
			case 29:
			case 30:
			case 31:
			case 32:
				result = "Panel01/";
				break;
			}
			break;
		case 4:
			switch (nameNum)
			{
			case 21:
			case 22:
			case 23:
				result = "Panel00/";
				break;
			case 25:
			case 26:
			case 27:
			case 28:
			case 30:
			case 31:
				result = "Panel01/";
				break;
			}
			break;
		case 5:
			switch (nameNum)
			{
			case 21:
				result = "Panel00/";
				break;
			case 22:
			case 23:
			case 24:
			case 25:
				result = "Panel01/";
				break;
			case 27:
			case 28:
			case 29:
			case 30:
			case 31:
			case 32:
			case 33:
			case 34:
			case 36:
			case 37:
				result = "Panel02/";
				break;
			}
			break;
		case 13:
			switch (nameNum)
			{
			case 14:
				result = "Panel00/";
				break;
			case 15:
			case 16:
			case 17:
			case 18:
			case 19:
			case 20:
			case 21:
				result = "Panel01/";
				break;
			case 23:
			case 24:
			case 25:
				result = "Panel02/";
				break;
			case 27:
			case 28:
			case 29:
			case 30:
			case 31:
			case 32:
			case 33:
			case 34:
			case 36:
			case 37:
				result = "Panel03/";
				break;
			}
			break;
		case 14:
			switch (nameNum)
			{
			case 21:
				result = "Panel00/";
				break;
			case 23:
			case 27:
			case 28:
			case 29:
			case 30:
			case 36:
			case 37:
				result = "Panel01/";
				break;
			}
			break;
		case 15:
			switch (nameNum)
			{
			case 24:
			case 25:
			case 26:
			case 27:
			case 28:
			case 29:
			case 31:
			case 32:
				result = "Panel00/";
				break;
			case 33:
			case 34:
			case 35:
			case 36:
			case 37:
			case 38:
			case 39:
			case 40:
			case 41:
			case 43:
			case 44:
			case 46:
			case 47:
			case 48:
			case 49:
			case 50:
			case 51:
			case 52:
			case 53:
			case 54:
				result = "Panel01/";
				break;
			}
			break;
		case 16:
			switch (nameNum)
			{
			case 14:
			case 15:
			case 16:
			case 17:
			case 18:
			case 19:
			case 21:
			case 22:
				result = "Panel00/";
				break;
			case 23:
			case 24:
			case 25:
			case 26:
			case 27:
			case 28:
			case 29:
			case 30:
			case 32:
			case 33:
				result = "Panel01/";
				break;
			}
			break;
		case 17:
			switch (nameNum)
			{
			case 1:
			case 3:
				result = "Panel00/";
				break;
			case 5:
			case 6:
			case 7:
			case 8:
			case 10:
			case 21:
			case 22:
			case 23:
				result = "Panel01/";
				break;
			case 25:
			case 26:
			case 27:
			case 28:
			case 30:
			case 31:
				result = "Panel02/";
				break;
			}
			break;
		case 18:
			switch (nameNum)
			{
			case 21:
				result = "Panel00/";
				break;
			case 23:
			case 24:
			case 25:
				result = "Panel01/";
				break;
			case 27:
			case 28:
			case 29:
			case 30:
			case 31:
			case 32:
			case 33:
			case 34:
			case 36:
			case 37:
				result = "Panel02/";
				break;
			}
			break;
		case 28:
			switch (nameNum)
			{
			case 21:
			case 22:
			case 23:
				result = "Panel00/";
				break;
			case 25:
			case 27:
			case 28:
				result = "Panel01/";
				break;
			}
			break;
		case 29:
			switch (nameNum)
			{
			case 21:
			case 22:
				result = "Panel00/";
				break;
			case 24:
			case 26:
			case 28:
			case 29:
			case 30:
			case 31:
			case 32:
			case 33:
			case 34:
			case 35:
			case 36:
			case 37:
			case 38:
				result = "Panel01/";
				break;
			}
			break;
		case 32:
			switch (nameNum)
			{
			case 21:
			case 22:
			case 23:
				result = "Panel00/";
				break;
			case 25:
			case 27:
			case 28:
				result = "Panel01/";
				break;
			}
			break;
		case 33:
			switch (nameNum)
			{
			case 21:
			case 22:
				result = "Panel00/";
				break;
			case 25:
			case 27:
			case 28:
				result = "Panel01/";
				break;
			}
			break;
		case 34:
			switch (nameNum)
			{
			case 1:
			case 4:
			case 5:
			case 7:
			case 8:
			case 10:
			case 11:
			case 12:
			case 13:
			case 14:
			case 15:
				result = "Panel00/";
				break;
			case 30:
			case 31:
			case 32:
			case 33:
			case 34:
			case 36:
			case 37:
			case 38:
			case 39:
				result = "Panel01/";
				break;
			}
			break;
		}
		return result;
	}
}
