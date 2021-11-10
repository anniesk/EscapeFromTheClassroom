using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
   public Item item;
   public GameObject icon;

   public void UpdateSlot(){
       if(item != null){
           icon.GetComponent<Image>().sprite = item.icon;
           icon.SetActive(true);
       }
       // tämä ei päivitä UI inventaariota kun poistan vanhat?? miksi?
       else{
           icon.GetComponent<Image>().sprite = null;
       }
   }
}
