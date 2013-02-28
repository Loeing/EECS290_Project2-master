using UnityEngine;
using System.Collections;
/*
 * Joshua Tang
 */
public class GuardAI : MonoBehaviour {
	public float coolDownTime = 0.3F;
	private bool coolDown = false;
	public GameObject bullet_prefab;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void fire()
	{
		if(!coolDown){
			GameObject newBullet = (GameObject)Instantiate(bullet_prefab);
			newBullet.SetActive (true);
			newBullet.SendMessage("fire"); 
			coolDown = true;
			StartCoroutine(cool_down ());
		}
	}
	IEnumerator cool_down ()
	{
		yield return new WaitForSeconds(coolDownTime);  
		coolDown = false;
		
	}
	
}
