using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    public int health;

    void Start()
    {
        for (int i = 0; i < 10; i += 2)// kac kez tekrar yapilacagi girilir (baslangicDegeri; bitisDegeri; artisMiktari)
        {
            print(i);
            // yapilacak islemi yazmam gerekiyor
        }

        while (health>0) // kosul yazmamiz gerekiyor
        {
            health--;
            print(health);
            // yapilacak islemi yazmam gerekiyor
        }
    }
}
