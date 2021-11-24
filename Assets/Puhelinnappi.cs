 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 using UnityEngine.UI;

 public class Puhelinnappi : MonoBehaviour
 {
     int slotnumber;
     public Button button;
     public Button button2;
     public Button button3;
     public Button button4;
     public Button button5;
     public GameObject craft;
     GameObject handler;
     Item a;
     Item b;
     Inventory inventory;
     // Start is called before the first frame update
     void Start()
     {
         //button.gameObject.SetActive(false);
         craft.SetActive(false);
         button.interactable = false;
         button2.interactable = false;
         button3.interactable = false;
         button4.interactable = false;
         button5.interactable = false;
         handler = GameObject.Find("InventoryHandler");
         inventory = handler.GetComponent<Inventory>();
        
     }

     // Update is called once per frame
     void Update()
     {
         // tarkista että molemmat puhelimen osat on jotta voi näyttää napin
        for(int i = 0; i < inventory.Itemlist.Count; i++){
             if(inventory.Itemlist[i] != null && inventory.Itemlist[i].itemName == "Akku"){
                a = inventory.Itemlist[i];
             }
             else if (inventory.Itemlist[i] != null && inventory.Itemlist[i].itemName == "PuhelinEIAKKUA"){
                 b = inventory.Itemlist[i];
             }
        }

         // craftaysnappi näkyviin.
         if(a != null && b != null){
             craft.SetActive(true);
         }



         // tarkista että on craftatty puhelin jotta  voi laittaa napin painettavaksi jotta voi siirtyä uuteen skeneen
         if(inventory.Itemlist != null){
         for (int i = 0; i < inventory.Itemlist.Count; i++ ){
            
             if (inventory.Itemlist[i] == null){
                 break;
             }
             else if (inventory.Itemlist[i].itemName == "Puhelin"){
                 slotnumber = i;
                 
                 // tarkistetaan minkä slotin nappula laitetaan klikattavaksi
                 if (slotnumber == 0){
                     button.interactable = true;
                 }
                 else if (slotnumber == 1){
                     button2.interactable = true;
                 }
                 else if (slotnumber == 2){
                     button3.interactable = true;
                 }
                 else if (slotnumber == 3){
                     button4.interactable = true;
                 }
                 else if (slotnumber == 4){
                     button5.interactable = true;
                 }
                 craft.SetActive(false);
             }
        }
        }
        // jos puzzle tehty ja avain saatu ei pääse puzzleen uudestaan.
        for(int i = 0; i < inventory.Itemlist.Count; i++){
             if(inventory.Itemlist[i] != null && inventory.Itemlist[i].itemName == "Avain"){
                 if (slotnumber == 0){
                     button.interactable = false;
                 }
                 else if (slotnumber == 1){
                     button2.interactable = false;
                 }
                 else if (slotnumber == 2){
                     button3.interactable = false;
                 }
                 else if (slotnumber == 3){
                     button4.interactable = false;
                 }
                 else if (slotnumber == 4){
                     button5.interactable = false;
                 }
             }
        }
     }
 }
