using System.Collections.Generic;

public class DirectionEvent
{
	private List<DirectionCommandBase> commandList = new List<DirectionCommandBase>
	{
		Capacity = 64
	};

	private List<int> prodPrepareList = new List<int>
	{
		Capacity = 64
	};

	private List<int> imagPrepareList = new List<int>
	{
		Capacity = 64
	};

	private List<int> animPrepareList = new List<int>
	{
		Capacity = 64
	};

	public static Production prod = SGLG.prod;

	public static ProductionImg prodImg = SGLG.prodImg;

	public static ProductionAnime prodAnime = SGLG.prodAnime;

	public static Sound sound = SGLG.sound;

	public static YakuManager yaku;

	public static LEDMainManager ledMain;

	public static LEDPanelManager ledPanel;

	public static DirectionLedManager dirLed;

	public static DirectionYakuManager dirYaku;

	public ReelManager reel;

	public bool m_Active;

	private bool m_End;

	private int m_CommandNum;

	private int m_Cnt;

	public int m_Priority;

	public int m_PriorityCnt;

	public DirectionEvent(int priority)
	{
		yaku = MainGameScene.yakuMan;
		ledMain = MainGameScene.ledMainMan;
		ledPanel = MainGameScene.ledPanelMan;
		dirLed = MainGameScene.dirLedMan;
		dirYaku = MainGameScene.dirYakuMan;
		reel = MainGameScene.reelMan;
		m_Priority = priority;
		m_PriorityCnt = 0;
	}

	public void start()
	{
		m_CommandNum = 0;
		m_Active = true;
		m_Cnt = 0;
		DirectionYakuManager.initActive();
	}

	public void end()
	{
		if (commandList.Count > 0)
		{
			foreach (DirectionCommandBase command in commandList)
			{
				command.terminate();
			}
			commandList.Clear();
		}
		prodPrepareList.Clear();
		imagPrepareList.Clear();
		animPrepareList.Clear();
		m_End = true;
	}

