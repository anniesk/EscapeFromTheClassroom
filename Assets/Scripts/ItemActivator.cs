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
    public GameObject goPuzzleBlack;
    
    public List<GameObject> activatorItems;

    int storyStage = 1;
    List<string> storyItems;

    private void Awake()
    {
        InputTransfer input = new InputTransfer(this);
    }

    // Start is called before the first frame update
    void Start()
    {
        activatorItems.Add(goPuzzleBlack);
    }

    void Update()
    {
        activatorItems.Clear();

        if (storyStage == 1) activatorItems.Add(goPuzzleBlack);
        if (storyStage == 2) activatorItems.Add(goPuzzleB);
        if (storyStage == 3) activatorItems.Add(goPuzzleB);

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
    //0 = StartScene, 1 = Pigpen, 2 = Muistipeli, 3 = k�nnykk�, 4 = Ristikko, 5 = Taulu
    //6 = EndScene
    public void changeStoryStage() //int a
    {
        storyStage++;
    }
    public void changeStoryItems(string b)
    {
        storyItems.Add(b);
    }

    /*void whenClicked()
    {
        RaycastHit2D hits2D = Physics2D.GetRayIntersection(ray);
        if (hits2D.collider != null)
        {
            Debug.Log("hit: " + hits2D.collider.tag);
        }

        RaycastHit2D[] hits2DAll = new RaycastHit2D[1];
        int numberOfHits2D = Physics2D.GetRayIntersection(ray);
        for (int i = 0; i < hits2DAll.Length; i++)
        {
            if ( hits2DAll[i].collider != null)
            {
                Debug.Log("Hit All: " + hits2DAll[i].collider.tag);
            }
        }

    }*/
}

    /*IEnumerator CheckActivation()
    {
        List<ActivatorItem> removeList = new List<ActivatorItem>();

        if (activatorItems.Count > 0)
        {
            foreach (ActivatorItem item in activatorItems)
            {
                if (Vector3.Distance(player.transform.position, item.itemPos) > distanceFromPlayer)
                {
                    Debug.Log("Player-Item: " + Vector3.Distance(player.transform.position, item.itemPos) + " set distance: " + distanceFromPlayer);
                    if (item.item == null)
                    {
                        removeList.Add(item);
                    }
                    else
                    {
                        item.item.SetActive(false);
                    }
                }
                else
                {
                    if (item.item == null)
                    {
                        removeList.Add(item);
                    }
                    else
                    {
                        item.item.SetActive(true);
                    }
                }
            }
        }
        yield return new WaitForSeconds(0.01f);

        if(removeList.Count > 0)
        {
            foreach (ActivatorItem item in removeList)
            {
                activatorItems.Remove(item);
            }
        }
        yield return new WaitForSeconds(0.01f);
        StartCoroutine("CheckActivation");
    }
}

public class ActivatorItem
{
    public GameObject item;
    public Vector3 itemPos;
}*/


/*[SerializeField]
public double distanceFromPlayer;
//private GameObject player;
private GameObject player;

//public GameObject goPuzzleB;
//public GameObject goPuzzleD;
//public GameObject goPuzzleBlack;
public List<ActivatorItem> activatorItems;
//public List<GameObject> activatorItems;

// Start is called before the first frame update
void Start()
{
    player = GameObject.Find("Player");
    activatorItems = new List<ActivatorItem>();
    //activatorItems = new List<GameObject>();
    //activatorItems.Add(goPuzzleB);
    //activatorItems.Add(goPuzzleD);
    //activatorItems.Add(goPuzzleBlack);

    StartCoroutine("CheckActivation");
}

IEnumerator CheckActivation()
{
    List<ActivatorItem> removeList = new List<ActivatorItem>();

    if (activatorItems.Count > 0)
    {
        foreach (ActivatorItem item in activatorItems)
        {
            if (Vector3.Distance(player.transform.position, item.itemPos) > distanceFromPlayer)
            {
                Debug.Log("Player-Item: " + Vector3.Distance(player.transform.position, item.itemPos) + " set distance: " + distanceFromPlayer);
                if (item.item == null)
                {
                    removeList.Add(item);
                }
                else
                {
                    item.item.SetActive(false);
                }
            }
            else
            {
                if (item.item == null)
                {
                    removeList.Add(item);
                }
                else
                {
                    item.item.SetActive(true);
                }
            }
        }
    }
    yield return new WaitForSeconds(0.01f);

    if (removeList.Count > 0)
    {
        foreach (ActivatorItem item in removeList)
        {
            activatorItems.Remove(item);
        }
    }
    yield return new WaitForSeconds(0.01f);
    StartCoroutine("CheckActivation");
}
}

public class ActivatorItem
{
    public GameObject item;
    public Vector3 itemPos;
}*/