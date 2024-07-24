using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StopGamePanel : MonoBehaviour
{
    public GameObject LoosPanel;
    public GameObject PausePanel;
    public bool PauseGame;

    private void Start()
    {
        LoosPanel.SetActive(false);
        PausePanel.SetActive(false);
    }

    
    public void Pause()
    {
        PausePanel.SetActive(true);
        Time.timeScale = 0f;
        PauseGame = true;
    }
    public void Resume()
    {
        PausePanel.SetActive(false);
        Time.timeScale = 1f;
        PauseGame = false;
    }
    public void Looses()
    {

        LoosPanel.SetActive(true);
        Time.timeScale = 0f;
    }
    public void ReturnToHomeStage()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("HomeStage");
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
