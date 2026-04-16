using UnityEngine;

public class SceneUpdater : MonoBehaviour
{
	protected int m_Cnt;

	protected static Production prod;

	protected static ProductionAnime prodAnime;

	protected static Sound sound;

	protected bool m_IsOK;

	public bool isOK()
	{
		return m_IsOK;
	}

	public static void setProd(Production _prod)
	{
		prod = _prod;
	}

	public static void setProdAnime(ProductionAnime _prodAnime)
	{
		prodAnime = _prodAnime;
	}

	public static void setSound(Sound _sound)
	{
		sound = _sound;
	}

	public virtual void init()
	{
	}

	public virtual void control()
	{
		m_Cnt++;
	}

	public virtual void controlReel()
	{
	}

	public virtual void controlFrame()
	{
	}

	public virtual void keyEvent()
	{
	}

	public virtual void OnBrowseEvent_Start()
	{
	}

	public virtual void OnBrowseEvent_Close()
	{
	}
}
