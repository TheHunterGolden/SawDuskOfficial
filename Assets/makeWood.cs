using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class makeWood : MonoBehaviour{

			public GameObject leftController;
			public GameObject rightController;
			public GameObject toClone;
			public Transform dispenseLocation;
		public bool woodDispensed;
	public GameObject ball;
		


			private void Start()
	{			
		woodDispensed = false;

				
				
			}
		
	public void Update(){
		GameObject leftTouched;
		GameObject rightTouched;
		leftTouched = leftController.GetComponent<VRTK_InteractTouch> ().GetTouchedObject ();
		rightTouched = rightController.GetComponent<VRTK_InteractTouch> ().GetTouchedObject ();
		Debug.Log ("touched");
		if (leftTouched || rightTouched == ball) {
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
	



