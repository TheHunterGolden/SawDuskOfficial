using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;
using VRTK.GrabAttachMechanics;
using VRTK.SecondaryControllerGrabActions;

public class Wood : MonoBehaviour {

	// Use this for initialization
	public GameObject empty;
	public GameObject emptyInScene;

	public GameObject leftCont;

	public bool runOnce;

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

				/*if  ((target.gameObject.transform.parent == null) && (gameObject.transform.parent == null))
					//((target.gameObject.transform.parent.tag.Equals ("empty") && gameObject.transform.parent.tag.Equals ("empty")) || (!(target.gameObject.transform.parent.tag.Equals ("empty")) && !(gameObject.transform.parent.tag.Equals ("empty"))))
				{
					
					emptyInScene = Instantiate (empty);
					emptyInScene.AddComponent<VRTK_InteractableObject>();
					emptyInScene.GetComponent<VRTK_InteractableObject> ().disableWhenIdle = false;
					emptyInScene.GetComponent<VRTK_InteractableObject> ().enabled = true;
					emptyInScene.GetComponent<VRTK_InteractableObject>().isGrabbable = true;

					//GameObject.Find ("leftcont").GetComponent<VRTK_InteractGrab> ().ForceRelease();
					//GameObject.Find ("rightcont").GetComponent<VRTK_InteractGrab> ().ForceRelease();

					gameObject.GetComponent<VRTK_InteractableObject> ().ForceStopInteracting ();
					target.gameObject.GetComponent<VRTK_InteractableObject> ().ForceStopInteracting ();


					Destroy (target.gameObject.GetComponent<VRTK_FixedJointGrabAttach>());
					Destroy (target.gameObject.GetComponent<FixedJoint>());
					Destroy (target.gameObject.GetComponent<VRTK_InteractControllerAppearance>());
					Destroy (target.gameObject.GetComponent<VRTK_SwapControllerGrabAction>());
					//Destroy (target.gameObject.GetComponent<VRTK_InteractableObject>()); 
				

					Destroy (gameObject.GetComponent<VRTK_FixedJointGrabAttach>());
					Destroy (gameObject.GetComponent<FixedJoint>());
					Destroy (gameObject.GetComponent<VRTK_InteractControllerAppearance>());
					Destroy (gameObject.GetComponent<VRTK_SwapControllerGrabAction>()); 
					//Destroy (gameObject.GetComponent<VRTK_InteractableObject>());


					target.gameObject.GetComponent<VRTK_InteractableObject>().isGrabbable = false;
					gameObject.GetComponent<VRTK_InteractableObject>().isGrabbable = false;

					Destroy(target.gameObject.GetComponent<Rigidbody>());
					Destroy(gameObject.GetComponent<Rigidbody>());

					target.gameObject.transform.SetParent(emptyInScene.transform); //sticks both wood objects together


					gameObject.transform.SetParent(emptyInScene.transform);
					if (runOnce == true) {
						Debug.Log ("runonce");
					}
					runOnce = true;


			
				}
				/*else if (target.gameObject.transform.parent.tag.Equals ("empty")) {
					//gameObject.transform.SetParent(target.gameObject.transform.parent); 

					//Destroy(gameObject.GetComponent<Rigidbody>());
				}
				else if (gameObject.transform.parent.tag.Equals ("empty")){
					//target.gameObject.transform.SetParent(gameObject.transform.parent); 
					//Destroy(target.gameObject.GetComponent<Rigidbody>());
					} */
			
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

			}

		}

	}
}



