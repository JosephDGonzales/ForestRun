using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Add functionality to jump button and base jump height on how long button is held down.

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D myRigidbody;     //Rigidbody component         
    public float movespeed;             //variable for move speed
    public float jumpforce;             //variable for jump force
    bool isGrounded;                    //variable to determine if touching ground or not
    bool doubleJump;                    //variable to determine whether or not player can double jump

    //public Button JumpButton;

    // Use this for initialization
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();      //setting rigidbody to object's rigidbody
        isGrounded = true;                              //at startup, isGrounded variable is set to true (touching ground)
    }

    // Update is called once per frame
    void Update()
    {
        myRigidbody.velocity = new Vector2(movespeed, myRigidbody.velocity.y);      //move rigidbody, with given move speed (Move)      
    }

    public void Jump()
    {
        if (isGrounded)       //if touching ground
        {
            myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, jumpforce);      //move rigidbody, with given jump force (Jump)
            isGrounded = false;     //set isGrounded variable to false (not touching ground)
            doubleJump = true;      //set doubleJump variable to true
        }
        else
        {
            if (doubleJump)     //if doubleJump variable is true
            {
                doubleJump = false;     //set doubleJump variable to false
                myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, jumpforce);      //move rigidbody, with given jump force (Jump)
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground" && isGrounded == false)        //if collision with object that has the Ground tag occurs and not touching ground
        {
            isGrounded = true;      //set isGrounded variable to true (touching ground)
        }
    }
}