using UnityEngine;

public class MainCameraManager
{
	public enum MODE
	{
		NONE = 0,
		SHITA = 1,
		SHITA_BACK = 2,
		SHITA_BACK_ZOOM = 3,
		ZOOM_1 = 4,
		ZOOM_2 = 5,
		ZOOM_BACK = 6,
		ZOOM_BACK_SHITA = 7,
		PINCH = 8,
		PINCHEND = 9
	}

	private GameObject gcamera;

	public Camera camera;

	public static MODE mode;

	public float camX = 1000f;

	public float camY = 0.55f;

	public float camZ = 2.2f;

	public float camF = 14.7f;

	private static readonly float COMPACT_Y = -0.05f;

	public float firstX;

	public float firstY;

	private static readonly float SWIPESTART = 80f;

	private static readonly float SWIPEMAX = 240f;

	private static readonly float SWIPEBACK = 32f;

	private static readonly float SWIPE_PZ = 1.25f;

	private static readonly float SWIPE_RX = 20f;

	private static readonly float SWIPE_FV = 10f;

	private static readonly float SWIPE_FV5 = 14.3f;

	public float moveX;

	public float moveY;

	public float backX;

	public float backY;

	public float swipe_fv = SWIPE_FV;

	public bool touched;

	public bool isZoom;

	public float zoomY;

	public float zoomF;

	public float zoomCnt;

	public float zoomStartY;

	public float zoomStartF;

	public float zoomDestY = 0.575f;

	public float zoomDestF = 11f;

	private static readonly float ZOOMMAX = 4f;

	private Vector2 first1;

	private Vector2 first2;

	private Vector2 prev1;

	private Vector2 prev2;

	private static readonly float PINCHMAX = 320f;

	public void init()
	{
		mode = MODE.NONE;
		gcamera = GameObject.Find("MainCamera");
		camera = gcamera.GetComponent<Camera>();
		float num = 0f;
		float num2 = 0f;
		float num3 = 0f;
		float num4 = 0f;
		if (SGLG.viewMode == SGLG.VIEWMODE.IPAD)
		{
			num = 0.59f;
			num2 = 0.1071488f;
			num3 = 0.575f;
			num4 = 0.07943846f;
		}
		else if (SGLG.viewMode == SGLG.VIEWMODE.IPHONE5)
		{
			num = 0.575f;
			num2 = 0.09417582f;
			num3 = 0.575f;
			num4 = 0.07061197f;
		}
		else
		{
			num = 0.59f;
			num2 = 0.09417582f;
			num3 = 0.575f;
			num4 = 0.07061197f;
		}
		camX = 1000f;
		camY = num;
		camZ = 2.2f;
		float num5 = num2;
		float num6 = num5 / camera.aspect;
		float num7 = 0.55f;
		camF = 2f * Mathf.Atan(num6 * 0.5f / num7) * 57.29578f;
		float num8 = num4;
		float num9 = num8 / camera.aspect;
		zoomDestY = num3;
		zoomDestF = 2f * Mathf.Atan(num9 * 0.5f / num7) * 57.29578f;
		swipe_fv = zoomDestF - 0.1f;
		gcamera.transform.position = new Vector3(camX, camY, camZ);
		gcamera.transform.eulerAngles = new Vector3(0f, 180f, 0f);
		camera.fieldOfView = camF;
	}

	private void keyNone()
	{
		if (SGLGInput.isPinch())
		{
			startPinch();
		}
		else if (!touched)
		{
			if (SGLGInput.isPush())
			{
				firstX = SGLGInput.x;
				firstY = SGLGInput.y;
				touched = true;
			}
		}
		else if (SGLGInput.isHold() && firstY < SGLGInput.y - SWIPESTART)
		{
			firstY = SGLGInput.y;
			if (isZoom)
			{
				zoomCnt = 0f;
				mode = MODE.ZOOM_BACK_SHITA;
			}
			else
			{
				mode = MODE.SHITA;
			}
		}
		else if (SGLGInput.isFree() || SGLGInput.isUp())
		{
			touched = false;
		}
	}

