using UnityEngine;
using System.Collections;

public class textScript : MonoBehaviour {

	//declare a character counter variable
	int characterCounter = 0;
	int coinFlip;

	// Use this for initialization
	void Start () {


	
	}
	
	// Update is called once per frame
	void Update () {


		//flip a coin
		coinFlip = Random.Range(0,10);

		//check if heads or tails
		if (coinFlip < 5)
		{
			GetComponent<TextMesh>().text += "/";

		}

		else
		{
			GetComponent<TextMesh>().text += "\\";
		}

		//increment character count
		characterCounter++;

		//check if we should add a new line
		if (characterCounter > 20)
		{
			GetComponent<TextMesh>().text += "\n";

			//reset counter
			characterCounter = 0;
		}
	
	}
}
