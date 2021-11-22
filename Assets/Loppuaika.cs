using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Loppuaika : MonoBehaviour
{
    public Canvas canvas;
    public GameObject timer;
    public Text text;

    string text2;
    // Start is called before the first frame update
    void Start()
    {
        canvas = GameObject.Find("Canvas").GetComponent<Canvas>();
        timer = canvas.transform.Find("Timer").gameObject;
        text2 += timer.GetComponent<Text>().text;
        if (text2 != "00:00"){
            text.text += text2;
        }
        Debug.Log(text);
        canvas.enabled = false;
        
 
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
