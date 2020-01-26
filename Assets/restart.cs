using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public void RestartGame()
    {
        if (GameIsPaused)
        {
           // SceneManager.LoadScene("SampleScene");
            resume();
        }
        else
        {
            pause();
        }

    }
    void pause()
    {
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    void resume()
    {
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
}
