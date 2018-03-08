using UnityEngine;
using System.Collections;

public class CameraShake : MonoBehaviour
{
	// Transform of the camera to shake. Grabs the gameObject's transform
	// if null.
	private Transform transform;

	// How long the object should shake for.
	public float shakeDuration;
	private float maxTime;

	public float MaxTurn;

	void Start() {
		transform = GetComponent<Transform>();
		maxTime = shakeDuration;
	}

	void Update()
	{
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