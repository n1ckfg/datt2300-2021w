using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSpeed : MonoBehaviour {

    public float minSpeed = 0.8f;
    public float maxSpeed = 1f;
    private AudioSource snd;

    private void Start() {
        snd = GetComponent<AudioSource>();
        snd.pitch = Random.Range(minSpeed, maxSpeed);
    }

}
