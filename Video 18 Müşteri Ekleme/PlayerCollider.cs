using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollider : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
         if(other.CompareTag("CustomerArea"))
        {
            Debug.Log("Musteri alanina girilidi");
        }
    }
}
