using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverExample : MonoBehaviour {

    public float speed = 5f;
    public float range = 2f;

    private void Start() {
        transform.position = new Vector3(Random.Range(-range, range), Random.Range(-range, range), Random.Range(-range, range));        
    }

    private void Update() {
        transform.Translate(new Vector3(speed, 0f, 0f));

        if (transform.position.x > range || transform.position.x < -range) speed *= -1f;
    }

}
