using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer : MonoBehaviour
{
    public GameObject player;

    [SerializeField] private GameObject[] foods;
    [SerializeField] private bool customerCheck = false;

    [SerializeField] private int index; // Yemek Tipini Tuttugumuz Veri
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

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T) && PlayerFoodType.instance.currentFoodObject != null)
        {
            if(index == PlayerFoodType.instance.currentFoodType)
            {
                PlayerMoneyManager.instance.IncreaseMoney(7);
            }
            else
            {
                PlayerMoneyManager.instance.DecreaseMoney(3);
            }
            Destroy(PlayerFoodType.instance.currentFoodObject);
            PlayerFoodType.instance.currentFoodObject = null;

            RejectCustomer();
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

    public void AcceptCustomer()
    {
        if(customerCheck)
        {
            //print(foods[index].name);   
            player.GetComponent<PlayerFoodType>().foodType = index;
        }
    }
}
