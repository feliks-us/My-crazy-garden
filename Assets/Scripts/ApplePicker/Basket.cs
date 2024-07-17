using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Basket : MonoBehaviour
{
    public static int AppleScore = 0;

    private void Start ()
    {
        AppleScore = 0;
    }

    void Update()
    {
               if (Time.timeScale == 0f)
        {
            return;
        }
        else { BasketPosition(); }
    }
    private void OnCollisionEnter2D(Collision2D collision) 
    {
        GameObject collidedWith = collision.gameObject;
        string colisionTag = collidedWith.tag;
        switch (colisionTag)
        {
            case ("Apple"):
                AppleScore++;
                break;
            case ("GoldenApple"):
                AppleScore += 20;
                break;
            case ("DeadBird"):
                if(AppleScore >= 50)
                {
                    AppleScore -= 50;
                }
                else AppleScore = 0;
                break;
        }
        Destroy(collidedWith);

    }
    private void BasketPosition()
    {
        Vector3 _mousePos2D = Input.mousePosition;
        _mousePos2D.z = -Camera.main.transform.position.z;
        Vector3 _mousePos3D = Camera.main.ScreenToWorldPoint(_mousePos2D);
        Vector3 _basketPos3D = this.transform.position;

        if(_mousePos3D.x > 8.5f)
        {
            _mousePos3D.x = 8.5f;
        }
        else if(_mousePos3D.x < -8.5f)
        {
            _mousePos3D.x = -8.5f;
        }
       
        _basketPos3D.x = _mousePos3D.x;
        this.transform.position = _basketPos3D;
    }
}
