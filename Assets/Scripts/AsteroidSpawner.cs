using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    
    public GameObject asteroid;
    public Vector3 randomPos;
    public float spawnTimer = 10f;


    private void Start()
    {
      
    }

    void Spawn()
    {
        if (spawnTimer > 10f)
        {
            Instantiate(asteroid, new Vector2(Random.Range(-8f, 8f), 9), transform.rotation);
            spawnTimer = 0f;
           
        }

    }
    private void Update()
    {
        Spawn();
        spawnTimer += Time.deltaTime;

    }
}
