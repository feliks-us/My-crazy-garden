using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorManager : MonoBehaviour
{
    [SerializeField] private Texture2D _mouseCursorDefolt;
    [SerializeField] private Texture2D _mouseCursorClick;
    Vector2 hotSpot = new Vector2 (12, 12);
    CursorMode cursorMode = CursorMode.Auto;
    private void Start()
    {     
      Cursor.SetCursor(_mouseCursorDefolt, hotSpot, cursorMode);  
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Cursor.SetCursor(_mouseCursorClick, hotSpot, cursorMode);
        }
        else
        {
            Cursor.SetCursor(_mouseCursorDefolt, hotSpot, cursorMode);
        }
    }
}
