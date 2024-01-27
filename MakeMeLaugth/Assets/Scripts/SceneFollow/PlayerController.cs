using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Rigidbody2D player;
    [SerializeField] private float jumpForce;
    private bool onFloor;
    public bool Onground;
    [SerializeField] private LayerMask floorLayer;
    [SerializeField] private float distanceFloor = 0.1f;
    [SerializeField] private float speed;
    [SerializeField] private float speedToReduce;
    public bool haTocado=false;
    public bool isJumping;
    
    void Start()
    {
        player= GetComponent<Rigidbody2D>();
        
    }

  
    void Update()
    {
        onFloor = Physics2D.OverlapCircle(transform.position, distanceFloor, floorLayer);
        if (onFloor)
        {
           // Debug.Log("En suelo");
           Onground = true;
            Jump();
            

        }
        if(!onFloor)
        {
            Onground= false;
        }
        VelocityOn();
    }
    

    public void Jump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            player.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            isJumping = true;
            Debug.Log("Salto");
        }
    }

    public void VelocityOn()
    {
        float timeTo = GameManager.FindObjectOfType<GameManager>().timeToLose;
        if ( timeTo<= 50f&& haTocado==false)
        {
            
           // player.velocity. = Vector2.right * speed;
            player.velocity = new Vector2(speed, player.velocity.y);
            
        }
        if(haTocado==true)
        {
            player.velocity = Vector2.left * speedToReduce;
        }
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Woman"))
        {
            Debug.Log("Ha ganado");
            SceneManager.LoadScene("KillingScene");
            
        }
        if (other.CompareTag("Enemy"))
        {
            Debug.Log("Enemigo tocado");
            
            haTocado = true;
            
        }
        if (other.CompareTag("Lose"))
        {
            //Lose
            
            Debug.Log("Ha perdido");
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            haTocado = false;
        }
    }

}
