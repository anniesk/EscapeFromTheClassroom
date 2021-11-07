using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName ="Inventory/Item")]
public class Item : ScriptableObject
{
  public string itemName = "New Item";
  public string Itemdescription = "New Description";
  public Sprite icon;
  public enum Type {
      Default,
      Phone,
      Key,
      Chalk
  }
  public Type type = Type.Default;
}
