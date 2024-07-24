using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPanelApplePicker : MonoBehaviour
{
    public Text scoreGT;
    public Text maxScoreGT;
    public int MaxAppleScore;

    private void Awake()
    {
        if (PlayerPrefs.HasKey("HighAppleScore")) 
        { 
            MaxAppleScore = PlayerPrefs.GetInt("HighAppleScore"); 
        }
        else 
        { 
            PlayerPrefs.SetInt("HighAppleScore", 50);
            MaxAppleScore = PlayerPrefs.GetInt("HighAppleScore");
        }
    }
    void Start()
    {
        GameObject scoreGO = GameObject.Find("AppleScore");
        scoreGT = scoreGO.GetComponent<Text>();
        scoreGT.text = "0";

        GameObject maxScoreGO = GameObject.Find("AppleMaxScore");
        maxScoreGT = maxScoreGO.GetComponent<Text>();
        maxScoreGT.text = MaxAppleScore.ToString();
    }
    private void Update()
    {
        ChangeNumberApples();
        ChangeMaxNumberApple();
    }
    public void ChangeNumberApples() 
    {
        
        scoreGT.text = Basket.AppleScore.ToString();
        if (Basket.AppleScore > MaxAppleScore)
        {
            MaxAppleScore = Basket.AppleScore;
        }
    }
    private void ChangeMaxNumberApple()
    {
        maxScoreGT.text = MaxAppleScore.ToString();
        if (MaxAppleScore > PlayerPrefs.GetInt("HighAppleScore")) {PlayerPrefs.SetInt("HighAppleScore", MaxAppleScore);} // сохранение максимального кол-ва яблок
    }
}
