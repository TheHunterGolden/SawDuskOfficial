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
		animator.enabled = true;
				animator.SetBool("isClicked", false);
				
				
			}
		
	public void Update(){
		GameObject leftTouched;
		GameObject rightTouched;
		leftTouched = leftController.GetComponent<VRTK_InteractTouch> ().GetTouchedObject ();
		rightTouched = rightController.GetComponent<VRTK_InteractTouch> ().GetTouchedObject ();
		Debug.Log ("touched");
		if (leftTouched || rightTouched == gameObject) {
			handlePush();
		}
	}

		 IEnumerator handlePush()
			{
				
				Debug.Log("Pushed");
				animator.SetBool ("isClicked", true);
				GameObject newGo = (GameObject)Instantiate(toClone, dispenseLocation.position, Quaternion.identity);
				animator.SetBool ("isClicked", false);
				yield return new WaitForSeconds (1);
			}
		}
	



