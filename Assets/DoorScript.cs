using UnityEngine;
using System.Collections;
/*
 * Joshua Tang
 */
public class DoorScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		this.gameObject.renderer.material.color = Color.green;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider other) {
		if(other.tag == "Player"){	
			Application.LoadLevel("project2teststuff");		
		}
	}
}