using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WomanAliveOrNot : MonoBehaviour
{
    public GameObject buttonPija;
    public GameObject buttonOtaku;
    public GameObject panelColorPija;
    public GameObject panelColorOtaku;



    private void Start()
    {
        WomanAliveCharge();
    }
    public void WomanAliveCharge()
    {
        if (PlayerPrefs.GetInt("woman1alive") == 0)
        {
            buttonOtaku.SetActive(false);   
            panelColorOtaku.SetActive(true);
        }
        if (PlayerPrefs.GetInt("woman2alive") == 0)
        {
            buttonPija.SetActive(false);
            panelColorPija.SetActive(true) ;
            
        }
    }

}
