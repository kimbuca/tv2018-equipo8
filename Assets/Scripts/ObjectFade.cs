using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFade : MonoBehaviour
{

	public bool visible;

	// Use this for initialization
	void Start()
	{
		var material = GetComponent<Renderer>().material;
		var color = material.color;

		material.color = new Color(color.r, color.g, color.b, 0f);
	}

	void Update()
	{

	}

	void OnTriggerEnter(Collider collider)
	{
		Debug.Log(this.gameObject.name+"Collision with: "+ collider.tag);
		if (collider.tag == "Player" && !visible)
		{
			StartCoroutine(FadeTo(1.0f, 1.0f));
		}
	}

	IEnumerator FadeTo(float aValue, float aTime)
	{

		float colorAlpha = GetComponent<Renderer>().material.color.a;
		var material = GetComponent<Renderer>().material;
		var color = material.color;

		for (float t = 0.0f; t < 1.0f; t += Time.deltaTime / aTime)
		{

			Color newColor = new Color(color.r, color.g, color.b, Mathf.Lerp(colorAlpha, aValue, t));
			GetComponent<Renderer>().material.color = newColor;

			yield return null;
		}
	}


}