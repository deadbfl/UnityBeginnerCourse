using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoneyManager : MonoBehaviour
{
    public static PlayerMoneyManager instance;

    public int money;

    private void Awake()
    {
        instance = this;
    }

    public void IncreaseMoney(int value)
    {
        money += value;
    }

    public void DecreaseMoney(int value)
    {
        money -= value;
    }
}
