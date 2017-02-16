using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wood : MonoBehaviour {

	// Use this for initialization
	public GameObject chainLink;
	public bool isSticky;
	void Start () {
		isSticky = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void makeSticky(){
		isSticky = true;
	}
	//calls to make wood sticky or not sticky (might need to set a timer to see how long things are sticky)
	public void setSticky(){
		isSticky = !isSticky;
	}

	void AttachWood (Collision target) { 
		if (target.gameObject.tag.Equals ("wood") == true) { 
	    //if this wood is sticky or the other wood object is sticky, connect
			if (chainLink.GetComponent<Wood>().isSticky || this.isSticky){ 
				
				gameObject.transform.SetParent (target.gameObject.transform); //sticks both wood objects together
				
				//chainLink.GetComponentInChildren<Animation>().Play("Take 001"); //turns on the fan animation
				
			}
			
		}
		
	}
}
