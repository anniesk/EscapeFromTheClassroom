using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneButton : MonoBehaviour
{
    private Camera cam;
    public int[] kymmenenedellista = new int[10];

    void Start() {
        cam = Camera.main;
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
        }
        else if (kymmenenedellista[3] == 4 && kymmenenedellista[4] == 2 && kymmenenedellista[5] == 8 && kymmenenedellista[6] == 8 && kymmenenedellista[7] == 8 && kymmenenedellista[8] == 3 && kymmenenedellista[9] == 3) {
            Debug.Log("GAVE");
        }
        else if (kymmenenedellista[3] == 7 && kymmenenedellista[4] == 7 && kymmenenedellista[5] == 7 && kymmenenedellista[6] == 8 && kymmenenedellista[7] == 8 && kymmenenedellista[8] == 6 && kymmenenedellista[9] == 6) {
            Debug.Log("RUN");
        }
    }

    private void Update() {
        //Debug.Log(cam.ScreenToWorldPoint(Input.mousePosition));
        //Debug.Log(Input.mousePosition);
    }
    public void OnMouseDown() {
        Vector3 worldpos = cam.ScreenToWorldPoint(Input.mousePosition);
        Debug.Log(worldpos.x +", " +worldpos.y);
        if (worldpos.x > -4 && worldpos.x < -1.5) {
            if (worldpos.y > 1.5 && worldpos.y < 3) {
                lisaaNumero(1);
            }
            else if (worldpos.y > 0 && worldpos.y < 1.5) {
                lisaaNumero(4);
            }
            else if (worldpos.y > -1.5 && worldpos.y < 0) {
                lisaaNumero(7);
            }
        }
        else if (worldpos.x > -1.5 && worldpos.x < 1.5) {
            if (worldpos.y > 1.5 && worldpos.y < 3) {
                lisaaNumero(2);
            }
            else if (worldpos.y > 0 && worldpos.y < 1.5) {
                lisaaNumero(5);
            }
            else if (worldpos.y > -1.5 && worldpos.y < 0) {
                lisaaNumero(8);
            }
            else if (worldpos.y > -3 && worldpos.y < -1.5) {
                lisaaNumero(0);
            }
        }
        else if (worldpos.x > 1.5 && worldpos.x < 4) {
            if (worldpos.y > 1.5 && worldpos.y < 3) {
                lisaaNumero(3);
            }
            else if (worldpos.y > 0 && worldpos.y < 1.5) {
                lisaaNumero(6);
            }
            else if (worldpos.y > -1.5 && worldpos.y < 0) {
                lisaaNumero(9);
            }
        }
        tulosta();
        tarkistaSana();
        //Debug.Log(worldpos);
    }
}
