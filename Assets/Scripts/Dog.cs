using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Dog : Animal
{
    private void Start()
    {
        Speed = 5;
        Value = 25;
    }

    // POLYMORPHISM
    public override void OnClick()
    {
        Destroy(gameObject);
    }
}
