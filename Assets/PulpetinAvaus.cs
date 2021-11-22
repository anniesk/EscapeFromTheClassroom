using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class PulpetinAvaus : MonoBehaviour, IPointerClickHandler,
                                  IPointerDownHandler, IPointerEnterHandler,
                                  IPointerUpHandler, IPointerExitHandler
{
    GameObject handler;
Inventory inventory;
    public Button pulpetti;

    void Start()
    {
        //Attach Physics2DRaycaster to the Camera
        Camera.main.gameObject.AddComponent<Physics2DRaycaster>();
        handler = GameObject.Find("InventoryHandler");
        inventory = handler.GetComponent<Inventory>();
        addEventSystem();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        //Debug.Log("Mouse Clicked!");
        for(int i = 0; i < inventory.Itemlist.Count; i++){
            if(inventory.Itemlist[i] != null && inventory.Itemlist[i].itemName == "Ruuvimeisseli"){
                 SceneManager.LoadScene("PuzzleDScene");
            }
            else {
                GetComponent<AudioSource>().Play();
                Debug.Log("Pelaajalla ei ole ruuvimeisseliä inventaariossa");
            }
         } 
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Mouse Down!");
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Mouse Enter!");
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log("Mouse Up!");
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Mouse Exit!");
    }

    //Add Event System to the Camera
    void addEventSystem()
    {
        GameObject eventSystem = null;
        GameObject tempObj = GameObject.Find("EventSystem");
        if (tempObj == null)
        {
            eventSystem = new GameObject("EventSystem");
            eventSystem.AddComponent<EventSystem>();
            eventSystem.AddComponent<StandaloneInputModule>();
        }
        else
        {
            if ((tempObj.GetComponent<EventSystem>()) == null)
            {
                tempObj.AddComponent<EventSystem>();
            }

            if ((tempObj.GetComponent<StandaloneInputModule>()) == null)
            {
                tempObj.AddComponent<StandaloneInputModule>();
            }
        }
    }
}

