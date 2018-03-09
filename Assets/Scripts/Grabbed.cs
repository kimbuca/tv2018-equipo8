using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class Grabbed : MonoBehaviour {

	public GameObject controles;

	// Use this for initialization
	void Start () {
		GetComponent<VRTK_InteractableObject> ().InteractableObjectGrabbed += new InteractableObjectEventHandler(ObjectGrabbed);
	}

	IEnumerator crumble(){
		yield return new WaitForSeconds (10f);
		controles.GetComponent<Controller> ().shake = true;
		GameObject.Find ("PlayAreaScripts").GetComponent<shatterManager> ().startCrumble = true;
		var playerRigidbody = GameObject.Find ("[CameraRig]").GetComponent<Rigidbody>();
		playerRigidbody.freezeRotation = true;
	}

	private void ObjectGrabbed(object sender, InteractableObjectEventArgs e){
		StartCoroutine ("crumble");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
