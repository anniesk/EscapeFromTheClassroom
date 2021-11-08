using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputTransfer : MonoBehaviour
{
    public string preesens;
    public InputField inputPreesens; //GameObject
    public Text textPreesens; // GameObject
    public string imperfect;
    public InputField inputImperfect;
    public Text textImperfect;
    public string perfect;
    public InputField inputPerfect;
    public Text textPerfect;
    public Image oldImage;
    public Sprite newImage;
    //public Sprite ;

    string[] rightAnswer = { "sit", "sit", "sit" };
    string[] arrayAllVerbs = { "sit", "sit", "sit" , "sing", "sang", "sung", "read", "read", "read",
    "lie", "lay", "lain", "draw", "drew", "drawn", "cut", "cut", "cut", "blow", "blew", "blown",
    "bite", "bit", "bitten"};

    List <List<string>> allVerbs = new List<List<string>>();
    List<string> verb = new List<string>();
    //string[] sing = { "sing", "sang", "sung" };
    //string[] read = { "read", "read", "read" };
    //string[] lie = { "lie", "lay", "lain" };
    //string[] draw = { "draw", "drew", "drawn" };
    //string[] cut = { "cut", "cut", "cut" };
    //string[] blow = { "blow", "blew", "blown" };
    //string[] bite = { "bite", "bit", "bitten" };


    public void Start()
    {
        int value = 0;
        for(int i = 0; i < 8; i++)
        {
            Debug.Log("List: " + i);
            for (int j = value; j < value + 3; j++){
            verb.Add(arrayAllVerbs[j]);
                Debug.Log(arrayAllVerbs[j]);
            }
            allVerbs.Add(verb);
            value += 3;
        }
    
        Debug.Log("Hei!");
        Debug.Log(allVerbs[0][0]);
        Debug.Log(allVerbs[0]);

    }


    public void StoreInput()
    {
        preesens = inputPreesens.text; // inputPerfect.GetComponent<Text>().text;
        imperfect = inputImperfect.text;
        perfect = inputPerfect.text;

        if (preesens != rightAnswer[0])
        {
            textPreesens.text = rightAnswer[0]; //textPreesens.GetComponent<Text>().text = rightAnswer[0];
        }
        if (imperfect != rightAnswer[1])
        {
            textImperfect.text = rightAnswer[1];
        }
        if (perfect != rightAnswer[1])
        {
            textPerfect.text = rightAnswer[2];
        }

        StartCoroutine(WaitAndShowNextVerb());

    }

    
    private IEnumerator WaitAndShowNextVerb()
    {
        //Print the time of when the function is first called.
        //Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(5);

        rightAnswer[0] = "sing";
        rightAnswer[1] = "sang";
        rightAnswer[2] = "sung";

        //string newVerb = verbs[0][0];

        oldImage.sprite = newImage;
        //verbs[0][0].sprite = newImage;
        textPreesens.text = "";
        textImperfect.text = "";
        textPerfect.text = "";
        inputPreesens.text = "";
        inputImperfect.text = "";
        inputPerfect.text = "";
        //imperfect = "";
        //perfect = "";

        //After we have waited 5 seconds print the time again.
        //Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }
}
