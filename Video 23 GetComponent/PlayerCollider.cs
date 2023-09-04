using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollider : MonoBehaviour
{
    [SerializeField] private GameObject customerPanel;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CustomerArea"))
        {
            customerPanel.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("CustomerArea"))
        {
            customerPanel.SetActive(false);
        }
    }
}
