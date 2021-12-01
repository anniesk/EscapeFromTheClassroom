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
    public int harmaa;
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
        // Kun mita tahansa nappainta painetaan, mutta hiiren nappaimia ei oteta huomioon
        if (Input.anyKeyDown && !(Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1) || Input.GetMouseButtonDown(2)))
        {
            holdingDown = true;



            // Jos painettu nappain on backspace, mennaan taaksepain
            if (Input.GetKeyDown(KeyCode.Backspace))
            {
                GameObject.Find("Ristikko").GetComponent<RistikkoLogiikka>().Eteenpain = false;
            }



            // Muussa tapauksessa mennaan eteenpain
            else
            {
                GameObject.Find("Ristikko").GetComponent<RistikkoLogiikka>().Eteenpain = true;
                for (int i = 1; i < 26; i++)
                {
                    if (GameObject.Find("Letter" + i).GetComponent<SpriteRenderer>().sprite == grey)
                    {
                        edellinen = i;
                        //Debug.Log(edellinen);
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
                        else
                        {
                            GameObject.Find("Letter" + i).GetComponent<SpriteRenderer>().sprite = empty;
                        }
                        Tarkista();
                    }
                }
            }
        }

        // Kun alas painettu nappain vapautetaan
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
        

        // Haetaan mika on harmaana ja varjataan se valkoiseksi
        for (int i = 1; i < 26; i++)
        {
            if (GameObject.Find("Letter" + i).GetComponent<SpriteRenderer>().sprite == grey)
            {
                //Debug.Log(i +" on harmaana");
                harmaa = i;
                GameObject.Find("Letter" + harmaa).GetComponent<SpriteRenderer>().sprite = empty;
                break;
            }
        }



        if (harmaa == 1)
        {
            GameObject.Find("Letter25").GetComponent<SpriteRenderer>().sprite = grey;
        }
        else if (harmaa == 2)
        {
            GameObject.Find("Letter1").GetComponent<SpriteRenderer>().sprite = grey;
        }
        else if (harmaa == 3)
        {
            if (GameObject.Find("Ristikko").GetComponent<RistikkoLogiikka>().Alas == true)
            {
                GameObject.Find("Letter2").GetComponent<SpriteRenderer>().sprite = grey;
                GameObject.Find("Ristikko").GetComponent<RistikkoLogiikka>().Alas = false;
            }
            else
            {
                GameObject.Find("Letter4").GetComponent<SpriteRenderer>().sprite = grey;
            }
        }
        else if (harmaa == 4)
        {
            GameObject.Find("Letter5").GetComponent<SpriteRenderer>().sprite = grey;
        }
        else if (harmaa == 5)
        {
            GameObject.Find("Letter6").GetComponent<SpriteRenderer>().sprite = grey;
        }
        else if (harmaa == 6)
        {
            if (GameObject.Find("Ristikko").GetComponent<RistikkoLogiikka>().Alas == true)
            {
                GameObject.Find("Letter3").GetComponent<SpriteRenderer>().sprite = grey;
                GameObject.Find("Ristikko").GetComponent<RistikkoLogiikka>().Alas = false;
            }
            else
            {
                GameObject.Find("Letter7").GetComponent<SpriteRenderer>().sprite = grey;
            }
        }
        else if (harmaa == 7)
        {
            GameObject.Find("Letter8").GetComponent<SpriteRenderer>().sprite = grey;
        }
        else if (harmaa == 8)
        {
            GameObject.Find("Ristikko").GetComponent<RistikkoLogiikka>().Alas = true;
            GameObject.Find("Letter3").GetComponent<SpriteRenderer>().sprite = grey;
        }
        else if (harmaa == 9)
        {
            GameObject.Find("Letter6").GetComponent<SpriteRenderer>().sprite = grey;
        }
        else if (harmaa == 10)
        {
            GameObject.Find("Ristikko").GetComponent<RistikkoLogiikka>().Alas = true;
            GameObject.Find("Letter9").GetComponent<SpriteRenderer>().sprite = grey;
        }
        else if (harmaa == 11)
        {
            GameObject.Find("Letter10").GetComponent<SpriteRenderer>().sprite = grey;
        }
        else if (harmaa == 12)
        {
            GameObject.Find("Letter11").GetComponent<SpriteRenderer>().sprite = grey;
        }
        else if (harmaa == 13)
        {
            GameObject.Find("Letter14").GetComponent<SpriteRenderer>().sprite = grey;
        }
        else if (harmaa == 14)
        {
            if (GameObject.Find("Ristikko").GetComponent<RistikkoLogiikka>().Alas == true)
            {
                GameObject.Find("Letter12").GetComponent<SpriteRenderer>().sprite = grey;
                GameObject.Find("Ristikko").GetComponent<RistikkoLogiikka>().Alas = false;
            }
            else
            {
                GameObject.Find("Letter15").GetComponent<SpriteRenderer>().sprite = grey;
            }
        }
        else if (harmaa == 15)
        {
            GameObject.Find("Letter18").GetComponent<SpriteRenderer>().sprite = grey;
        }
        else if (harmaa == 16)
        {
            GameObject.Find("Ristikko").GetComponent<RistikkoLogiikka>().Alas = true;
            GameObject.Find("Letter14").GetComponent<SpriteRenderer>().sprite = grey;
        }
        else if (harmaa == 17)
        {
            GameObject.Find("Ristikko").GetComponent<RistikkoLogiikka>().Alas = true;
            GameObject.Find("Letter25").GetComponent<SpriteRenderer>().sprite = grey;
        }
        else if (harmaa == 18)
        {
            if (GameObject.Find("Ristikko").GetComponent<RistikkoLogiikka>().Alas == true)
            {
                GameObject.Find("Letter16").GetComponent<SpriteRenderer>().sprite = grey;
                GameObject.Find("Ristikko").GetComponent<RistikkoLogiikka>().Alas = false;
            }
            else
            {
                GameObject.Find("Letter17").GetComponent<SpriteRenderer>().sprite = grey;
            }
        }
        else if (harmaa == 19)
        {
            GameObject.Find("Letter18").GetComponent<SpriteRenderer>().sprite = grey;
        }
        else if (harmaa == 20)
        {
            GameObject.Find("Letter19").GetComponent<SpriteRenderer>().sprite = grey;
        }
        else if (harmaa == 21)
        {
            GameObject.Find("Letter13").GetComponent<SpriteRenderer>().sprite = grey;
        }
        else if (harmaa == 22)
        {
            GameObject.Find("Letter21").GetComponent<SpriteRenderer>().sprite = grey;
        }
        else if (harmaa == 23)
        {
            if (GameObject.Find("Ristikko").GetComponent<RistikkoLogiikka>().Alas == true)
            {
                GameObject.Find("Letter20").GetComponent<SpriteRenderer>().sprite = grey;
            }
            else
            {
                GameObject.Find("Letter22").GetComponent<SpriteRenderer>().sprite = grey;
            }
        }
        else if (harmaa == 24)
        {
            GameObject.Find("Letter23").GetComponent<SpriteRenderer>().sprite = grey;
        }
        else if (harmaa == 25)
        {
            GameObject.Find("Letter23").GetComponent<SpriteRenderer>().sprite = grey;
        }
        GameObject.Find("Ristikko").GetComponent<RistikkoLogiikka>().Eteenpain = true;
    }

    public void LiikuEteenpain()
    {
        if (edellinen == 1)
        {
            GameObject.Find("Letter2").GetComponent<SpriteRenderer>().sprite = grey;
            GameObject.Find("Letter1").GetComponent<AudioSource>().Play();
            GameObject.Find("Ristikko").GetComponent<RistikkoLogiikka>().Alas = true;
        }
        else if (edellinen == 2)
        {
            GameObject.Find("Letter3").GetComponent<SpriteRenderer>().sprite = grey;
        }
        else if (edellinen == 3)
        {
            if (GameObject.Find("Ristikko").GetComponent<RistikkoLogiikka>().Alas == true)
            {
                GameObject.Find("Letter8").GetComponent<SpriteRenderer>().sprite = grey;
                GameObject.Find("Letter8").GetComponent<AudioSource>().Play();
            }
            else
            {
                GameObject.Find("Letter9").GetComponent<SpriteRenderer>().sprite = grey;
                GameObject.Find("Letter6").GetComponent<AudioSource>().Play();
            }
        }
        else if (edellinen == 8)
        {
            GameObject.Find("Ristikko").GetComponent<RistikkoLogiikka>().Alas = false;
            GameObject.Find("Letter7").GetComponent<SpriteRenderer>().sprite = grey;
        }
        else if (edellinen == 7)
        {
            GameObject.Find("Letter6").GetComponent<SpriteRenderer>().sprite = grey;
        }
        else if (edellinen == 6)
        {
            if (GameObject.Find("Ristikko").GetComponent<RistikkoLogiikka>().Alas == true)
            {
                GameObject.Find("Letter9").GetComponent<SpriteRenderer>().sprite = grey;
                GameObject.Find("Letter6").GetComponent<AudioSource>().Play();
            }
            else
            {
                GameObject.Find("Letter5").GetComponent<SpriteRenderer>().sprite = grey;
            }
        }
        else if (edellinen == 5)
        {
            GameObject.Find("Letter4").GetComponent<SpriteRenderer>().sprite = grey;
        }
        else if (edellinen == 4)
        {
            GameObject.Find("Letter3").GetComponent<SpriteRenderer>().sprite = grey;
            GameObject.Find("Ristikko").GetComponent<RistikkoLogiikka>().Alas = false;
        }
        else if (edellinen == 9)
        {
            GameObject.Find("Ristikko").GetComponent<RistikkoLogiikka>().Alas = true;
            GameObject.Find("Letter10").GetComponent<SpriteRenderer>().sprite = grey;
        }
        else if (edellinen == 10)
        {
            GameObject.Find("Letter11").GetComponent<SpriteRenderer>().sprite = grey;
        }
        else if (edellinen == 11)
        {
            GameObject.Find("Letter12").GetComponent<SpriteRenderer>().sprite = grey;
        }
        else if (edellinen == 12)
        {
            GameObject.Find("Letter14").GetComponent<SpriteRenderer>().sprite = grey;
        }
        else if (edellinen == 14)
        {
            if (GameObject.Find("Ristikko").GetComponent<RistikkoLogiikka>().Alas == true)
            {
                GameObject.Find("Letter16").GetComponent<SpriteRenderer>().sprite = grey;
                GameObject.Find("Letter16").GetComponent<AudioSource>().Play();
            }
            else
            {
                GameObject.Find("Letter13").GetComponent<SpriteRenderer>().sprite = grey;
            }
        }
        else if (edellinen == 16)
        {
            GameObject.Find("Letter18").GetComponent<SpriteRenderer>().sprite = grey;
        }
        else if (edellinen == 18)
        {
            if (GameObject.Find("Ristikko").GetComponent<RistikkoLogiikka>().Alas == true)
            {
                GameObject.Find("Letter19").GetComponent<SpriteRenderer>().sprite = grey;
            }
            else
            {
                GameObject.Find("Letter15").GetComponent<SpriteRenderer>().sprite = grey;
            }
        }
        else if (edellinen == 19)
        {
            GameObject.Find("Letter20").GetComponent<SpriteRenderer>().sprite = grey;
        }
        else if (edellinen == 20)
        {
            GameObject.Find("Letter23").GetComponent<SpriteRenderer>().sprite = grey;
        }
        else if (edellinen == 23)
        {
            if (GameObject.Find("Ristikko").GetComponent<RistikkoLogiikka>().Alas == true)
            {
                GameObject.Find("Letter25").GetComponent<SpriteRenderer>().sprite = grey;
            }
            else
            {
                GameObject.Find("Letter24").GetComponent<SpriteRenderer>().sprite = grey;
            }
        }
        else if (edellinen == 25)
        {
            GameObject.Find("Letter17").GetComponent<SpriteRenderer>().sprite = grey;
            GameObject.Find("Letter17").GetComponent<AudioSource>().Play();
        }
        else if (edellinen == 17)
        {
            GameObject.Find("Letter18").GetComponent<SpriteRenderer>().sprite = grey;
            GameObject.Find("Ristikko").GetComponent<RistikkoLogiikka>().Alas = false;
        }
        else if (edellinen == 15)
        {
            GameObject.Find("Letter14").GetComponent<SpriteRenderer>().sprite = grey;
            GameObject.Find("Ristikko").GetComponent<RistikkoLogiikka>().Alas = false;
        }
        else if (edellinen == 13)
        {
            GameObject.Find("Letter21").GetComponent<SpriteRenderer>().sprite = grey;
            GameObject.Find("Letter21").GetComponent<AudioSource>().Play();
        }
        else if (edellinen == 21)
        {
            GameObject.Find("Letter22").GetComponent<SpriteRenderer>().sprite = grey;
        }
        else if (edellinen == 22)
        {
            GameObject.Find("Letter23").GetComponent<SpriteRenderer>().sprite = grey;
        }
        else if (edellinen == 24)
        {
            
        }
    }

    public void Tarkista()
    {
        if (GameObject.Find("Letter1").GetComponent<SpriteRenderer>().sprite == empty || GameObject.Find("Letter2").GetComponent<SpriteRenderer>().sprite == empty || GameObject.Find("Letter3").GetComponent<SpriteRenderer>().sprite == empty || GameObject.Find("Letter4").GetComponent<SpriteRenderer>().sprite == empty || GameObject.Find("Letter5").GetComponent<SpriteRenderer>().sprite == empty || GameObject.Find("Letter6").GetComponent<SpriteRenderer>().sprite == empty || GameObject.Find("Letter7").GetComponent<SpriteRenderer>().sprite == empty || GameObject.Find("Letter8").GetComponent<SpriteRenderer>().sprite == empty || GameObject.Find("Letter9").GetComponent<SpriteRenderer>().sprite == empty || GameObject.Find("Letter10").GetComponent<SpriteRenderer>().sprite == empty || GameObject.Find("Letter11").GetComponent<SpriteRenderer>().sprite == empty || GameObject.Find("Letter12").GetComponent<SpriteRenderer>().sprite == empty || GameObject.Find("Letter13").GetComponent<SpriteRenderer>().sprite == empty || GameObject.Find("Letter14").GetComponent<SpriteRenderer>().sprite == empty || GameObject.Find("Letter15").GetComponent<SpriteRenderer>().sprite == empty || GameObject.Find("Letter16").GetComponent<SpriteRenderer>().sprite == empty || GameObject.Find("Letter17").GetComponent<SpriteRenderer>().sprite == empty || GameObject.Find("Letter18").GetComponent<SpriteRenderer>().sprite == empty || GameObject.Find("Letter19").GetComponent<SpriteRenderer>().sprite == empty || GameObject.Find("Letter20").GetComponent<SpriteRenderer>().sprite == empty || GameObject.Find("Letter21").GetComponent<SpriteRenderer>().sprite == empty || GameObject.Find("Letter22").GetComponent<SpriteRenderer>().sprite == empty || GameObject.Find("Letter23").GetComponent<SpriteRenderer>().sprite == empty || GameObject.Find("Letter24").GetComponent<SpriteRenderer>().sprite == empty || GameObject.Find("Letter25").GetComponent<SpriteRenderer>().sprite == empty)
        {
            Debug.Log("jossain on viela tyhjaa");
        }
        else if (GameObject.Find("Letter1").GetComponent<SpriteRenderer>().sprite == lettera && GameObject.Find("Letter2").GetComponent<SpriteRenderer>().sprite == lettert && GameObject.Find("Letter3").GetComponent<SpriteRenderer>().sprite == lettere && GameObject.Find("Letter4").GetComponent<SpriteRenderer>().sprite == letterm && GameObject.Find("Letter5").GetComponent<SpriteRenderer>().sprite == lettero && GameObject.Find("Letter6").GetComponent<SpriteRenderer>().sprite == letterc && GameObject.Find("Letter7").GetComponent<SpriteRenderer>().sprite == lettere && GameObject.Find("Letter8").GetComponent<SpriteRenderer>().sprite == letterb && GameObject.Find("Letter9").GetComponent<SpriteRenderer>().sprite == letterh && GameObject.Find("Letter10").GetComponent<SpriteRenderer>().sprite == lettero && GameObject.Find("Letter11").GetComponent<SpriteRenderer>().sprite == letters && GameObject.Find("Letter12").GetComponent<SpriteRenderer>().sprite == lettere && GameObject.Find("Letter13").GetComponent<SpriteRenderer>().sprite == letterk && GameObject.Find("Letter14").GetComponent<SpriteRenderer>().sprite == lettern && GameObject.Find("Letter15").GetComponent<SpriteRenderer>().sprite == letteru && GameObject.Find("Letter16").GetComponent<SpriteRenderer>().sprite == lettera && GameObject.Find("Letter17").GetComponent<SpriteRenderer>().sprite == letterd && GameObject.Find("Letter18").GetComponent<SpriteRenderer>().sprite == letterr && GameObject.Find("Letter19").GetComponent<SpriteRenderer>().sprite == letteri && GameObject.Find("Letter20").GetComponent<SpriteRenderer>().sprite == letters && GameObject.Find("Letter21").GetComponent<SpriteRenderer>().sprite == letterb && GameObject.Find("Letter22").GetComponent<SpriteRenderer>().sprite == letterl && GameObject.Find("Letter23").GetComponent<SpriteRenderer>().sprite == lettere && GameObject.Find("Letter24").GetComponent<SpriteRenderer>().sprite == letterw && GameObject.Find("Letter25").GetComponent<SpriteRenderer>().sprite == lettern)
        {
            // Kaikki spritet ovat oikein, eli siis peli on ratkaistu
            Debug.Log("Peli ratkaistu oikein jee!");
            button.SetActive(true);
            if (success != null)
            {
                success.Play();
            }
        }
        else
        {
            Debug.Log("Jossain on virhe tai useampi");
            if (fail != null)
            {
                fail.Play();
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
