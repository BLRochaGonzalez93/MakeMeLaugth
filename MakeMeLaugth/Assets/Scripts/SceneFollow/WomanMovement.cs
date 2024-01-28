using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WomanMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;


    [SerializeField] Rigidbody2D rb;
    public int ID;

    void Start()
    {
       
        rb = GetComponent<Rigidbody2D>();
    }

    
   


   




}
