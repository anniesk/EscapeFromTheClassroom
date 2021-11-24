using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Eipuzzleenuudestaan : MonoBehaviour
{
    string sceneName;
    Canvas canvas;
    GameObject handler;
    Inventory inventory;
    GameObject hylly;
    GameObject pulpetti1;
    GameObject pulpetti2;
    GameObject blackboard;
    // Start is called before the first frame update
    void Start()
    {
        // haetaan kaikki huonekalut mitkä pitää vaihtaa pois päältä
        hylly = GameObject.Find("Kirjahylly");
        pulpetti1 = GameObject.Find("Pulpetti");
        pulpetti2 = GameObject.Find("Pulpetti (2)");
        blackboard = GameObject.Find("Liitutaulu");

        handler = GameObject.Find("InventoryHandler");
        inventory = handler.GetComponent<Inventory>();
        canvas = GameObject.Find("Canvas").GetComponent<Canvas>();
        Scene currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
    }

    // Update is called once per frame
    void Update()
    {
        // laitetaan istrigget pois päältä kun tietty puzzle valmis ja esine saatu inventaarioon.
        for(int i = 0; i < inventory.Itemlist.Count; i++){
             if(inventory.Itemlist[i] != null && inventory.Itemlist[i].itemName == "Ruuvimeisseli" && sceneName == "SampleScene"){
                 hylly.GetComponent<Collider2D>().isTrigger = false;
            }
            else if (inventory.Itemlist[i] != null && inventory.Itemlist[i].itemName == "Akku" && sceneName == "SampleScene"){
                 pulpetti2.GetComponent<Collider2D>().isTrigger = false;
            }
            else if (inventory.Itemlist[i] != null && inventory.Itemlist[i].itemName == "Liitu" && sceneName == "SampleScene"){
                 pulpetti1.GetComponent<Collider2D>().isTrigger = false;
            }
            else if (inventory.Itemlist[i] != null && inventory.Itemlist[i].itemName == "DoorAvain" && sceneName == "SampleScene"){
                 blackboard.GetComponent<Collider2D>().isTrigger = false;
            }
        }
    }
}
