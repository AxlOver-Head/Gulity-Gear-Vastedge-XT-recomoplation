using System.Collections;
using UnityEngine;

public class SoundCRI : MonoBehaviour
{
	private AudioSource audioSource;

	public float m_Volume = 1f;

	public float m_Pitch = 1f;

	public int m_PlayID = -1;

	public bool m_Pause;

	public static float masterVolume = 1f;

	// Dictionary to cache loaded audio clips
	private static System.Collections.Generic.Dictionary<int, AudioClip> audioClipCache = 
		new System.Collections.Generic.Dictionary<int, AudioClip>();

	public AudioSource getPlayer()
	{
		return audioSource;
	}

	public static bool isBindOK()
	{
		// AudioSource doesn't need CriFsBinder - always ready
		return true;
	}

	public static void UnregisterAcf()
	{
		// No cleanup needed with AudioSource
		ClearAudioCache();
	}

	public static void create()
	{
		// No CriFsBinder needed - AudioSource handles loading
	}

	public static void create2()
	{
		// No longer needed - AudioSource loads audio directly
	}

	private void Awake()
	{
		Object.DontDestroyOnLoad(base.gameObject);
	}

	public void init()
	{
		if (audioSource == null)
		{
			audioSource = base.gameObject.AddComponent<AudioSource>();
			audioSource.playOnAwake = false;
			audioSource.loop = false;
			audioSource.volume = m_Volume;
			audioSource.pitch = m_Pitch;
		}
	}

	public void terminate()
	{
		stop();
	}

	private void OnDestroy()
	{
		stop();
		if (audioSource != null)
		{
			Destroy(audioSource);
			audioSource = null;
		}
	}

	private void Update()
	{
		if (audioSource != null)
		{
			if (isPlayEnd())
			{
				stop();
			}
			updateVolume();
		}
	}

	/// <summary>
	/// Loads an audio clip from Resources folder. Supports .mp3, .ogg, .wav formats
	/// </summary>
	private AudioClip LoadAudioClip(string fileName)
	{
		// Check cache first
		if (audioClipCache.TryGetValue(m_PlayID, out AudioClip cachedClip))
		{
			return cachedClip;
		}

		// Remove extension and load from Resources
		string resourcePath = fileName.Replace(".mp3", "").Replace(".wav", "").Replace(".ogg", "");
		AudioClip clip = Resources.Load<AudioClip>(resourcePath);
		
		if (clip != null)
		{
			audioClipCache[m_PlayID] = clip;
		}
		else
		{
			Debug.LogError($"Failed to load audio clip: {resourcePath}");
		}
		
		return clip;
	}

	public void play(int _id, bool _stop)
	{
		stop();
		
		if (audioSource == null)
		{
			Debug.LogError("AudioSource not initialized. Call init() first.");
			return;
		}

		m_PlayID = _id;

		// Get the sound file name from your resource list
		string soundFileName = MainResourceSound.CueNameList[_id] + ".mp3"; // or .wav, .ogg
		AudioClip clip = LoadAudioClip(soundFileName);

		if (clip != null)
		{
			audioSource.clip = clip;
			audioSource.volume = m_Volume * masterVolume;
			audioSource.pitch = m_Pitch;
			audioSource.Play();
		}
		else
		{
			Debug.LogWarning($"Could not play sound ID: {_id}");
		}
	}

	public void setVolume(float vol)
	{
		if (vol > 1f)
		{
			vol = 1f;
		}
		if (vol < 0f)
		{
			vol = 0f;
		}
		m_Volume = vol;
		updateVolume();
	}

	public void updateVolume()
	{
		if (audioSource != null)
		{
			float volume = m_Volume * masterVolume;
			audioSource.volume = volume;
		}
	}

	public void setPitch(float pitch)
	{
		m_Pitch = pitch;
		if (audioSource != null)
		{
			audioSource.pitch = pitch;
		}
	}

	public bool isPlaying()
	{
		if (audioSource == null)
			return false;
		return audioSource.isPlaying;
	}

	public bool isPlayEnd()
	{
		if (audioSource == null)
			return true;
		return !audioSource.isPlaying && m_PlayID != -1;
	}

	public bool isStop()
	{
		if (audioSource == null)
			return true;
		return !audioSource.isPlaying;
	}

	public bool isError()
	{
		// AudioSource doesn't have error states
		return false;
	}

	public bool isPaused()
	{
		if (audioSource == null)
			return false;
		
		return !audioSource.isPlaying && m_Pause && audioSource.clip != null;
	}

	public void susres_pause()
	{
		if (audioSource != null)
		{
			audioSource.Pause();
		}
	}

	public void susres_resume()
	{
		if (!m_Pause && audioSource != null)
		{
			audioSource.UnPause();
		}
	}

	public void pause()
	{
		m_Pause = true;
		if (audioSource != null)
		{
			audioSource.Pause();
		}
	}

	public void resume()
	{
		m_Pause = false;
		if (audioSource != null)
		{
			audioSource.UnPause();
		}
	}

	public void stop()
	{
		if (audioSource != null && isPlaying())
		{
			audioSource.Stop();
			m_Volume = 1f;
			m_Pitch = 1f;
			m_PlayID = -1;
			m_Pause = false;
		}
	}

	/// <summary>
	/// Clears the audio clip cache to free memory
	/// </summary>
	public static void ClearAudioCache()
	{
		audioClipCache.Clear();
	}
}