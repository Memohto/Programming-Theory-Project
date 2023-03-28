using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private Animal[] animals;

    private float zSpawnRange = 6;
    private float xSpawnPos = -28;

    private void Start()
    {
        InvokeRepeating("SpawnAnimal", 1, 1);
    }

    private void SpawnAnimal() {
        int index = Random.Range(0, animals.Length);
        Instantiate(animals[index], new Vector3(xSpawnPos, 0, Random.Range(-zSpawnRange, zSpawnRange)), animals[index].transform.rotation);
    }
}
