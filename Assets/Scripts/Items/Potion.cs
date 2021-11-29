using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : Item
{
    //Reference to which Does not Exist
    HealthScript health;
    public int amount;
    public override void OnActivate()
    {
        health = GetComponent<HealthScript>();
        health.hp += amount;
        Debug.Log("Restore Health");
    }
}
