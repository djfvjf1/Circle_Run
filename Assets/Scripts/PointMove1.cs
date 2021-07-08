using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointMove1 : MonoBehaviour
{

    [SerializeField] GameObject point;
    [SerializeField] float speed;



    // Update is called once per frame
    void FixedUpdate()
    {
        point.transform.Translate(speed * Time.deltaTime, 0, 0);
    }
}


