using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterBox : MonoBehaviour
{
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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
        if (spriteRenderer.sprite == grey) {
            if (Input.GetKeyDown(KeyCode.A)) {
                spriteRenderer.sprite = lettera;
            }
            else if (Input.GetKeyDown(KeyCode.B)) {
                spriteRenderer.sprite = letterb;
            }
            else if (Input.GetKeyDown(KeyCode.C)) {
                spriteRenderer.sprite = letterc;
            }
            else if (Input.GetKeyDown(KeyCode.D)) {
                spriteRenderer.sprite = letterd;
            }
            else if (Input.GetKeyDown(KeyCode.E)) {
                spriteRenderer.sprite = lettere;
            }
            else if (Input.GetKeyDown(KeyCode.F)) {
                spriteRenderer.sprite = letterf;
            }
            else if (Input.GetKeyDown(KeyCode.G)) {
                spriteRenderer.sprite = letterg;
            }
            else if (Input.GetKeyDown(KeyCode.H)) {
                spriteRenderer.sprite = letterh;
            }
            else if (Input.GetKeyDown(KeyCode.I)) {
                spriteRenderer.sprite = letteri;
            }
            else if (Input.GetKeyDown(KeyCode.J)) {
                spriteRenderer.sprite = letterj;
            }
            else if (Input.GetKeyDown(KeyCode.K)) {
                spriteRenderer.sprite = letterk;
            }
            else if (Input.GetKeyDown(KeyCode.L)) {
                spriteRenderer.sprite = letterl;
            }
            else if (Input.GetKeyDown(KeyCode.M)) {
                spriteRenderer.sprite = letterm;
            }
            else if (Input.GetKeyDown(KeyCode.N)) {
                spriteRenderer.sprite = lettern;
            }
            else if (Input.GetKeyDown(KeyCode.O)) {
                spriteRenderer.sprite = lettero;
            }
            else if (Input.GetKeyDown(KeyCode.P)) {
                spriteRenderer.sprite = letterp;
            }
            else if (Input.GetKeyDown(KeyCode.Q)) {
                spriteRenderer.sprite = letterq;
            }
            else if (Input.GetKeyDown(KeyCode.R)) {
                spriteRenderer.sprite = letterr;
            }
            else if (Input.GetKeyDown(KeyCode.S)) {
                spriteRenderer.sprite = letters;
            }
            else if (Input.GetKeyDown(KeyCode.T)) {
                spriteRenderer.sprite = lettert;
            }
            else if (Input.GetKeyDown(KeyCode.U)) {
                spriteRenderer.sprite = letteru;
            }
            else if (Input.GetKeyDown(KeyCode.V)) {
                spriteRenderer.sprite = letterv;
            }
            else if (Input.GetKeyDown(KeyCode.W)) {
                spriteRenderer.sprite = letterw;
            }
            else if (Input.GetKeyDown(KeyCode.X)) {
                spriteRenderer.sprite = letterx;
            }
            else if (Input.GetKeyDown(KeyCode.Y)) {
                spriteRenderer.sprite = lettery;
            }
            else if (Input.GetKeyDown(KeyCode.Z)) {
                spriteRenderer.sprite = letterz;
            }
            else if (Input.GetKeyDown(KeyCode.Space)) {
                spriteRenderer.sprite = empty;
            }
        }
    }

    public void OnMouseDown() {
        for (int i = 1; i < 26; i++) {
            if (GameObject.Find("Letter"+i).GetComponent<SpriteRenderer>().sprite == grey) {
                GameObject.Find("Letter"+i).GetComponent<SpriteRenderer>().sprite = empty;
            }
        }
        if (spriteRenderer.sprite == empty) {
            spriteRenderer.sprite = grey;
        }
        else if (spriteRenderer.sprite == grey) {
            spriteRenderer.sprite = empty;
        }
        else {
            spriteRenderer.sprite = grey;
        }
    }

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
}
