using UnityEngine;

public class ReelObject : MonoBehaviour
{
	public enum REELSPEED
	{
		NORMAL = 0,
		HIGH = 1,
		LOW = 2,
		LOW_2 = 3
	}

	public enum MOVESTATE
	{
		NONE = 0,
		STOP = 1,
		ROLL = 2,
		SLIDE = 3,
		FREEZE = 4,
		FREEZEEND = 5
	}

	public static readonly float REEL_FPS = 60f;

	private static readonly float STEP_SIZE = 17.142857f;

	private static readonly float CORRECT_STEP = STEP_SIZE * 5f;

	private static readonly float SEC_SLW2 = 2.011976f;

	private static readonly float SEC_SLW = 1f;

	private static readonly float SEC_NML = 0.7f;

	private static readonly float SEC_HIG = 0.5f;

	public static readonly float SPEED_SLW2 = 10800f / (30f * SEC_SLW2);

	public static readonly float SPEED_SLW = 10800f / (30f * SEC_SLW);

	public static readonly float SPEED_NML = 10800f / (30f * SEC_NML);

	public static readonly float SPEED_HIG = 10800f / (30f * SEC_HIG);

	public static readonly int STEP_MAX = 21;

	public int thisID = -1;

	public int pushStep = -1;

	public int nowStep = -1;

	public int oldStep = -1;

	public int stopStep = -1;

	public MOVESTATE state;

	public float rot;

	public float destRot;

	public int suberi = -1;

	public float reelSpeed;

	private bool blurFlag;

	public Texture mainTex;

	public Texture blurTex;

	public int direction = 1;

	public bool isFreeze;

	public int freezeID = -1;

	public int freezeNo;

	public int fLoopNum;

	public int fShakeCnt;

	public int fSpeed;

	private static float[] shakeTbl = new float[8]
	{
		STEP_SIZE / 8f * 1f,
		STEP_SIZE / 8f * 2f,
		STEP_SIZE / 8f * 1f,
		STEP_SIZE / 8f * 0f,
		STEP_SIZE / 8f * -1f,
		STEP_SIZE / 8f * -2f,
		STEP_SIZE / 8f * -1f,
		STEP_SIZE / 8f * 0f
	};

	public bool isMove()
	{
		return state == MOVESTATE.ROLL || state == MOVESTATE.FREEZE || state == MOVESTATE.FREEZEEND;
	}

	public void setBlur(bool _flag)
	{
		blurFlag = _flag;
	}

	public void setStep(int _prm)
	{
		rot = (float)_prm * STEP_SIZE;
		oldStep = nowStep;
		nowStep = _prm;
		updateRot();
	}

	private void Awake()
	{
		state = MOVESTATE.STOP;
		rot = base.gameObject.transform.rotation.x;
		updateNowStep();
	}

	private void updateNowStep()
	{
		oldStep = nowStep;
		if (direction == 1)
		{
			nowStep = (int)(rot / STEP_SIZE) + 1;
		}
		else
		{
			nowStep = (int)(rot / STEP_SIZE) - 1;
		}
	}

	private void updateRot()
	{
		base.gameObject.transform.eulerAngles = new Vector3(rot + CORRECT_STEP, 0f, 0f);
	}

	private void Update()
	{
		switch (state)
		{
		case MOVESTATE.STOP:
			break;
		case MOVESTATE.ROLL:
			rotate(reelSpeed * Time.deltaTime, false);
			updateRot();
			break;
		case MOVESTATE.SLIDE:
			if (direction == 1)
			{
				rotate(reelSpeed * Time.deltaTime, true);
				if (rot >= destRot)
				{
					setStep(stopStep);
					state = MOVESTATE.STOP;
					end();
				}
			}
			else
			{
				rotate(reelSpeed * Time.deltaTime, true);
				if (rot <= destRot)
				{
					setStep(stopStep);
					state = MOVESTATE.STOP;
					end();
				}
			}
			updateRot();
			break;
		case MOVESTATE.FREEZE:
			updateFreeze();
			break;
		}
	}

	private void rotate(float angle, bool permit360)
	{
		rot += angle * (float)direction;
		if (!permit360)
		{
			correctRotate();
		}
		updateNowStep();
	}

	private void correctRotate()
	{
		while (rot < 0f)
		{
			rot += 360f;
		}
		while (rot >= 360f)
		{
			rot -= 360f;
		}
	}

	public void start(REELSPEED speed, int _direction)
	{
		start(speed, _direction, false);
	}

	public void start(REELSPEED speed, int _direction, bool isFreeze)
	{
		state = MOVESTATE.ROLL;
		if (isFreeze)
		{
			state = MOVESTATE.FREEZE;
		}
		pushStep = -1;
		stopStep = -1;
		Texture mainTexture = mainTex;
		if (blurFlag)
		{
			mainTexture = blurTex;
		}
		base.gameObject.GetComponent<Renderer>().material.mainTexture = mainTexture;
		switch (speed)
		{
		case REELSPEED.NORMAL:
			reelSpeed = SPEED_NML;
			break;
		case REELSPEED.HIGH:
			reelSpeed = SPEED_HIG;
			break;
		case REELSPEED.LOW:
			reelSpeed = SPEED_SLW;
			break;
		case REELSPEED.LOW_2:
			reelSpeed = SPEED_SLW2;
			break;
		}
		direction = _direction;
	}

