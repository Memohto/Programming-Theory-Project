using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    // ENCAPSULATION
    public float Speed { get; protected set; }
    public int Value { get; protected set; }

    private Camera camera;

    private void Start()
    {
        camera = Camera.main;
    }

    private void Update()
    {
        Move();
    }

    protected void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }

    // ABSTRACTION
    protected virtual void Move() {
        transform.Translate(Vector3.forward * Speed * Time.deltaTime, Space.Self);
    }

    public abstract void OnClick();
}
