using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    public float Speed = 600f;
    float move = 0f;
    public static bool GameIsPaused = false;

    // Update is called once per frame
    void Update()
    {
       move = Input.GetAxisRaw("Horizontal");
    }
    private void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, move * Time.fixedDeltaTime * -Speed);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        pause();
    }
    void pause()
    {
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}
