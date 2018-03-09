using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class cambioEscena : MonoBehaviour {
 
    public Animator anim;
    public Image Img;
    public string scene;


	void Update() {

//		if (Input.GetKeyUp ("down")) {
//			Debug.Log ("tecla");
//			StartCoroutine(Fade());
//		}
	}


    IEnumerator Fade()
    {
        anim.SetBool("Fade", true);
        yield return new WaitUntil(() => Img.color.a == 1);
        SceneManager.LoadScene(scene);
    }
 
    private void OnCollisionEnter(Collision collision)
    {
        StartCoroutine(Fade());
       
    }
		
}
