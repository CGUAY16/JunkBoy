using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagementScripts : MonoBehaviour
{
    //This holds all scripts that Scenes will use to transition to where they need to be.

    // will load the next scene in the build settings array set up.
    public void LoadNextSceneInSceneArray()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    // This will load the start menu.
    // Used when player wants to return to main menu.
    public void LoadMainMenu()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene("StartMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
