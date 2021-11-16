using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Screenswitcher : MonoBehaviour
{
   
    public void goClassroom()
    {
        SceneManager.LoadScene(sceneBuildIndex: 1);
    }

    public void goPuzzleB()
    {
        SceneManager.LoadScene(sceneBuildIndex: 2);
    }
    public void goPuzzleD()
    {
        SceneManager.LoadScene(sceneBuildIndex: 0);
    }

    public void goPuzzleC()
    {
        SceneManager.LoadScene(sceneBuildIndex: 1);
    }

    public void goPuzzleF()
    {
        SceneManager.LoadScene(sceneBuildIndex: 1);
    }

    public void goPuzzleG()
    {
        SceneManager.LoadScene(sceneBuildIndex: 5);
    }
}
