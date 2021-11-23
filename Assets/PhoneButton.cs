using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneButton : MonoBehaviour
{

    public GameObject button;
    public Canvas canvas;

    private Camera cam;
    public AudioSource audio1;
    public AudioSource audio2;
    public AudioSource audio3;
    public AudioSource audio4;
    public int[] kymmenenedellista = new int[10];

    void Start() {
        canvas = GameObject.Find("Canvas").GetComponent<Canvas>();
        button = canvas.transform.Find("BlackBoardButton").gameObject;
        cam = Camera.main;
        audio1.Play();
    }

    void lisaaNumero(int numero) {
        kymmenenedellista[0] = kymmenenedellista[1];
        kymmenenedellista[1] = kymmenenedellista[2];
        kymmenenedellista[2] = kymmenenedellista[3];
        kymmenenedellista[3] = kymmenenedellista[4];
        kymmenenedellista[4] = kymmenenedellista[5];
        kymmenenedellista[5] = kymmenenedellista[6];
        kymmenenedellista[6] = kymmenenedellista[7];
        kymmenenedellista[7] = kymmenenedellista[8];
        kymmenenedellista[8] = kymmenenedellista[9];
        kymmenenedellista[9] = numero;
    }

    void tulosta() {
        //Debug.Log(kymmenenedellista[0]+""+kymmenenedellista[1]+kymmenenedellista[2]+kymmenenedellista[3]+kymmenenedellista[4]+kymmenenedellista[5]+kymmenenedellista[6]+kymmenenedellista[7]+kymmenenedellista[8]+kymmenenedellista[9]);
    }

    void tarkistaSana() {
        if (kymmenenedellista[6] == 3 && kymmenenedellista[7] == 8 && kymmenenedellista[8] == 8 && kymmenenedellista[9] == 4) {
            Debug.Log("DUG");
            audio1.Stop();
            audio2.Play();
        }
        else if (kymmenenedellista[3] == 4 && kymmenenedellista[4] == 2 && kymmenenedellista[5] == 8 && kymmenenedellista[6] == 8 && kymmenenedellista[7] == 8 && kymmenenedellista[8] == 3 && kymmenenedellista[9] == 3) {
            Debug.Log("DUG2");
            audio2.Stop();
            audio3.Play();
        }
        else if (kymmenenedellista[3] == 7 && kymmenenedellista[4] == 7 && kymmenenedellista[5] == 7 && kymmenenedellista[6] == 8 && kymmenenedellista[7] == 8 && kymmenenedellista[8] == 6 && kymmenenedellista[9] == 6) {
            Debug.Log("DUG3");
            audio3.Stop();
            audio4.Play();
            button.SetActive(true);
        }
    }

    private void Update() {
        //Debug.Log(cam.ScreenToWorldPoint(Input.mousePosition));
        //Debug.Log(Input.mousePosition);
    }
    public void OnMouseDown() {
        Vector3 worldpos = cam.ScreenToWorldPoint(Input.mousePosition);
        Debug.Log(worldpos.x +", " +worldpos.y);
        if (worldpos.x > -1.5 && worldpos.x < -0.6) {
            if (worldpos.y > -1.6 && worldpos.y < -1) {
                lisaaNumero(1);
            }
            else if (worldpos.y > -2.2 && worldpos.y < -1.6) {
                lisaaNumero(4);
            }
            else if (worldpos.y > -3 && worldpos.y < 0) {
                lisaaNumero(7);
            }
        }
        else if (worldpos.x > -0.4 && worldpos.x < 0.4) {
            if (worldpos.y > -1.6 && worldpos.y < -0.6) {
                lisaaNumero(2);
            }
            else if (worldpos.y > -2.2 && worldpos.y < -1.6) {
                lisaaNumero(5);
            }
            else if (worldpos.y > -3 && worldpos.y < -2.2) {
                lisaaNumero(8);
            }
            else if (worldpos.y > -4 && worldpos.y < -3) {
                lisaaNumero(0);
            }
        }
        else if (worldpos.x > 0.7 && worldpos.x < 1.5) {
            if (worldpos.y > -1.6 && worldpos.y < -0.6) {
                lisaaNumero(3);
            }
            else if (worldpos.y > -2.2 && worldpos.y < -1.6) {
                lisaaNumero(6);
            }
            else if (worldpos.y > -3 && worldpos.y < -2.2) {
                lisaaNumero(9);
            }
        }
        tulosta();
        tarkistaSana();
        //Debug.Log(worldpos);
    }
}
