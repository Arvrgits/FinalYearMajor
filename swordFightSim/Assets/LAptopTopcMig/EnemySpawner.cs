using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform player;
    public float respawnTime = 3f;

    void Start()
    {
        StartCoroutine(RespawnEnemy());
    }

    IEnumerator RespawnEnemy()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("enemy");
            foreach (GameObject enemy in enemies)
            {
                enemy.GetComponent<EnemyMovement>().player = player;
            }
        }
    }
}
