using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Horse : Animal
{
    private float speedMultiplier = 2;
    private int valueMultiplier = 2;

    private void Start()
    {
        Speed = 4;
        Value = 10;
    }

    // POLYMORPHISM
    public override void OnClick()
    {
        Speed *= speedMultiplier;
        Value *= valueMultiplier;
    }
}
