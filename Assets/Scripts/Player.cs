using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//send on player
[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    public float PlayerSpeed;
    public Joystick Joystick;
    private GameOver gameOver;

    private void Start()
    {
        gameOver = GameObject.Find("GameOver").GetComponent<GameOver>();
    }

    private void FixedUpdate()
    {
        movePlayer();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            gameOver.Lose();
        }
    }

    private void movePlayer()
    {
        //get joystic variables
        float disX = Joystick.Horizontal;
        float disY = Joystick.Vertical;
        
        //determine the position to which the player should move
        Vector3 movePosition = new Vector3(disX,disY,0)*PlayerSpeed;
        
        //moves the player
        if(movePosition != Vector3.zero)
          transform.Translate(movePosition);
    }
}
