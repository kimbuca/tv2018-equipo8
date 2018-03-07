using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockY : MonoBehaviour {
	public float y;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position = new Vector3(this.transform.position.x, y, this.transform.position.z);
	}
}
