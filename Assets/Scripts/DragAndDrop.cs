using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDrop : MonoBehaviour 
{
    public GameObject snapPosition;
    private bool isDragged = false;
    private Vector3 mouseDragStartPosition;
    private Vector3 spriteDragStartPosition;

    private Vector3 resetPosition;
    

    void Start()
    {
        resetPosition = this.transform.localPosition;
    }

    private void OnMouseDown()
    {
        isDragged = true;
        mouseDragStartPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        spriteDragStartPosition = transform.localPosition;
    }

    private void OnMouseDrag()
    {
        if (isDragged)
        {
            transform.localPosition = spriteDragStartPosition + (Camera.main.ScreenToWorldPoint(Input.mousePosition) - mouseDragStartPosition);
        }
    }

    private void OnMouseUp()
    {
        isDragged = false;

        if (Mathf.Abs(this.transform.localPosition.x - snapPosition.transform.localPosition.x) <= 0.5f &&
            Mathf.Abs(this.transform.localPosition.y - snapPosition.transform.localPosition.y) <= 0.5f ){
            this.transform.position = new Vector3(snapPosition.transform.position.x, snapPosition.transform.position.y, snapPosition.transform.localPosition.z);
            
        }

        else
        {
            this.transform.localPosition = new Vector3(resetPosition.x, resetPosition.y, resetPosition.z);
        }
        
    }
    
}

/**
 * private float startPosX;
    private float startPosY;
    private bool moving;


    void Update()
    {
        if (moving)
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            this.gameObject.transform.localPosition = new Vector3(mousePos.x - startPosX, mousePos.y - startPosY, 0);
            
        }
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            startPosX = mousePos.x - this.transform.localPosition.x;
            startPosY = mousePos.y - this.transform.localPosition.y;

            moving = true;
        }
    }

    private void OnMouseUp()
    {
        moving = false;*/

/**
 * private float startPosX;
private float startPosY;
private bool isBeingHeld;


void Update()
{
    Vector3 mousePos;
    mousePos = Input.mousePosition;
    mousePos = Camera.main.ScreenToWorldPoint(mousePos);
    
    if(isBeingHeld == true)
    {
        this.gameObject.transform.localPosition = new Vector3(mousePos.x -startPosX, mousePos.y - startPosY, 0);
    }
}

private void OnMouseDown()
{
    if (Input.GetMouseButtonDown(0))
    { 
        Vector3 mousePos;
        mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        startPosX = mousePos.x - this.transform.localPosition.x;
        startPosY = mousePos.y - this.transform.localPosition.y;

        isBeingHeld = true;
    }
}

private void OnMouseUp()
{
    isBeingHeld = false;} */

/**
 * public delagate void DragEndedDelegate(DragAndDrop draggableObject);
    public DragEndedDelegate dragEndedCallback;

    private bool isDragged = false;
    private Vector3 mouseDragStartPosition;
    private Vector3 spriteDragStartPosition;


    private void OnMouseDown()
    {
        isDragged = true;
        mouseDragStartPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        spriteDragStartPosition = transform.localPosition;
    }

    private void OnMouseDrag()
    {
        if (isDragged)
        {
            transform.localPosition = spriteDragStartPosition + (Camera.main.ScreenToWorldPoit(Input.mousePosition) - mouseDragStartPosition);
        }
    }

    private void OnMouseUp()
    {
        isDragged = false;
        dragEndedCallback(this);
    }*/


/**
 * //, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
 * void onMouseDrag()
{
    transform.position = GetMousePos();
}

Vector3 GetMousePos()
{
    var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    mousePos.z = 0;
    return mousePos;
}
/** public void OnBeginDrag(PointerEventData eventData)
{
    Debug.Log("OnBeginDrag");
}

public void OnEndDrag(PointerEventData eventData)
{
    Debug.Log("OnEndDrag");
}

public void OnPointerDown(PointerEventData eventData)
{
    Debug.Log("OnPointerDown");
}*/

