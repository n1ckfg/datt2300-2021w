using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallaxer : MonoBehaviour {

    public float speed;

    private SpriteRenderer ren;
    private float spriteWidth;
    private float xStart, xEnd;
    private Vector2 delta = Vector2.zero;

    private void Start() {
        ren = GetComponent<SpriteRenderer>();
        spriteWidth = ren.sprite.rect.width / 200f; // half pixel width / 100
        updateDelta();
        Debug.Log("spriteWidth: " + -spriteWidth + ", " + spriteWidth + " | start/end: " + xStart + ", " + xEnd);
    }

    private void Update() {
        updateDelta();

        transform.Translate(delta);

        if (transform.position.x < xEnd) {
            Vector2 pos = new Vector2(xStart, transform.position.y);
            transform.position = pos;
        }
    }

    private void updateDelta() {
        delta = Vector2.left * speed * Time.deltaTime;
        //Vector3 screenPos = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        xStart = spriteWidth - (Mathf.Abs(spriteWidth - Screen.width / 100f));
        xEnd = -xStart;
    }

}
