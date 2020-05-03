using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodController : MonoBehaviour
{
    private bool moved = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void teleport()
    {
        if (moved)
        {
            transform.position = new Vector3(4.6f, 1.8f, -16.84f);
            moved = false;
        }
        else
        {
            transform.position = new Vector3(0f, 1.8f, 0f);
            moved = true;
        }
    }
}
