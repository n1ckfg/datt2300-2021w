using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {

    private ParticleSystem particles;

    private IEnumerator Start() {
        particles = GetComponent<ParticleSystem>();
        yield return new WaitForSeconds(particles.main.duration * 3f);
        Destroy(gameObject);
    }
    

}
