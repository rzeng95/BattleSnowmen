using UnityEngine;
using System.Collections;

public class EnemyBehavior : MonoBehaviour {

	private int AIState;
	// Use this for initialization
	void Start () {
		AIState = 0;
	}
	
	// Update is called once per frame
	void Update () {
		//ToDo: death stuff 
		transform.position = transform.position + transform.forward * 0.1f;
		
		
		
	}
}
