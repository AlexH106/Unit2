using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -24.0f;
    private float spawnLimitXRight = 8.0f;
    private float spawnPosY = 28.0f;

    private float startDelay = 2.0f;
    private float lowSpawnInterval = 2.0f;
    private float highSpawnInterval = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnRandomBall", startDelay);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
        int randomBall = Random.Range(0, ballPrefabs.Length);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[randomBall], spawnPos, ballPrefabs[0].transform.rotation);

        float randomSpawnInterval = Random.Range(lowSpawnInterval, highSpawnInterval);
        Invoke("SpawnRandomBall", randomSpawnInterval);
    }

}
