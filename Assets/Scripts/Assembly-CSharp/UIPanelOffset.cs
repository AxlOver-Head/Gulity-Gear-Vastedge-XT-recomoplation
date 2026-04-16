using UnityEngine;

public class UIPanelOffset : MonoBehaviour
{
	private bool initialized;

	private void Awake()
	{
		if (!initialized)
		{
			float x = base.gameObject.transform.localPosition.x;
			float y = base.gameObject.transform.localPosition.y + 40f;
			float z = base.gameObject.transform.localPosition.z;
			base.gameObject.transform.localPosition = new Vector3(x, y, z);
			initialized = true;
		}
	}
}
