using Oculus.Interaction;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public EnemyController EnemyController;
    // Start is called before the first frame update
    void Start()
    {
        EnemyController.TestEnemyscript();
        Debug.Log(EnemyController.health);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(EnemyController.health);
        if (EnemyController != null)
        {
            // Example: Reduce health by 10
           // EnemyController.health -= 10;
            Debug.Log("Enemy Health: " + EnemyController.health);
        }
    }
    private void OnTriggerEnter(Collider collision)
    {
        
        if (collision.gameObject.tag == "enemy")
        {
            //Get the prop stuff
            Debug.Log("we hit nme");
            if (EnemyController != null)
            {
                // Example: Reduce health by 10
                EnemyController.health -= 10;
                Debug.Log("Enemy Health: " + EnemyController.health);
                if(EnemyController.health<=0) { EnemyController.die(); }
            }
        }
    }
}
