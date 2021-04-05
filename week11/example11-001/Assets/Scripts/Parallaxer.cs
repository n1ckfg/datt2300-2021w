using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallaxer : MonoBehaviour {

    public float speed;
    public float xStart;
    public float xEnd; // must be less than Xstart

    private void Update() {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        if (transform.position.x < xEnd) {
            Vector2 pos = new Vector2(xStart, transform.position.y);
            transform.position = pos;
        }
    }

}
