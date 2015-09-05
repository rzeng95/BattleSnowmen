using UnityEngine;
using System.Collections;

public class PlayerProjectileShooter : MonoBehaviour {
	
	public bool testMode;
	public bool fireOnceMode;
	private GameObject prefab;
	private float cd;
	private bool canFire;
	
	// Use this for initialization
	void Start () {
		prefab = Resources.Load("projectile") as GameObject;
		canFire = true;
	}
	
	// Update is called once per frame
	void Update () {
		
		if (fireOnceMode) {
			if (canFire) {
				fire();
				canFire = false;
			}
			
		}
		if (testMode) {
			
			if (canFire) {
				
				fire();
				cd = Time.time + 0.5f;
				canFire = false;
			}
			if (!canFire && Time.time > cd)
				canFire = true;

			
		}
		else {
			if (Input.GetKeyDown(KeyCode.Mouse0)) 
				fire();			
		}
		
	}
	
	void fire() {
		GameObject projectile = Instantiate(prefab) as GameObject;
		projectile.transform.position = transform.position + Camera.main.transform.forward;
		
		Rigidbody rb = projectile.GetComponent<Rigidbody>();
		
		rb.velocity = Camera.main.transform.forward * 100; //40
		Destroy(projectile, 3f);
	
	}
	
	void toggle() {
		fireOnceMode = true;
		
	}
}
