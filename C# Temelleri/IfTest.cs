using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfTest : MonoBehaviour
{
    public int health;

    private void Start()
    {
        //if (health < 0 || health > 100) print(health);

        //if (health != 0) print("canim var");
        //print(health += 13); // aslinda health = health + 13;
        //print(health % 5); // Mod Alma
        //print(health);
        //health++;
        //print(health);

        //if (health > 50)
        //{
        //    print("saglikli");
        //}
        //else if (0 < health && health <= 50)
        //{
        //    print("yarali");
        //}
        //else
        //{
        //    print("oldu");
        //}
    }
    #region else if yapsi
    //if () // paratezin icine kosulumu giriyorum
    //{
    //    // bu kosul saglanirsa neler yapilacak
    //}
    //else if() // paratezin icine kosulumu giriyorum
    //{
    //    // bu kosul saglanirsa neler yapilacak
    //}
    //else // yukaridaki kosullar haricindeki tum kosullarda else yapisi calisir
    //{
    //    // bu kosul saglanirsa neler yapilacak
    //}
    #endregion
    #region Operators
    /* Aritmetik operatörleri
      +  : toplama
      -  : çıkartma
      *  : çarpma
      /  : bölme
      %  : mod alma
      ++ : bir artırma
      -- : bir azaltma
      += : kendisi ile toplama 
      -= : kendisi ile çıkarma
      *= : kendisi ile çarpma 
      /= : kendisi ile bölme  
      %= : kendisi ile mod alma
    
        Karşılaştırma operatörleri
      == : eşit mi
      != : eşit değil mi
      <  : küçük mü
      >  : büyük mü
      <= : küçük eşit mi
      >= : büyük eşit mi

        Mantıksal operatörler
      && : AND kapısı (iki koşulda sağlanıyorsa çalışır)
      || : OR kapısı  (iki koşuldan en az biri sağlanıyorsa çalışır)
      !  : NOT kapısı (Sonuçları tersine çevirir)
    */
    #endregion
}
