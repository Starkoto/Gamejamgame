using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card1 : MonoBehaviour
{
    public Cardeffects cardeffects;

    // Update is called once per frame
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Call a method to handle the destruction
            cardeffects.LoseHp(20);

            // Destroy the object when the mouse button is clicked
            Destroy(gameObject);
        }
    }
}

