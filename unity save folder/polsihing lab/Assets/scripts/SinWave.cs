using UnityEngine;
using System.Collections;

public class SinWave : MonoBehaviour {

	Vector3 startPosition;

	// Use this for initialization
	void Start () {

		startPosition = transform.position;
		
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.position = startPosition + new Vector3(0f, 1f, 0f) * Mathf.Sin(Time.time * 3f)  ;
		
	}
}
