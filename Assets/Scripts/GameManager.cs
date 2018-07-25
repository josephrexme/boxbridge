using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    bool isGameEnded = false;
    public float restartDelay = 1f;
    public GameObject levelCompletePanel;

    public void CompleteLevel() {
        levelCompletePanel.SetActive(true);
    }

    public void EndGame() {
        if(!isGameEnded){
            isGameEnded = true;
            Debug.Log("Game over");
            Invoke("Restart", restartDelay);
        }
    }

    void Restart() {
        string currentScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentScene);
    }
}
