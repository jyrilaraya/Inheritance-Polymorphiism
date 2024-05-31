using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : Player
{
    public void Start()
    {
        playerName = "Archer";
        Debug.Log(playerName);
        BasicAttack();
        Skill();
    }
    public override void BasicAttack()
    {
        Debug.Log("Archer Attack");
    }
}
