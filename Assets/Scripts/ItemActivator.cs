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

    int storyStage = 0;
    List<string> storyItems;

    // Start is called before the first frame update
    void Start()
    {
        activatorItems.Add(goPuzzleB);
    }

    void Update()
    {
        if (storyStage == 0)
        for (int i = 0; i < activatorItems.Count; i++)
        {
            if (Vector3.Distance(player.transform.position, activatorItems[i].transform.position) > distanceFromPlayer)
            {
                Debug.Log("Player-Item: " + Vector3.Distance(player.transform.position, activatorItems[i].transform.position) + " set distance: " + distanceFromPlayer);

                activatorItems[i].SetActive(false);
            }
            else
            {
                activatorItems[i].SetActive(true);
            }
        }
    }
    void changeStoryStage(int a)
    {
        storyStage++;
    }
    void changeStoryItems(string b)
    {
        storyItems.Add(b);
    }
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