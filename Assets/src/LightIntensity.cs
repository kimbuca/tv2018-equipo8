using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightIntensity : MonoBehaviour {
	public GameObject target;
	public float maxDistance;
	private float distanceToTarget;
	private Light light;
	public float intensity;

	// Use this for initialization
	void Start () {
		light = gameObject.GetComponent<Light> ();

		intensity = light.intensity;
	}
	
	// Update is called once per frame
	void Update () {
		changeIntensity ();
	}

	void changeIntensity(){
		Vector3 targetPosition = new Vector3 (target.transform.position.x, 0, target.transform.position.z);
		Vector3 objectPosition = new Vector3 (gameObject.transform.position.x, 0, gameObject.transform.position.z);

		distanceToTarget = Vector3.Distance (targetPosition,objectPosition);

		if(distanceToTarget > maxDistance){
			distanceToTarget = maxDistance;
		}
		if (targetPosition.z > objectPosition.z) {
			light.intensity = 1 - (distanceToTarget / maxDistance);	
		} else {
			light.intensity = intensity;
		}
	}
}
