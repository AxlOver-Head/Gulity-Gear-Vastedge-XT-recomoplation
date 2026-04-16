using UnityEngine;

public class NumberFont : MonoBehaviour
{
	public enum FONT_POS
	{
		Left = 0,
		Center = 1,
		Right = 2
	}

	public enum TIME
	{
		MS = 0,
		SEC = 1,
		MIN = 2
	}

	public int Value;

	public GameObject[] FontObject = new GameObject[1];

	public bool isMinus;

	public GameObject SubObjectLeft;

	public float SubObjectLeftPitch;

	public GameObject SubObjectRight;

	public float SubObjectRightPitch;

	public bool AutoPosition = true;

	public Transform FontOrigin;

	public FONT_POS FontPosition;

	public float Pitch;

	public bool DisplayZero = true;

	public bool AlwaysUpdate;

	public GameObject OjbectComma;

	public float SubObjectCommaPitch;

	public bool IsTime;

	public GameObject ObjectDecimal;

	public float ObjectDecimalPitch;

	public int decimalDigit;

	public GameObject ObjectBackground;

	private GameObject[] ObjectBackgroundArry;

	[HideInInspector]
	public GameObject[] OjbectsComma;

	[HideInInspector]
	public bool IsDecimal;

	[HideInInspector]
	public int decimalPoint;

	[HideInInspector]
	public int backKeta;

	[HideInInspector]
	public bool IsOneLess;

	[HideInInspector]
	public bool IsInitEnd;

	private int CommaInterval = 3;

	private int BackValue = -1;

	private string[] maxCount = new string[10] { "9", "99", "999", "9999", "99999", "999999", "9999999", "99999999", "999999999", "2147483647" };

	private void Awake()
	{
		if (IsInitEnd)
		{
			return;
		}
		if (FontObject[0] != null)
		{
			for (int i = 1; i < FontObject.Length; i++)
			{
				if (FontObject[i] == null || FontObject[i] == FontObject[0])
				{
					FontObject[i] = Object.Instantiate(FontObject[0]) as GameObject;
					FontObject[i].transform.parent = FontObject[0].transform.parent;
					FontObject[i].transform.localScale = FontObject[0].transform.localScale;
					FontObject[i].transform.localRotation = FontObject[0].transform.localRotation;
					FontObject[i].transform.localPosition = FontObject[0].transform.localPosition;
				}
			}
		}
		if (OjbectComma != null)
		{
			CommaInterval = (IsTime ? 2 : 3);
			int num = (FontObject.Length - 1) / CommaInterval;
			OjbectsComma = new GameObject[num];
			OjbectsComma[0] = OjbectComma;
			for (int j = 1; j < num; j++)
			{
				OjbectsComma[j] = Object.Instantiate(OjbectsComma[0]) as GameObject;
				OjbectsComma[j].transform.parent = OjbectsComma[0].transform.parent;
				OjbectsComma[j].transform.localScale = OjbectsComma[0].transform.localScale;
				OjbectsComma[j].transform.localRotation = OjbectsComma[0].transform.localRotation;
				OjbectsComma[j].transform.localPosition = OjbectsComma[0].transform.localPosition;
			}
		}
		if (FontObject[0] != null)
		{
			backKeta = Value.ToString().Length;
			BackValue = Value;
			NumberDisp(FontObject, (uint)Value);
			if (AutoPosition)
			{
				SetFontPositon();
			}
		}
		IsInitEnd = true;
	}

	private void Update()
	{
		if (FontObject[0] != null && (Value != BackValue || AlwaysUpdate))
		{
			NumberDisp(FontObject, (uint)Value);
			BackValue = Value;
			if (AutoPosition)
			{
				SetFontPositon();
			}
		}
	}

	private void OnEnable()
	{
		if (FontObject[0] != null)
		{
			NumberDisp(FontObject, (uint)Value);
			if (AutoPosition)
			{
				SetFontPositon();
			}
		}
	}

	public void SetValue(int setValue)
	{
		if (isMinus && setValue >= 0)
		{
			if (SubObjectLeft != null && SubObjectLeft.activeInHierarchy)
			{
				SubObjectLeft.SetActive(false);
			}
		}
		else if (isMinus && setValue < 0)
		{
			setValue *= -1;
		}
		if (Value != setValue)
		{
			string text = Value.ToString();
			string text2 = setValue.ToString();
			Value = setValue;
			NumberDisp(FontObject, (uint)Value);
			if (AutoPosition && text.Length != text2.Length)
			{
				SetFontPositon();
			}
		}
	}

