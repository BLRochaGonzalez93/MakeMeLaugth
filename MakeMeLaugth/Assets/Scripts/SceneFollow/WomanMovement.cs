using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WomanMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] GameManager manager;
    
    [SerializeField] Rigidbody2D rb;
    public int ID;
    
    void Start()
    {
       manager= GetComponent<GameManager>();
        
        rb= GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Movement();
    }



    public void Movement()
    {
        //rb.velocity = new Vector2(speed, rb.velocity.y);
        //TODO reduce velocity to seem nearly when time is going, normal velocity when player touch enemy
        
    }

  

    
}
