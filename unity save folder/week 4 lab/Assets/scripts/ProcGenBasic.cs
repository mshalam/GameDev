using UnityEngine;
using System.Collections;

public class ProcGenBasic : MonoBehaviour {

	//create variables
	public Transform small, medium, big, tall;

	// Use this for initialization
	void Start () {

		//spawn 100 small cube
		int counter = 0;
		while(counter<100)
		{

			Transform prefabToSpawn;

			int prefabIndex = Random.Range(0,4);

			if(prefabIndex == 0)
			{
				prefabToSpawn = small;
			}

			else if(prefabIndex == 1)
			{
				prefabToSpawn = medium;
			}

			else if(prefabIndex == 2)
			{
				prefabToSpawn = big;
			}

			else
			{
				prefabToSpawn = tall;
			}

			Instantiate(prefabToSpawn, new Vector3(Random.Range(-10f, 10f), 0f, Random.Range(-10f, 10f)), Quaternion.identity);
			counter++;
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
