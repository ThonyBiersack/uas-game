using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(2);
    }

    public void InfoDev()
    {
        SceneManager.LoadScene(1);
    }

    public void SelectLevelEasy()
    {
        SceneManager.LoadScene(3);
    }

    public void SelectLevelHard()
    {
        SceneManager.LoadScene(4);
    }

    public void Back()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void RestartGame(){
        SceneManager.LoadScene(3);
    }

    public void RestartGameHard(){
        SceneManager.LoadScene(4);
    }
}