	public void end()
	{
		base.gameObject.GetComponent<Renderer>().material.mainTexture = mainTex;
	}

	public void push(int _suberi)
	{
		pushStep = nowStep;
		if (direction == 1)
		{
			stopStep = nowStep + _suberi;
			suberi = _suberi;
			destRot = (float)stopStep * STEP_SIZE;
			if (nowStep > stopStep)
			{
				setStep(stopStep);
				state = MOVESTATE.STOP;
				end();
			}
			else
			{
				state = MOVESTATE.SLIDE;
			}
		}
		else
		{
			stopStep = nowStep - _suberi;
			suberi = -_suberi;
			destRot = (float)stopStep * STEP_SIZE;
			if (nowStep < stopStep)
			{
				setStep(stopStep);
				state = MOVESTATE.STOP;
				end();
			}
			else
			{
				state = MOVESTATE.SLIDE;
			}
		}
	}

	public int getPushStep_OnStop()
	{
		int num = -1;
		num = ((pushStep >= 0) ? pushStep : nowStep);
		return ReelManager.getCorrect(num);
	}

	public void fEventSet(int eventID, int number)
	{
		if (state != MOVESTATE.ROLL)
		{
			isFreeze = true;
			freezeID = eventID;
			freezeNo = number;
			fLoopNum = 0;
			fShakeCnt = 0;
			fSpeed = 0;
			state = MOVESTATE.FREEZE;
		}
	}

	public int fGetNumber()
	{
		return freezeNo;
	}

	public int fEventGet()
	{
		return freezeID;
	}

	public void fWaitProc(int frame, int cnt)
	{
		if (cnt == 0)
		{
			end();
		}
	}

	public void fPlusProc(int speed, int loop, int frame, int step, int cnt)
	{
		if (cnt == 0)
		{
			fSpeed = 0;
			if (speed != -1)
			{
				fSpeed = speed;
			}
			start((REELSPEED)fSpeed, 1, true);
		}
		if (isFreeze)
		{
			if (frame == cnt)
			{
				setStep(nowStep);
				fEnd();
			}
			else if (frame == (int)(SEC_NML * 30f) * loop)
			{
				setStep(nowStep);
				fEnd();
			}
			else if (step != -1 && isStepBetween2Points(oldStep, nowStep, step))
			{
				setStep(step);
				fEnd();
				end();
			}
		}
	}

	public void fMinusProc(int speed, int loop, int frame, int step, int cnt)
	{
		if (cnt == 0)
		{
			fSpeed = 0;
			if (speed != -1)
			{
				fSpeed = speed;
			}
			start((REELSPEED)fSpeed, -1, true);
		}
		if (isFreeze)
		{
			if (frame == cnt)
			{
				fEnd();
			}
			else if (frame == (int)(SEC_NML * 30f) * loop)
			{
				setStep(nowStep);
				fEnd();
			}
			else if (step != -1 && isStepBetween2Points(nowStep, oldStep, step))
			{
				setStep(step);
				fEnd();
				end();
			}
		}
	}

	public void fShakeProc(int speed, int loop)
	{
		if (fShakeCnt == 0 && fLoopNum == 0)
		{
			end();
			setStep(nowStep);
		}
		if (!isFreeze)
		{
			return;
		}
		if (loop == fLoopNum)
		{
			fEnd();
			return;
		}
		int num = fShakeCnt % 8;
		rot = (float)nowStep * STEP_SIZE + shakeTbl[num];
		fShakeCnt++;
		if (fShakeCnt >= 8)
		{
			fShakeCnt = 0;
			fLoopNum++;
		}
		updateRot();
	}

	public void fEndProc()
	{
		isFreeze = false;
		freezeID = -1;
		freezeNo = 0;
		fLoopNum = 0;
		fShakeCnt = 0;
		state = MOVESTATE.FREEZEEND;
	}

	public void fEnd()
	{
		isFreeze = false;
	}

	private void updateFreeze()
	{
		if (isFreeze)
		{
			switch (freezeID)
			{
			case 0:
				break;
			case 1:
				rotate(reelSpeed * Time.deltaTime, false);
				updateRot();
				break;
			case 2:
				rotate(reelSpeed * Time.deltaTime, false);
				updateRot();
				break;
			case 3:
				break;
			}
		}
	}

	private bool isStepBetween2Points(int pA, int pB, int step)
	{
		while (pA < 0)
		{
			pA += STEP_MAX;
		}
		while (pA >= STEP_MAX)
		{
			pA -= STEP_MAX;
		}
		while (pB < 0)
		{
			pB += STEP_MAX;
		}
		while (pB >= STEP_MAX)
		{
			pB -= STEP_MAX;
		}
		int num = step + STEP_MAX;
		if (pB < pA)
		{
			pB += STEP_MAX;
		}
		if ((pA <= step && step <= pB) || (pA <= num && num <= pB))
		{
			return true;
		}
		return false;
	}
}
