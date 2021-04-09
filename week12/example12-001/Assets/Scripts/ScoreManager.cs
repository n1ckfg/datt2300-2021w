using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class ScoreManager : MonoBehaviour {

    public MenuManager menuManager;
    public Player player;
    public int score;
    public TMP_Text scoreDisplay;
    public TMP_Text healthDisplay;

    private void Update() {
        scoreDisplay.text = score.ToString();
        healthDisplay.text = player.health.ToString();

        if (!player.alive) {
            menuManager.restart();
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Obstacle")) {
            score++;
            Debug.Log(score);
        }
    }
}
