using UnityEngine;
using System.Collections;

public class invisibleWall : MonoBehaviour {

	//create variables
	public Transform myWallText;
	
	// You will need a trigger-collider on this object
	void OnTriggerEnter ( ) {		

			myWallText.GetComponent<MeshRenderer>().enabled = true;
		myWallText.GetComponent<TextMesh>().text = "Every man's life ends the same way. It is only the " +
			"details\n of how he lived and how he died that distinguish one man from another." +
			"\n -- Ernest Hemingway";
		
	}
	//thing to do when we leave trigger box
	void OnTriggerExit()
	{
		//hide the text that we just showed
		myWallText.GetComponent<MeshRenderer>().enabled = false;
	}
	
	
}