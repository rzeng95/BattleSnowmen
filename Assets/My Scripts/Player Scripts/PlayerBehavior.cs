using UnityEngine;
using System.Collections;

public class PlayerBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Cursor.lockState = CursorLockMode.Locked; //at the beginning, lock cursor to middle of screen 
		Cursor.visible = false; //at the beginning, the cursor is hidden (since it's locked to middle of screen)
		
	}
	
	// Update is called once per frame
	void Update () {

		//NOTE: This is pretty broken. Cursor flashes on screen - hopefully this won't occur in the final build.
		//Documented on: http://forum.unity3d.com/threads/cursor-lockstate-troubles.278221/#post-1887455
		if (Input.GetKeyDown(KeyCode.Escape)) {
			Cursor.lockState = CursorLockMode.None;
			Cursor.visible = true;
		}
		else {
			Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = false;			
		}
	}
}
