using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float yIncrement;
    public float speed;
    public float maxHeight;
    public float minHeight;
    public int health;
    public bool alive = true;
    public GameObject explosionPrefab;

    private Vector2 targetPos;
    private Animator animator;

    private void Start() {
        targetPos = transform.position;
        animator = GetComponent<Animator>();
    }

    private void Update() { 
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) && transform.position.y < maxHeight) {
            animator.SetTrigger("Jump");
            targetPos = new Vector2(transform.position.x, transform.position.y + yIncrement);
            Debug.Log(transform.position);
        } else if ((Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow)) && transform.position.y > minHeight) {
            animator.SetTrigger("Jump");
            targetPos = new Vector2(transform.position.x, transform.position.y - yIncrement);
            Debug.Log(transform.position);
        }

        if (alive && health <= 0) {
            alive = false;
            Debug.Log("Player has died.");
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

    public void takeDamage(int damage) {
        animator.SetTrigger("Damage");
        health -= damage;
        Debug.Log("Player has taken damage, health: " + health);
    }

}
