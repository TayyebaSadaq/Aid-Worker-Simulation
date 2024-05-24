using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public static bool isPaused;

    private void Start()
    {
        pauseMenu.SetActive(false);
    }

    public void TogglePause()
    {
        if(isPaused)
        {
            ResumeProgram();
        }
        else
        {
            PauseProgram();
        }
    }
    
    public void PauseProgram()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void ResumeProgram()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }
    public void mainMenu()
    {
        Time.timeScale = 1f;
        isPaused = false;
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitApp()
    {
        Application.Quit(); // quit application
    }
}
