using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ApplePicker : MonoBehaviour
{
    public int NumberOfBasket;
    public Text BasketGT;
    public GameObject LoosPanel;
    public GameObject PausePanel;
    public bool PauseGame;

    private void Awake()
    {
        if (PlayerPrefs.HasKey("BasketsNumber")) {NumberOfBasket = PlayerPrefs.GetInt("BasketsNumber");}
        else {PlayerPrefs.SetInt("BasketsNumber", 3);}
    }
    void Start()
    {
        Time.timeScale = 1f;
        BasketGT = GameObject.Find("NumberOfBasket").GetComponent<Text>();
        BasketGT.text = NumberOfBasket.ToString();
        LoosPanel.SetActive(false);
    }

    void Update()
    {
        if (NumberOfBasket == 0)
        {
            Looses();
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (PauseGame)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
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
    public void AppleDestroyed()
    {
        // ќтчистка всего листа падающих €блок
        //GameObject[] tAppleArray = GameObject.FindGameObjectsWithTag("Apple");
        //foreach (GameObject tApple in tAppleArray)
        //{
        //    Destroy(tApple);
        //}
        NumberOfBasket--;
        BasketGT.text = NumberOfBasket.ToString();
    }
    public void ReturnToHomeStage()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("HomeStage");
    }
    public void RestartGame()
    {
        SceneManager.LoadScene("ApplePicker");
    }
}
