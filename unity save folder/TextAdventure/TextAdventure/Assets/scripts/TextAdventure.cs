using UnityEngine;
using System.Collections;

public class TextAdventure : MonoBehaviour {

	//set up variables
	string currentRoom = "Cave";
	bool hasKey = false;
	bool hasSword = false;

	
	// Update is called once per frame
	void Update () {

		string textBuffer = "You are currenty in a: " + currentRoom;

		//set up te scene for the cave
		if (currentRoom == "Cave")
		{

			textBuffer += "\nShhhh!!! you see a lot of sleeping\nbats.";

			textBuffer += "\npress [W] to go through the tunnel";
			textBuffer += "\npress [S] to open the mysterious door\n with ancient markings on it.";

			//read keyboard inputs
			if (Input.GetKeyDown(KeyCode.W))
			{
				currentRoom = "Tunnel";
			}
			else if (Input.GetKeyDown(KeyCode.S))
			{
				currentRoom = "Small Room";
			}

		}

		//set up the scene for the tunnel
		else if(currentRoom == "Tunnel")
		{
			textBuffer += "\nYou approach the end of the tunnel\nand find an ancient key on top \nof a pedastool.\nYou pick up the key";
			textBuffer += "\npress [W] to go back to the cave";

			//pick u the key
			hasKey = true;

			if (Input.GetKeyDown(KeyCode.W))
			{
				currentRoom = "Cave";
			}

		}

		//set up the scene for the ancient door
		else if(currentRoom == "Small Room")
		{

			if(hasKey == false)
			{
				textBuffer += "\nThe door is locked.\nIt looks like you need a key to open it";
				textBuffer += "\npress [W] to go back to the cave";
			}
			else
			{
				textBuffer += "\nYou use the Ancient Key to open \nthe Mysterious door";
				textBuffer += "\nYou see a small room with a \nwooden door and a gold gate leading out of it";
				textBuffer += "\npress [W] to go back to the cave";
				textBuffer += "\npress [S] to go through the wooden door";
				textBuffer += "\npress [A] to go through the gold gate";

			}

			if (Input.GetKeyDown(KeyCode.W))
			{
				currentRoom = "Cave";
			}

			if (Input.GetKeyDown(KeyCode.S))
			{
				currentRoom = "Wooden Door";
			}

			if (Input.GetKeyDown(KeyCode.A))
			{
				currentRoom = "Gold Gate";
			}

		}

		//set up the scene for the Wooden door
		else if(currentRoom == "Wooden Door")
		{
			textBuffer += "\nYou enter through the wooden door\nand see a skeleton with a sword in its\nribcage. You pick up the sword";
			textBuffer += "\npress [W] to go back to the small room";
			
			//pick u the key
			hasSword = true;
			
			if (Input.GetKeyDown(KeyCode.W))
			{
				currentRoom = "Small Room";
			}
			
		}

		//set up the scene for the gold gate
		else if(currentRoom == "Gold Gate")
		{
			if(hasSword == false)
			{
				textBuffer += "\nYou open the gate and see a treasure\nchest in the corner.";
				textBuffer += "\nAs you approach it a giant troll jumps\nout and attacks you.";
				textBuffer += "\npress [W] to go back to the small room\nand flee the troll";
			}
			else
			{
				textBuffer += "\nYou open the gate and see a treasure\nchest in the corner.";
				textBuffer += "\nAs you approach it a giant troll jumps\nout and attacks you.";
				textBuffer += "\nYou use your sword to slay the troll.";
				textBuffer += "\nCongratulations you recieved the treasure";
				textBuffer += "\npress [W] to go back to the small room";
			}
			
			if (Input.GetKeyDown(KeyCode.W))
			{
				currentRoom = "Small Room";
			}
			
		}

		GetComponent<TextMesh>().text = textBuffer;
	
	}
}
