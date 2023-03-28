using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clicker : MonoBehaviour
{
    private Camera camera;
    private ScoreManager scoreManager;

    private void Awake()
    {
        camera = Camera.main;
        scoreManager = GameObject.Find("Main Manager").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    private void Update()
    {
        CheckClick();
    }

    private void CheckClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePosition = Input.mousePosition;
            Ray ray = camera.ScreenPointToRay(mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                Animal animal = hit.collider.GetComponentInParent<Animal>();
                if (animal != null) {
                    scoreManager.UpdateScore(animal.Value);
                    animal.OnClick();
                }
            }
        }
    }
}
