using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Loppuaika : MonoBehaviour
{
    public Canvas canvas;
    public GameObject timer;
    public Text text;

    float timeFloat;
    // Start is called before the first frame update
    void Start()
    {
        canvas = GameObject.Find("Canvas").GetComponent<Canvas>();
        timer = canvas.transform.Find("Timer").gameObject;
        timeFloat = 900 - timer.GetComponent<Timer>().returnFloat();
        float minutes = Mathf.FloorToInt(timeFloat / 60);
        float seconds = Mathf.FloorToInt(timeFloat % 60);
        if (timeFloat != 0){
            text.text += string.Format("{0:00}:{1:00}", minutes, seconds);
        }
        Debug.Log(text);
        canvas.enabled = false;
        
 
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