	private void keyShita()
	{
		if (SGLGInput.isFree() || SGLGInput.isUp())
		{
			touched = false;
			mode = MODE.SHITA_BACK;
			backX = moveX;
			backY = moveY;
			return;
		}
		moveX = SGLGInput.x - firstX;
		moveY = SGLGInput.y - firstY;
		if (moveY >= SWIPEMAX)
		{
			moveY = SWIPEMAX;
		}
	}

	private void keyShitaBack()
	{
	}

	public void keyEvent()
	{
		switch (mode)
		{
		case MODE.NONE:
			keyNone();
			break;
		case MODE.SHITA:
			keyShita();
			break;
		case MODE.SHITA_BACK:
			keyShitaBack();
			break;
		}
	}

	private bool isCompactOffset()
	{
		if (MainGameScene.m_DataPanel.isCompactMode())
		{
			switch (SGLG.viewMode)
			{
			case SGLG.VIEWMODE.IPHONE5:
			case SGLG.VIEWMODE.ANDROID:
				return true;
			}
		}
		return false;
	}

	private void controlNone()
	{
		float num = ((!isZoom) ? camY : zoomY);
		float num2 = num;
		if (isCompactOffset())
		{
			num2 += COMPACT_Y;
		}
		gcamera.transform.position = new Vector3(camX, num2, camZ);
	}

	private void controlShita()
	{
		float num = moveY;
		if (num > SWIPEMAX)
		{
			num = SWIPEMAX;
		}
		if (num < 0f)
		{
			num = 0f;
		}
		float z = camZ - SWIPE_PZ * num / SWIPEMAX;
		float x = 0f + SWIPE_RX * num / SWIPEMAX;
		float fieldOfView = camF + swipe_fv * num / SWIPEMAX;
		gcamera.transform.position = new Vector3(gcamera.transform.position.x, gcamera.transform.position.y, z);
		gcamera.transform.eulerAngles = new Vector3(x, gcamera.transform.eulerAngles.y, gcamera.transform.eulerAngles.z);
		camera.fieldOfView = fieldOfView;
	}

	private void controlShitaBack()
	{
		backY -= SWIPEBACK;
		float num = backY;
		if (num > SWIPEMAX)
		{
			num = SWIPEMAX;
		}
		if (num < 0f)
		{
			num = 0f;
		}
		float z = camZ - SWIPE_PZ * num / SWIPEMAX;
		float x = 0f + SWIPE_RX * num / SWIPEMAX;
		float fieldOfView = camF + swipe_fv * num / SWIPEMAX;
		gcamera.transform.position = new Vector3(gcamera.transform.position.x, gcamera.transform.position.y, z);
		gcamera.transform.eulerAngles = new Vector3(x, gcamera.transform.eulerAngles.y, gcamera.transform.eulerAngles.z);
		camera.fieldOfView = fieldOfView;
		if (num <= 0f)
		{
			moveX = 0f;
			moveY = 0f;
			if (isZoom)
			{
				zoomCnt = 0f;
				mode = MODE.SHITA_BACK_ZOOM;
			}
			else
			{
				mode = MODE.NONE;
			}
		}
	}

	private void controlShitaBackZoom()
	{
		float num = zoomY - camY;
		float num2 = zoomF - camF;
		zoomCnt += 1f;
		float num3 = camY + zoomCnt * num / ZOOMMAX;
		float fieldOfView = camF + zoomCnt * num2 / ZOOMMAX;
		float num4 = num3;
		if (isCompactOffset())
		{
			num4 += COMPACT_Y;
		}
		gcamera.transform.position = new Vector3(gcamera.transform.position.x, num4, gcamera.transform.position.z);
		camera.fieldOfView = fieldOfView;
		if (zoomCnt >= ZOOMMAX)
		{
			mode = MODE.NONE;
		}
	}

