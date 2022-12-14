using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    /* chat.openai.com
    program a main menu script with unity library in C# inculiding 
    start first scene, replay, pause, unpause, load scene, next scene, quit functions
    */

    // Start the first scene in the game
    public void StartFirstScene()
    {
        SceneManager.LoadScene(0);
    }

    // Replay the current scene
    public void ReplayScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // Pause the game
    public void PauseGame()
    {
        Time.timeScale = 0;
    }

    // Unpause the game
    public void UnpauseGame()
    {
        Time.timeScale = 1;
    }

    // Load a specific scene by its build index
    public void LoadScene(int buildIndex)
    {
        SceneManager.LoadScene(buildIndex);
    }

    // Move to the next scene in the build order
    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Quit the game
    public void QuitGame()
    {
        Application.Quit();
    }
}
