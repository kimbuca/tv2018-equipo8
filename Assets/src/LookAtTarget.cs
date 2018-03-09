using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtTarget : MonoBehaviour {
	public GameObject target;

	private float offset = -0.4f;

	// Use this for initialization
	void Start () {
			
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt (new Vector3(target.transform.position.x,target.transform.position.y + offset,target.transform.position.z));
	}
}
