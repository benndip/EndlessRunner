using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    public GameObject groundTile;
    Vector3 nextSpawnPoint;
    // Start is called before the first frame update
    void Start()
    {
       for (int i = 0; i < 20; i++)
       {
           SpawnTile();
       }
    }

    public void SpawnTile()
    {
        GameObject temp = Instantiate(groundTile, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;
    }

    // Update is called once per frame
    void Update()
    {
    
    }
}
