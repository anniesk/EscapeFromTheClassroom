using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BackToClassroom : MonoBehaviour
{
    void OnMouseDown()
    {
        SceneManager.LoadScene(sceneBuildIndex: 1);
    }

}