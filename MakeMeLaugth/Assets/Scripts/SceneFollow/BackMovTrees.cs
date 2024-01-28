using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackMovTrees : MonoBehaviour
{
    [SerializeField] private Rigidbody2D back1;
    [SerializeField] private Rigidbody2D back2;
    [SerializeField] private float speedBG1 = 1f;
    [SerializeField] private float speedBG2 = 1f;
    [SerializeField] private float incrementSpeedBG = 1f;
    [SerializeField] private Rigidbody2D[] back1Child;
    [SerializeField] private Rigidbody2D[] back2Child;

    void Start()
    {
        
        back1Child=GetComponentsInChildren<Rigidbody2D>();
        back2Child=GetComponentsInChildren<Rigidbody2D>();
    }

    void Update()
    {
        ChangeVelocity();
        MoveChildren();
    }
    private void ChangeVelocity()
    {
        speedBG1 += incrementSpeedBG * Time.deltaTime;
        speedBG2 += incrementSpeedBG * Time.deltaTime;

       back1.velocity = new Vector2(-speedBG1, 0f);
       back2.velocity = new Vector2(-speedBG2, 0f);

    }

    private void MoveChildren()
    {
        for (int i = 0; i < back1Child.Length; i++)
        {
            back1Child[i].velocity = new Vector2(-speedBG1, 0f);
        }
        for (int i = 0; i < back2Child.Length; i++)
        {
            back2Child[i].velocity = new Vector2(-speedBG2, 0f);
        }


    }
}
