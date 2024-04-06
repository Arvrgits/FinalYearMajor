using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float health = 100f;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health <=  0)
        {
            Debug.Log("nme slayen");
            Destroy(gameObject);
        }
    }
    public void damageTaken()
    {
       // animator.GetComponet SetBool = true;
    }
}
