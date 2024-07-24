using UnityEngine;
using UnityEngine.UI;

public class CarrotBeds : MonoBehaviour
{
    private int NumberOfGlove;
    private Text GloveGT;
    [SerializeField] private StopGamePanel _stopGamePanel;

    private void Awake()
    {
        if (PlayerPrefs.HasKey("GloveNumber")) { NumberOfGlove = PlayerPrefs.GetInt("GloveNumber"); }
        else 
        { 
            PlayerPrefs.SetInt("GloveNumber", 5);
            NumberOfGlove = PlayerPrefs.GetInt("GloveNumber");
        }
    }
    void Start()
    {
        _stopGamePanel.PauseGame = false;
        Time.timeScale = 1f;
        GloveGT = GameObject.Find("NumberOfGlove").GetComponent<Text>();
        GloveGT.text = NumberOfGlove.ToString();

    }

    void Update()
    {
        if (NumberOfGlove == 0)
        {
            _stopGamePanel.Looses();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (_stopGamePanel.PauseGame)
            {
                _stopGamePanel.Resume();
            }
            else
            {
                _stopGamePanel.Pause();
            }
        }
        //if (Time.timeScale == 0f)
        //{
        //    Cursor.visible = true;
        //}
        //else
        //{
        //    Cursor.visible = false;
        //}
    }
}
