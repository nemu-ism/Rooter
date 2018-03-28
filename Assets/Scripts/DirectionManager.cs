using UnityEngine;
using System.Collections;

public class DirectionManager : MonoBehaviour {
	
	void Start () {
		
	}

	void Update () {
		
	}

	public void Menu () {
		Application.LoadLevel("Menu");
		Time.timeScale = 1;
	}

	public void Stage1 () {
		Application.LoadLevel("Play1");
	}

	public void Stage2 () {
		Application.LoadLevel("Play2");
	}

	public void Stage3 () {
		Application.LoadLevel("Play3");
	}

	public void Stage4 () {
		Application.LoadLevel("Play4");
	}

	public void Stage5 () {
		Application.LoadLevel("Play5");
	}

	public void Stage6 () {
		Application.LoadLevel("Play6");
	}

	public void Stage7 () {
		Application.LoadLevel("Play7");
	}

	public void Stage8 () {
		Application.LoadLevel("Play8");
	}

	public void Stage9 () {
		Application.LoadLevel("Play9");
	}

	public void Tutorial1 () {
		Application.LoadLevel("Tutorial1");
	}

	public void Tutorial2 () {
		Application.LoadLevel("Tutorial2");
	}

	public void Prototype () {
		Application.LoadLevel ("Prototype");
	}
}
