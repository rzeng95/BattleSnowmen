using UnityEngine;
using System.Collections;
//using NUnit.Framework;

public class SpawnTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject prefab = Resources.Load("Player Prefab") as GameObject;
		GameObject player = Instantiate(prefab) as GameObject;
		
		//player.GetComponent("PlayerProjectileShooter").fireOnceMode = true;
		GameObject obj = player.transform.Find("MainCamera/PlayerKey/GunTip").gameObject;
		obj.SendMessage("toggle", SendMessageOptions.DontRequireReceiver);
	
	}
	
	// Update is called once per frame
	void Update () {
		GameObject f = GameObject.FindWithTag ("bullet");
		print(f);
	
	} 
	/*
	[Test]
	public void ShootOnce() {
		GameObject prefab = Resources.Load("Player Prefab") as GameObject;
		GameObject player = Instantiate(prefab) as GameObject;
		
		//player.GetComponent("PlayerProjectileShooter").fireOnceMode = true;
		GameObject obj = player.transform.Find("MainCamera/PlayerKey/GunTip").gameObject;
		obj.SendMessage("toggle", SendMessageOptions.DontRequireReceiver);		
		GameObject f = GameObject.FindWithTag ("bullet");
		Assert.AreNotEqual(null, f);
	}
	*/
}
