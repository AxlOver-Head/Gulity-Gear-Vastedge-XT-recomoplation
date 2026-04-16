using UnityEngine;

public class LEDMainObj_Cube : LEDMainObj
{
	public enum KIND
	{
		CUBE = 0,
		MAX = 1
	}

	public LEDMainObj_Cube(LEDMainManager _man)
		: base(_man)
	{
		m_LEDArray = new GameObject[1];
		m_LEDArray[0] = GameObject.Find("kyoutai/sglg_CG/sglg_cube_light/cube_A_01");
		setLEDColor();
	}

	public void init()
	{
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
			case 24:
			case 25:
			case 26:
			case 27:
				r = (float)(int)man.blendData[170] / 31f;
				g = (float)(int)man.blendData[171] / 31f;
				b = (float)(int)man.blendData[172] / 31f;
				a = 1f;
				break;
			case 4:
			case 5:
			case 6:
			case 7:
			case 28:
			case 29:
			case 30:
			case 31:
				r = (float)(int)man.blendData[173] / 31f;
				g = (float)(int)man.blendData[174] / 31f;
				b = (float)(int)man.blendData[175] / 31f;
				a = 1f;
				break;
			case 8:
			case 9:
			case 10:
			case 11:
			case 32:
			case 33:
			case 34:
			case 35:
				r = (float)(int)man.blendData[176] / 31f;
				g = (float)(int)man.blendData[177] / 31f;
				b = (float)(int)man.blendData[178] / 31f;
				a = 1f;
				break;
			case 12:
			case 13:
			case 14:
			case 15:
			case 36:
			case 37:
			case 38:
			case 39:
				r = (float)(int)man.blendData[179] / 31f;
				g = (float)(int)man.blendData[180] / 31f;
				b = (float)(int)man.blendData[181] / 31f;
				a = 1f;
				break;
			case 16:
			case 17:
			case 18:
			case 19:
			case 40:
			case 41:
			case 42:
			case 43:
				r = (float)(int)man.blendData[182] / 31f;
				g = (float)(int)man.blendData[183] / 31f;
				b = (float)(int)man.blendData[184] / 31f;
				a = 1f;
				break;
			case 20:
			case 21:
			case 22:
			case 23:
			case 44:
			case 45:
			case 46:
			case 47:
				r = (float)(int)man.blendData[185] / 31f;
				g = (float)(int)man.blendData[186] / 31f;
				b = (float)(int)man.blendData[187] / 31f;
				a = 1f;
				break;
			case 48:
			case 49:
			case 50:
			case 51:
			case 76:
			case 77:
			case 78:
			case 79:
			{
				float num17 = (float)(int)man.blendData[170] / 31f;
				float num18 = (float)(int)man.blendData[171] / 31f;
				float num19 = (float)(int)man.blendData[172] / 31f;
				float num20 = num17;
				if (num20 < num18)
				{
					num20 = num18;
				}
				if (num20 < num19)
				{
					num20 = num19;
				}
				r = 1f;
				g = 1f;
				b = 1f;
				a = num20;
				break;
			}
			case 52:
			case 53:
			case 54:
			case 55:
			case 80:
			case 81:
			case 82:
			case 83:
			{
				float num5 = (float)(int)man.blendData[173] / 31f;
				float num6 = (float)(int)man.blendData[174] / 31f;
				float num7 = (float)(int)man.blendData[175] / 31f;
				float num8 = num5;
				if (num8 < num6)
				{
					num8 = num6;
				}
				if (num8 < num7)
				{
					num8 = num7;
				}
				r = 1f;
				g = 1f;
				b = 1f;
				a = num8;
				break;
			}
			case 56:
			case 57:
			case 58:
			case 59:
			case 60:
			case 61:
			case 62:
			case 63:
			{
				float num9 = (float)(int)man.blendData[176] / 31f;
				float num10 = (float)(int)man.blendData[177] / 31f;
				float num11 = (float)(int)man.blendData[178] / 31f;
				float num12 = num9;
				if (num12 < num10)
				{
					num12 = num10;
				}
				if (num12 < num11)
				{
					num12 = num11;
				}
				r = 1f;
				g = 1f;
				b = 1f;
				a = num12;
				break;
			}
			case 64:
			case 65:
			case 66:
			case 67:
			case 84:
			case 85:
			case 86:
			case 87:
			{
				float num21 = (float)(int)man.blendData[179] / 31f;
				float num22 = (float)(int)man.blendData[180] / 31f;
				float num23 = (float)(int)man.blendData[181] / 31f;
				float num24 = num21;
				if (num24 < num22)
				{
					num24 = num22;
				}
				if (num24 < num23)
				{
					num24 = num23;
				}
				r = 1f;
				g = 1f;
				b = 1f;
				a = num24;
				break;
			}
			case 72:
			case 73:
			case 74:
			case 75:
			case 88:
			case 89:
			case 90:
			case 91:
			{
				float num13 = (float)(int)man.blendData[182] / 31f;
				float num14 = (float)(int)man.blendData[183] / 31f;
				float num15 = (float)(int)man.blendData[184] / 31f;
				float num16 = num13;
				if (num16 < num14)
				{
					num16 = num14;
				}
				if (num16 < num15)
				{
					num16 = num15;
				}
				r = 1f;
				g = 1f;
				b = 1f;
				a = num16;
				break;
			}
			case 68:
			case 69:
			case 70:
			case 71:
			case 92:
			case 93:
			case 94:
			case 95:
			{
				float num = (float)(int)man.blendData[185] / 31f;
				float num2 = (float)(int)man.blendData[186] / 31f;
				float num3 = (float)(int)man.blendData[187] / 31f;
				float num4 = num;
				if (num4 < num2)
				{
					num4 = num2;
				}
				if (num4 < num3)
				{
					num4 = num3;
				}
				r = 1f;
				g = 1f;
				b = 1f;
				a = num4;
				break;
			}
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
