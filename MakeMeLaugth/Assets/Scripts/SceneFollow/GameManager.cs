using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float timeToLose;
    

    void Start()
    {
        
    }

    
    void Update()
    {
        
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
