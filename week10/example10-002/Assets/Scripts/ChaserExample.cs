using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaserExample : MonoBehaviour {

    public Transform target;
    public float speed = 0.5f;

    void Update() {
        if (Input.GetMouseButton(0)) {
            transform.position = Vector3.Lerp(transform.position, target.position, speed);
        }
    }

}
