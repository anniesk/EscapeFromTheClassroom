using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScenes2D : MonoBehaviour
{
    [SerializeField] private string newLevel;
    GameObject handler;
    Inventory inventory;
    bool check;

    [SerializeField] private AudioSource fail;
    [SerializeField] private AudioSource success;

    void Start(){
        handler = GameObject.Find("InventoryHandler");
         inventory = handler.GetComponent<Inventory>();
    }

    void OnTriggerEnter2D(Collider2D other) { 

        SpawnPlayer.spawn = new Vector3(transform.position.x, -6, 0);
        //oven avaus ja avaimen tarkistus
        if(other.CompareTag("Player") && this.gameObject.name == "Ovi"){
                 for(int i = 0; i < inventory.Itemlist.Count; i++){
                     if(inventory.Itemlist[i] != null && inventory.Itemlist[i].itemName == "DoorAvain"){
                         SceneManager.LoadScene(newLevel);
                         check = true;
                        }
                        else {
                            check = false;
                        }
                    }
                    if (check == false){
                        // mitä tapahtuu jos ei avainta
                        Debug.Log("Ei avainta.");
                        fail.Play();
                    }
            }
        else if(other.CompareTag("Player") && this.gameObject.name == "Liitutaulu"){
                 for(int i = 0; i < inventory.Itemlist.Count; i++){
                     if(inventory.Itemlist[i] != null && inventory.Itemlist[i].itemName == "Liitu"){
                         success.Play();
                         SceneManager.LoadScene(newLevel);
                         check = true;
                        }
                        else {
                            check = false;
                        }
                    }
                    if (check == false){
                        // mitä tapahtuu jos ei avainta
                        Debug.Log("Ei avainta.");
                        fail.Play();
                    }
            }
        else if(other.CompareTag("Player") && this.gameObject.name == "Pulpetti (2)"){
                 for(int i = 0; i < inventory.Itemlist.Count; i++){
                     if(inventory.Itemlist[i] != null && inventory.Itemlist[i].itemName == "Ruuvimeisseli"){
                         check = true;
                         StartCoroutine(audioWaiter(success, 2));
                         break;
                        }
                        else {
                            check = false;
                        }
                    }
                    if (check == false){
                        // mitä tapahtuu jos ei avainta
                        Debug.Log("Ei avainta.");
                        fail.Play();
                    }
            }
        else if(other.CompareTag("Player") && this.gameObject.name == "Pulpetti"){
                 for(int i = 0; i < inventory.Itemlist.Count; i++){
                     if(inventory.Itemlist[i] != null && inventory.Itemlist[i].itemName == "Avain"){
                         check = true;
                         StartCoroutine(audioWaiter(success, 2));
                         break;
                        }
                        else {
                            check = false;
                        }
                    }
                    if (check == false){
                        // mitä tapahtuu jos ei avainta
                        Debug.Log("Ei avainta.");
                        fail.Play();
                    }
            }
        else if(other.CompareTag("Player") && this.gameObject.name == "Kasvi"){
                Debug.Log("Törmäsit kasviin");
                success.Play();
            }

        else if(other.CompareTag("Player") && this.gameObject.name == "Kirjahylly"){
                StartCoroutine(audioWaiter(success, 2));
            }

        else if(other.CompareTag("Player") && this.gameObject.name == "Kirjahylly (1)"){
                StartCoroutine(audioWaiter(success, 2));
            }
        
        else if(other.CompareTag("Player"))
        {
            
            SceneManager.LoadScene(newLevel);
        }
    }
    public void OnClick(){
            SceneManager.LoadScene(newLevel);
    }

    IEnumerator audioWaiter(AudioSource sound, float seconds) {
        sound.Play();
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene(newLevel);
    }
}

