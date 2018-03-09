using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shatterManager : MonoBehaviour {


	private bool first = true;


	// Use this for initialization
	void Start () {
		
	}

	IEnumerator destroyAll() {
		var destructables = Object.FindObjectsOfType<shatter> ();
		foreach (shatter destructable in destructables) {

			if (first) {
				first = false;
				continue;
			}
			destructable.Destroy ();
			yield return new WaitForSeconds (3f);
		}

		destructables [0].Destroy ();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyUp("space")) {

			var shakeRoom = Object.FindObjectOfType<shake> ();
			shakeRoom.enabled = true;

			var enGravity = Object.FindObjectOfType<enableGravity> ();
			enGravity.enabled = true;

			StartCoroutine ("destroyAll");

		};
	}
}
