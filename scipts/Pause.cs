using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Pause : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenu;

    void Update() {
    if (Input.GetKeyDown("escape"))
        {
            if (GameIsPaused) 
            {
                Resume();
            } else 
            {
                PauseGame();
            }
        }
    }

    public void Resume() {
        pauseMenu.SetActive(false);
        Time.timeScale=1f;
        GameIsPaused=false;
        Debug.Log ("Button pressed");
        FindObjectOfType<AudioManager>().Play("restart");
    }

     void PauseGame() {
        pauseMenu.SetActive(true);
        Time.timeScale=0f;
        GameIsPaused=true;
    }
    
    public void restart() {
        FindObjectOfType<AudioManager>().Play("beep");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale=1f;
        GameIsPaused=false;
    }

    public void QuitGame()
    {
        Debug.Log ("Quitting Game...");
        SceneManager.LoadScene("Menu");
        FindObjectOfType<AudioManager>().Play("quit");
    }
}
