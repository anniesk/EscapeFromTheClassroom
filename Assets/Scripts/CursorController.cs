using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorController : MonoBehaviour
{
    public Texture2D cursor;
    public Texture2D cursorClicked;

    private void Awake()
    {
        ChangeCursor(cursor);
        //Cursor.lockState = CursorLockMode.Confined;
    }

    private void ChangeCursor(Texture2D cursortype)
    {
        //Vector2 hotpot = new Vector2(cursortype.width / 2, cursortype.height / 2);
        Cursor.SetCursor(cursortype, Vector2.zero, CursorMode.Auto); //hotpot
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

}