	public void control()
	{
		if (!m_Active)
		{
			return;
		}
		if (commandList.Count > 0)
		{
			foreach (DirectionCommandBase command in commandList)
			{
				bool active = command.m_Active;
				command.control(m_Cnt);
				if (active && !command.m_Active)
				{
					if (command.m_Class == DirectionCommandBase.CLASS.PLAYMOVIE)
					{
						DirectionCommandMoviePlay directionCommandMoviePlay = (DirectionCommandMoviePlay)command;
						if (directionCommandMoviePlay.m_ProdID >= 0)
						{
							prodPrepareList.Add(directionCommandMoviePlay.m_ProdID);
						}
					}
					else if (command.m_Class == DirectionCommandBase.CLASS.ADDMOVIE)
					{
						DirectionCommandMovieAdd directionCommandMovieAdd = (DirectionCommandMovieAdd)command;
						if (directionCommandMovieAdd.m_ProdID >= 0)
						{
							prodPrepareList.Add(directionCommandMovieAdd.m_ProdID);
						}
					}
					else if (command.m_Class == DirectionCommandBase.CLASS.ADDMOVIEWITHPOS)
					{
						DirectionCommandMovieAddWithPosition directionCommandMovieAddWithPosition = (DirectionCommandMovieAddWithPosition)command;
						if (directionCommandMovieAddWithPosition.m_ProdID >= 0)
						{
							prodPrepareList.Add(directionCommandMovieAddWithPosition.m_ProdID);
						}
					}
					else if (command.m_Class == DirectionCommandBase.CLASS.ADDMOVIEWITHLAYER)
					{
						DirectionCommandMovieAddWithLayer directionCommandMovieAddWithLayer = (DirectionCommandMovieAddWithLayer)command;
						if (directionCommandMovieAddWithLayer.m_ProdID >= 0)
						{
							prodPrepareList.Add(directionCommandMovieAddWithLayer.m_ProdID);
						}
					}
					else if (command.m_Class == DirectionCommandBase.CLASS.ADDMOVIEWITHLAYERANDPOS)
					{
						DirectionCommandMovieAddWithLayerAndPosition directionCommandMovieAddWithLayerAndPosition = (DirectionCommandMovieAddWithLayerAndPosition)command;
						if (directionCommandMovieAddWithLayerAndPosition.m_ProdID >= 0)
						{
							prodPrepareList.Add(directionCommandMovieAddWithLayerAndPosition.m_ProdID);
						}
					}
					else if (command.m_Class == DirectionCommandBase.CLASS.PLAYIMAGE)
					{
						DirectionCommandImagePlay directionCommandImagePlay = (DirectionCommandImagePlay)command;
						imagPrepareList.Add(directionCommandImagePlay.m_ProdID);
					}
					if (command.m_Class == DirectionCommandBase.CLASS.PLAYANIME)
					{
						DirectionCommandAnimePlay directionCommandAnimePlay = (DirectionCommandAnimePlay)command;
						if (directionCommandAnimePlay.m_ProdID >= 0)
						{
							animPrepareList.Add(directionCommandAnimePlay.m_ProdID);
						}
					}
					else if (command.m_Class == DirectionCommandBase.CLASS.ADDANIME)
					{
						DirectionCommandAnimeAdd directionCommandAnimeAdd = (DirectionCommandAnimeAdd)command;
						if (directionCommandAnimeAdd.m_ProdID >= 0)
						{
							animPrepareList.Add(directionCommandAnimeAdd.m_ProdID);
						}
					}
					else if (command.m_Class == DirectionCommandBase.CLASS.ADDANIMEWITHPOS)
					{
						DirectionCommandAnimeAddWithPosition directionCommandAnimeAddWithPosition = (DirectionCommandAnimeAddWithPosition)command;
						if (directionCommandAnimeAddWithPosition.m_ProdID >= 0)
						{
							animPrepareList.Add(directionCommandAnimeAddWithPosition.m_ProdID);
						}
					}
					else if (command.m_Class == DirectionCommandBase.CLASS.ADDANIMEWITHLAYER)
					{
						DirectionCommandAnimeAddWithLayer directionCommandAnimeAddWithLayer = (DirectionCommandAnimeAddWithLayer)command;
						if (directionCommandAnimeAddWithLayer.m_ProdID >= 0)
						{
							animPrepareList.Add(directionCommandAnimeAddWithLayer.m_ProdID);
						}
					}
					else if (command.m_Class == DirectionCommandBase.CLASS.ADDANIMEWITHLAYERANDPOS)
					{
						DirectionCommandAnimeAddWithLayerAndPosition directionCommandAnimeAddWithLayerAndPosition = (DirectionCommandAnimeAddWithLayerAndPosition)command;
						if (directionCommandAnimeAddWithLayerAndPosition.m_ProdID >= 0)
						{
							animPrepareList.Add(directionCommandAnimeAddWithLayerAndPosition.m_ProdID);
						}
					}
				}
				if (m_End)
				{
					return;
				}
			}
		}
		if (prodPrepareList.Count > 0)
		{
			prod.PlayAll(prodPrepareList);
			prodPrepareList.Clear();
		}
		if (imagPrepareList.Count > 0)
		{
			prodImg.PlayAll(imagPrepareList);
			imagPrepareList.Clear();
		}
		if (animPrepareList.Count > 0)
		{
			prodAnime.PlayAll(animPrepareList);
			animPrepareList.Clear();
		}
		m_Cnt++;
	}

	public void setCommandUnuse(int _id)
	{
		if (_id < commandList.Count && _id >= 0)
		{
			commandList[_id].m_UnUse = true;
		}
	}

	public int eventPlayMovie(DirectionManager.MOVIE playID, bool kill, bool loop, bool add, bool trim, int x, int y, int layer, int exe)
	{
		DirectionCommandMoviePlay item = new DirectionCommandMoviePlay(prod, (int)playID, kill, loop, add, trim, x, y, layer, exe, m_Priority + m_PriorityCnt);
		if (m_Priority >= 0)
		{
			m_PriorityCnt++;
		}
		commandList.Add(item);
		return m_CommandNum++;
	}

	public int eventAddMovie(DirectionManager.MOVIE playID, DirectionManager.MOVIE oldID, bool kill, bool loop, bool add, bool trim)
	{
		DirectionCommandMovieAdd item = new DirectionCommandMovieAdd(prod, (int)playID, (int)oldID, kill, loop, add, trim, m_Priority + m_PriorityCnt);
		if (m_Priority >= 0)
		{
			m_PriorityCnt++;
		}
		commandList.Add(item);
		return m_CommandNum++;
	}

