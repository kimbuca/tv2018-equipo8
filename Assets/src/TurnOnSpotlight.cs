using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnSpotlight : MonoBehaviour {
	public GameObject spotlight;
	public GameObject player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other){
		Light light = spotlight.GetComponent<Light> ();
		if (other.gameObject.GetInstanceID()==player.GetInstanceID()) {
			light.enabled = true;
		}

	}
}
