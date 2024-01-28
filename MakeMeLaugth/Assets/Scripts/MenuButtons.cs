using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public AudioSource ClickSound;

    public void SelectStart()
    {
        
        SceneManager.LoadScene("Intro");
    }

    public void SelectExit()
    {
        
        Application.Quit();

    }
    public void SelectCredits()
    {
       
        SceneManager.LoadScene("Credits");
    }

    public void PlaySoundClick()
    {
        ClickSound.Play();
    }

}