	public int eventAddMovieWithPosition(DirectionManager.MOVIE playID, DirectionManager.MOVIE oldID, bool kill, bool loop, bool add, bool trim, int x, int y)
	{
		DirectionCommandMovieAddWithPosition item = new DirectionCommandMovieAddWithPosition(prod, (int)playID, (int)oldID, kill, loop, add, trim, x, y, m_Priority + m_PriorityCnt);
		if (m_Priority >= 0)
		{
			m_PriorityCnt++;
		}
		commandList.Add(item);
		return m_CommandNum++;
	}

	public int eventAddMovieWithLayer(DirectionManager.MOVIE playID, DirectionManager.MOVIE oldID, float layer, bool kill, bool loop, bool add, bool trim)
	{
		DirectionCommandMovieAddWithLayer item = new DirectionCommandMovieAddWithLayer(prod, (int)playID, (int)oldID, layer, kill, loop, add, trim, m_Priority + m_PriorityCnt);
		if (m_Priority >= 0)
		{
			m_PriorityCnt++;
		}
		commandList.Add(item);
		return m_CommandNum++;
	}

	public int eventAddMovieWithLayerAndPosition(DirectionManager.MOVIE playID, DirectionManager.MOVIE oldID, float layer, bool kill, bool loop, bool add, bool trim, int x, int y)
	{
		DirectionCommandMovieAddWithLayerAndPosition item = new DirectionCommandMovieAddWithLayerAndPosition(prod, (int)playID, (int)oldID, layer, kill, loop, add, trim, x, y, m_Priority + m_PriorityCnt);
		if (m_Priority >= 0)
		{
			m_PriorityCnt++;
		}
		commandList.Add(item);
		return m_CommandNum++;
	}

	public int eventPauseMovie(DirectionManager.MOVIE pauseID, int exe)
	{
		DirectionCommandMoviePause item = new DirectionCommandMoviePause(prod, (int)pauseID, exe);
		commandList.Add(item);
		return m_CommandNum++;
	}

	public int eventResumeMovie(DirectionManager.MOVIE pauseID, int exe)
	{
		DirectionCommandMovieResume item = new DirectionCommandMovieResume(prod, (int)pauseID, exe);
		commandList.Add(item);
		return m_CommandNum++;
	}

	public int eventStopMovie(DirectionManager.MOVIE stopID, int exe)
	{
		DirectionCommandMovieStop item = new DirectionCommandMovieStop(prod, (int)stopID, exe);
		commandList.Add(item);
		return m_CommandNum++;
	}

	public int eventStopMovieLayer(float layer, int exe)
	{
		DirectionCommandMovieStopLayer item = new DirectionCommandMovieStopLayer(prod, layer, exe);
		commandList.Add(item);
		return m_CommandNum++;
	}

	public int eventStopMovieAll(int exe)
	{
		DirectionCommandMovieStopAll item = new DirectionCommandMovieStopAll(prod, exe);
		commandList.Add(item);
		return m_CommandNum++;
	}

	public int eventKillMovie(DirectionManager.MOVIE killID, int exe)
	{
		DirectionCommandMovieKill item = new DirectionCommandMovieKill(prod, (int)killID, exe);
		commandList.Add(item);
		return m_CommandNum++;
	}

	public int eventKillMovieLayer(float layer, int exe)
	{
		DirectionCommandMovieKillLayer item = new DirectionCommandMovieKillLayer(prod, layer, exe);
		commandList.Add(item);
		return m_CommandNum++;
	}

	public int eventKillMovieAll(int exe)
	{
		DirectionCommandMovieKillAll item = new DirectionCommandMovieKillAll(prod, exe);
		commandList.Add(item);
		return m_CommandNum++;
	}

	public int eventMovieSlide(float layer, float sx, float sy, float dx, float dy, int frame, int exe)
	{
		DirectionCommandMovieSlide item = new DirectionCommandMovieSlide(prod, layer, sx, sy, dx, dy, frame, exe);
		commandList.Add(item);
		return m_CommandNum++;
	}

	public int eventMovieChangeScale(float layer, float sx, float sy, float dx, float dy, int frame, int exe)
	{
		DirectionCommandMovieChangeScale item = new DirectionCommandMovieChangeScale(prod, layer, sx, sy, dx, dy, frame, exe);
		commandList.Add(item);
		return m_CommandNum++;
	}

	public int eventMovieLoop(DirectionManager.MOVIE playID, bool loop, int exe)
	{
		DirectionCommandMovieLoop item = new DirectionCommandMovieLoop(prod, (int)playID, loop, exe);
		commandList.Add(item);
		return m_CommandNum++;
	}

