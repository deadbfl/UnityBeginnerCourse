using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerMoneyManager : MonoBehaviour
{
    public static PlayerMoneyManager instance;

    public int money;

    public TMP_Text moneyText;

    private void Awake()
    {
        instance = this;
        if(PlayerPrefs.HasKey("Money"))
        {
            money = PlayerPrefs.GetInt("Money");
            ChangeMoneyText();
        }
    }

    public void IncreaseMoney(int value)
    {
        money += value;
        PlayerPrefs.SetInt("Money",money); // Integere deger kaydetmek anlamina gelir
        ChangeMoneyText();
    }

    public void DecreaseMoney(int value)
    {
        money -= value;
        PlayerPrefs.SetInt("Money", money);
        ChangeMoneyText();
    }

    private void ChangeMoneyText()
    {
        moneyText.text = "Money : " + money;
    }
}
