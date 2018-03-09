using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unmountTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}


	IEnumerator destroyAll() {
		
		var destructables = Object.FindObjectsOfType<unmount> ();

		foreach (unmount destructable in destructables) {
			destructable.destroyFloor ();
			yield return new WaitForSeconds (1f);
		}
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyUp("space")) {	
			StartCoroutine ("destroyAll");
		}
	}
}
