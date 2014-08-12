using UnityEngine;
using System.Collections;

public class BallSwap : MonoBehaviour {

	public Transform ball1, ball2; //assign in inspector

	// Use this for initialization
	void Start () {

		StartCoroutine(BallCoroutine());

	
	}

	IEnumerator BallCoroutine()
	{
		Debug.Log("coroutine started");

		yield return 0; // wait one frame

		Debug.Log("frame elapsed");

		//yield return new WaitForSeconds(2.3f);

		//Debug.Log("now 2.3 seconds have elapsed");

		//lerpng with while loops
		while(true)
		{

			Vector3 ball1Pos = ball1.position;
			Vector3 ball2Pos = ball2.position;
			float t = 0f;
			bool soundPlayed = false;

			while(t<1f) // keep lerping 
			{
				t+=Time.deltaTime;

				if (t>=0.5f && !soundPlayed)
				{
					audio.Play();
					soundPlayed = true;
					StartCoroutine(ScreenShake(0.5f, 40f));
				}

				ball1.position = Vector3.Lerp(ball1Pos, ball2Pos, t);
				ball2.position = Vector3.Lerp(ball2Pos, ball1Pos, t);
				yield return 0;
			}

			yield return 0;
		}

	}

	IEnumerator ScreenShake(float duration, float shakeSpeed)
	{
		//value from o to 1
		float t = 1f;
		Vector3 cameraStartPos = Camera.main.transform.position;

		while(t > 0f)
		{
			t -= Time.deltaTime / duration;

			//shake the screen using a sin wave
			Camera.main.transform.position = cameraStartPos + 
				Camera.main.transform.right * Mathf.Sin(Time.time * shakeSpeed) * t
					+ Camera.main.transform.up * Mathf.Sin(Time.time * shakeSpeed * 1.1f) * t;

			yield return 0;
		}


	}
	
	// Update is called once per frame
	void Update () {
	
	}


}
