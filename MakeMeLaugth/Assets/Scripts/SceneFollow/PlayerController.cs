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
    [SerializeField] private AudioSource audioJump;
    [SerializeField] private AudioSource audioReduceSpeed;
    [SerializeField] private AudioSource audioWin;
    public AudioSource audioLose;
    public bool haTocado=false;
    public bool haTocadoS=false;
    public bool isJumping;
    public bool audioRSpeed;
    void Start()
    {
        player= GetComponent<Rigidbody2D>();
        
    }

  
    void Update()
    {
        onFloor = Physics2D.OverlapCircle(transform.position, distanceFloor, floorLayer);
        if (onFloor)
        {
           
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
            audioJump.Play();
            player.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            isJumping = true;
            
        }
    }

    public void VelocityOn()
    {
        float timeTo = GameManager.FindObjectOfType<GameManager>().timeToLose;
        if ( timeTo<= 50f&& haTocado==false)
        {
            
           
            player.velocity = new Vector2(speed, player.velocity.y);
            
        }
        if(haTocado==true)
        {
            //audioReduceSpeed.Play();
            if(audioRSpeed==false)
            {
                PlayReduceSpeedSound();
            }
            player.velocity = Vector2.left * speedToReduce;
        }
        if(haTocadoS==true)
        {
            //audioReduceSpeed.Play();
            if(audioRSpeed==false)
            {
                PlayReduceSpeedSound();
            }
            player.velocity = Vector2.left * speedToReduce*2;
        }
        
    }
    public void PlayReduceSpeedSound()
    {
        audioReduceSpeed.Play();
        audioRSpeed = true;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Woman"))
        {
           // win
            audioWin.Play();
            SceneManager.LoadScene("KillingScene");
            
        }
        //TODO crear otro tag para cambiar escena
        if (other.CompareTag("Enemy"))
        {
            //Reduce speed
            
            
            haTocado = true;
            
        } 
        if (other.CompareTag("EnemyS"))
        {
            //Reduce speed
            
            
            haTocadoS = true;
            
        }

        if (other.CompareTag("Lose"))
        {
            //Lose
            audioLose.Play();
           // SceneManager.LoadScene("YouDied");
            
        } 
        if (other.CompareTag("Lose1"))
        {
            //Lose, change scene
            
             SceneManager.LoadScene("YouDied");

        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            haTocado = false;
            audioRSpeed=false;
        }
        if (collision.CompareTag("EnemyS"))
        {
            haTocadoS = false;
            audioRSpeed=false;
        }

    }

}
