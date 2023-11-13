using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{

    public GameObject ItemPrefab;
    public float spawnRate = 2f;
    public float spawnHeight = 10f;

    private float nextSpawnTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            SpawnObject();
            nextSpawnTime = Time.time + 1f / spawnRate;
        }
    }

    void SpawnObject()
    {
        float spawnX = Random.Range(-6f, 6f);

        Vector3 spawnPosition = new Vector3(spawnX, spawnHeight, 0f);

        Instantiate(ItemPrefab, spawnPosition, Quaternion.identity);
        
    }
}
