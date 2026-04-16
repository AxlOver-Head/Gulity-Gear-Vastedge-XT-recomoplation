using UnityEngine;

public class EkisyoImg : MonoBehaviour
{
	private const int IMAGE_W = 256;

	private const int IMAGE_H = 144;

	private const float BASE_SCALE_X = 1.5f;

	private const float BASE_SCALE_Y = 2.675f;

	private const float BASE_X = 0f;

	private const float BASE_Y = 0f;

	public Material m_Material;

	public int m_ImageID = -1;

	public int m_ProdID;

	public bool m_Active;

	public bool m_Trim;

	public bool m_Additive;

	public float m_X;

	public float m_Y;

	public float m_Z;

	private float m_W = 1f;

	private float m_H = 1f;

	public float m_ScaleX = 1f;

	public float m_ScaleY = 1f;

	public int m_ColorA = 255;

	public int m_ColorR = 255;

	public int m_ColorG = 255;

	public int m_ColorB = 255;

	public bool m_Visible;

	private void OnEnable()
	{
	}

	private void Awake()
	{
		m_ImageID = -1;
		m_Material = base.GetComponent<Renderer>().material;
		Object.DontDestroyOnLoad(base.gameObject);
		base.GetComponent<Renderer>().enabled = false;
	}

	public static void create()
	{
	}

	public void init()
	{
	}

	private void Update()
	{
		if (m_Active)
		{
		}
	}

	public void prepare(int kind)
	{
		kill();
		m_ImageID = kind;
		m_Material.mainTexture = SGLG.prodImg.getLoadTexture(m_ImageID);
	}

	public void setTrim(bool flag)
	{
		m_Trim = flag;
	}

	public void setAdditive(bool _additive)
	{
		m_Additive = _additive;
		if (m_Additive)
		{
			m_Material.shader = Shader.Find("Mobile/Particles/Additive");
		}
		else
		{
			m_Material.shader = Shader.Find("Mobile/Particles/Alpha Blended");
		}
	}

	public void setXY(float _x, float _y)
	{
		m_X = _x;
		m_Y = _y;
	}

	public void setLayer(float _layer)
	{
		m_Z = _layer;
	}

	public void setScale(float _x, float _y)
	{
		m_ScaleX = _x;
		m_ScaleY = _y;
	}

	public void setColor(int _a, int _r, int _g, int _b)
	{
		m_ColorA = _a;
		m_ColorR = _r;
		m_ColorG = _g;
		m_ColorB = _b;
		if (m_ColorA < 0)
		{
			m_ColorA = 0;
		}
		if (m_ColorA > 255)
		{
			m_ColorA = 255;
		}
		if (m_ColorR < 0)
		{
			m_ColorR = 0;
		}
		if (m_ColorR > 255)
		{
			m_ColorR = 255;
		}
		if (m_ColorG < 0)
		{
			m_ColorG = 0;
		}
		if (m_ColorG > 255)
		{
			m_ColorG = 255;
		}
		if (m_ColorB < 0)
		{
			m_ColorB = 0;
		}
		if (m_ColorB > 255)
		{
			m_ColorB = 255;
		}
	}

	public void updatePosition()
	{
		float num = 0.7525f;
		float num2 = m_W * 1.5f;
		float num3 = m_H * 2.675f;
		float num4 = 0f - num + m_X / 256f * 1.5f;
		float num5 = 0f - num + m_Y / 256f * 2.675f;
		if (!m_Trim)
		{
			num4 += num + (num2 * m_ScaleX - num2) / 2f;
			num5 += num + (num3 * m_ScaleY - num3) / 2f;
		}
		num5 = 0f - num5;
		base.gameObject.transform.position = new Vector3(num4, num5, m_Z);
		base.gameObject.transform.rotation = Quaternion.Euler(0f, 0f, 180f);
	}

	public void updateScale()
	{
		m_W = 1f * (float)MainResourceImage.sizeList[m_ImageID, 0] / 256f;
		m_H = 0.5625f * (float)MainResourceImage.sizeList[m_ImageID, 1] / 144f;
		base.gameObject.transform.localScale = new Vector3(m_W * m_ScaleX * 1.5f, m_H * m_ScaleY * 2.675f, 0f);
	}

	public void updateColor()
	{
		float a = (float)m_ColorA / 255f / 2f;
		float r = (float)m_ColorR / 255f / 2f;
		float g = (float)m_ColorG / 255f / 2f;
		float b = (float)m_ColorB / 255f / 2f;
		Color color = new Color(r, g, b, a);
		m_Material.SetColor("_TintColor", color);
	}

	public bool isPlaying()
	{
		return m_Active;
	}

	public bool isStop()
	{
		return !m_Active;
	}

	public void play()
	{
		updateScale();
		updatePosition();
		updateColor();
		m_Active = true;
		base.GetComponent<Renderer>().enabled = false;
	}

	private void initParam()
	{
		m_Active = false;
		m_ImageID = -1;
		m_Trim = false;
		m_Additive = false;
		m_X = 0f;
		m_Y = 0f;
		m_Z = 0f;
		m_W = 1f;
		m_H = 1f;
		m_ColorA = 255;
		m_ColorR = 255;
		m_ColorG = 255;
		m_ColorB = 255;
		m_ScaleX = 1f;
		m_ScaleY = 1f;
		if (m_Material != null)
		{
			m_Material.mainTexture = null;
		}
	}

	public void kill()
	{
		if (m_Active && SGLG.prodImg.getUnloadTexture(m_ProdID))
		{
			Resources.UnloadAsset(m_Material.mainTexture);
		}
		initParam();
		if (m_Material != null)
		{
			m_Material.mainTexture = null;
		}
		m_Active = false;
		base.GetComponent<Renderer>().enabled = false;
	}

	public void setVisible(bool _flag)
	{
		if (m_Active)
		{
			m_Visible = _flag;
			base.GetComponent<Renderer>().enabled = _flag;
		}
	}

	public void forceSetVisible(bool _flag)
	{
		base.GetComponent<Renderer>().enabled = _flag;
	}

	public void terminate()
	{
		kill();
		m_Material = null;
	}

	public static Texture load(int _id)
	{
		return Resources.Load("DirectionImages/" + MainResourceImage.fileList[_id]) as Texture;
	}
}