	private void NumberDisp(GameObject[] obj, uint num)
	{
		int num2 = obj.Length;
		int length = num.ToString().Length;
		if (!DisplayZero)
		{
			num2 = ((length >= num2) ? num2 : length);
			for (int i = 0; i < obj.Length; i++)
			{
				if (obj[i] != null)
				{
					bool active = ((i < num2) ? true : false);
					obj[i].SetActive(active);
				}
				else
				{
					MonoBehaviour.print("Called Null object.");
				}
			}
		}
		else
		{
			for (int j = 0; j < obj.Length; j++)
			{
				if (obj[j] != null)
				{
					obj[j].SetActive(true);
				}
				else
				{
					MonoBehaviour.print("Called Null object.");
				}
			}
		}
		if (num2 > 10)
		{
			return;
		}
		string text = string.Empty + num;
		int num3 = text.Length;
		if (num2 < num3)
		{
			text = maxCount[num2];
			num3 = num2;
		}
		for (int k = 0; k < num2; k++)
		{
			UISprite component = obj[k].GetComponent<UISprite>();
			if (!(component != null))
			{
				continue;
			}
			int length2 = component.spriteName.Length;
			string text2 = component.spriteName.Substring(0, length2 - 1);
			if (k < num3)
			{
				int num4 = int.Parse(text.Substring(num3 - k - 1, 1));
				if (k == num2 - 1 && IsOneLess)
				{
					num4 = 0;
				}
				component.spriteName = text2 + num4;
			}
			else
			{
				component.spriteName = text2 + "0";
			}
			if (backKeta < num2)
			{
				component.Update();
			}
		}
		backKeta = num2;
	}

