using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarrotSpawner : MonoBehaviour
{
    [SerializeField] GameObject CarrotPassive;
    [SerializeField] GameObject CarrotActive;
    private Vector2[] _spavnerPosition;
    public static int CarrotScore = 0;
    private void Start()
    {
        _spavnerPosition = new Vector2[15];
        _spavnerPosition[1] = new Vector2(-4f, 2f);
        _spavnerPosition[2] = new Vector2(-2f, 2f);
        _spavnerPosition[3] = new Vector2(0f, 2f);
        _spavnerPosition[4] = new Vector2(2f, 2f);
        _spavnerPosition[5] = new Vector2(4f, 2f);
        _spavnerPosition[6] = new Vector2(-4.6f, 0f);
        _spavnerPosition[7] = new Vector2(-2.3f, 0f);
        _spavnerPosition[8] = new Vector2(0f, 0f);
        _spavnerPosition[9] = new Vector2(2.3f, 0f);
        _spavnerPosition[10] = new Vector2(4.6f, 0f);
        _spavnerPosition[11] = new Vector2(-5f, -2f);
        _spavnerPosition[12] = new Vector2(-2.5f, -2f);
        _spavnerPosition[13] = new Vector2(0f, -2f);
        _spavnerPosition[14] = new Vector2(2.5f, -2f);
        _spavnerPosition[15] = new Vector2(5f, -2f);
        CarrotPassive.SetActive(true);
        CarrotPassive.SetActive(false);
    }

    public void ActivatorCarrot()
    {
        int _sPosition = Random.Range(0, 15);
        transform.position = _spavnerPosition[_sPosition];
        CarrotPassive.SetActive(false);
        CarrotPassive.SetActive(true);
        Invoke (nameof(AutoDeactivateCarrot), 2f);
    }
    public void AutoDeactivateCarrot()
    {
        
        CarrotPassive.SetActive(true);
        CarrotPassive.SetActive(false);
    }
    public void DeactivateCarrotOnClick()
    {
        CarrotPassive.SetActive(true);
        CarrotPassive.SetActive(false);
        CarrotScore++;
    }

}
