using UnityEngine;
using System.Collections;

public class Gage : MonoBehaviour {
	/*	public  bool pause = false;

	public int gageLine = 600;
	public int substcleGage = 3;
	int substclegage;

	public int damage = 300;
	public int heal = 150;

	GameObject touch;

	void Start () {
		touch = GameObject.Find ("Touch") as GameObject;
		substclegage = substcleGage;
	}

	public void Update () {
		if (pause) {
			return;
		} else {
			if (Input.GetMouseButton (0)) {
				gageLine -= substclegage;
			}
			RectTransform rt = gameObject.GetComponent<RectTransform> ();
			rt.sizeDelta = new Vector2 (gageLine, 75);
			if (gageLine <= 0) {
				touch.GetComponent<MousePosition> ().CannotWrite ();
				gageLine = 0;
				substclegage = 0;
			} else if (gageLine > 0){
				touch.GetComponent<MousePosition> ().CanWrite ();
				substclegage = substcleGage;
			}
			if (gageLine >= 600) {
				gageLine = 600;
			}
		}
	}

	public void Damaged () {
		gageLine -= damage;
	}

	public void Heal () {
		gageLine += heal;
	}

	public void Pause_OFF() {
		pause = false;
	}

	public void Pause_ON() {
		pause = true;
	}*/
}
