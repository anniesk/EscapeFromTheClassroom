using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicloop : MonoBehaviour
{
    public AudioSource music;

    // Update is called once per frame
    void Update()
    {
        if(music.time > 254f){
            music.time = 64f;
            music.Play();
        }
    }
}
