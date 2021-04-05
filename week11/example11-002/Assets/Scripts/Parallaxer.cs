using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallaxer : MonoBehaviour {

    public float speed;

    private Parallaxer dupeLayer;
    private bool isDupe = false;
    private float spriteWidth;
    private float startX, endX, offsetX;
    private Vector2 delta = Vector2.zero;

    private void Start() {
        if (gameObject.name.Split('(')[0] != transform.parent.name.Split('(')[0]) {
            dupeLayer = GameObject.Instantiate(gameObject).GetComponent<Parallaxer>();
            dupeLayer.isDupe = true;
            dupeLayer.transform.SetParent(transform);

            SpriteRenderer ren = GetComponent<SpriteRenderer>();
            spriteWidth = ren.sprite.rect.width / 200f; // half pixel width / 100

            startX = transform.position.x;
            dupeLayer.startX = startX + spriteWidth * 2f;
            dupeLayer.transform.position = new Vector2(dupeLayer.startX, transform.position.y);
        }
    }

    private void Update() {
        delta = Vector2.left * speed * Time.deltaTime;
        offsetX = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z)).x / 2f;
        endX = (startX - (spriteWidth * 2)) - offsetX;
        Debug.Log("spriteWidth: " + spriteWidth + ", startX: " + startX + ", endX: " + endX + ", offsetX: " + offsetX);

        transform.Translate(delta);

        if (transform.position.x < endX) {
            transform.position = new Vector2(startX, transform.position.y);
        }
    }

}
