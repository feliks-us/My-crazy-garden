using UnityEngine;
using UnityEngine.UI;

public class ApplePicker : MonoBehaviour
{
    public static int NumberOfBasket;
    private Text BasketGT;
    [SerializeField] private StopGamePanel _stopGamePanel;
    
    private void Awake()
    {
        if (PlayerPrefs.HasKey("BasketsNumber")) { NumberOfBasket = PlayerPrefs.GetInt("BasketsNumber"); }
        else 
        {
            PlayerPrefs.SetInt("BasketsNumber", 3);
            NumberOfBasket = PlayerPrefs.GetInt("BasketsNumber"); 
        }
    }
    void Start()
    {
        Cursor.visible = false;
        _stopGamePanel.PauseGame = false;
        Time.timeScale = 1f;
        BasketGT = GameObject.Find("NumberOfBasket").GetComponent<Text>();
        BasketGT.text = NumberOfBasket.ToString();

    }

    void Update()
    {
        if (NumberOfBasket == 0)
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
        if (Time.timeScale ==0f)
        {
            Cursor.visible = true;
        }
        else
        {
            Cursor.visible = false;
        }
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

    public void AddBasketNumber()
    {
        if (NumberOfBasket < 5)
        {
            NumberOfBasket++;
            BasketGT.text = NumberOfBasket.ToString();
        }
    }



    public void RemoveBasketNumber()
    {
        NumberOfBasket--;
        BasketGT.text = NumberOfBasket.ToString();
    }
}
