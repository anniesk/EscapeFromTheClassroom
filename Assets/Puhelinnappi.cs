 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 using UnityEngine.UI;

 public class Puhelinnappi : MonoBehaviour
 {

     public Button button;
     public GameObject button2;
     GameObject handler;
     Item a;
     Item b;
     Inventory inventory;
     // Start is called before the first frame update
     void Start()
     {
         //button.gameObject.SetActive(false);
         button2.SetActive(false);
         button.interactable = false;
         handler = GameObject.Find("InventoryHandler");
         Debug.Log(handler);
         inventory = handler.GetComponent<Inventory>();
         Debug.Log(inventory);
     }

     // Update is called once per frame
     void Update()
     {
         // tarkista että molemmat puhelimen osat on jotta voi näyttää napin
        for(int i = 0; i < inventory.Itemlist.Count; i++){
             if(inventory.Itemlist[i] != null && inventory.Itemlist[i].itemName == "Akku"){
                a = inventory.Itemlist[i];
             }
             else if (inventory.Itemlist[i] != null && inventory.Itemlist[i].itemName == "Phone"){
                 b = inventory.Itemlist[i];
             }
        }

         // craftaysnappi näkyviin.
         if(a != null && b != null){
             button2.SetActive(true);
         }



         // tarkista että on craftatty puhelin jotta  voi laittaa napin painettavaksi jotta voi siirtyä uuteen skeneen
         if(inventory.Itemlist != null){
         for (int i = 0; i < inventory.Itemlist.Count; i++ ){
            
             if (inventory.Itemlist[i] == null){
                 break;
             }
             else if (inventory.Itemlist[i].itemName == "Puhelin"){
                 //button.gameObject.SetActive(true);
                 button.interactable = true;
                 button2.SetActive(false);
             }
        }
        }
        
     }
 }
