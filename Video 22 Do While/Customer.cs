using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer : MonoBehaviour
{
    [SerializeField] private GameObject[] foods;
    [SerializeField] private bool customerCheck = false;

    [SerializeField] private int index;
    private int lastIndex = -1;
    private void OnEnable()
    {
        OpenCustomer();
    }
    private void OnDisable()
    {
        if (customerCheck == false)
        {
            foods[index].SetActive(false);
        }
    }

    public void OpenCustomer()
    {
        if (!customerCheck) // !customerCheck ile customerCheck == false birbiri ile ayni islevi gorur
        {
            do
            {
                index = Random.Range(0, foods.Length); // Yemegimi secti
            } while (index == lastIndex);

            lastIndex = index;
            foods[index].SetActive(true);
            customerCheck = true;
        }
    }
    public void RejectCustomer()
    {
        if (customerCheck) // customerCheck ile customerCheck == true birbiri ile ayni islevi gorur
        {
            foods[index].SetActive(false);
            customerCheck = false;
        }
        OpenCustomer();
    }
}
