using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopAssist : MonoBehaviour
{

    public int money;
    public Text moneyText;
    public bool isMulty = false;


    // Start is called before the first frame update
    void Start()
    {

        isMulty = PlayerPrefs.GetInt("isMulty") == 1 ? true : false;
        money = PlayerPrefs.GetInt("Money");

    }

    // Update is called once per frame
    void Update()
    {

        // Чтобы кол-во денег отражалось правильно, мы должны обновлять это значение на каждом кадре
        // Поэтому записываем сеттер в методе Апдейт, а не в Cтарте
        moneyText.text = money.ToString();

    }

    // Этот метод будет выполняться при нажатии на кнопку
    public void BuyMUlty()
    {

        if (money >= 1000 && isMulty == false) // Если у игрока больше или равно 10 монет и при этом множитель еще не куплен, то выполняется условие; если же множитель уже куплен, то ты идешь нахуй
        {
            isMulty = true;
            money -= 1000;
            PlayerPrefs.SetInt("Money", money);
            PlayerPrefs.SetInt("isMulty", isMulty ? 1 : 0);
        }

    }


    public void ExitShop()
    {

        SceneManager.LoadScene(0);

    }

}

