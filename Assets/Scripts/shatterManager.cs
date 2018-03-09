using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shatterManager : MonoBehaviour {


	private bool first = true;
	public GameObject controles;
	public bool startCrumble = false;

	// Use this for initialization
	void Start () {
		first = true;
		startCrumble = false;
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

		var playerRigidbody = GameObject.Find ("[CameraRig]").GetComponent<Rigidbody>();
		playerRigidbody.freezeRotation = true;
		destructables [0].Destroy ();
		controles.GetComponent<Controller> ().shake = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(startCrumble) {
			var shakeRoom = Object.FindObjectOfType<shake> ();
			shakeRoom.enabled = true;

			var enGravity = Object.FindObjectOfType<enableGravity> ();
			enGravity.enabled = true;

			StartCoroutine ("destroyAll");
			startCrumble = false;
		};
	}
}
