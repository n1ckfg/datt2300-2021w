using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {

    public void playGame() {
        SceneManager.LoadScene("Main"); // This will have the name of your main game scene
    }

    public void restart() {
        SceneManager.LoadScene("Loader"); // This will have the name of your main menu scene
    }

    public void exitGame() {
        Application.Quit();
    }

}