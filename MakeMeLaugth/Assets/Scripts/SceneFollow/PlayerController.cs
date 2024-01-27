using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Rigidbody2D player;
    [SerializeField] private float jumpForce;
    private bool onFloor;
    [SerializeField] private LayerMask floorLayer;
    [SerializeField] private float distanceFloor = 0.1f;
    void Start()
    {
        player= GetComponent<Rigidbody2D>();
        floorLayer = GetComponent<LayerMask>();
    }

  
    void Update()
    {
        onFloor = Physics2D.OverlapCircle(transform.position, distanceFloor, floorLayer);
        if (onFloor)
        {
            Debug.Log("En suelo");
            Jump();

        }
        
    }

    public void Jump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            player.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            Debug.Log("Salto");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Woman"))
        {
            Debug.Log("Ha tocado");
            //TODO go to winScene
        }
        if (other.CompareTag("Enemy"))
        {
            Debug.Log("Enemigo tocado");
            //TODO Reduce speed
        }

    }

   
}
