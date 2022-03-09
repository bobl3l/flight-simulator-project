using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{   
    public GameObject mainMenu;
    public GameObject controls;

    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        Time.timeScale=1f;
        FindObjectOfType<AudioManager>().Play("click");
    }

    public void Controls() {
        mainMenu.SetActive(false);
        controls.SetActive(true);
        FindObjectOfType<AudioManager>().Play("click");
    }

    public void Back() {
        mainMenu.SetActive(true);
        controls.SetActive(false);
        FindObjectOfType<AudioManager>().Play("click");
    }

    public void QuitGame ()
    {
        Debug.Log("QUIT!");
        Application.Quit();
        FindObjectOfType<AudioManager>().Play("click");
    }
}
