using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {

	public bool tutorial = false;

	GameObject gage;
	
	void Start () {
		gage = GameObject.Find ("Player/Player/Body") as GameObject;
	}

	void Update () {

	}

	void OnTriggerEnter (Collider col) {
		if (col.gameObject.tag == "Player") {
			Destroy(gameObject);
			gage.GetComponent<PlayerFadeouter>().Heal();
		}
	}
}
