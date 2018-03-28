using UnityEngine;
using System.Collections;

public class MousePosition : MonoBehaviour {
	public bool tutorial = false;

	Vector3 position_mouse;

	Vector3 screenToWorldPosition;

	public GameObject footing;
	GameObject gage;

	bool gameover;

	bool canWrite;
	
	void Start () {
		gage = GameObject.Find ("Player/Player/Body") as GameObject;
		gameover = false;
		canWrite = true;
		//GetComponent<TrailRenderer> ().enabled = false;
		if (tutorial) {
			CannotWrite();
		}
	}

	public void Update () {
		if (!gameover) {
			//Application.targetFrameRate = 600;
			position_mouse = Input.mousePosition;
			position_mouse.z = 10f;
			screenToWorldPosition = Camera.main.ScreenToWorldPoint (position_mouse);
			gameObject.transform.position = screenToWorldPosition;

			if (Input.GetMouseButton (0)) {
				Ray ray = Camera.main.ScreenPointToRay(position_mouse);
				RaycastHit hit;
				if (canWrite) {
					if (Physics.Raycast(ray, out hit, 1 << 8)) {
						if (hit.transform.gameObject.tag == "Background"  || hit.transform.gameObject.tag == "Ground" && hit.transform.gameObject.tag != "UI") {
							//GetComponent<TrailRenderer>().enabled = true;
							Gen_Object (Input.mousePosition);
							gage.GetComponent<PlayerFadeouter>().Drawing();
						}
					}
				}
			}
			if (Input.GetMouseButtonUp (0)) {
				//GetComponent<TrailRenderer>().enabled = false;
			}
		}
	}

	void Gen_Object (Vector3 clickPosition){
		clickPosition.z = 10f;
		Instantiate (footing, Camera.main.ScreenToWorldPoint(clickPosition), footing.transform.rotation);
	}

	public void CannotWrite () {
		canWrite = false;
	}

	public void CanWrite () {
		canWrite = true;
	}

	public void GameFinish () {
		gameover = true;
	}

	public void GameStart () {
		gameover = false;
	}
}
