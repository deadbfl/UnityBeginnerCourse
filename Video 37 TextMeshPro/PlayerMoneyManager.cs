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
    }

    public void IncreaseMoney(int value)
    {
        money += value;
        ChangeMoneyText();
    }

    public void DecreaseMoney(int value)
    {
        money -= value;
        ChangeMoneyText();
    }

    private void ChangeMoneyText()
    {
        moneyText.text = "Money : " + money;
    }
}
