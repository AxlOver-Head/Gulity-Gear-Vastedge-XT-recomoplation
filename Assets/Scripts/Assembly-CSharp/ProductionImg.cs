using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProductionImg : MonoBehaviour
{
	public const int IMAGE_MAX = 8;

	private EkisyoImg[] images = new EkisyoImg[8];

	public static List<int> m_PrepareList = new List<int>
	{
		Capacity = 8
	};

	private void Start()
	{
	}

	public void Dispose(bool _flag)
	{
		if (images == null)
		{
			return;
		}
		for (int i = 0; i < 8; i++)
		{
			if (!(images[i] == null))
			{
				images[i].terminate();
				if (_flag)
				{
					Object.Destroy(images[i].gameObject);
					images[i] = null;
				}
			}
		}
	}

	public void init()
	{
		EkisyoImg.create();
		ClearImage();
		m_PrepareList.Clear();
	}

	private void Update()
	{
	}

	public int find(int _id)
	{
		for (int i = 0; i < 8; i++)
		{
			if (images[i].m_ImageID == _id)
			{
				return i;
			}
		}
		return -1;
	}

	public void ClearImage()
	{
		for (int i = 0; i < 8; i++)
		{
			GameObject gameObject = (GameObject)Object.Instantiate(Resources.Load("prefabs/EkisyoImg"), Vector3.zero, Quaternion.identity);
			EkisyoImg ekisyoImg = (EkisyoImg)gameObject.GetComponent("EkisyoImg");
			ekisyoImg.init();
			images[i] = ekisyoImg;
		}
	}

	public int MakeImage(int _playID, float _layer)
	{
		int num = -1;
		for (int i = 0; i < 8; i++)
		{
			if (!images[i].m_Active)
			{
				num = i;
				break;
			}
		}
		if (num < 0)
		{
			return -1;
		}
		images[num].prepare(_playID);
		SetLayer(num, _layer);
		images[num].m_ProdID = num;
		return num;
	}

	public void SetAdditive(int _id, bool _additive)
	{
		if (_id >= 0 && _id < 8)
		{
			images[_id].setAdditive(_additive);
			images[_id].updateColor();
		}
	}

	public void SetTrim(int _id, bool _trim)
	{
		if (_id >= 0 && _id < 8)
		{
			images[_id].setTrim(_trim);
		}
	}

	public void SetXY(int _id, float _x, float _y)
	{
		if (_id >= 0 && _id < 8)
		{
			images[_id].setXY(_x, _y);
			images[_id].updatePosition();
		}
	}

	public void SetScale(int _id, float _x, float _y)
	{
		if (_id >= 0 && _id < 8)
		{
			images[_id].setScale(_x, _y);
			images[_id].updateScale();
			images[_id].updatePosition();
		}
	}

	public void SetColor(int _id, int _a, int _r, int _g, int _b)
	{
		if (_id >= 0 && _id < 8)
		{
			images[_id].setColor(_a, _r, _g, _b);
			images[_id].updateColor();
		}
	}

	public void SetLayer(int _id, float _layer)
	{
		if (_id >= 0 && _id < 8)
		{
			images[_id].setLayer(_layer);
		}
	}

	public void PlayImage(int _id)
	{
		if (_id < 0 || _id >= 8)
		{
			return;
		}
		images[_id].play();
		for (int i = 0; i < 8; i++)
		{
			if (i != _id && images[i].m_Active && images[_id].m_Z == images[i].m_Z)
			{
				Kill(i);
			}
		}
	}

	private IEnumerator coPlayAll()
	{
		bool flag = true;
		do
		{
			if (!flag)
			{
				yield return null;
			}
			flag = Production.m_PrepareList.Count == 0;
		}
		while (!flag);
		foreach (int it in m_PrepareList)
		{
			images[it].setVisible(true);
			images[it].forceSetVisible(false);
		}
		m_PrepareList.Clear();
	}

	public void PlayAll(List<int> list)
	{
		foreach (int item in list)
		{
			m_PrepareList.Add(item);
		}
		StartCoroutine("coPlayAll");
	}

	public bool IsPlaying(int _id)
	{
		if (_id < 0 || _id >= 8)
		{
			return false;
		}
		return images[_id].isPlaying();
	}

	public bool IsStop(int _id)
	{
		if (_id < 0 || _id >= 8)
		{
			return false;
		}
		return images[_id].isStop();
	}

	public void Kill(int _id)
	{
		if (_id >= 0 && _id < 8)
		{
			images[_id].kill();
		}
	}

	public void Kill()
	{
		for (int i = 0; i < 8; i++)
		{
			Kill(i);
		}
	}

	public void Kill_PlayID(int _id)
	{
		for (int i = 0; i < 8; i++)
		{
			if (images[i].m_ImageID == _id)
			{
				Kill(i);
			}
		}
	}

	public void SetVisible(int _id, bool _flag)
	{
		if (_id >= 0 && _id < 8)
		{
			images[_id].setVisible(_flag);
		}
	}

	public void SetVisible(bool _flag)
	{
		for (int i = 0; i < 8; i++)
		{
			SetVisible(i, _flag);
		}
	}

	public void forceSetVisibleOn()
	{
		for (int i = 0; i < 8; i++)
		{
			if (images[i].m_Active && images[i].m_Visible)
			{
				images[i].forceSetVisible(true);
			}
		}
	}

	public void forceSetVisibleOff()
	{
		for (int i = 0; i < 8; i++)
		{
			images[i].forceSetVisible(false);
		}
	}

	public float GetX(int _id)
	{
		if (_id < 0 || _id >= 8)
		{
			return 0f;
		}
		return images[_id].m_X;
	}

	public float GetY(int _id)
	{
		if (_id < 0 || _id >= 8)
		{
			return 0f;
		}
		return images[_id].m_Y;
	}

	public float GetZ(int _id)
	{
		if (_id < 0 || _id >= 8)
		{
			return 0f;
		}
		return images[_id].m_Z;
	}

	public int findLayer(float layer)
	{
		for (int i = 0; i < 8; i++)
		{
			if (layer == images[i].m_Z)
			{
				return i;
			}
		}
		return -1;
	}

	public bool isDrawNothing()
	{
		for (int i = 0; i < 8; i++)
		{
			if (images[i].GetComponent<Renderer>().enabled)
			{
				return false;
			}
		}
		return true;
	}

	public Texture getLoadTexture(int _id)
	{
		for (int i = 0; i < 8; i++)
		{
			if (images[i].m_Active && images[i].m_ImageID == _id)
			{
				return images[i].m_Material.mainTexture;
			}
		}
		return EkisyoImg.load(_id);
	}

	public bool getUnloadTexture(int _id)
	{
		for (int i = 0; i < 8; i++)
		{
			if (images[i].m_Active && i != _id && images[i].m_ImageID == images[_id].m_ImageID)
			{
				return false;
			}
		}
		return true;
	}
}
