using UnityEngine;
using System.Collections;

public class MassageManager : MonoBehaviour {

	bool pause;
	public bool tutorial1 = false;
	public bool tutorial2 = false;

	public GameObject playerTurn;
	GameObject player;
	public GameObject item;
	public GameObject enemy;
	GameObject massage;
	GameObject massage1;
	GameObject massage2;
	GameObject massage3;
	GameObject massage4;
	GameObject massage5;

	void Start () {
		player = GameObject.Find ("Player/Player") as GameObject;
		player.GetComponent<Player> ().PlayerStop ();
		playerTurn.GetComponent<PlayerTurnManager> ().Pause_ON ();
		massage = GameObject.Find ("Canvas/Massages/Massage");
		massage1 = GameObject.Find ("Canvas/Massages/Massage1");
		massage2 = GameObject.Find ("Canvas/Massages/Massage2");
		massage3 = GameObject.Find ("Canvas/Massages/Massage3");
		massage4 = GameObject.Find ("Canvas/Massages/Massage4");
		massage5 = GameObject.Find ("Canvas/Massages/Massage5");
	}

	void Update () {

	}

	public void Shift () {
		massage.SetActive (false);
		massage1.SetActive (true);
	}

	public void Shift1() {
		massage1.SetActive (false);
		massage2.SetActive (true);
	}

	public void Shift2 () {
		massage2.SetActive (false);
		Vector3 showPoint_item = new Vector3 (60f, 300.7f, 0);
		if (tutorial2) {
			Instantiate (item, showPoint_item, item.transform.rotation);
		}
		massage3.SetActive (true);
	}

	public void Shift3 () {
		massage3.SetActive (false);
		Vector3 showPoint_enemy = new Vector3 (70f, 300.7f, 0);
		if (tutorial2) {
			Instantiate (enemy, showPoint_enemy, enemy.transform.rotation);
			enemy.GetComponent<Enemy>().EnemyStop();
		}
		massage4.SetActive (true);
	}

	public void Shift4 () {
		massage4.SetActive (false);
		if (tutorial1) {
			PlayerStart ();
		}else if (tutorial2) {
			Destroy (enemy);
		}
		massage5.SetActive (true);
	}

	public void PlayerStart () {
		player.GetComponent<Player> ().PlayerStart ();
		playerTurn.GetComponent<PlayerTurnManager> ().Pause_OFF ();
	}
}
