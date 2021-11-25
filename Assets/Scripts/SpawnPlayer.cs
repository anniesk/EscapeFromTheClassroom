using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class SpawnPlayer : MonoBehaviour
{
     public static Vector3 spawn = new Vector3(-7, -5, 0);
    // Start is called before the first frame update
    void Start()
    {
        transform.position = spawn;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
