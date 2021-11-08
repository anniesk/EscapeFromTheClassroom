using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{   
public GameObject button1;
public GameObject button2;

    public Item[] Itemlist = new Item[5];

    public List<InventorySlot> inventorySlots = new List<InventorySlot>(5);

    private bool add(Item item){
        for(int i = 0; i < Itemlist.Length; i++){
            if(Itemlist[i] == null){
                Itemlist[i] = item;
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
        button1.SetActive(false);
        button2.SetActive(false);
    }

    public void Awake (){
        button2.SetActive(false);
        GameObject.DontDestroyOnLoad(this.gameObject);
    }
}
