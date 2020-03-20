using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    private void OnControllerColliderHit (ControllerColliderHit hit)
        {
        	if (hit.gameObject.tag == "oldman")
     		{
         		Debug.Log("You have hit Harold");
     		}
        }
}
