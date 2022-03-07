using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform spawnReference;
    public int amountToSpawn;
    public float spawnCadence = 1;
    public float initialTime = 0.5f;

    void Start()
    {
        StartCoroutine(SpawnEnemies());
    }
    IEnumerator SpawnEnemies()
    {
        yield return new WaitForSeconds(initialTime);
        for (int i = 0; i < amountToSpawn; i++)
        {
            SpawnEnemy(new Vector3(Random.Range(-8.7f, 8.7f), spawnReference.position.y, 0));
            yield return new WaitForSeconds(spawnCadence);
        }
    }
    public void SpawnEnemy(Vector3 position)
    {
        Instantiate(enemyPrefab, position, Quaternion.identity);
    }
}
