using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScenes2D : MonoBehaviour
{
    [SerializeField] private string newLevel;
    GameObject handler;
    Inventory inventory;
    bool check;

    void Start(){
        handler = GameObject.Find("InventoryHandler");
         inventory = handler.GetComponent<Inventory>();
    }

    void OnTriggerEnter2D(Collider2D other) { 
        //oven avaus ja avaimen tarkistus
        if(other.CompareTag("Player") && this.gameObject.name == "Ovi"){
                 for(int i = 0; i < inventory.Itemlist.Count; i++){
                     if(inventory.Itemlist[i] != null && inventory.Itemlist[i].itemName == "Avain"){
                         SceneManager.LoadScene(newLevel);
                         check = true;
                        }
                        else {
                            check = false;
                        }
                    }
                    if (check == false){
                        // mitä tapahtuu jos ei avainta
                        Debug.Log("Ei avainta.");
                    }
            }

        else if(other.CompareTag("Player"))
        {
            
            SceneManager.LoadScene(newLevel);
        }
    }
    public void OnClick(){
            SceneManager.LoadScene(newLevel);
    }

}

