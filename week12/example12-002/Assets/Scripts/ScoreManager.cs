using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour {

    public int score;
    public TMP_Text scoreDisplay;
    public TMP_Text healthDisplay;
    public Player player;

    private void Update() {
        scoreDisplay.text = "Score: " + score;
        healthDisplay.text = "Health: " + player.health;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Obstacle")) {
            Destroy(other.gameObject);
            score++;
            Debug.Log("Score: " + score);
        }
    }

}
