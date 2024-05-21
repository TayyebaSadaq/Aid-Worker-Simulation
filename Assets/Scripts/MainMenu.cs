using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartApp()
    {
        SceneManager.LoadScene("ChooseScenario"); // load choose scenario scene
    }

    public void Settings()
    {
        SceneManager.LoadScene("Settings"); //load settings
    }
    public void QuitApp()
    {
        Application.Quit(); // quit application
    }
}
