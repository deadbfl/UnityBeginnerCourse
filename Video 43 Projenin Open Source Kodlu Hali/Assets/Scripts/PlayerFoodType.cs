using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFoodType : MonoBehaviour
{
    public static PlayerFoodType instance;

    public GameObject currentFoodObject;

    public int foodType;
    public int currentFoodType;
    private void Awake()
    {
        instance = this;
    }
}
