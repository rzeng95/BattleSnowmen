using UnityEngine;
using System.Collections;
using NUnit.Framework;

public class BulletTest {
	
	[Test]
	public void blah2() {
		Assert.That(2 + 2 == 4);
		
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