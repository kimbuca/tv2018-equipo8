using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour {

	public GameObject camera;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position = new Vector3(this.camera.transform.position.x, 0.53f, this.camera.transform.position.z);
		this.transform.localRotation = new Quaternion(0f, this.camera.transform.rotation.y, 0f, this.camera.transform.rotation.w);
	}
}
