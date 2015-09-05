using UnityEngine;
using System.Collections;
 using UnityEngine.UI;

public class PlayerScore : MonoBehaviour {

	Text txt;
	private int curScore;
	
	// Use this for initialization
	void Start () {
		curScore = 0;
		txt = gameObject.GetComponent<Text>(); 
        txt.text="Score : " + curScore;
	}
	
	// Update is called once per frame
	void Update () {
		txt.text="Score : " + curScore;  
	}
	
	void incScore() {
		
		curScore = curScore + 10;
	}
	
}
