using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacle : MonoBehaviour
{
    public GameObject obstacle;
    public float maxX;
    public float maxY;
    public float minX;
    public float minY;
    public float timeBetweenSpawn;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(obstaclewave());
    }

    // Update is called once per frame
    void Spawn()
    {
        float randomX = UnityEngine.Random.Range(minX, maxX);
        float randomY = UnityEngine.Random.Range(minY, maxY);
        GameObject a = Instantiate(obstacle, transform.position + new Vector3(randomX, randomY, 0), transform.rotation) as GameObject;
        
    }

    IEnumerator obstaclewave()
    {
        while (true)
        {
            yield return new WaitForSeconds(timeBetweenSpawn);
            Spawn();
        }
        
    }
}
