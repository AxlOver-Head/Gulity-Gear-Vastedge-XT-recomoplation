using UnityEngine;

public class LEDPanelObj_Panel : LEDPanelObj
{
	public enum KIND
	{
		PANEL = 0,
		MAX = 1
	}

	public LEDPanelObj_Panel(LEDPanelManager _man)
		: base(_man)
	{
	}

	public void init()
	{
		m_LEDArray = new GameObject[1];
		m_LEDArray[0] = GameObject.Find("kyoutai/body/LED/Panel");
		setLEDColor();
	}

	private void setColor(out Color col, int i, int j)
	{
		float r = 0f;
		float g = 0f;
		float b = 0f;
		float a = 0f;
		if (i == 0)
		{
			switch (j)
			{
			case 0:
			case 1:
			case 2:
			case 3:
				r = 1f;
				g = 1f;
				b = 1f;
				a = (float)(int)man.blendData[10] / 255f;
				break;
			case 4:
			case 5:
			case 6:
			case 7:
				r = 1f;
				g = 1f;
				b = 1f;
				a = ((man.blendData[9] != 0) ? 1f : 0f);
				break;
			case 8:
			case 9:
			case 10:
			case 11:
				r = 1f;
				g = 1f;
				b = 1f;
				a = ((man.blendData[11] != 0) ? 1f : 0f);
				break;
			case 12:
			case 13:
			case 14:
			case 15:
				r = (float)(int)man.blendData[3] / 255f;
				g = (float)(int)man.blendData[4] / 255f;
				b = (float)(int)man.blendData[5] / 255f;
				a = 1f;
				break;
			case 16:
			case 17:
			case 18:
			case 19:
				r = (float)(int)man.blendData[6] / 255f;
				g = (float)(int)man.blendData[7] / 255f;
				b = (float)(int)man.blendData[8] / 255f;
				a = 1f;
				break;
			case 20:
			case 21:
			case 22:
			case 23:
				r = (float)(int)man.blendData[81] / 255f;
				g = (float)(int)man.blendData[82] / 255f;
				b = (float)(int)man.blendData[83] / 255f;
				a = 1f;
				break;
			case 24:
			case 25:
			case 26:
			case 27:
				r = (float)(int)man.blendData[86] / 255f;
				g = (float)(int)man.blendData[86] / 255f;
				b = (float)(int)man.blendData[86] / 255f;
				a = 1f;
				break;
			case 28:
			case 29:
			case 30:
			case 31:
				r = (float)(int)man.blendData[89] / 255f;
				g = (float)(int)man.blendData[89] / 255f;
				b = (float)(int)man.blendData[89] / 255f;
				a = 1f;
				break;
			case 32:
			case 33:
			case 34:
			case 35:
				r = (float)(int)man.blendData[92] / 255f;
				g = (float)(int)man.blendData[92] / 255f;
				b = (float)(int)man.blendData[92] / 255f;
				a = 1f;
				break;
			case 36:
			case 37:
			case 38:
			case 39:
				r = (float)(int)man.blendData[95] / 255f;
				g = (float)(int)man.blendData[95] / 255f;
				b = (float)(int)man.blendData[95] / 255f;
				a = 1f;
				break;
			case 40:
			case 41:
			case 42:
			case 43:
				r = (float)(int)man.blendData[96] / 255f;
				g = (float)(int)man.blendData[97] / 255f;
				b = (float)(int)man.blendData[98] / 255f;
				a = 1f;
				break;
			case 44:
			case 45:
			case 46:
			case 47:
				r = (float)(int)man.blendData[93] / 255f;
				g = (float)(int)man.blendData[93] / 255f;
				b = (float)(int)man.blendData[93] / 255f;
				a = 1f;
				break;
			case 48:
			case 49:
			case 50:
			case 51:
				r = (float)(int)man.blendData[90] / 255f;
				g = (float)(int)man.blendData[90] / 255f;
				b = (float)(int)man.blendData[90] / 255f;
				a = 1f;
				break;
			case 52:
			case 53:
			case 54:
			case 55:
				r = (float)(int)man.blendData[87] / 255f;
				g = (float)(int)man.blendData[87] / 255f;
				b = (float)(int)man.blendData[87] / 255f;
				a = 1f;
				break;
			case 56:
			case 57:
			case 58:
			case 59:
				r = (float)(int)man.blendData[84] / 255f;
				g = (float)(int)man.blendData[84] / 255f;
				b = (float)(int)man.blendData[84] / 255f;
				a = 1f;
				break;
			case 60:
			case 61:
			case 62:
			case 63:
				r = 1f;
				g = 1f;
				b = 1f;
				a = (float)(int)man.blendData[68] / 255f;
				break;
			case 64:
			case 65:
			case 66:
			case 67:
				r = 1f;
				g = 1f;
				b = 1f;
				a = (float)(int)man.blendData[71] / 255f;
				break;
			case 68:
			case 69:
			case 70:
			case 71:
				r = 1f;
				g = 1f;
				b = 1f;
				a = (float)(int)man.blendData[74] / 255f;
				break;
			case 72:
			case 73:
			case 74:
			case 75:
				r = 1f;
				g = 1f;
				b = 1f;
				a = (float)(int)man.blendData[77] / 255f;
				break;
			case 76:
			case 77:
			case 78:
			case 79:
				r = 1f;
				g = 1f;
				b = 1f;
				a = (float)(int)man.blendData[80] / 255f;
				break;
			case 80:
			case 81:
			case 82:
			case 83:
				r = 1f;
				g = 1f;
				b = 1f;
				a = (float)(int)man.blendData[66] / 255f;
				break;
			case 84:
			case 85:
			case 86:
			case 87:
				r = 1f;
				g = 1f;
				b = 1f;
				a = (float)(int)man.blendData[69] / 255f;
				break;
			case 88:
			case 89:
			case 90:
			case 91:
				r = 1f;
				g = 1f;
				b = 1f;
				a = (float)(int)man.blendData[72] / 255f;
				break;
			case 92:
			case 93:
			case 94:
			case 95:
				r = 1f;
				g = 1f;
				b = 1f;
				a = (float)(int)man.blendData[75] / 255f;
				break;
			case 96:
			case 97:
			case 98:
			case 99:
				r = 1f;
				g = 1f;
				b = 1f;
				a = (float)(int)man.blendData[78] / 255f;
				break;
			case 100:
			case 101:
			case 102:
			case 103:
				r = (float)(int)man.blendData[99] / 255f;
				g = (float)(int)man.blendData[100] / 255f;
				b = (float)(int)man.blendData[101] / 255f;
				a = 1f;
				break;
			case 104:
			case 105:
			case 106:
			case 107:
				r = (float)(int)man.blendData[21] / 255f;
				g = (float)(int)man.blendData[22] / 255f;
				b = (float)(int)man.blendData[23] / 255f;
				a = 1f;
				break;
			case 108:
			case 109:
			case 110:
			case 111:
				r = (float)(int)man.blendData[24] / 255f;
				g = (float)(int)man.blendData[25] / 255f;
				b = (float)(int)man.blendData[26] / 255f;
				a = 1f;
				break;
			case 112:
			case 113:
			case 114:
			case 115:
				r = (float)(int)man.blendData[27] / 255f;
				g = (float)(int)man.blendData[28] / 255f;
				b = (float)(int)man.blendData[29] / 255f;
				a = 1f;
				break;
			case 116:
			case 117:
			case 118:
			case 119:
				r = (float)(int)man.blendData[30] / 255f;
				g = (float)(int)man.blendData[31] / 255f;
				b = (float)(int)man.blendData[32] / 255f;
				a = 1f;
				break;
			case 120:
			case 121:
			case 122:
			case 123:
				r = (float)(int)man.blendData[33] / 255f;
				g = (float)(int)man.blendData[34] / 255f;
				b = (float)(int)man.blendData[35] / 255f;
				a = 1f;
				break;
			case 124:
			case 125:
			case 126:
			case 127:
				r = (float)(int)man.blendData[36] / 255f;
				g = (float)(int)man.blendData[37] / 255f;
				b = (float)(int)man.blendData[38] / 255f;
				a = 1f;
				break;
			case 128:
			case 129:
			case 130:
			case 131:
				r = (float)(int)man.blendData[102] / 255f;
				g = (float)(int)man.blendData[103] / 255f;
				b = (float)(int)man.blendData[104] / 255f;
				a = 1f;
				break;
			case 132:
			case 133:
			case 134:
			case 135:
				r = (float)(int)man.blendData[39] / 255f;
				g = (float)(int)man.blendData[40] / 255f;
				b = (float)(int)man.blendData[41] / 255f;
				a = 1f;
				break;
			case 136:
			case 137:
			case 138:
			case 139:
				r = (float)(int)man.blendData[42] / 255f;
				g = (float)(int)man.blendData[43] / 255f;
				b = (float)(int)man.blendData[44] / 255f;
				a = 1f;
				break;
			case 140:
			case 141:
			case 142:
			case 143:
				r = (float)(int)man.blendData[18] / 255f;
				g = (float)(int)man.blendData[19] / 255f;
				b = (float)(int)man.blendData[20] / 255f;
				a = 1f;
				break;
			case 144:
			case 145:
			case 146:
			case 147:
				r = (float)(int)man.blendData[15] / 255f;
				g = (float)(int)man.blendData[16] / 255f;
				b = (float)(int)man.blendData[17] / 255f;
				a = 1f;
				break;
			case 148:
			case 149:
			case 150:
			case 151:
				r = (float)(int)man.blendData[45] / 255f;
				g = (float)(int)man.blendData[46] / 255f;
				b = (float)(int)man.blendData[47] / 255f;
				a = 1f;
				break;
			case 152:
			case 153:
			case 154:
			case 155:
				r = (float)(int)man.blendData[12] / 255f;
				g = (float)(int)man.blendData[13] / 255f;
				b = (float)(int)man.blendData[14] / 255f;
				a = 1f;
				break;
			case 156:
			case 157:
			case 158:
			case 159:
				r = (float)(int)man.blendData[63] / 255f;
				g = (float)(int)man.blendData[64] / 255f;
				b = (float)(int)man.blendData[65] / 255f;
				a = 1f;
				break;
			case 160:
			case 161:
			case 162:
			case 163:
				r = (float)(int)man.blendData[60] / 255f;
				g = (float)(int)man.blendData[61] / 255f;
				b = (float)(int)man.blendData[62] / 255f;
				a = 1f;
				break;
			case 164:
			case 165:
			case 166:
			case 167:
				r = (float)(int)man.blendData[57] / 255f;
				g = (float)(int)man.blendData[58] / 255f;
				b = (float)(int)man.blendData[59] / 255f;
				a = 1f;
				break;
			case 168:
			case 169:
			case 170:
			case 171:
				r = (float)(int)man.blendData[54] / 255f;
				g = (float)(int)man.blendData[55] / 255f;
				b = (float)(int)man.blendData[56] / 255f;
				a = 1f;
				break;
			case 172:
			case 173:
			case 174:
			case 175:
				r = (float)(int)man.blendData[51] / 255f;
				g = (float)(int)man.blendData[52] / 255f;
				b = (float)(int)man.blendData[53] / 255f;
				a = 1f;
				break;
			case 176:
			case 177:
			case 178:
			case 179:
				r = (float)(int)man.blendData[48] / 255f;
				g = (float)(int)man.blendData[49] / 255f;
				b = (float)(int)man.blendData[50] / 255f;
				a = 1f;
				break;
			default:
				r = 0f;
				g = 0f;
				b = 0f;
				a = 0f;
				break;
			}
		}
		col.a = a;
		col.r = r;
		col.g = g;
		col.b = b;
	}

	public void control()
	{
		for (int i = 0; i < m_LEDArray.Length; i++)
		{
			for (int j = 0; j < m_LEDColorArray[i].Length; j++)
			{
				setColor(out m_LEDColorArray[i][j], i, j);
			}
			m_LEDMeshArray[i].colors = m_LEDColorArray[i];
		}
	}
}
