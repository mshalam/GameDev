using UnityEngine;
using System.Collections;

public class CannonBall : MonoBehaviour {
	//make variables
	public float speed = 10f;
	public Vector3 direction;
	
	// Use this for initialization
	void Start () {
		
		//acessing the position of a thing
		//Debug.Log (GetComponent<Transform>().position);
		
	}
	
	// Update is called once per frame
	void Update () {

		//Debug.Log (Time.realtimeSinceStartup * Time.fixedDeltaTime   );

		if ((Time.realtimeSinceStartup * Time.fixedDeltaTime ) > .71f)
		{
		
		GetComponent<Transform>().position += direction * Time.deltaTime * speed;
		//acessing the position of a thing
		//Debug.Log (GetComponent<Transform>().position);


			if(GetComponent<Transform>().position.x <.35f )
			{
				speed = 0.0f;
			}


		}


	}
}
