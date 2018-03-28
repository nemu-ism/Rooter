using UnityEngine;
using System.Collections;

public class DeadLine : MonoBehaviour {

	public bool tutorial = false;
	public GameObject tutorial_bad;
	public GameObject deleteMessage;

	public GameObject gameover;
	public GameObject gameplaying;
	GameObject player;
	GameObject touch;
	
	void Start () {
		player = GameObject.Find ("Player/Player") as GameObject;
		touch = GameObject.Find ("Touch") as GameObject;
	}

	void OnCollisionEnter(Collision col) {
		if (col.gameObject.tag == "Player") {
			player.GetComponent<Player> ().PlayerStop ();
			touch.GetComponent<MousePosition> ().GameFinish ();
			Gameover ();
		}
		if (col.gameObject.tag == "Enemy") {
			Destroy(col.gameObject);
		}
	}

	public void Gameover () {
		Destroy (player.gameObject);
		gameplaying.SetActive (false);
		if (tutorial) {
			Destroy (deleteMessage);
			tutorial_bad.SetActive (true);
		} else {
			gameover.SetActive (true);
		}
	}
}
