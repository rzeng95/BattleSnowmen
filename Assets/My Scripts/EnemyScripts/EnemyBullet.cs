﻿using UnityEngine;
using System.Collections;

public class EnemyBullet : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other) {
		
		if (other.gameObject.tag == "Player") {
			//print ("player tag");
			GameObject target = GameObject.Find("/Canvas/DmgText");
			target.SendMessage("incDmg", SendMessageOptions.DontRequireReceiver);
			Destroy(gameObject);
		}
			
	}
}
