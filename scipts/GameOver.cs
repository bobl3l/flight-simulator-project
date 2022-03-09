using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    
    public GameObject over;
    public GameObject score;
    public static bool GameIsPaused = false;
    public bool gameEnded = false;

    public void EndGame () {
        if (gameEnded==false) {
            gameEnded = true;
            Invoke("OverMenu",1f);
        }
    }

    public void OverMenu() {
        Time.timeScale=0f;
        over.SetActive(true);
        score.SetActive(false);
    }

    public void Restart() {
        FindObjectOfType<AudioManager>().Play("beep");
        DontDestroyOnLoad(gameObject);
        Time.timeScale=1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        over.SetActive(false);
        score.SetActive(true);
        FindObjectOfType<AudioManager>().Play("Bgm");
    }

    public void QuitGame()
    {
        Debug.Log ("Quitting Game...");
        SceneManager.LoadScene("Menu");
        FindObjectOfType<AudioManager>().Play("Bgm");
        FindObjectOfType<AudioManager>().Play("quit");
    }
}
