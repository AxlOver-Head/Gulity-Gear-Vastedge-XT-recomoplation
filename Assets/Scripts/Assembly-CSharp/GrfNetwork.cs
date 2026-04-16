using System.Collections;
using System.Text;
using UnityEngine;

public class GrfNetwork : MonoBehaviour
{
	private struct Timeout
	{
		public float timer;

		public float sec;

		public bool active;
	}

	public const int None = 0;

	public const int OK = 1;

	public const int NG = -1;

	public const int NG_timeout = -2;

	public const int NG_kengai = -3;

	private const int TYPE_none = 0;

	private const int TYPE_form = 1;

	private const int TYPE_byte = 2;

	private WWW _www;

	private string _url;

	private GameObject _targetScript;

	private string _method;

	private WWWForm _form;

	private int _status;

	private bool _connecting;

	private string _error = string.Empty;

	private Timeout _timeout;

	private byte[] _buffer;

	private int _type;

	private byte[] _recvBuffer;

	private bool _debugSendDump;

	private bool _debugSendText;

	private bool _debugRecvDump;

	private bool _debugRecvText;

	private int _tag = -1;

	private AndroidJavaObject _webView;

	private bool _https;

	private void Awake()
	{
		clear();
	}

private void Update()
{
	// Legacy WWW timeout check
	if (_connecting && _www != null && _timeout.active)
	{
		_timeout.timer += Time.deltaTime;
		if (_timeout.timer >= _timeout.sec)
		{
			_error = string.Empty;
			_status = -2;
			callBack();
			disconnect();
			_timeout.active = false;
		}
	}

	// HTTPS check - ensure _webView exists
	if (_webView == null || !_https)
	{
		return;
	}

	// Safe call to Java plugin with null handling
	string text = null;
	try
	{
		text = _webView.CallStatic<string>("getBuffer", new object[0]);
	}
	catch (System.Exception ex)
	{
		Debug.LogError($"GrfNetwork: Failed to get buffer from webView: {ex.Message}");
		_status = -2;
		_timeout.active = false;
		_https = false;
		callBack();
		return;
	}

	// Null/empty check for text
	if (text == null)
	{
		text = string.Empty;
	}

	if (_debugRecvText && text.Length > 0)
	{
		Debug.Log($"[RECV] {text}");
	}

	if (_timeout.active)
	{
		_timeout.timer += Time.deltaTime;
		if (_timeout.timer >= _timeout.sec)
		{
			_error = string.Empty;
			_status = -2;
			callBack();
			_timeout.active = false;
			_https = false;
		}
		else if (text.Length > 0)
		{
			try
			{
				_recvBuffer = GrfUtility.stringToByte(text);
				_status = 1;
				callBack();
				_timeout.active = false;
				_https = false;
			}
			catch (System.Exception ex)
			{
				Debug.LogError($"GrfNetwork: Failed to convert string to byte: {ex.Message}");
				_status = -2;
				_timeout.active = false;
				_https = false;
				callBack();
			}
		}
	}
}

	public void clear()
	{
		_timeout.active = false;
		_timeout.timer = 0f;
		_timeout.sec = 0f;
	}

	public bool connect(string url, float sec = 0f)
	{
		_type = 0;
		_form = null;
		_buffer = null;
		return connectSub(url, null, null, sec);
	}

	public bool connect(string url, GameObject targetScript, string method, float sec = 40f)
	{
		_type = 0;
		_form = null;
		_buffer = null;
		return connectSub(url, targetScript, method, sec);
	}

	public bool connectByte(string url, GameObject targetScript, string method, byte[] b, float sec = 40f)
	{
		_type = 2;
		_form = null;
		_buffer = b;
		return connectSub(url, targetScript, method, sec);
	}

	public bool connectForm(string url, GameObject targetScript, string method, WWWForm form, float sec = 40f)
	{
		_type = 1;
		_form = form;
		_buffer = null;
		return connectSub(url, targetScript, method, sec);
	}

