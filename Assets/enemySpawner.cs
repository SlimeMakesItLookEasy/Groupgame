using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    public GameObject triangle;
    private Transform thisTransform;

    private IEnumerator Spawntime()
    {
        yield return new WaitForSeconds(2);
        Instantiate(triangle, thisTransform);
    }

    void Spawn()
    {
        Instantiate(triangle, thisTransform);
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 3, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
