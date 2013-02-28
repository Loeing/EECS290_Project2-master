using UnityEngine;
using System.Collections;

public class BallHandler : MonoBehaviour {
	GameObject ball;

	// Use this for initialization
	void Start () {
		ball = GameObject.Find("SphereOfDeath");
		//ball.transform.position = new Vector3(-41.5f, 117.0f, 0.0f);
	}
	
	// Update is called once per frame
	void Update () {
		if(ball.transform.position.y < -30.0f) {
			ball.transform.position = new Vector3(-41.5f, 117.0f, 0.0f);
		}
	}
}
