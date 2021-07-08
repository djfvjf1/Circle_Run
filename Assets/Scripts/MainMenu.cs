using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/* 
   0 - главное меню;
   1 - игра;
   2 - проигрыш.
*/

public class MainMenu : MonoBehaviour
{

    public int money; 
    public int earnedMoney;
    public Text moneyText;


    private void Start()
    {

        money = PlayerPrefs.GetInt("Money");
        earnedMoney = PlayerPrefs.GetInt("Score");
        money += earnedMoney;
        PlayerPrefs.SetInt("Money", money); // Запишем и сохраним в реестр под названием "Money"

        moneyText.text = money.ToString();
        earnedMoney = 0;
        PlayerPrefs.SetInt("Score", earnedMoney);

    }


    public void StartGame()
    {

        SceneManager.LoadScene(1);

    }

}
