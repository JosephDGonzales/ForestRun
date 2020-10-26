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
    bool isCrouching;

    private void Start()
    {
        isCrouching = false;
    }

    public void Crouching()
    {
        isCrouching = true;
        standCollider.enabled = false;
        crouchCollider.enabled = true;
    }    

    public void notCrouching()
    {
        isCrouching = false;
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