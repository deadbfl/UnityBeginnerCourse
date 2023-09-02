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
            print("The Choosen Food : " + foods[index].name);
            index = Random.Range(0, foods.Length);
            foods[index].SetActive(true);
            customerCheck = true;
        }
    }
    public void RejectCustomer()
    {
        if(customerCheck) // customerCheck ile customerCheck == true birbiri ile ayni islevi gorur
        {
            foods[index].SetActive(false);
            customerCheck = false;
        }
        OpenCustomer();
    }
}
