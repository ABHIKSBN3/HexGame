using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class destroy : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public void RestartGame()
    {

        SceneManager.LoadScene("SampleScene");
        resume();

    }
    void resume()
    {
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
}
