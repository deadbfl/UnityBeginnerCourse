using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFoodType : MonoBehaviour
{
    public static PlayerFoodType instance;

    public int foodType;

    private void Awake()
    {
        instance = this;
    }
}