	public int eventPlaySound(DirectionManager.SOUND playID, Sound.CH ch, bool stop, float volume, int exe)
	{
		DirectionCommandSoundPlay item = new DirectionCommandSoundPlay(dirLed, sound, (int)playID, ch, stop, volume, exe);
		commandList.Add(item);
		return m_CommandNum++;
	}

	public int eventStopSound(Sound.CH ch, int exe)
	{
		DirectionCommandSoundStop item = new DirectionCommandSoundStop(sound, ch, exe);
		commandList.Add(item);
		return m_CommandNum++;
	}

	public int eventPlaySoundWithMovie(DirectionManager.SOUND playID, DirectionManager.MOVIE movieID, Sound.CH ch, bool stop, float volume, int exe)
	{
		DirectionCommandSoundPlayWithMovie item = new DirectionCommandSoundPlayWithMovie(dirLed, prod, sound, (int)playID, (int)movieID, ch, stop, volume, exe);
		commandList.Add(item);
		return m_CommandNum++;
	}

	public int eventStopSoundWithMovie(DirectionManager.MOVIE movieID, Sound.CH ch, int exe)
	{
		DirectionCommandSoundStopWithMovie item = new DirectionCommandSoundStopWithMovie(prod, sound, ch, (int)movieID, exe);
		commandList.Add(item);
		return m_CommandNum++;
	}

	public int eventFadeSound(Sound.CH ch, float start, float end, int frame, int exe)
	{
		DirectionCommandSoundFade item = new DirectionCommandSoundFade(sound, ch, start, end, frame, exe);
		commandList.Add(item);
		return m_CommandNum++;
	}

	public int eventStopDirection(DirectionManager mng, DirectionManager.DIR dir, int exe)
	{
		DirectionCommandDirectionStop item = new DirectionCommandDirectionStop(mng, dir, exe);
		commandList.Add(item);
		return m_CommandNum++;
	}

	public int eventDisable(DirectionManager mng, DirectionManager.DIR dir, int exe)
	{
		DirectionCommandDisable item = new DirectionCommandDisable(mng, dir, exe);
		commandList.Add(item);
		return m_CommandNum++;
	}

	public int eventStopDirectionBefore(DirectionManager mng, int exe)
	{
		DirectionCommandDirectionStopBefore item = new DirectionCommandDirectionStopBefore(mng, exe);
		commandList.Add(item);
		return m_CommandNum++;
	}

	public int eventDisableBefore(DirectionManager mng, int exe)
	{
		DirectionCommandDisableBefore item = new DirectionCommandDisableBefore(mng, exe);
		commandList.Add(item);
		return m_CommandNum++;
	}

	public int eventYakumonoMove(YakuManager.KIND _line, int _id, int exe)
	{
		DirectionCommandYakumonoMove item = new DirectionCommandYakumonoMove(yaku, _line, _id, exe);
		commandList.Add(item);
		return m_CommandNum++;
	}

	public int eventPlayImage(DirectionManager.IMAGE playID, bool add, bool trim, int x, int y, int layer, int exe)
	{
		DirectionCommandImagePlay item = new DirectionCommandImagePlay(prodImg, (int)playID, add, trim, x, y, layer, exe);
		commandList.Add(item);
		return m_CommandNum++;
	}

	public int eventStopImage(DirectionManager.IMAGE stopID, int exe)
	{
		DirectionCommandImageStop item = new DirectionCommandImageStop(prodImg, (int)stopID, exe);
		commandList.Add(item);
		return m_CommandNum++;
	}

	public int eventStopImageLayer(float layer, int exe)
	{
		DirectionCommandImageStopLayer item = new DirectionCommandImageStopLayer(prodImg, layer, exe);
		commandList.Add(item);
		return m_CommandNum++;
	}

	public int eventStopImageAll(int exe)
	{
		DirectionCommandImageStopAll item = new DirectionCommandImageStopAll(prodImg, exe);
		commandList.Add(item);
		return m_CommandNum++;
	}

	public int eventImageSlide(float layer, float sx, float sy, float dx, float dy, int frame, int exe)
	{
		DirectionCommandImageSlide item = new DirectionCommandImageSlide(prodImg, layer, sx, sy, dx, dy, frame, exe);
		commandList.Add(item);
		return m_CommandNum++;
	}

