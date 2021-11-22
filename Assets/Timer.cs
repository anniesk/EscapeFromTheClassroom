using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float timeValue = 900;
    public Text timeText;
    string sceneName;
     bool IncreaseTime = true;

    // Start is called before the first frame update
    void Start()
    {
        // Create a temporary reference to the current scene.
         Scene currentScene = SceneManager.GetActiveScene ();
 
         // Retrieve the name of this scene.
        sceneName = currentScene.name;
    }

    // Update is called once per frame
    void Update()
    {   
        if (IncreaseTime == true){

        if (timeValue > 0) 
        {
        timeValue -= Time.deltaTime;
        }
        else 
        {
            timeValue = 0;
            // tänne mitä tapahtuu kun aika loppuu, joku gameoverscene?
            if (sceneName != "GameOverScene"){
                SceneManager.LoadScene("GameOverScene");
                Debug.Log("Game Over");
                IncreaseTime = false;
            }
        }
        DisplayTime(timeValue);
        }
        if(sceneName == "Loppunäkymä"){
            IncreaseTime = false;
        }
    }
    void DisplayTime(float timeToDisplay){
        if(timeToDisplay < 0){
            timeToDisplay = 0;
        }
        else if (timeToDisplay > 0){
            timeToDisplay += 1;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