	private void SetFontPositon()
	{
		Vector3 position = ((!(FontOrigin != null)) ? base.gameObject.transform.parent.position : FontOrigin.position);
		position = FontObject[0].transform.InverseTransformPoint(position);
		Vector3 localPosition = position;
		float pitch = Pitch;
		float x = FontObject[0].transform.localScale.x;
		float subObjectLeftPitch = SubObjectLeftPitch;
		float num = ((!(SubObjectLeft != null)) ? 0f : SubObjectLeft.transform.localScale.x);
		float subObjectRightPitch = SubObjectRightPitch;
		float num2 = ((!(SubObjectRight != null)) ? 0f : SubObjectRight.transform.localScale.x);
		float subObjectCommaPitch = SubObjectCommaPitch;
		float num3 = ((!(OjbectComma != null)) ? 0f : OjbectsComma[0].transform.localScale.x);
		int num4 = 0;
		int num5 = 0;
		float objectDecimalPitch = ObjectDecimalPitch;
		float num6 = ((!(ObjectDecimal != null)) ? 0f : ObjectDecimal.transform.localScale.x);
		for (int i = 0; i < FontObject.Length; i++)
		{
			if (FontObject[i] != null && FontObject[i].activeInHierarchy)
			{
				num5++;
			}
		}
		if (OjbectComma != null)
		{
			num4 = ((!IsDecimal) ? ((num5 - 1) / CommaInterval) : ((0 < num5 - (num5 - decimalPoint)) ? ((num5 - (num5 - decimalPoint) - 1) / CommaInterval) : 0));
			for (int j = 0; j < OjbectsComma.Length; j++)
			{
				if (j < num4)
				{
					OjbectsComma[j].SetActive(true);
				}
				else
				{
					OjbectsComma[j].SetActive(false);
				}
				UISprite component = OjbectsComma[j].GetComponent<UISprite>();
				if (component != null)
				{
					component.Update();
				}
			}
		}
		if (ObjectDecimal != null)
		{
			if (IsDecimal)
			{
				ObjectDecimal.SetActive(true);
			}
			else
			{
				ObjectDecimal.SetActive(false);
			}
			UISprite component2 = ObjectDecimal.GetComponent<UISprite>();
			if (component2 != null)
			{
				component2.Update();
			}
		}
		int num7 = 0;
		if (SubObjectLeft != null)
		{
			num7++;
		}
		if (SubObjectRight != null)
		{
			num7++;
		}
		if (IsDecimal)
		{
			num7++;
		}
		int num8 = num5 + num4 + num7;
		GameObject[] array = new GameObject[num8];
		float[] array2 = new float[num8];
		float[] array3 = new float[num8];
		float num9 = 0f;
		int num10 = 0;
		if (SubObjectLeft != null)
		{
			array[num10] = SubObjectLeft;
			array2[num10] = subObjectLeftPitch;
			array3[num10] = num;
			num9 += array3[num10] - array2[num10];
			num10++;
		}
		int num11 = 0;
		int num12 = 0;
		for (int k = 0; k < FontObject.Length; k++)
		{
			if (!(FontObject[k] != null) || !FontObject[k].activeInHierarchy)
			{
				continue;
			}
			int num13 = num8 - num10 - 1;
			num13 = ((!(SubObjectLeft != null)) ? num13 : (num13 + 1));
			num13 = ((!(SubObjectRight != null)) ? num13 : (num13 - 1));
			array[num13] = FontObject[k];
			array2[num13] = pitch;
			array3[num13] = x;
			num9 += array3[num13] - array2[num13];
			num10++;
			if (OjbectComma != null)
			{
				bool flag = false;
				if (IsDecimal)
				{
					int num14 = num11 - (num5 - decimalPoint);
					if (num11 + 1 != num5 && 0 < num14 && num14 % CommaInterval == CommaInterval - 1)
					{
						flag = true;
					}
				}
				else if (num11 + 1 != num5 && num11 % CommaInterval == CommaInterval - 1)
				{
					flag = true;
				}
				if (flag)
				{
					int num15 = num13 - 1;
					array[num15] = OjbectsComma[num12];
					array2[num15] = subObjectCommaPitch;
					array3[num15] = num3;
					num9 += array3[num15] - array2[num15];
					num10++;
					num12++;
				}
			}
			if (IsDecimal && num11 == num5 - decimalPoint - 1)
			{
				int num16 = num13 - 1;
				array[num16] = ObjectDecimal;
				array2[num16] = objectDecimalPitch;
				array3[num16] = num6;
				num9 += array3[num16] - array2[num16];
				num10++;
			}
			num11++;
		}
		if (SubObjectRight != null)
		{
			array[num10] = SubObjectRight;
			array2[num10] = subObjectRightPitch;
			array3[num10] = num2;
			num9 += array3[num10] - array2[num10];
			num10++;
		}
		float num17 = 0f;
		float num18 = 0f;
		switch (FontPosition)
		{
		case FONT_POS.Left:
			num17 = ((!(SubObjectLeft == null)) ? num : x);
			position.x += num17 / 2f;
			break;
		case FONT_POS.Center:
			num18 = (array3[0] - array2[0] - num9) / 2f;
			break;
		case FONT_POS.Right:
			num17 = ((!(SubObjectRight == null)) ? num2 : x);
			position.x -= num17 / 2f;
			break;
		}
		for (int l = 0; l < array.Length; l++)
		{
			switch (FontPosition)
			{
			case FONT_POS.Left:
			case FONT_POS.Center:
				localPosition = array[l].transform.localPosition;
				localPosition.x = position.x + num18;
				array[l].transform.localPosition = localPosition;
				if (l < array.Length - 1)
				{
					num18 += (array3[l] - array2[l] + array3[l + 1] - array2[l + 1]) / 2f;
				}
				break;
			case FONT_POS.Right:
			{
				int num19 = array.Length - l - 1;
				localPosition = array[l].transform.localPosition;
				localPosition = array[num19].transform.localPosition;
				localPosition.x = position.x + num18;
				array[num19].transform.localPosition = localPosition;
				if (0 < num19)
				{
					num18 -= (array3[num19] - array2[num19] + array3[num19 - 1] - array2[num19 - 1]) / 2f;
				}
				break;
			}
			}
		}
		if (!(FontObject[0] != null) || !(ObjectBackground != null))
		{
			return;
		}
		if (ObjectBackgroundArry != null)
		{
			for (int m = 0; m < ObjectBackgroundArry.Length; m++)
			{
				Object.Destroy(ObjectBackgroundArry[m]);
			}
			ObjectBackgroundArry = null;
		}
		ObjectBackgroundArry = new GameObject[FontObject.Length];
		ObjectBackground.transform.localScale = FontObject[0].transform.localScale;
		ObjectBackground.transform.localRotation = FontObject[0].transform.localRotation;
		ObjectBackground.transform.localPosition = FontObject[0].transform.localPosition;
		for (int n = 0; n < FontObject.Length; n++)
		{
			ObjectBackgroundArry[n] = (GameObject)Object.Instantiate(ObjectBackground);
			ObjectBackgroundArry[n].transform.parent = base.transform;
			ObjectBackgroundArry[n].transform.localScale = FontObject[0].transform.localScale;
			ObjectBackgroundArry[n].transform.localRotation = FontObject[0].transform.localRotation;
			ObjectBackgroundArry[n].transform.localPosition = FontObject[0].transform.localPosition;
			ObjectBackgroundArry[n].name = "BG" + n;
		}
		num18 = 0f;
		for (int num20 = 0; num20 < ObjectBackgroundArry.Length; num20++)
		{
			switch (FontPosition)
			{
			case FONT_POS.Left:
			case FONT_POS.Center:
				localPosition = ObjectBackgroundArry[num20].transform.localPosition;
				localPosition.x = position.x + num18;
				ObjectBackgroundArry[num20].transform.localPosition = localPosition;
				if (num20 < ObjectBackgroundArry.Length - 1)
				{
					num18 += (x - Pitch + x - Pitch) / 2f;
				}
				break;
			case FONT_POS.Right:
			{
				int num21 = ObjectBackgroundArry.Length - num20 - 1;
				if (ObjectBackgroundArry[num21] != null)
				{
					localPosition = ObjectBackgroundArry[num21].transform.localPosition;
				}
				localPosition.x = position.x + num18;
				if (ObjectBackgroundArry[num21] != null)
				{
					ObjectBackgroundArry[num21].transform.localPosition = localPosition;
				}
				if (0 < num21)
				{
					num18 -= (x - Pitch + x - Pitch) / 2f;
				}
				break;
			}
			}
		}
	}

