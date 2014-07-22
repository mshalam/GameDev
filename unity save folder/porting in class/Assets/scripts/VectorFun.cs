using UnityEngine;
using System.Collections;

public class VectorFun : MonoBehaviour {

	//make variables
	public float speed = 5f;
	public Vector3 direction;

	// Use this for initialization
	void Start () {

		//acessing the position of a thing
		Debug.Log (GetComponent<Transform>().position);
	
	}
	
	// Update is called once per frame
	void Update () {

		GetComponent<Transform>().position += direction * Time.deltaTime * speed;
	
	}
}
