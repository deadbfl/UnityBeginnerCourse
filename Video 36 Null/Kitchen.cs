using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kitchen : MonoBehaviour
{
    [SerializeField] private GameObject[] foods;
    [SerializeField] private Transform spawnPoint;

    public Transform playerHand;

    private GameObject currentFood;

    public int foodType;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (PlayerCollider.instance.isInsideOfKitchen && currentFood != null)
            {
                currentFood.transform.position = playerHand.transform.position;
                currentFood.transform.parent = playerHand.transform;
                PlayerFoodType.instance.currentFoodType = foodType;
                PlayerFoodType.instance.currentFoodObject = currentFood;
                currentFood = null;
            }
        }
    }
    public void CreateFood()
    {
        foodType = PlayerFoodType.instance.foodType;

        if (0 <= foodType && foodType < foods.Length)
        {
            Vector3 firstFoodPosition = foods[foodType].transform.position;
            currentFood = Instantiate(foods[foodType], spawnPoint.position + firstFoodPosition, Quaternion.identity);
        }
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