	public int eventImageChangeScale(float layer, float sx, float sy, float dx, float dy, int frame, int exe)
	{
		DirectionCommandImageChangeScale item = new DirectionCommandImageChangeScale(prodImg, layer, sx, sy, dx, dy, frame, exe);
		commandList.Add(item);
		return m_CommandNum++;
	}

	public int eventImageColorChange(float layer, int sa, int sr, int sg, int sb, int da, int dr, int dg, int db, int frame, int exe)
	{
		DirectionCommandImageColorChange item = new DirectionCommandImageColorChange(prodImg, layer, sa, sr, sg, sb, da, dr, dg, db, frame, exe);
		commandList.Add(item);
		return m_CommandNum++;
	}

	public int eventLEDMainStart(LEDMainManager.LINE _line, int _id, bool _loop, int exe)
	{
		DirectionCommandLEDMainStart item = new DirectionCommandLEDMainStart(ledMain, _line, _id, _loop, exe);
		commandList.Add(item);
		return m_CommandNum++;
	}

	public int eventLEDMainStop(LEDMainManager.LINE _line, int exe)
	{
		DirectionCommandLEDMainStop item = new DirectionCommandLEDMainStop(ledMain, _line, exe);
		commandList.Add(item);
		return m_CommandNum++;
	}

	public int eventLEDMainStopAll(LEDMainManager.LINE _line, int exe)
	{
		DirectionCommandLEDMainStopAll item = new DirectionCommandLEDMainStopAll(ledMain, exe);
		commandList.Add(item);
		return m_CommandNum++;
	}

	public int eventLEDPanelStart(LEDPanelManager.LINE _line, int _id, bool _loop, int exe)
	{
		DirectionCommandLEDPanelStart item = new DirectionCommandLEDPanelStart(ledPanel, _line, _id, _loop, exe);
		commandList.Add(item);
		return m_CommandNum++;
	}

	public int eventLEDPanelStop(LEDPanelManager.LINE _line, int exe)
	{
		DirectionCommandLEDPanelStop item = new DirectionCommandLEDPanelStop(ledPanel, _line, exe);
		commandList.Add(item);
		return m_CommandNum++;
	}

	public int eventLEDPanelStopAll(LEDPanelManager.LINE _line, int exe)
	{
		DirectionCommandLEDPanelStopAll item = new DirectionCommandLEDPanelStopAll(ledPanel, exe);
		commandList.Add(item);
		return m_CommandNum++;
	}

	public int eventMakeDirection(DirectionManager.DIR kind, byte high, byte low, byte mode, int exe)
	{
		DirectionCommandMakeDirection item = new DirectionCommandMakeDirection(kind, high, low, mode, exe);
		commandList.Add(item);
		return m_CommandNum++;
	}

	public int eventSetCanPush(bool _flag, int exe)
	{
		DirectionCommandSetCanPush item = new DirectionCommandSetCanPush(_flag, exe);
		commandList.Add(item);
		return m_CommandNum++;
	}

	public int eventPlayAnime(DirectionManager.ANIME playID, int ptnID, bool kill, bool loop, bool add, bool trim, int x, int y, int layer, int exe)
	{
		DirectionCommandAnimePlay item = new DirectionCommandAnimePlay(prodAnime, (int)playID, ptnID, kill, loop, add, trim, x, y, layer, exe, m_Priority + m_PriorityCnt);
		if (m_Priority >= 0)
		{
			m_PriorityCnt++;
		}
		commandList.Add(item);
		return m_CommandNum++;
	}

	public int eventAddAnime(DirectionManager.ANIME playID, int ptnID, DirectionManager.ANIME oldID, bool kill, bool loop, bool add, bool trim)
	{
		DirectionCommandAnimeAdd item = new DirectionCommandAnimeAdd(prodAnime, (int)playID, ptnID, (int)oldID, kill, loop, add, trim, m_Priority + m_PriorityCnt);
		if (m_Priority >= 0)
		{
			m_PriorityCnt++;
		}
		commandList.Add(item);
		return m_CommandNum++;
	}

	public int eventAddAnimeWithPosition(DirectionManager.ANIME playID, int ptnID, DirectionManager.ANIME oldID, bool kill, bool loop, bool add, bool trim, int x, int y)
	{
		DirectionCommandAnimeAddWithPosition item = new DirectionCommandAnimeAddWithPosition(prodAnime, (int)playID, ptnID, (int)oldID, kill, loop, add, trim, x, y, m_Priority + m_PriorityCnt);
		if (m_Priority >= 0)
		{
			m_PriorityCnt++;
		}
		commandList.Add(item);
		return m_CommandNum++;
	}

