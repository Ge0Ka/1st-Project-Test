using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSphereGenerator : MonoBehaviour
{
    public GameObject whatPrefab;
    public int numbersofprefabs;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numbersofprefabs; i++)
        {
            var position = new Vector3(Random.Range(-10f, 10f), Random.Range(-5f, 5f), Random.Range(-10f, 10f));
            Instantiate(whatPrefab, position, Quaternion.identity);
        }
    }
}