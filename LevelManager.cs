using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{


    public void LoadGame()
    {
        SceneManager.LoadScene("Level_01", LoadSceneMode.Single);  
    }

    public void LoadStart()
    {
        SceneManager.LoadScene("Start", LoadSceneMode.Single);
    }

    public void LoadLose()
    {
        SceneManager.LoadScene("Lose", LoadSceneMode.Single);
    }

    public void LoadWin()
    {
        SceneManager.LoadScene("Win", LoadSceneMode.Single);
    }

    public void RequestQuit()
    {
        Application.Quit();
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void brickDestroyed()
    {
        if(Brick.breakableCount <= 0)
        {
            LoadNextLevel();
        }
    }
}
