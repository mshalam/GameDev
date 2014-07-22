using UnityEngine;
using System.Collections;

public class cameraCode : MonoBehaviour {

	//make variables
	public int turnCount = 0;
	public int camPos = 0;
	public bool phase3 = false;
	
	// Use this for initialization
	void Start () {
		
		//acessing the position of a thing
		//Debug.Log (GetComponent<Transform>().position);
		
	}
	
	// Update is called once per frame
	void Update () {

		if (camPos == 0)
		{
			//transform.Translate(Vector3.right * Time.deltaTime);
			transform.Translate(Vector3.right * Time.deltaTime);
		}

		Debug.Log ( "X:"  );
		Debug.Log ( GetComponent<Transform>().position.x  );
		Debug.Log ( "Y:"  );
		Debug.Log ( GetComponent<Transform>().position.y  );

			
		if(!phase3 && GetComponent<Transform>().position.x >6.35f && (GetComponent<Transform>().position.y <6f && GetComponent<Transform>().position.y >=0f) )
		{
			if(camPos==0)
			{
				camPos++;
			}

			if(camPos == 1)
			{
				transform.Translate(Vector3.back * Time.deltaTime *.5f);
				transform.Translate(Vector3.down * Time.deltaTime *.6f);
			}

			if(GetComponent<Transform>().position.x >7.2f && GetComponent<Transform>().position.y <=.2f )
			{
				phase3 = true;
				Debug.Log ( "HI"  );

			}

		}
			
		if(phase3 )
		{/*
			Debug.Log ( "HI"  );
			Debug.Log ( "X:"  );
			Debug.Log ( GetComponent<Transform>().position.x  );
			Debug.Log ( "Y:"  );
			Debug.Log ( GetComponent<Transform>().position.y  );
			*/

			if(camPos==1)
			{
				camPos++;
			}

			if(camPos == 2)
			{
				Debug.Log ( "YO"  );
				transform.Translate(Vector3.left * Time.deltaTime *1.2f );
				transform.Translate(Vector3.up * Time.deltaTime *0.6f);
				transform.Translate(Vector3.back * Time.deltaTime *.4f );
			}
			if(GetComponent<Transform>().position.y > 7.4)
			{
				camPos++;
			}

			
		}
			

		
		
	}
}
