using UnityEngine;
using System.Collections;

public class PauseManager : MonoBehaviour {

	GameObject gage;
	GameObject mouse;
	public GameObject pause;
	public GameObject gameplaying;

	void Start () {
		gage = GameObject.Find ("Player/Player/Body") as GameObject;
		mouse = GameObject.Find ("Touch") as GameObject;
	}

	public void Pause () {
		if (Time.timeScale == 0) {
			mouse.GetComponent<MousePosition>().CanWrite();
			pause.SetActive(false);
			gameplaying.SetActive(true);
			Time.timeScale = 1;
		} else {
			mouse.GetComponent<MousePosition>().CannotWrite();
			pause.SetActive(true);
			gameplaying.SetActive(false);
			Time.timeScale = 0;
		}
	}
}
