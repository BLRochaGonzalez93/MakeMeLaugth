using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float timeToLose;
    public float timeToSpeed;

    public List<GameObject> girls;

    public TextMeshProUGUI TMPTimer;

    public int girl;

    private void Start()
    {
        SelecWoman();
    }

    private void Update()
    {
        TMPTimer.text = Mathf.RoundToInt( timeToLose).ToString();
    }

    private void FixedUpdate()
    {
        TimeGone();
    }

    //Time Magnagement
    public void TimeGone() {

        timeToLose -= 1f * Time.fixedDeltaTime;
        if (timeToLose <= 0f) {
            Lose();
        }
    }  

   public void Lose() {
        //Cargar escena perder

        SceneManager.LoadScene("YouDied");
    }

    public void SelecWoman() {
        girl = PlayerPrefs.GetInt("IDwoman");
        for (int i = 0; i < girls.Count; i++)
        {
            if (i == girl)
            {
                girls[i].gameObject.SetActive(true);
            }
            else
            {
                girls[i].gameObject.SetActive(false);
            }
        }
    }

}
