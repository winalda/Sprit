using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {

	public GameObject newSpritman;
	public GameObject stopSpritman;
	public GameObject RunSpritman;

	// Use this for initialization
	void Start () {
		Instantiate (newSpritman, new Vector3 (-9f, -3.5f, 0), Quaternion.identity);//new Quaternion(0,0,0,0));//newSpritman.transform.rotation);
		this.CharacterGame();
	}

	void CharacterGame(){
		//System.Threading.Thread.Sleep (10000000);
		//DestroyObject (newSpritman);
		//newSpritman.SetActive(false);
	}

	// Update is called once per 	frame
	//void Update () {
	//}
}
