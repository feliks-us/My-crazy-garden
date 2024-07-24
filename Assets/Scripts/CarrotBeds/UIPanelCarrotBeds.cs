using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPanelCarrotBeds : MonoBehaviour
{
    public Text scoreGT;
    public Text maxScoreGT;
    public int MaxAppleScore;

    private void Awake()
    {
        if (PlayerPrefs.HasKey("HighCarrotScore")) 
        { 
            MaxAppleScore = PlayerPrefs.GetInt("HighCarrotScore"); 
        }
        else 
        { 
            PlayerPrefs.SetInt("HighCarrotScoreCarrot", 50);
            MaxAppleScore = PlayerPrefs.GetInt("HighCarrotScore");
        }
    }
    void Start()
    {
        GameObject scoreGO = GameObject.Find("CarrotScore");
        scoreGT = scoreGO.GetComponent<Text>();
        scoreGT.text = "0";

        GameObject maxScoreGO = GameObject.Find("CarrotMaxScore");
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
        if (MaxAppleScore > PlayerPrefs.GetInt("HighCarrotScore")) {PlayerPrefs.SetInt("HighCarrotScore", MaxAppleScore);} // ���������� ������������� ���-�� ��������
    }
}
