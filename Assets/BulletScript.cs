using UnityEngine;
using System.Collections;

/*
 * Joshua Tang
 */
public class MissileGuidanceScript : MonoBehaviour {
	public float speed = 100; // speed of bullet
	public Vector3 velocity = Vector3.zero;
	
	void Start () {
		this.gameObject.renderer.material.color = Color.red;
	}
	
	void fire(int playerID)
	{
		
			Vector3 position =  GameObject.Find("Soldier").transform.position; 
			this.transform.position =  position;
			if( GameObject.Find ("Soldier").transform.position.x > position.x){
			velocity.x = 0;
			velocity.y = -speed; // moves straight to the left
			velocity.z = 0;
		}
		else {
			velocity.x = 0;
			velocity.y = +speed; // moves straight to the right
			velocity.z = 0;			
		}
			this.gameObject.SetActive (true);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.Translate(velocity*Time.fixedDeltaTime); 
	}
	void OnCollisionEnter(Collision other){
		Destroy(this.gameObject); //destroys the bullet
		
	}
		
}