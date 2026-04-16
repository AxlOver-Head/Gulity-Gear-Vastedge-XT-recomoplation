public class Direction92KWD : DirectionBase
{
	public Direction92KWD(DirectionManager _mng, byte _high, byte _low, byte _mode, DirectionManager.DIR _dir)
		: base(_mng, _high, _low, _mode, _dir, DirectionBase.PRIORITY_NORMAL)
	{
	}

	public override void start()
	{
		base.start();
		int num = -1;
		int num2 = -1;
		int layer = 60;
		switch (low)
		{
		case 0:
			switch (mode)
			{
			case 1:
				num = 671;
				num2 = 37;
				break;
			case 2:
				num = 672;
				num2 = 36;
				break;
			case 3:
				num = 673;
				num2 = 37;
				break;
			case 4:
				num = 674;
				num2 = 37;
				break;
			case 5:
				num = 675;
				num2 = 37;
				break;
			case 6:
				num = 676;
				num2 = 37;
				break;
			case 7:
				num = 677;
				num2 = 37;
				break;
			case 8:
				num = 678;
				num2 = 37;
				break;
			case 9:
				num = 679;
				num2 = 37;
				break;
			case 10:
				num = 680;
				num2 = 37;
				break;
			case 11:
				num = 681;
				num2 = 37;
				break;
			case 12:
				num = 682;
				num2 = 37;
				break;
			case 13:
				num = 683;
				num2 = 37;
				break;
			case 14:
				num = 684;
				num2 = 37;
				break;
			case 15:
				num = 685;
				num2 = 37;
				break;
			case 16:
				num = 686;
				num2 = 36;
				break;
			case 17:
				num = 687;
				num2 = 36;
				break;
			case 18:
				num = 688;
				num2 = 36;
				break;
			case 19:
				num = 689;
				num2 = 37;
				break;
			case 20:
				num = 690;
				num2 = 36;
				break;
			case 21:
				num = 691;
				num2 = 36;
				break;
			case 22:
				num = 692;
				num2 = 37;
				break;
			case 23:
				num = 693;
				num2 = 36;
				break;
			case 24:
				num = 694;
				num2 = 37;
				break;
			case 25:
				num = 695;
				num2 = 36;
				break;
			case 26:
				num = 696;
				num2 = 36;
				break;
			case 27:
				num = 697;
				num2 = 37;
				break;
			case 28:
				num = 698;
				num2 = 37;
				break;
			case 29:
				num = 699;
				num2 = 36;
				break;
			case 30:
				num = 700;
				num2 = 36;
				break;
			case 31:
				num = 701;
				num2 = 36;
				break;
			case 32:
				num = 702;
				num2 = 36;
				break;
			case 33:
				num = 703;
				num2 = 36;
				break;
			case 34:
				num = 704;
				num2 = 36;
				break;
			case 35:
				num = 705;
				num2 = 36;
				break;
			case 36:
				num = 706;
				num2 = 36;
				break;
			case 37:
				num = 707;
				num2 = 36;
				break;
			case 38:
				num = 708;
				num2 = 36;
				break;
			case 39:
				num = 709;
				num2 = 36;
				break;
			case 40:
				num = 710;
				num2 = 36;
				break;
			case 41:
				num = 1031;
				num2 = 36;
				break;
			case 42:
				num = 1032;
				num2 = 36;
				break;
			case 43:
				num = 1033;
				num2 = 37;
				break;
			case 44:
				num = 1034;
				num2 = 36;
				break;
			case 45:
				num = 1035;
				num2 = 37;
				break;
			case 46:
				num = 1036;
				num2 = 37;
				break;
			case 47:
				num = 1037;
				num2 = 37;
				break;
			case 48:
				num = 1038;
				num2 = 37;
				break;
			case 49:
				num = 1039;
				num2 = 36;
				break;
			case 50:
				num = 1040;
				num2 = 36;
				break;
			case 51:
				num = 1041;
				num2 = 37;
				break;
			case 52:
				num = 1042;
				num2 = 37;
				break;
			case 53:
				num = 1043;
				num2 = 37;
				break;
			case 54:
				num = 1044;
				num2 = 36;
				break;
			case 55:
				num = 1045;
				num2 = 37;
				break;
			case 56:
				num = 1046;
				num2 = 36;
				break;
			case 57:
				num = 1047;
				num2 = 36;
				break;
			case 58:
				num = 1048;
				num2 = 37;
				break;
			case 59:
				num = 1049;
				num2 = 36;
				break;
			case 60:
				num = 1050;
				num2 = 36;
				break;
			case 61:
				num = 1051;
				num2 = 37;
				break;
			case 62:
				num = 1052;
				num2 = 36;
				break;
			case 63:
				num = 1053;
				num2 = 36;
				break;
			case 64:
				num = 1054;
				num2 = 36;
				break;
			case 65:
				num = 1055;
				num2 = 37;
				break;
			case 66:
				num = 1056;
				num2 = 37;
				break;
			case 67:
				num = 1057;
				num2 = 36;
				break;
			case 68:
				num = 1058;
				num2 = 37;
				break;
			case 69:
				num = 1059;
				num2 = 37;
				break;
			case 70:
				num = 1060;
				num2 = 37;
				break;
			case 71:
				num = 1061;
				num2 = 36;
				break;
			case 72:
				num = 1062;
				num2 = 36;
				break;
			case 73:
				num = 1063;
				num2 = 36;
				break;
			case 74:
				num = 1064;
				num2 = 36;
				break;
			case 75:
				num = 1065;
				num2 = 36;
				break;
			case 76:
				num = 1066;
				num2 = 36;
				break;
			case 77:
				num = 1067;
				num2 = 36;
				break;
			case 78:
				num = 1068;
				num2 = 36;
				break;
			case 79:
				num = 1069;
				num2 = 36;
				break;
			case 80:
				num = 1070;
				num2 = 36;
				break;
			case 81:
				num = 1300;
				num2 = 37;
				break;
			case 82:
				num = 1301;
				num2 = 36;
				break;
			case 83:
				num = 1302;
				num2 = 37;
				break;
			case 84:
				num = 1303;
				num2 = 37;
				break;
			case 85:
				num = 1304;
				num2 = 37;
				break;
			case 86:
				num = 1305;
				num2 = 37;
				break;
			case 87:
				num = 1306;
				num2 = 37;
				break;
			case 88:
				num = 1307;
				num2 = 37;
				break;
			case 89:
				num = 1308;
				num2 = 37;
				break;
			case 90:
				num = 1309;
				num2 = 36;
				break;
			case 91:
				num = 1310;
				num2 = 37;
				break;
			case 92:
				num = 1311;
				num2 = 37;
				break;
			case 93:
				num = 1312;
				num2 = 36;
				break;
			case 94:
				num = 1313;
				num2 = 36;
				break;
			case 95:
				num = 1314;
				num2 = 36;
				break;
			case 96:
				num = 1315;
				num2 = 36;
				break;
			case 97:
				num = 1316;
				num2 = 36;
				break;
			case 98:
				num = 1317;
				num2 = 36;
				break;
			case 99:
				num = 1318;
				num2 = 36;
				break;
			case 100:
				num = 1319;
				num2 = 36;
				break;
			case 101:
				num = 1779;
				num2 = 37;
				break;
			case 102:
				num = 1780;
				num2 = 36;
				break;
			case 103:
				num = 1781;
				num2 = 37;
				break;
			case 104:
				num = 1782;
				num2 = 37;
				break;
			case 105:
				num = 1783;
				num2 = 36;
				break;
			case 106:
				num = 1784;
				num2 = 37;
				break;
			case 107:
				num = 1785;
				num2 = 37;
				break;
			case 108:
				num = 1786;
				num2 = 37;
				break;
			case 109:
				num = 1787;
				num2 = 37;
				break;
			case 110:
				num = 1788;
				num2 = 37;
				break;
			case 111:
				num = 1789;
				num2 = 37;
				break;
			case 112:
				num = 1790;
				num2 = 37;
				break;
			case 113:
				num = 1791;
				num2 = 37;
				break;
			case 114:
				num = 1792;
				num2 = 37;
				break;
			case 115:
				num = 1793;
				num2 = 37;
				break;
			case 116:
				num = 1794;
				num2 = 37;
				break;
			case 117:
				num = 1795;
				num2 = 37;
				break;
			case 118:
				num = 1796;
				num2 = 37;
				break;
			case 119:
				num = 1797;
				num2 = 37;
				break;
			case 120:
				num = 1798;
				num2 = 36;
				break;
			case 121:
				num = 1799;
				num2 = 36;
				break;
			case 122:
				num = 1800;
				num2 = 36;
				break;
			case 123:
				num = 1801;
				num2 = 37;
				break;
			case 124:
				num = 1802;
				num2 = 36;
				break;
			case 125:
				num = 1803;
				num2 = 36;
				break;
			case 126:
				num = 1804;
				num2 = 36;
				break;
			case 127:
				num = 1805;
				num2 = 36;
				break;
			case 128:
				num = 1806;
				num2 = 37;
				break;
			case 129:
				num = 1807;
				num2 = 36;
				break;
			case 130:
				num = 1808;
				num2 = 37;
				break;
			case 131:
				num = 1726;
				num2 = 37;
				break;
			case 132:
				num = 1727;
				num2 = 37;
				break;
			case 133:
				num = 1728;
				num2 = 37;
				break;
			case 134:
				num = 1729;
				num2 = 37;
				break;
			case 135:
				num = 1730;
				num2 = 37;
				break;
			case 136:
				num = 1731;
				num2 = 37;
				break;
			case 137:
				num = 1732;
				num2 = 37;
				break;
			case 138:
				num = 1733;
				num2 = 36;
				break;
			case 139:
				num = 1734;
				num2 = 36;
				break;
			case 140:
				num = 1735;
				num2 = 37;
				break;
			case 141:
				num = 1736;
				num2 = 37;
				break;
			case 142:
				num = 1737;
				num2 = 37;
				break;
			case 143:
				num = 1738;
				num2 = 37;
				break;
			case 144:
				num = 1739;
				num2 = 36;
				break;
			case 145:
				num = 1740;
				num2 = 37;
				break;
			case 146:
				num = 1741;
				num2 = 37;
				break;
			case 147:
				num = 1742;
				num2 = 37;
				break;
			case 148:
				num = 1743;
				num2 = 37;
				break;
			case 149:
				num = 1744;
				num2 = 36;
				break;
			case 150:
				num = 1745;
				num2 = 37;
				break;
			case 151:
				num = 1746;
				num2 = 37;
				break;
			case 152:
				num = 1747;
				num2 = 36;
				break;
			case 153:
				num = 1748;
				num2 = 36;
				break;
			case 154:
				num = 1749;
				num2 = 36;
				break;
			case 155:
				num = 1750;
				num2 = 36;
				break;
			case 156:
				num = 1751;
				num2 = 36;
				break;
			case 157:
				num = 1752;
				num2 = 36;
				break;
			case 158:
				num = 1753;
				num2 = 37;
				break;
			case 159:
				num = 1754;
				num2 = 37;
				break;
			case 160:
				num = 1755;
				num2 = 36;
				break;
			case 161:
				num = 1647;
				num2 = 37;
				break;
			case 162:
				num = 1648;
				num2 = 37;
				break;
			case 163:
				num = 1649;
				num2 = 37;
				break;
			case 164:
				num = 1650;
				num2 = 36;
				break;
			case 165:
				num = 1651;
				num2 = 37;
				break;
			case 166:
				num = 1652;
				num2 = 37;
				break;
			case 167:
				num = 1653;
				num2 = 37;
				break;
			case 168:
				num = 1654;
				num2 = 37;
				break;
			case 169:
				num = 1655;
				num2 = 37;
				break;
			case 170:
				num = 1656;
				num2 = 37;
				break;
			case 171:
				num = 1657;
				num2 = 37;
				break;
			case 172:
				num = 1658;
				num2 = 37;
				break;
			case 173:
				num = 1659;
				num2 = 37;
				break;
			case 174:
				num = 1660;
				num2 = 36;
				break;
			case 175:
				num = 1661;
				num2 = 36;
				break;
			case 176:
				num = 1662;
				num2 = 36;
				break;
			case 177:
				num = 1663;
				num2 = 37;
				break;
			case 178:
				num = 1664;
				num2 = 36;
				break;
			case 179:
				num = 1665;
				num2 = 36;
				break;
			case 180:
				num = 1666;
				num2 = 36;
				break;
			case 181:
				num = 1617;
				num2 = 37;
				break;
			case 182:
				num = 1618;
				num2 = 36;
				break;
			case 183:
				num = 1619;
				num2 = 37;
				break;
			case 184:
				num = 1620;
				num2 = 37;
				break;
			case 185:
				num = 1621;
				num2 = 37;
				break;
			case 186:
				num = 1622;
				num2 = 36;
				break;
			case 187:
				num = 1623;
				num2 = 37;
				break;
			case 188:
				num = 1624;
				num2 = 36;
				break;
			case 189:
				num = 1625;
				num2 = 37;
				break;
			case 190:
				num = 1626;
				num2 = 37;
				break;
			case 191:
				num = 1627;
				num2 = 36;
				break;
			case 192:
				num = 1628;
				num2 = 36;
				break;
			case 193:
				num = 1629;
				num2 = 37;
				break;
			case 194:
				num = 1630;
				num2 = 37;
				break;
			case 195:
				num = 1631;
				num2 = 36;
				break;
			case 196:
				num = 1632;
				num2 = 37;
				break;
			case 197:
				num = 1633;
				num2 = 36;
				break;
			case 198:
				num = 1634;
				num2 = 36;
				break;
			case 199:
				num = 1635;
				num2 = 36;
				break;
			case 200:
				num = 1636;
				num2 = 36;
				break;
			case 201:
				num = 1815;
				num2 = 37;
				break;
			case 202:
				num = 1816;
				num2 = 36;
				break;
			case 203:
				num = 1817;
				num2 = 37;
				break;
			case 204:
				num = 1818;
				num2 = 36;
				break;
			case 205:
				num = 1819;
				num2 = 37;
				break;
			case 206:
				num = 1820;
				num2 = 36;
				break;
			case 207:
				num = 1821;
				num2 = 37;
				break;
			case 208:
				num = 1822;
				num2 = 37;
				break;
			case 209:
				num = 1823;
				num2 = 36;
				break;
			case 210:
				num = 1824;
				num2 = 37;
				break;
			case 211:
				num = 1825;
				num2 = 36;
				break;
			case 212:
				num = 1826;
				num2 = 36;
				break;
			case 213:
				num = 1827;
				num2 = 37;
				break;
			case 214:
				num = 1828;
				num2 = 36;
				break;
			case 215:
				num = 1829;
				num2 = 36;
				break;
			case 216:
				num = 1830;
				num2 = 36;
				break;
			case 217:
				num = 1831;
				num2 = 37;
				break;
			case 218:
				num = 1832;
				num2 = 37;
				break;
			case 219:
				num = 1833;
				num2 = 37;
				break;
			case 220:
				num = 1834;
				num2 = 37;
				break;
			case 221:
				num = 1575;
				num2 = 36;
				break;
			case 222:
				num = 1576;
				num2 = 36;
				break;
			case 223:
				num = 1577;
				num2 = 37;
				break;
			case 224:
				num = 1578;
				num2 = 36;
				break;
			case 225:
				num = 1581;
				num2 = 36;
				break;
			case 226:
				num = 1580;
				num2 = 36;
				break;
			case 227:
				num = 1583;
				num2 = 37;
				break;
			case 228:
				num = 1584;
				num2 = 36;
				break;
			case 229:
				num = 1582;
				num2 = 37;
				break;
			case 230:
				num = 1579;
				num2 = 37;
				break;
			case 231:
				num = 1537;
				num2 = 36;
				break;
			case 232:
				num = 1538;
				num2 = 36;
				break;
			case 233:
				num = 1539;
				num2 = 36;
				break;
			case 234:
				num = 1540;
				num2 = 36;
				break;
			case 235:
				num = 1541;
				num2 = 36;
				break;
			case 236:
				num = 1542;
				num2 = 36;
				break;
			case 237:
				num = 1543;
				num2 = 36;
				break;
			case 238:
				num = 1544;
				num2 = 36;
				break;
			case 239:
				num = 1545;
				num2 = 36;
				break;
			case 240:
				num = 1546;
				num2 = 36;
				break;
			case 241:
				num = 1340;
				num2 = 37;
				break;
			case 242:
				num = 1341;
				num2 = 37;
				break;
			case 243:
				num = 1342;
				num2 = 36;
				break;
			case 244:
				num = 1343;
				num2 = 37;
				break;
			case 245:
				num = 1344;
				num2 = 36;
				break;
			case 246:
				num = 1345;
				num2 = 37;
				break;
			case 247:
				num = 1346;
				num2 = 36;
				break;
			case 248:
				num = 1347;
				num2 = 37;
				break;
			case 249:
				num = 1348;
				num2 = 37;
				break;
			case 250:
				num = 1349;
				num2 = 37;
				break;
			case 251:
				num = 1350;
				num2 = 36;
				break;
			case 252:
				num = 1351;
				num2 = 37;
				break;
			case 253:
				num = 1352;
				num2 = 37;
				break;
			case 254:
				num = 1353;
				num2 = 36;
				break;
			case byte.MaxValue:
				num = 1354;
				num2 = 36;
				break;
			}
			break;
		case 1:
			switch (mode)
			{
			case 0:
				num = 1355;
				num2 = 36;
				break;
			case 1:
				num = 1356;
				num2 = 36;
				break;
			case 2:
				num = 1357;
				num2 = 36;
				break;
			case 3:
				num = 1358;
				num2 = 36;
				break;
			case 4:
				num = 1359;
				num2 = 36;
				break;
			case 5:
				num = 1380;
				num2 = 37;
				break;
			case 6:
				num = 1381;
				num2 = 37;
				break;
			case 7:
				num = 1382;
				num2 = 36;
				break;
			case 8:
				num = 1383;
				num2 = 36;
				break;
			case 9:
				num = 1384;
				num2 = 37;
				break;
			case 10:
				num = 1385;
				num2 = 36;
				break;
			case 11:
				num = 1386;
				num2 = 36;
				break;
			case 12:
				num = 1387;
				num2 = 37;
				break;
			case 13:
				num = 1388;
				num2 = 36;
				break;
			case 14:
				num = 1389;
				num2 = 37;
				break;
			case 15:
				num = 1390;
				num2 = 37;
				break;
			case 16:
				num = 1391;
				num2 = 37;
				break;
			case 17:
				num = 1392;
				num2 = 37;
				break;
			case 18:
				num = 1393;
				num2 = 36;
				break;
			case 19:
				num = 1394;
				num2 = 36;
				break;
			case 20:
				num = 1395;
				num2 = 36;
				break;
			case 21:
				num = 1396;
				num2 = 36;
				break;
			case 22:
				num = 1397;
				num2 = 37;
				break;
			case 23:
				num = 1398;
				num2 = 36;
				break;
			case 24:
				num = 1399;
				num2 = 36;
				break;
			case 25:
				num = 1418;
				num2 = 37;
				break;
			case 26:
				num = 1419;
				num2 = 37;
				break;
			case 27:
				num = 1420;
				num2 = 36;
				break;
			case 28:
				num = 1421;
				num2 = 36;
				break;
			case 29:
				num = 1422;
				num2 = 36;
				break;
			case 30:
				num = 1423;
				num2 = 37;
				break;
			case 31:
				num = 1424;
				num2 = 36;
				break;
			case 32:
				num = 1425;
				num2 = 37;
				break;
			case 33:
				num = 1426;
				num2 = 36;
				break;
			case 34:
				num = 1427;
				num2 = 36;
				break;
			case 35:
				num = 1428;
				num2 = 36;
				break;
			case 36:
				num = 1429;
				num2 = 36;
				break;
			case 37:
				num = 1430;
				num2 = 37;
				break;
			case 38:
				num = 1431;
				num2 = 36;
				break;
			case 39:
				num = 1432;
				num2 = 36;
				break;
			case 40:
				num = 1433;
				num2 = 36;
				break;
			case 41:
				num = 1434;
				num2 = 36;
				break;
			case 42:
				num = 1435;
				num2 = 36;
				break;
			case 43:
				num = 1436;
				num2 = 36;
				break;
			case 44:
				num = 1437;
				num2 = 36;
				break;
			case 45:
				num = 1462;
				num2 = 37;
				break;
			case 46:
				num = 1463;
				num2 = 36;
				break;
			case 47:
				num = 1464;
				num2 = 36;
				break;
			case 48:
				num = 1465;
				num2 = 36;
				break;
			case 49:
				num = 1466;
				num2 = 36;
				break;
			case 50:
				num = 1467;
				num2 = 36;
				break;
			case 51:
				num = 1468;
				num2 = 36;
				break;
			case 52:
				num = 1469;
				num2 = 37;
				break;
			case 53:
				num = 1470;
				num2 = 36;
				break;
			case 54:
				num = 1471;
				num2 = 37;
				break;
			case 55:
				num = 1472;
				num2 = 37;
				break;
			case 56:
				num = 1473;
				num2 = 36;
				break;
			case 57:
				num = 1474;
				num2 = 37;
				break;
			case 58:
				num = 1475;
				num2 = 36;
				break;
			case 59:
				num = 1476;
				num2 = 36;
				break;
			case 60:
				num = 1477;
				num2 = 36;
				break;
			case 61:
				num = 1478;
				num2 = 36;
				break;
			case 62:
				num = 1479;
				num2 = 36;
				break;
			case 63:
				num = 1480;
				num2 = 36;
				break;
			case 64:
				num = 1481;
				num2 = 36;
				break;
			case 65:
				num = 1505;
				num2 = 37;
				break;
			case 66:
				num = 1506;
				num2 = 37;
				break;
			case 67:
				num = 1507;
				num2 = 37;
				break;
			case 68:
				num = 1508;
				num2 = 36;
				break;
			case 69:
				num = 1509;
				num2 = 37;
				break;
			case 70:
				num = 1510;
				num2 = 37;
				break;
			case 71:
				num = 1511;
				num2 = 36;
				break;
			case 72:
				num = 1512;
				num2 = 37;
				break;
			case 73:
				num = 1513;
				num2 = 37;
				break;
			case 74:
				num = 1514;
				num2 = 37;
				break;
			case 75:
				num = 1515;
				num2 = 37;
				break;
			case 76:
				num = 1516;
				num2 = 36;
				break;
			case 77:
				num = 1517;
				num2 = 36;
				break;
			case 78:
				num = 1518;
				num2 = 37;
				break;
			case 79:
				num = 1519;
				num2 = 36;
				break;
			case 80:
				num = 1520;
				num2 = 37;
				break;
			case 81:
				num = 1521;
				num2 = 36;
				break;
			case 82:
				num = 1522;
				num2 = 36;
				break;
			case 83:
				num = 1523;
				num2 = 36;
				break;
			case 84:
				num = 1524;
				num2 = 37;
				break;
			case 85:
				num = 1687;
				num2 = 36;
				break;
			case 86:
				num = 1688;
				num2 = 36;
				break;
			case 87:
				num = 1689;
				num2 = 36;
				break;
			case 88:
				num = 1690;
				num2 = 36;
				break;
			case 89:
				num = 1691;
				num2 = 36;
				break;
			case 90:
				num = 1692;
				num2 = 36;
				break;
			case 91:
				num = 1693;
				num2 = 36;
				break;
			case 92:
				num = 1694;
				num2 = 36;
				break;
			case 93:
				num = 1695;
				num2 = 36;
				break;
			case 94:
				num = 1696;
				num2 = 36;
				break;
			case 95:
				num = 721;
				num2 = 36;
				break;
			case 96:
				num = 722;
				num2 = 36;
				break;
			case 97:
				num = 723;
				num2 = 37;
				break;
			case 98:
				num = 724;
				num2 = 36;
				break;
			case 99:
				num = 733;
				num2 = 36;
				break;
			case 100:
				num = 734;
				num2 = 36;
				break;
			case 101:
				num = 735;
				num2 = 36;
				break;
			case 102:
				num = 736;
				num2 = 36;
				break;
			case 103:
				num = 745;
				num2 = 36;
				break;
			case 104:
				num = 746;
				num2 = 36;
				break;
			case 105:
				num = 747;
				num2 = 36;
				break;
			case 106:
				num = 748;
				num2 = 36;
				break;
			case 107:
				num = 757;
				num2 = 37;
				break;
			case 108:
				num = 758;
				num2 = 36;
				break;
			case 109:
				num = 759;
				num2 = 36;
				break;
			case 110:
				num = 760;
				num2 = 36;
				break;
			case 111:
				num = 769;
				num2 = 36;
				break;
			case 112:
				num = 770;
				num2 = 36;
				break;
			case 113:
				num = 771;
				num2 = 36;
				break;
			case 114:
				num = 772;
				num2 = 36;
				break;
			case 115:
				num = 789;
				num2 = 36;
				break;
			case 116:
				num = 790;
				num2 = 36;
				break;
			case 117:
				num = 791;
				num2 = 36;
				break;
			case 118:
				num = 792;
				num2 = 36;
				break;
			case 119:
				num = 793;
				num2 = 36;
				break;
			case 120:
				num = 794;
				num2 = 36;
				break;
			case 121:
				num = 795;
				num2 = 36;
				break;
			case 122:
				num = 796;
				num2 = 36;
				break;
			case 123:
				num = 1077;
				num2 = 39;
				layer = 70;
				break;
			case 124:
				num = 1079;
				num2 = 39;
				layer = 70;
				break;
			case 125:
				num = 1081;
				num2 = 39;
				layer = 70;
				break;
			case 126:
				num = 1083;
				num2 = 39;
				layer = 70;
				break;
			case 127:
				num = 1089;
				num2 = 39;
				layer = 70;
				break;
			case 128:
				num = 1091;
				num2 = 39;
				layer = 70;
				break;
			case 129:
				num = 1093;
				num2 = 39;
				layer = 70;
				break;
			case 130:
				num = 1095;
				num2 = 39;
				layer = 70;
				break;
			case 131:
				num = 1101;
				num2 = 39;
				layer = 70;
				break;
			case 132:
				num = 1103;
				num2 = 39;
				layer = 70;
				break;
			case 133:
				num = 1105;
				num2 = 39;
				layer = 70;
				break;
			case 134:
				num = 1107;
				num2 = 39;
				layer = 70;
				break;
			case 135:
				num = 1113;
				num2 = 39;
				layer = 70;
				break;
			case 136:
				num = 1115;
				num2 = 39;
				layer = 70;
				break;
			case 137:
				num = 1117;
				num2 = 39;
				layer = 70;
				break;
			case 138:
				num = 1119;
				num2 = 39;
				layer = 70;
				break;
			case 139:
				num = 1125;
				num2 = 39;
				layer = 70;
				break;
			case 140:
				num = 1127;
				num2 = 39;
				layer = 70;
				break;
			case 141:
				num = 1129;
				num2 = 39;
				layer = 70;
				break;
			case 142:
				num = 1131;
				num2 = 39;
				layer = 70;
				break;
			case 143:
				num = 1141;
				num2 = 39;
				layer = 70;
				break;
			case 144:
				num = 1143;
				num2 = 39;
				layer = 70;
				break;
			case 145:
				num = 1145;
				num2 = 39;
				layer = 70;
				break;
			case 146:
				num = 1147;
				num2 = 39;
				layer = 70;
				break;
			case 147:
				num = 1149;
				num2 = 39;
				layer = 70;
				break;
			case 148:
				num = 1151;
				num2 = 39;
				layer = 70;
				break;
			case 149:
				num = 1153;
				num2 = 39;
				layer = 70;
				break;
			case 150:
				num = 1155;
				num2 = 39;
				layer = 70;
				break;
			case 151:
				num = 1078;
				num2 = 39;
				layer = 70;
				break;
			case 152:
				num = 1080;
				num2 = 39;
				layer = 70;
				break;
			case 153:
				num = 1082;
				num2 = 39;
				layer = 70;
				break;
			case 154:
				num = 1084;
				num2 = 39;
				layer = 70;
				break;
			case 155:
				num = 1090;
				num2 = 39;
				layer = 70;
				break;
			case 156:
				num = 1092;
				num2 = 39;
				layer = 70;
				break;
			case 157:
				num = 1094;
				num2 = 39;
				layer = 70;
				break;
			case 158:
				num = 1096;
				num2 = 39;
				layer = 70;
				break;
			case 159:
				num = 1102;
				num2 = 39;
				layer = 70;
				break;
			case 160:
				num = 1104;
				num2 = 39;
				layer = 70;
				break;
			case 161:
				num = 1106;
				num2 = 39;
				layer = 70;
				break;
			case 162:
				num = 1108;
				num2 = 39;
				layer = 70;
				break;
			case 163:
				num = 1114;
				num2 = 39;
				layer = 70;
				break;
			case 164:
				num = 1116;
				num2 = 39;
				layer = 70;
				break;
			case 165:
				num = 1118;
				num2 = 39;
				layer = 70;
				break;
			case 166:
				num = 1120;
				num2 = 39;
				layer = 70;
				break;
			case 167:
				num = 1126;
				num2 = 39;
				layer = 70;
				break;
			case 168:
				num = 1128;
				num2 = 39;
				layer = 70;
				break;
			case 169:
				num = 1130;
				num2 = 39;
				layer = 70;
				break;
			case 170:
				num = 1132;
				num2 = 39;
				layer = 70;
				break;
			case 171:
				num = 1142;
				num2 = 39;
				layer = 70;
				break;
			case 172:
				num = 1144;
				num2 = 39;
				layer = 70;
				break;
			case 173:
				num = 1146;
				num2 = 39;
				layer = 70;
				break;
			case 174:
				num = 1148;
				num2 = 39;
				layer = 70;
				break;
			case 175:
				num = 1150;
				num2 = 39;
				layer = 70;
				break;
			case 176:
				num = 1152;
				num2 = 39;
				layer = 70;
				break;
			case 177:
				num = 1154;
				num2 = 39;
				layer = 70;
				break;
			case 178:
				num = 1156;
				num2 = 39;
				layer = 70;
				break;
			case 179:
				num = 1073;
				num2 = 36;
				break;
			case 180:
				num = 1074;
				num2 = 36;
				break;
			case 181:
				num = 1075;
				num2 = 36;
				break;
			case 182:
				num = 1076;
				num2 = 37;
				break;
			case 183:
				num = 1085;
				num2 = 36;
				break;
			case 184:
				num = 1086;
				num2 = 36;
				break;
			case 185:
				num = 1087;
				num2 = 36;
				break;
			case 186:
				num = 1088;
				num2 = 36;
				break;
			case 187:
				num = 1097;
				num2 = 36;
				break;
			case 188:
				num = 1098;
				num2 = 36;
				break;
			case 189:
				num = 1099;
				num2 = 36;
				break;
			case 190:
				num = 1100;
				num2 = 36;
				break;
			case 191:
				num = 1109;
				num2 = 36;
				break;
			case 192:
				num = 1110;
				num2 = 36;
				break;
			case 193:
				num = 1111;
				num2 = 36;
				break;
			case 194:
				num = 1112;
				num2 = 36;
				break;
			case 195:
				num = 1121;
				num2 = 36;
				break;
			case 196:
				num = 1122;
				num2 = 36;
				break;
			case 197:
				num = 1123;
				num2 = 36;
				break;
			case 198:
				num = 1124;
				num2 = 36;
				break;
			case 199:
				num = 1133;
				num2 = 36;
				break;
			case 200:
				num = 1134;
				num2 = 36;
				break;
			case 201:
				num = 1135;
				num2 = 36;
				break;
			case 202:
				num = 1136;
				num2 = 36;
				break;
			case 203:
				num = 1137;
				num2 = 36;
				break;
			case 204:
				num = 1138;
				num2 = 36;
				break;
			case 205:
				num = 1139;
				num2 = 36;
				break;
			case 206:
				num = 1140;
				num2 = 36;
				break;
			case 207:
				num = 713;
				num2 = 39;
				layer = 70;
				break;
			case 208:
				num = 715;
				num2 = 39;
				layer = 70;
				break;
			case 209:
				num = 717;
				num2 = 39;
				layer = 70;
				break;
			case 210:
				num = 719;
				num2 = 39;
				layer = 70;
				break;
			case 211:
				num = 725;
				num2 = 39;
				layer = 70;
				break;
			case 212:
				num = 727;
				num2 = 39;
				layer = 70;
				break;
			case 213:
				num = 729;
				num2 = 39;
				layer = 70;
				break;
			case 214:
				num = 731;
				num2 = 39;
				layer = 70;
				break;
			case 215:
				num = 737;
				num2 = 39;
				layer = 70;
				break;
			case 216:
				num = 739;
				num2 = 39;
				layer = 70;
				break;
			case 217:
				num = 741;
				num2 = 39;
				layer = 70;
				break;
			case 218:
				num = 743;
				num2 = 39;
				layer = 70;
				break;
			case 219:
				num = 749;
				num2 = 39;
				layer = 70;
				break;
			case 220:
				num = 751;
				num2 = 39;
				layer = 70;
				break;
			case 221:
				num = 753;
				num2 = 39;
				layer = 70;
				break;
			case 222:
				num = 755;
				num2 = 39;
				layer = 70;
				break;
			case 223:
				num = 761;
				num2 = 39;
				layer = 70;
				break;
			case 224:
				num = 763;
				num2 = 39;
				layer = 70;
				break;
			case 225:
				num = 765;
				num2 = 39;
				layer = 70;
				break;
			case 226:
				num = 767;
				num2 = 39;
				layer = 70;
				break;
			case 227:
				num = 773;
				num2 = 39;
				layer = 70;
				break;
			case 228:
				num = 775;
				num2 = 39;
				layer = 70;
				break;
			case 229:
				num = 777;
				num2 = 39;
				layer = 70;
				break;
			case 230:
				num = 779;
				num2 = 39;
				layer = 70;
				break;
			case 231:
				num = 781;
				num2 = 39;
				layer = 70;
				break;
			case 232:
				num = 783;
				num2 = 39;
				layer = 70;
				break;
			case 233:
				num = 785;
				num2 = 39;
				layer = 70;
				break;
			case 234:
				num = 787;
				num2 = 39;
				layer = 70;
				break;
			case 235:
				num = 714;
				num2 = 39;
				layer = 70;
				break;
			case 236:
				num = 716;
				num2 = 39;
				layer = 70;
				break;
			case 237:
				num = 718;
				num2 = 39;
				layer = 70;
				break;
			case 238:
				num = 720;
				num2 = 39;
				layer = 70;
				break;
			case 239:
				num = 726;
				num2 = 39;
				layer = 70;
				break;
			case 240:
				num = 728;
				num2 = 39;
				layer = 70;
				break;
			case 241:
				num = 730;
				num2 = 39;
				layer = 70;
				break;
			case 242:
				num = 732;
				num2 = 39;
				layer = 70;
				break;
			case 243:
				num = 738;
				num2 = 39;
				layer = 70;
				break;
			case 244:
				num = 740;
				num2 = 39;
				layer = 70;
				break;
			case 245:
				num = 742;
				num2 = 39;
				layer = 70;
				break;
			case 246:
				num = 744;
				num2 = 39;
				layer = 70;
				break;
			case 247:
				num = 750;
				num2 = 39;
				layer = 70;
				break;
			case 248:
				num = 752;
				num2 = 39;
				layer = 70;
				break;
			case 249:
				num = 754;
				num2 = 39;
				layer = 70;
				break;
			case 250:
				num = 756;
				num2 = 39;
				layer = 70;
				break;
			case 251:
				num = 762;
				num2 = 39;
				layer = 70;
				break;
			case 252:
				num = 764;
				num2 = 39;
				layer = 70;
				break;
			case 253:
				num = 766;
				num2 = 39;
				layer = 70;
				break;
			case 254:
				num = 768;
				num2 = 39;
				layer = 70;
				break;
			case byte.MaxValue:
				num = 774;
				num2 = 39;
				layer = 70;
				break;
			}
			break;
		case 2:
			switch (mode)
			{
			case 0:
				num = 776;
				num2 = 39;
				layer = 70;
				break;
			case 1:
				num = 778;
				num2 = 39;
				layer = 70;
				break;
			case 2:
				num = 780;
				num2 = 39;
				layer = 70;
				break;
			case 3:
				num = 782;
				num2 = 39;
				layer = 70;
				break;
			case 4:
				num = 784;
				num2 = 39;
				layer = 70;
				break;
			case 5:
				num = 786;
				num2 = 39;
				layer = 70;
				break;
			case 6:
				num = 788;
				num2 = 39;
				layer = 70;
				break;
			}
			break;
		}
		if (num2 >= 0)
		{
			evt.eventPlayAnime((DirectionManager.ANIME)num2, low * 1000 + mode, false, false, false, false, 128, 72, layer, 0);
		}
		if (num >= 0)
		{
			evt.eventPlaySound((DirectionManager.SOUND)num, Sound.CH.VC2, true, 1f, 12);
		}
		switch (low)
		{
		case 0:
			switch (mode)
			{
			case 1:
				break;
			case 2:
				break;
			case 3:
				break;
			case 4:
				break;
			case 5:
				break;
			case 6:
				break;
			case 7:
				break;
			case 8:
				break;
			case 9:
				break;
			case 10:
				break;
			case 11:
				break;
			case 12:
				break;
			case 13:
				break;
			case 14:
				break;
			case 15:
				break;
			case 16:
				break;
			case 17:
				break;
			case 18:
				break;
			case 19:
				break;
			case 20:
				break;
			case 21:
				break;
			case 22:
				break;
			case 23:
				break;
			case 24:
				break;
			case 25:
				break;
			case 26:
				break;
			case 27:
				break;
			case 28:
				break;
			case 29:
				break;
			case 30:
				break;
			case 31:
				break;
			case 32:
				break;
			case 33:
				break;
			case 34:
				break;
			case 35:
				break;
			case 36:
				break;
			case 37:
				break;
			case 38:
				break;
			case 39:
				break;
			case 40:
				break;
			case 41:
				break;
			case 42:
				break;
			case 43:
				break;
			case 44:
				break;
			case 45:
				break;
			case 46:
				break;
			case 47:
				break;
			case 48:
				break;
			case 49:
				break;
			case 50:
				break;
			case 51:
				break;
			case 52:
				break;
			case 53:
				break;
			case 54:
				break;
			case 55:
				break;
			case 56:
				break;
			case 57:
				break;
			case 58:
				break;
			case 59:
				break;
			case 60:
				break;
			case 61:
				break;
			case 62:
				break;
			case 63:
				break;
			case 64:
				break;
			case 65:
				break;
			case 66:
				break;
			case 67:
				break;
			case 68:
				break;
			case 69:
				break;
			case 70:
				break;
			case 71:
				break;
			case 72:
				break;
			case 73:
				break;
			case 74:
				break;
			case 75:
				break;
			case 76:
				break;
			case 77:
				break;
			case 78:
				break;
			case 79:
				break;
			case 80:
				break;
			case 81:
				break;
			case 82:
				break;
			case 83:
				break;
			case 84:
				break;
			case 85:
				break;
			case 86:
				break;
			case 87:
				break;
			case 88:
				break;
			case 89:
				break;
			case 90:
				break;
			case 91:
				break;
			case 92:
				break;
			case 93:
				break;
			case 94:
				break;
			case 95:
				break;
			case 96:
				break;
			case 97:
				break;
			case 98:
				break;
			case 99:
				break;
			case 100:
				break;
			case 101:
				break;
			case 102:
				break;
			case 103:
				break;
			case 104:
				break;
			case 105:
				break;
			case 106:
				break;
			case 107:
				break;
			case 108:
				break;
			case 109:
				break;
			case 110:
				break;
			case 111:
				break;
			case 112:
				break;
			case 113:
				break;
			case 114:
				break;
			case 115:
				break;
			case 116:
				break;
			case 117:
				break;
			case 118:
				break;
			case 119:
				break;
			case 120:
				break;
			case 121:
				break;
			case 122:
				break;
			case 123:
				break;
			case 124:
				break;
			case 125:
				break;
			case 126:
				break;
			case 127:
				break;
			case 128:
				break;
			case 129:
				break;
			case 130:
				break;
			case 131:
				break;
			case 132:
				break;
			case 133:
				break;
			case 134:
				break;
			case 135:
				break;
			case 136:
				break;
			case 137:
				break;
			case 138:
				break;
			case 139:
				break;
			case 140:
				break;
			case 141:
				break;
			case 142:
				break;
			case 143:
				break;
			case 144:
				break;
			case 145:
				break;
			case 146:
				break;
			case 147:
				break;
			case 148:
				break;
			case 149:
				break;
			case 150:
				break;
			case 151:
				break;
			case 152:
				break;
			case 153:
				break;
			case 154:
				break;
			case 155:
				break;
			case 156:
				break;
			case 157:
				break;
			case 158:
				break;
			case 159:
				break;
			case 160:
				break;
			case 161:
				break;
			case 162:
				break;
			case 163:
				break;
			case 164:
				break;
			case 165:
				break;
			case 166:
				break;
			case 167:
				break;
			case 168:
				break;
			case 169:
				break;
			case 170:
				break;
			case 171:
				break;
			case 172:
				break;
			case 173:
				break;
			case 174:
				break;
			case 175:
				break;
			case 176:
				break;
			case 177:
				break;
			case 178:
				break;
			case 179:
				break;
			case 180:
				break;
			case 181:
				break;
			case 182:
				break;
			case 183:
				break;
			case 184:
				break;
			case 185:
				break;
			case 186:
				break;
			case 187:
				break;
			case 188:
				break;
			case 189:
				break;
			case 190:
				break;
			case 191:
				break;
			case 192:
				break;
			case 193:
				break;
			case 194:
				break;
			case 195:
				break;
			case 196:
				break;
			case 197:
				break;
			case 198:
				break;
			case 199:
				break;
			case 200:
				break;
			case 201:
				break;
			case 202:
				break;
			case 203:
				break;
			case 204:
				break;
			case 205:
				break;
			case 206:
				break;
			case 207:
				break;
			case 208:
				break;
			case 209:
				break;
			case 210:
				break;
			case 211:
				break;
			case 212:
				break;
			case 213:
				break;
			case 214:
				break;
			case 215:
				break;
			case 216:
				break;
			case 217:
				break;
			case 218:
				break;
			case 219:
				break;
			case 220:
				break;
			case 221:
				break;
			case 222:
				break;
			case 223:
				break;
			case 224:
				break;
			case 225:
				break;
			case 226:
				break;
			case 227:
				break;
			case 228:
				break;
			case 229:
				break;
			case 230:
				break;
			case 231:
				break;
			case 232:
				break;
			case 233:
				break;
			case 234:
				break;
			case 235:
				break;
			case 236:
				break;
			case 237:
				break;
			case 238:
				break;
			case 239:
				break;
			case 240:
				break;
			case 241:
				break;
			case 242:
				break;
			case 243:
				break;
			case 244:
				break;
			case 245:
				break;
			case 246:
				break;
			case 247:
				break;
			case 248:
				break;
			case 249:
				break;
			case 250:
				break;
			case 251:
				break;
			case 252:
				break;
			case 253:
				break;
			case 254:
				break;
			case byte.MaxValue:
				break;
			}
			break;
		case 1:
			switch (mode)
			{
			case 0:
				break;
			case 1:
				break;
			case 2:
				break;
			case 3:
				break;
			case 4:
				break;
			case 5:
				break;
			case 6:
				break;
			case 7:
				break;
			case 8:
				break;
			case 9:
				break;
			case 10:
				break;
			case 11:
				break;
			case 12:
				break;
			case 13:
				break;
			case 14:
				break;
			case 15:
				break;
			case 16:
				break;
			case 17:
				break;
			case 18:
				break;
			case 19:
				break;
			case 20:
				break;
			case 21:
				break;
			case 22:
				break;
			case 23:
				break;
			case 24:
				break;
			case 25:
				break;
			case 26:
				break;
			case 27:
				break;
			case 28:
				break;
			case 29:
				break;
			case 30:
				break;
			case 31:
				break;
			case 32:
				break;
			case 33:
				break;
			case 34:
				break;
			case 35:
				break;
			case 36:
				break;
			case 37:
				break;
			case 38:
				break;
			case 39:
				break;
			case 40:
				break;
			case 41:
				break;
			case 42:
				break;
			case 43:
				break;
			case 44:
				break;
			case 45:
				break;
			case 46:
				break;
			case 47:
				break;
			case 48:
				break;
			case 49:
				break;
			case 50:
				break;
			case 51:
				break;
			case 52:
				break;
			case 53:
				break;
			case 54:
				break;
			case 55:
				break;
			case 56:
				break;
			case 57:
				break;
			case 58:
				break;
			case 59:
				break;
			case 60:
				break;
			case 61:
				break;
			case 62:
				break;
			case 63:
				break;
			case 64:
				break;
			case 65:
				break;
			case 66:
				break;
			case 67:
				break;
			case 68:
				break;
			case 69:
				break;
			case 70:
				break;
			case 71:
				break;
			case 72:
				break;
			case 73:
				break;
			case 74:
				break;
			case 75:
				break;
			case 76:
				break;
			case 77:
				break;
			case 78:
				break;
			case 79:
				break;
			case 80:
				break;
			case 81:
				break;
			case 82:
				break;
			case 83:
				break;
			case 84:
				break;
			case 85:
				break;
			case 86:
				break;
			case 87:
				break;
			case 88:
				break;
			case 89:
				break;
			case 90:
				break;
			case 91:
				break;
			case 92:
				break;
			case 93:
				break;
			case 94:
				break;
			case 95:
				break;
			case 96:
				break;
			case 97:
				break;
			case 98:
				break;
			case 99:
				break;
			case 100:
				break;
			case 101:
				break;
			case 102:
				break;
			case 103:
				break;
			case 104:
				break;
			case 105:
				break;
			case 106:
				break;
			case 107:
				break;
			case 108:
				break;
			case 109:
				break;
			case 110:
				break;
			case 111:
				break;
			case 112:
				break;
			case 113:
				break;
			case 114:
				break;
			case 115:
				break;
			case 116:
				break;
			case 117:
				break;
			case 118:
				break;
			case 119:
				break;
			case 120:
				break;
			case 121:
				break;
			case 122:
				break;
			case 123:
				break;
			case 124:
				break;
			case 125:
				break;
			case 126:
				break;
			case 127:
				break;
			case 128:
				break;
			case 129:
				break;
			case 130:
				break;
			case 131:
				break;
			case 132:
				break;
			case 133:
				break;
			case 134:
				break;
			case 135:
				break;
			case 136:
				break;
			case 137:
				break;
			case 138:
				break;
			case 139:
				break;
			case 140:
				break;
			case 141:
				break;
			case 142:
				break;
			case 143:
				break;
			case 144:
				break;
			case 145:
				break;
			case 146:
				break;
			case 147:
				break;
			case 148:
				break;
			case 149:
				break;
			case 150:
				break;
			case 151:
				break;
			case 152:
				break;
			case 153:
				break;
			case 154:
				break;
			case 155:
				break;
			case 156:
				break;
			case 157:
				break;
			case 158:
				break;
			case 159:
				break;
			case 160:
				break;
			case 161:
				break;
			case 162:
				break;
			case 163:
				break;
			case 164:
				break;
			case 165:
				break;
			case 166:
				break;
			case 167:
				break;
			case 168:
				break;
			case 169:
				break;
			case 170:
				break;
			case 171:
				break;
			case 172:
				break;
			case 173:
				break;
			case 174:
				break;
			case 175:
				break;
			case 176:
				break;
			case 177:
				break;
			case 178:
				break;
			case 179:
				break;
			case 180:
				break;
			case 181:
				break;
			case 182:
				break;
			case 183:
				break;
			case 184:
				break;
			case 185:
				break;
			case 186:
				break;
			case 187:
				break;
			case 188:
				break;
			case 189:
				break;
			case 190:
				break;
			case 191:
				break;
			case 192:
				break;
			case 193:
				break;
			case 194:
				break;
			case 195:
				break;
			case 196:
				break;
			case 197:
				break;
			case 198:
				break;
			case 199:
				break;
			case 200:
				break;
			case 201:
				break;
			case 202:
				break;
			case 203:
				break;
			case 204:
				break;
			case 205:
				break;
			case 206:
				break;
			case 207:
				break;
			case 208:
				break;
			case 209:
				break;
			case 210:
				break;
			case 211:
				break;
			case 212:
				break;
			case 213:
				break;
			case 214:
				break;
			case 215:
				break;
			case 216:
				break;
			case 217:
				break;
			case 218:
				break;
			case 219:
				break;
			case 220:
				break;
			case 221:
				break;
			case 222:
				break;
			case 223:
				break;
			case 224:
				break;
			case 225:
				break;
			case 226:
				break;
			case 227:
				break;
			case 228:
				break;
			case 229:
				break;
			case 230:
				break;
			case 231:
				break;
			case 232:
				break;
			case 233:
				break;
			case 234:
				break;
			case 235:
				break;
			case 236:
				break;
			case 237:
				break;
			case 238:
				break;
			case 239:
				break;
			case 240:
				break;
			case 241:
				break;
			case 242:
				break;
			case 243:
				break;
			case 244:
				break;
			case 245:
				break;
			case 246:
				break;
			case 247:
				break;
			case 248:
				break;
			case 249:
				break;
			case 250:
				break;
			case 251:
				break;
			case 252:
				break;
			case 253:
				break;
			case 254:
				break;
			case byte.MaxValue:
				break;
			}
			break;
		case 2:
			switch (mode)
			{
			case 0:
				break;
			case 1:
				break;
			case 2:
				break;
			case 3:
				break;
			case 4:
				break;
			case 5:
				break;
			case 6:
				break;
			}
			break;
		}
	}

	public override void end()
	{
		base.end();
	}

	public override void control()
	{
		base.control();
	}
}
