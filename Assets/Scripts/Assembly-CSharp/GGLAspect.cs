using UnityEngine;

public class GGLAspect : MonoBehaviour
{
	private static Rect[] box_rect;

	private static Vector3 tra;

	private static bool bUpdate;

	private void Awake()
	{
		tra = new Vector3(0f, 0f, 0f);
	}

	public static void Adjust(Camera inCamera)
	{
		float num = 2f / 3f;
		float num2 = (float)Screen.width / (float)Screen.height;
		float num3 = num2 / num;
		if (inCamera != null)
		{
			if (num3 < 1f)
			{
				Rect rect = inCamera.rect;
				rect.width = 1f;
				rect.height = num3;
				rect.x = 0f;
				rect.y = (1f - num3) / 2f;
				inCamera.rect = rect;
				box_rect = new Rect[2];
				box_rect[0] = new Rect(0f, 0f, Screen.width, rect.y * (float)Screen.height);
				box_rect[1] = new Rect(0f, (rect.y + rect.height) * (float)Screen.height, Screen.width, rect.y * (float)Screen.height);
			}
			else
			{
				num = 0.75f;
				num3 = num2 / num;
				float num4 = 1f / num3;
				Rect rect2 = inCamera.rect;
				rect2.width = num4;
				rect2.height = 1f;
				rect2.x = (1f - num4) / 2f;
				rect2.y = 0f;
				inCamera.rect = rect2;
				box_rect = new Rect[2];
				box_rect[0] = new Rect(0f, 0f, Screen.width, rect2.y * (float)Screen.height);
				box_rect[1] = new Rect((rect2.x + rect2.width) * (float)Screen.width, 0f, rect2.x * (float)Screen.width, Screen.height);
			}
			bUpdate = true;
		}
		else
		{
			bUpdate = false;
		}
	}

	private void OnGUI()
	{
	}

	public static void SetVisibleBack(bool flg)
	{
		bUpdate = flg;
	}
}
