using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public float startTimeBtwSpawns;
    public float timeDecrease;
    public float minTime;
    public GameObject prefab;
    public Transform[] spawnPoints;

    private float timeBtwSpawns;

    private void Start() {
        timeBtwSpawns = startTimeBtwSpawns;
    }

    private void Update() {
        if (timeBtwSpawns <= 0) {
            int rand = Random.Range(0, spawnPoints.Length);
            Instantiate(prefab, spawnPoints[rand].position, Quaternion.identity);
            timeBtwSpawns = startTimeBtwSpawns;
            if (startTimeBtwSpawns > minTime) {
                startTimeBtwSpawns -= timeDecrease;
            }
        } else {
            timeBtwSpawns -= Time.deltaTime;
        }
    }

}
