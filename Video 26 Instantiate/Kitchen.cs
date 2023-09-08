using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kitchen : MonoBehaviour
{
    [SerializeField] private GameObject[] foods;

    public int foodType;
    public void CreateFood()
    {
        Instantiate(foods[foodType]);
    }
}
