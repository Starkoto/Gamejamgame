using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card1 : MonoBehaviour
{
    public Cardeffects cardeffects;
    public int health;

    // Update is called once per frame
    
    void OnMouseDown()
    {
        // Destroy the object when clicked
        cardeffects.LoseHp(health);
        Destroy(gameObject);
       // Destroy(gameObject);
    }
}
        


        

    


