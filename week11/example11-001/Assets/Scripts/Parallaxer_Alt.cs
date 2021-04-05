// by @maxp123

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//put this script in parallax layer, and center your layers on the camera

public class Parallaxer_Alt : MonoBehaviour {
    [SerializeField] private float moveSpeed = 1f;

    [SerializeField] private float offset;
    private Vector2 startPos;
    private float newXpos;
    // Start is called before the first frame update
    void Start() {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update() {
        newXpos = Mathf.Repeat(Time.time * -moveSpeed, offset);

        transform.position = startPos + Vector2.right * newXpos;
    }
}