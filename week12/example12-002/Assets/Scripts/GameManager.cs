using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public MenuManager menuManager;
    public ScoreManager scoreManager;
    public Player player;
    public bool gameOver = false;
    public float restartDelay = 1f;

    private void Update() {
        if (!gameOver && !player.alive) {
            gameOver = true;
            StartCoroutine(doRestart());
        }
    }

    private IEnumerator doRestart() {
        yield return new WaitForSeconds(restartDelay);
        menuManager.restart();
    }

}