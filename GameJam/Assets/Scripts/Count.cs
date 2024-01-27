using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Count : MonoBehaviour
{
    public TextMeshProUGUI score;
    private int count;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
     void Update()
    {

    }
    public void Addscore(){
        count -= 1; 
        score.text =  10 + count + "";
    }

}
