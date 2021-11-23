using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{   
public GameObject puhelin;
public GameObject cipher;
public GameObject muistipeli;
public GameObject liitutaulu;
public GameObject doorkey;

public GameObject ristikko;

public static Inventory Instance;

   // public Item[] Itemlist = new Item[5];
   public List<Item> Itemlist = new List<Item>(5);

    public List<InventorySlot> inventorySlots = new List<InventorySlot>(5);

    private bool add(Item item){
        for(int i = 0; i < Itemlist.Count; i++){
            if(Itemlist[i] == null){
                Itemlist[i] = item;
                Debug.Log(item);
                Debug.Log(Itemlist[i]);
                inventorySlots[i].item = item;
                return true;
            }
        }
        return false;
    }
    public void UpdateSlotUI(){
        for(int i = 0; i < inventorySlots.Count; i++){
           inventorySlots[i].UpdateSlot();
        }
    }
    public void AddItem(Item item){
        bool hasAdded = add(item);
        if(hasAdded){
            UpdateSlotUI();
        }
        // aina tarkistetaan että kaikki nappulat on piilotettu
        puhelin.SetActive(false);
        cipher.SetActive(false);
        ristikko.SetActive(false);
        liitutaulu.SetActive(false);
        muistipeli.SetActive(false);
        doorkey.SetActive(false);
    }

    public void Awake (){
        // kaikki nappulat piilotettu
        puhelin.SetActive(false);
        cipher.SetActive(false);
        ristikko.SetActive(false);
        liitutaulu.SetActive(false);
        muistipeli.SetActive(false);
        doorkey.SetActive(false);
    }

    public void CraftPhone(Item newItem){
        Item a = null;
        Item b = null;
        //Item apu;
        int c = 0;
        int d = 0;
        for(int i = 0; i < Itemlist.Count; i++){
            // otetaan tässä puhelimen osat muuttujiin, numerotkin vaikka
            if(Itemlist[i] != null && Itemlist[i].type.Equals(Item.Type.Phone)){
                 //apu = Itemlist[i];
                if (a != null){
                    b = Itemlist[i];
                    d = i;
                }
                else {
                    a = Itemlist[i];
                    c = i;
                }
            }
        }
        if (a != null && b != null){
        // täällä laitetaan puhelin listaan ja poistetaan vanhat
        Itemlist[c] = null;
        inventorySlots[c].item = null;
        Itemlist[d] = null;
        inventorySlots[d].item = null;
        UpdateSlotUI();
        AddItem(newItem);
       
        }        
    }
    public void Start(){
        
       if (Instance == null) {
           Instance = this;
       } else if (Instance != this)
     {
         Destroy (gameObject);
       }
       DontDestroyOnLoad (gameObject);
    }
}
