using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTile : MonoBehaviour
{
    GroundSpawner groundSpawner;
    public GameObject obstaclePrefab;
    public GameObject coinPrefab;

    // Start is called before the first frame update
    void Start()
    {
        groundSpawner = GameObject.FindObjectOfType<GroundSpawner>();
    }

    private void OnTriggerExit(Collider other) {
        groundSpawner.SpawnTile(true);
        Destroy(gameObject, 2);
    }

    public void SpawnObstacle(){
        int obstacleSpawnerIndex = Random.Range(2,5);
        Vector3 spawnPos = transform.GetChild(obstacleSpawnerIndex).transform.position;
        Instantiate(obstaclePrefab, spawnPos, Quaternion.identity, transform);
    }

    public void SpawnCoins(){
        int coinsToSpawn = 5;
        for (int i = 0; i < coinsToSpawn; i++)
        {  
            GameObject temp = Instantiate(coinPrefab, transform);
            temp.transform.position = GetRandomPointInCollider(GetComponent<Collider>());
        }
    }

    Vector3 GetRandomPointInCollider(Collider collider){
        Vector3 point = new Vector3(
            Random.Range(collider.bounds.min.x, collider.bounds.max.x),
            Random.Range(collider.bounds.min.y, collider.bounds.max.y),
            Random.Range(collider.bounds.min.z, collider.bounds.max.z)
        );

        point.y = 1;
        return point;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
