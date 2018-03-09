using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flowerExplosion : MonoBehaviour {


	//Flower hierarchy


	// Use this for initialization
	void Start () {



	}
	
	// Update is called once per frame
	void Update () {


		if(Input.GetKeyUp("space")) {


			var gTransform = gameObject.transform;

			for (int i = 0; i < gTransform.childCount; i++) {

				var currentTulip = gTransform.GetChild (i);

				GameObject flower = currentTulip.transform.Find ("pPlane3").gameObject;
				Rigidbody flowerRigidbody = flower.AddComponent (typeof(Rigidbody)) as Rigidbody;
				flowerRigidbody.useGravity = true;

				var fPosition = flower.transform.position;
				flowerRigidbody.AddExplosionForce (10000f, fPosition, 1f);
				//flowerRigidbody.AddForceAtPosition (new Vector3 (fPosition.x, fPosition.y + 600f, fPosition.z + 20f), fPosition);

			}

		}
	}
}
