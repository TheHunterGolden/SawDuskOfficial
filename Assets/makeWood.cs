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
		public bool woodDispensed;
		

			private void Start()
	{			
		woodDispensed = false;

		animator = GetComponent<Animator> ();
		animator.enabled = true;
				//animator.SetBool("isClicked", false);
				
				
			}
		
	public void Update(){
		GameObject leftTouched;
		GameObject rightTouched;
		leftTouched = leftController.GetComponent<VRTK_InteractTouch> ().GetTouchedObject ();
		rightTouched = rightController.GetComponent<VRTK_InteractTouch> ().GetTouchedObject ();
		Debug.Log ("touched");
		if (leftTouched || rightTouched == gameObject) {
			Debug.Log ("L or R touching");
			handlePush ();
		} else {
			woodDispensed = false;
		}
	}

	public void handlePush()
			{
				
				Debug.Log("Pushed");
		if (woodDispensed == false){ 
				//animator.SetBool ("isClicked", true);
				GameObject newGo = (GameObject)Instantiate(toClone, dispenseLocation.position, Quaternion.identity);
		woodDispensed = true;
				//animator.SetBool ("isClicked", false);
		}
				
			}
		
		}
	



