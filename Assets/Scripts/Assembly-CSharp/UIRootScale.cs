using UnityEngine;

[ExecuteInEditMode]
public class UIRootScale : MonoBehaviour
{
	private UIRoot uiRoot;

	public int defaultHeight = 960;

	public int defaultWidth = 640;

	public float maxAcceptAspectRatio = 1.8f;

	public float minAcceptAspectRaito = 1.3f;

	public float aspect;

	private void Awake()
	{
		uiRoot = GetComponent<UIRoot>();
	}

	private void Start()
	{
		updateScale();
	}

	private void Update()
	{
	}

	private void updateScale()
	{
		if (!(uiRoot == null))
		{
			aspect = (float)Screen.height / (float)Screen.width;
			if (maxAcceptAspectRatio < aspect)
			{
				aspect = maxAcceptAspectRatio;
			}
			else if (aspect < minAcceptAspectRaito)
			{
				aspect = minAcceptAspectRaito;
			}
			int num = (int)((float)defaultWidth * aspect);
			if (uiRoot.manualHeight != num)
			{
				uiRoot.manualHeight = num;
			}
		}
	}
}