	private bool connectSub(string url, GameObject targetScript, string method, float sec)
	{
		_url = url;
		_targetScript = targetScript;
		_method = method;
		_status = 0;
		_error = string.Empty;
		_timeout.active = false;
		_timeout.timer = 0f;
		_recvBuffer = null;
		if (sec > 0f)
		{
			_timeout.active = true;
			_timeout.sec = sec;
		}
		_https = false;
		disconnect();
		if (!GrfNetUtility.isNetwork())
		{
			_status = -3;
			_timeout.active = false;
			callBack();
			return false;
		}
		_connecting = true;
		if (url.StartsWith("http://"))
		{
			StartCoroutine("connecting");
		}
		if (url.StartsWith("https://"))
		{
			_https = true;
			StartCoroutine("connecting2");
		}
		return true;
	}

	private IEnumerator connecting2()
	{
		if (_webView == null)
		{
			_webView = new AndroidJavaObject("jp.giraffe.plugin.HttpPlugin");
		}
		if (_debugSendText || _debugSendDump)
		{
		}
		if (_debugSendText)
		{
			switch (_type)
			{
			case 1:
				debugSendText(_form.data);
				break;
			case 2:
				debugSendText(_buffer);
				break;
			}
		}
		if (_debugSendDump)
		{
			switch (_type)
			{
			case 1:
				debugSendDump(_form.data);
				break;
			case 2:
				debugSendDump(_buffer);
				break;
			}
		}
		_webView.CallStatic("clearBuffer");
		_webView.CallStatic("conn", _url, Encoding.UTF8.GetString(_form.data));
		yield return 0;
	}

	public void disconnect()
	{
		if (_www != null)
		{
			_www.Dispose();
			_www = null;
		}
		_connecting = false;
		_status = 0;
		_webView = null;
	}

	private IEnumerator connecting()
	{
		switch (_type)
		{
		case 0:
			_www = new WWW(_url);
			break;
		case 1:
			_www = new WWW(_url, _form);
			break;
		case 2:
			_www = new WWW(_url, _buffer);
			break;
		}
		if (_debugSendText || _debugSendDump)
		{
		}
		if (_debugSendText)
		{
			switch (_type)
			{
			case 1:
				debugSendText(_form.data);
				break;
			case 2:
				debugSendText(_buffer);
				break;
			}
		}
		if (_debugSendDump)
		{
			switch (_type)
			{
			case 1:
				debugSendDump(_form.data);
				break;
			case 2:
				debugSendDump(_buffer);
				break;
			}
		}
		yield return _www;
		_timeout.active = false;
		if (_www != null)
		{
			if (_www.error != null)
			{
				_error = _www.error;
				_status = -1;
			}
			else
			{
				_error = _www.error;
				_status = 1;
			}
			_recvBuffer = _www.bytes;
			_www.Dispose();
			_www = null;
			if (_debugRecvText)
			{
				debugRecvText();
			}
			if (_debugRecvDump)
			{
				debugRecvDump();
			}
			callBack();
			_tag = -1;
		}
	}

	private void callBack()
	{
		if (_targetScript != null && _method != null)
		{
			_targetScript.SendMessage(_method);
		}
	}

	public void setTag(int tag)
	{
		_tag = tag;
	}

	public void setSendPrint(bool text, bool dump)
	{
		_debugSendDump = dump;
		_debugSendText = text;
	}

	public void setRecvPrint(bool text, bool dump)
	{
		_debugRecvDump = dump;
		_debugRecvText = text;
	}

	public byte[] getRecvBuffer()
	{
		return _recvBuffer;
	}

	public int getRecvSize()
	{
		return _recvBuffer.Length;
	}

	public string textUTF8()
	{
		return Encoding.UTF8.GetString(_recvBuffer);
	}

	public int getStatus()
	{
		return _status;
	}

	public string getStatusString()
	{
		switch (_status)
		{
		case 0:
			return "None";
		case 1:
			return "OK";
		case -1:
			return "NG";
		case -2:
			return "NG_timeout";
		case -3:
			return "NG_kengai";
		default:
			return "?";
		}
	}

	public string getLastError()
	{
		return _error;
	}

	public int getTag()
	{
		return _tag;
	}

	private void debugSendDump(byte[] b)
	{
		string text = "[SEND]size=" + b.Length + ", tag=" + _tag + ", dump\n";
		GrfUtility.dump(256, b, text);
	}

	private void debugSendText(byte[] b)
	{
	}

	private void debugRecvDump()
	{
		string text = "[RECV]size=" + getRecvSize() + ", tag=" + _tag + ", dump\n";
		GrfUtility.dump(1024, getRecvBuffer(), text);
	}

	private void debugRecvText()
	{
	}
}
