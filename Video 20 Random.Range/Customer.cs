using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer : MonoBehaviour
{
    [SerializeField] private GameObject[] foods;
    [SerializeField] private bool customerCheck = false;

    private int index;
    private void OnEnable()
    {
        if (customerCheck == false)
        {
            index = Random.Range(0, foods.Length);
            foods[index].SetActive(true);
            customerCheck = true;
        }

    }
    private void OnDisable()
    {
        if (customerCheck == false)
        {

            foods[index].SetActive(false);
        }
    }
}
