using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainToken1 : MonoBehaviour
{
    GameObject gameControl;
    SpriteRenderer spriteRenderer;
    public Sprite face;
    public Sprite back;

    public void OnMouseDown()
    {
        // Tarkistaa onko taman verbin kaikki muodot jo loydetty
        // (be waswere been, jos on, niin ei anna tehda mitaan)
        if (gameControl.GetComponent<GameControl>().Loydettybe == true) {

        }
        else {
            if (gameControl.GetComponent<GameControl>().kuinkamontakaannetty == 3) {
                gameControl.GetComponent<GameControl>().KaannaEiLoydetyt();
                gameControl.GetComponent<GameControl>().kuinkamontakaannetty = 0;
            }
            if(spriteRenderer.sprite == back)
            {
                gameControl.GetComponent<GameControl>().Tila1 = true;
                gameControl.GetComponent<GameControl>().kuinkamontakaannetty++;
                spriteRenderer.sprite = face;
                GetComponent<AudioSource>().Play();
            }
            else
            {
                gameControl.GetComponent<GameControl>().Tila1 = false;
                gameControl.GetComponent<GameControl>().kuinkamontakaannetty--;
                spriteRenderer.sprite = back;
            }
            gameControl.GetComponent<GameControl>().Tarkista();
        }
    }

    private void Awake()
    {
        gameControl = GameObject.Find("GameControl");
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
}
