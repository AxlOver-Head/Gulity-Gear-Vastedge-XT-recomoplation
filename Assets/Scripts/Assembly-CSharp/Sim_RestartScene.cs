using System;
using UnityEngine;

public class Sim_RestartScene : MonoBehaviour
{
	private bool complete;

	private int m_Cnt;

	private void Start()
	{
		SGLG.prod.Kill();
		SGLG.prodImg.Kill();
		SGLG.prodAnime.Kill();
		SGLG.sound.Stop();
		SGLG.DataSaveEndSimulation();
		SGLG.m_Scene = null;
		releaseDontDestroyObjects();
		remakeDontDestroyObjects();
		GC.Collect();
		Resources.UnloadUnusedAssets();
		SGLG.startLoading();
	}

	private void releaseDontDestroyObjects()
	{
		if (SGLG.prod != null)
		{
			SGLG.prod.Dispose(true);
		}
		if (SGLG.prodImg != null)
		{
			SGLG.prodImg.Dispose(true);
		}
		if (SGLG.prodAnime != null)
		{
			SGLG.prodAnime.Dispose(true);
		}
		if (SGLG.sound != null)
		{
			SGLG.sound.Dispose(true);
		}
	}

	private void remakeDontDestroyObjects()
	{
		SGLG.prod.init();
		SGLG.prodImg.init();
		SGLG.prodAnime.init();
		SGLG.sound.init();
	}

	private void Update()
	{
		if (!complete && !(SGLG.loading == null))
		{
			if (m_Cnt >= 30 && SGLG.loading.loadStart && SGLG.isReady())
			{
				SGLG.sound.init2();
				SGLG.m_Mode = SGLG.MODE.MAIN;
				complete = true;
			}
			m_Cnt++;
		}
	}
}
