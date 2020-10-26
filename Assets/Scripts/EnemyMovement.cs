using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Rigidbody2D myRigidbody;     //Rigidbody component
    public float movespeed;             //variable to determine move speed
    public float jumpforce;             //variable to determine jump force

    // Use this for initialization
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();      //Rigidbody set to rigidbody of object
    }

    // Update is called once per frame
    void Update()
    {
        myRigidbody.velocity = new Vector2(movespeed, myRigidbody.velocity.y);      //move the object's rigidbody, with given speed (Move)
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")       //if collision with object that has the Player tag occurs
        {
            Destroy(collision.gameObject);      //Destroy the object that collided with this object
        }

        if (collision.gameObject.tag == "Obstacle")     //if collision with object that has the Obstacle tag occurs
        {
            myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, jumpforce);      //move the object's rigidbody, with given jumpForce (Jump) 
        }
    }
}