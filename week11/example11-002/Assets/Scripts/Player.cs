using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float yIncrement;
    public float speed;
    public float maxHeight;
    public float minHeight;
    public int health;

    private Vector2 targetPos;

    private void Start() {
        targetPos = transform.position;
    }

    private void Update() {
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) && transform.position.y < maxHeight) {
            targetPos = new Vector2(transform.position.x, transform.position.y + yIncrement);
            Debug.Log(transform.position);
        } else if ((Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow)) && transform.position.y > minHeight) {
            targetPos = new Vector2(transform.position.x, transform.position.y - yIncrement);
            Debug.Log(transform.position);
        }
    }

}
