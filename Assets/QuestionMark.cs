using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionMark : MonoBehaviour
{
    public GameObject button;
    public Canvas canvas;


    SpriteRenderer spriteRenderer;
    public Sprite questionmark;
    public Sprite lettera;
    public Sprite lettere;
    public Sprite letteri;
    public Sprite lettero;
    public Sprite letteru;
    public AudioSource done;

    void Start() {
        canvas = GameObject.Find("Canvas").GetComponent<Canvas>();
        button = canvas.transform.Find("CipherButton").gameObject;
        Debug.Log("start function");
    }

    public void OnMouseDown() {
        if(spriteRenderer.sprite == questionmark)
        {
            spriteRenderer.sprite = lettera;
        }
        else if(spriteRenderer.sprite == lettera)
        {
            spriteRenderer.sprite = lettere;
        }
        else if(spriteRenderer.sprite == lettere)
        {
            spriteRenderer.sprite = letteri;
        }
        else if(spriteRenderer.sprite == letteri)
        {
            spriteRenderer.sprite = lettero;
        }
        else if(spriteRenderer.sprite == lettero)
        {
            spriteRenderer.sprite = letteru;
        }
        else {
            spriteRenderer.sprite = questionmark;
        }
        if (GameObject.Find("QM1").GetComponent<SpriteRenderer>().sprite == letteri) {
            if (GameObject.Find("QM2").GetComponent<SpriteRenderer>().sprite == lettera) {
                if (GameObject.Find("QM3").GetComponent<SpriteRenderer>().sprite == letteru) {
                    Debug.Log("Kaikki oikein!");
                    done.Play();

                    Debug.Log(button);
                    button.SetActive(true);

                }
            }
        }
    }

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
}
