using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unmount : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


		if(Input.GetKeyUp("space")) {	
			destroyFloor ();
		}
		
	}





	void destroyFloor() {

		//var childrenGameobject  = gameObject.GetComponentsInChildren<GameObject> ();
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
