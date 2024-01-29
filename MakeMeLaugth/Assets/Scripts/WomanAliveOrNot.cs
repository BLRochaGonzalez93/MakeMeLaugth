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

    public int wPija, wOtaku;

    private void Start()
    {
        wPija = PlayerPrefs.GetInt("woman2alive");
        wOtaku = PlayerPrefs.GetInt("woman1alive");
        WomanAliveCharge();
    }
    public void WomanAliveCharge()
    {
        if (wPija == 0)
        {
            buttonPija.SetActive(false);
            panelColorPija.SetActive(true);
        }
        else
        {
            buttonPija.SetActive(true);
            panelColorPija.SetActive(false);
        }


        if (wOtaku == 0)
        {
            buttonOtaku.SetActive(false);
            panelColorOtaku.SetActive(true) ;
        }
        else
        {
            buttonOtaku.SetActive(true);
            panelColorOtaku.SetActive(false);
        }
    }

}
