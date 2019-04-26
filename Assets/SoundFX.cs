using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundFX : MonoBehaviour {

    public AudioClip Sound = null;
    public float Volume = 1.0f;
    protected Transform Position = null;

    public void Start()
    {
        Position = transform;
    }

    public void OnCollisionEnter(Collision col)
    {
        if (Sound) AudioSource.PlayClipAtPoint(Sound, Position.position, Volume);
    }
}
