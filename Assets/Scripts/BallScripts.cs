using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BallScripts : MonoBehaviour
{

    public int score = 1;
    public bool isMulty;
    [SerializeField] Text scoreText;

    public GameObject PointEffect;


    public void Start()
    {

        isMulty = PlayerPrefs.GetInt("isMulty") == 1 ? true : false;

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
           
        if(collision.gameObject.tag == "Point")
        {
            Destroy(collision.gameObject);
            Instantiate(PointEffect, transform.position, Quaternion.identity); // Создаем объект PointEffect, который будет принимать позицию шарика благодаря transform.position

            // Запишем условие, при котором мы получим бонус х2
            if (isMulty == true)
            {
                score += 2; // Если isMulty == true, то мы получаем два очка
            }
            else
            {
                score++;
            }
        }

        if (collision.gameObject.tag == "Enemy")
        {
            PlayerPrefs.SetInt("Score", score); // Записывает в реестр "Score" значение переменной score 

            Destroy(collision.gameObject);
            score = 0;
            SceneManager.LoadScene(2);
        }

    }



    // Update is called once per frame
    void Update()
    {

        scoreText.text = score.ToString(); // Переводим целочисленное значение "score" в строку

    }
}
