using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enableGravity : MonoBehaviour {

	void Awake () {
		var myScript = GetComponent<enableGravity> ();
		myScript.enabled = false;
	}

	// Use this for initialization
	void Start () {
		enableGravityOnChildren ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator waitUntil(){


		yield return new WaitForSeconds (5f);

		var myChildren = this.gameObject.GetComponentsInChildren<Rigidbody> ();

		foreach (Rigidbody child in myChildren) {
			child.useGravity = true;
		}
		
	}

	void enableGravityOnChildren() {

		StartCoroutine ("waitUntil");
	}

}
