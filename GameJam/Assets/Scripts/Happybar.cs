using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Happybar : MonoBehaviour
{
   public Slider slider;
    public void SetMaxHappy(int happy){
        slider.maxValue = happy;
        slider.value = happy;
    }
    public void SetHealth(int happy){
        slider.value = happy;
    }
}
