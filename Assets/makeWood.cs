using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class makeWood : MonoBehaviour{

			public GameObject leftController;
			public GameObject rightController;
			public GameObject toClone;
			public Transform dispenseLocation;
			Animator animator;

			private void Start()
	{			animator = GetComponent<Animator> ();
				animator.SetBool("isClicked", false);
				animator.enabled = true;
				
			}
		
	private void update(){
		GameObject leftTouched;
		GameObject rightTouched;
		leftTouched = leftController.GetComponent<VRTK_InteractTouch> ().GetTouchedObject ();
		rightTouched = rightController.GetComponent<VRTK_InteractTouch> ().GetTouchedObject ();
		if (leftTouched || rightTouched == gameObject) {
			handlePush();
		}
	}

			private void handlePush()
			{
				
				Debug.Log("Pushed");
				animator.SetBool ("isClicked", true);
				GameObject newGo = (GameObject)Instantiate(toClone, dispenseLocation.position, Quaternion.identity);
				animator.SetBool ("isClicked", false);
			}
		}
	