	private void controlZoom1()
	{
		float num = (zoomDestY - zoomStartY) / 2f;
		float num2 = (zoomDestF - zoomStartF) / 2f;
		zoomCnt += 1f;
		float num3 = zoomStartY + zoomCnt * num / ZOOMMAX;
		float fieldOfView = zoomStartF + zoomCnt * num2 / ZOOMMAX;
		float num4 = num3;
		if (isCompactOffset())
		{
			num4 += COMPACT_Y;
		}
		gcamera.transform.position = new Vector3(gcamera.transform.position.x, num4, gcamera.transform.position.z);
		camera.fieldOfView = fieldOfView;
		zoomY = num3;
		zoomF = fieldOfView;
		if (zoomCnt >= ZOOMMAX)
		{
			mode = MODE.NONE;
		}
	}

	private void controlZoom2()
	{
		float num = zoomDestY - zoomStartY;
		float num2 = zoomDestF - zoomStartF;
		zoomCnt += 1f;
		float num3 = zoomStartY + zoomCnt * num / ZOOMMAX;
		float fieldOfView = zoomStartF + zoomCnt * num2 / ZOOMMAX;
		float num4 = num3;
		if (isCompactOffset())
		{
			num4 += COMPACT_Y;
		}
		gcamera.transform.position = new Vector3(gcamera.transform.position.x, num4, gcamera.transform.position.z);
		camera.fieldOfView = fieldOfView;
		zoomY = num3;
		zoomF = fieldOfView;
		if (zoomCnt >= ZOOMMAX)
		{
			mode = MODE.NONE;
		}
	}

	private void controlZoomBack()
	{
		float num = zoomStartY - camY;
		float num2 = zoomStartF - camF;
		zoomCnt += 1f;
		float num3 = zoomStartY - zoomCnt * num / ZOOMMAX;
		float fieldOfView = zoomStartF - zoomCnt * num2 / ZOOMMAX;
		float num4 = num3;
		if (isCompactOffset())
		{
			num4 += COMPACT_Y;
		}
		gcamera.transform.position = new Vector3(gcamera.transform.position.x, num4, gcamera.transform.position.z);
		camera.fieldOfView = fieldOfView;
		zoomY = num3;
		zoomF = fieldOfView;
		if (zoomCnt >= ZOOMMAX)
		{
			mode = MODE.NONE;
			isZoom = false;
		}
	}

	private void controlZoomBackShita()
	{
		float num = zoomY - camY;
		float num2 = zoomF - camF;
		zoomCnt += 1f;
		float num3 = zoomY - zoomCnt * num / ZOOMMAX;
		float fieldOfView = zoomF - zoomCnt * num2 / ZOOMMAX;
		float num4 = num3;
		if (isCompactOffset())
		{
			num4 += COMPACT_Y;
		}
		gcamera.transform.position = new Vector3(gcamera.transform.position.x, num4, gcamera.transform.position.z);
		camera.fieldOfView = fieldOfView;
		if (zoomCnt >= ZOOMMAX)
		{
			firstY = SGLGInput.y;
			mode = MODE.SHITA;
		}
	}

