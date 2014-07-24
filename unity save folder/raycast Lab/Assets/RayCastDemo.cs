using UnityEngine;
using System.Collections;

public class RayCastDemo : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//constructed a ray
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

		//initialize a raycast hit info container
		RaycastHit rayHit = new RaycastHit();

		//actually shoot the raycast
		if(Physics.Raycast(ray, out rayHit, 1000f) 
		   && Input.GetMouseButtonDown(0))
		{
			//destroy the object
			Destroy(rayHit.transform.gameObject);

		}
	
	}
}
