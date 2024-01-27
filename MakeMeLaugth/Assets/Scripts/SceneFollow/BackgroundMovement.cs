using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{
    [SerializeField] private float speedBG = 1f;
    [SerializeField] private float incrementSpeedBG = 1f;
    [SerializeField] private Rigidbody2D rb;
    private GameManager gameManager;
    [SerializeField] private Rigidbody2D[] rbChild;
    private float actualTime;
    void Start()
    {
        gameManager = GetComponent<GameManager>();
        rb=GetComponent<Rigidbody2D>();
        
        rbChild= GetComponentsInChildren<Rigidbody2D>();
    }

    void Update()
    {
        ChangeVelocity();
        MoveChildren();

    }
    private void FixedUpdate()
    {
       // actualTime-= Time.time;
        
    }


    private void MoveChildren()
    {
        for (int i = 0; i < rbChild.Length; i++)
        {
            rbChild[i].velocity = new Vector2(-speedBG, 0f);
        }

    }
    private void ChangeVelocity()
    {
        speedBG += incrementSpeedBG * Time.deltaTime;
        
        rb.velocity = new Vector2(-speedBG, 0f);

    }

    
}
