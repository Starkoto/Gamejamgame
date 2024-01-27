using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public int maxhp = 100;
    public int maxhappy = 100;
    public int currenthp;
    public int currenthappy;
    void Start()
    {
        currenthp = maxhp;
        currenthappy = 50;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
