using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTile : MonoBehaviour
{
    GroundSpawner groundSpawner;
    public GameObject obstaclePrefab;

    // Start is called before the first frame update
    void Start()
    {
        groundSpawner = GameObject.FindObjectOfType<GroundSpawner>();
        SpawnObstacle();
    }

    private void OnTriggerExit(Collider other) {
        groundSpawner.SpawnTile();
        Destroy(gameObject, 2);
    }

    void SpawnObstacle(){
        int obstacleSpawnerIndex = Random.Range(2,5);
        Vector3 spawnPos = transform.GetChild(obstacleSpawnerIndex).transform.position;
        Instantiate(obstaclePrefab, spawnPos, Quaternion.identity, transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
