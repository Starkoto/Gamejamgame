using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card3 : MonoBehaviour
{
    // Start is called before the first frame update
    public Cardeffects card3;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    if(Input.GetKey("down")){
        card3.LoseHappy(20);
    }
    
    }
}
