using UnityEngine;
using System.Collections;

public class Vision : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other){
		if(other.tag == "Player"){
			GameObject soldier = GameObject.Find("Soldier");
			soldier.SendMessage("fire");
		}
	}
}
