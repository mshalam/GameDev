using UnityEngine;
using System.Collections;

public class treasure : MonoBehaviour {

	//create variables
	public bool hasKey = false;
	public Transform myTreasureText;
	
	// You will need a trigger-collider on this object
	void OnTriggerEnter ( ) {		

		
		//if the user has the key then let them collect the gold
		if(hasKey == true)
		{
			myTreasureText.GetComponent<MeshRenderer>().enabled = true;
			myTreasureText.GetComponent<TextMesh>().text = "You unlocked the chest!!" +
				"\nCongradulations thier is a lot of gold inside!!";
		}
		//if doesn't have the key then tell the user to go get the key
		else
		{
			myTreasureText.GetComponent<MeshRenderer>().enabled = true;
			myTreasureText.GetComponent<TextMesh>().text = "THE CHEST IS LOCKED. IT LOOKS LIKE " +
				"\n a key can open it";

		}

	}
	//thing to do when we leave trigger box
	void OnTriggerExit()
	{
		//hide the text that we just showed
		myTreasureText.GetComponent<MeshRenderer>().enabled = false;
	}


}