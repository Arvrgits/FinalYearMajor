using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform player;
    public float respawnTime = 3f;
    private List<GameObject> enemies = new List<GameObject>();

    void Start()
    {
        StartCoroutine(RespawnEnemy());
    }

    IEnumerator RespawnEnemy()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            Debug.Log("Respawning enemy...");
            if (player == null)
            {
                Debug.LogError("Player is not assigned!");
                yield break; // Exit the coroutine if player is not assigned
            }
            GameObject newEnemy = Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            newEnemy.GetComponent<EnemyMovement>().player = player;
            enemies.Add(newEnemy);
        }
    }
}