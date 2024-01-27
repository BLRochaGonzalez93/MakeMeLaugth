using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

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
            lose();
        }
    }  

   

   

    //Win or lose
    public void win()
    {
        //go to killingScene

        Debug.Log("Ha ganado");
    }

    public void lose()
    {
        //Go to loseScene
        Debug.Log("Ha perdido");
    }

}
