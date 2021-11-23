using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    GameObject token;

    public GameObject button;
    public Canvas canvas;

    public bool Tila1;
    public bool Tila2;
    public bool Tila3;
    public bool Tila4;
    public bool Tila5;
    public bool Tila6;
    public bool Tila7;
    public bool Tila8;
    public bool Tila9;
    public bool Tila10;
    public bool Tila11;
    public bool Tila12;

    public bool Loydettyget;
    public bool Loydettybuy;
    public bool Loydettybe;
    public bool Loydettybring;

    public AudioSource done;

    public int kuinkamontakaannetty;

    public Sprite back;
    public Sprite Ruutu1;
    public Sprite Ruutu2;
    public Sprite Ruutu3;
    public Sprite Ruutu4;
    public Sprite Ruutu5;
    public Sprite Ruutu6;
    public Sprite Ruutu7;
    public Sprite Ruutu8;
    public Sprite Ruutu9;
    public Sprite Ruutu10;
    public Sprite Ruutu11;
    public Sprite Ruutu12;

    public void Start()
    {
        Tila1 = false;
        Tila2 = false;
        Tila3 = false;
        Tila4 = false;
        Tila5 = false;
        Tila6 = false;
        Tila7 = false;
        Tila8 = false;
        Tila9 = false;
        Tila10 = false;
        Tila11 = false;
        Tila12 = false;
        Loydettyget = false;
        Loydettybuy = false;
        Loydettybe = false;
        Loydettybring = false;
        kuinkamontakaannetty = 0;
        canvas = GameObject.Find("Canvas").GetComponent<Canvas>();
        button = canvas.transform.Find("memoryButton").gameObject;
    }

    public void Tarkista() {
        if (Tila3 && Tila5 && Tila12) {
            Loydettyget = true;
        }
        if (Tila7 && Tila2 && Tila11) {
            Loydettybuy = true;
        }
        if (Tila10 && Tila6 && Tila1) {
            Loydettybe = true;
        }
        if (Tila9 && Tila4 && Tila8) {
            Loydettybring = true;
        }
        if (Loydettybe && Loydettybring && Loydettybuy && Loydettyget) {
            button.SetActive(true);
            done.Play();
        }
    }

    public void KaannaEiLoydetyt() {    
        GameObject.Find("Token1").GetComponent<SpriteRenderer>().sprite = back;
        GameObject.Find("Token2").GetComponent<SpriteRenderer>().sprite = back;
        GameObject.Find("Token3").GetComponent<SpriteRenderer>().sprite = back;
        GameObject.Find("Token4").GetComponent<SpriteRenderer>().sprite = back;
        GameObject.Find("Token5").GetComponent<SpriteRenderer>().sprite = back;
        GameObject.Find("Token6").GetComponent<SpriteRenderer>().sprite = back;
        GameObject.Find("Token7").GetComponent<SpriteRenderer>().sprite = back;
        GameObject.Find("Token8").GetComponent<SpriteRenderer>().sprite = back;
        GameObject.Find("Token9").GetComponent<SpriteRenderer>().sprite = back;
        GameObject.Find("Token10").GetComponent<SpriteRenderer>().sprite = back;
        GameObject.Find("Token11").GetComponent<SpriteRenderer>().sprite = back;
        GameObject.Find("Token12").GetComponent<SpriteRenderer>().sprite = back;
        Tila1 = false;
        Tila2 = false;
        Tila3 = false;
        Tila4 = false;
        Tila5 = false;
        Tila6 = false;
        Tila7 = false;
        Tila8 = false;
        Tila9 = false;
        Tila10 = false;
        Tila11 = false;
        Tila12 = false;
        if (Loydettyget) {
            GameObject.Find("Token3").GetComponent<SpriteRenderer>().sprite = Ruutu3;
            GameObject.Find("Token5").GetComponent<SpriteRenderer>().sprite = Ruutu5;
            GameObject.Find("Token12").GetComponent<SpriteRenderer>().sprite = Ruutu12;
            Tila3 = true;
            Tila5 = true;
            Tila12 = true;
        }
        if (Loydettybuy) {
            GameObject.Find("Token7").GetComponent<SpriteRenderer>().sprite = Ruutu7;
            GameObject.Find("Token2").GetComponent<SpriteRenderer>().sprite = Ruutu2;
            GameObject.Find("Token11").GetComponent<SpriteRenderer>().sprite = Ruutu11;
            Tila7 = true;
            Tila2 = true;
            Tila11 = true;
        }
        if (Loydettybe) {
            GameObject.Find("Token10").GetComponent<SpriteRenderer>().sprite = Ruutu10;
            GameObject.Find("Token6").GetComponent<SpriteRenderer>().sprite = Ruutu6;
            GameObject.Find("Token1").GetComponent<SpriteRenderer>().sprite = Ruutu1;
            Tila10 = true;
            Tila6 = true;
            Tila1 = true;
        }
        if (Loydettybring) {
            GameObject.Find("Token9").GetComponent<SpriteRenderer>().sprite = Ruutu9;
            GameObject.Find("Token4").GetComponent<SpriteRenderer>().sprite = Ruutu4;
            GameObject.Find("Token8").GetComponent<SpriteRenderer>().sprite = Ruutu8;
            Tila9 = true;
            Tila4 = true;
            Tila8 = true;
        }
    }

    private void Awake()
    {
        token = GameObject.Find("Token");
    }
}
