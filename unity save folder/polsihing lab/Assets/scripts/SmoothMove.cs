using UnityEngine;
using System.Collections;

public class SmoothMove : MonoBehaviour {

	public Vector3 destination;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.position = Vector3.Lerp(transform.position, destination, Time.deltaTime ) ;

	
	}
}
