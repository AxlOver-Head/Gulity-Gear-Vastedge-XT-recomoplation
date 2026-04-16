using UnityEngine;

public class Machine : MonoBehaviour
{
	public enum _MACHINE_STATE
	{
		OPEN = 0,
		DEMO = 1,
		NORMAL = 2,
		BONUS = 3,
		ART = 4,
		MAX = 5
	}

	private const float REEL_UPDATE = 0.04f;

	private const float ONE_GAME_TIME = 4.1f;

	private const int LAMP_PATTERN_MAX = 4;

	private static Vector2[] demoEkisyoUv = new Vector2[4]
	{
		new Vector2(0.46348524f, 0.79687625f),
		new Vector2(0.5991324f, 0.8654471f),
		new Vector2(0.5991324f, 0.79687625f),
		new Vector2(0.46348524f, 0.8654471f)
	};

	private static Vector2[] normalEkisyoUv = new Vector2[4]
	{
		new Vector2(0.31898654f, 0.79687625f),
		new Vector2(0.4546337f, 0.8654471f),
		new Vector2(0.4546337f, 0.79687625f),
		new Vector2(0.31898654f, 0.8654471f)
	};

	private static Vector2[] artEkisyoUv = new Vector2[4]
	{
		new Vector2(0.31898654f, 0.722056f),
		new Vector2(0.4546337f, 0.7906268f),
		new Vector2(0.4546337f, 0.722056f),
		new Vector2(0.31898654f, 0.7906268f)
	};

	private static Vector2[] bnsEkisyoUv = new Vector2[4]
	{
		new Vector2(0.46324232f, 0.722056f),
		new Vector2(0.5988895f, 0.7906268f),
		new Vector2(0.5988895f, 0.722056f),
		new Vector2(0.46324232f, 0.7906268f)
	};

	private static Vector2[] reelSevenUv = new Vector2[12]
	{
		new Vector2(0.1059344f, 0.6814119f),
		new Vector2(0.28379732f, 0.68742347f),
		new Vector2(0.28379732f, 0.6814119f),
		new Vector2(0.1059344f, 0.68742347f),
		new Vector2(0.1059344f, 0.6609066f),
		new Vector2(0.28379732f, 0.6609066f),
		new Vector2(0.1059344f, 0.6379163f),
		new Vector2(0.28379732f, 0.6379163f),
		new Vector2(0.1059344f, 0.615332f),
		new Vector2(0.28379732f, 0.615332f),
		new Vector2(0.1059344f, 0.6093238f),
		new Vector2(0.28379732f, 0.6093238f)
	};

	private static Vector2[] reelRev1Uv = new Vector2[12]
	{
		new Vector2(0.1059344f, 0.5989936f),
		new Vector2(0.28379732f, 0.60500515f),
		new Vector2(0.28379732f, 0.5989936f),
		new Vector2(0.1059344f, 0.60500515f),
		new Vector2(0.1059344f, 0.5784883f),
		new Vector2(0.28379732f, 0.5784883f),
		new Vector2(0.1059344f, 0.555498f),
		new Vector2(0.28379732f, 0.555498f),
		new Vector2(0.1059344f, 0.5329137f),
		new Vector2(0.28379732f, 0.5329137f),
		new Vector2(0.1059344f, 0.5269055f),
		new Vector2(0.28379732f, 0.5269055f)
	};

	private static Vector2[] reelRev2Uv = new Vector2[12]
	{
		new Vector2(0.1059344f, 0.518149f),
		new Vector2(0.28379732f, 0.52416056f),
		new Vector2(0.28379732f, 0.518149f),
		new Vector2(0.1059344f, 0.52416056f),
		new Vector2(0.1059344f, 0.49764374f),
		new Vector2(0.28379732f, 0.49764374f),
		new Vector2(0.1059344f, 0.47465345f),
		new Vector2(0.28379732f, 0.47465345f),
		new Vector2(0.1059344f, 0.45206913f),
		new Vector2(0.28379732f, 0.45206913f),
		new Vector2(0.1059344f, 0.44606093f),
		new Vector2(0.28379732f, 0.44606093f)
	};

	private static Vector2[] reelNone1Uv = new Vector2[12]
	{
		new Vector2(0.1059344f, 0.43646005f),
		new Vector2(0.28379732f, 0.4424716f),
		new Vector2(0.28379732f, 0.43646005f),
		new Vector2(0.1059344f, 0.4424716f),
		new Vector2(0.1059344f, 0.41595474f),
		new Vector2(0.28379732f, 0.41595474f),
		new Vector2(0.1059344f, 0.39296445f),
		new Vector2(0.28379732f, 0.39296445f),
		new Vector2(0.1059344f, 0.37038013f),
		new Vector2(0.28379732f, 0.37038013f),
		new Vector2(0.1059344f, 0.36437193f),
		new Vector2(0.28379732f, 0.36437193f)
	};

	private static Vector2[] reelNone2Uv = new Vector2[12]
	{
		new Vector2(0.1059344f, 0.35403585f),
		new Vector2(0.28379732f, 0.3600474f),
		new Vector2(0.28379732f, 0.35403585f),
		new Vector2(0.1059344f, 0.3600474f),
		new Vector2(0.1059344f, 0.33353055f),
		new Vector2(0.28379732f, 0.33353055f),
		new Vector2(0.1059344f, 0.31054026f),
		new Vector2(0.28379732f, 0.31054026f),
		new Vector2(0.1059344f, 0.28795594f),
		new Vector2(0.28379732f, 0.28795594f),
		new Vector2(0.1059344f, 0.28194773f),
		new Vector2(0.28379732f, 0.28194773f)
	};

	private bool SpinReel;

	private float reelTime;

	private float lampTime;