	private void controlPinch()
	{
		if (!SGLGInput.isPinch())
		{
			if (zoomY == camY && zoomF == camF)
			{
				isZoom = false;
			}
			else
			{
				isZoom = true;
			}
			mode = MODE.PINCHEND;
			return;
		}
		Vector2 a = new Vector2(SGLGInput.x, SGLGInput.y);
		Vector2 b = new Vector2(SGLGInput.x2, SGLGInput.y2);
		float num = Vector2.Distance(prev1, prev2);
		float num2 = Vector2.Distance(a, b);
		float num3 = num2 - num;
		if (num3 > 0f)
		{
			if (num3 > PINCHMAX)
			{
				num3 = PINCHMAX;
			}
			float num4 = zoomDestY - camY;
			float num5 = camF - zoomDestF;
			zoomY += num3 * num4 / PINCHMAX;
			zoomF -= num3 * num5 / PINCHMAX;
			if (zoomY > camY)
			{
				zoomY = camY;
			}
			if (zoomY < zoomDestY)
			{
				zoomY = zoomDestY;
			}
			if (zoomF < zoomDestF)
			{
				zoomF = zoomDestF;
			}
			if (zoomF > camF)
			{
				zoomF = camF;
			}
			float num6 = zoomY;
			if (isCompactOffset())
			{
				num6 += COMPACT_Y;
			}
			gcamera.transform.position = new Vector3(gcamera.transform.position.x, num6, gcamera.transform.position.z);
			camera.fieldOfView = zoomF;
		}
		else if (num3 < 0f)
		{
			if (num3 < 0f - PINCHMAX)
			{
				num3 = 0f - PINCHMAX;
			}
			float num7 = zoomDestY - camY;
			float num8 = camF - zoomDestF;
			zoomY += num3 * num7 / PINCHMAX;
			zoomF -= num3 * num8 / PINCHMAX;
			if (zoomY > camY)
			{
				zoomY = camY;
			}
			if (zoomY < zoomDestY)
			{
				zoomY = zoomDestY;
			}
			if (zoomF < zoomDestF)
			{
				zoomF = zoomDestF;
			}
			if (zoomF > camF)
			{
				zoomF = camF;
			}
			float num9 = zoomY;
			if (isCompactOffset())
			{
				num9 += COMPACT_Y;
			}
			gcamera.transform.position = new Vector3(gcamera.transform.position.x, num9, gcamera.transform.position.z);
			camera.fieldOfView = zoomF;
		}
		prev1 = a;
		prev2 = b;
	}

	private void controlPinchEnd()
	{
		if (SGLGInput.isUp() || SGLGInput.isFree())
		{
			mode = MODE.NONE;
			if (zoomY == ((!isCompactOffset()) ? camY : (camY + COMPACT_Y)))
			{
				isZoom = false;
			}
		}
		else if (SGLGInput.isPinch())
		{
			startPinch();
		}
	}

	private void startPinch()
	{
		first1 = new Vector2(SGLGInput.x, SGLGInput.y);
		first2 = new Vector2(SGLGInput.x2, SGLGInput.y2);
		prev1 = new Vector2(SGLGInput.x, SGLGInput.y);
		prev2 = new Vector2(SGLGInput.x2, SGLGInput.y2);
		float y = gcamera.transform.position.y;
		zoomY = (zoomStartY = ((!isCompactOffset()) ? y : (y - COMPACT_Y)));
		zoomF = (zoomStartF = camera.fieldOfView);
		isZoom = true;
		mode = MODE.PINCH;
	}

	public void control()
	{
		switch (mode)
		{
		case MODE.NONE:
			controlNone();
			break;
		case MODE.SHITA:
			controlShita();
			break;
		case MODE.SHITA_BACK:
			controlShitaBack();
			break;
		case MODE.SHITA_BACK_ZOOM:
			controlShitaBackZoom();
			break;
		case MODE.ZOOM_1:
			controlZoom1();
			break;
		case MODE.ZOOM_2:
			controlZoom2();
			break;
		case MODE.ZOOM_BACK:
			controlZoomBack();
			break;
		case MODE.ZOOM_BACK_SHITA:
			controlZoomBackShita();
			break;
		case MODE.PINCH:
			controlPinch();
			break;
		case MODE.PINCHEND:
			controlPinchEnd();
			break;
		}
	}

	public void ekisyoTouch()
	{
		if (mode == MODE.NONE)
		{
			zoomY = (zoomStartY = gcamera.transform.position.y);
			zoomF = (zoomStartF = camera.fieldOfView);
			zoomCnt = 0f;
			isZoom = true;
			if (zoomStartY < camY + (zoomDestY - camY) / 2f)
			{
				mode = MODE.ZOOM_1;
			}
			else if (zoomStartY < zoomDestY)
			{
				mode = MODE.ZOOM_2;
			}
			else
			{
				mode = MODE.ZOOM_BACK;
			}
		}
	}
}
