using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Add additional functionality to remain crouched when between two platforms
//and crouch button

public class Crouch : MonoBehaviour
{
    // Start is called before the first frame update

    public Collider2D standCollider;
    public Collider2D crouchCollider;
    public Animator charAnimation;
    bool isCrouching;

    private void Start()
    {
        isCrouching = false;
        charAnimation = gameObject.GetComponent<Animator>();
    }

    public void Crouching()
    {
        isCrouching = true;
        charAnimation.SetBool("isCrawling", true);
        standCollider.enabled = false;
        crouchCollider.enabled = true;
    }    

    public void notCrouching()
    {
        isCrouching = false;
        charAnimation.SetBool("isCrawling", false);
        standCollider.enabled = true;
        crouchCollider.enabled = false;
    }

    public void Toggle()
    {
        if (!isCrouching)
        {
            Crouching();
        }
        else
        {
            notCrouching();
        }
    }
}