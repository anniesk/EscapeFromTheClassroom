using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ikkuna_animaatio : MonoBehaviour
{
    public Canvas canvas;
    public GameObject timer;
    public Animator ikkuna;
    // Start is called before the first frame update
    void Start()
    {
        canvas = GameObject.Find("Canvas").GetComponent<Canvas>();
        timer = canvas.transform.Find("Timer").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        float timerAika = timer.GetComponent<Timer>().returnFloat();
        
        /*if (timerAika < 900 && timerAika > 675){
            ikkuna.SetFloat("time", 2);
        }
        else*/ if (timerAika < 675 && timerAika > 450){
            ikkuna.SetFloat("time", 2);
        }
        else if (timerAika < 450 && timerAika > 225){
            ikkuna.SetFloat("time", 3);
        }
        else if (timerAika <225){
            ikkuna.SetFloat("time", 4);
        }
    }
}
