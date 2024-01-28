using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeMenu : MonoBehaviour
{
    public GameObject menu;
    public void HomeMenuPanel(){
        menu.SetActive(true);
    }
    public void closeMenu()
    {
        menu.SetActive(false);
    }

    public void GoBackToTheMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
