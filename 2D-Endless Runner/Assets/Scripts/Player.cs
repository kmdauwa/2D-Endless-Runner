using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float playerSpeed;
    private Rigidbody2D rb;
    private Vector2 playerDirection;
    public Joystick joyStick;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()   //Once per frame - timers and direction
    {

        float directionY = joyStick.Vertical;   //get input from joystick

        /* 
        if (directionY <= 0.5f && directionY >= -0.5f)          //if you want to change senstivity. This code doesn't move character unless joystick goes past halfway both direections. 
        {
            playerSpeed = 0;
        }
        else
        {
            playerSpeed = 15;
        }
        */

        playerDirection = new Vector2(0, directionY).normalized;
        
    }
    void FixedUpdate()  //Once per physics frame - applying force
    {
        rb.velocity = new Vector2(0, playerDirection.y * playerSpeed);
    }
}
