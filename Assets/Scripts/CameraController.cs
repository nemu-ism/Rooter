using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	bool camera_switch= false;
	Vector3 offset;
	public float smooth = 1.0f;
	public GameObject player;

	private Camera cam;
	private float width = 6400f;
	private float height = 3600f;
	private float pixelPerUnit = 100f;

	public void Start() {
		offset = transform.position - player.transform.position;
	}

	public void Camera_Switch () {
		camera_switch = true;
	}

	public void FixedUpdate () {
		if (camera_switch) {
			offset.x *= -1;
			camera_switch = false;
		}

		transform.position = Vector3.Lerp (transform.position, player.transform.position + offset, smooth * Time.deltaTime);
	}

	void Awake () {
		float aspect = (float)Screen.height / (float)Screen.width;
		float bgAcpect = height / width;
		cam = GetComponent<Camera> ();
		cam.orthographicSize = (height / 2f / pixelPerUnit);
		
		
		if (bgAcpect > aspect) {
			float bgScale = height / Screen.height;
			float camWidth = width / (Screen.width * bgScale);
			cam.rect = new Rect ((1f - camWidth) / 2f, 0f, camWidth, 1f);
		} else {
			float bgScale = width / Screen.width;
			float camHeight = height / (Screen.height * bgScale);
			cam.rect = new Rect (0f, (1f - camHeight) / 2f, 1f, camHeight);
		}
	}
}
