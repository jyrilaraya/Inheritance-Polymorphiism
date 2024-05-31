using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swordsman : Player
{
    public new void Start()
    {
        playerName = "Jyhoo";
        Debug.Log(playerName);
        BasicAttack();
        Skill();
    }
    public override void BasicAttack()
    {
        Debug.Log("Swordsman Attack");
    }
    public override void Skill()
    {
        Debug.Log("SHUNG SHUNG");
    }
}
