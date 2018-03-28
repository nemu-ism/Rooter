using UnityEngine;
using System.Collections;

public class GroundChecker : MonoBehaviour {

	public GameObject gameobject;

	void Start () {
	
	}
	/*
	public void FixedUpdate() {
		Vector3 dwn = transform.TransformDirection (Vector3.down);
		if (!Physics.Raycast(transform.position, dwn, 1)) {
			gameobject.GetComponent<Enemy>().Turn();
		}
	}*/
}
