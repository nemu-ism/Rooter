using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public float speed;

	bool enemy_active;

	GameObject gage;

	void Start () {
		gage = GameObject.Find ("Player/Player/Body") as GameObject;
		enemy_active = true;
	}

	void Move (Vector3 direction) {
		GetComponent<Rigidbody> ().velocity = direction * speed;
	}

	void OnCollisionStay () {
		if (enemy_active) {
			Move (transform.right * -1);
		}
	}

	void OnTriggerEnter (Collider taged) {
		if (taged.gameObject.tag == "Edge") {
			Turn();
		}
	}

	public void Turn() {
		transform.Rotate(new Vector3(0, 1, 0), 180);
	}

	public void EnemyStop () {
		enemy_active = false;
	}

	public void EnemyStart () {
		enemy_active = true;
	}

	void OnCollisionEnter (Collision col) {
		if (col.gameObject.tag == "Player") {
			Destroy(gameObject);
			gage.GetComponent<PlayerFadeouter>().Damaged();
		}
	}
}
