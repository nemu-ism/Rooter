using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float speed;
	bool player_active;

	GameObject playerAnimator;

	GameObject camera;

	void Start () {
		camera = GameObject.Find ("Player/Main Camera") as GameObject;
		playerAnimator = GameObject.Find ("Player/Player/Body") as GameObject;
		player_active = true;
	}

	void OnTriggerStay (Collider ground) {
		if (ground.gameObject.tag == "Ground") {
			if (player_active) {
				Move (transform.right * 1);
			} else {
				Move (transform.right * 0);
			}
		}
	}

	void OnTriggerEnter () {
		playerAnimator.GetComponent<PlayerAnimator> ().Walking ();
	}

	void OnTriggerExit () {
		playerAnimator.GetComponent<PlayerAnimator> ().Idling ();
	}

	void Move (Vector3 direction) {
		GetComponent<Rigidbody>().velocity = direction * speed;
	}

	public void PlayerStop () {
		player_active = false;
		playerAnimator.GetComponent<PlayerAnimator> ().Idling ();
	}

	public void PlayerStart () {
		player_active = true;
		playerAnimator.GetComponent<PlayerAnimator> ().Walking ();
	}

	public void Turn () {
		transform.Rotate (new Vector3 (0, 180, 0));
		camera.GetComponent<CameraController> ().Camera_Switch ();
	}
}
