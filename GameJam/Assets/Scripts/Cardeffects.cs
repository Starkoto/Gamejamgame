using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cardeffects : MonoBehaviour
{
   
    public Player player;
    public Healthbar healthbar;
     
    
    public void GetHp(int a){
        player.currenthp += a;
        healthbar.SetHealth(player.currenthp);
    }
    public void GetHappy(int a){
        player.currenthappy += a;
    }
    public void LoseHp(int a){
        player.currenthp -= a;
        healthbar.SetHealth(player.currenthp);
    }
    public void LoseHappy(int a){
        player.currenthappy -= a;
    }
}
