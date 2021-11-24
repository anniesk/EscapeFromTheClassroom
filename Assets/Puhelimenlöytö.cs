using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Puhelimenlöytö : MonoBehaviour
{
    string sceneName;
    public GameObject button;
    public Canvas canvas;
    GameObject handler;
    Inventory inventory;
    bool check;
    // Start is called before the first frame update
    void Start()
    {
        handler = GameObject.Find("InventoryHandler");
        inventory = handler.GetComponent<Inventory>();
        canvas = GameObject.Find("Canvas").GetComponent<Canvas>();
        button = canvas.transform.Find("PhoneButton").gameObject;
        Debug.Log(button);
        Scene currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < inventory.Itemlist.Count; i++){
             if(inventory.Itemlist[i] != null && inventory.Itemlist[i].itemName == "PuhelinEIAKKUA" && sceneName == "SampleScene"){
                 // puhelin saatu joten laitetaan trigger pois päältä taas
                 this.gameObject.GetComponent<Collider2D>().isTrigger = false;
             }
             else if (inventory.Itemlist[i] != null && inventory.Itemlist[i].itemName == "PuhelinEIAKKUA" && sceneName == "PuhelinScene"){
                 check = true;
                 break;
             }
             else {
                 check = false;
             }
        }
        if (check == false && sceneName == "PuhelinScene"){
            // nappula esiin
            button.SetActive(true);
        }
        
        if (check == false && sceneName == "SampleScene"){
            button.SetActive(false);
        }
    } 
}
