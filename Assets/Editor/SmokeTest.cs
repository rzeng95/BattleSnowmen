using UnityEngine;
//using System;
using System.Collections;
using NUnit.Framework;

public class SmokeTest {
	
	[Test]
	public void blah() {
		Assert.That(2 + 2 == 4);
		
	}
	
	[Test]
	public void spawnplayer() {
		GameObject prefab = Resources.Load("Player Prefab") as GameObject;
		Assert.AreNotEqual(null, prefab);
	}
	
	[Test]
	public void spawnenemy() {
		GameObject prefab = Resources.Load("Enemy Prefab") as GameObject;
		Assert.AreNotEqual(null, prefab);
	}	
	
	[Test]
	public void smoketest() {
		GameObject player = Resources.Load("Player Prefab") as GameObject;
		Assert.AreNotEqual(null, player);
		GameObject enemy = Resources.Load("Enemy Prefab") as GameObject;
		Assert.AreNotEqual(null, enemy);
	}
	
	
	
	
}
