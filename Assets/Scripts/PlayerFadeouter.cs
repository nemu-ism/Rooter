using UnityEngine;
using System.Collections;

public class PlayerFadeouter : MonoBehaviour {
	float substcl = 2f;
	float gage = 600f;
	float gageM;
	float alpha;
	tk2dSprite spRenderer;

	GameObject player;
	GameObject touch;
	public GameObject gameOver;
	int damage = 300;
	int heal = 300;

	void Start () {
		gageM = gage;
		spRenderer = GetComponent<tk2dSprite> ();

		player = GameObject.Find ("Player/Player") as GameObject;
		touch = GameObject.Find ("Touch") as GameObject;
	}

	void Update () {
		alpha = gage / gageM;
		var color = spRenderer.color;
		color.a = alpha;
		spRenderer.color = color;
		Debug.Log (alpha);

		if (alpha <= 0) {
			alpha = 0;
			substcl = 0;
			player.GetComponent<Player>().PlayerStop();
			gameOver.SetActive(true);
			Destroy(player.gameObject);
			touch.GetComponent<MousePosition>().CannotWrite();
		}
		
		if (alpha > 1) {
			alpha = 1;
		}
	}

	public void Drawing() {
		gage -= substcl;
	}

	public void Damaged () {
		gage -= damage;
	}
	
	public void Heal () {
		gage += heal;
	}
}
