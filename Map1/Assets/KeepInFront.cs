using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepInFront : MonoBehaviour
{

    public Transform cameraTransform;
    public float distanceFromCamera = 1f;

     void Update()
     {
         if(Time.timeScale != 0)
         {
            transform.eulerAngles = cameraTransform.eulerAngles;
            Vector3 resultingPosition = cameraTransform.position + cameraTransform.forward * distanceFromCamera;
            transform.position = new Vector3 (resultingPosition.x, transform.position.y, resultingPosition.z);
         }
         
     }
}
