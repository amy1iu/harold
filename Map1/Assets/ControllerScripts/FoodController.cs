using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodController : MonoBehaviour
{
    private bool moved = false;

    private int position = 1;

    Vector3 position1 = new Vector3(4.6f, 4f, -16.84f);
    Vector3 position2 = new Vector3(0f, 4f, -16.84f);
    Vector3 position3 = new Vector3(-5f, 4f, 3.5f);
    Vector3 position4 = new Vector3(4f, 4f, 3.5f);
    Vector3 position5 = new Vector3(-5f, 4f, -20f);
    Vector3 position6 = new Vector3(-5f, 4f, -49f);
    Vector3 position7 = new Vector3(4f, 4f, -49f);
    Vector3 position8 = new Vector3(1f, 4f, -30f);
    Vector3 position9 = new Vector3(5f, 4f, -25f);
    Vector3 position10 = new Vector3(5f, 4f, -35f);
    Vector3 position11 = new Vector3(0f, 4f, 0f);
    Vector3 position12 = new Vector3(0f, 4f, 3.5f);


    private Vector3[] positions;

    // Start is called before the first frame update
    void Start()
    {
        positions = new Vector3[] { position1, position2, position3, position4, position5, position6,
            position7, position8, position9, position10, position11, position12};
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void teleport()
    {
        if (position == 12)
        {
            position = 0;
        }
        transform.position = positions[position];
        position ++;
        /*
        if (moved)
        {
            transform.position = new Vector3(4.6f, 1.8f, -16.84f);
            moved = false;
        }
        else
        {
            transform.position = new Vector3(0f, 1.8f, 0f);
            moved = true;
        }*/
    }
}