	public int eventAddAnimeWithLayer(DirectionManager.ANIME playID, int ptnID, DirectionManager.ANIME oldID, float layer, bool kill, bool loop, bool add, bool trim)
	{
		DirectionCommandAnimeAddWithLayer item = new DirectionCommandAnimeAddWithLayer(prodAnime, (int)playID, ptnID, (int)oldID, layer, kill, loop, add, trim, m_Priority + m_PriorityCnt);
		if (m_Priority >= 0)
		{
			m_PriorityCnt++;
		}
		commandList.Add(item);
		return m_CommandNum++;
	}

	public int eventAddAnimeWithLayerAndPosition(DirectionManager.ANIME playID, int ptnID, DirectionManager.ANIME oldID, float layer, bool kill, bool loop, bool add, bool trim, int x, int y)
	{
		DirectionCommandAnimeAddWithLayerAndPosition item = new DirectionCommandAnimeAddWithLayerAndPosition(prodAnime, (int)playID, ptnID, (int)oldID, layer, kill, loop, add, trim, x, y, m_Priority + m_PriorityCnt);
		if (m_Priority >= 0)
		{
			m_PriorityCnt++;
		}
		commandList.Add(item);
		return m_CommandNum++;
	}

	public int eventPauseAnime(DirectionManager.ANIME pauseID, int exe)
	{
		DirectionCommandAnimePause item = new DirectionCommandAnimePause(prodAnime, (int)pauseID, exe);
		commandList.Add(item);
		return m_CommandNum++;
	}

	public int eventResumeAnime(DirectionManager.ANIME pauseID, int exe)
	{
		DirectionCommandAnimeResume item = new DirectionCommandAnimeResume(prodAnime, (int)pauseID, exe);
		commandList.Add(item);
		return m_CommandNum++;
	}

	public int eventStopAnime(DirectionManager.ANIME stopID, int exe)
	{
		DirectionCommandAnimeStop item = new DirectionCommandAnimeStop(prodAnime, (int)stopID, exe);
		commandList.Add(item);
		return m_CommandNum++;
	}

	public int eventStopAnimeLayer(float layer, int exe)
	{
		DirectionCommandAnimeStopLayer item = new DirectionCommandAnimeStopLayer(prodAnime, layer, exe);
		commandList.Add(item);
		return m_CommandNum++;
	}

	public int eventStopAnimeAll(int exe)
	{
		DirectionCommandAnimeStopAll item = new DirectionCommandAnimeStopAll(prodAnime, exe);
		commandList.Add(item);
		return m_CommandNum++;
	}

	public int eventKillAnime(DirectionManager.ANIME killID, int exe)
	{
		DirectionCommandAnimeKill item = new DirectionCommandAnimeKill(prodAnime, (int)killID, exe);
		commandList.Add(item);
		return m_CommandNum++;
	}

	public int eventKillAnimeLayer(float layer, int exe)
	{
		DirectionCommandAnimeKillLayer item = new DirectionCommandAnimeKillLayer(prodAnime, layer, exe);
		commandList.Add(item);
		return m_CommandNum++;
	}

	public int eventKillAnimeAll(int exe)
	{
		DirectionCommandAnimeKillAll item = new DirectionCommandAnimeKillAll(prodAnime, exe);
		commandList.Add(item);
		return m_CommandNum++;
	}

	public int eventAnimeSlide(float layer, float sx, float sy, float dx, float dy, int frame, int exe)
	{
		DirectionCommandAnimeSlide item = new DirectionCommandAnimeSlide(prodAnime, layer, sx, sy, dx, dy, frame, exe);
		commandList.Add(item);
		return m_CommandNum++;
	}

	public int eventAnimeChangeScale(float layer, float sx, float sy, float dx, float dy, int frame, int exe)
	{
		DirectionCommandAnimeChangeScale item = new DirectionCommandAnimeChangeScale(prodAnime, layer, sx, sy, dx, dy, frame, exe);
		commandList.Add(item);
		return m_CommandNum++;
	}

	public int eventAnimeLoop(DirectionManager.ANIME playID, bool loop, int exe)
	{
		DirectionCommandAnimeLoop item = new DirectionCommandAnimeLoop(prodAnime, (int)playID, loop, exe);
		commandList.Add(item);
		return m_CommandNum++;
	}
}
