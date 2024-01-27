using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
       

    public void SelectStart()
    {
        SceneManager.LoadScene("LevelChose");
    }

    public void SelectExit()
    {
        Application.Quit();

    }
    public void SelectCredits()
    {
        SceneManager.LoadScene("Credits");
    }

}
