using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public string playerName;
    public void Start()
    {
        BasicAttack();
        Skill();
    }
    public virtual void BasicAttack()
    {
        Debug.Log("Player Attacks!");
    }
    public virtual void Skill()
    {
        Debug.Log("Player ONE PUNCH you");
    }
}
