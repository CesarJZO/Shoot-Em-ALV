using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform spawnReference;
    public int amountToSpawn;
    void Start()
    {
        for (int i = 0; i < amountToSpawn; i++)
        {
            SpawnEnemy(new Vector3(Random.Range(-8.7f, 8.7f), spawnReference.position.y, 0));
        }
    }
    public void SpawnEnemy(Vector3 position)
    {
        Instantiate(enemyPrefab, position, Quaternion.identity);
    }
}
