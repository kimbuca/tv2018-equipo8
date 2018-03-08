using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectFade : MonoBehaviour {

	public bool visible;

	// Use this for initialization
	void Start () {

	}
		
	void Update () {

		if (Input.GetKeyUp ("space")) {

			if (visible) {
				StartCoroutine (FadeTo (1.0f, 1.0f));
			} else { 
				StartCoroutine (FadeTo (0.0f, 1.0f));
			}
			visible = !visible;
		}

	}

	IEnumerator FadeTo(float aValue, float aTime) {
	
		float colorAlpha = GetComponent<Renderer> ().material.color.a;
		var material = GetComponent<Renderer>().material;
		var color = material.color;

		for (float t = 0.0f; t < 1.0f; t += Time.deltaTime / aTime) {
			
			Color newColor = new Color(color.r, color.g, color.b, Mathf.Lerp(colorAlpha,aValue,t));
			GetComponent<Renderer> ().material.color = newColor;

			yield return null;
		}
	}


}
