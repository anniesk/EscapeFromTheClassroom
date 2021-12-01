using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemActivator : MonoBehaviour
{

    [SerializeField]
    public double distanceFromPlayer;
    //private GameObject player;
    public GameObject player;

    public GameObject goPuzzleB;
    public GameObject goPuzzleD;
    public GameObject goPuzzleF;
    public GameObject goPuzzleG;

    public List<GameObject> activatorItems;


    List<string> storyItems;

    private void Awake()
    {
        //InputTransfer input = new InputTransfer(this);
    }

    // Start is called before the first frame update
    void Start()
    {
        activatorItems.Add(goPuzzleB);
        activatorItems.Add(goPuzzleD);
        activatorItems.Add(goPuzzleF);
        activatorItems.Add(goPuzzleG);
    }

    void Update()
    {
        //activatorItems.Clear();

        for (int i = 0; i < activatorItems.Count; i++)
        {
            if (Vector3.Distance(player.transform.position, activatorItems[i].transform.position) > distanceFromPlayer)
            {
                //Debug.Log("Player-Item: " + Vector3.Distance(player.transform.position, activatorItems[i].transform.position) + " set distance: " + distanceFromPlayer);

                activatorItems[i].SetActive(false);
            }
            else
            {
                activatorItems[i].SetActive(true);
            }
        }
    }

}
   