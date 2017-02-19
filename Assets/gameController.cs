using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class gameController : MonoBehaviour {
	public GameObject leftController;
	public GameObject rightController;
	public Vector3 dispenseLocation;
	public bool woodDispensed1;
	public bool woodDispensed2;
	public bool woodDispensed3;
	public bool woodDispensed4;
	public GameObject wood;
	public GameObject smallWood;
	public GameObject mediumWood;
	public GameObject largeWood;
	public GameObject buttonWood;
	public GameObject buttonSmallWood;
	public GameObject buttonMediumWood;
	public GameObject buttonLargeWood;

	private void Start()
	{			
		woodDispensed1 = false;
		woodDispensed2 = false;
		woodDispensed3 = false;
		woodDispensed4 = false;
		dispenseLocation = new Vector3 (3, 10, -8);

	}

	public void Update ()
	{
		GameObject leftTouched;
		GameObject rightTouched;
		leftTouched = leftController.GetComponent<VRTK_InteractTouch> ().GetTouchedObject ();
		rightTouched = rightController.GetComponent<VRTK_InteractTouch> ().GetTouchedObject ();
		Debug.Log ("touched");
		if (leftTouched || rightTouched == buttonWood) {
			if (woodDispensed1 == false) { 
				Instantiate (wood, dispenseLocation, Quaternion.identity);
				woodDispensed1 = true;
			} 
		} else {
			woodDispensed1 = false;
		}
	
		if (leftTouched || rightTouched == buttonSmallWood) {
			if (woodDispensed2 == false) { 
				Instantiate (wood, dispenseLocation, Quaternion.identity);
				woodDispensed2 = true;
			} 
		}else {
			woodDispensed2 = false;
		}
		if (leftTouched || rightTouched == buttonMediumWood) {
			if (woodDispensed3 == false) { 
				Instantiate (wood, dispenseLocation, Quaternion.identity);
				woodDispensed3 = true;
			} 
		}else {
			woodDispensed3 = false;
		}
		if (leftTouched || rightTouched == buttonLargeWood) {
			if (woodDispensed4 == false) { 
				Instantiate (wood, dispenseLocation, Quaternion.identity);
				woodDispensed4 = true;
			} 
		}else {
			woodDispensed4 = false;
		}
				
	}
}
	
