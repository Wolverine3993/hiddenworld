using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    [SerializeField] GameObject pauseScreen;
    void Update()
    {
        if(Input.GetKey(KeyCode.Escape))
            PauseGame();
    }
    public void UnPause()
    {
        Time.timeScale = 1.0f;
        pauseScreen.SetActive(false);
    }
    public void PauseGame()
    {
        Time.timeScale = 0f;
        pauseScreen.SetActive(true);
    }
}
