using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform player;
    public float speed = 3f;

    void Start()
    {
        // Find the player object with the tag "Player"
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        if (player != null) // Ensure player reference is not null
        {
            // Calculate the direction from the enemy to the player
            Vector3 direction = (player.position - transform.position).normalized;

            // Rotate the enemy to face the player
            transform.LookAt(player);

            // Calculate the movement amount
            Vector3 moveAmount = direction * speed * Time.deltaTime;

            // Move the enemy towards the player
            transform.Translate(moveAmount);
        }
    }

    public void EnemyDestroy()
    {
        Debug.Log("Mission Accomplished");
        // Add Game Over Script here
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Player")
        {
            EnemyDestroy();
        }
    }
}