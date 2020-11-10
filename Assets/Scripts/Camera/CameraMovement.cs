using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform playerTransform;       //Transform of the object camera should follow
    public float cameraDistance = 100;      //Distance of camera. Camera distance is increased as value is decreased. 
    //public float sceneWidth = 10;

    void Awake()
    {
       GetComponent<UnityEngine.Camera>().orthographicSize = ((Screen.height / 2) / cameraDistance);       //Getting camera within scene and setting distance  
    }

    /*private void Start()
    {
        Camera.main.projectionMatrix = Matrix4x4.Ortho(-5.0f * 1.77f, 5.0f * 1.77f, -5.0f, 0.5f, 0.3f, 1000f);
    }*/

    void FixedUpdate()
    {
        if(playerTransform != null)
        {
            transform.position = new Vector3(playerTransform.position.x, playerTransform.position.y, transform.position.z);     //changing position of camera to transform of object
        }    
    }

    /*private void Update()
    {
        float unitsPerPixel = sceneWidth / Screen.width;

        float desiredHalfHeight = 0.5f * unitsPerPixel * Screen.height;

        GetComponent<UnityEngine.Camera>().orthographicSize = desiredHalfHeight;
    }*/
}