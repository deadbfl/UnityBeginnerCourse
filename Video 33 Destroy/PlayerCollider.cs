using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollider : MonoBehaviour
{
    public static PlayerCollider instance;

    [SerializeField] private GameObject customerPanel;
    [SerializeField] private GameObject kitchenPanel;

    public bool isInsideOfKitchen;

    private void Awake()
    {
        instance = this;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CustomerArea"))
        {
            customerPanel.SetActive(true);
        }

        if (other.CompareTag("KitchenArea"))
        {
            kitchenPanel.SetActive(true);
            isInsideOfKitchen = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("CustomerArea"))
        {
            customerPanel.SetActive(false);
        }

        if (other.CompareTag("KitchenArea"))
        {
            kitchenPanel.SetActive(false);
            isInsideOfKitchen = false;
        }
    }
}
