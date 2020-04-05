using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject enemigo;
    public float cooldown, randomRange;

    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("enemigo", 0F, cooldown);

    }

    void SpawnObstacle()
    {
        Vector3 spawnposition;
        spawnposition.x = Random.Range(randomRange, -randomRange);
        spawnposition.y = transform.position.y; //Random.Range(randomRange, -randomRange)
        spawnposition.z = transform.position.z;
        Instantiate(enemigo, spawnposition, Quaternion.identity);
    }
}
