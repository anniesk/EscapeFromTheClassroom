using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dontdestoryonload : MonoBehaviour
{

    public static Dontdestoryonload Instance;
    // Start is called before the first frame update
    void Start(){
        
       if (Instance == null) {
           Instance = this;
       } else if (Instance != this)
     {
         Destroy (gameObject);
       }
 
       DontDestroyOnLoad (gameObject);
    }
        /*
        if(Instance != null){
            Destroy(this.gameObject);
        }
        Instance = this;
       GameObject.DontDestroyOnLoad(this.gameObject);
       */

    // Update is called once per frame
    void Update()
    {
        
    }
}
