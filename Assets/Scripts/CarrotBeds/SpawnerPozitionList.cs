using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerPozitionList : MonoBehaviour
{
    public Vector2[] SpavnerPosition;
    void Start()
    {
        SpavnerPosition = new Vector2[15];
        SpavnerPosition[1] = new Vector2(-4f,2f);
        SpavnerPosition[2] = new Vector2(-2f,2f);
        SpavnerPosition[3] = new Vector2(0f,2f);
        SpavnerPosition[4] = new Vector2(2f, 2f);
        SpavnerPosition[5] = new Vector2(4f, 2f);
        SpavnerPosition[6] = new Vector2(-4.6f, 0f);
        SpavnerPosition[7] = new Vector2(-2.3f, 0f);
        SpavnerPosition[8] = new Vector2(0f, 0f);
        SpavnerPosition[9] = new Vector2(2.3f, 0f);
        SpavnerPosition[10] = new Vector2(4.6f, 0f);
        SpavnerPosition[11] = new Vector2(-5f, -2f);
        SpavnerPosition[12] = new Vector2(-2.5f, -2f);
        SpavnerPosition[13] = new Vector2(0f, -2f);
        SpavnerPosition[14] = new Vector2(2.5f, -2f);
        SpavnerPosition[15] = new Vector2(5f, -2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
}
