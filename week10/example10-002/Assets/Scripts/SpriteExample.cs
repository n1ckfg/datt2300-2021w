using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteExample : MonoBehaviour {

    public Transform target;
    public Animator ctl;
    public float speed = 0.5f;

    private void Start() {
        ctl.speed = 0f;
    }

    private void Update() {
        if (Input.GetMouseButton(0)) {
            ctl.speed = 1f;
            transform.position = Vector3.Lerp(transform.position, target.position, speed);
        } else if (Input.GetMouseButtonUp(0)) {
            ctl.speed = 0f;
        }

        if (transform.position.x < target.position.x) {
            transform.localScale = new Vector3(1f, 1f, 1f);
        } else {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
    }

}
