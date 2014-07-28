using UnityEngine;
using System.Collections;

public class KeyScript : MonoBehaviour {

	public Transform treasure; // WHICH DOOR? ASSIGN IN UNITY INSPECTOR
	public Transform myKeyText;
	
	// You will need a trigger-collider on this object
	void OnTriggerEnter ( ) {		

		//add the key
		treasure.GetComponent<treasure>().hasKey = true;

		//inform the user that they picked up the key
		myKeyText.GetComponent<MeshRenderer>().enabled = true;
			
	}

	void OnTriggerStay()
	{
		GetComponent<Transform>().position += Vector3.down * Time.deltaTime;
	}

	//performs actions upon exiting trigger box
	void OnTriggerExit()
	{
		//hide the text
		myKeyText.GetComponent<MeshRenderer>().enabled = false;

		// destroy key because we picked it up
		Destroy ( gameObject );
	}


}