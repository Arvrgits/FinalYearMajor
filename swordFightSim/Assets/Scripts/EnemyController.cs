using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [System.NonSerialized] public float health = 10f;
    public Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        health = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update enemy");
      //  if (health ==  0|| health<0 )
       // {
       //     Debug.Log("nme slayen");
       //     Destroy(gameObject);
        //}
    }
    public void die()
    {
        //DestroyImmediate(gameObject,true);
        StartCoroutine(DestroyAfterDelay());
    }

    public void TestEnemyscript()
    {
        Debug.Log("Enemyscript attached");
    }
    private IEnumerator DestroyAfterDelay()
    {
        yield return new WaitForSeconds(0.1f); // Adjust the delay as needed
        Destroy(gameObject);
    }

}