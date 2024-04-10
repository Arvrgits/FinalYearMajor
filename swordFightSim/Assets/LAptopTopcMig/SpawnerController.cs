using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    public float TimeElapsed = 0f;
    public GameObject Spawner;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TimeElapsed +=  Time.deltaTime;
        Debug.Log(TimeElapsed);
        if(TimeElapsed >= 3)
        {
            Spawner.SetActive(true);
        }
    }
}
