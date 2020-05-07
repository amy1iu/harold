using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayPut : MonoBehaviour
{
    public Camera self;
    public LayerMask topFloor;
    public LayerMask bottomFloor;

    bool top;
    // Start is called before the first frame update
    void Start()
    {
        top = true;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rotation = transform.eulerAngles;

        rotation.x = 90;
        rotation.y = 0;
        rotation.z = -180;

        transform.eulerAngles = rotation;

        var pos = GameObject.Find("Player").transform.position;

        transform.position = new Vector3(pos.x, 5.83f, pos.z);

        if (pos.y < 3 && top)
        {
            self.cullingMask = bottomFloor;
            top = false;
        }
        else if (pos.y > 3 && !top)
        {
            self.cullingMask = topFloor;
            top = true;
        }
    }
}
