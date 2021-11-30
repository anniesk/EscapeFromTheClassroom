using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterBox : MonoBehaviour
{
    public AudioSource success;
    public AudioSource fail;
    public GameObject button;
    public Canvas canvas;
    SpriteRenderer spriteRenderer;
    public Sprite empty;
    public Sprite grey;
    public Sprite lettera;
    public Sprite letterb;
    public Sprite letterc;
    public Sprite letterd;
    public Sprite lettere;
    public Sprite letterf;
    public Sprite letterg;
    public Sprite letterh;
    public Sprite letteri;
    public Sprite letterj;
    public Sprite letterk;
    public Sprite letterl;
    public Sprite letterm;
    public Sprite lettern;
    public Sprite lettero;
    public Sprite letterp;
    public Sprite letterq;
    public Sprite letterr;
    public Sprite letters;
    public Sprite lettert;
    public Sprite letteru;
    public Sprite letterv;
    public Sprite letterw;
    public Sprite letterx;
    public Sprite lettery;
    public Sprite letterz;

    public int edellinen;
    public bool alas;

    bool holdingDown;

    // Start is called before the first frame update
    void Start()
    {
        // Ristikkopelin alkaessa varjataan ensimmainen kirjain harmaaksi ja suunnaksi asetetaan alas
        GameObject.Find("Letter1").GetComponent<SpriteRenderer>().sprite = grey;
        GameObject.Find("Ristikko").GetComponent<RistikkoLogiikka>().Alas = true;
        GameObject.Find("Ristikko").GetComponent<RistikkoLogiikka>().Eteenpain = true;
        canvas = GameObject.Find("Canvas").GetComponent<Canvas>();
        button = canvas.transform.Find("RistikkoButton").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown && !(Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1) || Input.GetMouseButtonDown(2)))
        {
            holdingDown = true;
            GameObject.Find("Ristikko").GetComponent<RistikkoLogiikka>().Eteenpain = true;
            for (int i = 1; i < 26; i++)
            {
                if (GameObject.Find("Letter" + i).GetComponent<SpriteRenderer>().sprite == grey)
                {
                    edellinen = i;
                    Debug.Log(edellinen);

                    if (Input.GetKeyDown(KeyCode.A))
                    {
                        GameObject.Find("Letter" + i).GetComponent<SpriteRenderer>().sprite = lettera;
                    }
                    else if (Input.GetKeyDown(KeyCode.B))
                    {
                        GameObject.Find("Letter" + i).GetComponent<SpriteRenderer>().sprite = letterb;
                    }
                    else if (Input.GetKeyDown(KeyCode.C))
                    {
                        GameObject.Find("Letter" + i).GetComponent<SpriteRenderer>().sprite = letterc;
                    }
                    else if (Input.GetKeyDown(KeyCode.D))
                    {
                        GameObject.Find("Letter" + i).GetComponent<SpriteRenderer>().sprite = letterd;
                    }
                    else if (Input.GetKeyDown(KeyCode.E))
                    {
                        GameObject.Find("Letter" + i).GetComponent<SpriteRenderer>().sprite = lettere;
                    }
                    else if (Input.GetKeyDown(KeyCode.F))
                    {
                        GameObject.Find("Letter" + i).GetComponent<SpriteRenderer>().sprite = letterf;
                    }
                    else if (Input.GetKeyDown(KeyCode.G))
                    {
                        GameObject.Find("Letter" + i).GetComponent<SpriteRenderer>().sprite = letterg;
                    }
                    else if (Input.GetKeyDown(KeyCode.H))
                    {
                        GameObject.Find("Letter" + i).GetComponent<SpriteRenderer>().sprite = letterh;
                    }
                    else if (Input.GetKeyDown(KeyCode.I))
                    {
                        GameObject.Find("Letter" + i).GetComponent<SpriteRenderer>().sprite = letteri;
                    }
                    else if (Input.GetKeyDown(KeyCode.J))
                    {
                        GameObject.Find("Letter" + i).GetComponent<SpriteRenderer>().sprite = letterj;
                    }
                    else if (Input.GetKeyDown(KeyCode.K))
                    {
                        GameObject.Find("Letter" + i).GetComponent<SpriteRenderer>().sprite = letterk;
                    }
                    else if (Input.GetKeyDown(KeyCode.L))
                    {
                        GameObject.Find("Letter" + i).GetComponent<SpriteRenderer>().sprite = letterl;
                    }
                    else if (Input.GetKeyDown(KeyCode.M))
                    {
                        GameObject.Find("Letter" + i).GetComponent<SpriteRenderer>().sprite = letterm;
                    }
                    else if (Input.GetKeyDown(KeyCode.N))
                    {
                        GameObject.Find("Letter" + i).GetComponent<SpriteRenderer>().sprite = lettern;
                    }
                    else if (Input.GetKeyDown(KeyCode.O))
                    {
                        GameObject.Find("Letter" + i).GetComponent<SpriteRenderer>().sprite = lettero;
                    }
                    else if (Input.GetKeyDown(KeyCode.P))
                    {
                        GameObject.Find("Letter" + i).GetComponent<SpriteRenderer>().sprite = letterp;
                    }
                    else if (Input.GetKeyDown(KeyCode.Q))
                    {
                        GameObject.Find("Letter" + i).GetComponent<SpriteRenderer>().sprite = letterq;
                    }
                    else if (Input.GetKeyDown(KeyCode.R))
                    {
                        GameObject.Find("Letter" + i).GetComponent<SpriteRenderer>().sprite = letterr;
                    }
                    else if (Input.GetKeyDown(KeyCode.S))
                    {
                        GameObject.Find("Letter" + i).GetComponent<SpriteRenderer>().sprite = letters;
                    }
                    else if (Input.GetKeyDown(KeyCode.T))
                    {
                        GameObject.Find("Letter" + i).GetComponent<SpriteRenderer>().sprite = lettert;
                    }
                    else if (Input.GetKeyDown(KeyCode.U))
                    {
                        GameObject.Find("Letter" + i).GetComponent<SpriteRenderer>().sprite = letteru;
                    }
                    else if (Input.GetKeyDown(KeyCode.V))
                    {
                        GameObject.Find("Letter" + i).GetComponent<SpriteRenderer>().sprite = letterv;
                    }
                    else if (Input.GetKeyDown(KeyCode.W))
                    {
                        GameObject.Find("Letter" + i).GetComponent<SpriteRenderer>().sprite = letterw;
                    }
                    else if (Input.GetKeyDown(KeyCode.X))
                    {
                        GameObject.Find("Letter" + i).GetComponent<SpriteRenderer>().sprite = letterx;
                    }
                    else if (Input.GetKeyDown(KeyCode.Y))
                    {
                        GameObject.Find("Letter" + i).GetComponent<SpriteRenderer>().sprite = lettery;
                    }
                    else if (Input.GetKeyDown(KeyCode.Z))
                    {
                        GameObject.Find("Letter" + i).GetComponent<SpriteRenderer>().sprite = letterz;
                    }
                    else if (Input.GetKeyDown(KeyCode.Backspace))
                    {
                        GameObject.Find("Ristikko").GetComponent<RistikkoLogiikka>().Eteenpain = false;
                    }
                    else
                    {
                        GameObject.Find("Letter" + i).GetComponent<SpriteRenderer>().sprite = empty;
                    }
                }
            }
        }

        if (!Input.anyKey && holdingDown)
        {
            holdingDown = false;
            if (GameObject.Find("Ristikko").GetComponent<RistikkoLogiikka>().Eteenpain == true)
            {
                LiikuEteenpain();
            }
            else
            {
                LiikuTakaisinpain();
            }
        }
    }

    public void LiikuTakaisinpain()
    {
        if (edellinen == 1)
        {
            GameObject.Find("Letter1").GetComponent<SpriteRenderer>().sprite = empty;
            GameObject.Find("Letter24").GetComponent<SpriteRenderer>().sprite = grey;
        }
        else if (edellinen == 2)
        {
            GameObject.Find("Letter2").GetComponent<SpriteRenderer>().sprite = empty;
            GameObject.Find("Letter1").GetComponent<SpriteRenderer>().sprite = grey;
        }
        else if (edellinen == 3)
        {
            GameObject.Find("Letter3").GetComponent<SpriteRenderer>().sprite = empty;
            if (GameObject.Find("Ristikko").GetComponent<RistikkoLogiikka>().Alas == true)
            {
                GameObject.Find("Letter2").GetComponent<SpriteRenderer>().sprite = grey;
            }
            else
            {
                GameObject.Find("Letter4").GetComponent<SpriteRenderer>().sprite = grey;
            }
        }
        else if (edellinen == 4)
        {
            GameObject.Find("Letter4").GetComponent<SpriteRenderer>().sprite = empty;
            GameObject.Find("Letter5").GetComponent<SpriteRenderer>().sprite = grey;
        }
        else if (edellinen == 5)
        {
            GameObject.Find("Letter5").GetComponent<SpriteRenderer>().sprite = empty;
            GameObject.Find("Letter6").GetComponent<SpriteRenderer>().sprite = grey;
        }
        else if (edellinen == 6)
        {
            GameObject.Find("Letter6").GetComponent<SpriteRenderer>().sprite = empty;
            if (GameObject.Find("Ristikko").GetComponent<RistikkoLogiikka>().Alas == true)
            {
                GameObject.Find("Letter3").GetComponent<SpriteRenderer>().sprite = grey;
            }
            else
            {
                GameObject.Find("Letter7").GetComponent<SpriteRenderer>().sprite = grey;
            }
        }
        else if (edellinen == 7)
        {
            GameObject.Find("Letter7").GetComponent<SpriteRenderer>().sprite = empty;
            GameObject.Find("Letter8").GetComponent<SpriteRenderer>().sprite = grey;
        }
        else if (edellinen == 8)
        {
            GameObject.Find("Letter8").GetComponent<SpriteRenderer>().sprite = empty;
            GameObject.Find("Letter3").GetComponent<SpriteRenderer>().sprite = grey;
            GameObject.Find("Ristikko").GetComponent<RistikkoLogiikka>().Alas = true;
        }
        else if (edellinen == 9)
        {
            GameObject.Find("Letter9").GetComponent<SpriteRenderer>().sprite = empty;
            GameObject.Find("Letter6").GetComponent<SpriteRenderer>().sprite = grey;
        }
        else if (edellinen == 10)
        {
            GameObject.Find("Letter10").GetComponent<SpriteRenderer>().sprite = empty;
            GameObject.Find("Letter9").GetComponent<SpriteRenderer>().sprite = grey;
        }
        else if (edellinen == 11)
        {
            GameObject.Find("Letter11").GetComponent<SpriteRenderer>().sprite = empty;
            GameObject.Find("Letter10").GetComponent<SpriteRenderer>().sprite = grey;
        }
        else if (edellinen == 12)
        {
            GameObject.Find("Letter12").GetComponent<SpriteRenderer>().sprite = empty;
            GameObject.Find("Letter11").GetComponent<SpriteRenderer>().sprite = grey;
        }
        else if (edellinen == 13)
        {
            GameObject.Find("Letter13").GetComponent<SpriteRenderer>().sprite = empty;
            GameObject.Find("Letter14").GetComponent<SpriteRenderer>().sprite = grey;
        }
        else if (edellinen == 14)
        {
            GameObject.Find("Letter14").GetComponent<SpriteRenderer>().sprite = empty;
            if (GameObject.Find("Ristikko").GetComponent<RistikkoLogiikka>().Alas == true)
            {
                GameObject.Find("Letter12").GetComponent<SpriteRenderer>().sprite = grey;
            }
            else
            {
                GameObject.Find("Letter15").GetComponent<SpriteRenderer>().sprite = grey;
            }
        }
        else if (edellinen == 15)
        {
            GameObject.Find("Letter15").GetComponent<SpriteRenderer>().sprite = empty;
            GameObject.Find("Letter18").GetComponent<SpriteRenderer>().sprite = grey;
        }
        else if (edellinen == 16)
        {
            GameObject.Find("Letter16").GetComponent<SpriteRenderer>().sprite = empty;
            GameObject.Find("Letter14").GetComponent<SpriteRenderer>().sprite = grey;
        }
        else if (edellinen == 17)
        {
            GameObject.Find("Letter17").GetComponent<SpriteRenderer>().sprite = empty;
            GameObject.Find("Letter25").GetComponent<SpriteRenderer>().sprite = grey;
        }
        else if (edellinen == 18)
        {
            GameObject.Find("Letter18").GetComponent<SpriteRenderer>().sprite = empty;
            if (GameObject.Find("Ristikko").GetComponent<RistikkoLogiikka>().Alas == true)
            {
                GameObject.Find("Letter16").GetComponent<SpriteRenderer>().sprite = grey;
            }
            else
            {
                GameObject.Find("Letter17").GetComponent<SpriteRenderer>().sprite = grey;
            }
        }
        else if (edellinen == 19)
        {
            GameObject.Find("Letter19").GetComponent<SpriteRenderer>().sprite = empty;
            GameObject.Find("Letter18").GetComponent<SpriteRenderer>().sprite = grey;
        }
        else if (edellinen == 20)
        {
            GameObject.Find("Letter20").GetComponent<SpriteRenderer>().sprite = empty;
            GameObject.Find("Letter19").GetComponent<SpriteRenderer>().sprite = grey;
        }
        else if (edellinen == 21)
        {
            GameObject.Find("Letter21").GetComponent<SpriteRenderer>().sprite = empty;
            GameObject.Find("Letter13").GetComponent<SpriteRenderer>().sprite = grey;
        }
        else if (edellinen == 22)
        {
            GameObject.Find("Letter22").GetComponent<SpriteRenderer>().sprite = empty;
            GameObject.Find("Letter21").GetComponent<SpriteRenderer>().sprite = grey;
        }
        else if (edellinen == 23)
        {
            GameObject.Find("Letter23").GetComponent<SpriteRenderer>().sprite = empty;
            if (GameObject.Find("Ristikko").GetComponent<RistikkoLogiikka>().Alas == true)
            {
                GameObject.Find("Letter20").GetComponent<SpriteRenderer>().sprite = grey;
            }
            else
            {
                GameObject.Find("Letter22").GetComponent<SpriteRenderer>().sprite = grey;
            }
        }
        else if (edellinen == 24)
        {
            GameObject.Find("Letter24").GetComponent<SpriteRenderer>().sprite = empty;
            GameObject.Find("Letter23").GetComponent<SpriteRenderer>().sprite = grey;
        }
        else if (edellinen == 25)
        {
            GameObject.Find("Letter25").GetComponent<SpriteRenderer>().sprite = empty;
            GameObject.Find("Letter23").GetComponent<SpriteRenderer>().sprite = grey;
        }
        edellinen = 0;
    }

    public void LiikuEteenpain()
    {
        if (edellinen == 1)
        {
            if (GameObject.Find("Letter2").GetComponent<SpriteRenderer>().sprite == empty)
            {
                GameObject.Find("Letter2").GetComponent<SpriteRenderer>().sprite = grey;
            }
            else
            {
                edellinen = 2;
                GameObject.Find("Ristikko").GetComponent<RistikkoLogiikka>().Alas = true;
                LiikuEteenpain();
            }
        }
        else if (edellinen == 2)
        {
            if (GameObject.Find("Letter3").GetComponent<SpriteRenderer>().sprite == empty)
            {
                GameObject.Find("Letter3").GetComponent<SpriteRenderer>().sprite = grey;
            }
            else
            {
                edellinen = 3;
                LiikuEteenpain();
            }
        }
        else if (edellinen == 3)
        {
            if (GameObject.Find("Ristikko").GetComponent<RistikkoLogiikka>().Alas == true)
            {
                if (GameObject.Find("Letter8").GetComponent<SpriteRenderer>().sprite == empty)
                {
                    GameObject.Find("Letter8").GetComponent<SpriteRenderer>().sprite = grey;
                    GameObject.Find("Letter8").GetComponent<AudioSource>().Play();
                }
                else
                {
                    edellinen = 8;
                    LiikuEteenpain();
                }
            }
            else
            {
                if (GameObject.Find("Letter9").GetComponent<SpriteRenderer>().sprite == empty)
                {
                    GameObject.Find("Letter9").GetComponent<SpriteRenderer>().sprite = grey;
                }
                else
                {
                    edellinen = 9;
                    LiikuEteenpain();
                }
            }
        }
        else if (edellinen == 8)
        {
            GameObject.Find("Ristikko").GetComponent<RistikkoLogiikka>().Alas = false;
            if (GameObject.Find("Letter7").GetComponent<SpriteRenderer>().sprite == empty)
            {
                GameObject.Find("Letter7").GetComponent<SpriteRenderer>().sprite = grey;
            }
            else
            {
                edellinen = 7;
                LiikuEteenpain();
            }
        }
        else if (edellinen == 7)
        {
            if (GameObject.Find("Letter6").GetComponent<SpriteRenderer>().sprite == empty)
            {
                GameObject.Find("Letter6").GetComponent<SpriteRenderer>().sprite = grey;
            }
            else
            {
                edellinen = 6;
                LiikuEteenpain();
            }
        }
        else if (edellinen == 6)
        {
            if (GameObject.Find("Ristikko").GetComponent<RistikkoLogiikka>().Alas == true)
            {
                if (GameObject.Find("Letter9").GetComponent<SpriteRenderer>().sprite == empty)
                {
                    GameObject.Find("Letter9").GetComponent<SpriteRenderer>().sprite = grey;
                    GameObject.Find("Letter6").GetComponent<AudioSource>().Play();
                }
                else
                {
                    edellinen = 9;
                    LiikuEteenpain();
                }
            }
            else
            {
                if (GameObject.Find("Letter5").GetComponent<SpriteRenderer>().sprite == empty)
                {
                    GameObject.Find("Letter5").GetComponent<SpriteRenderer>().sprite = grey;
                }
                else
                {
                    edellinen = 5;
                    LiikuEteenpain();
                }
            }
        }
        else if (edellinen == 5)
        {
            if (GameObject.Find("Letter4").GetComponent<SpriteRenderer>().sprite == empty)
            {
                GameObject.Find("Letter4").GetComponent<SpriteRenderer>().sprite = grey;
            }
            else
            {
                edellinen = 4;
                LiikuEteenpain();
            }
        }
        else if (edellinen == 4)
        {
            if (GameObject.Find("Letter3").GetComponent<SpriteRenderer>().sprite == empty)
            {
                GameObject.Find("Letter3").GetComponent<SpriteRenderer>().sprite = grey;
            }
            else
            {
                edellinen = 6;
                GameObject.Find("Ristikko").GetComponent<RistikkoLogiikka>().Alas = true;
                LiikuEteenpain();
            }
        }
        else if (edellinen == 9)
        {
            GameObject.Find("Ristikko").GetComponent<RistikkoLogiikka>().Alas = true;
            if (GameObject.Find("Letter10").GetComponent<SpriteRenderer>().sprite == empty)
            {
                GameObject.Find("Letter10").GetComponent<SpriteRenderer>().sprite = grey;
            }
            else
            {
                edellinen = 10;
                LiikuEteenpain();
            }
        }
        else if (edellinen == 10)
        {
            if (GameObject.Find("Letter11").GetComponent<SpriteRenderer>().sprite == empty)
            {
                GameObject.Find("Letter11").GetComponent<SpriteRenderer>().sprite = grey;
            }
            else
            {
                edellinen = 11;
                LiikuEteenpain();
            }
        }
        else if (edellinen == 11)
        {
            if (GameObject.Find("Letter12").GetComponent<SpriteRenderer>().sprite == empty)
            {
                GameObject.Find("Letter12").GetComponent<SpriteRenderer>().sprite = grey;
            }
            else
            {
                edellinen = 12;
                LiikuEteenpain();
            }
        }
        else if (edellinen == 12)
        {
            if (GameObject.Find("Letter14").GetComponent<SpriteRenderer>().sprite == empty)
            {
                GameObject.Find("Letter14").GetComponent<SpriteRenderer>().sprite = grey;
            }
            else
            {
                edellinen = 14;
                LiikuEteenpain();
            }
        }
        else if (edellinen == 14)
        {
            if (GameObject.Find("Ristikko").GetComponent<RistikkoLogiikka>().Alas == true)
            {
                if (GameObject.Find("Letter16").GetComponent<SpriteRenderer>().sprite == empty)
                {
                    GameObject.Find("Letter16").GetComponent<SpriteRenderer>().sprite = grey;
                    GameObject.Find("Letter16").GetComponent<AudioSource>().Play();
                }
                else
                {
                    edellinen = 16;
                    LiikuEteenpain();
                }
            }
            else
            {
                if (GameObject.Find("Letter13").GetComponent<SpriteRenderer>().sprite == empty)
                {
                    GameObject.Find("Letter13").GetComponent<SpriteRenderer>().sprite = grey;
                }
                else
                {
                    edellinen = 13;
                    LiikuEteenpain();
                }
            }
        }
        else if (edellinen == 16)
        {
            if (GameObject.Find("Letter18").GetComponent<SpriteRenderer>().sprite == empty)
            {
                GameObject.Find("Letter18").GetComponent<SpriteRenderer>().sprite = grey;
            }
            else
            {
                edellinen = 18;
                LiikuEteenpain();
            }
        }
        else if (edellinen == 18)
        {
            if (GameObject.Find("Ristikko").GetComponent<RistikkoLogiikka>().Alas == true)
            {
                if (GameObject.Find("Letter19").GetComponent<SpriteRenderer>().sprite == empty)
                {
                    GameObject.Find("Letter19").GetComponent<SpriteRenderer>().sprite = grey;
                }
                else
                {
                    edellinen = 19;
                    LiikuEteenpain();
                }
            }
            else
            {
                if (GameObject.Find("Letter15").GetComponent<SpriteRenderer>().sprite == empty)
                {
                    GameObject.Find("Letter15").GetComponent<SpriteRenderer>().sprite = grey;
                }
                else
                {
                    edellinen = 15;
                    LiikuEteenpain();
                }
            }
        }
        else if (edellinen == 19)
        {
            if (GameObject.Find("Letter20").GetComponent<SpriteRenderer>().sprite == empty)
            {
                GameObject.Find("Letter20").GetComponent<SpriteRenderer>().sprite = grey;
            }
            else
            {
                edellinen = 20;
                LiikuEteenpain();
            }
        }
        else if (edellinen == 20)
        {
            if (GameObject.Find("Letter23").GetComponent<SpriteRenderer>().sprite == empty)
            {
                GameObject.Find("Letter23").GetComponent<SpriteRenderer>().sprite = grey;
            }
            else
            {
                edellinen = 23;
                LiikuEteenpain();
            }
        }
        else if (edellinen == 23)
        {
            if (GameObject.Find("Ristikko").GetComponent<RistikkoLogiikka>().Alas == true)
            {
                if (GameObject.Find("Letter25").GetComponent<SpriteRenderer>().sprite == empty)
                {
                    GameObject.Find("Letter25").GetComponent<SpriteRenderer>().sprite = grey;
                }
                else
                {
                    edellinen = 25;
                    LiikuEteenpain();
                }
            }
            else
            {
                if (GameObject.Find("Letter24").GetComponent<SpriteRenderer>().sprite == empty)
                {
                    GameObject.Find("Letter24").GetComponent<SpriteRenderer>().sprite = grey;
                }
                else
                {
                    edellinen = 24;
                    LiikuEteenpain();
                }
            }
        }
        else if (edellinen == 25)
        {
            GameObject.Find("Ristikko").GetComponent<RistikkoLogiikka>().Alas = false;
            if (GameObject.Find("Letter17").GetComponent<SpriteRenderer>().sprite == empty)
            {
                GameObject.Find("Letter17").GetComponent<SpriteRenderer>().sprite = grey;
                GameObject.Find("Letter17").GetComponent<AudioSource>().Play();
            }
            else
            {
                edellinen = 17;
                LiikuEteenpain();
            }
        }
        else if (edellinen == 17)
        {
            if (GameObject.Find("Letter18").GetComponent<SpriteRenderer>().sprite == empty)
            {
                GameObject.Find("Letter18").GetComponent<SpriteRenderer>().sprite = grey;
            }
            else
            {
                edellinen = 18;
                GameObject.Find("Ristikko").GetComponent<RistikkoLogiikka>().Alas = false;
                LiikuEteenpain();
            }
        }
        else if (edellinen == 15)
        {
            if (GameObject.Find("Letter14").GetComponent<SpriteRenderer>().sprite == empty)
            {
                GameObject.Find("Letter14").GetComponent<SpriteRenderer>().sprite = grey;
            }
            else
            {
                edellinen = 14;
                GameObject.Find("Ristikko").GetComponent<RistikkoLogiikka>().Alas = false;
                LiikuEteenpain();
            }
        }
        else if (edellinen == 13)
        {
            if (GameObject.Find("Letter21").GetComponent<SpriteRenderer>().sprite == empty)
            {
                GameObject.Find("Letter21").GetComponent<SpriteRenderer>().sprite = grey;
                GameObject.Find("Letter21").GetComponent<AudioSource>().Play();
            }
            else
            {
                edellinen = 21;
                LiikuEteenpain();
            }
        }
        else if (edellinen == 21)
        {
            if (GameObject.Find("Letter22").GetComponent<SpriteRenderer>().sprite == empty)
            {
                GameObject.Find("Letter22").GetComponent<SpriteRenderer>().sprite = grey;
            }
            else
            {
                edellinen = 22;
                LiikuEteenpain();
            }
        }
        else if (edellinen == 22)
        {
            if (GameObject.Find("Letter23").GetComponent<SpriteRenderer>().sprite == empty)
            {
                GameObject.Find("Letter23").GetComponent<SpriteRenderer>().sprite = grey;
            }
            else
            {
                edellinen = 23;
                GameObject.Find("Ristikko").GetComponent<RistikkoLogiikka>().Alas = false;
                LiikuEteenpain();
            }
        }
        else if (edellinen == 24)
        {
            if (GameObject.Find("Letter1").GetComponent<SpriteRenderer>().sprite == empty)
            {
                GameObject.Find("Letter1").GetComponent<SpriteRenderer>().sprite = grey;
            }
            else
            {
                if (GameObject.Find("Letter1").GetComponent<SpriteRenderer>().sprite == empty || GameObject.Find("Letter2").GetComponent<SpriteRenderer>().sprite == empty || GameObject.Find("Letter3").GetComponent<SpriteRenderer>().sprite == empty || GameObject.Find("Letter4").GetComponent<SpriteRenderer>().sprite == empty || GameObject.Find("Letter5").GetComponent<SpriteRenderer>().sprite == empty || GameObject.Find("Letter6").GetComponent<SpriteRenderer>().sprite == empty || GameObject.Find("Letter7").GetComponent<SpriteRenderer>().sprite == empty || GameObject.Find("Letter8").GetComponent<SpriteRenderer>().sprite == empty || GameObject.Find("Letter9").GetComponent<SpriteRenderer>().sprite == empty || GameObject.Find("Letter10").GetComponent<SpriteRenderer>().sprite == empty || GameObject.Find("Letter11").GetComponent<SpriteRenderer>().sprite == empty || GameObject.Find("Letter12").GetComponent<SpriteRenderer>().sprite == empty || GameObject.Find("Letter13").GetComponent<SpriteRenderer>().sprite == empty || GameObject.Find("Letter14").GetComponent<SpriteRenderer>().sprite == empty || GameObject.Find("Letter15").GetComponent<SpriteRenderer>().sprite == empty || GameObject.Find("Letter16").GetComponent<SpriteRenderer>().sprite == empty || GameObject.Find("Letter17").GetComponent<SpriteRenderer>().sprite == empty || GameObject.Find("Letter18").GetComponent<SpriteRenderer>().sprite == empty || GameObject.Find("Letter19").GetComponent<SpriteRenderer>().sprite == empty || GameObject.Find("Letter20").GetComponent<SpriteRenderer>().sprite == empty || GameObject.Find("Letter21").GetComponent<SpriteRenderer>().sprite == empty || GameObject.Find("Letter22").GetComponent<SpriteRenderer>().sprite == empty || GameObject.Find("Letter23").GetComponent<SpriteRenderer>().sprite == empty || GameObject.Find("Letter24").GetComponent<SpriteRenderer>().sprite == empty || GameObject.Find("Letter25").GetComponent<SpriteRenderer>().sprite == empty)
                {
                    edellinen = 1;
                    GameObject.Find("Ristikko").GetComponent<RistikkoLogiikka>().Alas = true;
                    LiikuEteenpain();
                }
                else if (GameObject.Find("Letter1").GetComponent<SpriteRenderer>().sprite == lettera && GameObject.Find("Letter2").GetComponent<SpriteRenderer>().sprite == lettert && GameObject.Find("Letter3").GetComponent<SpriteRenderer>().sprite == lettere && GameObject.Find("Letter4").GetComponent<SpriteRenderer>().sprite == letterm && GameObject.Find("Letter5").GetComponent<SpriteRenderer>().sprite == lettero && GameObject.Find("Letter6").GetComponent<SpriteRenderer>().sprite == letterc && GameObject.Find("Letter7").GetComponent<SpriteRenderer>().sprite == lettere && GameObject.Find("Letter8").GetComponent<SpriteRenderer>().sprite == letterb && GameObject.Find("Letter9").GetComponent<SpriteRenderer>().sprite == letterh && GameObject.Find("Letter10").GetComponent<SpriteRenderer>().sprite == lettero && GameObject.Find("Letter11").GetComponent<SpriteRenderer>().sprite == letters && GameObject.Find("Letter12").GetComponent<SpriteRenderer>().sprite == lettere && GameObject.Find("Letter13").GetComponent<SpriteRenderer>().sprite == letterk && GameObject.Find("Letter14").GetComponent<SpriteRenderer>().sprite == lettern && GameObject.Find("Letter15").GetComponent<SpriteRenderer>().sprite == letteru && GameObject.Find("Letter16").GetComponent<SpriteRenderer>().sprite == lettera && GameObject.Find("Letter17").GetComponent<SpriteRenderer>().sprite == letterd && GameObject.Find("Letter18").GetComponent<SpriteRenderer>().sprite == letterr && GameObject.Find("Letter19").GetComponent<SpriteRenderer>().sprite == letteri && GameObject.Find("Letter20").GetComponent<SpriteRenderer>().sprite == letters && GameObject.Find("Letter21").GetComponent<SpriteRenderer>().sprite == letterb && GameObject.Find("Letter22").GetComponent<SpriteRenderer>().sprite == letterl && GameObject.Find("Letter23").GetComponent<SpriteRenderer>().sprite == lettere && GameObject.Find("Letter24").GetComponent<SpriteRenderer>().sprite == letterw && GameObject.Find("Letter25").GetComponent<SpriteRenderer>().sprite == lettern)
                {
                    Debug.Log("Peli ratkaistu oikein jee!");
                    button.SetActive(true);
                    if (success != null) {
                        success.Play();
                    }
                }
                else
                {
                    Debug.Log("Jossain on virhe tai useampi");
                    if (fail != null) {
                        fail.Play();
                    }
                }
            }
        }
    }

    public void OnMouseDown()
    {   
        if (GetComponent<AudioSource>() != null) {
            GetComponent<AudioSource>().Play();
        }
        for (int i = 1; i < 26; i++)
        {
            if (GameObject.Find("Letter" + i).GetComponent<SpriteRenderer>().sprite == grey)
            {
                GameObject.Find("Letter" + i).GetComponent<SpriteRenderer>().sprite = empty;
            }
        }
        if (spriteRenderer.sprite == empty)
        {
            spriteRenderer.sprite = grey;
        }
        else if (spriteRenderer.sprite == grey)
        {
            spriteRenderer.sprite = empty;
        }
        else
        {
            spriteRenderer.sprite = grey;
        }
        // Taman jalkeen katsotaan mika varjaytyi harmaaksi ja muokataan muuttujaa Alas sen perusteella
        if (GameObject.Find("Letter1").GetComponent<SpriteRenderer>().sprite == grey)
        {
            GameObject.Find("Ristikko").GetComponent<RistikkoLogiikka>().Alas = true;
        }
        else if (GameObject.Find("Letter2").GetComponent<SpriteRenderer>().sprite == grey)
        {
            GameObject.Find("Ristikko").GetComponent<RistikkoLogiikka>().Alas = true;
        }
        else if (GameObject.Find("Letter8").GetComponent<SpriteRenderer>().sprite == grey)
        {
            GameObject.Find("Ristikko").GetComponent<RistikkoLogiikka>().Alas = false;
        }
        else if (GameObject.Find("Letter6").GetComponent<SpriteRenderer>().sprite == grey)
        {
            GameObject.Find("Ristikko").GetComponent<RistikkoLogiikka>().Alas = true;
        }
        else if (GameObject.Find("Letter16").GetComponent<SpriteRenderer>().sprite == grey)
        {
            GameObject.Find("Ristikko").GetComponent<RistikkoLogiikka>().Alas = true;
        }
        else if (GameObject.Find("Letter17").GetComponent<SpriteRenderer>().sprite == grey)
        {
            GameObject.Find("Ristikko").GetComponent<RistikkoLogiikka>().Alas = false;
        }
        else if (GameObject.Find("Letter21").GetComponent<SpriteRenderer>().sprite == grey)
        {
            GameObject.Find("Ristikko").GetComponent<RistikkoLogiikka>().Alas = false;
        }
    }


    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
}
