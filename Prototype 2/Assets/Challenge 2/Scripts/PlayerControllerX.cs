using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float spawnStart = 0;
    private float coolDownDuration = 1.0f;

    // Update is called once per frame
    void Update()
    {
        // Check if enough time has passed since the last dog was spawned
        if (Time.time - spawnStart >= coolDownDuration)
        {
            // On spacebar press, send dog
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                spawnStart = Time.time;
            }
        }
    }
}

