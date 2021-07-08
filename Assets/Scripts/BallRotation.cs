using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRotation : MonoBehaviour
{

    //Создадим поле в редакторе Юнити
    [SerializeField] GameObject CentreCircle;

    bool direction = false; // При значении false шарик хуярит против часовой стрелки

   

    void FixedUpdate()
    {
        
        if (direction == false)
        {
            CentreCircle.transform.Rotate(0, 0, 160 * Time.deltaTime);
        }
        else
        {
            CentreCircle.transform.Rotate(0, 0, -160 * Time.deltaTime);

        }

    }


    public void ChangeDirection()
    {

        direction = !direction;

    }

}
