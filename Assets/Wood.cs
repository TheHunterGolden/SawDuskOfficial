using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wood : MonoBehaviour {

	// Use this for initialization
	public GameObject empty;
	public bool isSticky;
	void Start () {
		isSticky = false;
	}

	// Update is called once per frame
	void Update () {

	}

	public void makeSticky(){
		isSticky = true;
		//Debug.Log("is this happening?");
	}
	//calls to make wood sticky or not sticky (might need to set a timer to see how long things are sticky)
	

	void OnCollisionEnter (Collision target) { 
		if (target.gameObject.tag.Equals ("wood") == true) { 
			//if this wood is sticky or the other wood object is sticky, connect
			if (target.gameObject.GetComponent<Wood>().isSticky || this.isSticky){
				Debug.Log("stuck");
				//target.gameObject.transform.SetParent(empty.transform); //sticks both wood objects together
				//gameObject.transform.SetParent(empty.transform);
				ConfigurableJoint joint = gameObject.AddComponent<ConfigurableJoint>();
				joint.angularXMotion = ConfigurableJointMotion.Locked;
				joint.angularYMotion = ConfigurableJointMotion.Locked;
				joint.angularZMotion = ConfigurableJointMotion.Locked;
				joint.xMotion = ConfigurableJointMotion.Locked;
				joint.yMotion = ConfigurableJointMotion.Locked;
				joint.zMotion = ConfigurableJointMotion.Locked;
				joint.projectionMode =JointProjectionMode.PositionAndRotation;

				joint.connectedBody = target.gameObject.GetComponent<Rigidbody>();
				makeSticky();
				//chainLink.GetComponentInChildren<Animation>().Play("Take 001"); //turns on the fan animation

			}

		}

	}
}



