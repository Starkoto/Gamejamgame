using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card2 : MonoBehaviour
{
    // Start is called before the first frame update
    public Cardeffects card2;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    if(Input.GetKey("up")){
        card2.GetHappy(20);
    }
    
    }
}
