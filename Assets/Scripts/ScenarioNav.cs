using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenarioNav : MonoBehaviour
{
    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu"); // load main menu
    }
    public void languagenav()
    {
        SceneManager.LoadScene("Language"); 
    }
    public void emotionsnav()
    {
        SceneManager.LoadScene("Emotions");
    }

}