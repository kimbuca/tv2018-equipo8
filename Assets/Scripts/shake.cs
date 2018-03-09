using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shake : MonoBehaviour {

	public float shakeDuration;
	public float MaxTurn;
	private float maxTime;

	void Awake() {
		var myScript = GetComponent<shake> ();
		myScript.enabled = false;
	}
	// Use this for initialization
	void Start () {
		maxTime = shakeDuration;
	}
	
	// Update is called once per frame
	void Update () {
		Shake ();
	}

	void Shake () {
		if (shakeDuration > 0)
		{
			shakeDuration -= Time.deltaTime;
			float percent = 1 - shakeDuration / maxTime;
			//transform.localRotation = Quaternion.identity;
			transform.Rotate (MaxTurn*percent*RandomSign()*Time.deltaTime*20f,0,MaxTurn*percent*RandomSign()*Time.deltaTime*20f);
		}
		else
		{
			transform.rotation = Quaternion.RotateTowards(transform.rotation,Quaternion.identity,5f*Time.deltaTime);
		}
	}


	int RandomSign(){
		int sign = Random.Range(-1,1);
		if (sign == 0) {
			sign++;
		}
		return sign;
	}
}
