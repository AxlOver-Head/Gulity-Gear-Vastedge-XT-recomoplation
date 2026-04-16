using UnityEngine;

public class SGLGInput
{
	public enum STATE
	{
		FREE = 0,
		PUSH = 1,
		HOLD = 2,
		UP = 3,
		PINCH = 4
	}

	public static STATE state;

	public static float X;

	public static float Y;

	public static float X2;

	public static float Y2;

	public static int BASE_W = 640;

	public static int BASE_H = 960;

	public static float x
	{
		get
		{
			return X;
		}
	}

	public static float y
	{
		get
		{
			return Y;
		}
	}

	public static float x2
	{
		get
		{
			return X2;
		}
	}

	public static float y2
	{
		get
		{
			return Y2;
		}
	}

	public static bool isFree()
	{
		return state == STATE.FREE;
	}

	public static bool isPush()
	{
		return state == STATE.PUSH;
	}

	public static bool isHold()
	{
		return state == STATE.HOLD;
	}

	public static bool isUp()
	{
		return state == STATE.UP;
	}

	public static bool isPinch()
	{
		return state == STATE.PINCH;
	}

	public static void update()
	{
		switch (state)
		{
		case STATE.FREE:
			if (Input.touchCount == 1)
			{
				state = STATE.PUSH;
			}
			else if (Input.touchCount == 2)
			{
				X2 = (float)BASE_W * Input.GetTouch(1).position.x / (float)SGLG.scrW;
				Y2 = (float)BASE_H * Input.GetTouch(1).position.y / (float)SGLG.scrH;
				state = STATE.PINCH;
			}
			break;
		case STATE.PUSH:
			if (Input.touchCount == 0)
			{
				state = STATE.UP;
			}
			else if (Input.touchCount == 2)
			{
				X2 = (float)BASE_W * Input.GetTouch(1).position.x / (float)SGLG.scrW;
				Y2 = (float)BASE_H * Input.GetTouch(1).position.y / (float)SGLG.scrH;
				state = STATE.PINCH;
			}
			else
			{
				state = STATE.HOLD;
			}
			break;
		case STATE.HOLD:
			if (Input.touchCount == 0)
			{
				state = STATE.UP;
			}
			else if (Input.touchCount == 2)
			{
				X2 = (float)BASE_W * Input.GetTouch(1).position.x / (float)SGLG.scrW;
				Y2 = (float)BASE_H * Input.GetTouch(1).position.y / (float)SGLG.scrH;
				state = STATE.PINCH;
			}
			break;
		case STATE.UP:
			if (Input.touchCount == 1)
			{
				state = STATE.PUSH;
			}
			else if (Input.touchCount == 2)
			{
				X2 = (float)BASE_W * Input.GetTouch(1).position.x / (float)SGLG.scrW;
				Y2 = (float)BASE_H * Input.GetTouch(1).position.y / (float)SGLG.scrH;
				state = STATE.PINCH;
			}
			else
			{
				state = STATE.FREE;
			}
			break;
		case STATE.PINCH:
			if (Input.touchCount == 2)
			{
				X2 = (float)BASE_W * Input.GetTouch(1).position.x / (float)SGLG.scrW;
				Y2 = (float)BASE_H * Input.GetTouch(1).position.y / (float)SGLG.scrH;
			}
			else if (Input.touchCount == 1)
			{
				state = STATE.HOLD;
			}
			else if (Input.touchCount == 0)
			{
				state = STATE.UP;
			}
			break;
		}
		if (Input.touchCount >= 1)
		{
			X = (float)BASE_W * Input.GetTouch(0).position.x / (float)SGLG.scrW;
			Y = (float)BASE_H * Input.GetTouch(0).position.y / (float)SGLG.scrH;
		}
	}
}
