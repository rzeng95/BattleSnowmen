using UnityEngine;
using System.Collections;
 using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

	Text txt;
	private int curDmg;
	
	// Use this for initialization
	void Start () {
		curDmg = 0;
		txt = gameObject.GetComponent<Text>(); 
        txt.text="Score : " + curDmg;
	}
	
	// Update is called once per frame
	void Update () {
		txt.text="Damage Taken : " + curDmg;  
	}
	
	void incDmg() {
		
		curDmg = curDmg + 10;
	}
	
}
