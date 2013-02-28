using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
	int distanceAway=-15;
	GameObject playerChar;
	GameObject mainCam;
	// Use this for initialization
	void Start () {
	FindPlayerChar();
	FindMainCam();
	}
	
	// Update is called once per frame
	void Update () {
	FindPlayerChar ();
	FindMainCam();
	
	mainCam.transform.position=new Vector3(playerChar.transform.position.x, playerChar.transform.position.y, distanceAway);
		
	}
	
	void FindPlayerChar()
	{
		if(playerChar == null)
		{
			playerChar = GameObject.Find("MainCharacter");	
		}
	}
	void FindMainCam()
	{
		if(mainCam == null)
		{
			mainCam = GameObject.Find("Main Camera");	
		}
	}
	
}
