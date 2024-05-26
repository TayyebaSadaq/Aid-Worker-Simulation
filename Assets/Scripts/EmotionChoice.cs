using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EmotionChoice : MonoBehaviour
{
    public void supportReassurance()
    {
        SceneManager.LoadScene("SupportReassurance");
    }
    public void supportGroup()
    {
        SceneManager.LoadScene("SupportGroup");
    }
    public void restart()
    {
        SceneManager.LoadScene("Emotions");
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