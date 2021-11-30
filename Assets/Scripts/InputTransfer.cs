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
    public Sprite sitImage;
    public Sprite singImage;
    public Sprite readImage;
    public Sprite lieImage;
    public Sprite drawImage;
    public Sprite cutImage;
    public Sprite blowImage;
    public Sprite biteImage;
    public Image preesensImage;
    public Image imperfectImage;
    public Image perfectImage;
    public Sprite empty;
    public Sprite right;

    public Image onePoint;
    public Image twoPoint;
    public Image threePoint;
    public Image fourPoint;
    public Image fivePoint;
    public Image sixPoint;
    public Image sevenPoint;
    public Image eightPoint;
    public Sprite emptyPoint;
    public Sprite point;

    int verbCalculator = 0;

    string[] arrayAllVerbs = { "sit", "sit", "sit" , "sing", "sang", "sung", "read", "read", "read",
    "lie", "lay", "lain", "draw", "drew", "drawn", "cut", "cut", "cut", "blow", "blew", "blown",
    "bite", "bit", "bitten"};
    List<string> rightAnswer = new List<string>();

    List <List<string>> allVerbs = new List<List<string>>();
    List<Sprite> sprites = new List<Sprite>();
    List<Image> pointImages = new List<Image>();

    Screenswitcher switchScene = new Screenswitcher();
  

    public void Start()
    {
        int value = 0;
        
        for (int i = 0; i < 8; i++)
        {
            List<string> verb = new List<string>();
            Debug.Log("List: " + i);
            for (int j = value; j < value + 3; j++){
            verb.Add(arrayAllVerbs[j]);
                Debug.Log(arrayAllVerbs[j]);
            }
            allVerbs.Add(verb);
            Debug.Log(allVerbs[i][0]);
            value += 3;
            
        }
        sprites.Add(sitImage);
        sprites.Add(singImage);
        sprites.Add(readImage);
        sprites.Add(lieImage);
        sprites.Add(drawImage);
        sprites.Add(cutImage);
        sprites.Add(blowImage);
        sprites.Add(biteImage);

        rightAnswer.Add("sit");
        rightAnswer.Add("sit");
        rightAnswer.Add("sit");

        pointImages.Add(onePoint);
        pointImages.Add(twoPoint);
        pointImages.Add(threePoint);
        pointImages.Add(fourPoint);
        pointImages.Add(fivePoint);
        pointImages.Add(sixPoint);
        pointImages.Add(sevenPoint);
        pointImages.Add(eightPoint);

        Debug.Log("Hei!");
        //Debug.Log(allVerbs[0][0]);
        //Debug.Log(allVerbs[0]);

    }


    public void StoreInput()
    {
        preesens = inputPreesens.text; // inputPerfect.GetComponent<Text>().text;
        imperfect = inputImperfect.text;
        perfect = inputPerfect.text;
        int rightCalculator = 3;

        if (preesens != rightAnswer[0])
        {
            textPreesens.text = rightAnswer[0]; // rightPreesens; //textPreesens.GetComponent<Text>().text = rightAnswer[0];
            rightCalculator --;
        }
        else
        {
            preesensImage.sprite = right;
        }
        if (imperfect != rightAnswer[1])
        {
            textImperfect.text = rightAnswer[1]; // rightImperfect;
            rightCalculator--;
        }
        else
        {
            imperfectImage.sprite = right;
        }
        if (perfect != rightAnswer[2])
        {
            textPerfect.text = rightAnswer[2]; // rightPerfect;
            rightCalculator--;
        }
        else
        {
            perfectImage.sprite = right;
        }

        if (rightCalculator == 3)
        {
            //textPreesens.text = "Right!";
            //pointImages[0].sprite = point;
            allVerbs.RemoveAt(verbCalculator);
            sprites.RemoveAt(verbCalculator);
            //pointImages.RemoveAt(0);

            if (allVerbs.Count != 0)
            {
                verbCalculator--;
            }
        }
        /*if (allVerbs.Count != 0 && verbCalculator == allVerbs.Count -1)
        {
            verbCalculator = 0;
        }*/

        if(allVerbs.Count == 0)
        {
            textPreesens.text = "You got all verbs right!";
            StartCoroutine(WaitAndGoClassroom());
            
            //switchScene.goClassroom();
        }
        else
        {
           StartCoroutine(WaitAndShowNextVerb());
        }
       

    }

    
    private IEnumerator WaitAndShowNextVerb()
    {
        if (verbCalculator == allVerbs.Count - 1)
        {
            verbCalculator = 0;
        }
        else
        {
            verbCalculator++;
        }
        
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(3);
        
        //set new verb --right answers
        rightAnswer[0] = allVerbs[verbCalculator][0];
        rightAnswer[1] = allVerbs[verbCalculator][1]; 
        rightAnswer[2] = allVerbs[verbCalculator][2]; 

        oldImage.sprite = sprites[verbCalculator];

        //set rightImages empty
        preesensImage.sprite = empty;
        imperfectImage.sprite = empty;
        perfectImage.sprite = empty;

        textPreesens.text = "";
        textImperfect.text = "";
        textPerfect.text = "";
        inputPreesens.text = "";
        inputImperfect.text = "";
        inputPerfect.text = "";

        Debug.Log("uusi verbi: " + allVerbs[verbCalculator][0]);
        

    }

    private IEnumerator WaitAndGoClassroom()
    {
        
        
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(3);

        
        switchScene.goClassroom();
    }
}
