using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LaguageChoice : MonoBehaviour
{
    public void visualAid()
    {
        SceneManager.LoadScene("VisualAid");
    }
    public void translatorApp()
    {
        SceneManager.LoadScene("TranslatorApp");
    }
    public void restart()
    {
        SceneManager.LoadScene("Language");
    }
    public void differentScenario()
    {
        SceneManager.LoadScene("ChooseScenario");
    }
    public void mainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
