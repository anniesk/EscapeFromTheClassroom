using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pause : MonoBehaviour
 {
     bool paused = false;
     public GameObject quitbutton;
     public GameObject panel;
    
    void Start(){
        quitbutton.SetActive(false);
        panel.SetActive(false);
    }

     void Update()
     {
         if(Input.GetKeyDown("escape"))
             paused = togglePause();
     }
     
     bool togglePause()
     {
         if(Time.timeScale == 0f)
         {
             quitbutton.SetActive(false);
             panel.SetActive(false);
             Time.timeScale = 1f;
             return(false);
         }
         else
         {
             Time.timeScale = 0f;
            quitbutton.SetActive(true);
            panel.SetActive(true);   
             return(true);    
         }
     }
     public void Quit(){
         Application.Quit();
     }
 }
