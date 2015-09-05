using UnityEngine;
using System.Collections;
using UnityEngine.Assertions;

public class EnemyBehavior : MonoBehaviour {


	private GameObject player;
	private Transform target;
	private int detectDistance;
	
	private int AIState;
	private int PatrolState;
	
	private Vector3 dir;
	
	public static bool canFire;
	private GameObject obj;
	private GameObject obj2;
	private float cd;
	private float bulletcounter;
	
	// Use this for initialization
	void Start () {
		player = GameObject.FindWithTag("Player");
		target = player.transform;
		detectDistance = 35;
		
		AIState = 0;
		PatrolState = 0;
		
		canFire = true;
		bulletcounter = 0;
		
		obj = transform.Find("EnemyKey/EnemyGunTip").gameObject;
		obj2 = transform.Find("EnemyKey2/EnemyGunTip").gameObject;
		Assert.IsNotNull(obj, "Error! Could not find enemy gun");
	}
	
	// Update is called once per frame
	void Update () {
		//ToDo: death stuff 
		
		
		if (Vector3.Distance(player.transform.position,transform.position) < detectDistance) 
			AIState = 1;
		else 
			AIState = 0;
		
			
			
		if (AIState == 0) {
			
			if (PatrolState == 0) {
				transform.position = transform.position + transform.forward * 0.1f;
				StartCoroutine(d0());
			}
			if (PatrolState == 1) {
				transform.Rotate(Vector3.up * Time.deltaTime*120);			
				StartCoroutine(d1());
			}

			if (PatrolState == 2) {
				transform.position = transform.position + transform.forward * 0.1f;
				StartCoroutine(d2());
			}	
			

		}
		
		if (AIState == 1) {
			
			//rotate to player always 
			dir= target.position - transform.position;
			dir.Normalize();
			transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(dir), 5 * Time.deltaTime);	

			
			if (canFire) {
				obj.SendMessage("Fire", SendMessageOptions.DontRequireReceiver);
				obj2.SendMessage("Fire", SendMessageOptions.DontRequireReceiver);
				cd = Time.time + 0.2f;
				canFire = false;
				bulletcounter++;
				
			}
			
			if (!canFire && Time.time > cd)
				canFire = true;
			
			if (bulletcounter == 2) {
				cd = Time.time + 1f;
				bulletcounter = 0;
				
			}

		}
		
		//print("AIState : " + AIState);
		
	}
	
	
	IEnumerator d0() {
		yield return new WaitForSeconds(1.5f);
		PatrolState = 1;
	}
	IEnumerator d1() {
		yield return new WaitForSeconds(1.2f);
		PatrolState = 2;
	}	
	IEnumerator d2() {
		yield return new WaitForSeconds(1.5f);
		PatrolState = 0;
	}
}
