﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//check inspector 
public class InteractableGlue : VRTK.VRTK_InteractableObject {

	public GameObject chainObj;
	public GameObject chainLink;
	public GameObject fanObj;
	public GameObject apObj;

	 private GameObject glueParticles;
		
     private float glueLife = 5f;

	void Awake()
	{
		
	}
	
	public override void StartUsing(GameObject usingObject)
        {
            base.StartUsing(usingObject);
            startGluing();
        }

        
		//not sure what this does, see Gun.cs for reference
        protected void Start()
        {
            glueParticles = transform.Find("glueParticles").gameObject;
            glueParticles.SetActive(false);
        }

		//puts the glue animation on the wood
        private void startGluing()
        {
			
            GameObject glueClone = Instantiate(glueParticles, glueParticles.transform.position, glueParticles.transform.rotation) as GameObject;
            glueClone.SetActive(true);
            Rigidbody rb = glueClone.GetComponent<Rigidbody>();
            Destroy(glueClone, glueLife);
        }
	
	void Update () { //Runs every frame
		
		
	}
	
//when the glue touches a wood object, makes it sticky
	void OnCollisionEnter (Collision target) { 
		if (target.gameObject.tag.Equals ("wood") == true) {  
			if (apObj.GetComponent<Wood>().isSticky){ 
				
				//don't think we need this in here since we aren't connecting anything, just gluing
				//gameObject.transform.SetParent (target.gameObject.transform); //THIS IS GLUE: The magnet now moves with the fan chain
				
				//whatever animation we decide for glue particles
				fanObj.GetComponentInChildren<Animation>().Play("Take 001");
			}
			else{
				apObj.GetComponent<Wood>().makeSticky(); 
				//would we want the animation to run even if the wood is already sticky?
				StartUsing(target.gameObject);

			}
		}
		
	}


}