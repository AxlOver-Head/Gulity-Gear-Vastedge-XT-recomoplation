public class DirectionYakuManager
{
	public const int DATA_MAX = 11;

	public const int HOH_SET_DAMAGE_CH = 10;

	public YakuManager ym;

	public static panelManager pm;

	public static SlotGameManager sgm;

	public static DirectionYakuData[] data = new DirectionYakuData[11];

	public static bool isActive;

	public DirectionYakuManager(YakuManager _ym, panelManager _pm, SlotGameManager _sgm)
	{
		sgm = _sgm;
		pm = _pm;
		ym = _ym;
		int num = 0;
		for (num = 0; num < 11; num++)
		{
			data[num] = new DirectionYakuData();
		}
		isActive = false;
	}

	public static void init(int _idx)
	{
		data[_idx].init();
		isActive = true;
	}

	public static void init()
	{
		int num = 0;
		for (num = 0; num < 11; num++)
		{
			data[num].init();
		}
		isActive = true;
	}

	public static void initActive()
	{
		isActive = false;
	}

	public void control()
	{
		int num = 0;
		for (num = 0; num < 11; num++)
		{
			data[num].control(ym, pm);
		}
	}

	public static void setData(int _idx, int _frame, int _kind, int _param, int _event)
	{
		data[_idx].setEvent(_frame, _kind, _param, _event);
	}

	public static void setMovieDamageYaku(int _mov_id)
	{
		switch (_mov_id)
		{
		case 491:
			DamageYaku(0, 0);
			break;
		case 498:
			DamageYaku(0, 0);
			break;
		case 519:
			DamageYaku(0, 0);
			break;
		case 530:
			DamageYaku(0, 0);
			break;
		case 2207:
			DamageYaku(0, 0);
			break;
		case 2212:
			DamageYaku(0, 0);
			break;
		case 2217:
			DamageYaku(0, 0);
			break;
		case 2220:
			DamageYaku(0, 0);
			break;
		case 2293:
			DamageYaku(0, 0);
			break;
		case 2298:
			DamageYaku(0, 0);
			break;
		case 2303:
			DamageYaku(0, 0);
			break;
		case 2306:
			DamageYaku(0, 0);
			break;
		case 2383:
			DamageYaku(0, 0);
			break;
		case 2393:
			DamageYaku(0, 0);
			break;
		case 2400:
			DamageYaku(0, 0);
			break;
		case 2403:
			DamageYaku(0, 0);
			break;
		case 2420:
			DamageYaku(0, 0);
			break;
		case 417:
			DamageYaku(1, 30);
			break;
		case 419:
			DamageYaku(1, 100);
			break;
		case 423:
			DamageYaku(1, 50);
			break;
		case 2176:
			DamageYaku(1, 30);
			break;
		case 2178:
			DamageYaku(1, 0);
			break;
		case 2182:
			DamageYaku(1, 130);
			break;
		case 2262:
			DamageYaku(1, 40);
			break;
		case 2264:
			DamageYaku(1, 0);
			break;
		case 2268:
			DamageYaku(1, 25);
			break;
		case 2349:
			DamageYaku(1, 35);
			break;
		case 2351:
			DamageYaku(1, 40);
			break;
		case 2355:
			DamageYaku(1, 30);
			break;
		}
	}

	public static void DamageYaku(int _atk, int _frame)
	{
		init(10);
		if (_atk == 0)
		{
			setData(10, _frame, 0, sgm.get_pkd_data(100), 10);
		}
		else
		{
			setData(10, _frame, 0, sgm.get_pkd_data(100), 11);
		}
		panelManager.setDamageFlag(true);
	}

	public static void setMovieYaku(int _mov_id)
	{
		if (!isActive)
		{
			switch (_mov_id)
			{
			case 2912:
				_MAIN_GIMMICK_PTTERNS_1401();
				break;
			case 190:
				_MAIN_GIMMICK_PTTERNS_190();
				_MAIN_GIMMICK_PTTERNS_192();
				break;
			case 2061:
				_MAIN_GIMMICK_PTTERNS_829();
				break;
			case 2062:
				_MAIN_GIMMICK_PTTERNS_829();
				break;
			case 2063:
				_MAIN_GIMMICK_PTTERNS_829();
				break;
			case 324:
				_MAIN_GIMMICK_PTTERNS_201();
				break;
			case 325:
				_MAIN_GIMMICK_PTTERNS_201();
				break;
			case 326:
				_MAIN_GIMMICK_PTTERNS_201();
				break;
			case 343:
				_MAIN_GIMMICK_PTTERNS_205();
				break;
			case 346:
				_MAIN_GIMMICK_PTTERNS_211();
				break;
			case 349:
				_MAIN_GIMMICK_PTTERNS_215();
				break;
			case 351:
				_MAIN_GIMMICK_PTTERNS_223();
				break;
			case 352:
				_MAIN_GIMMICK_PTTERNS_223();
				break;
			case 353:
				_MAIN_GIMMICK_PTTERNS_223();
				break;
			case 354:
				_MAIN_GIMMICK_PTTERNS_223();
				break;
			case 355:
				_MAIN_GIMMICK_PTTERNS_223();
				break;
			case 361:
				_MAIN_GIMMICK_PTTERNS_231();
				break;
			case 368:
				_MAIN_GIMMICK_PTTERNS_239();
				break;
			case 370:
				_MAIN_GIMMICK_PTTERNS_244();
				break;
			case 373:
				_MAIN_GIMMICK_PTTERNS_249();
				break;
			case 375:
				_MAIN_GIMMICK_PTTERNS_254();
				break;
			case 377:
				_MAIN_GIMMICK_PTTERNS_268();
				break;
			case 379:
				_MAIN_GIMMICK_PTTERNS_274();
				break;
			case 382:
				_MAIN_GIMMICK_PTTERNS_282();
				break;
			case 384:
				_MAIN_GIMMICK_PTTERNS_287();
				break;
			case 411:
				_MAIN_GIMMICK_PTTERNS_296();
				break;
			case 414:
				_MAIN_GIMMICK_PTTERNS_300();
				break;
			case 417:
				_MAIN_GIMMICK_PTTERNS_305();
				break;
			case 419:
				_MAIN_GIMMICK_PTTERNS_314();
				break;
			case 426:
				_MAIN_GIMMICK_PTTERNS_319();
				break;
			case 423:
				_MAIN_GIMMICK_PTTERNS_323();
				break;
			case 428:
				_MAIN_GIMMICK_PTTERNS_310();
				break;
			case 429:
				_MAIN_GIMMICK_PTTERNS_310();
				break;
			case 430:
				_MAIN_GIMMICK_PTTERNS_310();
				break;
			case 431:
				_MAIN_GIMMICK_PTTERNS_310();
				break;
			case 432:
				_MAIN_GIMMICK_PTTERNS_310();
				break;
			case 433:
				_MAIN_GIMMICK_PTTERNS_326();
				break;
			case 435:
				_MAIN_GIMMICK_PTTERNS_095();
				break;
			case 551:
				_MAIN_GIMMICK_PTTERNS_072();
				break;
			case 613:
				_MAIN_GIMMICK_PTTERNS_341();
				break;
			case 617:
				_MAIN_GIMMICK_PTTERNS_345();
				break;
			case 629:
				_MAIN_GIMMICK_PTTERNS_347();
				_MAIN_GIMMICK_PTTERNS_349();
				break;
			case 760:
				_MAIN_GIMMICK_PTTERNS_356();
				break;
			case 762:
				_MAIN_GIMMICK_PTTERNS_356();
				break;
			case 784:
				_MAIN_GIMMICK_PTTERNS_356();
				break;
			case 788:
				_MAIN_GIMMICK_PTTERNS_356();
				break;
			case 792:
				_MAIN_GIMMICK_PTTERNS_356();
				break;
			case 798:
				_MAIN_GIMMICK_PTTERNS_368();
				break;
			case 799:
				_MAIN_GIMMICK_PTTERNS_364();
				break;
			case 800:
				_MAIN_GIMMICK_PTTERNS_372();
				break;
			case 801:
				_MAIN_GIMMICK_PTTERNS_380();
				break;
			case 802:
				_MAIN_GIMMICK_PTTERNS_376();
				break;
			case 803:
				_MAIN_GIMMICK_PTTERNS_384();
				break;
			case 804:
				_MAIN_GIMMICK_PTTERNS_388();
				break;
			case 805:
				_MAIN_GIMMICK_PTTERNS_392();
				break;
			case 807:
				_MAIN_GIMMICK_PTTERNS_396();
				break;
			case 809:
				_MAIN_GIMMICK_PTTERNS_400();
				break;
			case 811:
				_MAIN_GIMMICK_PTTERNS_406();
				break;
			case 813:
				_MAIN_GIMMICK_PTTERNS_410();
				break;
			case 922:
				_MAIN_GIMMICK_PTTERNS_413();
				break;
			case 1266:
				_MAIN_GIMMICK_PTTERNS_453();
				_MAIN_GIMMICK_PTTERNS_455();
				break;
			case 1268:
				_MAIN_GIMMICK_PTTERNS_457();
				_MAIN_GIMMICK_PTTERNS_459();
				break;
			case 1270:
				_MAIN_GIMMICK_PTTERNS_461();
				_MAIN_GIMMICK_PTTERNS_463();
				break;
			case 1278:
				_MAIN_GIMMICK_PTTERNS_474();
				break;
			case 1339:
				_MAIN_GIMMICK_PTTERNS_621();
				break;
			case 1429:
				_MAIN_GIMMICK_PTTERNS_629();
				_MAIN_GIMMICK_PTTERNS_631();
				break;
			case 1430:
				_MAIN_GIMMICK_PTTERNS_629();
				_MAIN_GIMMICK_PTTERNS_631();
				break;
			case 1497:
				_MAIN_GIMMICK_PTTERNS_676();
				break;
			case 1499:
				_MAIN_GIMMICK_PTTERNS_680();
				break;
			case 1501:
				_MAIN_GIMMICK_PTTERNS_684();
				break;
			case 1506:
				_MAIN_GIMMICK_PTTERNS_689();
				break;
			case 1509:
				_MAIN_GIMMICK_PTTERNS_693();
				break;
			case 1512:
				_MAIN_GIMMICK_PTTERNS_697();
				break;
			case 1515:
				_MAIN_GIMMICK_PTTERNS_701();
				_MAIN_GIMMICK_PTTERNS_703();
				break;
			case 1518:
				_MAIN_GIMMICK_PTTERNS_705();
				_MAIN_GIMMICK_PTTERNS_707();
				break;
			case 1531:
				_MAIN_GIMMICK_PTTERNS_709();
				_MAIN_GIMMICK_PTTERNS_711();
				break;
			case 1521:
				_MAIN_GIMMICK_PTTERNS_715();
				_MAIN_GIMMICK_PTTERNS_717();
				break;
			case 1524:
				_MAIN_GIMMICK_PTTERNS_719();
				_MAIN_GIMMICK_PTTERNS_721();
				break;
			case 1503:
				_MAIN_GIMMICK_PTTERNS_729();
				break;
			case 1637:
				_MAIN_GIMMICK_PTTERNS_739();
				break;
			case 1635:
				_MAIN_GIMMICK_PTTERNS_752();
				break;
			case 1638:
				_MAIN_GIMMICK_PTTERNS_084();
				break;
			case 1640:
				_MAIN_GIMMICK_PTTERNS_076();
				break;
			case 1641:
				_MAIN_GIMMICK_PTTERNS_080();
				break;
			case 2064:
				_MAIN_GIMMICK_PTTERNS_793();
				break;
			case 2065:
				_MAIN_GIMMICK_PTTERNS_793();
				break;
			case 2066:
				_MAIN_GIMMICK_PTTERNS_793();
				break;
			case 2067:
				_MAIN_GIMMICK_PTTERNS_797();
				break;
			case 2068:
				_MAIN_GIMMICK_PTTERNS_797();
				break;
			case 2069:
				_MAIN_GIMMICK_PTTERNS_797();
				break;
			case 2070:
				_MAIN_GIMMICK_PTTERNS_813();
				break;
			case 2071:
				_MAIN_GIMMICK_PTTERNS_813();
				break;
			case 2072:
				_MAIN_GIMMICK_PTTERNS_813();
				break;
			case 2073:
				_MAIN_GIMMICK_PTTERNS_805();
				break;
			case 2074:
				_MAIN_GIMMICK_PTTERNS_805();
				break;
			case 2075:
				_MAIN_GIMMICK_PTTERNS_805();
				break;
			case 2076:
				_MAIN_GIMMICK_PTTERNS_821();
				break;
			case 2077:
				_MAIN_GIMMICK_PTTERNS_821();
				break;
			case 2078:
				_MAIN_GIMMICK_PTTERNS_821();
				break;
			case 2079:
				_MAIN_GIMMICK_PTTERNS_817();
				break;
			case 2080:
				_MAIN_GIMMICK_PTTERNS_817();
				break;
			case 2081:
				_MAIN_GIMMICK_PTTERNS_817();
				break;
			case 2082:
				_MAIN_GIMMICK_PTTERNS_801();
				break;
			case 2083:
				_MAIN_GIMMICK_PTTERNS_801();
				break;
			case 2084:
				_MAIN_GIMMICK_PTTERNS_801();
				break;
			case 2085:
				_MAIN_GIMMICK_PTTERNS_809();
				break;
			case 2086:
				_MAIN_GIMMICK_PTTERNS_809();
				break;
			case 2087:
				_MAIN_GIMMICK_PTTERNS_809();
				break;
			case 2088:
				_MAIN_GIMMICK_PTTERNS_825();
				break;
			case 2089:
				_MAIN_GIMMICK_PTTERNS_825();
				break;
			case 2090:
				_MAIN_GIMMICK_PTTERNS_825();
				break;
			case 2113:
				_MAIN_GIMMICK_PTTERNS_833();
				break;
			case 2132:
				_MAIN_GIMMICK_PTTERNS_835();
				break;
			case 2130:
				_MAIN_GIMMICK_PTTERNS_839();
				_MAIN_GIMMICK_PTTERNS_841();
				break;
			case 2121:
				_MAIN_GIMMICK_PTTERNS_845();
				break;
			case 2123:
				_MAIN_GIMMICK_PTTERNS_849();
				break;
			case 2151:
				_MAIN_GIMMICK_PTTERNS_862();
				break;
			case 2153:
				_MAIN_GIMMICK_PTTERNS_866();
				break;
			case 2157:
				_MAIN_GIMMICK_PTTERNS_882();
				break;
			case 2158:
				_MAIN_GIMMICK_PTTERNS_890();
				break;
			case 2159:
				_MAIN_GIMMICK_PTTERNS_895();
				break;
			case 2161:
				_MAIN_GIMMICK_PTTERNS_899();
				break;
			case 2162:
				_MAIN_GIMMICK_PTTERNS_904();
				break;
			case 2163:
				_MAIN_GIMMICK_PTTERNS_911();
				break;
			case 2164:
				_MAIN_GIMMICK_PTTERNS_915();
				break;
			case 2172:
				_MAIN_GIMMICK_PTTERNS_943();
				break;
			case 2174:
				_MAIN_GIMMICK_PTTERNS_947();
				break;
			case 2176:
				_MAIN_GIMMICK_PTTERNS_951();
				break;
			case 2177:
				_MAIN_GIMMICK_PTTERNS_960();
				break;
			case 2183:
				_MAIN_GIMMICK_PTTERNS_965();
				break;
			case 2181:
				_MAIN_GIMMICK_PTTERNS_969();
				break;
			case 2184:
				_MAIN_GIMMICK_PTTERNS_310();
				break;
			case 2186:
				_MAIN_GIMMICK_PTTERNS_310();
				break;
			case 2188:
				_MAIN_GIMMICK_PTTERNS_310();
				break;
			case 2190:
				_MAIN_GIMMICK_PTTERNS_310();
				break;
			case 2192:
				_MAIN_GIMMICK_PTTERNS_310();
				break;
			case 2236:
				_MAIN_GIMMICK_PTTERNS_985();
				break;
			case 2238:
				_MAIN_GIMMICK_PTTERNS_989();
				break;
			case 2242:
				_MAIN_GIMMICK_PTTERNS_1005();
				break;
			case 2243:
				_MAIN_GIMMICK_PTTERNS_1010();
				break;
			case 2244:
				_MAIN_GIMMICK_PTTERNS_1015();
				break;
			case 2246:
				_MAIN_GIMMICK_PTTERNS_1019();
				break;
			case 2247:
				_MAIN_GIMMICK_PTTERNS_1024();
				break;
			case 2248:
				_MAIN_GIMMICK_PTTERNS_1035();
				break;
			case 2249:
				_MAIN_GIMMICK_PTTERNS_1041();
				break;
			case 2258:
				_MAIN_GIMMICK_PTTERNS_1063();
				break;
			case 2260:
				_MAIN_GIMMICK_PTTERNS_1067();
				break;
			case 2262:
				_MAIN_GIMMICK_PTTERNS_1072();
				break;
			case 2263:
				_MAIN_GIMMICK_PTTERNS_1081();
				break;
			case 2269:
				_MAIN_GIMMICK_PTTERNS_1086();
				break;
			case 2267:
				_MAIN_GIMMICK_PTTERNS_1090();
				break;
			case 2270:
				_MAIN_GIMMICK_PTTERNS_310();
				break;
			case 2272:
				_MAIN_GIMMICK_PTTERNS_310();
				break;
			case 2274:
				_MAIN_GIMMICK_PTTERNS_310();
				break;
			case 2276:
				_MAIN_GIMMICK_PTTERNS_310();
				break;
			case 2278:
				_MAIN_GIMMICK_PTTERNS_310();
				break;
			case 2323:
				_MAIN_GIMMICK_PTTERNS_1106();
				break;
			case 2325:
				_MAIN_GIMMICK_PTTERNS_1110();
				break;
			case 2329:
				_MAIN_GIMMICK_PTTERNS_1126();
				break;
			case 2330:
				_MAIN_GIMMICK_PTTERNS_1131();
				break;
			case 2331:
				_MAIN_GIMMICK_PTTERNS_1136();
				break;
			case 2333:
				_MAIN_GIMMICK_PTTERNS_1140();
				break;
			case 2334:
				_MAIN_GIMMICK_PTTERNS_1145();
				break;
			case 2335:
				_MAIN_GIMMICK_PTTERNS_1156();
				break;
			case 2336:
				_MAIN_GIMMICK_PTTERNS_1162();
				break;
			case 2345:
				_MAIN_GIMMICK_PTTERNS_1184();
				break;
			case 2347:
				_MAIN_GIMMICK_PTTERNS_1188();
				break;
			case 2349:
				_MAIN_GIMMICK_PTTERNS_1193();
				break;
			case 2350:
				_MAIN_GIMMICK_PTTERNS_1202();
				break;
			case 2356:
				_MAIN_GIMMICK_PTTERNS_1207();
				break;
			case 2354:
				_MAIN_GIMMICK_PTTERNS_1211();
				break;
			case 2357:
				_MAIN_GIMMICK_PTTERNS_310();
				break;
			case 2359:
				_MAIN_GIMMICK_PTTERNS_310();
				break;
			case 2361:
				_MAIN_GIMMICK_PTTERNS_310();
				break;
			case 2363:
				_MAIN_GIMMICK_PTTERNS_310();
				break;
			case 2365:
				_MAIN_GIMMICK_PTTERNS_310();
				break;
			case 2417:
				_MAIN_GIMMICK_PTTERNS_1223();
				break;
			case 2419:
				_MAIN_GIMMICK_PTTERNS_1227();
				break;
			case 2434:
				_MAIN_GIMMICK_PTTERNS_1256();
				_MAIN_GIMMICK_PTTERNS_1257();
				break;
			case 2435:
				_MAIN_GIMMICK_PTTERNS_1256();
				_MAIN_GIMMICK_PTTERNS_1257();
				break;
			case 2446:
				_MAIN_GIMMICK_PTTERNS_1269();
				break;
			case 2448:
				_MAIN_GIMMICK_PTTERNS_1256();
				break;
			case 2984:
				_MAIN_GIMMICK_PTTERNS_1595();
				_MAIN_GIMMICK_PTTERNS_1595();
				break;
			case 2534:
				_MAIN_GIMMICK_PTTERNS_1276();
				_MAIN_GIMMICK_PTTERNS_1278();
				break;
			case 2523:
				_MAIN_GIMMICK_PTTERNS_1282();
				break;
			case 2527:
				_MAIN_GIMMICK_PTTERNS_1286();
				break;
			case 2539:
				_MAIN_GIMMICK_PTTERNS_1288();
				_MAIN_GIMMICK_PTTERNS_1290();
				break;
			case 2632:
				_MAIN_GIMMICK_PTTERNS_1294();
				_MAIN_GIMMICK_PTTERNS_1295();
				break;
			case 2634:
				_MAIN_GIMMICK_PTTERNS_1297();
				_MAIN_GIMMICK_PTTERNS_1298();
				_MAIN_GIMMICK_PTTERNS_1298();
				break;
			case 2686:
				_MAIN_GIMMICK_PTTERNS_1308();
				break;
			case 2706:
				_MAIN_GIMMICK_PTTERNS_1316();
				break;
			case 2707:
				_MAIN_GIMMICK_PTTERNS_1320();
				break;
			case 2708:
				_MAIN_GIMMICK_PTTERNS_1324();
				break;
			case 2709:
				_MAIN_GIMMICK_PTTERNS_1328();
				break;
			case 2710:
				_MAIN_GIMMICK_PTTERNS_1332();
				break;
			case 2757:
				_MAIN_GIMMICK_PTTERNS_1338();
				break;
			case 2769:
				_MAIN_GIMMICK_PTTERNS_1343();
				break;
			case 2771:
				_MAIN_GIMMICK_PTTERNS_1347();
				break;
			case 2679:
				_MAIN_GIMMICK_PTTERNS_1302();
				break;
			case 2687:
				_MAIN_GIMMICK_PTTERNS_1312();
				break;
			case 2842:
				_MAIN_GIMMICK_PTTERNS_1368();
				break;
			case 2843:
				_MAIN_GIMMICK_PTTERNS_1368();
				break;
			case 2844:
				_MAIN_GIMMICK_PTTERNS_1368();
				break;
			case 2839:
				_MAIN_GIMMICK_PTTERNS_1364();
				break;
			case 2840:
				_MAIN_GIMMICK_PTTERNS_1364();
				break;
			case 2841:
				_MAIN_GIMMICK_PTTERNS_1364();
				break;
			case 2845:
				_MAIN_GIMMICK_PTTERNS_1370();
				break;
			case 2846:
				_MAIN_GIMMICK_PTTERNS_1374();
				_MAIN_GIMMICK_PTTERNS_1375();
				_MAIN_GIMMICK_PTTERNS_1376();
				break;
			case 2850:
				_MAIN_GIMMICK_PTTERNS_1378();
				break;
			case 2852:
				_MAIN_GIMMICK_PTTERNS_1382();
				_MAIN_GIMMICK_PTTERNS_1384();
				break;
			case 2858:
				_MAIN_GIMMICK_PTTERNS_1388();
				break;
			case 2862:
				_MAIN_GIMMICK_PTTERNS_1390();
				_MAIN_GIMMICK_PTTERNS_1392();
				break;
			case 2870:
				_MAIN_GIMMICK_PTTERNS_1394();
				_MAIN_GIMMICK_PTTERNS_1395();
				break;
			case 2944:
				_MAIN_GIMMICK_PTTERNS_1540();
				break;
			case 2946:
				_MAIN_GIMMICK_PTTERNS_1541();
				break;
			case 2948:
				_MAIN_GIMMICK_PTTERNS_1545();
				break;
			case 2950:
				_MAIN_GIMMICK_PTTERNS_1552();
				break;
			case 2952:
				_MAIN_GIMMICK_PTTERNS_1552();
				break;
			case 2954:
				_MAIN_GIMMICK_PTTERNS_1552();
				break;
			case 2956:
				_MAIN_GIMMICK_PTTERNS_1552();
				break;
			case 2958:
				_MAIN_GIMMICK_PTTERNS_1552();
				break;
			case 2960:
				_MAIN_GIMMICK_PTTERNS_1556();
				break;
			case 2982:
				_MAIN_GIMMICK_PTTERNS_1590();
				_MAIN_GIMMICK_PTTERNS_1592();
				break;
			case 3692:
				_MAIN_GIMMICK_PTTERNS_1692();
				_MAIN_GIMMICK_PTTERNS_1694();
				break;
			case 3699:
				_MAIN_GIMMICK_PTTERNS_1696();
				_MAIN_GIMMICK_PTTERNS_1698();
				break;
			case 3742:
				_MAIN_GIMMICK_PTTERNS_1700();
				_MAIN_GIMMICK_PTTERNS_1702();
				break;
			case 3744:
				_MAIN_GIMMICK_PTTERNS_1722();
				_MAIN_GIMMICK_PTTERNS_1724();
				break;
			case 3764:
				_MAIN_GIMMICK_PTTERNS_1728();
				break;
			case 3811:
				_MAIN_GIMMICK_PTTERNS_1732();
				break;
			case 3813:
				_MAIN_GIMMICK_PTTERNS_1732();
				break;
			case 3815:
				_MAIN_GIMMICK_PTTERNS_1732();
				break;
			case 3817:
				_MAIN_GIMMICK_PTTERNS_1732();
				break;
			case 3819:
				_MAIN_GIMMICK_PTTERNS_1732();
				break;
			case 3821:
				_MAIN_GIMMICK_PTTERNS_1732();
				break;
			case 3823:
				_MAIN_GIMMICK_PTTERNS_1736();
				break;
			case 3824:
				_MAIN_GIMMICK_PTTERNS_1736();
				break;
			case 3825:
				_MAIN_GIMMICK_PTTERNS_1736();
				break;
			case 3826:
				_MAIN_GIMMICK_PTTERNS_1736();
				break;
			case 3827:
				_MAIN_GIMMICK_PTTERNS_1736();
				break;
			case 3828:
				_MAIN_GIMMICK_PTTERNS_1736();
				break;
			case 165:
				_MAIN_GIMMICK_PTTERNS_180();
				break;
			case 167:
				_MAIN_GIMMICK_PTTERNS_184();
				break;
			case 623:
				_MAIN_GIMMICK_PTTERNS_334();
				_MAIN_GIMMICK_PTTERNS_336();
				break;
			}
			isActive = false;
		}
	}

	public static void procBonusGD()
	{
		int num = MainGameScene.slotGameMan.get_pdt_data(45);
		int num2 = MainGameScene.slotGameMan.get_pdt_data(46);
		int num3 = MainGameScene.slotGameMan.get_pdt_data(1);
		if (num != num2 && num2 != 13 && num2 != 14)
		{
			num = num2;
		}
		if (13 <= num && num <= 14 && num3 != 95 && num3 != 94)
		{
			_MAIN_TESTTEST_051();
		}
		else if (num == 33)
		{
			_MAIN_GIMMICK_PTTERNS_1666();
		}
	}

	public static void _GIMMICK_PTTERNS_001(int _idx, int _frame)
	{
		_MOT_JYD_U_001(_idx, 0 + _frame);
		_MOT_JYD_B_001(_idx, 42 + _frame);
		_MOT_LOGO_001(_idx, 91 + _frame);
		_MOT_GEAR_001(_idx, 99 + _frame);
		_MOT_ROT_007(_idx, 124 + _frame);
		setData(_idx, 177 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_002(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		_MOT_LOGO_001(_idx, 1 + _frame);
		setData(_idx, 9 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_003(int _idx, int _frame)
	{
		_TEST_JYD_021(_idx, 0 + _frame);
		_TEST_JYD_001(_idx, 1 + _frame);
		setData(_idx, 43 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_004(int _idx, int _frame)
	{
		_MOT_ROT_008(_idx, 0 + _frame);
		_MOT_ROT_045(_idx, 1 + _frame);
		setData(_idx, 64 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_005(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_MOT_GEAR_001(_idx, 1 + _frame);
		setData(_idx, 26 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_006(int _idx, int _frame)
	{
		_MOT_ROT_008(_idx, 0 + _frame);
		_MOT_ROT_025(_idx, 1 + _frame);
		setData(_idx, 28 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_007(int _idx, int _frame)
	{
		_MOT_ROT_008(_idx, 0 + _frame);
		_MOT_ROT_026(_idx, 1 + _frame);
		setData(_idx, 40 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_008(int _idx, int _frame)
	{
		_MOT_ROT_008(_idx, 0 + _frame);
		_MOT_ROT_027(_idx, 1 + _frame);
		setData(_idx, 36 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_009(int _idx, int _frame)
	{
		_MOT_ROT_008(_idx, 0 + _frame);
		_MOT_ROT_028(_idx, 1 + _frame);
		setData(_idx, 28 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_010(int _idx, int _frame)
	{
		_MOT_JYD_U_004(_idx, 0 + _frame);
		_MOT_JYD_U_027(_idx, 1 + _frame);
		setData(_idx, 26 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_011(int _idx, int _frame)
	{
		_MOT_JYD_U_004(_idx, 0 + _frame);
		_MOT_JYD_U_009(_idx, 1 + _frame);
		setData(_idx, 25 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_012(int _idx, int _frame)
	{
		_MOT_JYD_B_004(_idx, 0 + _frame);
		_MOT_JYD_B_027(_idx, 1 + _frame);
		setData(_idx, 32 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_013(int _idx, int _frame)
	{
		_MOT_JYD_B_004(_idx, 0 + _frame);
		_MOT_JYD_B_006(_idx, 1 + _frame);
		setData(_idx, 22 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_014(int _idx, int _frame)
	{
		_TEST_JYD_021(_idx, 0 + _frame);
		_TEST_JYD_009(_idx, 1 + _frame);
		setData(_idx, 25 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_015(int _idx, int _frame)
	{
		_TEST_JYD_021(_idx, 0 + _frame);
		_TEST_JYD_005(_idx, 1 + _frame);
		setData(_idx, 31 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_016(int _idx, int _frame)
	{
		_MOT_JYD_U_006(_idx, 67 + _frame);
		_MOT_JYD_B_009(_idx, 97 + _frame);
		_MOT_JYD_U_009(_idx, 134 + _frame);
		_MOT_JYD_B_006(_idx, 158 + _frame);
		_MOT_JYD_U_006(_idx, 246 + _frame);
		_MOT_JYD_B_009(_idx, 276 + _frame);
		_MOT_LOGO_006(_idx, 313 + _frame);
		_MOT_LOGO_009(_idx, 319 + _frame);
		_MOT_LOGO_006(_idx, 389 + _frame);
		_MOT_GEAR_020(_idx, 395 + _frame);
		_MOT_GEAR_010(_idx, 397 + _frame);
		_MOT_GEAR_020(_idx, 421 + _frame);
		_MOT_ROT_045(_idx, 490 + _frame);
		_MOT_ROT_039(_idx, 620 + _frame);
		_MOT_ROT_006(_idx, 714 + _frame);
		setData(_idx, 741 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_017(int _idx, int _frame)
	{
		_TEST_JYD_021(_idx, 0 + _frame);
		setData(_idx, 1 + _frame, 8, 3, 8);
		setData(_idx, 31 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_018(int _idx, int _frame)
	{
		_TEST_JYD_021(_idx, 0 + _frame);
		setData(_idx, 1 + _frame, 8, 2, 8);
		setData(_idx, 15 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_019(int _idx, int _frame)
	{
		_TEST_JYD_021(_idx, 0 + _frame);
		setData(_idx, 1 + _frame, 8, 4, 8);
		setData(_idx, 15 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_020(int _idx, int _frame)
	{
		_TEST_JYD_021(_idx, 0 + _frame);
		setData(_idx, 1 + _frame, 8, 3, 8);
		setData(_idx, 33 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_021(int _idx, int _frame)
	{
		_TEST_JYD_021(_idx, 0 + _frame);
		setData(_idx, 1 + _frame, 8, 3, 8);
		setData(_idx, 31 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_022(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		_MOT_LOGO_013(_idx, 1 + _frame);
		setData(_idx, 6 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_023(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		_MOT_LOGO_009(_idx, 1 + _frame);
		setData(_idx, 4 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_024(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		_MOT_LOGO_005(_idx, 1 + _frame);
		setData(_idx, 11 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_025(int _idx, int _frame)
	{
		setData(_idx, 1 + _frame, 6, 1, 8);
		setData(_idx, 21 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_026(int _idx, int _frame)
	{
		setData(_idx, 1 + _frame, 6, 2, 8);
		setData(_idx, 31 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_027(int _idx, int _frame)
	{
		setData(_idx, 1 + _frame, 6, 3, 8);
		setData(_idx, 41 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_028(int _idx, int _frame)
	{
		setData(_idx, 1 + _frame, 6, 4, 8);
		setData(_idx, 51 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_029(int _idx, int _frame)
	{
		setData(_idx, 1 + _frame, 6, 7, 8);
		setData(_idx, 81 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_030(int _idx, int _frame)
	{
		_MOT_GEAR_020(_idx, 0 + _frame);
		setData(_idx, 2 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_031(int _idx, int _frame)
	{
		setData(_idx, 1 + _frame, 7, 78, 8);
		setData(_idx, 27 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_032(int _idx, int _frame)
	{
		setData(_idx, 1 + _frame, 7, 79, 8);
		setData(_idx, 51 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_033(int _idx, int _frame)
	{
		setData(_idx, 1 + _frame, 7, 80, 8);
		setData(_idx, 75 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_034(int _idx, int _frame)
	{
		setData(_idx, 1 + _frame, 7, 81, 8);
		setData(_idx, 99 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_035(int _idx, int _frame)
	{
		setData(_idx, 1 + _frame, 7, 69, 8);
		setData(_idx, 27 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_036(int _idx, int _frame)
	{
		setData(_idx, 1 + _frame, 7, 70, 8);
		setData(_idx, 51 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_037(int _idx, int _frame)
	{
		setData(_idx, 1 + _frame, 7, 71, 8);
		setData(_idx, 75 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_038(int _idx, int _frame)
	{
		setData(_idx, 1 + _frame, 7, 72, 8);
		setData(_idx, 99 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_039(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		setData(_idx, 1 + _frame, 7, 1, 8);
		setData(_idx, 6 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_040(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		setData(_idx, 1 + _frame, 7, 2, 8);
		setData(_idx, 6 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_041(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		setData(_idx, 1 + _frame, 7, 3, 8);
		setData(_idx, 6 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_042(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		setData(_idx, 1 + _frame, 7, 5, 8);
		setData(_idx, 6 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_043(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		setData(_idx, 1 + _frame, 7, 9, 8);
		setData(_idx, 6 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_044(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		setData(_idx, 1 + _frame, 7, 69, 8);
		setData(_idx, 6 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_045(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		setData(_idx, 1 + _frame, 7, 70, 8);
		setData(_idx, 6 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_046(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		setData(_idx, 1 + _frame, 7, 71, 8);
		setData(_idx, 6 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_047(int _idx, int _frame)
	{
		_MOT_ROT_008(_idx, 0 + _frame);
		_MOT_ROT_024(_idx, 1 + _frame);
		setData(_idx, 6 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_048(int _idx, int _frame)
	{
		_MOT_ROT_008(_idx, 0 + _frame);
		_MOT_ROT_042(_idx, 1 + _frame);
		setData(_idx, 6 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_049(int _idx, int _frame)
	{
		_MOT_ROT_008(_idx, 0 + _frame);
		setData(_idx, 1 + _frame, 9, 69, 8);
		setData(_idx, 1 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_050(int _idx, int _frame)
	{
		_MOT_ROT_008(_idx, 0 + _frame);
		setData(_idx, 1 + _frame, 9, 71, 8);
		setData(_idx, 1 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_051(int _idx, int _frame)
	{
		_MOT_ROT_008(_idx, 0 + _frame);
		setData(_idx, 1 + _frame, 9, 73, 8);
		setData(_idx, 1 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_052(int _idx, int _frame)
	{
		_MOT_ROT_008(_idx, 0 + _frame);
		setData(_idx, 1 + _frame, 9, 75, 8);
		setData(_idx, 1 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_053(int _idx, int _frame)
	{
		_MOT_ROT_008(_idx, 0 + _frame);
		setData(_idx, 1 + _frame, 9, 77, 8);
		setData(_idx, 1 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_054(int _idx, int _frame)
	{
		_MOT_ROT_008(_idx, 0 + _frame);
		setData(_idx, 1 + _frame, 9, 79, 8);
		setData(_idx, 1 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_055(int _idx, int _frame)
	{
		_MOT_ROT_008(_idx, 0 + _frame);
		setData(_idx, 1 + _frame, 9, 81, 8);
		setData(_idx, 1 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_056(int _idx, int _frame)
	{
		_MOT_ROT_008(_idx, 0 + _frame);
		setData(_idx, 1 + _frame, 9, 83, 8);
		setData(_idx, 1 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_057(int _idx, int _frame)
	{
		_MOT_ROT_008(_idx, 0 + _frame);
		setData(_idx, 1 + _frame, 9, 106, 8);
		setData(_idx, 72 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_058(int _idx, int _frame)
	{
		_MOT_ROT_008(_idx, 0 + _frame);
		setData(_idx, 1 + _frame, 9, 107, 8);
		setData(_idx, 105 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_059(int _idx, int _frame)
	{
		_MOT_ROT_008(_idx, 0 + _frame);
		setData(_idx, 1 + _frame, 9, 101, 8);
		setData(_idx, 105 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_060(int _idx, int _frame)
	{
		_MOT_ROT_008(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_053(_idx, 1 + _frame);
		setData(_idx, 2 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_061(int _idx, int _frame)
	{
		_MOT_ROT_008(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_049(_idx, 1 + _frame);
		setData(_idx, 2 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_062(int _idx, int _frame)
	{
		_MOT_ROT_008(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_054(_idx, 1 + _frame);
		setData(_idx, 2 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_063(int _idx, int _frame)
	{
		_MOT_ROT_008(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_050(_idx, 1 + _frame);
		setData(_idx, 2 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_064(int _idx, int _frame)
	{
		_MOT_ROT_008(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_055(_idx, 1 + _frame);
		setData(_idx, 2 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_065(int _idx, int _frame)
	{
		_MOT_ROT_008(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_051(_idx, 1 + _frame);
		setData(_idx, 2 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_066(int _idx, int _frame)
	{
		_MOT_ROT_008(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_056(_idx, 1 + _frame);
		setData(_idx, 2 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_067(int _idx, int _frame)
	{
		_MOT_ROT_008(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_052(_idx, 1 + _frame);
		setData(_idx, 2 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_068(int _idx, int _frame)
	{
		_MOT_JYD_U_004(_idx, 0 + _frame);
		_MOT_JYD_B_004(_idx, 1 + _frame);
		_MOT_LOGO_002(_idx, 2 + _frame);
		_MOT_GEAR_004(_idx, 3 + _frame);
		_MOT_ROT_008(_idx, 4 + _frame);
		_MOT_JYD_U_006(_idx, 5 + _frame);
		_MOT_JYD_B_009(_idx, 35 + _frame);
		_MOT_LOGO_006(_idx, 72 + _frame);
		_MOT_GEAR_013(_idx, 78 + _frame);
		_MOT_GEAR_020(_idx, 102 + _frame);
		_MOT_ROT_006(_idx, 104 + _frame);
		setData(_idx, 131 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_069(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_070(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_071(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_072(int _idx, int _frame)
	{
		_MOT_ROT_008(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_065(_idx, 1 + _frame);
		setData(_idx, 3 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_073(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_074(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_075(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_076(int _idx, int _frame)
	{
		_MOT_ROT_008(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_063(_idx, 1 + _frame);
		setData(_idx, 3 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_077(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_078(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_079(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_080(int _idx, int _frame)
	{
		_MOT_ROT_008(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_067(_idx, 1 + _frame);
		setData(_idx, 3 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_081(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_082(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_083(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_084(int _idx, int _frame)
	{
		_MOT_ROT_008(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_065(_idx, 1 + _frame);
		setData(_idx, 3 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_085(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_086(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_087(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_088(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_089(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_090(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_091(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_092(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_093(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_094(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_095(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_MOT_GEAR_010(_idx, 1 + _frame);
		_MOT_GEAR_020(_idx, 25 + _frame);
		setData(_idx, 27 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_096(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_097(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		setData(_idx, 1 + _frame, 6, 2, 8);
		setData(_idx, 11 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_098(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_099(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_100(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_097(_idx, 0 + _frame);
		setData(_idx, 11 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_101(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_097(_idx, 0 + _frame);
		setData(_idx, 11 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_102(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_103(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_104(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_105(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		setData(_idx, 19 + _frame, 7, 3, 8);
		setData(_idx, 24 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_106(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_107(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_108(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_109(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		setData(_idx, 19 + _frame, 6, 3, 8);
		setData(_idx, 29 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_110(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_111(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_MOT_GEAR_010(_idx, 19 + _frame);
		_MOT_GEAR_020(_idx, 43 + _frame);
		setData(_idx, 45 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_112(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_113(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_114(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_115(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		setData(_idx, 19 + _frame, 6, 7, 8);
		setData(_idx, 29 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_116(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_117(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		setData(_idx, 19 + _frame, 7, 70, 8);
		_MOT_GEAR_020(_idx, 43 + _frame);
		setData(_idx, 45 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_118(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_119(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1401(_idx, 0 + _frame);
		setData(_idx, 107 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_120(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		setData(_idx, 99 + _frame, 6, 3, 8);
		setData(_idx, 109 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_121(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_122(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_MOT_GEAR_010(_idx, 99 + _frame);
		_MOT_GEAR_020(_idx, 123 + _frame);
		setData(_idx, 125 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_123(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_124(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_125(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1401(_idx, 0 + _frame);
		setData(_idx, 107 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_126(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		setData(_idx, 99 + _frame, 6, 7, 8);
		setData(_idx, 109 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_127(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_128(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		setData(_idx, 99 + _frame, 7, 70, 8);
		_MOT_GEAR_020(_idx, 123 + _frame);
		setData(_idx, 125 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_129(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_130(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_131(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		setData(_idx, 1 + _frame, 6, 4, 8);
		setData(_idx, 11 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_132(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_133(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_134(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_135(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		setData(_idx, 1 + _frame, 6, 4, 8);
		setData(_idx, 11 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_136(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_137(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		setData(_idx, 19 + _frame, 6, 7, 8);
		setData(_idx, 29 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_138(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_139(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		setData(_idx, 19 + _frame, 7, 70, 8);
		_MOT_GEAR_020(_idx, 43 + _frame);
		setData(_idx, 45 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_140(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_141(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_142(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_143(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		setData(_idx, 19 + _frame, 7, 3, 8);
		setData(_idx, 24 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_144(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_145(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_146(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_147(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		setData(_idx, 19 + _frame, 6, 3, 8);
		setData(_idx, 29 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_148(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_149(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_MOT_GEAR_010(_idx, 19 + _frame);
		_MOT_GEAR_020(_idx, 43 + _frame);
		setData(_idx, 45 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_150(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_151(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_152(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_153(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		setData(_idx, 19 + _frame, 6, 7, 8);
		setData(_idx, 29 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_154(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_155(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		setData(_idx, 1 + _frame, 7, 70, 8);
		_MOT_GEAR_020(_idx, 25 + _frame);
		setData(_idx, 27 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_156(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_157(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_158(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		setData(_idx, 99 + _frame, 6, 3, 8);
		setData(_idx, 109 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_159(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_160(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_MOT_GEAR_010(_idx, 99 + _frame);
		_MOT_GEAR_020(_idx, 123 + _frame);
		setData(_idx, 125 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_161(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_162(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_163(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_164(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		setData(_idx, 99 + _frame, 6, 7, 8);
		setData(_idx, 109 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_165(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_166(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		setData(_idx, 99 + _frame, 7, 70, 8);
		_MOT_GEAR_020(_idx, 123 + _frame);
		setData(_idx, 125 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_167(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_168(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_169(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_170(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_171(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_172(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_173(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_174(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_175(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_176(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_177(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_178(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_179(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_180(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		setData(_idx, 18 + _frame, 7, 3, 8);
		setData(_idx, 23 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_181(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_182(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_183(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_184(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_032(_idx, 18 + _frame);
		setData(_idx, 45 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_185(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_186(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_027(_idx, 8 + _frame);
		setData(_idx, 19 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_187(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_188(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_031(_idx, 8 + _frame);
		setData(_idx, 35 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_189(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_190(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		setData(_idx, 1 + _frame, 6, 3, 8);
		setData(_idx, 11 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_191(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_192(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_MOT_GEAR_010(_idx, 1 + _frame);
		_MOT_GEAR_020(_idx, 25 + _frame);
		setData(_idx, 27 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_193(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_194(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_195(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_196(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_197(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_198(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_199(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_200(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_201(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		setData(_idx, 34 + _frame, 6, 2, 8);
		setData(_idx, 44 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_202(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_203(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_204(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_205(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_028(_idx, 14 + _frame);
		setData(_idx, 25 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_206(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_207(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_208(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_209(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_210(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_211(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_MOT_GEAR_014(_idx, 3 + _frame);
		setData(_idx, 8 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_212(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_213(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_214(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_215(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_MOT_GEAR_014(_idx, 3 + _frame);
		setData(_idx, 8 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_216(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_217(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_218(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_219(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_CMD_002(_idx, 1 + _frame);
		setData(_idx, 1 + _frame, 7, 96, 8);
		setData(_idx, 6 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_220(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_221(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_222(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_223(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_219(_idx, 45 + _frame);
		setData(_idx, 51 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_224(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_225(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_226(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_227(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_CMD_002(_idx, 1 + _frame);
		setData(_idx, 1 + _frame, 7, 98, 8);
		setData(_idx, 6 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_228(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_229(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_230(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_231(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_227(_idx, 158 + _frame);
		setData(_idx, 164 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_232(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_233(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_234(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_235(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_CMD_002(_idx, 1 + _frame);
		setData(_idx, 1 + _frame, 7, 98, 8);
		setData(_idx, 6 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_236(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_237(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_238(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_239(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_235(_idx, 93 + _frame);
		setData(_idx, 99 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_240(int _idx, int _frame)
	{
		_TEST_JYD_021(_idx, 0 + _frame);
		_TEST_JYD_009(_idx, 1 + _frame);
		_TEST_JYD_005(_idx, 25 + _frame);
		_GIMMICK_PTTERNS_235(_idx, 55 + _frame);
		setData(_idx, 61 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_241(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_242(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_243(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_244(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_MOT_GEAR_014(_idx, 14 + _frame);
		setData(_idx, 19 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_245(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_CMD_004(_idx, 5 + _frame);
		_MOT_GEAR_014(_idx, 5 + _frame);
		_CMD_004(_idx, 20 + _frame);
		_MOT_GEAR_014(_idx, 20 + _frame);
		setData(_idx, 25 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_246(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_247(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_248(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_249(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_245(_idx, 0 + _frame);
		_CMD_002(_idx, 53 + _frame);
		setData(_idx, 53 + _frame, 7, 96, 8);
		setData(_idx, 58 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_250(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_249(_idx, 0 + _frame);
		setData(_idx, 58 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_251(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_252(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_253(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_254(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_245(_idx, 0 + _frame);
		_CMD_004(_idx, 35 + _frame);
		_MOT_GEAR_014(_idx, 35 + _frame);
		_CMD_004(_idx, 50 + _frame);
		_MOT_GEAR_014(_idx, 50 + _frame);
		_CMD_004(_idx, 65 + _frame);
		_MOT_GEAR_014(_idx, 65 + _frame);
		_CMD_002(_idx, 98 + _frame);
		setData(_idx, 98 + _frame, 7, 96, 8);
		setData(_idx, 103 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_255(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_254(_idx, 0 + _frame);
		setData(_idx, 103 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_256(int _idx, int _frame)
	{
		_TEST_JYD_021(_idx, 0 + _frame);
		_TEST_JYD_009(_idx, 1 + _frame);
		_TEST_JYD_005(_idx, 25 + _frame);
		_GIMMICK_PTTERNS_254(_idx, 55 + _frame);
		setData(_idx, 158 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_257(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_258(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_259(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_260(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_CMD_004(_idx, 1 + _frame);
		setData(_idx, 1 + _frame, 7, 98, 8);
		setData(_idx, 6 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_261(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_262(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_263(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_264(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_260(_idx, 47 + _frame);
		setData(_idx, 53 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_265(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_266(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_267(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_268(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_260(_idx, 36 + _frame);
		_CMD_002(_idx, 105 + _frame);
		setData(_idx, 105 + _frame, 7, 96, 8);
		setData(_idx, 110 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_269(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_268(_idx, 0 + _frame);
		setData(_idx, 110 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_270(int _idx, int _frame)
	{
		_TEST_JYD_021(_idx, 0 + _frame);
		_TEST_JYD_009(_idx, 1 + _frame);
		_TEST_JYD_005(_idx, 25 + _frame);
		_GIMMICK_PTTERNS_268(_idx, 55 + _frame);
		setData(_idx, 165 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_271(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_272(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_273(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_274(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_MOT_GEAR_014(_idx, 3 + _frame);
		setData(_idx, 8 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_275(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_276(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_277(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_278(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_CMD_002(_idx, 1 + _frame);
		setData(_idx, 1 + _frame, 7, 102, 8);
		setData(_idx, 6 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_279(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_280(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_281(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_282(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_278(_idx, 154 + _frame);
		setData(_idx, 160 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_283(int _idx, int _frame)
	{
		_TEST_JYD_021(_idx, 0 + _frame);
		_TEST_JYD_009(_idx, 1 + _frame);
		_TEST_JYD_005(_idx, 25 + _frame);
		_GIMMICK_PTTERNS_278(_idx, 55 + _frame);
		setData(_idx, 61 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_284(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_285(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_286(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_287(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_CMD_002(_idx, 132 + _frame);
		setData(_idx, 132 + _frame, 7, 70, 8);
		setData(_idx, 156 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_288(int _idx, int _frame)
	{
		_TEST_JYD_021(_idx, 0 + _frame);
		_TEST_JYD_009(_idx, 1 + _frame);
		_TEST_JYD_005(_idx, 25 + _frame);
		_GIMMICK_PTTERNS_287(_idx, 55 + _frame);
		setData(_idx, 211 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_289(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_290(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		setData(_idx, 40 + _frame, 6, 4, 8);
		setData(_idx, 50 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_291(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_292(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_293(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_294(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_295(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_296(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_MOT_GEAR_017(_idx, 5 + _frame);
		setData(_idx, 10 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_297(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_298(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_299(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_300(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_MOT_GEAR_017(_idx, 7 + _frame);
		setData(_idx, 12 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_301(int _idx, int _frame)
	{
		setData(_idx, 28 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_302(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_303(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_304(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_305(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_301(_idx, 1 + _frame);
		_CMD_001(_idx, 29 + _frame);
		setData(_idx, 29 + _frame, 7, 88, 8);
		setData(_idx, 34 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_306(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_305(_idx, 0 + _frame);
		setData(_idx, 34 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_307(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_308(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_309(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_310(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_301(_idx, 1 + _frame);
		setData(_idx, 29 + _frame, 7, 3, 8);
		setData(_idx, 34 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_311(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_312(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_313(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_314(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_CMD_001(_idx, 103 + _frame);
		setData(_idx, 103 + _frame, 7, 90, 8);
		setData(_idx, 108 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_315(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_314(_idx, 0 + _frame);
		setData(_idx, 108 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_316(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_317(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_318(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_319(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		setData(_idx, 39 + _frame, 7, 7, 8);
		setData(_idx, 44 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_320(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_321(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_322(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_323(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_CMD_001(_idx, 67 + _frame);
		setData(_idx, 67 + _frame, 7, 94, 8);
		setData(_idx, 72 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_324(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_323(_idx, 0 + _frame);
		setData(_idx, 72 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_325(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_326(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		setData(_idx, 1 + _frame, 6, 2, 8);
		setData(_idx, 11 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_327(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_328(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_329(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_MOT_GEAR_014(_idx, 1 + _frame);
		setData(_idx, 6 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_330(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_329(_idx, 0 + _frame);
		setData(_idx, 6 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_331(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_329(_idx, 0 + _frame);
		setData(_idx, 6 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_332(int _idx, int _frame)
	{
		_TEST_JYD_021(_idx, 0 + _frame);
		_TEST_JYD_009(_idx, 1 + _frame);
		_TEST_JYD_005(_idx, 25 + _frame);
		setData(_idx, 55 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_333(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_334(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		setData(_idx, 27 + _frame, 6, 3, 8);
		setData(_idx, 37 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_335(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_336(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_MOT_GEAR_010(_idx, 27 + _frame);
		_MOT_GEAR_020(_idx, 51 + _frame);
		setData(_idx, 53 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_337(int _idx, int _frame)
	{
		setData(_idx, 33 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_338(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_339(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_340(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_341(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_337(_idx, 1 + _frame);
		setData(_idx, 34 + _frame, 7, 3, 8);
		setData(_idx, 39 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_342(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_343(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_344(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_345(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_337(_idx, 1 + _frame);
		_GIMMICK_PTTERNS_032(_idx, 34 + _frame);
		setData(_idx, 61 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_346(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_347(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		setData(_idx, 1 + _frame, 6, 3, 8);
		setData(_idx, 11 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_348(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_349(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_MOT_GEAR_010(_idx, 1 + _frame);
		_MOT_GEAR_020(_idx, 25 + _frame);
		setData(_idx, 27 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_350(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_351(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		setData(_idx, 33 + _frame, 6, 3, 8);
		setData(_idx, 43 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_352(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_353(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_MOT_GEAR_010(_idx, 33 + _frame);
		_MOT_GEAR_020(_idx, 57 + _frame);
		setData(_idx, 59 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_354(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_355(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_356(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_065(_idx, 0 + _frame);
		setData(_idx, 2 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_357(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_358(int _idx, int _frame)
	{
		_TEST_JYD_021(_idx, 0 + _frame);
		_TEST_JYD_009(_idx, 1 + _frame);
		_TEST_JYD_005(_idx, 25 + _frame);
		setData(_idx, 55 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_359(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_358(_idx, 0 + _frame);
		setData(_idx, 55 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_360(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_358(_idx, 0 + _frame);
		setData(_idx, 55 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_361(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_358(_idx, 0 + _frame);
		setData(_idx, 55 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_362(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_358(_idx, 0 + _frame);
		setData(_idx, 55 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_363(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_364(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		setData(_idx, 1 + _frame, 6, 2, 8);
		setData(_idx, 11 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_365(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_366(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_367(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_368(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_364(_idx, 0 + _frame);
		setData(_idx, 11 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_369(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_370(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_371(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_372(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_364(_idx, 0 + _frame);
		setData(_idx, 11 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_373(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_374(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_375(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_376(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		setData(_idx, 3 + _frame, 6, 4, 8);
		setData(_idx, 13 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_377(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_378(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_379(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_380(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_376(_idx, 0 + _frame);
		setData(_idx, 13 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_381(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_382(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_383(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_384(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_376(_idx, 0 + _frame);
		setData(_idx, 13 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_385(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_386(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_387(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_388(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_364(_idx, 0 + _frame);
		setData(_idx, 11 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_389(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_390(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_391(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_392(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_025(_idx, 0 + _frame);
		setData(_idx, 11 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_393(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_394(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_395(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_396(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_392(_idx, 0 + _frame);
		setData(_idx, 11 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_397(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_398(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_399(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_400(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_027(_idx, 0 + _frame);
		setData(_idx, 11 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_401(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_402(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_403(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_404(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_405(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_406(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_043(_idx, 0 + _frame);
		setData(_idx, 6 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_407(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_408(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_409(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_410(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_MOT_GEAR_020(_idx, 1 + _frame);
		setData(_idx, 3 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_411(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_412(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_413(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_061(_idx, 33 + _frame);
		setData(_idx, 35 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_414(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_415(int _idx, int _frame)
	{
		setData(_idx, 67 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_416(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_417(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_418(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_419(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_415(_idx, 1 + _frame);
		setData(_idx, 68 + _frame, 7, 3, 8);
		setData(_idx, 73 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_420(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_421(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_422(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_423(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_419(_idx, 0 + _frame);
		setData(_idx, 73 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_424(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_425(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_426(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_427(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_419(_idx, 0 + _frame);
		setData(_idx, 73 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_428(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_429(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_415(_idx, 1 + _frame);
		setData(_idx, 68 + _frame, 6, 3, 8);
		setData(_idx, 78 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_430(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_431(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_415(_idx, 1 + _frame);
		_MOT_GEAR_010(_idx, 68 + _frame);
		_MOT_GEAR_020(_idx, 92 + _frame);
		setData(_idx, 94 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_432(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_433(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_429(_idx, 0 + _frame);
		setData(_idx, 78 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_434(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_435(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_431(_idx, 0 + _frame);
		setData(_idx, 94 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_436(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_437(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_429(_idx, 0 + _frame);
		setData(_idx, 78 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_438(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_439(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_431(_idx, 0 + _frame);
		setData(_idx, 94 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_440(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_441(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_415(_idx, 1 + _frame);
		setData(_idx, 68 + _frame, 6, 7, 8);
		setData(_idx, 78 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_442(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_443(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_415(_idx, 1 + _frame);
		setData(_idx, 68 + _frame, 7, 70, 8);
		_MOT_GEAR_020(_idx, 92 + _frame);
		setData(_idx, 94 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_444(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_445(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_441(_idx, 0 + _frame);
		setData(_idx, 78 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_446(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_447(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_443(_idx, 0 + _frame);
		setData(_idx, 94 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_448(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_449(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_450(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_451(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_419(_idx, 0 + _frame);
		setData(_idx, 73 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_452(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_453(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		setData(_idx, 1 + _frame, 6, 7, 8);
		setData(_idx, 11 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_454(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_455(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		setData(_idx, 1 + _frame, 7, 70, 8);
		_MOT_GEAR_020(_idx, 25 + _frame);
		setData(_idx, 27 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_456(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_457(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_453(_idx, 0 + _frame);
		setData(_idx, 11 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_458(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_459(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_455(_idx, 0 + _frame);
		setData(_idx, 27 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_460(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_461(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_453(_idx, 0 + _frame);
		setData(_idx, 11 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_462(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_463(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_455(_idx, 0 + _frame);
		setData(_idx, 27 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_464(int _idx, int _frame)
	{
		_TEST_JYD_021(_idx, 0 + _frame);
		_TEST_JYD_009(_idx, 1 + _frame);
		setData(_idx, 25 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_465(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_466(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_467(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_468(int _idx, int _frame)
	{
		_TEST_JYD_021(_idx, 0 + _frame);
		_TEST_JYD_005(_idx, 1 + _frame);
		setData(_idx, 31 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_469(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_029(_idx, 1 + _frame);
		setData(_idx, 12 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_470(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_471(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_032(_idx, 1 + _frame);
		setData(_idx, 28 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_472(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_473(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_474(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		setData(_idx, 23 + _frame, 6, 2, 8);
		setData(_idx, 33 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_475(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_476(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_477(int _idx, int _frame)
	{
		_CMD_002(_idx, 44 + _frame);
		setData(_idx, 65 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_478(int _idx, int _frame)
	{
		setData(_idx, 66 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_479(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_480(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_481(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_482(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_477(_idx, 1 + _frame);
		_GIMMICK_PTTERNS_041(_idx, 66 + _frame);
		setData(_idx, 72 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_483(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_484(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_485(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_486(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_477(_idx, 1 + _frame);
		_GIMMICK_PTTERNS_027(_idx, 66 + _frame);
		setData(_idx, 77 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_487(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_488(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_478(_idx, 1 + _frame);
		_GIMMICK_PTTERNS_031(_idx, 67 + _frame);
		setData(_idx, 94 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_489(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_490(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_491(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_492(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_477(_idx, 1 + _frame);
		_GIMMICK_PTTERNS_029(_idx, 66 + _frame);
		setData(_idx, 77 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_493(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_494(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_478(_idx, 1 + _frame);
		_GIMMICK_PTTERNS_032(_idx, 67 + _frame);
		setData(_idx, 94 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_495(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_496(int _idx, int _frame)
	{
		_CMD_002(_idx, 56 + _frame);
		setData(_idx, 77 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_497(int _idx, int _frame)
	{
		setData(_idx, 77 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_498(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_499(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_500(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_501(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_496(_idx, 1 + _frame);
		_GIMMICK_PTTERNS_041(_idx, 78 + _frame);
		setData(_idx, 84 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_502(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_503(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_504(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_505(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_496(_idx, 1 + _frame);
		_GIMMICK_PTTERNS_027(_idx, 78 + _frame);
		setData(_idx, 89 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_506(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_507(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_497(_idx, 1 + _frame);
		_GIMMICK_PTTERNS_031(_idx, 78 + _frame);
		setData(_idx, 105 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_508(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_509(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_510(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_511(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_496(_idx, 1 + _frame);
		_GIMMICK_PTTERNS_029(_idx, 78 + _frame);
		setData(_idx, 89 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_512(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_513(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_497(_idx, 1 + _frame);
		_GIMMICK_PTTERNS_032(_idx, 78 + _frame);
		setData(_idx, 105 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_514(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_515(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_MOT_GEAR_010(_idx, 10 + _frame);
		_MOT_GEAR_020(_idx, 34 + _frame);
		_CMD_002(_idx, 47 + _frame);
		setData(_idx, 47 + _frame, 7, 3, 8);
		setData(_idx, 52 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_516(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_026(_idx, 12 + _frame);
		setData(_idx, 23 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_517(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_026(_idx, 12 + _frame);
		setData(_idx, 132 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_518(int _idx, int _frame)
	{
		_CMD_002(_idx, 56 + _frame);
		setData(_idx, 120 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_519(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_520(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_516(_idx, 0 + _frame);
		setData(_idx, 23 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_521(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_522(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_518(_idx, 1 + _frame);
		_GIMMICK_PTTERNS_041(_idx, 121 + _frame);
		setData(_idx, 127 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_523(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_524(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_525(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_526(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_517(_idx, 1 + _frame);
		_GIMMICK_PTTERNS_027(_idx, 133 + _frame);
		setData(_idx, 144 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_527(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_528(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_518(_idx, 1 + _frame);
		_GIMMICK_PTTERNS_031(_idx, 121 + _frame);
		setData(_idx, 148 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_529(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_530(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_531(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_532(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_517(_idx, 1 + _frame);
		_GIMMICK_PTTERNS_029(_idx, 133 + _frame);
		setData(_idx, 144 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_533(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_534(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_518(_idx, 1 + _frame);
		_GIMMICK_PTTERNS_032(_idx, 121 + _frame);
		setData(_idx, 148 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_535(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_536(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_516(_idx, 0 + _frame);
		setData(_idx, 23 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_537(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_517(_idx, 0 + _frame);
		setData(_idx, 132 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_538(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_518(_idx, 0 + _frame);
		setData(_idx, 120 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_539(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_540(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_536(_idx, 0 + _frame);
		setData(_idx, 23 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_541(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_542(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_538(_idx, 1 + _frame);
		_GIMMICK_PTTERNS_041(_idx, 121 + _frame);
		setData(_idx, 127 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_543(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_544(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_545(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_546(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_537(_idx, 1 + _frame);
		_GIMMICK_PTTERNS_027(_idx, 133 + _frame);
		setData(_idx, 144 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_547(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_548(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_538(_idx, 1 + _frame);
		_GIMMICK_PTTERNS_031(_idx, 121 + _frame);
		setData(_idx, 148 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_549(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_550(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_551(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_552(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_537(_idx, 1 + _frame);
		_GIMMICK_PTTERNS_029(_idx, 133 + _frame);
		setData(_idx, 144 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_553(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_554(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_538(_idx, 1 + _frame);
		_GIMMICK_PTTERNS_032(_idx, 121 + _frame);
		setData(_idx, 148 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_555(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_556(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_516(_idx, 0 + _frame);
		setData(_idx, 23 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_557(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_517(_idx, 0 + _frame);
		setData(_idx, 132 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_558(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_518(_idx, 0 + _frame);
		setData(_idx, 120 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_559(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_560(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_556(_idx, 0 + _frame);
		setData(_idx, 23 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_561(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_562(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_558(_idx, 1 + _frame);
		_GIMMICK_PTTERNS_041(_idx, 121 + _frame);
		setData(_idx, 127 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_563(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_564(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_565(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_566(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_557(_idx, 1 + _frame);
		_GIMMICK_PTTERNS_027(_idx, 133 + _frame);
		setData(_idx, 144 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_567(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_568(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_558(_idx, 1 + _frame);
		_GIMMICK_PTTERNS_031(_idx, 121 + _frame);
		setData(_idx, 148 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_569(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_570(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_571(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_572(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_557(_idx, 1 + _frame);
		_GIMMICK_PTTERNS_029(_idx, 133 + _frame);
		setData(_idx, 144 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_573(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_574(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_558(_idx, 1 + _frame);
		_GIMMICK_PTTERNS_032(_idx, 121 + _frame);
		setData(_idx, 148 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_575(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_576(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_026(_idx, 28 + _frame);
		setData(_idx, 39 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_577(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_026(_idx, 28 + _frame);
		setData(_idx, 99 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_578(int _idx, int _frame)
	{
		_CMD_002(_idx, 82 + _frame);
		setData(_idx, 103 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_579(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_580(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_576(_idx, 0 + _frame);
		setData(_idx, 39 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_581(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_582(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_578(_idx, 1 + _frame);
		_GIMMICK_PTTERNS_041(_idx, 104 + _frame);
		setData(_idx, 110 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_583(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_584(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_585(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_586(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_577(_idx, 1 + _frame);
		_GIMMICK_PTTERNS_027(_idx, 100 + _frame);
		setData(_idx, 111 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_587(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_588(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_578(_idx, 1 + _frame);
		_GIMMICK_PTTERNS_031(_idx, 104 + _frame);
		setData(_idx, 131 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_589(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_590(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_591(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_592(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_577(_idx, 1 + _frame);
		_GIMMICK_PTTERNS_029(_idx, 100 + _frame);
		setData(_idx, 111 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_593(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_594(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_578(_idx, 1 + _frame);
		_GIMMICK_PTTERNS_032(_idx, 104 + _frame);
		setData(_idx, 131 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_595(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_596(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_026(_idx, 28 + _frame);
		setData(_idx, 39 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_597(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_026(_idx, 28 + _frame);
		setData(_idx, 110 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_598(int _idx, int _frame)
	{
		_CMD_002(_idx, 93 + _frame);
		setData(_idx, 114 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_599(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_600(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_596(_idx, 0 + _frame);
		setData(_idx, 39 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_601(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_602(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_598(_idx, 1 + _frame);
		_GIMMICK_PTTERNS_041(_idx, 115 + _frame);
		setData(_idx, 121 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_603(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_604(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_605(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_606(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_597(_idx, 1 + _frame);
		_GIMMICK_PTTERNS_027(_idx, 111 + _frame);
		setData(_idx, 122 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_607(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_608(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_598(_idx, 1 + _frame);
		_GIMMICK_PTTERNS_031(_idx, 115 + _frame);
		setData(_idx, 142 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_609(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_610(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_611(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_612(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_597(_idx, 1 + _frame);
		_GIMMICK_PTTERNS_029(_idx, 111 + _frame);
		setData(_idx, 122 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_613(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_614(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_598(_idx, 1 + _frame);
		_GIMMICK_PTTERNS_032(_idx, 115 + _frame);
		setData(_idx, 142 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_615(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_616(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_617(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_618(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_619(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_MOT_GEAR_007(_idx, 1 + _frame);
		setData(_idx, 6 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_620(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_621(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_028(_idx, 1 + _frame);
		setData(_idx, 12 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_622(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_623(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_624(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_625(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_626(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_627(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_628(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_629(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_029(_idx, 32 + _frame);
		setData(_idx, 43 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_630(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_631(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_032(_idx, 32 + _frame);
		setData(_idx, 59 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_632(int _idx, int _frame)
	{
		setData(_idx, 39 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_633(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_634(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_632(_idx, 1 + _frame);
		_GIMMICK_PTTERNS_029(_idx, 40 + _frame);
		setData(_idx, 51 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_635(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_636(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_632(_idx, 1 + _frame);
		_GIMMICK_PTTERNS_032(_idx, 40 + _frame);
		setData(_idx, 67 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_637(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_638(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_639(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_640(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_632(_idx, 1 + _frame);
		setData(_idx, 40 + _frame, 7, 3, 8);
		setData(_idx, 45 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_641(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_642(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_643(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_644(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_640(_idx, 0 + _frame);
		setData(_idx, 45 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_645(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_646(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_647(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_648(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_640(_idx, 0 + _frame);
		setData(_idx, 45 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_649(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_650(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_632(_idx, 1 + _frame);
		setData(_idx, 40 + _frame, 6, 3, 8);
		setData(_idx, 50 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_651(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_652(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_632(_idx, 1 + _frame);
		_MOT_GEAR_010(_idx, 40 + _frame);
		_MOT_GEAR_020(_idx, 64 + _frame);
		setData(_idx, 66 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_653(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_654(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_650(_idx, 0 + _frame);
		setData(_idx, 50 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_655(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_656(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_652(_idx, 0 + _frame);
		setData(_idx, 66 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_657(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_658(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_650(_idx, 0 + _frame);
		setData(_idx, 50 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_659(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_660(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_652(_idx, 0 + _frame);
		setData(_idx, 66 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_661(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_662(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_634(_idx, 0 + _frame);
		setData(_idx, 51 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_663(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_664(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_636(_idx, 0 + _frame);
		setData(_idx, 67 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_665(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_666(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_634(_idx, 0 + _frame);
		setData(_idx, 51 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_667(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_668(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_636(_idx, 0 + _frame);
		setData(_idx, 67 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_669(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_670(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_671(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_672(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_640(_idx, 0 + _frame);
		setData(_idx, 45 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_673(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_674(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_675(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_676(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_MOT_GEAR_007(_idx, 7 + _frame);
		setData(_idx, 12 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_677(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_678(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_679(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_680(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_MOT_GEAR_007(_idx, 5 + _frame);
		setData(_idx, 10 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_681(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_682(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_683(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_684(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		setData(_idx, 23 + _frame, 7, 3, 8);
		setData(_idx, 28 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_685(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 7, 3, 8);
		setData(_idx, 5 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_686(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_687(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_688(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_689(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_685(_idx, 23 + _frame);
		setData(_idx, 28 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_690(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_691(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_692(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_693(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_685(_idx, 34 + _frame);
		setData(_idx, 39 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_694(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_695(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_696(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_697(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_685(_idx, 47 + _frame);
		setData(_idx, 52 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_698(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 6, 3, 8);
		setData(_idx, 10 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_699(int _idx, int _frame)
	{
		_MOT_GEAR_010(_idx, 0 + _frame);
		_MOT_GEAR_020(_idx, 24 + _frame);
		setData(_idx, 26 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_700(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_701(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_698(_idx, 70 + _frame);
		setData(_idx, 80 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_702(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_703(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_699(_idx, 70 + _frame);
		setData(_idx, 96 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_704(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_705(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_698(_idx, 101 + _frame);
		setData(_idx, 111 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_706(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_707(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_699(_idx, 101 + _frame);
		setData(_idx, 127 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_708(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_709(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_698(_idx, 133 + _frame);
		setData(_idx, 143 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_710(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_711(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_699(_idx, 133 + _frame);
		setData(_idx, 159 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_712(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 6, 7, 8);
		setData(_idx, 10 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_713(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 7, 70, 8);
		_MOT_GEAR_020(_idx, 24 + _frame);
		setData(_idx, 26 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_714(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_715(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_712(_idx, 163 + _frame);
		setData(_idx, 173 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_716(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_717(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_713(_idx, 163 + _frame);
		setData(_idx, 189 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_718(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_719(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_712(_idx, 189 + _frame);
		setData(_idx, 199 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_720(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_721(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_713(_idx, 189 + _frame);
		setData(_idx, 215 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_722(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_723(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_712(_idx, 0 + _frame);
		setData(_idx, 10 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_724(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_725(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_713(_idx, 0 + _frame);
		setData(_idx, 26 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_726(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_727(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_728(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_729(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_685(_idx, 19 + _frame);
		setData(_idx, 24 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_730(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_731(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_026(_idx, 1 + _frame);
		setData(_idx, 12 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_732(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_733(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_734(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_735(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_736(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_737(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_738(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_739(int _idx, int _frame)
	{
		_MOT_ROT_008(_idx, 0 + _frame);
		setData(_idx, 1 + _frame, 9, 117, 8);
		setData(_idx, 82 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_740(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_741(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_742(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_026(_idx, 0 + _frame);
		setData(_idx, 11 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_743(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_744(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_745(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_746(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_747(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_748(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_749(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_750(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_751(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_752(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_060(_idx, 0 + _frame);
		setData(_idx, 2 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_753(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_754(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_755(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_756(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_757(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		setData(_idx, 15 + _frame, 7, 3, 8);
		setData(_idx, 20 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_758(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_759(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_760(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_761(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		setData(_idx, 15 + _frame, 6, 3, 8);
		setData(_idx, 25 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_762(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_763(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_MOT_GEAR_010(_idx, 15 + _frame);
		_MOT_GEAR_020(_idx, 39 + _frame);
		setData(_idx, 41 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_764(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_765(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_766(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_767(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		setData(_idx, 15 + _frame, 6, 7, 8);
		setData(_idx, 25 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_768(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_769(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		setData(_idx, 15 + _frame, 7, 70, 8);
		_MOT_GEAR_020(_idx, 39 + _frame);
		setData(_idx, 41 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_770(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_771(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_772(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_773(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_774(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_775(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		setData(_idx, 15 + _frame, 7, 3, 8);
		setData(_idx, 20 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_776(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_777(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_778(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_779(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		setData(_idx, 15 + _frame, 6, 3, 8);
		setData(_idx, 25 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_780(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_781(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_MOT_GEAR_010(_idx, 15 + _frame);
		_MOT_GEAR_020(_idx, 39 + _frame);
		setData(_idx, 41 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_782(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_783(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_784(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_785(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		setData(_idx, 15 + _frame, 6, 7, 8);
		setData(_idx, 25 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_786(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_787(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		setData(_idx, 15 + _frame, 7, 70, 8);
		_MOT_GEAR_020(_idx, 39 + _frame);
		setData(_idx, 41 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_788(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_789(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_790(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_791(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_792(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_793(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		setData(_idx, 1 + _frame, 7, 5, 8);
		setData(_idx, 27 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_794(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_795(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_796(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_797(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_MOT_GEAR_018(_idx, 1 + _frame);
		setData(_idx, 5 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_798(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_799(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_800(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_801(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_MOT_GEAR_015(_idx, 1 + _frame);
		setData(_idx, 5 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_802(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_803(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_804(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_805(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		setData(_idx, 1 + _frame, 7, 5, 8);
		_MOT_GEAR_020(_idx, 25 + _frame);
		setData(_idx, 27 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_806(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_807(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_808(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_809(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_805(_idx, 0 + _frame);
		setData(_idx, 27 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_810(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_811(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_812(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_813(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_MOT_GEAR_018(_idx, 1 + _frame);
		setData(_idx, 5 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_814(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_815(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_816(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_817(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_MOT_GEAR_016(_idx, 1 + _frame);
		setData(_idx, 9 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_818(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_819(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_820(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_821(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		setData(_idx, 1 + _frame, 7, 5, 8);
		_MOT_GEAR_020(_idx, 25 + _frame);
		setData(_idx, 27 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_822(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_823(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_824(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_825(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_821(_idx, 0 + _frame);
		setData(_idx, 27 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_826(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_827(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_828(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_829(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_793(_idx, 0 + _frame);
		setData(_idx, 27 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_830(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_831(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_832(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_833(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		setData(_idx, 1 + _frame, 7, 3, 8);
		setData(_idx, 6 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_834(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_835(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		setData(_idx, 60 + _frame, 6, 4, 8);
		setData(_idx, 70 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_836(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_837(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_838(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_839(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		setData(_idx, 8 + _frame, 6, 3, 8);
		setData(_idx, 18 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_840(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_841(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_MOT_GEAR_010(_idx, 8 + _frame);
		_MOT_GEAR_020(_idx, 32 + _frame);
		setData(_idx, 34 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_842(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_843(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_844(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_845(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		setData(_idx, 1 + _frame, 7, 3, 8);
		setData(_idx, 6 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_846(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_847(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_848(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_849(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_032(_idx, 1 + _frame);
		setData(_idx, 28 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_850(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_851(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_852(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_201(_idx, 0 + _frame);
		setData(_idx, 44 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_853(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_854(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_855(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_856(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_205(_idx, 0 + _frame);
		setData(_idx, 25 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_857(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_858(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_859(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_860(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_861(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_862(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_211(_idx, 0 + _frame);
		setData(_idx, 8 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_863(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_864(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_865(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_866(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_215(_idx, 0 + _frame);
		setData(_idx, 8 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_867(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_868(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_869(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_870(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_219(_idx, 0 + _frame);
		setData(_idx, 6 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_871(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_872(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_873(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_874(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_223(_idx, 0 + _frame);
		setData(_idx, 51 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_875(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_876(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_877(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_878(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_227(_idx, 0 + _frame);
		setData(_idx, 6 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_879(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_880(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_881(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_882(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_231(_idx, 0 + _frame);
		setData(_idx, 164 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_883(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_884(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_885(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_886(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_235(_idx, 0 + _frame);
		setData(_idx, 6 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_887(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_888(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_889(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_890(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_239(_idx, 0 + _frame);
		setData(_idx, 99 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_891(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_892(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_893(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_894(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_895(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_244(_idx, 0 + _frame);
		setData(_idx, 19 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_896(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_897(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_898(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_899(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_249(_idx, 0 + _frame);
		setData(_idx, 58 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_900(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_901(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_902(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_903(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_904(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_254(_idx, 0 + _frame);
		setData(_idx, 103 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_905(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_255(_idx, 0 + _frame);
		setData(_idx, 103 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_906(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_907(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_908(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_909(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_910(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_911(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_264(_idx, 0 + _frame);
		setData(_idx, 53 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_912(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_913(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_914(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_915(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_268(_idx, 0 + _frame);
		setData(_idx, 110 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_916(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_917(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_918(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_919(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_920(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_921(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_274(_idx, 0 + _frame);
		setData(_idx, 8 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_922(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_923(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_924(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_925(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_278(_idx, 0 + _frame);
		setData(_idx, 6 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_926(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_927(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_928(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_929(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_282(_idx, 0 + _frame);
		setData(_idx, 160 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_930(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_931(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_932(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_933(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_934(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_287(_idx, 0 + _frame);
		setData(_idx, 156 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_935(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_936(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_937(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_290(_idx, 0 + _frame);
		setData(_idx, 50 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_938(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_939(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_940(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_941(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_942(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_943(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_MOT_GEAR_017(_idx, 5 + _frame);
		setData(_idx, 10 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_944(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_945(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_946(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_947(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_MOT_GEAR_017(_idx, 5 + _frame);
		setData(_idx, 10 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_948(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_949(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_950(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_951(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_CMD_001(_idx, 27 + _frame);
		setData(_idx, 27 + _frame, 7, 88, 8);
		setData(_idx, 32 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_952(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_953(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_954(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_955(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_956(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		setData(_idx, 27 + _frame, 7, 3, 8);
		setData(_idx, 32 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_957(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_958(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_959(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_960(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_CMD_001(_idx, 109 + _frame);
		setData(_idx, 109 + _frame, 7, 90, 8);
		setData(_idx, 114 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_961(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_962(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_963(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_964(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_965(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_319(_idx, 0 + _frame);
		setData(_idx, 44 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_966(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_967(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_968(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_969(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_CMD_001(_idx, 162 + _frame);
		setData(_idx, 162 + _frame, 7, 94, 8);
		setData(_idx, 167 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_970(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_971(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_972(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_973(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_974(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_975(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_201(_idx, 0 + _frame);
		setData(_idx, 44 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_976(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_977(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_978(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_979(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_205(_idx, 0 + _frame);
		setData(_idx, 25 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_980(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_981(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_982(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_983(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_984(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_985(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_211(_idx, 0 + _frame);
		setData(_idx, 8 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_986(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_987(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_988(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_989(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_215(_idx, 0 + _frame);
		setData(_idx, 8 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_990(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_991(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_992(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_993(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_219(_idx, 0 + _frame);
		setData(_idx, 6 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_994(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_995(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_996(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_997(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_223(_idx, 0 + _frame);
		setData(_idx, 51 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_998(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_999(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1000(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1001(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_227(_idx, 0 + _frame);
		setData(_idx, 6 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1002(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1003(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1004(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1005(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_231(_idx, 0 + _frame);
		setData(_idx, 164 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1006(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1007(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1008(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1009(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1010(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_239(_idx, 0 + _frame);
		setData(_idx, 99 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1011(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1012(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1013(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1014(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1015(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_244(_idx, 0 + _frame);
		setData(_idx, 19 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1016(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1017(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1018(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1019(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_249(_idx, 0 + _frame);
		setData(_idx, 58 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1020(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1021(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1022(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1023(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1024(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_254(_idx, 0 + _frame);
		setData(_idx, 103 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1025(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1026(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1027(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1028(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1029(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1030(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1031(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_264(_idx, 0 + _frame);
		setData(_idx, 53 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1032(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1033(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1034(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1035(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_268(_idx, 0 + _frame);
		setData(_idx, 110 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1036(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1037(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1038(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1039(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1040(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1041(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_274(_idx, 0 + _frame);
		setData(_idx, 8 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1042(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1043(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1044(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1045(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_278(_idx, 0 + _frame);
		setData(_idx, 6 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1046(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1047(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1048(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1049(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_282(_idx, 0 + _frame);
		setData(_idx, 160 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1050(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1051(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1052(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1053(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1054(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_287(_idx, 0 + _frame);
		setData(_idx, 156 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1055(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1056(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1057(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_290(_idx, 0 + _frame);
		setData(_idx, 50 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1058(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1059(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1060(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1061(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1062(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1063(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_MOT_GEAR_017(_idx, 5 + _frame);
		setData(_idx, 10 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1064(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1065(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1066(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1067(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_MOT_GEAR_017(_idx, 5 + _frame);
		setData(_idx, 10 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1068(int _idx, int _frame)
	{
		setData(_idx, 31 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1069(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1070(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1071(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1072(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_1068(_idx, 1 + _frame);
		_CMD_001(_idx, 32 + _frame);
		setData(_idx, 32 + _frame, 7, 88, 8);
		setData(_idx, 37 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1073(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1074(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1075(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1076(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1077(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_1068(_idx, 1 + _frame);
		setData(_idx, 32 + _frame, 7, 3, 8);
		setData(_idx, 37 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1078(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1079(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1080(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1081(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_CMD_001(_idx, 137 + _frame);
		setData(_idx, 137 + _frame, 7, 90, 8);
		setData(_idx, 142 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1082(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1083(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1084(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1085(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1086(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_319(_idx, 0 + _frame);
		setData(_idx, 44 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1087(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1088(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1089(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1090(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_CMD_001(_idx, 48 + _frame);
		setData(_idx, 48 + _frame, 7, 94, 8);
		setData(_idx, 53 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1091(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1092(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1093(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1094(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1095(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1096(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_201(_idx, 0 + _frame);
		setData(_idx, 44 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1097(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1098(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1099(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1100(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_205(_idx, 0 + _frame);
		setData(_idx, 25 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1101(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1102(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1103(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1104(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1105(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1106(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_211(_idx, 0 + _frame);
		setData(_idx, 8 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1107(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1108(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1109(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1110(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_215(_idx, 0 + _frame);
		setData(_idx, 8 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1111(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1112(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1113(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1114(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_219(_idx, 0 + _frame);
		setData(_idx, 6 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1115(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1116(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1117(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1118(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_223(_idx, 0 + _frame);
		setData(_idx, 51 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1119(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1120(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1121(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1122(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_227(_idx, 0 + _frame);
		setData(_idx, 6 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1123(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1124(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1125(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1126(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_231(_idx, 0 + _frame);
		setData(_idx, 164 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1127(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1128(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1129(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1130(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1131(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_239(_idx, 0 + _frame);
		setData(_idx, 99 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1132(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1133(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1134(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1135(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1136(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_244(_idx, 0 + _frame);
		setData(_idx, 19 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1137(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1138(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1139(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1140(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_249(_idx, 0 + _frame);
		setData(_idx, 58 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1141(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1142(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1143(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1144(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1145(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_254(_idx, 0 + _frame);
		setData(_idx, 103 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1146(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1147(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1148(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1149(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1150(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1151(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1152(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_264(_idx, 0 + _frame);
		setData(_idx, 53 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1153(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1154(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1155(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1156(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_268(_idx, 0 + _frame);
		setData(_idx, 110 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1157(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1158(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1159(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1160(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1161(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1162(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_274(_idx, 0 + _frame);
		setData(_idx, 8 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1163(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1164(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1165(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1166(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_278(_idx, 0 + _frame);
		setData(_idx, 6 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1167(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1168(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1169(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1170(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_282(_idx, 0 + _frame);
		setData(_idx, 160 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1171(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1172(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1173(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1174(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1175(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_287(_idx, 0 + _frame);
		setData(_idx, 156 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1176(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1177(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1178(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_290(_idx, 0 + _frame);
		setData(_idx, 50 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1179(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1180(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1181(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1182(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1183(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1184(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_MOT_GEAR_017(_idx, 5 + _frame);
		setData(_idx, 10 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1185(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1186(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1187(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1188(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_MOT_GEAR_017(_idx, 5 + _frame);
		setData(_idx, 10 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1189(int _idx, int _frame)
	{
		setData(_idx, 30 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1190(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1191(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1192(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1193(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_1189(_idx, 1 + _frame);
		_CMD_001(_idx, 31 + _frame);
		setData(_idx, 31 + _frame, 7, 88, 8);
		setData(_idx, 36 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1194(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1195(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1196(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1197(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1198(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_1189(_idx, 1 + _frame);
		setData(_idx, 31 + _frame, 7, 3, 8);
		setData(_idx, 36 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1199(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1200(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1201(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1202(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		setData(_idx, 113 + _frame, 7, 90, 8);
		setData(_idx, 118 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1203(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1204(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1205(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1206(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1207(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_319(_idx, 0 + _frame);
		setData(_idx, 44 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1208(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1209(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1210(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1211(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_CMD_001(_idx, 128 + _frame);
		setData(_idx, 128 + _frame, 7, 94, 8);
		setData(_idx, 133 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1212(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1213(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1214(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1215(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1216(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1217(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_290(_idx, 0 + _frame);
		setData(_idx, 50 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1218(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1219(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1220(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1221(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1222(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1223(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_274(_idx, 0 + _frame);
		setData(_idx, 8 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1224(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1225(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1226(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1227(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_282(_idx, 0 + _frame);
		setData(_idx, 160 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1228(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1229(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1230(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		setData(_idx, 1 + _frame, 6, 2, 8);
		setData(_idx, 11 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1231(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1232(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1233(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1234(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1235(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1236(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		setData(_idx, 38 + _frame, 7, 2, 8);
		setData(_idx, 43 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1237(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1238(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1239(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1240(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		setData(_idx, 38 + _frame, 6, 3, 8);
		setData(_idx, 48 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1241(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1242(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_MOT_GEAR_010(_idx, 38 + _frame);
		_MOT_GEAR_020(_idx, 62 + _frame);
		setData(_idx, 64 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1243(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1244(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1245(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1246(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		setData(_idx, 38 + _frame, 6, 7, 8);
		setData(_idx, 48 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1247(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1248(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		setData(_idx, 38 + _frame, 7, 70, 8);
		_MOT_GEAR_020(_idx, 62 + _frame);
		setData(_idx, 64 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1249(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1250(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1251(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		setData(_idx, 1 + _frame, 6, 4, 8);
		setData(_idx, 11 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1252(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1253(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1254(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1255(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1256(int _idx, int _frame)
	{
		_MOT_ROT_008(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_067(_idx, 1 + _frame);
		setData(_idx, 3 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1257(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_034(_idx, 1 + _frame);
		setData(_idx, 28 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1258(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1259(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1260(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1261(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1262(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1263(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1264(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1265(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1266(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1267(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1268(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1269(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_034(_idx, 81 + _frame);
		setData(_idx, 108 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1270(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1271(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1272(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1273(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1274(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1275(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1276(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_027(_idx, 8 + _frame);
		setData(_idx, 19 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1277(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1278(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_031(_idx, 8 + _frame);
		setData(_idx, 35 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1279(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1280(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1281(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1282(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		setData(_idx, 1 + _frame, 7, 3, 8);
		setData(_idx, 6 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1283(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1284(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1285(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1286(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_032(_idx, 1 + _frame);
		setData(_idx, 28 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1287(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1288(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		setData(_idx, 1 + _frame, 6, 3, 8);
		setData(_idx, 11 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1289(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1290(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_MOT_GEAR_010(_idx, 1 + _frame);
		_MOT_GEAR_020(_idx, 25 + _frame);
		setData(_idx, 27 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1291(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1292(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1293(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1294(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_061(_idx, 0 + _frame);
		setData(_idx, 2 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1295(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		setData(_idx, 82 + _frame, 7, 86, 8);
		_MOT_GEAR_020(_idx, 130 + _frame);
		setData(_idx, 132 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1296(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1297(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		setData(_idx, 78 + _frame, 6, 50, 8);
		setData(_idx, 88 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1298(int _idx, int _frame)
	{
		_MOT_ROT_008(_idx, 0 + _frame);
		setData(_idx, 78 + _frame, 9, 54, 8);
		setData(_idx, 83 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1299(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		setData(_idx, 78 + _frame, 7, 54, 8);
		setData(_idx, 83 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1300(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1301(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1302(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		setData(_idx, 1 + _frame, 6, 2, 8);
		setData(_idx, 11 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1303(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1304(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1305(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1306(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1307(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1308(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		setData(_idx, 69 + _frame, 7, 70, 8);
		_MOT_GEAR_020(_idx, 93 + _frame);
		setData(_idx, 95 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1309(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1310(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1311(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1312(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		setData(_idx, 97 + _frame, 7, 70, 8);
		_MOT_GEAR_020(_idx, 121 + _frame);
		setData(_idx, 123 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1313(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1314(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1315(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1316(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		setData(_idx, 20 + _frame, 7, 70, 8);
		_MOT_GEAR_020(_idx, 44 + _frame);
		setData(_idx, 46 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1317(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1318(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1319(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1320(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1316(_idx, 0 + _frame);
		setData(_idx, 46 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1321(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1322(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1323(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1324(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1316(_idx, 0 + _frame);
		setData(_idx, 46 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1325(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1326(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1327(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1328(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1316(_idx, 0 + _frame);
		setData(_idx, 46 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1329(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1330(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1331(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1332(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1316(_idx, 0 + _frame);
		setData(_idx, 46 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1333(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1334(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1335(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1336(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1337(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1338(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_061(_idx, 0 + _frame);
		setData(_idx, 2 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1339(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1340(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1341(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1342(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1343(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		setData(_idx, 1 + _frame, 7, 70, 8);
		_MOT_GEAR_020(_idx, 25 + _frame);
		setData(_idx, 27 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1344(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1345(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1346(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1347(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		setData(_idx, 1 + _frame, 7, 70, 8);
		_MOT_GEAR_020(_idx, 25 + _frame);
		setData(_idx, 27 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1348(int _idx, int _frame)
	{
		setData(_idx, 6 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1349(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1350(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1351(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1352(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_1348(_idx, 1 + _frame);
		_GIMMICK_PTTERNS_032(_idx, 7 + _frame);
		setData(_idx, 34 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1353(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1354(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1355(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1356(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_1348(_idx, 1 + _frame);
		_GIMMICK_PTTERNS_033(_idx, 7 + _frame);
		setData(_idx, 34 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1357(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1358(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1359(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1360(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_1348(_idx, 1 + _frame);
		_GIMMICK_PTTERNS_034(_idx, 7 + _frame);
		setData(_idx, 34 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1361(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1362(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1363(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1364(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_035(_idx, 1 + _frame);
		setData(_idx, 28 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1365(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1366(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1367(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1368(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_031(_idx, 1 + _frame);
		setData(_idx, 28 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1369(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1370(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_026(_idx, 44 + _frame);
		setData(_idx, 55 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1371(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1372(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1373(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1374(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 6, 5, 8);
		setData(_idx, 11 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1375(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 9, 7, 8);
		setData(_idx, 6 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1376(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 7, 7, 8);
		setData(_idx, 6 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1377(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1378(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 6, 1, 8);
		setData(_idx, 11 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1379(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1380(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1381(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1382(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 6, 2, 8);
		setData(_idx, 11 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1383(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1384(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_034(_idx, 61 + _frame);
		setData(_idx, 88 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1385(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1386(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1387(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1388(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_041(_idx, 60 + _frame);
		setData(_idx, 66 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1389(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1390(int _idx, int _frame)
	{
		setData(_idx, 72 + _frame, 6, 5, 8);
		setData(_idx, 83 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1391(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1392(int _idx, int _frame)
	{
		setData(_idx, 72 + _frame, 7, 8, 8);
		setData(_idx, 78 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1393(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1394(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_026(_idx, 0 + _frame);
		setData(_idx, 11 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1395(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_061(_idx, 0 + _frame);
		setData(_idx, 2 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1396(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1397(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1398(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1399(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1400(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_035(_idx, 1 + _frame);
		setData(_idx, 28 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1401(int _idx, int _frame)
	{
		_TEST_JYD_021(_idx, 0 + _frame);
		_TEST_JYD_009(_idx, 1 + _frame);
		_TEST_JYD_005(_idx, 77 + _frame);
		setData(_idx, 107 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1402(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1403(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1404(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1405(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1406(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1407(int _idx, int _frame)
	{
		_MOT_ROT_008(_idx, 0 + _frame);
		_MOT_ROT_002(_idx, 1 + _frame);
		setData(_idx, 64 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1408(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1409(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1410(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1411(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1412(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_MOT_GEAR_010(_idx, 1 + _frame);
		_MOT_GEAR_020(_idx, 25 + _frame);
		setData(_idx, 27 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1413(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1414(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1415(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1416(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1412(_idx, 0 + _frame);
		setData(_idx, 27 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1417(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1418(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1419(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 9, 101, 8);
		setData(_idx, 104 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1420(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1421(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1422(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1423(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 9, 101, 8);
		setData(_idx, 104 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1424(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1425(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1426(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1427(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 9, 103, 8);
		setData(_idx, 59 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1428(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1429(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1430(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1431(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 9, 107, 8);
		setData(_idx, 104 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1432(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1433(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1434(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1435(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 9, 105, 8);
		setData(_idx, 67 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1436(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1437(int _idx, int _frame)
	{
		_TEST_JYD_009(_idx, 0 + _frame);
		_TEST_JYD_015(_idx, 24 + _frame);
		_TEST_JYD_005(_idx, 118 + _frame);
		setData(_idx, 148 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1438(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1439(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1423(_idx, 40 + _frame);
		setData(_idx, 144 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1440(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1441(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1437(_idx, 0 + _frame);
		setData(_idx, 148 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1442(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1443(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1431(_idx, 40 + _frame);
		setData(_idx, 144 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1444(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1445(int _idx, int _frame)
	{
		setData(_idx, 90 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1446(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1447(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1445(_idx, 0 + _frame);
		setData(_idx, 90 + _frame, 6, 7, 8);
		setData(_idx, 100 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1448(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1423(_idx, 0 + _frame);
		setData(_idx, 104 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1449(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1445(_idx, 0 + _frame);
		setData(_idx, 90 + _frame, 7, 70, 8);
		_MOT_GEAR_020(_idx, 114 + _frame);
		setData(_idx, 116 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1450(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1451(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1452(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1423(_idx, 0 + _frame);
		setData(_idx, 104 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1453(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1445(_idx, 0 + _frame);
		setData(_idx, 90 + _frame, 7, 3, 8);
		setData(_idx, 95 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1454(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1455(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1456(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1452(_idx, 0 + _frame);
		setData(_idx, 104 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1457(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1453(_idx, 0 + _frame);
		setData(_idx, 95 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1458(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1459(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1460(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1452(_idx, 0 + _frame);
		setData(_idx, 104 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1461(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1453(_idx, 0 + _frame);
		setData(_idx, 95 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1462(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1463(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1445(_idx, 0 + _frame);
		setData(_idx, 90 + _frame, 6, 3, 8);
		setData(_idx, 100 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1464(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1423(_idx, 0 + _frame);
		setData(_idx, 104 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1465(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1445(_idx, 0 + _frame);
		_MOT_GEAR_010(_idx, 90 + _frame);
		_MOT_GEAR_020(_idx, 114 + _frame);
		setData(_idx, 116 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1466(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1467(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1463(_idx, 0 + _frame);
		setData(_idx, 100 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1468(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1464(_idx, 0 + _frame);
		setData(_idx, 104 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1469(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1465(_idx, 0 + _frame);
		setData(_idx, 116 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1470(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1471(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1463(_idx, 0 + _frame);
		setData(_idx, 100 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1472(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1464(_idx, 0 + _frame);
		setData(_idx, 104 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1473(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1465(_idx, 0 + _frame);
		setData(_idx, 116 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1474(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1475(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1445(_idx, 0 + _frame);
		setData(_idx, 90 + _frame, 6, 7, 8);
		setData(_idx, 100 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1476(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1423(_idx, 0 + _frame);
		setData(_idx, 104 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1477(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1445(_idx, 0 + _frame);
		setData(_idx, 90 + _frame, 7, 70, 8);
		_MOT_GEAR_020(_idx, 114 + _frame);
		setData(_idx, 116 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1478(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1479(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1475(_idx, 0 + _frame);
		setData(_idx, 100 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1480(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1476(_idx, 0 + _frame);
		setData(_idx, 104 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1481(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1477(_idx, 0 + _frame);
		setData(_idx, 116 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1482(int _idx, int _frame)
	{
		setData(_idx, 149 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1483(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1437(_idx, 0 + _frame);
		setData(_idx, 148 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1484(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1482(_idx, 0 + _frame);
		setData(_idx, 149 + _frame, 6, 3, 8);
		setData(_idx, 159 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1485(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1423(_idx, 40 + _frame);
		setData(_idx, 144 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1486(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1482(_idx, 0 + _frame);
		_MOT_GEAR_010(_idx, 149 + _frame);
		_MOT_GEAR_020(_idx, 173 + _frame);
		setData(_idx, 175 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1487(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1483(_idx, 0 + _frame);
		setData(_idx, 148 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1488(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1484(_idx, 0 + _frame);
		setData(_idx, 159 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1489(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1485(_idx, 0 + _frame);
		setData(_idx, 144 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1490(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1486(_idx, 0 + _frame);
		setData(_idx, 175 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1491(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1483(_idx, 0 + _frame);
		setData(_idx, 148 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1492(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1484(_idx, 0 + _frame);
		setData(_idx, 159 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1493(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1485(_idx, 0 + _frame);
		setData(_idx, 144 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1494(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1486(_idx, 0 + _frame);
		setData(_idx, 175 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1495(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1483(_idx, 0 + _frame);
		setData(_idx, 148 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1496(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1482(_idx, 0 + _frame);
		setData(_idx, 149 + _frame, 6, 7, 8);
		setData(_idx, 159 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1497(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1485(_idx, 0 + _frame);
		setData(_idx, 144 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1498(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1482(_idx, 0 + _frame);
		setData(_idx, 149 + _frame, 7, 70, 8);
		_MOT_GEAR_020(_idx, 173 + _frame);
		setData(_idx, 175 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1499(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1495(_idx, 0 + _frame);
		setData(_idx, 148 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1500(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1496(_idx, 0 + _frame);
		setData(_idx, 159 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1501(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1497(_idx, 0 + _frame);
		setData(_idx, 144 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1502(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1498(_idx, 0 + _frame);
		setData(_idx, 175 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1503(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1504(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1505(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1506(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1507(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1508(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1509(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1510(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 9, 102, 8);
		setData(_idx, 55 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1511(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1512(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1513(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1514(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 9, 104, 8);
		setData(_idx, 63 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1515(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1516(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1517(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1518(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 9, 106, 8);
		setData(_idx, 71 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1519(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1520(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1521(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1522(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 9, 108, 8);
		setData(_idx, 80 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1523(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1524(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1525(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1526(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1527(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1528(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1529(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1530(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1531(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1532(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1533(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1534(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1535(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1536(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		setData(_idx, 1 + _frame, 7, 70, 8);
		_MOT_GEAR_020(_idx, 25 + _frame);
		setData(_idx, 27 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1537(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1538(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1539(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1540(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_032(_idx, 8 + _frame);
		setData(_idx, 35 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1541(int _idx, int _frame)
	{
		_TEST_JYD_021(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_014(_idx, 100 + _frame);
		setData(_idx, 125 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1542(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1543(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1544(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1545(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1546(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1547(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1548(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1549(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1550(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1551(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1552(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_031(_idx, 0 + _frame);
		setData(_idx, 27 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1553(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1554(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1555(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1556(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_032(_idx, 0 + _frame);
		setData(_idx, 27 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1557(int _idx, int _frame)
	{
		_TEST_JYD_021(_idx, 0 + _frame);
		_TEST_JYD_005(_idx, 1 + _frame);
		setData(_idx, 31 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1558(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1559(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1560(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_041(_idx, 19 + _frame);
		setData(_idx, 25 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1561(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1557(_idx, 0 + _frame);
		setData(_idx, 31 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1562(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1563(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1564(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1560(_idx, 0 + _frame);
		setData(_idx, 25 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1565(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1557(_idx, 0 + _frame);
		setData(_idx, 31 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1566(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1567(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1568(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1560(_idx, 0 + _frame);
		setData(_idx, 25 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1569(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1557(_idx, 0 + _frame);
		setData(_idx, 31 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1570(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_027(_idx, 19 + _frame);
		setData(_idx, 30 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1571(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1572(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_031(_idx, 19 + _frame);
		setData(_idx, 46 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1573(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1569(_idx, 0 + _frame);
		setData(_idx, 31 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1574(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1570(_idx, 0 + _frame);
		setData(_idx, 30 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1575(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1576(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1572(_idx, 0 + _frame);
		setData(_idx, 46 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1577(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1569(_idx, 0 + _frame);
		setData(_idx, 31 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1578(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1570(_idx, 0 + _frame);
		setData(_idx, 30 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1579(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1580(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1572(_idx, 0 + _frame);
		setData(_idx, 46 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1581(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1557(_idx, 0 + _frame);
		setData(_idx, 31 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1582(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_029(_idx, 19 + _frame);
		setData(_idx, 30 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1583(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1584(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_032(_idx, 19 + _frame);
		setData(_idx, 46 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1585(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1581(_idx, 0 + _frame);
		setData(_idx, 31 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1586(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1582(_idx, 0 + _frame);
		setData(_idx, 30 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1587(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1588(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1584(_idx, 0 + _frame);
		setData(_idx, 46 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1589(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1590(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_029(_idx, 13 + _frame);
		setData(_idx, 24 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1591(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1592(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_032(_idx, 13 + _frame);
		setData(_idx, 40 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1593(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1594(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1595(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_029(_idx, 13 + _frame);
		setData(_idx, 24 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1596(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1597(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_032(_idx, 13 + _frame);
		setData(_idx, 40 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1598(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1599(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1600(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		setData(_idx, 1 + _frame, 6, 1, 8);
		setData(_idx, 11 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1601(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1602(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1603(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1604(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		setData(_idx, 1 + _frame, 6, 3, 8);
		setData(_idx, 11 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1605(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1606(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1607(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1608(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1609(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1610(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1611(int _idx, int _frame)
	{
		_TEST_JYD_021(_idx, 0 + _frame);
		setData(_idx, 1 + _frame, 8, 2, 8);
		setData(_idx, 33 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1612(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1613(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1614(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1615(int _idx, int _frame)
	{
		_TEST_JYD_021(_idx, 0 + _frame);
		setData(_idx, 1 + _frame, 8, 2, 8);
		setData(_idx, 31 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1616(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1617(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1618(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1619(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1620(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1621(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1622(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		setData(_idx, 1 + _frame, 7, 2, 8);
		setData(_idx, 6 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1623(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1624(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1625(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1626(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		setData(_idx, 1 + _frame, 7, 5, 8);
		setData(_idx, 6 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1627(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1628(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1629(int _idx, int _frame)
	{
		_MOT_ROT_008(_idx, 0 + _frame);
		setData(_idx, 2 + _frame, 9, 2, 8);
		setData(_idx, 7 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1630(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1631(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1632(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1633(int _idx, int _frame)
	{
		_MOT_ROT_008(_idx, 0 + _frame);
		setData(_idx, 2 + _frame, 9, 5, 8);
		setData(_idx, 7 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1634(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1635(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1636(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1637(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1638(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_MOT_GEAR_014(_idx, 1 + _frame);
		setData(_idx, 6 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1639(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1640(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1641(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1642(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_MOT_GEAR_016(_idx, 1 + _frame);
		setData(_idx, 9 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1643(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1644(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1645(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1646(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_MOT_GEAR_017(_idx, 1 + _frame);
		setData(_idx, 6 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1647(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1648(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1649(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1650(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_MOT_GEAR_019(_idx, 1 + _frame);
		setData(_idx, 9 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1651(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1652(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1653(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1654(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_041(_idx, 0 + _frame);
		setData(_idx, 6 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1655(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1656(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_027(_idx, 0 + _frame);
		setData(_idx, 11 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1657(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1658(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_031(_idx, 0 + _frame);
		setData(_idx, 27 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1659(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1660(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_029(_idx, 0 + _frame);
		setData(_idx, 11 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1661(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1662(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_032(_idx, 0 + _frame);
		setData(_idx, 27 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1663(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1664(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1665(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1666(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_MOT_GEAR_020(_idx, 1 + _frame);
		setData(_idx, 3 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1667(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1668(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1669(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1670(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_032(_idx, 58 + _frame);
		setData(_idx, 85 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1671(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1672(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1673(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1674(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_034(_idx, 58 + _frame);
		setData(_idx, 85 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1675(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1676(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1677(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1678(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_MOT_GEAR_020(_idx, 1 + _frame);
		setData(_idx, 3 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1679(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1680(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1681(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1682(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_MOT_GEAR_020(_idx, 1 + _frame);
		setData(_idx, 3 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1683(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1684(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1685(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1686(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_032(_idx, 69 + _frame);
		setData(_idx, 96 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1687(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1688(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1689(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1690(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_MOT_GEAR_020(_idx, 1 + _frame);
		setData(_idx, 3 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1691(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1692(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_027(_idx, 110 + _frame);
		setData(_idx, 121 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1693(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1694(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_031(_idx, 110 + _frame);
		setData(_idx, 137 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1695(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1696(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_027(_idx, 95 + _frame);
		setData(_idx, 106 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1697(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1698(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_031(_idx, 95 + _frame);
		setData(_idx, 122 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1699(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1700(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_027(_idx, 95 + _frame);
		setData(_idx, 106 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1701(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1702(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_031(_idx, 95 + _frame);
		setData(_idx, 122 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1703(int _idx, int _frame)
	{
		setData(_idx, 104 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1704(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1705(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1706(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1707(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_1703(_idx, 1 + _frame);
		_GIMMICK_PTTERNS_041(_idx, 105 + _frame);
		setData(_idx, 111 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1708(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1709(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1710(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1711(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_1703(_idx, 1 + _frame);
		_GIMMICK_PTTERNS_027(_idx, 105 + _frame);
		setData(_idx, 116 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1712(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1713(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_1703(_idx, 1 + _frame);
		_GIMMICK_PTTERNS_031(_idx, 105 + _frame);
		setData(_idx, 132 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1714(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1715(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1716(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1717(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_1703(_idx, 1 + _frame);
		_GIMMICK_PTTERNS_029(_idx, 105 + _frame);
		setData(_idx, 116 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1718(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1719(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_1703(_idx, 1 + _frame);
		_GIMMICK_PTTERNS_032(_idx, 105 + _frame);
		setData(_idx, 132 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1720(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1721(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1722(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_027(_idx, 85 + _frame);
		setData(_idx, 96 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1723(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1724(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_031(_idx, 85 + _frame);
		setData(_idx, 112 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1725(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1726(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1727(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1728(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_033(_idx, 0 + _frame);
		setData(_idx, 27 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1729(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1730(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1731(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1732(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_031(_idx, 97 + _frame);
		setData(_idx, 124 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1733(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1734(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1735(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1736(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_031(_idx, 32 + _frame);
		setData(_idx, 59 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1737(int _idx, int _frame)
	{
		setData(_idx, 8 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1738(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1739(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1740(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1741(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_1737(_idx, 1 + _frame);
		_GIMMICK_PTTERNS_041(_idx, 9 + _frame);
		setData(_idx, 15 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1742(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1743(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1744(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1745(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_1737(_idx, 1 + _frame);
		_GIMMICK_PTTERNS_027(_idx, 9 + _frame);
		setData(_idx, 20 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1746(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1747(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_1737(_idx, 1 + _frame);
		_GIMMICK_PTTERNS_031(_idx, 9 + _frame);
		setData(_idx, 36 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1748(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1749(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1750(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1751(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_1737(_idx, 1 + _frame);
		_GIMMICK_PTTERNS_029(_idx, 9 + _frame);
		setData(_idx, 20 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1752(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1753(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_1737(_idx, 1 + _frame);
		_GIMMICK_PTTERNS_032(_idx, 9 + _frame);
		setData(_idx, 36 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1754(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1755(int _idx, int _frame)
	{
		setData(_idx, 91 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1756(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1401(_idx, 0 + _frame);
		setData(_idx, 107 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1757(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_1755(_idx, 1 + _frame);
		_GIMMICK_PTTERNS_027(_idx, 92 + _frame);
		setData(_idx, 103 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1758(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1759(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_1755(_idx, 1 + _frame);
		_GIMMICK_PTTERNS_031(_idx, 92 + _frame);
		setData(_idx, 119 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1760(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1761(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1762(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1756(_idx, 0 + _frame);
		setData(_idx, 107 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1763(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_1755(_idx, 1 + _frame);
		_GIMMICK_PTTERNS_029(_idx, 92 + _frame);
		setData(_idx, 103 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1764(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1765(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_1755(_idx, 1 + _frame);
		_GIMMICK_PTTERNS_032(_idx, 92 + _frame);
		setData(_idx, 119 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1766(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1767(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1401(_idx, 0 + _frame);
		setData(_idx, 91 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1768(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1401(_idx, 0 + _frame);
		setData(_idx, 107 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1769(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1770(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1771(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_1767(_idx, 1 + _frame);
		_GIMMICK_PTTERNS_041(_idx, 92 + _frame);
		setData(_idx, 98 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1772(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1773(int _idx, int _frame)
	{
		_GIMMICK_PTTERNS_1768(_idx, 0 + _frame);
		setData(_idx, 107 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1774(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_1767(_idx, 1 + _frame);
		_GIMMICK_PTTERNS_029(_idx, 92 + _frame);
		setData(_idx, 103 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1775(int _idx, int _frame)
	{
	}

	public static void _GIMMICK_PTTERNS_1776(int _idx, int _frame)
	{
		_MOT_GEAR_004(_idx, 0 + _frame);
		_GIMMICK_PTTERNS_1767(_idx, 1 + _frame);
		_GIMMICK_PTTERNS_041(_idx, 92 + _frame);
		setData(_idx, 98 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1777(int _idx, int _frame)
	{
		_TEST_JYD_021(_idx, 0 + _frame);
		setData(_idx, 1 + _frame, 0, 0, 6);
	}

	public static void _GIMMICK_PTTERNS_1778(int _idx, int _frame)
	{
		_MOT_LOGO_002(_idx, 0 + _frame);
		setData(_idx, 1 + _frame, 0, 0, 6);
	}

	public static void _TESTTEST_051(int _idx, int _frame)
	{
		setData(_idx, 2 + _frame, 0, 255, 4);
		setData(_idx, 3 + _frame, 7, 95, 8);
		setData(_idx, 17 + _frame, 0, 0, 3);
		setData(_idx, 17 + _frame, 0, 0, 6);
	}

	public static void _TEST_JYD_001(int _idx, int _frame)
	{
		_MOT_JYD_B_001(_idx, 0 + _frame);
		_MOT_JYD_U_001(_idx, 0 + _frame);
		setData(_idx, 42 + _frame, 0, 0, 6);
	}

	public static void _TEST_JYD_002(int _idx, int _frame)
	{
		_MOT_JYD_B_002(_idx, 0 + _frame);
		_MOT_JYD_U_002(_idx, 0 + _frame);
		setData(_idx, 60 + _frame, 0, 0, 6);
	}

	public static void _TEST_JYD_003(int _idx, int _frame)
	{
		_MOT_JYD_B_003(_idx, 0 + _frame);
		_MOT_JYD_U_003(_idx, 0 + _frame);
		setData(_idx, 78 + _frame, 0, 0, 6);
	}

	public static void _TEST_JYD_004(int _idx, int _frame)
	{
		_MOT_JYD_B_010(_idx, 0 + _frame);
		_MOT_JYD_U_007(_idx, 0 + _frame);
		setData(_idx, 43 + _frame, 0, 0, 6);
	}

	public static void _TEST_JYD_005(int _idx, int _frame)
	{
		_MOT_JYD_B_009(_idx, 0 + _frame);
		_MOT_JYD_U_006(_idx, 0 + _frame);
		setData(_idx, 30 + _frame, 0, 0, 6);
	}

	public static void _TEST_JYD_006(int _idx, int _frame)
	{
		_MOT_JYD_B_009(_idx, 0 + _frame);
		setData(_idx, 0 + _frame, 0, 0, 6);
	}

	public static void _TEST_JYD_007(int _idx, int _frame)
	{
		_MOT_JYD_U_006(_idx, 0 + _frame);
		setData(_idx, 30 + _frame, 0, 0, 6);
	}

	public static void _TEST_JYD_008(int _idx, int _frame)
	{
		_MOT_JYD_B_007(_idx, 0 + _frame);
		_MOT_JYD_U_010(_idx, 0 + _frame);
		setData(_idx, 31 + _frame, 0, 0, 6);
	}

	public static void _TEST_JYD_009(int _idx, int _frame)
	{
		_MOT_JYD_B_006(_idx, 0 + _frame);
		_MOT_JYD_U_009(_idx, 0 + _frame);
		setData(_idx, 24 + _frame, 0, 0, 6);
	}

	public static void _TEST_JYD_010(int _idx, int _frame)
	{
		_MOT_JYD_B_006(_idx, 0 + _frame);
		setData(_idx, 0 + _frame, 0, 0, 6);
	}

	public static void _TEST_JYD_011(int _idx, int _frame)
	{
		_MOT_JYD_U_009(_idx, 0 + _frame);
		setData(_idx, 24 + _frame, 0, 0, 6);
	}

	public static void _TEST_JYD_012(int _idx, int _frame)
	{
		_MOT_JYD_B_012(_idx, 0 + _frame);
		_MOT_JYD_U_012(_idx, 0 + _frame);
		setData(_idx, 32 + _frame, 0, 0, 6);
	}

	public static void _TEST_JYD_013(int _idx, int _frame)
	{
		_MOT_JYD_B_013(_idx, 0 + _frame);
		_MOT_JYD_U_013(_idx, 0 + _frame);
		setData(_idx, 30 + _frame, 0, 0, 6);
	}

	public static void _TEST_JYD_014(int _idx, int _frame)
	{
		_MOT_JYD_B_014(_idx, 0 + _frame);
		_MOT_JYD_U_014(_idx, 0 + _frame);
		setData(_idx, 7 + _frame, 0, 0, 6);
	}

	public static void _TEST_JYD_015(int _idx, int _frame)
	{
		_MOT_JYD_B_015(_idx, 0 + _frame);
		_MOT_JYD_U_015(_idx, 0 + _frame);
		setData(_idx, 14 + _frame, 0, 0, 6);
	}

	public static void _TEST_JYD_016(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 0, 0, 6);
	}

	public static void _TEST_JYD_017(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 0, 0, 6);
	}

	public static void _TEST_JYD_018(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 0, 0, 6);
	}

	public static void _TEST_JYD_019(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 0, 0, 6);
	}

	public static void _TEST_JYD_020(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 0, 0, 6);
	}

	public static void _TEST_JYD_021(int _idx, int _frame)
	{
		_MOT_JYD_B_004(_idx, 0 + _frame);
		_MOT_JYD_U_004(_idx, 0 + _frame);
		setData(_idx, 1 + _frame, 0, 0, 6);
	}

	public static void _MOT_JYD_U_001(int _idx, int _frame)
	{
		setData(_idx, 42 + _frame, 0, 0, 6);
	}

	public static void _MOT_JYD_U_002(int _idx, int _frame)
	{
		setData(_idx, 60 + _frame, 0, 0, 6);
	}

	public static void _MOT_JYD_U_003(int _idx, int _frame)
	{
		setData(_idx, 78 + _frame, 0, 0, 6);
	}

	public static void _MOT_JYD_U_004(int _idx, int _frame)
	{
		setData(_idx, 1 + _frame, 0, 0, 6);
	}

	public static void _MOT_JYD_U_005(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 0, 0, 6);
	}

	public static void _MOT_JYD_U_006(int _idx, int _frame)
	{
		setData(_idx, 30 + _frame, 0, 0, 6);
	}

	public static void _MOT_JYD_U_007(int _idx, int _frame)
	{
		setData(_idx, 43 + _frame, 0, 0, 6);
	}

	public static void _MOT_JYD_U_008(int _idx, int _frame)
	{
		setData(_idx, 49 + _frame, 0, 0, 6);
	}

	public static void _MOT_JYD_U_009(int _idx, int _frame)
	{
		setData(_idx, 24 + _frame, 0, 0, 6);
	}

	public static void _MOT_JYD_U_010(int _idx, int _frame)
	{
		setData(_idx, 31 + _frame, 0, 0, 6);
	}

	public static void _MOT_JYD_U_011(int _idx, int _frame)
	{
		setData(_idx, 41 + _frame, 0, 0, 6);
	}

	public static void _MOT_JYD_U_012(int _idx, int _frame)
	{
		setData(_idx, 32 + _frame, 0, 0, 6);
	}

	public static void _MOT_JYD_U_013(int _idx, int _frame)
	{
		setData(_idx, 30 + _frame, 0, 0, 6);
	}

	public static void _MOT_JYD_U_014(int _idx, int _frame)
	{
		setData(_idx, 7 + _frame, 0, 0, 6);
	}

	public static void _MOT_JYD_U_015(int _idx, int _frame)
	{
		setData(_idx, 14 + _frame, 0, 0, 6);
	}

	public static void _MOT_JYD_U_016(int _idx, int _frame)
	{
		setData(_idx, 14 + _frame, 0, 0, 6);
	}

	public static void _MOT_JYD_U_017(int _idx, int _frame)
	{
		setData(_idx, 27 + _frame, 0, 0, 6);
	}

	public static void _MOT_JYD_U_018(int _idx, int _frame)
	{
		setData(_idx, 27 + _frame, 0, 0, 6);
	}

	public static void _MOT_JYD_U_019(int _idx, int _frame)
	{
		setData(_idx, 2 + _frame, 0, 0, 6);
	}

	public static void _MOT_JYD_U_020(int _idx, int _frame)
	{
		setData(_idx, 4 + _frame, 0, 0, 6);
	}

	public static void _MOT_JYD_U_021(int _idx, int _frame)
	{
		setData(_idx, 7 + _frame, 0, 0, 6);
	}

	public static void _MOT_JYD_U_022(int _idx, int _frame)
	{
		setData(_idx, 11 + _frame, 0, 0, 6);
	}

	public static void _MOT_JYD_U_023(int _idx, int _frame)
	{
		setData(_idx, 1 + _frame, 0, 0, 6);
	}

	public static void _MOT_JYD_U_024(int _idx, int _frame)
	{
		setData(_idx, 1 + _frame, 0, 0, 6);
	}

	public static void _MOT_JYD_U_025(int _idx, int _frame)
	{
		setData(_idx, 1 + _frame, 0, 0, 6);
	}

	public static void _MOT_JYD_U_026(int _idx, int _frame)
	{
		setData(_idx, 22 + _frame, 0, 0, 6);
	}

	public static void _MOT_JYD_U_027(int _idx, int _frame)
	{
		setData(_idx, 25 + _frame, 0, 0, 6);
	}

	public static void _MOT_JYD_B_001(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 8, 0, 8);
		setData(_idx, 12 + _frame, 8, 5, 8);
		setData(_idx, 49 + _frame, 0, 0, 6);
	}

	public static void _MOT_JYD_B_002(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 8, 0, 8);
		setData(_idx, 17 + _frame, 8, 5, 8);
		setData(_idx, 71 + _frame, 0, 0, 6);
	}

	public static void _MOT_JYD_B_003(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 8, 0, 8);
		setData(_idx, 22 + _frame, 8, 5, 8);
		setData(_idx, 93 + _frame, 0, 0, 6);
	}

	public static void _MOT_JYD_B_004(int _idx, int _frame)
	{
		setData(_idx, 1 + _frame, 0, 0, 6);
	}

	public static void _MOT_JYD_B_005(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 0, 0, 6);
	}

	public static void _MOT_JYD_B_006(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 8, 0, 8);
		setData(_idx, 31 + _frame, 0, 0, 6);
	}

	public static void _MOT_JYD_B_007(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 8, 0, 8);
		setData(_idx, 31 + _frame, 0, 0, 6);
	}

	public static void _MOT_JYD_B_008(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 8, 0, 8);
		setData(_idx, 41 + _frame, 0, 0, 6);
	}

	public static void _MOT_JYD_B_009(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 8, 5, 8);
		setData(_idx, 37 + _frame, 0, 0, 6);
	}

	public static void _MOT_JYD_B_010(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 8, 5, 8);
		setData(_idx, 54 + _frame, 0, 0, 6);
	}

	public static void _MOT_JYD_B_011(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 8, 5, 8);
		setData(_idx, 71 + _frame, 0, 0, 6);
	}

	public static void _MOT_JYD_B_012(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 8, 0, 8);
		setData(_idx, 4 + _frame, 8, 5, 8);
		setData(_idx, 32 + _frame, 0, 0, 6);
	}

	public static void _MOT_JYD_B_013(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 8, 0, 8);
		setData(_idx, 7 + _frame, 8, 5, 8);
		setData(_idx, 26 + _frame, 0, 0, 6);
	}

	public static void _MOT_JYD_B_014(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 8, 5, 8);
		setData(_idx, 3 + _frame, 8, 0, 8);
		setData(_idx, 7 + _frame, 0, 0, 6);
	}

	public static void _MOT_JYD_B_015(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 8, 5, 8);
		setData(_idx, 7 + _frame, 8, 0, 8);
		setData(_idx, 14 + _frame, 0, 0, 6);
	}

	public static void _MOT_JYD_B_016(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 8, 0, 8);
		setData(_idx, 13 + _frame, 0, 0, 6);
	}

	public static void _MOT_JYD_B_017(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 8, 0, 8);
		setData(_idx, 23 + _frame, 0, 0, 6);
	}

	public static void _MOT_JYD_B_018(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 8, 5, 8);
		setData(_idx, 23 + _frame, 0, 0, 6);
	}

	public static void _MOT_JYD_B_019(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 8, 5, 8);
		setData(_idx, 2 + _frame, 0, 0, 6);
	}

	public static void _MOT_JYD_B_020(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 8, 0, 8);
		setData(_idx, 4 + _frame, 0, 0, 6);
	}

	public static void _MOT_JYD_B_021(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 8, 0, 8);
		setData(_idx, 7 + _frame, 0, 0, 6);
	}

	public static void _MOT_JYD_B_022(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 8, 0, 8);
		setData(_idx, 11 + _frame, 0, 0, 6);
	}

	public static void _MOT_JYD_B_023(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 8, 0, 8);
		setData(_idx, 1 + _frame, 0, 0, 6);
	}

	public static void _MOT_JYD_B_024(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 8, 0, 8);
		setData(_idx, 1 + _frame, 0, 0, 6);
	}

	public static void _MOT_JYD_B_025(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 8, 0, 8);
		setData(_idx, 1 + _frame, 0, 0, 6);
	}

	public static void _MOT_JYD_B_026(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 8, 5, 8);
		setData(_idx, 26 + _frame, 0, 0, 6);
	}

	public static void _MOT_JYD_B_027(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 8, 5, 8);
		setData(_idx, 31 + _frame, 0, 0, 6);
	}

	public static void _MOT_LOGO_001(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 6, 0, 8);
		setData(_idx, 8 + _frame, 0, 0, 6);
	}

	public static void _MOT_LOGO_002(int _idx, int _frame)
	{
		setData(_idx, 1 + _frame, 0, 0, 6);
	}

	public static void _MOT_LOGO_003(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 0, 0, 6);
	}

	public static void _MOT_LOGO_004(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 6, 0, 8);
		setData(_idx, 9 + _frame, 0, 0, 6);
	}

	public static void _MOT_LOGO_005(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 6, 0, 8);
		setData(_idx, 10 + _frame, 0, 0, 6);
	}

	public static void _MOT_LOGO_006(int _idx, int _frame)
	{
		setData(_idx, 6 + _frame, 0, 0, 6);
	}

	public static void _MOT_LOGO_007(int _idx, int _frame)
	{
		setData(_idx, 8 + _frame, 0, 0, 6);
	}

	public static void _MOT_LOGO_008(int _idx, int _frame)
	{
		setData(_idx, 8 + _frame, 0, 0, 6);
	}

	public static void _MOT_LOGO_009(int _idx, int _frame)
	{
		setData(_idx, 3 + _frame, 0, 0, 6);
	}

	public static void _MOT_LOGO_010(int _idx, int _frame)
	{
		setData(_idx, 4 + _frame, 0, 0, 6);
	}

	public static void _MOT_LOGO_011(int _idx, int _frame)
	{
		setData(_idx, 4 + _frame, 0, 0, 6);
	}

	public static void _MOT_LOGO_012(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 0, 0, 6);
	}

	public static void _MOT_LOGO_013(int _idx, int _frame)
	{
		setData(_idx, 5 + _frame, 0, 0, 6);
	}

	public static void _MOT_ROT_001(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 9, 10, 8);
		setData(_idx, 67 + _frame, 0, 0, 6);
	}

	public static void _MOT_ROT_002(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 9, 12, 8);
		setData(_idx, 63 + _frame, 0, 0, 6);
	}

	public static void _MOT_ROT_003(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 9, 14, 8);
		setData(_idx, 59 + _frame, 0, 0, 6);
	}

	public static void _MOT_ROT_004(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 9, 16, 8);
		setData(_idx, 55 + _frame, 0, 0, 6);
	}

	public static void _MOT_ROT_005(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 9, 9, 8);
		setData(_idx, 53 + _frame, 0, 0, 6);
	}

	public static void _MOT_ROT_006(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 9, 9, 8);
		setData(_idx, 27 + _frame, 0, 0, 6);
	}

	public static void _MOT_ROT_007(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 9, 9, 8);
		setData(_idx, 53 + _frame, 0, 0, 6);
	}

	public static void _MOT_ROT_008(int _idx, int _frame)
	{
		setData(_idx, 1 + _frame, 0, 0, 6);
	}

	public static void _MOT_ROT_009(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 0, 0, 6);
	}

	public static void _MOT_ROT_010(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 9, 3, 8);
		setData(_idx, 6 + _frame, 0, 0, 6);
	}

	public static void _MOT_ROT_011(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 9, 4, 8);
		setData(_idx, 10 + _frame, 0, 0, 6);
	}

	public static void _MOT_ROT_012(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 9, 5, 8);
		setData(_idx, 14 + _frame, 0, 0, 6);
	}

	public static void _MOT_ROT_013(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 9, 6, 8);
		setData(_idx, 18 + _frame, 0, 0, 6);
	}

	public static void _MOT_ROT_014(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 9, 7, 8);
		setData(_idx, 22 + _frame, 0, 0, 6);
	}

	public static void _MOT_ROT_015(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 9, 8, 8);
		setData(_idx, 55 + _frame, 0, 0, 6);
	}

	public static void _MOT_ROT_016(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 9, 9, 8);
		setData(_idx, 31 + _frame, 0, 0, 6);
	}

	public static void _MOT_ROT_017(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 9, 1, 8);
		setData(_idx, 55 + _frame, 0, 0, 6);
	}

	public static void _MOT_ROT_018(int _idx, int _frame)
	{
		setData(_idx, 18 + _frame, 0, 0, 6);
	}

	public static void _MOT_ROT_019(int _idx, int _frame)
	{
		setData(_idx, 49 + _frame, 0, 0, 6);
	}

	public static void _MOT_ROT_020(int _idx, int _frame)
	{
		setData(_idx, 66 + _frame, 0, 0, 6);
	}

	public static void _MOT_ROT_021(int _idx, int _frame)
	{
		setData(_idx, 18 + _frame, 0, 0, 6);
	}

	public static void _MOT_ROT_022(int _idx, int _frame)
	{
		setData(_idx, 66 + _frame, 0, 0, 6);
	}

	public static void _MOT_ROT_023(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 9, 0, 8);
		setData(_idx, 3 + _frame, 0, 0, 6);
	}

	public static void _MOT_ROT_024(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 9, 0, 8);
		setData(_idx, 5 + _frame, 0, 0, 6);
	}

	public static void _MOT_ROT_025(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 9, 9, 8);
		setData(_idx, 27 + _frame, 0, 0, 6);
	}

	public static void _MOT_ROT_026(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 9, 11, 8);
		setData(_idx, 39 + _frame, 0, 0, 6);
	}

	public static void _MOT_ROT_027(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 9, 13, 8);
		setData(_idx, 35 + _frame, 0, 0, 6);
	}

	public static void _MOT_ROT_028(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 9, 15, 8);
		setData(_idx, 27 + _frame, 0, 0, 6);
	}

	public static void _MOT_ROT_029(int _idx, int _frame)
	{
		setData(_idx, 27 + _frame, 0, 0, 6);
	}

	public static void _MOT_ROT_030(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 9, 3, 8);
		setData(_idx, 31 + _frame, 0, 0, 6);
	}

	public static void _MOT_ROT_031(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 9, 5, 8);
		setData(_idx, 35 + _frame, 0, 0, 6);
	}

	public static void _MOT_ROT_032(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 9, 7, 8);
		setData(_idx, 27 + _frame, 0, 0, 6);
	}

	public static void _MOT_ROT_033(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 9, 1, 8);
		setData(_idx, 39 + _frame, 0, 0, 6);
	}

	public static void _MOT_ROT_034(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 9, 1, 8);
		setData(_idx, 27 + _frame, 0, 0, 6);
	}

	public static void _MOT_ROT_035(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 9, 9, 8);
		setData(_idx, 40 + _frame, 0, 0, 6);
	}

	public static void _MOT_ROT_036(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 9, 9, 8);
		setData(_idx, 27 + _frame, 0, 0, 6);
	}

	public static void _MOT_ROT_037(int _idx, int _frame)
	{
		setData(_idx, 1 + _frame, 0, 0, 6);
	}

	public static void _MOT_ROT_038(int _idx, int _frame)
	{
		setData(_idx, 1 + _frame, 0, 0, 6);
	}

	public static void _MOT_ROT_039(int _idx, int _frame)
	{
		setData(_idx, 27 + _frame, 0, 0, 6);
	}

	public static void _MOT_ROT_040(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 9, 1, 8);
		setData(_idx, 31 + _frame, 0, 0, 6);
	}

	public static void _MOT_ROT_041(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 9, 1, 8);
		setData(_idx, 3 + _frame, 0, 0, 6);
	}

	public static void _MOT_ROT_042(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 9, 0, 8);
		setData(_idx, 5 + _frame, 0, 0, 6);
	}

	public static void _MOT_ROT_043(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 9, 1, 8);
		setData(_idx, 4 + _frame, 0, 0, 6);
	}

	public static void _MOT_ROT_044(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 9, 9, 8);
		setData(_idx, 4 + _frame, 0, 0, 6);
	}

	public static void _MOT_ROT_045(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 9, 0, 8);
		setData(_idx, 63 + _frame, 0, 0, 6);
	}

	public static void _MOT_GEAR_001(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 7, 0, 8);
		setData(_idx, 25 + _frame, 0, 0, 6);
	}

	public static void _MOT_GEAR_002(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 7, 0, 8);
		setData(_idx, 37 + _frame, 0, 0, 6);
	}

	public static void _MOT_GEAR_003(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 7, 0, 8);
		setData(_idx, 49 + _frame, 0, 0, 6);
	}

	public static void _MOT_GEAR_004(int _idx, int _frame)
	{
		setData(_idx, 1 + _frame, 0, 0, 6);
	}

	public static void _MOT_GEAR_005(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 0, 0, 6);
	}

	public static void _MOT_GEAR_006(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 7, 0, 8);
		setData(_idx, 3 + _frame, 0, 0, 6);
	}

	public static void _MOT_GEAR_007(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 7, 0, 8);
		setData(_idx, 5 + _frame, 0, 0, 6);
	}

	public static void _MOT_GEAR_008(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 7, 78, 8);
		setData(_idx, 48 + _frame, 0, 0, 6);
	}

	public static void _MOT_GEAR_009(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 7, 78, 8);
		setData(_idx, 36 + _frame, 0, 0, 6);
	}

	public static void _MOT_GEAR_010(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 7, 78, 8);
		setData(_idx, 24 + _frame, 0, 0, 6);
	}

	public static void _MOT_GEAR_011(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 7, 69, 8);
		setData(_idx, 48 + _frame, 0, 0, 6);
	}

	public static void _MOT_GEAR_012(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 7, 69, 8);
		setData(_idx, 36 + _frame, 0, 0, 6);
	}

	public static void _MOT_GEAR_013(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 7, 69, 8);
		setData(_idx, 24 + _frame, 0, 0, 6);
	}

	public static void _MOT_GEAR_014(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 7, 95, 8);
		setData(_idx, 5 + _frame, 0, 0, 6);
	}

	public static void _MOT_GEAR_015(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 7, 95, 8);
		setData(_idx, 4 + _frame, 0, 0, 6);
	}

	public static void _MOT_GEAR_016(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 7, 95, 8);
		setData(_idx, 8 + _frame, 0, 0, 6);
	}

	public static void _MOT_GEAR_017(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 7, 87, 8);
		setData(_idx, 5 + _frame, 0, 0, 6);
	}

	public static void _MOT_GEAR_018(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 7, 87, 8);
		setData(_idx, 4 + _frame, 0, 0, 6);
	}

	public static void _MOT_GEAR_019(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 7, 87, 8);
		setData(_idx, 8 + _frame, 0, 0, 6);
	}

	public static void _MOT_GEAR_020(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 7, 0, 12);
		setData(_idx, 2 + _frame, 0, 0, 6);
	}

	public static void _MOT_GEAR_021(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 7, 78, 8);
		setData(_idx, 2 + _frame, 0, 0, 6);
	}

	public static void _MOT_GEAR_022(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 7, 78, 8);
		setData(_idx, 4 + _frame, 0, 0, 6);
	}

	public static void _CMD_001(int _idx, int _frame)
	{
	}

	public static void _CMD_002(int _idx, int _frame)
	{
	}

	public static void _CMD_003(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 0, 0, 6);
	}

	public static void _CMD_004(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 0, 0, 6);
	}

	public static void _MOT_EFF_001(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 0, 0, 6);
	}

	public static void _MOT_EFF_002(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 0, 1, 4);
		setData(_idx, 0 + _frame, 0, 0, 6);
	}

	public static void _MOT_EFF_003(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 0, 0, 6);
	}

	public static void _MOT_EFF_004(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 0, 0, 6);
	}

	public static void _MOT_EFF_005(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 0, 0, 6);
	}

	public static void _MOT_EFF_006(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 0, 0, 6);
	}

	public static void _MOT_EFF_007(int _idx, int _frame)
	{
		setData(_idx, 0 + _frame, 0, 0, 6);
	}

	public static void _MAIN_GIMMICK_PTTERNS_002()
	{
		init(6);
		_GIMMICK_PTTERNS_002(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_003()
	{
		init(8);
		_GIMMICK_PTTERNS_003(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_004()
	{
		init(9);
		_GIMMICK_PTTERNS_004(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_005()
	{
		init(7);
		_GIMMICK_PTTERNS_005(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_006()
	{
		init(9);
		_GIMMICK_PTTERNS_006(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_007()
	{
		init(9);
		_GIMMICK_PTTERNS_007(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_008()
	{
		init(9);
		_GIMMICK_PTTERNS_008(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_009()
	{
		init(9);
		_GIMMICK_PTTERNS_009(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_010()
	{
		init(8);
		_GIMMICK_PTTERNS_010(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_011()
	{
		init(8);
		_GIMMICK_PTTERNS_011(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_012()
	{
		init(8);
		_GIMMICK_PTTERNS_012(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_013()
	{
		init(8);
		_GIMMICK_PTTERNS_013(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_014()
	{
		init(8);
		_GIMMICK_PTTERNS_014(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_015()
	{
		init(8);
		_GIMMICK_PTTERNS_015(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_017()
	{
		init(8);
		_GIMMICK_PTTERNS_017(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_018()
	{
		init(8);
		_GIMMICK_PTTERNS_018(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_019()
	{
		init(8);
		_GIMMICK_PTTERNS_019(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_020()
	{
		init(8);
		_GIMMICK_PTTERNS_020(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_021()
	{
		init(8);
		_GIMMICK_PTTERNS_021(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_022()
	{
		init(6);
		_GIMMICK_PTTERNS_022(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_023()
	{
		init(6);
		_GIMMICK_PTTERNS_023(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_024()
	{
		init(6);
		_GIMMICK_PTTERNS_024(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_025()
	{
		init(6);
		_GIMMICK_PTTERNS_025(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_026()
	{
		init(6);
		_GIMMICK_PTTERNS_026(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_027()
	{
		init(6);
		_GIMMICK_PTTERNS_027(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_028()
	{
		init(6);
		_GIMMICK_PTTERNS_028(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_029()
	{
		init(6);
		_GIMMICK_PTTERNS_029(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_030()
	{
		init(7);
		_GIMMICK_PTTERNS_030(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_031()
	{
		init(7);
		_GIMMICK_PTTERNS_031(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_032()
	{
		init(7);
		_GIMMICK_PTTERNS_032(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_033()
	{
		init(7);
		_GIMMICK_PTTERNS_033(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_034()
	{
		init(7);
		_GIMMICK_PTTERNS_034(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_035()
	{
		init(7);
		_GIMMICK_PTTERNS_035(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_036()
	{
		init(7);
		_GIMMICK_PTTERNS_036(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_037()
	{
		init(7);
		_GIMMICK_PTTERNS_037(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_038()
	{
		init(7);
		_GIMMICK_PTTERNS_038(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_039()
	{
		init(7);
		_GIMMICK_PTTERNS_039(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_040()
	{
		init(7);
		_GIMMICK_PTTERNS_040(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_041()
	{
		init(7);
		_GIMMICK_PTTERNS_041(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_042()
	{
		init(7);
		_GIMMICK_PTTERNS_042(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_043()
	{
		init(7);
		_GIMMICK_PTTERNS_043(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_044()
	{
		init(7);
		_GIMMICK_PTTERNS_044(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_045()
	{
		init(7);
		_GIMMICK_PTTERNS_045(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_046()
	{
		init(7);
		_GIMMICK_PTTERNS_046(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_047()
	{
		init(9);
		_GIMMICK_PTTERNS_047(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_048()
	{
		init(9);
		_GIMMICK_PTTERNS_048(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_049()
	{
		init(9);
		_GIMMICK_PTTERNS_049(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_050()
	{
		init(9);
		_GIMMICK_PTTERNS_050(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_051()
	{
		init(9);
		_GIMMICK_PTTERNS_051(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_052()
	{
		init(9);
		_GIMMICK_PTTERNS_052(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_053()
	{
		init(9);
		_GIMMICK_PTTERNS_053(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_054()
	{
		init(9);
		_GIMMICK_PTTERNS_054(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_055()
	{
		init(9);
		_GIMMICK_PTTERNS_055(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_056()
	{
		init(9);
		_GIMMICK_PTTERNS_056(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_057()
	{
		init(9);
		_GIMMICK_PTTERNS_057(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_058()
	{
		init(9);
		_GIMMICK_PTTERNS_058(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_059()
	{
		init(9);
		_GIMMICK_PTTERNS_059(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_060()
	{
		init(9);
		_GIMMICK_PTTERNS_060(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_061()
	{
		init(9);
		_GIMMICK_PTTERNS_061(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_062()
	{
		init(9);
		_GIMMICK_PTTERNS_062(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_063()
	{
		init(9);
		_GIMMICK_PTTERNS_063(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_064()
	{
		init(9);
		_GIMMICK_PTTERNS_064(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_065()
	{
		init(9);
		_GIMMICK_PTTERNS_065(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_066()
	{
		init(9);
		_GIMMICK_PTTERNS_066(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_067()
	{
		init(9);
		_GIMMICK_PTTERNS_067(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_070()
	{
		init(8);
		_GIMMICK_PTTERNS_070(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_071()
	{
		init(6);
		_GIMMICK_PTTERNS_071(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_072()
	{
		init(9);
		_GIMMICK_PTTERNS_072(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_073()
	{
		init(7);
		_GIMMICK_PTTERNS_073(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_074()
	{
		init(8);
		_GIMMICK_PTTERNS_074(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_075()
	{
		init(6);
		_GIMMICK_PTTERNS_075(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_076()
	{
		init(9);
		_GIMMICK_PTTERNS_076(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_077()
	{
		init(7);
		_GIMMICK_PTTERNS_077(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_078()
	{
		init(8);
		_GIMMICK_PTTERNS_078(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_079()
	{
		init(6);
		_GIMMICK_PTTERNS_079(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_080()
	{
		init(9);
		_GIMMICK_PTTERNS_080(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_081()
	{
		init(7);
		_GIMMICK_PTTERNS_081(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_082()
	{
		init(8);
		_GIMMICK_PTTERNS_082(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_083()
	{
		init(6);
		_GIMMICK_PTTERNS_083(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_084()
	{
		init(9);
		_GIMMICK_PTTERNS_084(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_085()
	{
		init(8);
		_GIMMICK_PTTERNS_085(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_086()
	{
		init(8);
		_GIMMICK_PTTERNS_086(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_087()
	{
		init(8);
		_GIMMICK_PTTERNS_087(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_088()
	{
		init(8);
		_GIMMICK_PTTERNS_088(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_090()
	{
		init(8);
		_GIMMICK_PTTERNS_090(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_091()
	{
		init(8);
		_GIMMICK_PTTERNS_091(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_092()
	{
		init(8);
		_GIMMICK_PTTERNS_092(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_093()
	{
		init(6);
		_GIMMICK_PTTERNS_093(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_094()
	{
		init(9);
		_GIMMICK_PTTERNS_094(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_095()
	{
		init(7);
		_GIMMICK_PTTERNS_095(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_096()
	{
		init(8);
		_GIMMICK_PTTERNS_096(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_097()
	{
		init(6);
		_GIMMICK_PTTERNS_097(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_098()
	{
		init(9);
		_GIMMICK_PTTERNS_098(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_099()
	{
		init(7);
		_GIMMICK_PTTERNS_099(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_102()
	{
		init(8);
		_GIMMICK_PTTERNS_102(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_103()
	{
		init(6);
		_GIMMICK_PTTERNS_103(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_104()
	{
		init(9);
		_GIMMICK_PTTERNS_104(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_105()
	{
		init(7);
		_GIMMICK_PTTERNS_105(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_108()
	{
		init(8);
		_GIMMICK_PTTERNS_108(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_109()
	{
		init(6);
		_GIMMICK_PTTERNS_109(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_110()
	{
		init(9);
		_GIMMICK_PTTERNS_110(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_111()
	{
		init(7);
		_GIMMICK_PTTERNS_111(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_114()
	{
		init(8);
		_GIMMICK_PTTERNS_114(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_115()
	{
		init(6);
		_GIMMICK_PTTERNS_115(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_116()
	{
		init(9);
		_GIMMICK_PTTERNS_116(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_117()
	{
		init(7);
		_GIMMICK_PTTERNS_117(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_119()
	{
		init(8);
		_GIMMICK_PTTERNS_119(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_120()
	{
		init(6);
		_GIMMICK_PTTERNS_120(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_121()
	{
		init(9);
		_GIMMICK_PTTERNS_121(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_122()
	{
		init(7);
		_GIMMICK_PTTERNS_122(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_123()
	{
		init(8);
		_GIMMICK_PTTERNS_123(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_124()
	{
		init(8);
		_GIMMICK_PTTERNS_124(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_125()
	{
		init(8);
		_GIMMICK_PTTERNS_125(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_126()
	{
		init(6);
		_GIMMICK_PTTERNS_126(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_127()
	{
		init(9);
		_GIMMICK_PTTERNS_127(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_128()
	{
		init(7);
		_GIMMICK_PTTERNS_128(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_129()
	{
		init(8);
		_GIMMICK_PTTERNS_129(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_130()
	{
		init(8);
		_GIMMICK_PTTERNS_130(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_131()
	{
		init(6);
		_GIMMICK_PTTERNS_131(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_132()
	{
		init(9);
		_GIMMICK_PTTERNS_132(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_133()
	{
		init(7);
		_GIMMICK_PTTERNS_133(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_134()
	{
		init(8);
		_GIMMICK_PTTERNS_134(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_135()
	{
		init(6);
		_GIMMICK_PTTERNS_135(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_136()
	{
		init(8);
		_GIMMICK_PTTERNS_136(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_137()
	{
		init(6);
		_GIMMICK_PTTERNS_137(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_138()
	{
		init(9);
		_GIMMICK_PTTERNS_138(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_139()
	{
		init(7);
		_GIMMICK_PTTERNS_139(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_140()
	{
		init(8);
		_GIMMICK_PTTERNS_140(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_141()
	{
		init(6);
		_GIMMICK_PTTERNS_141(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_142()
	{
		init(9);
		_GIMMICK_PTTERNS_142(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_143()
	{
		init(7);
		_GIMMICK_PTTERNS_143(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_146()
	{
		init(8);
		_GIMMICK_PTTERNS_146(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_147()
	{
		init(6);
		_GIMMICK_PTTERNS_147(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_148()
	{
		init(9);
		_GIMMICK_PTTERNS_148(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_149()
	{
		init(7);
		_GIMMICK_PTTERNS_149(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_152()
	{
		init(8);
		_GIMMICK_PTTERNS_152(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_153()
	{
		init(6);
		_GIMMICK_PTTERNS_153(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_154()
	{
		init(9);
		_GIMMICK_PTTERNS_154(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_155()
	{
		init(7);
		_GIMMICK_PTTERNS_155(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_157()
	{
		init(8);
		_GIMMICK_PTTERNS_157(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_158()
	{
		init(6);
		_GIMMICK_PTTERNS_158(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_159()
	{
		init(9);
		_GIMMICK_PTTERNS_159(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_160()
	{
		init(7);
		_GIMMICK_PTTERNS_160(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_161()
	{
		init(8);
		_GIMMICK_PTTERNS_161(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_162()
	{
		init(8);
		_GIMMICK_PTTERNS_162(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_163()
	{
		init(8);
		_GIMMICK_PTTERNS_163(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_164()
	{
		init(6);
		_GIMMICK_PTTERNS_164(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_165()
	{
		init(9);
		_GIMMICK_PTTERNS_165(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_166()
	{
		init(7);
		_GIMMICK_PTTERNS_166(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_167()
	{
		init(8);
		_GIMMICK_PTTERNS_167(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_168()
	{
		init(8);
		_GIMMICK_PTTERNS_168(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_169()
	{
		init(8);
		_GIMMICK_PTTERNS_169(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_170()
	{
		init(8);
		_GIMMICK_PTTERNS_170(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_171()
	{
		init(8);
		_GIMMICK_PTTERNS_171(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_172()
	{
		init(8);
		_GIMMICK_PTTERNS_172(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_173()
	{
		init(8);
		_GIMMICK_PTTERNS_173(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_174()
	{
		init(8);
		_GIMMICK_PTTERNS_174(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_175()
	{
		init(8);
		_GIMMICK_PTTERNS_175(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_176()
	{
		init(8);
		_GIMMICK_PTTERNS_176(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_177()
	{
		init(8);
		_GIMMICK_PTTERNS_177(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_178()
	{
		init(6);
		_GIMMICK_PTTERNS_178(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_179()
	{
		init(9);
		_GIMMICK_PTTERNS_179(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_180()
	{
		init(7);
		_GIMMICK_PTTERNS_180(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_181()
	{
		init(8);
		_GIMMICK_PTTERNS_181(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_182()
	{
		init(6);
		_GIMMICK_PTTERNS_182(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_183()
	{
		init(9);
		_GIMMICK_PTTERNS_183(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_184()
	{
		init(7);
		_GIMMICK_PTTERNS_184(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_185()
	{
		init(8);
		_GIMMICK_PTTERNS_185(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_186()
	{
		init(6);
		_GIMMICK_PTTERNS_186(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_187()
	{
		init(9);
		_GIMMICK_PTTERNS_187(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_188()
	{
		init(7);
		_GIMMICK_PTTERNS_188(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_189()
	{
		init(8);
		_GIMMICK_PTTERNS_189(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_190()
	{
		init(6);
		_GIMMICK_PTTERNS_190(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_191()
	{
		init(9);
		_GIMMICK_PTTERNS_191(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_192()
	{
		init(7);
		_GIMMICK_PTTERNS_192(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_193()
	{
		init(8);
		_GIMMICK_PTTERNS_193(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_194()
	{
		init(8);
		_GIMMICK_PTTERNS_194(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_195()
	{
		init(8);
		_GIMMICK_PTTERNS_195(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_197()
	{
		init(9);
		_GIMMICK_PTTERNS_197(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_198()
	{
		init(7);
		_GIMMICK_PTTERNS_198(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_200()
	{
		init(8);
		_GIMMICK_PTTERNS_200(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_201()
	{
		init(6);
		_GIMMICK_PTTERNS_201(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_202()
	{
		init(9);
		_GIMMICK_PTTERNS_202(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_203()
	{
		init(7);
		_GIMMICK_PTTERNS_203(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_204()
	{
		init(8);
		_GIMMICK_PTTERNS_204(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_205()
	{
		init(6);
		_GIMMICK_PTTERNS_205(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_206()
	{
		init(9);
		_GIMMICK_PTTERNS_206(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_207()
	{
		init(7);
		_GIMMICK_PTTERNS_207(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_208()
	{
		init(8);
		_GIMMICK_PTTERNS_208(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_209()
	{
		init(6);
		_GIMMICK_PTTERNS_209(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_210()
	{
		init(9);
		_GIMMICK_PTTERNS_210(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_211()
	{
		init(7);
		_GIMMICK_PTTERNS_211(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_212()
	{
		init(8);
		_GIMMICK_PTTERNS_212(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_213()
	{
		init(6);
		_GIMMICK_PTTERNS_213(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_214()
	{
		init(9);
		_GIMMICK_PTTERNS_214(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_215()
	{
		init(7);
		_GIMMICK_PTTERNS_215(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_216()
	{
		init(8);
		_GIMMICK_PTTERNS_216(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_217()
	{
		init(6);
		_GIMMICK_PTTERNS_217(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_218()
	{
		init(9);
		_GIMMICK_PTTERNS_218(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_219()
	{
		init(7);
		_GIMMICK_PTTERNS_219(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_220()
	{
		init(8);
		_GIMMICK_PTTERNS_220(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_221()
	{
		init(6);
		_GIMMICK_PTTERNS_221(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_222()
	{
		init(9);
		_GIMMICK_PTTERNS_222(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_223()
	{
		init(7);
		_GIMMICK_PTTERNS_223(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_224()
	{
		init(8);
		_GIMMICK_PTTERNS_224(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_225()
	{
		init(6);
		_GIMMICK_PTTERNS_225(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_226()
	{
		init(9);
		_GIMMICK_PTTERNS_226(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_227()
	{
		init(7);
		_GIMMICK_PTTERNS_227(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_228()
	{
		init(8);
		_GIMMICK_PTTERNS_228(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_229()
	{
		init(6);
		_GIMMICK_PTTERNS_229(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_230()
	{
		init(9);
		_GIMMICK_PTTERNS_230(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_231()
	{
		init(7);
		_GIMMICK_PTTERNS_231(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_232()
	{
		init(8);
		_GIMMICK_PTTERNS_232(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_233()
	{
		init(6);
		_GIMMICK_PTTERNS_233(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_234()
	{
		init(9);
		_GIMMICK_PTTERNS_234(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_235()
	{
		init(7);
		_GIMMICK_PTTERNS_235(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_236()
	{
		init(8);
		_GIMMICK_PTTERNS_236(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_237()
	{
		init(6);
		_GIMMICK_PTTERNS_237(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_238()
	{
		init(9);
		_GIMMICK_PTTERNS_238(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_239()
	{
		init(7);
		_GIMMICK_PTTERNS_239(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_240()
	{
		init(8);
		_GIMMICK_PTTERNS_240(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_241()
	{
		init(8);
		_GIMMICK_PTTERNS_241(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_242()
	{
		init(6);
		_GIMMICK_PTTERNS_242(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_243()
	{
		init(9);
		_GIMMICK_PTTERNS_243(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_244()
	{
		init(7);
		_GIMMICK_PTTERNS_244(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_246()
	{
		init(8);
		_GIMMICK_PTTERNS_246(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_247()
	{
		init(6);
		_GIMMICK_PTTERNS_247(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_248()
	{
		init(9);
		_GIMMICK_PTTERNS_248(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_249()
	{
		init(7);
		_GIMMICK_PTTERNS_249(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_251()
	{
		init(8);
		_GIMMICK_PTTERNS_251(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_252()
	{
		init(6);
		_GIMMICK_PTTERNS_252(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_253()
	{
		init(9);
		_GIMMICK_PTTERNS_253(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_254()
	{
		init(7);
		_GIMMICK_PTTERNS_254(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_256()
	{
		init(8);
		_GIMMICK_PTTERNS_256(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_257()
	{
		init(8);
		_GIMMICK_PTTERNS_257(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_258()
	{
		init(6);
		_GIMMICK_PTTERNS_258(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_259()
	{
		init(9);
		_GIMMICK_PTTERNS_259(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_260()
	{
		init(7);
		_GIMMICK_PTTERNS_260(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_261()
	{
		init(8);
		_GIMMICK_PTTERNS_261(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_262()
	{
		init(6);
		_GIMMICK_PTTERNS_262(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_263()
	{
		init(9);
		_GIMMICK_PTTERNS_263(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_264()
	{
		init(7);
		_GIMMICK_PTTERNS_264(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_265()
	{
		init(8);
		_GIMMICK_PTTERNS_265(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_266()
	{
		init(6);
		_GIMMICK_PTTERNS_266(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_267()
	{
		init(9);
		_GIMMICK_PTTERNS_267(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_268()
	{
		init(7);
		_GIMMICK_PTTERNS_268(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_270()
	{
		init(8);
		_GIMMICK_PTTERNS_270(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_271()
	{
		init(8);
		_GIMMICK_PTTERNS_271(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_272()
	{
		init(6);
		_GIMMICK_PTTERNS_272(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_273()
	{
		init(9);
		_GIMMICK_PTTERNS_273(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_274()
	{
		init(7);
		_GIMMICK_PTTERNS_274(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_275()
	{
		init(8);
		_GIMMICK_PTTERNS_275(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_276()
	{
		init(6);
		_GIMMICK_PTTERNS_276(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_277()
	{
		init(9);
		_GIMMICK_PTTERNS_277(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_278()
	{
		init(7);
		_GIMMICK_PTTERNS_278(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_279()
	{
		init(8);
		_GIMMICK_PTTERNS_279(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_280()
	{
		init(6);
		_GIMMICK_PTTERNS_280(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_281()
	{
		init(9);
		_GIMMICK_PTTERNS_281(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_282()
	{
		init(7);
		_GIMMICK_PTTERNS_282(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_283()
	{
		init(8);
		_GIMMICK_PTTERNS_283(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_284()
	{
		init(8);
		_GIMMICK_PTTERNS_284(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_285()
	{
		init(6);
		_GIMMICK_PTTERNS_285(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_286()
	{
		init(9);
		_GIMMICK_PTTERNS_286(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_287()
	{
		init(7);
		_GIMMICK_PTTERNS_287(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_288()
	{
		init(8);
		_GIMMICK_PTTERNS_288(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_289()
	{
		init(8);
		_GIMMICK_PTTERNS_289(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_290()
	{
		init(6);
		_GIMMICK_PTTERNS_290(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_291()
	{
		init(9);
		_GIMMICK_PTTERNS_291(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_292()
	{
		init(7);
		_GIMMICK_PTTERNS_292(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_293()
	{
		init(8);
		_GIMMICK_PTTERNS_293(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_294()
	{
		init(6);
		_GIMMICK_PTTERNS_294(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_295()
	{
		init(9);
		_GIMMICK_PTTERNS_295(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_296()
	{
		init(7);
		_GIMMICK_PTTERNS_296(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_297()
	{
		init(8);
		_GIMMICK_PTTERNS_297(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_298()
	{
		init(6);
		_GIMMICK_PTTERNS_298(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_299()
	{
		init(9);
		_GIMMICK_PTTERNS_299(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_300()
	{
		init(7);
		_GIMMICK_PTTERNS_300(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_302()
	{
		init(8);
		_GIMMICK_PTTERNS_302(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_303()
	{
		init(6);
		_GIMMICK_PTTERNS_303(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_304()
	{
		init(9);
		_GIMMICK_PTTERNS_304(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_305()
	{
		init(7);
		_GIMMICK_PTTERNS_305(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_307()
	{
		init(8);
		_GIMMICK_PTTERNS_307(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_308()
	{
		init(6);
		_GIMMICK_PTTERNS_308(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_309()
	{
		init(9);
		_GIMMICK_PTTERNS_309(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_310()
	{
		init(7);
		_GIMMICK_PTTERNS_310(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_311()
	{
		init(8);
		_GIMMICK_PTTERNS_311(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_312()
	{
		init(6);
		_GIMMICK_PTTERNS_312(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_313()
	{
		init(9);
		_GIMMICK_PTTERNS_313(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_314()
	{
		init(7);
		_GIMMICK_PTTERNS_314(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_316()
	{
		init(8);
		_GIMMICK_PTTERNS_316(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_317()
	{
		init(6);
		_GIMMICK_PTTERNS_317(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_318()
	{
		init(9);
		_GIMMICK_PTTERNS_318(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_319()
	{
		init(7);
		_GIMMICK_PTTERNS_319(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_320()
	{
		init(8);
		_GIMMICK_PTTERNS_320(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_321()
	{
		init(6);
		_GIMMICK_PTTERNS_321(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_322()
	{
		init(9);
		_GIMMICK_PTTERNS_322(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_323()
	{
		init(7);
		_GIMMICK_PTTERNS_323(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_325()
	{
		init(8);
		_GIMMICK_PTTERNS_325(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_326()
	{
		init(6);
		_GIMMICK_PTTERNS_326(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_327()
	{
		init(9);
		_GIMMICK_PTTERNS_327(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_328()
	{
		init(7);
		_GIMMICK_PTTERNS_328(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_332()
	{
		init(8);
		_GIMMICK_PTTERNS_332(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_333()
	{
		init(8);
		_GIMMICK_PTTERNS_333(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_334()
	{
		init(6);
		_GIMMICK_PTTERNS_334(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_335()
	{
		init(9);
		_GIMMICK_PTTERNS_335(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_336()
	{
		init(7);
		_GIMMICK_PTTERNS_336(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_338()
	{
		init(8);
		_GIMMICK_PTTERNS_338(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_339()
	{
		init(6);
		_GIMMICK_PTTERNS_339(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_340()
	{
		init(9);
		_GIMMICK_PTTERNS_340(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_341()
	{
		init(7);
		_GIMMICK_PTTERNS_341(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_342()
	{
		init(8);
		_GIMMICK_PTTERNS_342(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_343()
	{
		init(6);
		_GIMMICK_PTTERNS_343(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_344()
	{
		init(9);
		_GIMMICK_PTTERNS_344(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_345()
	{
		init(7);
		_GIMMICK_PTTERNS_345(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_346()
	{
		init(8);
		_GIMMICK_PTTERNS_346(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_347()
	{
		init(6);
		_GIMMICK_PTTERNS_347(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_348()
	{
		init(9);
		_GIMMICK_PTTERNS_348(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_349()
	{
		init(7);
		_GIMMICK_PTTERNS_349(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_350()
	{
		init(8);
		_GIMMICK_PTTERNS_350(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_351()
	{
		init(6);
		_GIMMICK_PTTERNS_351(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_352()
	{
		init(9);
		_GIMMICK_PTTERNS_352(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_353()
	{
		init(7);
		_GIMMICK_PTTERNS_353(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_354()
	{
		init(8);
		_GIMMICK_PTTERNS_354(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_355()
	{
		init(6);
		_GIMMICK_PTTERNS_355(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_356()
	{
		init(9);
		_GIMMICK_PTTERNS_356(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_357()
	{
		init(7);
		_GIMMICK_PTTERNS_357(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_358()
	{
		init(8);
		_GIMMICK_PTTERNS_358(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_359()
	{
		init(8);
		_GIMMICK_PTTERNS_359(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_360()
	{
		init(8);
		_GIMMICK_PTTERNS_360(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_361()
	{
		init(8);
		_GIMMICK_PTTERNS_361(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_362()
	{
		init(8);
		_GIMMICK_PTTERNS_362(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_363()
	{
		init(8);
		_GIMMICK_PTTERNS_363(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_364()
	{
		init(6);
		_GIMMICK_PTTERNS_364(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_365()
	{
		init(9);
		_GIMMICK_PTTERNS_365(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_366()
	{
		init(7);
		_GIMMICK_PTTERNS_366(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_367()
	{
		init(8);
		_GIMMICK_PTTERNS_367(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_368()
	{
		init(6);
		_GIMMICK_PTTERNS_368(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_369()
	{
		init(9);
		_GIMMICK_PTTERNS_369(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_370()
	{
		init(7);
		_GIMMICK_PTTERNS_370(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_371()
	{
		init(8);
		_GIMMICK_PTTERNS_371(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_372()
	{
		init(6);
		_GIMMICK_PTTERNS_372(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_373()
	{
		init(9);
		_GIMMICK_PTTERNS_373(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_374()
	{
		init(7);
		_GIMMICK_PTTERNS_374(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_375()
	{
		init(8);
		_GIMMICK_PTTERNS_375(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_376()
	{
		init(6);
		_GIMMICK_PTTERNS_376(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_377()
	{
		init(9);
		_GIMMICK_PTTERNS_377(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_378()
	{
		init(7);
		_GIMMICK_PTTERNS_378(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_379()
	{
		init(8);
		_GIMMICK_PTTERNS_379(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_380()
	{
		init(6);
		_GIMMICK_PTTERNS_380(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_381()
	{
		init(9);
		_GIMMICK_PTTERNS_381(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_382()
	{
		init(7);
		_GIMMICK_PTTERNS_382(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_383()
	{
		init(8);
		_GIMMICK_PTTERNS_383(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_384()
	{
		init(6);
		_GIMMICK_PTTERNS_384(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_385()
	{
		init(9);
		_GIMMICK_PTTERNS_385(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_386()
	{
		init(7);
		_GIMMICK_PTTERNS_386(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_387()
	{
		init(8);
		_GIMMICK_PTTERNS_387(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_388()
	{
		init(6);
		_GIMMICK_PTTERNS_388(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_389()
	{
		init(9);
		_GIMMICK_PTTERNS_389(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_390()
	{
		init(7);
		_GIMMICK_PTTERNS_390(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_391()
	{
		init(8);
		_GIMMICK_PTTERNS_391(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_392()
	{
		init(6);
		_GIMMICK_PTTERNS_392(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_393()
	{
		init(9);
		_GIMMICK_PTTERNS_393(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_394()
	{
		init(7);
		_GIMMICK_PTTERNS_394(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_395()
	{
		init(8);
		_GIMMICK_PTTERNS_395(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_396()
	{
		init(6);
		_GIMMICK_PTTERNS_396(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_397()
	{
		init(9);
		_GIMMICK_PTTERNS_397(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_398()
	{
		init(7);
		_GIMMICK_PTTERNS_398(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_399()
	{
		init(8);
		_GIMMICK_PTTERNS_399(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_400()
	{
		init(6);
		_GIMMICK_PTTERNS_400(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_401()
	{
		init(9);
		_GIMMICK_PTTERNS_401(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_402()
	{
		init(7);
		_GIMMICK_PTTERNS_402(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_403()
	{
		init(8);
		_GIMMICK_PTTERNS_403(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_404()
	{
		init(6);
		_GIMMICK_PTTERNS_404(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_405()
	{
		init(9);
		_GIMMICK_PTTERNS_405(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_406()
	{
		init(7);
		_GIMMICK_PTTERNS_406(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_407()
	{
		init(8);
		_GIMMICK_PTTERNS_407(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_408()
	{
		init(6);
		_GIMMICK_PTTERNS_408(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_409()
	{
		init(9);
		_GIMMICK_PTTERNS_409(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_410()
	{
		init(7);
		_GIMMICK_PTTERNS_410(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_411()
	{
		init(8);
		_GIMMICK_PTTERNS_411(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_412()
	{
		init(6);
		_GIMMICK_PTTERNS_412(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_413()
	{
		init(9);
		_GIMMICK_PTTERNS_413(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_414()
	{
		init(7);
		_GIMMICK_PTTERNS_414(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_416()
	{
		init(8);
		_GIMMICK_PTTERNS_416(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_417()
	{
		init(6);
		_GIMMICK_PTTERNS_417(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_418()
	{
		init(9);
		_GIMMICK_PTTERNS_418(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_419()
	{
		init(7);
		_GIMMICK_PTTERNS_419(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_420()
	{
		init(8);
		_GIMMICK_PTTERNS_420(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_421()
	{
		init(6);
		_GIMMICK_PTTERNS_421(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_422()
	{
		init(9);
		_GIMMICK_PTTERNS_422(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_423()
	{
		init(7);
		_GIMMICK_PTTERNS_423(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_424()
	{
		init(8);
		_GIMMICK_PTTERNS_424(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_425()
	{
		init(6);
		_GIMMICK_PTTERNS_425(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_426()
	{
		init(9);
		_GIMMICK_PTTERNS_426(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_427()
	{
		init(7);
		_GIMMICK_PTTERNS_427(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_428()
	{
		init(8);
		_GIMMICK_PTTERNS_428(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_429()
	{
		init(6);
		_GIMMICK_PTTERNS_429(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_430()
	{
		init(9);
		_GIMMICK_PTTERNS_430(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_431()
	{
		init(7);
		_GIMMICK_PTTERNS_431(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_432()
	{
		init(8);
		_GIMMICK_PTTERNS_432(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_433()
	{
		init(6);
		_GIMMICK_PTTERNS_433(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_434()
	{
		init(9);
		_GIMMICK_PTTERNS_434(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_435()
	{
		init(7);
		_GIMMICK_PTTERNS_435(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_436()
	{
		init(8);
		_GIMMICK_PTTERNS_436(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_437()
	{
		init(6);
		_GIMMICK_PTTERNS_437(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_438()
	{
		init(9);
		_GIMMICK_PTTERNS_438(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_439()
	{
		init(7);
		_GIMMICK_PTTERNS_439(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_440()
	{
		init(8);
		_GIMMICK_PTTERNS_440(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_441()
	{
		init(6);
		_GIMMICK_PTTERNS_441(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_442()
	{
		init(9);
		_GIMMICK_PTTERNS_442(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_443()
	{
		init(7);
		_GIMMICK_PTTERNS_443(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_444()
	{
		init(8);
		_GIMMICK_PTTERNS_444(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_445()
	{
		init(6);
		_GIMMICK_PTTERNS_445(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_446()
	{
		init(9);
		_GIMMICK_PTTERNS_446(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_447()
	{
		init(7);
		_GIMMICK_PTTERNS_447(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_448()
	{
		init(8);
		_GIMMICK_PTTERNS_448(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_449()
	{
		init(6);
		_GIMMICK_PTTERNS_449(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_450()
	{
		init(9);
		_GIMMICK_PTTERNS_450(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_451()
	{
		init(7);
		_GIMMICK_PTTERNS_451(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_452()
	{
		init(8);
		_GIMMICK_PTTERNS_452(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_453()
	{
		init(6);
		_GIMMICK_PTTERNS_453(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_454()
	{
		init(9);
		_GIMMICK_PTTERNS_454(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_455()
	{
		init(7);
		_GIMMICK_PTTERNS_455(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_456()
	{
		init(8);
		_GIMMICK_PTTERNS_456(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_457()
	{
		init(6);
		_GIMMICK_PTTERNS_457(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_458()
	{
		init(9);
		_GIMMICK_PTTERNS_458(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_459()
	{
		init(7);
		_GIMMICK_PTTERNS_459(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_460()
	{
		init(8);
		_GIMMICK_PTTERNS_460(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_461()
	{
		init(6);
		_GIMMICK_PTTERNS_461(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_462()
	{
		init(9);
		_GIMMICK_PTTERNS_462(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_463()
	{
		init(7);
		_GIMMICK_PTTERNS_463(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_464()
	{
		init(8);
		_GIMMICK_PTTERNS_464(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_465()
	{
		init(6);
		_GIMMICK_PTTERNS_465(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_466()
	{
		init(9);
		_GIMMICK_PTTERNS_466(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_467()
	{
		init(7);
		_GIMMICK_PTTERNS_467(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_468()
	{
		init(8);
		_GIMMICK_PTTERNS_468(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_469()
	{
		init(6);
		_GIMMICK_PTTERNS_469(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_470()
	{
		init(9);
		_GIMMICK_PTTERNS_470(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_471()
	{
		init(7);
		_GIMMICK_PTTERNS_471(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_472()
	{
		init(8);
		_GIMMICK_PTTERNS_472(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_473()
	{
		init(8);
		_GIMMICK_PTTERNS_473(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_474()
	{
		init(6);
		_GIMMICK_PTTERNS_474(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_475()
	{
		init(9);
		_GIMMICK_PTTERNS_475(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_476()
	{
		init(7);
		_GIMMICK_PTTERNS_476(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_479()
	{
		init(8);
		_GIMMICK_PTTERNS_479(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_480()
	{
		init(6);
		_GIMMICK_PTTERNS_480(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_481()
	{
		init(9);
		_GIMMICK_PTTERNS_481(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_482()
	{
		init(7);
		_GIMMICK_PTTERNS_482(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_485()
	{
		init(8);
		_GIMMICK_PTTERNS_485(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_486()
	{
		init(6);
		_GIMMICK_PTTERNS_486(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_487()
	{
		init(9);
		_GIMMICK_PTTERNS_487(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_488()
	{
		init(7);
		_GIMMICK_PTTERNS_488(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_491()
	{
		init(8);
		_GIMMICK_PTTERNS_491(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_492()
	{
		init(6);
		_GIMMICK_PTTERNS_492(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_493()
	{
		init(9);
		_GIMMICK_PTTERNS_493(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_494()
	{
		init(7);
		_GIMMICK_PTTERNS_494(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_498()
	{
		init(8);
		_GIMMICK_PTTERNS_498(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_499()
	{
		init(6);
		_GIMMICK_PTTERNS_499(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_500()
	{
		init(9);
		_GIMMICK_PTTERNS_500(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_501()
	{
		init(7);
		_GIMMICK_PTTERNS_501(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_504()
	{
		init(8);
		_GIMMICK_PTTERNS_504(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_505()
	{
		init(6);
		_GIMMICK_PTTERNS_505(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_506()
	{
		init(9);
		_GIMMICK_PTTERNS_506(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_507()
	{
		init(7);
		_GIMMICK_PTTERNS_507(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_510()
	{
		init(8);
		_GIMMICK_PTTERNS_510(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_511()
	{
		init(6);
		_GIMMICK_PTTERNS_511(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_512()
	{
		init(9);
		_GIMMICK_PTTERNS_512(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_513()
	{
		init(7);
		_GIMMICK_PTTERNS_513(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_515()
	{
		init(7);
		_GIMMICK_PTTERNS_515(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_516()
	{
		init(6);
		_GIMMICK_PTTERNS_516(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_517()
	{
		init(6);
		_GIMMICK_PTTERNS_517(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_518()
	{
		init(7);
		_GIMMICK_PTTERNS_518(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_519()
	{
		init(8);
		_GIMMICK_PTTERNS_519(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_520()
	{
		init(6);
		_GIMMICK_PTTERNS_520(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_521()
	{
		init(9);
		_GIMMICK_PTTERNS_521(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_522()
	{
		init(7);
		_GIMMICK_PTTERNS_522(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_525()
	{
		init(8);
		_GIMMICK_PTTERNS_525(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_526()
	{
		init(6);
		_GIMMICK_PTTERNS_526(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_527()
	{
		init(9);
		_GIMMICK_PTTERNS_527(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_528()
	{
		init(7);
		_GIMMICK_PTTERNS_528(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_531()
	{
		init(8);
		_GIMMICK_PTTERNS_531(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_532()
	{
		init(6);
		_GIMMICK_PTTERNS_532(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_533()
	{
		init(9);
		_GIMMICK_PTTERNS_533(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_534()
	{
		init(7);
		_GIMMICK_PTTERNS_534(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_536()
	{
		init(6);
		_GIMMICK_PTTERNS_536(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_537()
	{
		init(6);
		_GIMMICK_PTTERNS_537(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_538()
	{
		init(7);
		_GIMMICK_PTTERNS_538(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_539()
	{
		init(8);
		_GIMMICK_PTTERNS_539(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_540()
	{
		init(6);
		_GIMMICK_PTTERNS_540(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_541()
	{
		init(9);
		_GIMMICK_PTTERNS_541(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_542()
	{
		init(7);
		_GIMMICK_PTTERNS_542(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_545()
	{
		init(8);
		_GIMMICK_PTTERNS_545(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_546()
	{
		init(6);
		_GIMMICK_PTTERNS_546(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_547()
	{
		init(9);
		_GIMMICK_PTTERNS_547(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_548()
	{
		init(7);
		_GIMMICK_PTTERNS_548(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_551()
	{
		init(8);
		_GIMMICK_PTTERNS_551(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_552()
	{
		init(6);
		_GIMMICK_PTTERNS_552(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_553()
	{
		init(9);
		_GIMMICK_PTTERNS_553(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_554()
	{
		init(7);
		_GIMMICK_PTTERNS_554(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_556()
	{
		init(6);
		_GIMMICK_PTTERNS_556(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_557()
	{
		init(6);
		_GIMMICK_PTTERNS_557(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_558()
	{
		init(7);
		_GIMMICK_PTTERNS_558(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_559()
	{
		init(8);
		_GIMMICK_PTTERNS_559(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_560()
	{
		init(6);
		_GIMMICK_PTTERNS_560(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_561()
	{
		init(9);
		_GIMMICK_PTTERNS_561(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_562()
	{
		init(7);
		_GIMMICK_PTTERNS_562(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_565()
	{
		init(8);
		_GIMMICK_PTTERNS_565(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_566()
	{
		init(6);
		_GIMMICK_PTTERNS_566(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_567()
	{
		init(9);
		_GIMMICK_PTTERNS_567(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_568()
	{
		init(7);
		_GIMMICK_PTTERNS_568(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_571()
	{
		init(8);
		_GIMMICK_PTTERNS_571(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_572()
	{
		init(6);
		_GIMMICK_PTTERNS_572(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_573()
	{
		init(9);
		_GIMMICK_PTTERNS_573(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_574()
	{
		init(7);
		_GIMMICK_PTTERNS_574(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_576()
	{
		init(6);
		_GIMMICK_PTTERNS_576(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_577()
	{
		init(6);
		_GIMMICK_PTTERNS_577(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_578()
	{
		init(7);
		_GIMMICK_PTTERNS_578(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_579()
	{
		init(8);
		_GIMMICK_PTTERNS_579(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_580()
	{
		init(6);
		_GIMMICK_PTTERNS_580(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_581()
	{
		init(9);
		_GIMMICK_PTTERNS_581(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_582()
	{
		init(7);
		_GIMMICK_PTTERNS_582(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_585()
	{
		init(8);
		_GIMMICK_PTTERNS_585(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_586()
	{
		init(6);
		_GIMMICK_PTTERNS_586(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_587()
	{
		init(9);
		_GIMMICK_PTTERNS_587(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_588()
	{
		init(7);
		_GIMMICK_PTTERNS_588(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_591()
	{
		init(8);
		_GIMMICK_PTTERNS_591(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_592()
	{
		init(6);
		_GIMMICK_PTTERNS_592(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_593()
	{
		init(9);
		_GIMMICK_PTTERNS_593(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_594()
	{
		init(7);
		_GIMMICK_PTTERNS_594(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_596()
	{
		init(6);
		_GIMMICK_PTTERNS_596(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_597()
	{
		init(6);
		_GIMMICK_PTTERNS_597(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_598()
	{
		init(7);
		_GIMMICK_PTTERNS_598(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_599()
	{
		init(8);
		_GIMMICK_PTTERNS_599(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_600()
	{
		init(6);
		_GIMMICK_PTTERNS_600(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_601()
	{
		init(9);
		_GIMMICK_PTTERNS_601(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_602()
	{
		init(7);
		_GIMMICK_PTTERNS_602(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_605()
	{
		init(8);
		_GIMMICK_PTTERNS_605(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_606()
	{
		init(6);
		_GIMMICK_PTTERNS_606(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_607()
	{
		init(9);
		_GIMMICK_PTTERNS_607(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_608()
	{
		init(7);
		_GIMMICK_PTTERNS_608(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_611()
	{
		init(8);
		_GIMMICK_PTTERNS_611(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_612()
	{
		init(6);
		_GIMMICK_PTTERNS_612(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_613()
	{
		init(9);
		_GIMMICK_PTTERNS_613(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_614()
	{
		init(7);
		_GIMMICK_PTTERNS_614(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_616()
	{
		init(8);
		_GIMMICK_PTTERNS_616(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_617()
	{
		init(6);
		_GIMMICK_PTTERNS_617(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_618()
	{
		init(9);
		_GIMMICK_PTTERNS_618(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_619()
	{
		init(7);
		_GIMMICK_PTTERNS_619(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_620()
	{
		init(8);
		_GIMMICK_PTTERNS_620(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_621()
	{
		init(6);
		_GIMMICK_PTTERNS_621(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_622()
	{
		init(9);
		_GIMMICK_PTTERNS_622(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_623()
	{
		init(7);
		_GIMMICK_PTTERNS_623(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_624()
	{
		init(8);
		_GIMMICK_PTTERNS_624(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_625()
	{
		init(6);
		_GIMMICK_PTTERNS_625(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_626()
	{
		init(9);
		_GIMMICK_PTTERNS_626(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_627()
	{
		init(7);
		_GIMMICK_PTTERNS_627(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_628()
	{
		init(8);
		_GIMMICK_PTTERNS_628(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_629()
	{
		init(6);
		_GIMMICK_PTTERNS_629(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_630()
	{
		init(9);
		_GIMMICK_PTTERNS_630(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_631()
	{
		init(7);
		_GIMMICK_PTTERNS_631(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_633()
	{
		init(8);
		_GIMMICK_PTTERNS_633(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_634()
	{
		init(6);
		_GIMMICK_PTTERNS_634(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_635()
	{
		init(9);
		_GIMMICK_PTTERNS_635(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_636()
	{
		init(7);
		_GIMMICK_PTTERNS_636(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_637()
	{
		init(8);
		_GIMMICK_PTTERNS_637(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_638()
	{
		init(6);
		_GIMMICK_PTTERNS_638(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_639()
	{
		init(9);
		_GIMMICK_PTTERNS_639(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_640()
	{
		init(7);
		_GIMMICK_PTTERNS_640(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_641()
	{
		init(8);
		_GIMMICK_PTTERNS_641(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_642()
	{
		init(6);
		_GIMMICK_PTTERNS_642(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_643()
	{
		init(9);
		_GIMMICK_PTTERNS_643(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_644()
	{
		init(7);
		_GIMMICK_PTTERNS_644(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_645()
	{
		init(8);
		_GIMMICK_PTTERNS_645(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_646()
	{
		init(6);
		_GIMMICK_PTTERNS_646(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_647()
	{
		init(9);
		_GIMMICK_PTTERNS_647(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_648()
	{
		init(7);
		_GIMMICK_PTTERNS_648(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_649()
	{
		init(8);
		_GIMMICK_PTTERNS_649(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_650()
	{
		init(6);
		_GIMMICK_PTTERNS_650(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_651()
	{
		init(9);
		_GIMMICK_PTTERNS_651(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_652()
	{
		init(7);
		_GIMMICK_PTTERNS_652(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_653()
	{
		init(8);
		_GIMMICK_PTTERNS_653(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_654()
	{
		init(6);
		_GIMMICK_PTTERNS_654(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_655()
	{
		init(9);
		_GIMMICK_PTTERNS_655(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_656()
	{
		init(7);
		_GIMMICK_PTTERNS_656(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_657()
	{
		init(8);
		_GIMMICK_PTTERNS_657(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_658()
	{
		init(6);
		_GIMMICK_PTTERNS_658(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_659()
	{
		init(9);
		_GIMMICK_PTTERNS_659(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_660()
	{
		init(7);
		_GIMMICK_PTTERNS_660(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_661()
	{
		init(8);
		_GIMMICK_PTTERNS_661(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_662()
	{
		init(6);
		_GIMMICK_PTTERNS_662(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_663()
	{
		init(9);
		_GIMMICK_PTTERNS_663(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_664()
	{
		init(7);
		_GIMMICK_PTTERNS_664(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_665()
	{
		init(8);
		_GIMMICK_PTTERNS_665(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_666()
	{
		init(6);
		_GIMMICK_PTTERNS_666(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_667()
	{
		init(9);
		_GIMMICK_PTTERNS_667(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_668()
	{
		init(7);
		_GIMMICK_PTTERNS_668(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_669()
	{
		init(8);
		_GIMMICK_PTTERNS_669(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_670()
	{
		init(6);
		_GIMMICK_PTTERNS_670(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_671()
	{
		init(9);
		_GIMMICK_PTTERNS_671(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_672()
	{
		init(7);
		_GIMMICK_PTTERNS_672(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_673()
	{
		init(8);
		_GIMMICK_PTTERNS_673(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_674()
	{
		init(6);
		_GIMMICK_PTTERNS_674(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_675()
	{
		init(9);
		_GIMMICK_PTTERNS_675(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_676()
	{
		init(7);
		_GIMMICK_PTTERNS_676(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_677()
	{
		init(8);
		_GIMMICK_PTTERNS_677(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_678()
	{
		init(6);
		_GIMMICK_PTTERNS_678(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_679()
	{
		init(9);
		_GIMMICK_PTTERNS_679(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_680()
	{
		init(7);
		_GIMMICK_PTTERNS_680(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_681()
	{
		init(8);
		_GIMMICK_PTTERNS_681(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_682()
	{
		init(6);
		_GIMMICK_PTTERNS_682(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_683()
	{
		init(9);
		_GIMMICK_PTTERNS_683(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_684()
	{
		init(7);
		_GIMMICK_PTTERNS_684(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_685()
	{
		init(7);
		_GIMMICK_PTTERNS_685(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_686()
	{
		init(8);
		_GIMMICK_PTTERNS_686(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_687()
	{
		init(6);
		_GIMMICK_PTTERNS_687(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_688()
	{
		init(9);
		_GIMMICK_PTTERNS_688(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_689()
	{
		init(7);
		_GIMMICK_PTTERNS_689(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_690()
	{
		init(8);
		_GIMMICK_PTTERNS_690(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_691()
	{
		init(6);
		_GIMMICK_PTTERNS_691(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_692()
	{
		init(9);
		_GIMMICK_PTTERNS_692(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_693()
	{
		init(7);
		_GIMMICK_PTTERNS_693(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_694()
	{
		init(8);
		_GIMMICK_PTTERNS_694(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_695()
	{
		init(6);
		_GIMMICK_PTTERNS_695(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_696()
	{
		init(9);
		_GIMMICK_PTTERNS_696(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_697()
	{
		init(7);
		_GIMMICK_PTTERNS_697(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_698()
	{
		init(6);
		_GIMMICK_PTTERNS_698(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_699()
	{
		init(7);
		_GIMMICK_PTTERNS_699(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_700()
	{
		init(8);
		_GIMMICK_PTTERNS_700(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_701()
	{
		init(6);
		_GIMMICK_PTTERNS_701(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_702()
	{
		init(9);
		_GIMMICK_PTTERNS_702(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_703()
	{
		init(7);
		_GIMMICK_PTTERNS_703(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_704()
	{
		init(8);
		_GIMMICK_PTTERNS_704(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_705()
	{
		init(6);
		_GIMMICK_PTTERNS_705(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_706()
	{
		init(9);
		_GIMMICK_PTTERNS_706(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_707()
	{
		init(7);
		_GIMMICK_PTTERNS_707(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_708()
	{
		init(8);
		_GIMMICK_PTTERNS_708(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_709()
	{
		init(6);
		_GIMMICK_PTTERNS_709(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_710()
	{
		init(9);
		_GIMMICK_PTTERNS_710(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_711()
	{
		init(7);
		_GIMMICK_PTTERNS_711(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_712()
	{
		init(6);
		_GIMMICK_PTTERNS_712(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_713()
	{
		init(7);
		_GIMMICK_PTTERNS_713(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_714()
	{
		init(8);
		_GIMMICK_PTTERNS_714(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_715()
	{
		init(6);
		_GIMMICK_PTTERNS_715(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_716()
	{
		init(9);
		_GIMMICK_PTTERNS_716(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_717()
	{
		init(7);
		_GIMMICK_PTTERNS_717(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_718()
	{
		init(8);
		_GIMMICK_PTTERNS_718(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_719()
	{
		init(6);
		_GIMMICK_PTTERNS_719(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_720()
	{
		init(9);
		_GIMMICK_PTTERNS_720(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_721()
	{
		init(7);
		_GIMMICK_PTTERNS_721(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_722()
	{
		init(8);
		_GIMMICK_PTTERNS_722(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_723()
	{
		init(6);
		_GIMMICK_PTTERNS_723(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_724()
	{
		init(9);
		_GIMMICK_PTTERNS_724(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_725()
	{
		init(7);
		_GIMMICK_PTTERNS_725(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_726()
	{
		init(8);
		_GIMMICK_PTTERNS_726(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_727()
	{
		init(6);
		_GIMMICK_PTTERNS_727(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_728()
	{
		init(9);
		_GIMMICK_PTTERNS_728(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_729()
	{
		init(7);
		_GIMMICK_PTTERNS_729(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_730()
	{
		init(8);
		_GIMMICK_PTTERNS_730(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_731()
	{
		init(6);
		_GIMMICK_PTTERNS_731(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_732()
	{
		init(9);
		_GIMMICK_PTTERNS_732(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_733()
	{
		init(7);
		_GIMMICK_PTTERNS_733(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_737()
	{
		init(8);
		_GIMMICK_PTTERNS_737(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_738()
	{
		init(6);
		_GIMMICK_PTTERNS_738(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_739()
	{
		init(9);
		_GIMMICK_PTTERNS_739(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_740()
	{
		init(7);
		_GIMMICK_PTTERNS_740(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_741()
	{
		init(8);
		_GIMMICK_PTTERNS_741(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_742()
	{
		init(6);
		_GIMMICK_PTTERNS_742(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_743()
	{
		init(9);
		_GIMMICK_PTTERNS_743(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_744()
	{
		init(7);
		_GIMMICK_PTTERNS_744(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_745()
	{
		init(8);
		_GIMMICK_PTTERNS_745(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_746()
	{
		init(8);
		_GIMMICK_PTTERNS_746(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_747()
	{
		init(8);
		_GIMMICK_PTTERNS_747(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_748()
	{
		init(8);
		_GIMMICK_PTTERNS_748(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_749()
	{
		init(8);
		_GIMMICK_PTTERNS_749(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_750()
	{
		init(8);
		_GIMMICK_PTTERNS_750(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_751()
	{
		init(6);
		_GIMMICK_PTTERNS_751(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_752()
	{
		init(9);
		_GIMMICK_PTTERNS_752(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_753()
	{
		init(7);
		_GIMMICK_PTTERNS_753(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_754()
	{
		init(8);
		_GIMMICK_PTTERNS_754(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_755()
	{
		init(6);
		_GIMMICK_PTTERNS_755(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_756()
	{
		init(9);
		_GIMMICK_PTTERNS_756(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_757()
	{
		init(7);
		_GIMMICK_PTTERNS_757(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_760()
	{
		init(8);
		_GIMMICK_PTTERNS_760(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_761()
	{
		init(6);
		_GIMMICK_PTTERNS_761(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_762()
	{
		init(9);
		_GIMMICK_PTTERNS_762(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_763()
	{
		init(7);
		_GIMMICK_PTTERNS_763(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_766()
	{
		init(8);
		_GIMMICK_PTTERNS_766(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_767()
	{
		init(6);
		_GIMMICK_PTTERNS_767(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_768()
	{
		init(9);
		_GIMMICK_PTTERNS_768(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_769()
	{
		init(7);
		_GIMMICK_PTTERNS_769(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_772()
	{
		init(8);
		_GIMMICK_PTTERNS_772(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_773()
	{
		init(6);
		_GIMMICK_PTTERNS_773(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_774()
	{
		init(9);
		_GIMMICK_PTTERNS_774(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_775()
	{
		init(7);
		_GIMMICK_PTTERNS_775(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_778()
	{
		init(8);
		_GIMMICK_PTTERNS_778(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_779()
	{
		init(6);
		_GIMMICK_PTTERNS_779(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_780()
	{
		init(9);
		_GIMMICK_PTTERNS_780(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_781()
	{
		init(7);
		_GIMMICK_PTTERNS_781(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_784()
	{
		init(8);
		_GIMMICK_PTTERNS_784(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_785()
	{
		init(6);
		_GIMMICK_PTTERNS_785(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_786()
	{
		init(9);
		_GIMMICK_PTTERNS_786(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_787()
	{
		init(7);
		_GIMMICK_PTTERNS_787(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_790()
	{
		init(8);
		_GIMMICK_PTTERNS_790(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_791()
	{
		init(6);
		_GIMMICK_PTTERNS_791(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_792()
	{
		init(9);
		_GIMMICK_PTTERNS_792(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_793()
	{
		init(7);
		_GIMMICK_PTTERNS_793(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_794()
	{
		init(8);
		_GIMMICK_PTTERNS_794(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_795()
	{
		init(6);
		_GIMMICK_PTTERNS_795(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_796()
	{
		init(9);
		_GIMMICK_PTTERNS_796(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_797()
	{
		init(7);
		_GIMMICK_PTTERNS_797(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_798()
	{
		init(8);
		_GIMMICK_PTTERNS_798(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_799()
	{
		init(6);
		_GIMMICK_PTTERNS_799(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_800()
	{
		init(9);
		_GIMMICK_PTTERNS_800(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_801()
	{
		init(7);
		_GIMMICK_PTTERNS_801(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_802()
	{
		init(8);
		_GIMMICK_PTTERNS_802(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_803()
	{
		init(6);
		_GIMMICK_PTTERNS_803(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_804()
	{
		init(9);
		_GIMMICK_PTTERNS_804(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_805()
	{
		init(7);
		_GIMMICK_PTTERNS_805(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_806()
	{
		init(8);
		_GIMMICK_PTTERNS_806(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_807()
	{
		init(6);
		_GIMMICK_PTTERNS_807(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_808()
	{
		init(9);
		_GIMMICK_PTTERNS_808(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_809()
	{
		init(7);
		_GIMMICK_PTTERNS_809(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_810()
	{
		init(8);
		_GIMMICK_PTTERNS_810(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_811()
	{
		init(6);
		_GIMMICK_PTTERNS_811(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_812()
	{
		init(9);
		_GIMMICK_PTTERNS_812(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_813()
	{
		init(7);
		_GIMMICK_PTTERNS_813(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_814()
	{
		init(8);
		_GIMMICK_PTTERNS_814(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_815()
	{
		init(6);
		_GIMMICK_PTTERNS_815(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_816()
	{
		init(9);
		_GIMMICK_PTTERNS_816(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_817()
	{
		init(7);
		_GIMMICK_PTTERNS_817(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_818()
	{
		init(8);
		_GIMMICK_PTTERNS_818(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_819()
	{
		init(6);
		_GIMMICK_PTTERNS_819(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_820()
	{
		init(9);
		_GIMMICK_PTTERNS_820(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_821()
	{
		init(7);
		_GIMMICK_PTTERNS_821(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_822()
	{
		init(8);
		_GIMMICK_PTTERNS_822(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_823()
	{
		init(6);
		_GIMMICK_PTTERNS_823(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_824()
	{
		init(9);
		_GIMMICK_PTTERNS_824(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_825()
	{
		init(7);
		_GIMMICK_PTTERNS_825(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_826()
	{
		init(8);
		_GIMMICK_PTTERNS_826(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_827()
	{
		init(6);
		_GIMMICK_PTTERNS_827(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_828()
	{
		init(9);
		_GIMMICK_PTTERNS_828(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_829()
	{
		init(7);
		_GIMMICK_PTTERNS_829(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_830()
	{
		init(8);
		_GIMMICK_PTTERNS_830(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_831()
	{
		init(6);
		_GIMMICK_PTTERNS_831(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_832()
	{
		init(9);
		_GIMMICK_PTTERNS_832(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_833()
	{
		init(7);
		_GIMMICK_PTTERNS_833(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_834()
	{
		init(8);
		_GIMMICK_PTTERNS_834(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_835()
	{
		init(6);
		_GIMMICK_PTTERNS_835(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_836()
	{
		init(9);
		_GIMMICK_PTTERNS_836(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_837()
	{
		init(7);
		_GIMMICK_PTTERNS_837(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_838()
	{
		init(8);
		_GIMMICK_PTTERNS_838(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_839()
	{
		init(6);
		_GIMMICK_PTTERNS_839(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_840()
	{
		init(9);
		_GIMMICK_PTTERNS_840(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_841()
	{
		init(7);
		_GIMMICK_PTTERNS_841(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_842()
	{
		init(8);
		_GIMMICK_PTTERNS_842(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_843()
	{
		init(6);
		_GIMMICK_PTTERNS_843(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_844()
	{
		init(9);
		_GIMMICK_PTTERNS_844(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_845()
	{
		init(7);
		_GIMMICK_PTTERNS_845(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_846()
	{
		init(8);
		_GIMMICK_PTTERNS_846(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_847()
	{
		init(6);
		_GIMMICK_PTTERNS_847(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_848()
	{
		init(9);
		_GIMMICK_PTTERNS_848(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_849()
	{
		init(7);
		_GIMMICK_PTTERNS_849(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_850()
	{
		init(8);
		_GIMMICK_PTTERNS_850(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_851()
	{
		init(8);
		_GIMMICK_PTTERNS_851(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_852()
	{
		init(6);
		_GIMMICK_PTTERNS_852(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_853()
	{
		init(9);
		_GIMMICK_PTTERNS_853(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_854()
	{
		init(7);
		_GIMMICK_PTTERNS_854(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_855()
	{
		init(8);
		_GIMMICK_PTTERNS_855(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_856()
	{
		init(6);
		_GIMMICK_PTTERNS_856(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_857()
	{
		init(9);
		_GIMMICK_PTTERNS_857(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_858()
	{
		init(7);
		_GIMMICK_PTTERNS_858(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_859()
	{
		init(8);
		_GIMMICK_PTTERNS_859(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_860()
	{
		init(6);
		_GIMMICK_PTTERNS_860(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_861()
	{
		init(9);
		_GIMMICK_PTTERNS_861(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_862()
	{
		init(7);
		_GIMMICK_PTTERNS_862(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_863()
	{
		init(8);
		_GIMMICK_PTTERNS_863(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_864()
	{
		init(6);
		_GIMMICK_PTTERNS_864(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_865()
	{
		init(9);
		_GIMMICK_PTTERNS_865(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_866()
	{
		init(7);
		_GIMMICK_PTTERNS_866(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_867()
	{
		init(8);
		_GIMMICK_PTTERNS_867(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_868()
	{
		init(6);
		_GIMMICK_PTTERNS_868(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_869()
	{
		init(9);
		_GIMMICK_PTTERNS_869(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_870()
	{
		init(7);
		_GIMMICK_PTTERNS_870(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_871()
	{
		init(8);
		_GIMMICK_PTTERNS_871(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_872()
	{
		init(6);
		_GIMMICK_PTTERNS_872(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_873()
	{
		init(9);
		_GIMMICK_PTTERNS_873(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_874()
	{
		init(7);
		_GIMMICK_PTTERNS_874(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_875()
	{
		init(8);
		_GIMMICK_PTTERNS_875(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_876()
	{
		init(6);
		_GIMMICK_PTTERNS_876(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_877()
	{
		init(9);
		_GIMMICK_PTTERNS_877(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_878()
	{
		init(7);
		_GIMMICK_PTTERNS_878(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_879()
	{
		init(8);
		_GIMMICK_PTTERNS_879(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_880()
	{
		init(6);
		_GIMMICK_PTTERNS_880(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_881()
	{
		init(9);
		_GIMMICK_PTTERNS_881(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_882()
	{
		init(7);
		_GIMMICK_PTTERNS_882(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_883()
	{
		init(8);
		_GIMMICK_PTTERNS_883(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_884()
	{
		init(6);
		_GIMMICK_PTTERNS_884(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_885()
	{
		init(9);
		_GIMMICK_PTTERNS_885(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_886()
	{
		init(7);
		_GIMMICK_PTTERNS_886(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_887()
	{
		init(8);
		_GIMMICK_PTTERNS_887(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_888()
	{
		init(6);
		_GIMMICK_PTTERNS_888(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_889()
	{
		init(9);
		_GIMMICK_PTTERNS_889(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_890()
	{
		init(7);
		_GIMMICK_PTTERNS_890(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_891()
	{
		init(8);
		_GIMMICK_PTTERNS_891(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_892()
	{
		init(8);
		_GIMMICK_PTTERNS_892(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_893()
	{
		init(6);
		_GIMMICK_PTTERNS_893(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_894()
	{
		init(9);
		_GIMMICK_PTTERNS_894(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_895()
	{
		init(7);
		_GIMMICK_PTTERNS_895(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_896()
	{
		init(8);
		_GIMMICK_PTTERNS_896(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_897()
	{
		init(6);
		_GIMMICK_PTTERNS_897(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_898()
	{
		init(9);
		_GIMMICK_PTTERNS_898(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_899()
	{
		init(7);
		_GIMMICK_PTTERNS_899(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_901()
	{
		init(8);
		_GIMMICK_PTTERNS_901(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_902()
	{
		init(6);
		_GIMMICK_PTTERNS_902(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_903()
	{
		init(9);
		_GIMMICK_PTTERNS_903(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_904()
	{
		init(7);
		_GIMMICK_PTTERNS_904(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_906()
	{
		init(8);
		_GIMMICK_PTTERNS_906(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_908()
	{
		init(8);
		_GIMMICK_PTTERNS_908(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_909()
	{
		init(6);
		_GIMMICK_PTTERNS_909(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_910()
	{
		init(9);
		_GIMMICK_PTTERNS_910(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_911()
	{
		init(7);
		_GIMMICK_PTTERNS_911(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_912()
	{
		init(8);
		_GIMMICK_PTTERNS_912(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_913()
	{
		init(6);
		_GIMMICK_PTTERNS_913(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_914()
	{
		init(9);
		_GIMMICK_PTTERNS_914(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_915()
	{
		init(7);
		_GIMMICK_PTTERNS_915(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_917()
	{
		init(8);
		_GIMMICK_PTTERNS_917(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_918()
	{
		init(8);
		_GIMMICK_PTTERNS_918(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_919()
	{
		init(6);
		_GIMMICK_PTTERNS_919(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_920()
	{
		init(9);
		_GIMMICK_PTTERNS_920(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_921()
	{
		init(7);
		_GIMMICK_PTTERNS_921(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_922()
	{
		init(8);
		_GIMMICK_PTTERNS_922(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_923()
	{
		init(6);
		_GIMMICK_PTTERNS_923(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_924()
	{
		init(9);
		_GIMMICK_PTTERNS_924(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_925()
	{
		init(7);
		_GIMMICK_PTTERNS_925(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_926()
	{
		init(8);
		_GIMMICK_PTTERNS_926(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_927()
	{
		init(6);
		_GIMMICK_PTTERNS_927(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_928()
	{
		init(9);
		_GIMMICK_PTTERNS_928(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_929()
	{
		init(7);
		_GIMMICK_PTTERNS_929(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_930()
	{
		init(8);
		_GIMMICK_PTTERNS_930(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_931()
	{
		init(8);
		_GIMMICK_PTTERNS_931(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_932()
	{
		init(6);
		_GIMMICK_PTTERNS_932(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_933()
	{
		init(9);
		_GIMMICK_PTTERNS_933(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_934()
	{
		init(7);
		_GIMMICK_PTTERNS_934(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_935()
	{
		init(8);
		_GIMMICK_PTTERNS_935(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_936()
	{
		init(8);
		_GIMMICK_PTTERNS_936(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_937()
	{
		init(6);
		_GIMMICK_PTTERNS_937(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_938()
	{
		init(9);
		_GIMMICK_PTTERNS_938(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_939()
	{
		init(7);
		_GIMMICK_PTTERNS_939(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_940()
	{
		init(8);
		_GIMMICK_PTTERNS_940(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_941()
	{
		init(6);
		_GIMMICK_PTTERNS_941(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_942()
	{
		init(9);
		_GIMMICK_PTTERNS_942(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_943()
	{
		init(7);
		_GIMMICK_PTTERNS_943(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_944()
	{
		init(8);
		_GIMMICK_PTTERNS_944(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_945()
	{
		init(6);
		_GIMMICK_PTTERNS_945(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_946()
	{
		init(9);
		_GIMMICK_PTTERNS_946(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_947()
	{
		init(7);
		_GIMMICK_PTTERNS_947(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_948()
	{
		init(8);
		_GIMMICK_PTTERNS_948(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_949()
	{
		init(6);
		_GIMMICK_PTTERNS_949(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_950()
	{
		init(9);
		_GIMMICK_PTTERNS_950(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_951()
	{
		init(7);
		_GIMMICK_PTTERNS_951(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_953()
	{
		init(8);
		_GIMMICK_PTTERNS_953(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_954()
	{
		init(6);
		_GIMMICK_PTTERNS_954(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_955()
	{
		init(9);
		_GIMMICK_PTTERNS_955(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_956()
	{
		init(7);
		_GIMMICK_PTTERNS_956(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_957()
	{
		init(8);
		_GIMMICK_PTTERNS_957(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_958()
	{
		init(6);
		_GIMMICK_PTTERNS_958(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_959()
	{
		init(9);
		_GIMMICK_PTTERNS_959(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_960()
	{
		init(7);
		_GIMMICK_PTTERNS_960(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_962()
	{
		init(8);
		_GIMMICK_PTTERNS_962(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_963()
	{
		init(6);
		_GIMMICK_PTTERNS_963(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_964()
	{
		init(9);
		_GIMMICK_PTTERNS_964(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_965()
	{
		init(7);
		_GIMMICK_PTTERNS_965(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_966()
	{
		init(8);
		_GIMMICK_PTTERNS_966(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_967()
	{
		init(6);
		_GIMMICK_PTTERNS_967(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_968()
	{
		init(9);
		_GIMMICK_PTTERNS_968(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_969()
	{
		init(7);
		_GIMMICK_PTTERNS_969(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_974()
	{
		init(8);
		_GIMMICK_PTTERNS_974(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_975()
	{
		init(6);
		_GIMMICK_PTTERNS_975(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_976()
	{
		init(9);
		_GIMMICK_PTTERNS_976(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_977()
	{
		init(7);
		_GIMMICK_PTTERNS_977(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_978()
	{
		init(8);
		_GIMMICK_PTTERNS_978(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_979()
	{
		init(6);
		_GIMMICK_PTTERNS_979(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_980()
	{
		init(9);
		_GIMMICK_PTTERNS_980(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_981()
	{
		init(7);
		_GIMMICK_PTTERNS_981(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_982()
	{
		init(8);
		_GIMMICK_PTTERNS_982(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_983()
	{
		init(6);
		_GIMMICK_PTTERNS_983(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_984()
	{
		init(9);
		_GIMMICK_PTTERNS_984(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_985()
	{
		init(7);
		_GIMMICK_PTTERNS_985(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_986()
	{
		init(8);
		_GIMMICK_PTTERNS_986(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_987()
	{
		init(6);
		_GIMMICK_PTTERNS_987(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_988()
	{
		init(9);
		_GIMMICK_PTTERNS_988(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_989()
	{
		init(7);
		_GIMMICK_PTTERNS_989(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_990()
	{
		init(8);
		_GIMMICK_PTTERNS_990(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_991()
	{
		init(6);
		_GIMMICK_PTTERNS_991(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_992()
	{
		init(9);
		_GIMMICK_PTTERNS_992(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_993()
	{
		init(7);
		_GIMMICK_PTTERNS_993(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_994()
	{
		init(8);
		_GIMMICK_PTTERNS_994(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_995()
	{
		init(6);
		_GIMMICK_PTTERNS_995(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_996()
	{
		init(9);
		_GIMMICK_PTTERNS_996(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_997()
	{
		init(7);
		_GIMMICK_PTTERNS_997(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_998()
	{
		init(8);
		_GIMMICK_PTTERNS_998(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_999()
	{
		init(6);
		_GIMMICK_PTTERNS_999(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1000()
	{
		init(9);
		_GIMMICK_PTTERNS_1000(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1001()
	{
		init(7);
		_GIMMICK_PTTERNS_1001(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1002()
	{
		init(8);
		_GIMMICK_PTTERNS_1002(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1003()
	{
		init(6);
		_GIMMICK_PTTERNS_1003(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1004()
	{
		init(9);
		_GIMMICK_PTTERNS_1004(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1005()
	{
		init(7);
		_GIMMICK_PTTERNS_1005(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1007()
	{
		init(8);
		_GIMMICK_PTTERNS_1007(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1008()
	{
		init(6);
		_GIMMICK_PTTERNS_1008(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1009()
	{
		init(9);
		_GIMMICK_PTTERNS_1009(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1010()
	{
		init(7);
		_GIMMICK_PTTERNS_1010(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1011()
	{
		init(8);
		_GIMMICK_PTTERNS_1011(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1012()
	{
		init(8);
		_GIMMICK_PTTERNS_1012(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1013()
	{
		init(6);
		_GIMMICK_PTTERNS_1013(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1014()
	{
		init(9);
		_GIMMICK_PTTERNS_1014(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1015()
	{
		init(7);
		_GIMMICK_PTTERNS_1015(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1016()
	{
		init(8);
		_GIMMICK_PTTERNS_1016(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1017()
	{
		init(6);
		_GIMMICK_PTTERNS_1017(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1018()
	{
		init(9);
		_GIMMICK_PTTERNS_1018(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1019()
	{
		init(7);
		_GIMMICK_PTTERNS_1019(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1021()
	{
		init(8);
		_GIMMICK_PTTERNS_1021(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1022()
	{
		init(6);
		_GIMMICK_PTTERNS_1022(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1023()
	{
		init(9);
		_GIMMICK_PTTERNS_1023(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1024()
	{
		init(7);
		_GIMMICK_PTTERNS_1024(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1026()
	{
		init(8);
		_GIMMICK_PTTERNS_1026(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1028()
	{
		init(8);
		_GIMMICK_PTTERNS_1028(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1029()
	{
		init(6);
		_GIMMICK_PTTERNS_1029(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1030()
	{
		init(9);
		_GIMMICK_PTTERNS_1030(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1031()
	{
		init(7);
		_GIMMICK_PTTERNS_1031(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1032()
	{
		init(8);
		_GIMMICK_PTTERNS_1032(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1033()
	{
		init(6);
		_GIMMICK_PTTERNS_1033(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1034()
	{
		init(9);
		_GIMMICK_PTTERNS_1034(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1035()
	{
		init(7);
		_GIMMICK_PTTERNS_1035(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1037()
	{
		init(8);
		_GIMMICK_PTTERNS_1037(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1038()
	{
		init(8);
		_GIMMICK_PTTERNS_1038(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1039()
	{
		init(6);
		_GIMMICK_PTTERNS_1039(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1040()
	{
		init(9);
		_GIMMICK_PTTERNS_1040(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1041()
	{
		init(7);
		_GIMMICK_PTTERNS_1041(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1042()
	{
		init(8);
		_GIMMICK_PTTERNS_1042(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1043()
	{
		init(6);
		_GIMMICK_PTTERNS_1043(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1044()
	{
		init(9);
		_GIMMICK_PTTERNS_1044(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1045()
	{
		init(7);
		_GIMMICK_PTTERNS_1045(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1046()
	{
		init(8);
		_GIMMICK_PTTERNS_1046(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1047()
	{
		init(6);
		_GIMMICK_PTTERNS_1047(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1048()
	{
		init(9);
		_GIMMICK_PTTERNS_1048(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1049()
	{
		init(7);
		_GIMMICK_PTTERNS_1049(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1050()
	{
		init(8);
		_GIMMICK_PTTERNS_1050(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1051()
	{
		init(8);
		_GIMMICK_PTTERNS_1051(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1052()
	{
		init(6);
		_GIMMICK_PTTERNS_1052(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1053()
	{
		init(9);
		_GIMMICK_PTTERNS_1053(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1054()
	{
		init(7);
		_GIMMICK_PTTERNS_1054(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1055()
	{
		init(8);
		_GIMMICK_PTTERNS_1055(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1056()
	{
		init(8);
		_GIMMICK_PTTERNS_1056(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1057()
	{
		init(6);
		_GIMMICK_PTTERNS_1057(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1058()
	{
		init(9);
		_GIMMICK_PTTERNS_1058(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1059()
	{
		init(7);
		_GIMMICK_PTTERNS_1059(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1060()
	{
		init(8);
		_GIMMICK_PTTERNS_1060(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1061()
	{
		init(6);
		_GIMMICK_PTTERNS_1061(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1062()
	{
		init(9);
		_GIMMICK_PTTERNS_1062(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1063()
	{
		init(7);
		_GIMMICK_PTTERNS_1063(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1064()
	{
		init(8);
		_GIMMICK_PTTERNS_1064(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1065()
	{
		init(6);
		_GIMMICK_PTTERNS_1065(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1066()
	{
		init(9);
		_GIMMICK_PTTERNS_1066(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1067()
	{
		init(7);
		_GIMMICK_PTTERNS_1067(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1069()
	{
		init(8);
		_GIMMICK_PTTERNS_1069(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1070()
	{
		init(6);
		_GIMMICK_PTTERNS_1070(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1071()
	{
		init(9);
		_GIMMICK_PTTERNS_1071(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1072()
	{
		init(7);
		_GIMMICK_PTTERNS_1072(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1074()
	{
		init(8);
		_GIMMICK_PTTERNS_1074(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1075()
	{
		init(6);
		_GIMMICK_PTTERNS_1075(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1076()
	{
		init(9);
		_GIMMICK_PTTERNS_1076(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1077()
	{
		init(7);
		_GIMMICK_PTTERNS_1077(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1078()
	{
		init(8);
		_GIMMICK_PTTERNS_1078(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1079()
	{
		init(6);
		_GIMMICK_PTTERNS_1079(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1080()
	{
		init(9);
		_GIMMICK_PTTERNS_1080(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1081()
	{
		init(7);
		_GIMMICK_PTTERNS_1081(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1083()
	{
		init(8);
		_GIMMICK_PTTERNS_1083(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1084()
	{
		init(6);
		_GIMMICK_PTTERNS_1084(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1085()
	{
		init(9);
		_GIMMICK_PTTERNS_1085(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1086()
	{
		init(7);
		_GIMMICK_PTTERNS_1086(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1087()
	{
		init(8);
		_GIMMICK_PTTERNS_1087(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1088()
	{
		init(6);
		_GIMMICK_PTTERNS_1088(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1089()
	{
		init(9);
		_GIMMICK_PTTERNS_1089(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1090()
	{
		init(7);
		_GIMMICK_PTTERNS_1090(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1095()
	{
		init(8);
		_GIMMICK_PTTERNS_1095(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1096()
	{
		init(6);
		_GIMMICK_PTTERNS_1096(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1097()
	{
		init(9);
		_GIMMICK_PTTERNS_1097(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1098()
	{
		init(7);
		_GIMMICK_PTTERNS_1098(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1099()
	{
		init(8);
		_GIMMICK_PTTERNS_1099(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1100()
	{
		init(6);
		_GIMMICK_PTTERNS_1100(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1101()
	{
		init(9);
		_GIMMICK_PTTERNS_1101(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1102()
	{
		init(7);
		_GIMMICK_PTTERNS_1102(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1103()
	{
		init(8);
		_GIMMICK_PTTERNS_1103(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1104()
	{
		init(6);
		_GIMMICK_PTTERNS_1104(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1105()
	{
		init(9);
		_GIMMICK_PTTERNS_1105(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1106()
	{
		init(7);
		_GIMMICK_PTTERNS_1106(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1107()
	{
		init(8);
		_GIMMICK_PTTERNS_1107(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1108()
	{
		init(6);
		_GIMMICK_PTTERNS_1108(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1109()
	{
		init(9);
		_GIMMICK_PTTERNS_1109(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1110()
	{
		init(7);
		_GIMMICK_PTTERNS_1110(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1111()
	{
		init(8);
		_GIMMICK_PTTERNS_1111(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1112()
	{
		init(6);
		_GIMMICK_PTTERNS_1112(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1113()
	{
		init(9);
		_GIMMICK_PTTERNS_1113(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1114()
	{
		init(7);
		_GIMMICK_PTTERNS_1114(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1115()
	{
		init(8);
		_GIMMICK_PTTERNS_1115(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1116()
	{
		init(6);
		_GIMMICK_PTTERNS_1116(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1117()
	{
		init(9);
		_GIMMICK_PTTERNS_1117(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1118()
	{
		init(7);
		_GIMMICK_PTTERNS_1118(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1119()
	{
		init(8);
		_GIMMICK_PTTERNS_1119(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1120()
	{
		init(6);
		_GIMMICK_PTTERNS_1120(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1121()
	{
		init(9);
		_GIMMICK_PTTERNS_1121(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1122()
	{
		init(7);
		_GIMMICK_PTTERNS_1122(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1123()
	{
		init(8);
		_GIMMICK_PTTERNS_1123(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1124()
	{
		init(6);
		_GIMMICK_PTTERNS_1124(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1125()
	{
		init(9);
		_GIMMICK_PTTERNS_1125(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1126()
	{
		init(7);
		_GIMMICK_PTTERNS_1126(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1128()
	{
		init(8);
		_GIMMICK_PTTERNS_1128(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1129()
	{
		init(6);
		_GIMMICK_PTTERNS_1129(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1130()
	{
		init(9);
		_GIMMICK_PTTERNS_1130(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1131()
	{
		init(7);
		_GIMMICK_PTTERNS_1131(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1132()
	{
		init(8);
		_GIMMICK_PTTERNS_1132(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1133()
	{
		init(8);
		_GIMMICK_PTTERNS_1133(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1134()
	{
		init(6);
		_GIMMICK_PTTERNS_1134(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1135()
	{
		init(9);
		_GIMMICK_PTTERNS_1135(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1136()
	{
		init(7);
		_GIMMICK_PTTERNS_1136(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1137()
	{
		init(8);
		_GIMMICK_PTTERNS_1137(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1138()
	{
		init(6);
		_GIMMICK_PTTERNS_1138(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1139()
	{
		init(9);
		_GIMMICK_PTTERNS_1139(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1140()
	{
		init(7);
		_GIMMICK_PTTERNS_1140(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1142()
	{
		init(8);
		_GIMMICK_PTTERNS_1142(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1143()
	{
		init(6);
		_GIMMICK_PTTERNS_1143(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1144()
	{
		init(9);
		_GIMMICK_PTTERNS_1144(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1145()
	{
		init(7);
		_GIMMICK_PTTERNS_1145(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1147()
	{
		init(8);
		_GIMMICK_PTTERNS_1147(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1149()
	{
		init(8);
		_GIMMICK_PTTERNS_1149(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1150()
	{
		init(6);
		_GIMMICK_PTTERNS_1150(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1151()
	{
		init(9);
		_GIMMICK_PTTERNS_1151(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1152()
	{
		init(7);
		_GIMMICK_PTTERNS_1152(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1153()
	{
		init(8);
		_GIMMICK_PTTERNS_1153(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1154()
	{
		init(6);
		_GIMMICK_PTTERNS_1154(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1155()
	{
		init(9);
		_GIMMICK_PTTERNS_1155(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1156()
	{
		init(7);
		_GIMMICK_PTTERNS_1156(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1158()
	{
		init(8);
		_GIMMICK_PTTERNS_1158(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1159()
	{
		init(8);
		_GIMMICK_PTTERNS_1159(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1160()
	{
		init(6);
		_GIMMICK_PTTERNS_1160(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1161()
	{
		init(9);
		_GIMMICK_PTTERNS_1161(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1162()
	{
		init(7);
		_GIMMICK_PTTERNS_1162(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1163()
	{
		init(8);
		_GIMMICK_PTTERNS_1163(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1164()
	{
		init(6);
		_GIMMICK_PTTERNS_1164(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1165()
	{
		init(9);
		_GIMMICK_PTTERNS_1165(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1166()
	{
		init(7);
		_GIMMICK_PTTERNS_1166(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1168()
	{
		init(6);
		_GIMMICK_PTTERNS_1168(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1169()
	{
		init(9);
		_GIMMICK_PTTERNS_1169(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1170()
	{
		init(7);
		_GIMMICK_PTTERNS_1170(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1171()
	{
		init(8);
		_GIMMICK_PTTERNS_1171(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1172()
	{
		init(8);
		_GIMMICK_PTTERNS_1172(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1173()
	{
		init(6);
		_GIMMICK_PTTERNS_1173(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1174()
	{
		init(9);
		_GIMMICK_PTTERNS_1174(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1175()
	{
		init(7);
		_GIMMICK_PTTERNS_1175(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1176()
	{
		init(8);
		_GIMMICK_PTTERNS_1176(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1177()
	{
		init(8);
		_GIMMICK_PTTERNS_1177(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1178()
	{
		init(6);
		_GIMMICK_PTTERNS_1178(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1179()
	{
		init(9);
		_GIMMICK_PTTERNS_1179(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1180()
	{
		init(7);
		_GIMMICK_PTTERNS_1180(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1181()
	{
		init(8);
		_GIMMICK_PTTERNS_1181(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1182()
	{
		init(6);
		_GIMMICK_PTTERNS_1182(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1183()
	{
		init(9);
		_GIMMICK_PTTERNS_1183(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1184()
	{
		init(7);
		_GIMMICK_PTTERNS_1184(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1185()
	{
		init(8);
		_GIMMICK_PTTERNS_1185(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1186()
	{
		init(6);
		_GIMMICK_PTTERNS_1186(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1187()
	{
		init(9);
		_GIMMICK_PTTERNS_1187(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1188()
	{
		init(7);
		_GIMMICK_PTTERNS_1188(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1190()
	{
		init(8);
		_GIMMICK_PTTERNS_1190(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1191()
	{
		init(6);
		_GIMMICK_PTTERNS_1191(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1192()
	{
		init(9);
		_GIMMICK_PTTERNS_1192(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1193()
	{
		init(7);
		_GIMMICK_PTTERNS_1193(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1195()
	{
		init(8);
		_GIMMICK_PTTERNS_1195(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1196()
	{
		init(6);
		_GIMMICK_PTTERNS_1196(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1197()
	{
		init(9);
		_GIMMICK_PTTERNS_1197(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1198()
	{
		init(7);
		_GIMMICK_PTTERNS_1198(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1199()
	{
		init(8);
		_GIMMICK_PTTERNS_1199(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1200()
	{
		init(6);
		_GIMMICK_PTTERNS_1200(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1201()
	{
		init(9);
		_GIMMICK_PTTERNS_1201(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1202()
	{
		init(7);
		_GIMMICK_PTTERNS_1202(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1204()
	{
		init(8);
		_GIMMICK_PTTERNS_1204(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1205()
	{
		init(6);
		_GIMMICK_PTTERNS_1205(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1206()
	{
		init(9);
		_GIMMICK_PTTERNS_1206(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1207()
	{
		init(7);
		_GIMMICK_PTTERNS_1207(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1208()
	{
		init(8);
		_GIMMICK_PTTERNS_1208(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1209()
	{
		init(6);
		_GIMMICK_PTTERNS_1209(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1210()
	{
		init(9);
		_GIMMICK_PTTERNS_1210(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1211()
	{
		init(7);
		_GIMMICK_PTTERNS_1211(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1216()
	{
		init(8);
		_GIMMICK_PTTERNS_1216(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1217()
	{
		init(6);
		_GIMMICK_PTTERNS_1217(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1218()
	{
		init(9);
		_GIMMICK_PTTERNS_1218(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1219()
	{
		init(7);
		_GIMMICK_PTTERNS_1219(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1220()
	{
		init(8);
		_GIMMICK_PTTERNS_1220(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1221()
	{
		init(6);
		_GIMMICK_PTTERNS_1221(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1222()
	{
		init(9);
		_GIMMICK_PTTERNS_1222(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1223()
	{
		init(7);
		_GIMMICK_PTTERNS_1223(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1224()
	{
		init(8);
		_GIMMICK_PTTERNS_1224(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1225()
	{
		init(6);
		_GIMMICK_PTTERNS_1225(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1226()
	{
		init(9);
		_GIMMICK_PTTERNS_1226(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1227()
	{
		init(7);
		_GIMMICK_PTTERNS_1227(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1228()
	{
		init(8);
		_GIMMICK_PTTERNS_1228(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1229()
	{
		init(8);
		_GIMMICK_PTTERNS_1229(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1230()
	{
		init(6);
		_GIMMICK_PTTERNS_1230(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1231()
	{
		init(9);
		_GIMMICK_PTTERNS_1231(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1232()
	{
		init(7);
		_GIMMICK_PTTERNS_1232(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1233()
	{
		init(8);
		_GIMMICK_PTTERNS_1233(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1234()
	{
		init(6);
		_GIMMICK_PTTERNS_1234(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1235()
	{
		init(9);
		_GIMMICK_PTTERNS_1235(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1236()
	{
		init(7);
		_GIMMICK_PTTERNS_1236(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1239()
	{
		init(8);
		_GIMMICK_PTTERNS_1239(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1240()
	{
		init(6);
		_GIMMICK_PTTERNS_1240(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1241()
	{
		init(9);
		_GIMMICK_PTTERNS_1241(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1242()
	{
		init(7);
		_GIMMICK_PTTERNS_1242(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1245()
	{
		init(8);
		_GIMMICK_PTTERNS_1245(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1246()
	{
		init(6);
		_GIMMICK_PTTERNS_1246(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1247()
	{
		init(9);
		_GIMMICK_PTTERNS_1247(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1248()
	{
		init(7);
		_GIMMICK_PTTERNS_1248(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1250()
	{
		init(8);
		_GIMMICK_PTTERNS_1250(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1251()
	{
		init(6);
		_GIMMICK_PTTERNS_1251(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1252()
	{
		init(9);
		_GIMMICK_PTTERNS_1252(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1253()
	{
		init(7);
		_GIMMICK_PTTERNS_1253(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1254()
	{
		init(8);
		_GIMMICK_PTTERNS_1254(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1255()
	{
		init(6);
		_GIMMICK_PTTERNS_1255(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1256()
	{
		init(9);
		_GIMMICK_PTTERNS_1256(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1257()
	{
		init(7);
		_GIMMICK_PTTERNS_1257(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1266()
	{
		init(8);
		_GIMMICK_PTTERNS_1266(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1267()
	{
		init(6);
		_GIMMICK_PTTERNS_1267(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1268()
	{
		init(9);
		_GIMMICK_PTTERNS_1268(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1269()
	{
		init(7);
		_GIMMICK_PTTERNS_1269(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1270()
	{
		init(8);
		_GIMMICK_PTTERNS_1270(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1271()
	{
		init(6);
		_GIMMICK_PTTERNS_1271(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1272()
	{
		init(9);
		_GIMMICK_PTTERNS_1272(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1273()
	{
		init(7);
		_GIMMICK_PTTERNS_1273(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1274()
	{
		init(8);
		_GIMMICK_PTTERNS_1274(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1275()
	{
		init(8);
		_GIMMICK_PTTERNS_1275(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1276()
	{
		init(6);
		_GIMMICK_PTTERNS_1276(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1277()
	{
		init(9);
		_GIMMICK_PTTERNS_1277(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1278()
	{
		init(7);
		_GIMMICK_PTTERNS_1278(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1279()
	{
		init(8);
		_GIMMICK_PTTERNS_1279(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1280()
	{
		init(6);
		_GIMMICK_PTTERNS_1280(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1281()
	{
		init(9);
		_GIMMICK_PTTERNS_1281(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1282()
	{
		init(7);
		_GIMMICK_PTTERNS_1282(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1283()
	{
		init(8);
		_GIMMICK_PTTERNS_1283(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1284()
	{
		init(6);
		_GIMMICK_PTTERNS_1284(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1285()
	{
		init(9);
		_GIMMICK_PTTERNS_1285(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1286()
	{
		init(7);
		_GIMMICK_PTTERNS_1286(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1287()
	{
		init(8);
		_GIMMICK_PTTERNS_1287(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1288()
	{
		init(6);
		_GIMMICK_PTTERNS_1288(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1289()
	{
		init(9);
		_GIMMICK_PTTERNS_1289(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1290()
	{
		init(7);
		_GIMMICK_PTTERNS_1290(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1291()
	{
		init(8);
		_GIMMICK_PTTERNS_1291(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1292()
	{
		init(8);
		_GIMMICK_PTTERNS_1292(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1293()
	{
		init(6);
		_GIMMICK_PTTERNS_1293(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1294()
	{
		init(9);
		_GIMMICK_PTTERNS_1294(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1295()
	{
		init(7);
		_GIMMICK_PTTERNS_1295(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1296()
	{
		init(8);
		_GIMMICK_PTTERNS_1296(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1297()
	{
		init(6);
		_GIMMICK_PTTERNS_1297(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1298()
	{
		init(9);
		_GIMMICK_PTTERNS_1298(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1299()
	{
		init(7);
		_GIMMICK_PTTERNS_1299(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1300()
	{
		init(8);
		_GIMMICK_PTTERNS_1300(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1301()
	{
		init(8);
		_GIMMICK_PTTERNS_1301(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1302()
	{
		init(6);
		_GIMMICK_PTTERNS_1302(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1303()
	{
		init(9);
		_GIMMICK_PTTERNS_1303(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1304()
	{
		init(7);
		_GIMMICK_PTTERNS_1304(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1305()
	{
		init(8);
		_GIMMICK_PTTERNS_1305(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1306()
	{
		init(6);
		_GIMMICK_PTTERNS_1306(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1307()
	{
		init(9);
		_GIMMICK_PTTERNS_1307(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1308()
	{
		init(7);
		_GIMMICK_PTTERNS_1308(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1309()
	{
		init(8);
		_GIMMICK_PTTERNS_1309(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1310()
	{
		init(6);
		_GIMMICK_PTTERNS_1310(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1311()
	{
		init(9);
		_GIMMICK_PTTERNS_1311(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1312()
	{
		init(7);
		_GIMMICK_PTTERNS_1312(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1313()
	{
		init(8);
		_GIMMICK_PTTERNS_1313(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1314()
	{
		init(6);
		_GIMMICK_PTTERNS_1314(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1315()
	{
		init(9);
		_GIMMICK_PTTERNS_1315(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1316()
	{
		init(7);
		_GIMMICK_PTTERNS_1316(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1317()
	{
		init(8);
		_GIMMICK_PTTERNS_1317(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1318()
	{
		init(6);
		_GIMMICK_PTTERNS_1318(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1319()
	{
		init(9);
		_GIMMICK_PTTERNS_1319(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1320()
	{
		init(7);
		_GIMMICK_PTTERNS_1320(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1321()
	{
		init(8);
		_GIMMICK_PTTERNS_1321(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1322()
	{
		init(6);
		_GIMMICK_PTTERNS_1322(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1323()
	{
		init(9);
		_GIMMICK_PTTERNS_1323(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1324()
	{
		init(7);
		_GIMMICK_PTTERNS_1324(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1325()
	{
		init(8);
		_GIMMICK_PTTERNS_1325(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1326()
	{
		init(6);
		_GIMMICK_PTTERNS_1326(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1327()
	{
		init(9);
		_GIMMICK_PTTERNS_1327(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1328()
	{
		init(7);
		_GIMMICK_PTTERNS_1328(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1329()
	{
		init(8);
		_GIMMICK_PTTERNS_1329(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1330()
	{
		init(6);
		_GIMMICK_PTTERNS_1330(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1331()
	{
		init(9);
		_GIMMICK_PTTERNS_1331(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1332()
	{
		init(7);
		_GIMMICK_PTTERNS_1332(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1333()
	{
		init(8);
		_GIMMICK_PTTERNS_1333(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1334()
	{
		init(8);
		_GIMMICK_PTTERNS_1334(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1335()
	{
		init(8);
		_GIMMICK_PTTERNS_1335(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1336()
	{
		init(8);
		_GIMMICK_PTTERNS_1336(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1337()
	{
		init(6);
		_GIMMICK_PTTERNS_1337(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1338()
	{
		init(9);
		_GIMMICK_PTTERNS_1338(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1339()
	{
		init(7);
		_GIMMICK_PTTERNS_1339(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1340()
	{
		init(8);
		_GIMMICK_PTTERNS_1340(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1341()
	{
		init(6);
		_GIMMICK_PTTERNS_1341(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1342()
	{
		init(9);
		_GIMMICK_PTTERNS_1342(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1343()
	{
		init(7);
		_GIMMICK_PTTERNS_1343(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1344()
	{
		init(8);
		_GIMMICK_PTTERNS_1344(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1345()
	{
		init(6);
		_GIMMICK_PTTERNS_1345(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1346()
	{
		init(9);
		_GIMMICK_PTTERNS_1346(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1347()
	{
		init(7);
		_GIMMICK_PTTERNS_1347(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1349()
	{
		init(8);
		_GIMMICK_PTTERNS_1349(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1350()
	{
		init(6);
		_GIMMICK_PTTERNS_1350(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1351()
	{
		init(9);
		_GIMMICK_PTTERNS_1351(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1352()
	{
		init(7);
		_GIMMICK_PTTERNS_1352(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1353()
	{
		init(8);
		_GIMMICK_PTTERNS_1353(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1354()
	{
		init(6);
		_GIMMICK_PTTERNS_1354(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1355()
	{
		init(9);
		_GIMMICK_PTTERNS_1355(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1356()
	{
		init(7);
		_GIMMICK_PTTERNS_1356(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1357()
	{
		init(8);
		_GIMMICK_PTTERNS_1357(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1358()
	{
		init(6);
		_GIMMICK_PTTERNS_1358(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1359()
	{
		init(9);
		_GIMMICK_PTTERNS_1359(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1360()
	{
		init(7);
		_GIMMICK_PTTERNS_1360(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1361()
	{
		init(8);
		_GIMMICK_PTTERNS_1361(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1362()
	{
		init(6);
		_GIMMICK_PTTERNS_1362(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1363()
	{
		init(9);
		_GIMMICK_PTTERNS_1363(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1364()
	{
		init(7);
		_GIMMICK_PTTERNS_1364(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1365()
	{
		init(8);
		_GIMMICK_PTTERNS_1365(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1366()
	{
		init(6);
		_GIMMICK_PTTERNS_1366(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1367()
	{
		init(9);
		_GIMMICK_PTTERNS_1367(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1368()
	{
		init(7);
		_GIMMICK_PTTERNS_1368(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1369()
	{
		init(8);
		_GIMMICK_PTTERNS_1369(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1370()
	{
		init(6);
		_GIMMICK_PTTERNS_1370(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1371()
	{
		init(9);
		_GIMMICK_PTTERNS_1371(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1372()
	{
		init(7);
		_GIMMICK_PTTERNS_1372(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1373()
	{
		init(8);
		_GIMMICK_PTTERNS_1373(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1374()
	{
		init(6);
		_GIMMICK_PTTERNS_1374(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1375()
	{
		init(9);
		_GIMMICK_PTTERNS_1375(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1376()
	{
		init(7);
		_GIMMICK_PTTERNS_1376(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1377()
	{
		init(8);
		_GIMMICK_PTTERNS_1377(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1378()
	{
		init(6);
		_GIMMICK_PTTERNS_1378(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1379()
	{
		init(9);
		_GIMMICK_PTTERNS_1379(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1380()
	{
		init(7);
		_GIMMICK_PTTERNS_1380(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1381()
	{
		init(8);
		_GIMMICK_PTTERNS_1381(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1382()
	{
		init(6);
		_GIMMICK_PTTERNS_1382(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1383()
	{
		init(9);
		_GIMMICK_PTTERNS_1383(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1384()
	{
		init(7);
		_GIMMICK_PTTERNS_1384(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1385()
	{
		init(8);
		_GIMMICK_PTTERNS_1385(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1386()
	{
		init(6);
		_GIMMICK_PTTERNS_1386(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1387()
	{
		init(9);
		_GIMMICK_PTTERNS_1387(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1388()
	{
		init(7);
		_GIMMICK_PTTERNS_1388(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1389()
	{
		init(8);
		_GIMMICK_PTTERNS_1389(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1390()
	{
		init(6);
		_GIMMICK_PTTERNS_1390(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1391()
	{
		init(9);
		_GIMMICK_PTTERNS_1391(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1392()
	{
		init(7);
		_GIMMICK_PTTERNS_1392(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1393()
	{
		init(8);
		_GIMMICK_PTTERNS_1393(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1394()
	{
		init(6);
		_GIMMICK_PTTERNS_1394(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1395()
	{
		init(9);
		_GIMMICK_PTTERNS_1395(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1396()
	{
		init(7);
		_GIMMICK_PTTERNS_1396(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1397()
	{
		init(8);
		_GIMMICK_PTTERNS_1397(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1398()
	{
		init(6);
		_GIMMICK_PTTERNS_1398(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1399()
	{
		init(9);
		_GIMMICK_PTTERNS_1399(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1400()
	{
		init(7);
		_GIMMICK_PTTERNS_1400(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1401()
	{
		init(8);
		_GIMMICK_PTTERNS_1401(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1402()
	{
		init(6);
		_GIMMICK_PTTERNS_1402(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1403()
	{
		init(9);
		_GIMMICK_PTTERNS_1403(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1404()
	{
		init(7);
		_GIMMICK_PTTERNS_1404(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1405()
	{
		init(8);
		_GIMMICK_PTTERNS_1405(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1406()
	{
		init(6);
		_GIMMICK_PTTERNS_1406(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1407()
	{
		init(9);
		_GIMMICK_PTTERNS_1407(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1408()
	{
		init(7);
		_GIMMICK_PTTERNS_1408(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1409()
	{
		init(8);
		_GIMMICK_PTTERNS_1409(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1410()
	{
		init(6);
		_GIMMICK_PTTERNS_1410(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1411()
	{
		init(9);
		_GIMMICK_PTTERNS_1411(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1412()
	{
		init(7);
		_GIMMICK_PTTERNS_1412(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1413()
	{
		init(8);
		_GIMMICK_PTTERNS_1413(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1414()
	{
		init(6);
		_GIMMICK_PTTERNS_1414(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1415()
	{
		init(9);
		_GIMMICK_PTTERNS_1415(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1416()
	{
		init(7);
		_GIMMICK_PTTERNS_1416(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1417()
	{
		init(8);
		_GIMMICK_PTTERNS_1417(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1418()
	{
		init(6);
		_GIMMICK_PTTERNS_1418(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1419()
	{
		init(9);
		_GIMMICK_PTTERNS_1419(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1420()
	{
		init(7);
		_GIMMICK_PTTERNS_1420(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1421()
	{
		init(8);
		_GIMMICK_PTTERNS_1421(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1422()
	{
		init(6);
		_GIMMICK_PTTERNS_1422(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1423()
	{
		init(9);
		_GIMMICK_PTTERNS_1423(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1424()
	{
		init(7);
		_GIMMICK_PTTERNS_1424(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1425()
	{
		init(8);
		_GIMMICK_PTTERNS_1425(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1426()
	{
		init(6);
		_GIMMICK_PTTERNS_1426(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1427()
	{
		init(9);
		_GIMMICK_PTTERNS_1427(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1428()
	{
		init(7);
		_GIMMICK_PTTERNS_1428(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1429()
	{
		init(8);
		_GIMMICK_PTTERNS_1429(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1430()
	{
		init(6);
		_GIMMICK_PTTERNS_1430(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1431()
	{
		init(9);
		_GIMMICK_PTTERNS_1431(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1432()
	{
		init(7);
		_GIMMICK_PTTERNS_1432(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1433()
	{
		init(8);
		_GIMMICK_PTTERNS_1433(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1434()
	{
		init(6);
		_GIMMICK_PTTERNS_1434(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1435()
	{
		init(9);
		_GIMMICK_PTTERNS_1435(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1436()
	{
		init(7);
		_GIMMICK_PTTERNS_1436(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1437()
	{
		init(8);
		_GIMMICK_PTTERNS_1437(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1438()
	{
		init(6);
		_GIMMICK_PTTERNS_1438(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1439()
	{
		init(9);
		_GIMMICK_PTTERNS_1439(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1440()
	{
		init(7);
		_GIMMICK_PTTERNS_1440(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1441()
	{
		init(8);
		_GIMMICK_PTTERNS_1441(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1442()
	{
		init(6);
		_GIMMICK_PTTERNS_1442(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1443()
	{
		init(9);
		_GIMMICK_PTTERNS_1443(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1444()
	{
		init(7);
		_GIMMICK_PTTERNS_1444(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1446()
	{
		init(8);
		_GIMMICK_PTTERNS_1446(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1447()
	{
		init(6);
		_GIMMICK_PTTERNS_1447(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1448()
	{
		init(9);
		_GIMMICK_PTTERNS_1448(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1449()
	{
		init(7);
		_GIMMICK_PTTERNS_1449(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1450()
	{
		init(8);
		_GIMMICK_PTTERNS_1450(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1451()
	{
		init(6);
		_GIMMICK_PTTERNS_1451(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1452()
	{
		init(9);
		_GIMMICK_PTTERNS_1452(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1453()
	{
		init(7);
		_GIMMICK_PTTERNS_1453(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1454()
	{
		init(8);
		_GIMMICK_PTTERNS_1454(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1455()
	{
		init(6);
		_GIMMICK_PTTERNS_1455(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1456()
	{
		init(9);
		_GIMMICK_PTTERNS_1456(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1457()
	{
		init(7);
		_GIMMICK_PTTERNS_1457(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1458()
	{
		init(8);
		_GIMMICK_PTTERNS_1458(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1459()
	{
		init(6);
		_GIMMICK_PTTERNS_1459(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1460()
	{
		init(9);
		_GIMMICK_PTTERNS_1460(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1461()
	{
		init(7);
		_GIMMICK_PTTERNS_1461(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1462()
	{
		init(8);
		_GIMMICK_PTTERNS_1462(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1463()
	{
		init(6);
		_GIMMICK_PTTERNS_1463(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1464()
	{
		init(9);
		_GIMMICK_PTTERNS_1464(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1465()
	{
		init(7);
		_GIMMICK_PTTERNS_1465(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1466()
	{
		init(8);
		_GIMMICK_PTTERNS_1466(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1467()
	{
		init(6);
		_GIMMICK_PTTERNS_1467(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1468()
	{
		init(9);
		_GIMMICK_PTTERNS_1468(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1469()
	{
		init(7);
		_GIMMICK_PTTERNS_1469(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1470()
	{
		init(8);
		_GIMMICK_PTTERNS_1470(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1471()
	{
		init(6);
		_GIMMICK_PTTERNS_1471(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1472()
	{
		init(9);
		_GIMMICK_PTTERNS_1472(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1473()
	{
		init(7);
		_GIMMICK_PTTERNS_1473(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1474()
	{
		init(8);
		_GIMMICK_PTTERNS_1474(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1475()
	{
		init(6);
		_GIMMICK_PTTERNS_1475(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1476()
	{
		init(9);
		_GIMMICK_PTTERNS_1476(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1477()
	{
		init(7);
		_GIMMICK_PTTERNS_1477(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1478()
	{
		init(8);
		_GIMMICK_PTTERNS_1478(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1479()
	{
		init(6);
		_GIMMICK_PTTERNS_1479(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1480()
	{
		init(9);
		_GIMMICK_PTTERNS_1480(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1481()
	{
		init(7);
		_GIMMICK_PTTERNS_1481(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1482()
	{
		init(8);
		_GIMMICK_PTTERNS_1482(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1483()
	{
		init(8);
		_GIMMICK_PTTERNS_1483(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1484()
	{
		init(6);
		_GIMMICK_PTTERNS_1484(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1485()
	{
		init(9);
		_GIMMICK_PTTERNS_1485(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1486()
	{
		init(7);
		_GIMMICK_PTTERNS_1486(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1487()
	{
		init(8);
		_GIMMICK_PTTERNS_1487(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1488()
	{
		init(6);
		_GIMMICK_PTTERNS_1488(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1489()
	{
		init(9);
		_GIMMICK_PTTERNS_1489(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1490()
	{
		init(7);
		_GIMMICK_PTTERNS_1490(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1491()
	{
		init(8);
		_GIMMICK_PTTERNS_1491(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1492()
	{
		init(6);
		_GIMMICK_PTTERNS_1492(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1493()
	{
		init(9);
		_GIMMICK_PTTERNS_1493(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1494()
	{
		init(7);
		_GIMMICK_PTTERNS_1494(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1495()
	{
		init(8);
		_GIMMICK_PTTERNS_1495(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1496()
	{
		init(6);
		_GIMMICK_PTTERNS_1496(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1497()
	{
		init(9);
		_GIMMICK_PTTERNS_1497(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1498()
	{
		init(7);
		_GIMMICK_PTTERNS_1498(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1499()
	{
		init(8);
		_GIMMICK_PTTERNS_1499(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1500()
	{
		init(6);
		_GIMMICK_PTTERNS_1500(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1501()
	{
		init(9);
		_GIMMICK_PTTERNS_1501(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1502()
	{
		init(7);
		_GIMMICK_PTTERNS_1502(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1508()
	{
		init(8);
		_GIMMICK_PTTERNS_1508(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1509()
	{
		init(6);
		_GIMMICK_PTTERNS_1509(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1510()
	{
		init(9);
		_GIMMICK_PTTERNS_1510(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1511()
	{
		init(7);
		_GIMMICK_PTTERNS_1511(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1512()
	{
		init(8);
		_GIMMICK_PTTERNS_1512(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1513()
	{
		init(6);
		_GIMMICK_PTTERNS_1513(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1514()
	{
		init(9);
		_GIMMICK_PTTERNS_1514(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1515()
	{
		init(7);
		_GIMMICK_PTTERNS_1515(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1516()
	{
		init(8);
		_GIMMICK_PTTERNS_1516(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1517()
	{
		init(6);
		_GIMMICK_PTTERNS_1517(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1518()
	{
		init(9);
		_GIMMICK_PTTERNS_1518(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1519()
	{
		init(7);
		_GIMMICK_PTTERNS_1519(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1520()
	{
		init(8);
		_GIMMICK_PTTERNS_1520(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1521()
	{
		init(6);
		_GIMMICK_PTTERNS_1521(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1522()
	{
		init(9);
		_GIMMICK_PTTERNS_1522(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1523()
	{
		init(7);
		_GIMMICK_PTTERNS_1523(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1533()
	{
		init(8);
		_GIMMICK_PTTERNS_1533(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1534()
	{
		init(6);
		_GIMMICK_PTTERNS_1534(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1535()
	{
		init(9);
		_GIMMICK_PTTERNS_1535(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1536()
	{
		init(7);
		_GIMMICK_PTTERNS_1536(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1537()
	{
		init(8);
		_GIMMICK_PTTERNS_1537(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1538()
	{
		init(6);
		_GIMMICK_PTTERNS_1538(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1539()
	{
		init(9);
		_GIMMICK_PTTERNS_1539(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1540()
	{
		init(7);
		_GIMMICK_PTTERNS_1540(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1541()
	{
		init(8);
		_GIMMICK_PTTERNS_1541(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1542()
	{
		init(6);
		_GIMMICK_PTTERNS_1542(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1543()
	{
		init(9);
		_GIMMICK_PTTERNS_1543(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1544()
	{
		init(7);
		_GIMMICK_PTTERNS_1544(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1545()
	{
		init(8);
		_GIMMICK_PTTERNS_1545(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1546()
	{
		init(6);
		_GIMMICK_PTTERNS_1546(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1547()
	{
		init(9);
		_GIMMICK_PTTERNS_1547(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1548()
	{
		init(7);
		_GIMMICK_PTTERNS_1548(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1549()
	{
		init(8);
		_GIMMICK_PTTERNS_1549(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1550()
	{
		init(6);
		_GIMMICK_PTTERNS_1550(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1551()
	{
		init(9);
		_GIMMICK_PTTERNS_1551(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1552()
	{
		init(7);
		_GIMMICK_PTTERNS_1552(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1553()
	{
		init(8);
		_GIMMICK_PTTERNS_1553(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1554()
	{
		init(6);
		_GIMMICK_PTTERNS_1554(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1555()
	{
		init(9);
		_GIMMICK_PTTERNS_1555(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1556()
	{
		init(7);
		_GIMMICK_PTTERNS_1556(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1557()
	{
		init(8);
		_GIMMICK_PTTERNS_1557(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1558()
	{
		init(6);
		_GIMMICK_PTTERNS_1558(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1559()
	{
		init(9);
		_GIMMICK_PTTERNS_1559(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1560()
	{
		init(7);
		_GIMMICK_PTTERNS_1560(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1561()
	{
		init(8);
		_GIMMICK_PTTERNS_1561(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1562()
	{
		init(6);
		_GIMMICK_PTTERNS_1562(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1563()
	{
		init(9);
		_GIMMICK_PTTERNS_1563(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1564()
	{
		init(7);
		_GIMMICK_PTTERNS_1564(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1565()
	{
		init(8);
		_GIMMICK_PTTERNS_1565(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1566()
	{
		init(6);
		_GIMMICK_PTTERNS_1566(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1567()
	{
		init(9);
		_GIMMICK_PTTERNS_1567(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1568()
	{
		init(7);
		_GIMMICK_PTTERNS_1568(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1569()
	{
		init(8);
		_GIMMICK_PTTERNS_1569(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1570()
	{
		init(6);
		_GIMMICK_PTTERNS_1570(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1571()
	{
		init(9);
		_GIMMICK_PTTERNS_1571(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1572()
	{
		init(7);
		_GIMMICK_PTTERNS_1572(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1573()
	{
		init(8);
		_GIMMICK_PTTERNS_1573(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1574()
	{
		init(6);
		_GIMMICK_PTTERNS_1574(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1575()
	{
		init(9);
		_GIMMICK_PTTERNS_1575(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1576()
	{
		init(7);
		_GIMMICK_PTTERNS_1576(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1577()
	{
		init(8);
		_GIMMICK_PTTERNS_1577(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1578()
	{
		init(6);
		_GIMMICK_PTTERNS_1578(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1579()
	{
		init(9);
		_GIMMICK_PTTERNS_1579(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1580()
	{
		init(7);
		_GIMMICK_PTTERNS_1580(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1581()
	{
		init(8);
		_GIMMICK_PTTERNS_1581(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1582()
	{
		init(6);
		_GIMMICK_PTTERNS_1582(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1583()
	{
		init(9);
		_GIMMICK_PTTERNS_1583(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1584()
	{
		init(7);
		_GIMMICK_PTTERNS_1584(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1585()
	{
		init(8);
		_GIMMICK_PTTERNS_1585(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1586()
	{
		init(6);
		_GIMMICK_PTTERNS_1586(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1587()
	{
		init(9);
		_GIMMICK_PTTERNS_1587(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1588()
	{
		init(7);
		_GIMMICK_PTTERNS_1588(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1589()
	{
		init(8);
		_GIMMICK_PTTERNS_1589(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1590()
	{
		init(6);
		_GIMMICK_PTTERNS_1590(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1591()
	{
		init(9);
		_GIMMICK_PTTERNS_1591(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1592()
	{
		init(7);
		_GIMMICK_PTTERNS_1592(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1593()
	{
		init(8);
		_GIMMICK_PTTERNS_1593(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1594()
	{
		init(8);
		_GIMMICK_PTTERNS_1594(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1595()
	{
		init(6);
		_GIMMICK_PTTERNS_1595(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1596()
	{
		init(9);
		_GIMMICK_PTTERNS_1596(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1597()
	{
		init(7);
		_GIMMICK_PTTERNS_1597(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1598()
	{
		init(8);
		_GIMMICK_PTTERNS_1598(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1599()
	{
		init(8);
		_GIMMICK_PTTERNS_1599(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1600()
	{
		init(6);
		_GIMMICK_PTTERNS_1600(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1601()
	{
		init(9);
		_GIMMICK_PTTERNS_1601(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1602()
	{
		init(7);
		_GIMMICK_PTTERNS_1602(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1603()
	{
		init(8);
		_GIMMICK_PTTERNS_1603(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1604()
	{
		init(6);
		_GIMMICK_PTTERNS_1604(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1605()
	{
		init(9);
		_GIMMICK_PTTERNS_1605(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1606()
	{
		init(7);
		_GIMMICK_PTTERNS_1606(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1607()
	{
		init(8);
		_GIMMICK_PTTERNS_1607(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1608()
	{
		init(6);
		_GIMMICK_PTTERNS_1608(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1609()
	{
		init(9);
		_GIMMICK_PTTERNS_1609(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1610()
	{
		init(7);
		_GIMMICK_PTTERNS_1610(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1611()
	{
		init(8);
		_GIMMICK_PTTERNS_1611(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1612()
	{
		init(6);
		_GIMMICK_PTTERNS_1612(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1613()
	{
		init(9);
		_GIMMICK_PTTERNS_1613(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1614()
	{
		init(7);
		_GIMMICK_PTTERNS_1614(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1615()
	{
		init(8);
		_GIMMICK_PTTERNS_1615(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1616()
	{
		init(6);
		_GIMMICK_PTTERNS_1616(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1617()
	{
		init(9);
		_GIMMICK_PTTERNS_1617(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1618()
	{
		init(7);
		_GIMMICK_PTTERNS_1618(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1619()
	{
		init(8);
		_GIMMICK_PTTERNS_1619(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1620()
	{
		init(6);
		_GIMMICK_PTTERNS_1620(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1621()
	{
		init(9);
		_GIMMICK_PTTERNS_1621(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1622()
	{
		init(7);
		_GIMMICK_PTTERNS_1622(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1623()
	{
		init(8);
		_GIMMICK_PTTERNS_1623(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1624()
	{
		init(6);
		_GIMMICK_PTTERNS_1624(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1625()
	{
		init(9);
		_GIMMICK_PTTERNS_1625(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1626()
	{
		init(7);
		_GIMMICK_PTTERNS_1626(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1627()
	{
		init(8);
		_GIMMICK_PTTERNS_1627(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1628()
	{
		init(6);
		_GIMMICK_PTTERNS_1628(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1629()
	{
		init(9);
		_GIMMICK_PTTERNS_1629(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1630()
	{
		init(7);
		_GIMMICK_PTTERNS_1630(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1631()
	{
		init(8);
		_GIMMICK_PTTERNS_1631(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1632()
	{
		init(6);
		_GIMMICK_PTTERNS_1632(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1633()
	{
		init(9);
		_GIMMICK_PTTERNS_1633(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1634()
	{
		init(7);
		_GIMMICK_PTTERNS_1634(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1635()
	{
		init(8);
		_GIMMICK_PTTERNS_1635(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1636()
	{
		init(6);
		_GIMMICK_PTTERNS_1636(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1637()
	{
		init(9);
		_GIMMICK_PTTERNS_1637(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1638()
	{
		init(7);
		_GIMMICK_PTTERNS_1638(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1639()
	{
		init(8);
		_GIMMICK_PTTERNS_1639(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1640()
	{
		init(6);
		_GIMMICK_PTTERNS_1640(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1641()
	{
		init(9);
		_GIMMICK_PTTERNS_1641(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1642()
	{
		init(7);
		_GIMMICK_PTTERNS_1642(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1643()
	{
		init(8);
		_GIMMICK_PTTERNS_1643(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1644()
	{
		init(6);
		_GIMMICK_PTTERNS_1644(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1645()
	{
		init(9);
		_GIMMICK_PTTERNS_1645(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1646()
	{
		init(7);
		_GIMMICK_PTTERNS_1646(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1647()
	{
		init(8);
		_GIMMICK_PTTERNS_1647(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1648()
	{
		init(6);
		_GIMMICK_PTTERNS_1648(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1649()
	{
		init(9);
		_GIMMICK_PTTERNS_1649(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1650()
	{
		init(7);
		_GIMMICK_PTTERNS_1650(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1651()
	{
		init(8);
		_GIMMICK_PTTERNS_1651(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1652()
	{
		init(6);
		_GIMMICK_PTTERNS_1652(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1653()
	{
		init(9);
		_GIMMICK_PTTERNS_1653(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1654()
	{
		init(7);
		_GIMMICK_PTTERNS_1654(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1655()
	{
		init(8);
		_GIMMICK_PTTERNS_1655(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1656()
	{
		init(6);
		_GIMMICK_PTTERNS_1656(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1657()
	{
		init(9);
		_GIMMICK_PTTERNS_1657(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1658()
	{
		init(7);
		_GIMMICK_PTTERNS_1658(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1659()
	{
		init(8);
		_GIMMICK_PTTERNS_1659(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1660()
	{
		init(6);
		_GIMMICK_PTTERNS_1660(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1661()
	{
		init(9);
		_GIMMICK_PTTERNS_1661(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1662()
	{
		init(7);
		_GIMMICK_PTTERNS_1662(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1663()
	{
		init(8);
		_GIMMICK_PTTERNS_1663(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1664()
	{
		init(6);
		_GIMMICK_PTTERNS_1664(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1665()
	{
		init(9);
		_GIMMICK_PTTERNS_1665(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1666()
	{
		init(7);
		_GIMMICK_PTTERNS_1666(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1667()
	{
		init(8);
		_GIMMICK_PTTERNS_1667(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1668()
	{
		init(6);
		_GIMMICK_PTTERNS_1668(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1669()
	{
		init(9);
		_GIMMICK_PTTERNS_1669(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1670()
	{
		init(7);
		_GIMMICK_PTTERNS_1670(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1671()
	{
		init(8);
		_GIMMICK_PTTERNS_1671(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1672()
	{
		init(6);
		_GIMMICK_PTTERNS_1672(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1673()
	{
		init(9);
		_GIMMICK_PTTERNS_1673(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1674()
	{
		init(7);
		_GIMMICK_PTTERNS_1674(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1675()
	{
		init(8);
		_GIMMICK_PTTERNS_1675(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1676()
	{
		init(6);
		_GIMMICK_PTTERNS_1676(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1677()
	{
		init(9);
		_GIMMICK_PTTERNS_1677(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1678()
	{
		init(7);
		_GIMMICK_PTTERNS_1678(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1679()
	{
		init(8);
		_GIMMICK_PTTERNS_1679(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1680()
	{
		init(6);
		_GIMMICK_PTTERNS_1680(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1681()
	{
		init(9);
		_GIMMICK_PTTERNS_1681(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1682()
	{
		init(7);
		_GIMMICK_PTTERNS_1682(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1683()
	{
		init(8);
		_GIMMICK_PTTERNS_1683(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1684()
	{
		init(6);
		_GIMMICK_PTTERNS_1684(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1685()
	{
		init(9);
		_GIMMICK_PTTERNS_1685(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1686()
	{
		init(7);
		_GIMMICK_PTTERNS_1686(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1687()
	{
		init(8);
		_GIMMICK_PTTERNS_1687(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1688()
	{
		init(6);
		_GIMMICK_PTTERNS_1688(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1689()
	{
		init(9);
		_GIMMICK_PTTERNS_1689(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1690()
	{
		init(7);
		_GIMMICK_PTTERNS_1690(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1691()
	{
		init(8);
		_GIMMICK_PTTERNS_1691(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1692()
	{
		init(6);
		_GIMMICK_PTTERNS_1692(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1693()
	{
		init(9);
		_GIMMICK_PTTERNS_1693(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1694()
	{
		init(7);
		_GIMMICK_PTTERNS_1694(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1695()
	{
		init(8);
		_GIMMICK_PTTERNS_1695(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1696()
	{
		init(6);
		_GIMMICK_PTTERNS_1696(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1697()
	{
		init(9);
		_GIMMICK_PTTERNS_1697(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1698()
	{
		init(7);
		_GIMMICK_PTTERNS_1698(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1699()
	{
		init(8);
		_GIMMICK_PTTERNS_1699(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1700()
	{
		init(6);
		_GIMMICK_PTTERNS_1700(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1701()
	{
		init(9);
		_GIMMICK_PTTERNS_1701(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1702()
	{
		init(7);
		_GIMMICK_PTTERNS_1702(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1704()
	{
		init(8);
		_GIMMICK_PTTERNS_1704(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1705()
	{
		init(6);
		_GIMMICK_PTTERNS_1705(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1706()
	{
		init(9);
		_GIMMICK_PTTERNS_1706(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1707()
	{
		init(7);
		_GIMMICK_PTTERNS_1707(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1710()
	{
		init(8);
		_GIMMICK_PTTERNS_1710(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1711()
	{
		init(6);
		_GIMMICK_PTTERNS_1711(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1712()
	{
		init(9);
		_GIMMICK_PTTERNS_1712(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1713()
	{
		init(7);
		_GIMMICK_PTTERNS_1713(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1716()
	{
		init(8);
		_GIMMICK_PTTERNS_1716(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1717()
	{
		init(6);
		_GIMMICK_PTTERNS_1717(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1718()
	{
		init(9);
		_GIMMICK_PTTERNS_1718(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1719()
	{
		init(7);
		_GIMMICK_PTTERNS_1719(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1721()
	{
		init(8);
		_GIMMICK_PTTERNS_1721(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1722()
	{
		init(6);
		_GIMMICK_PTTERNS_1722(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1723()
	{
		init(9);
		_GIMMICK_PTTERNS_1723(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1724()
	{
		init(7);
		_GIMMICK_PTTERNS_1724(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1725()
	{
		init(8);
		_GIMMICK_PTTERNS_1725(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1726()
	{
		init(6);
		_GIMMICK_PTTERNS_1726(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1727()
	{
		init(9);
		_GIMMICK_PTTERNS_1727(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1728()
	{
		init(7);
		_GIMMICK_PTTERNS_1728(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1729()
	{
		init(8);
		_GIMMICK_PTTERNS_1729(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1730()
	{
		init(6);
		_GIMMICK_PTTERNS_1730(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1731()
	{
		init(9);
		_GIMMICK_PTTERNS_1731(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1732()
	{
		init(7);
		_GIMMICK_PTTERNS_1732(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1733()
	{
		init(8);
		_GIMMICK_PTTERNS_1733(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1734()
	{
		init(6);
		_GIMMICK_PTTERNS_1734(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1735()
	{
		init(9);
		_GIMMICK_PTTERNS_1735(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1736()
	{
		init(7);
		_GIMMICK_PTTERNS_1736(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1738()
	{
		init(8);
		_GIMMICK_PTTERNS_1738(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1739()
	{
		init(6);
		_GIMMICK_PTTERNS_1739(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1740()
	{
		init(9);
		_GIMMICK_PTTERNS_1740(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1741()
	{
		init(7);
		_GIMMICK_PTTERNS_1741(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1744()
	{
		init(8);
		_GIMMICK_PTTERNS_1744(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1745()
	{
		init(6);
		_GIMMICK_PTTERNS_1745(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1746()
	{
		init(9);
		_GIMMICK_PTTERNS_1746(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1747()
	{
		init(7);
		_GIMMICK_PTTERNS_1747(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1750()
	{
		init(8);
		_GIMMICK_PTTERNS_1750(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1751()
	{
		init(6);
		_GIMMICK_PTTERNS_1751(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1752()
	{
		init(9);
		_GIMMICK_PTTERNS_1752(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1753()
	{
		init(7);
		_GIMMICK_PTTERNS_1753(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1755()
	{
		init(8);
		_GIMMICK_PTTERNS_1755(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1756()
	{
		init(8);
		_GIMMICK_PTTERNS_1756(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1757()
	{
		init(6);
		_GIMMICK_PTTERNS_1757(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1758()
	{
		init(9);
		_GIMMICK_PTTERNS_1758(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1759()
	{
		init(7);
		_GIMMICK_PTTERNS_1759(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1760()
	{
		init(8);
		_GIMMICK_PTTERNS_1760(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1761()
	{
		init(8);
		_GIMMICK_PTTERNS_1761(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1762()
	{
		init(8);
		_GIMMICK_PTTERNS_1762(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1763()
	{
		init(6);
		_GIMMICK_PTTERNS_1763(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1764()
	{
		init(9);
		_GIMMICK_PTTERNS_1764(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1765()
	{
		init(7);
		_GIMMICK_PTTERNS_1765(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1766()
	{
		init(8);
		_GIMMICK_PTTERNS_1766(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1767()
	{
		init(8);
		_GIMMICK_PTTERNS_1767(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1768()
	{
		init(8);
		_GIMMICK_PTTERNS_1768(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1769()
	{
		init(6);
		_GIMMICK_PTTERNS_1769(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1770()
	{
		init(9);
		_GIMMICK_PTTERNS_1770(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1771()
	{
		init(7);
		_GIMMICK_PTTERNS_1771(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1772()
	{
		init(8);
		_GIMMICK_PTTERNS_1772(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1773()
	{
		init(8);
		_GIMMICK_PTTERNS_1773(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1774()
	{
		init(6);
		_GIMMICK_PTTERNS_1774(6, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1775()
	{
		init(9);
		_GIMMICK_PTTERNS_1775(9, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1776()
	{
		init(7);
		_GIMMICK_PTTERNS_1776(7, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1777()
	{
		init(8);
		_GIMMICK_PTTERNS_1777(8, 0);
	}

	public static void _MAIN_GIMMICK_PTTERNS_1778()
	{
		init(6);
		_GIMMICK_PTTERNS_1778(6, 0);
	}

	public static void _MAIN_TESTTEST_051()
	{
		init(7);
		_TESTTEST_051(7, 0);
	}
}
