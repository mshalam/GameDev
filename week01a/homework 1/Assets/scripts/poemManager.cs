using UnityEngine;
using System.Collections;

public class poemManager : MonoBehaviour {

	// Use this for initialization
	void Start () {

		Debug.Log("Hello World");

		GetComponent<TextMesh>().text = "The sight of the hills is a beauty \nThe bright moon is the sign of purity \nThe flow of the river is a murmuring music \nThe act of the sun is so philanthropic.";
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
