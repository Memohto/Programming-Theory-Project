using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Chick : Animal
{
    private void Start()
    {
        Speed = 10;
        Value = 100;
    }

    // POLYMORPHISM
    public override void OnClick()
    {
        transform.Rotate(Vector3.up, 180, Space.Self);
    }
}