	public void SetTimeValue(float nowTime, TIME TimeNum = TIME.MS)
	{
		int num = (int)Mathf.Floor(nowTime);
		int num2 = num / 3600;
		int num3 = (num - num2 * 3600) / 60;
		int num4 = num - num2 * 3600 - num3 * 60;
		string text = string.Empty + (int)Mathf.Floor(nowTime * 100f);
		if (text.Length > 1)
		{
			string text2 = text.Substring(text.Length - 2, 2);
			string text3 = ((num4 >= 10) ? (string.Empty + num4) : ("0" + num4));
			string text4 = ((num3 >= 10) ? (string.Empty + num3) : ("0" + num3));
			string text5 = ((num2 >= 10) ? (string.Empty + num2) : ("0" + num2));
			string s = text5 + text4 + text3 + text2;
			switch (TimeNum)
			{
			case TIME.MS:
				s = text5 + text4 + text3 + text2;
				break;
			case TIME.SEC:
				s = text5 + text4 + text3;
				break;
			case TIME.MIN:
				s = text5 + text4;
				break;
			}
			int.TryParse(s, out Value);
		}
		else
		{
			Value = 0;
		}
	}

	public void SetDecimalValue(float fValue)
	{
		IsDecimal = false;
		IsOneLess = false;
		if (ObjectDecimal != null)
		{
			string text = fValue.ToString();
			if (0 < text.Length)
			{
				string text2 = string.Empty;
				int num = 0;
				for (int i = 0; i < text.Length; i++)
				{
					string text3 = text.Substring(i, 1);
					if (i == 0)
					{
						if (1 < text.Length && text3 == "0")
						{
							IsOneLess = true;
							text2 += "1";
						}
						else
						{
							text2 += text3;
						}
						continue;
					}
					if (IsDecimal)
					{
						if (decimalDigit == num)
						{
							if (IsOneLess)
							{
								int result = 0;
								string s = text2.Substring(1, text2.Length - 1);
								int.TryParse(s, out result);
								if (result == 0)
								{
									text2 = "0";
									IsDecimal = false;
									IsOneLess = false;
									decimalPoint = 0;
								}
							}
							break;
						}
						num++;
					}
					if (text3 == ".")
					{
						decimalPoint = i;
						IsDecimal = true;
					}
					else
					{
						text2 += text3;
					}
				}
				if (!int.TryParse(text2, out Value))
				{
					IsDecimal = false;
					IsOneLess = false;
					decimalPoint = 0;
				}
			}
			else
			{
				Value = 0;
			}
		}
		else
		{
			Value = (int)fValue;
		}
		if (decimalDigit == 0)
		{
			IsDecimal = false;
			IsOneLess = false;
		}
	}

	public void SetColor(Color col)
	{
		for (int i = 0; i < FontObject.Length; i++)
		{
			if (FontObject[i] != null && FontObject[i].activeInHierarchy)
			{
				UISprite component = FontObject[i].GetComponent<UISprite>();
				component.color = col;
			}
		}
		if (SubObjectLeft != null && SubObjectLeft.activeInHierarchy)
		{
			UISprite component2 = SubObjectLeft.GetComponent<UISprite>();
			component2.color = col;
		}
		if (SubObjectRight != null && SubObjectRight.activeInHierarchy)
		{
			UISprite component3 = SubObjectRight.GetComponent<UISprite>();
			component3.color = col;
		}
		if (ObjectDecimal != null && ObjectDecimal.activeInHierarchy)
		{
			UISprite component4 = ObjectDecimal.GetComponent<UISprite>();
			component4.color = col;
		}
	}
}
