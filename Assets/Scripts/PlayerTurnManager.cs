using UnityEngine;
using System.Collections;

public class PlayerTurnManager: MonoBehaviour {

	GameObject player;

	bool pause = false;

	void Start () {
		player = GameObject.Find ("Player/Player") as GameObject;
	}

	public void Turn () {
		if (!pause) {
			player.GetComponent<Player> ().Turn ();
			transform.Rotate (new Vector3 (0, 0, 180));
		}
	}

	public void Pause_ON () {
		pause = true;
	}

	public void Pause_OFF () {
		pause = false;
	}
}
