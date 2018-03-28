using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour {

	public bool tutorial = false;
	public GameObject tutorial_good;
	public GameObject deleteMessage;

	public GameObject gameclear;
	public GameObject gameplaying;
	GameObject player;
	GameObject touch;

	void Start () {
		player = GameObject.Find ("Player/Player") as GameObject;
		touch = GameObject.Find ("Touch") as GameObject;
	}

	public void OnTriggerEnter (Collider col) {

		if (col.gameObject.tag == "Player") {
			player.GetComponent<Player>().PlayerStop();
			player.layer = LayerMask.NameToLayer("Object");
			touch.GetComponent<MousePosition>().GameFinish();
			gameplaying.SetActive(false);
			if (tutorial) {
				Destroy (deleteMessage);
				tutorial_good.SetActive(true);
			} else {
				gameclear.SetActive(true);
			}
		}
	}
}
