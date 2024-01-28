using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float timeToLose;
    public float timeToSpeed;

    public TextMeshProUGUI TMPTimer;

    void Start()
    {
       
        
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



}
