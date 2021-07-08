using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{

    [SerializeField] GameObject enemy;
    [SerializeField] float speed;


   
    // Update is called once per frame
    void FixedUpdate()
    {
        enemy.transform.Translate(speed * Time.deltaTime, 0, 0);     
    }
}
