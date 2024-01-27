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
        if(Input.GetKeyDown("space")){
            cardeffects.LoseHp(20);
        }
    }
}
