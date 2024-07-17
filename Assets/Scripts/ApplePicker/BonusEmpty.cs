using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusEmpty : MonoBehaviour
{
    public static float _bottomY = -7f;
    private void Update()
    {
        if (transform.position.y < _bottomY)
        {
            Destroy(this.gameObject);            
        }
    }
}
