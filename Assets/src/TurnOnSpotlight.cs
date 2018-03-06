using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnSpotlight : MonoBehaviour {
	public GameObject spotlight;
	public GameObject doorSpotLight;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other){
		Light doorLight = doorSpotLight.GetComponent<Light> ();
		Light light = spotlight.GetComponent<Light> ();
		if (other.gameObject.tag=="MainCamera") {
			light.enabled = false;
			doorLight.enabled = true;

		}

	}
}
