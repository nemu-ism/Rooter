using UnityEngine;
using System.Collections;

public class GenedObject : MonoBehaviour {

	public float life = 3;

	void Start () {

	}

	void Update () {
		life -= Time.deltaTime;
		if (life <= 0) {
			Destroy(this.gameObject);
		}
	}
}
