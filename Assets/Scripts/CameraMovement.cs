using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform playerTransform;       //Transform of the object camera should follow
    public float cameraDistance = 100;      //Distance of camera. Camera distance is increased as value is decreased. 

    void Awake()
    {
        GetComponent<UnityEngine.Camera>().orthographicSize = ((Screen.height / 2) / cameraDistance);       //Getting camera within scene and setting distance  
    }

    void FixedUpdate()
    {
        if(playerTransform != null)
        {
            transform.position = new Vector3(playerTransform.position.x, playerTransform.position.y, transform.position.z);     //changing position of camera to transform of object
        }    
    }
}