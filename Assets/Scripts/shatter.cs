using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shatter : MonoBehaviour {


	void Awake() {

		var myScript = GetComponent<shatter> ();
		myScript.enabled = false;
	
	}
	// Use this for initialization
	void Start () {
		Destroy ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Destroy() {
		
		var childrenRigidBody = gameObject.GetComponentsInChildren<Rigidbody> ();

		foreach (Rigidbody child in childrenRigidBody) {
			child.useGravity = true;
			child.AddForceAtPosition (new Vector3 (child.position.x + Random.Range (-500f, 500f), child.position.y + Random.Range (-500f, 500f), child.position.z + Random.Range (-500f, 500f)), child.position);
		}

		for (int i = 0; i < gameObject.transform.childCount; i++) {
			Destroy (gameObject.transform.GetComponentInParent<BoxCollider> ());
			Destroy (gameObject.transform.GetChild(i).gameObject, Random.Range(1f, 5f));
		}
	}
}
