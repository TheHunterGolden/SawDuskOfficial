using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class makeWood : VRTK_InteractableObject {

	Animator animator;

	public GameObject wood;

	// Use this for initialization

	void Start () {
		animator = GetComponent<Animator> ();
		animator.enabled = true;
	}

	public override void StartUsing(GameObject usingObject)
	{
		base.StartUsing(usingObject);
		animator.SetBool ("isClicked", true);
		dropWood();
		animator.SetBool("isClicked", false);
	}

	public void dropWood(){
		Instantiate (wood, new Vector3(0, 4, 8), Quaternion.identity);
	}
	


}
