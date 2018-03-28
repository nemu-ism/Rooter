using UnityEngine;
using System.Collections;

public class PlayerAnimator : MonoBehaviour {

	Animator animator;
	int walk;

	void Start () {
		animator = GetComponent<Animator>();
		walk = Animator.StringToHash ("Bool");
	}

	public void Walking  () {
		animator.SetBool (walk, true);
	}

	public void Idling () {
		animator.SetBool (walk, false);
	}
}
