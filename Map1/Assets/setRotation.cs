using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setRotation : MonoBehaviour
{
    public GameObject minimapBorder;
    public GameObject food;
    public GameObject refPoint;

    float angle = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vector1 = refPoint.transform.position - transform.position;
        Vector3 vector2 = food.transform.position - transform.position;
        float angle = Vector3.AngleBetween(vector2, vector1);
        //print("angle: " + angle);
        minimapBorder.transform.eulerAngles = new Vector3(minimapBorder.transform.eulerAngles.x, minimapBorder.transform.eulerAngles.y,  180-Mathf.Rad2Deg*angle);
    }
}
