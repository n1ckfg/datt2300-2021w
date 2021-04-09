using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour {

    public int score;
    public TMP_Text scoreDisplay;
    public TMP_Text healthDisplay;
    public Player player;
    public MenuManager menuManager;
    public bool gameOver = false;
    public float restartDelay = 1f;

    private void Update() {
        scoreDisplay.text = score.ToString();
        healthDisplay.text = player.health.ToString();

        if (!gameOver && !player.alive) {
            gameOver = true;
            StartCoroutine(restartGame());
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Obstacle")) {
            Destroy(other.gameObject);
            score++;
            Debug.Log(score);
        }
    }   
    
    private IEnumerator restartGame() {
        yield return new WaitForSeconds(restartDelay);
        menuManager.restart();
    }

}