	private int sqcIndex;

	private GameObject machine;

	private GameObject machineLed;

	private Material ledMaterial;

	private MeshFilter screenMesh;

	private MeshFilter reelMesh;

	private _MACHINE_STATE machineStat;

	private simpleRot machineRot;

	private _MACHINE_STATE machineState;

	private ledDatas lampData;

	private bool isInit;

	private simpleRot rot;

	private static GameObject[] lampObj = new GameObject[4];

	private void Awake()
	{
	}

	private void Start()
	{
		SpinReel = false;
	}

	public void init(GameObject obj)
	{
		Shader shader = Shader.Find("Giraffe/UnlitFade");
		Transform[] componentsInChildren = obj.GetComponentsInChildren<Transform>();
		Transform[] array = componentsInChildren;
		foreach (Transform transform in array)
		{
			if (transform.gameObject.name == "LED")
			{
				machineLed = transform.gameObject;
			}
			else if (transform.gameObject.name == "ekishou")
			{
				screenMesh = transform.gameObject.GetComponent<MeshFilter>();
			}
			else if (transform.gameObject.name == "reel")
			{
				reelMesh = transform.gameObject.GetComponent<MeshFilter>();
			}
		}
		ledMaterial = new Material(shader);
		ledMaterial.mainTexture = (Texture2D)Resources.Load("Texture/LED0");
		machineLed.GetComponent<Renderer>().sharedMaterial = ledMaterial;
		for (int j = 0; j < 4; j++)
		{
			if (lampObj[j] == null)
			{
				lampObj[j] = (GameObject)Object.Instantiate(Resources.Load("Prefab/HallLamp/lamp" + j));
				lampObj[j].name = "lamp" + (j + 1);
			}
		}
		lampData = lampObj[0].GetComponent<ledDatas>();
		rot = base.gameObject.AddComponent<simpleRot>();
		isInit = true;
	}

	private void Update()
	{
		if (isInit)
		{
			changeReelRev();
			chengeLamp();
		}
	}

	private void OnDestroy()
	{
		for (int i = 0; i < lampObj.Length; i++)
		{
			if (lampObj[i] != null)
			{
				Object.Destroy(lampObj[i]);
				lampObj[i] = null;
			}
		}
		if ((bool)ledMaterial)
		{
			ledMaterial = null;
		}
	}

	public void setMachineState(int state)
	{
		switch ((_MACHINE_STATE)state)
		{
		default:
			return;
		case _MACHINE_STATE.NORMAL:
			screenMesh.mesh.uv = normalEkisyoUv;
			lampData = lampObj[1].GetComponent<ledDatas>();
			break;
		case _MACHINE_STATE.DEMO:
			reelMesh.mesh.uv = ((!(Random.value < 0.5f)) ? reelNone2Uv : reelNone1Uv);
			screenMesh.mesh.uv = demoEkisyoUv;
			lampData = lampObj[0].GetComponent<ledDatas>();
			break;
		case _MACHINE_STATE.BONUS:
			screenMesh.mesh.uv = bnsEkisyoUv;
			lampData = lampObj[3].GetComponent<ledDatas>();
			break;
		case _MACHINE_STATE.ART:
			screenMesh.mesh.uv = artEkisyoUv;
			lampData = lampObj[2].GetComponent<ledDatas>();
			break;
		case _MACHINE_STATE.OPEN:
			screenMesh.mesh.uv = demoEkisyoUv;
			reelMesh.mesh.uv = reelSevenUv;
			break;
		}
		sqcIndex = 0;
		machineState = (_MACHINE_STATE)state;
	}

	public int updateRot()
	{
		if (machineState != _MACHINE_STATE.DEMO && machineState != _MACHINE_STATE.OPEN)
		{
			rot.Game();
			int mode = rot.getMode();
			if (machineState != (_MACHINE_STATE)mode)
			{
				setMachineState(mode);
			}
			return mode;
		}
		return (int)machineState;
	}

	public int getStatus()
	{
		return (int)machineState;
	}

	private void chengeLamp()
	{
		lampTime += GGLRealTimeClock.deltaTime;
		AnimationCurve anim = lampData.data[sqcIndex].anim;
		if (anim == null)
		{
			return;
		}
		ledMaterial.mainTexture = lampData.data[sqcIndex].tex;
		machineLed.GetComponent<Renderer>().sharedMaterial = ledMaterial;
		if (lampData.data[sqcIndex + 1].anim != null)
		{
			ledMaterial.SetTexture("_Texture2", lampData.data[sqcIndex + 1].tex);
		}
		float value = anim.Evaluate(lampTime);
		ledMaterial.SetFloat("_Blend", value);
		if (anim.length > 0 && anim.keys[anim.length - 1].time < lampTime)
		{
			lampTime = 0f;
			sqcIndex++;
			if (anim == null || sqcIndex >= lampData.data.Length - 1)
			{
				sqcIndex = 0;
			}
		}
	}

	private void changeReelRev()
	{
		reelTime += GGLRealTimeClock.deltaTime;
		if (!(reelTime > 0.04f))
		{
			return;
		}
		reelTime = 0f;
		if (machineState != _MACHINE_STATE.DEMO && machineState != _MACHINE_STATE.OPEN)
		{
			if (SpinReel)
			{
				reelMesh.mesh.uv = reelRev1Uv;
			}
			else
			{
				reelMesh.mesh.uv = reelRev2Uv;
			}
			SpinReel = !SpinReel;
		}
	}

	public int getPay()
	{
		return rot.getPay();
	}

	public void setSettei(int settei, bool recv)
	{
		rot.setSettei(settei, recv);
	}

	public void setMachineData(MachineData backUp)
	{
		rot.setMachineData(backUp);
	}
}
