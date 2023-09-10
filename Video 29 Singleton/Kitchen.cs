using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kitchen : MonoBehaviour
{
    [SerializeField] private GameObject[] foods;
    [SerializeField] private Transform spawnPoint;

    public int foodType;
    public void CreateFood()
    {
        foodType = PlayerFoodType.instance.foodType;

        Vector3 firstFoodPosition = foods[foodType].transform.position;
        Instantiate(foods[foodType],spawnPoint.position + firstFoodPosition,Quaternion.identity);
    }

    private IEnumerator FoodCoroutine()
    {
        yield return new WaitForSeconds(5);
        CreateFood();
    }

    public void GiveMeFood()
    {
        StartCoroutine(FoodCoroutine());
    }
}
