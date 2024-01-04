using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    PlayerMovement pm;
    [SerializeField] private GameObject enemy;
    private float spawnTimer = 0f;
    private float spawnIntervals;


    // Start is called before the first frame update
    void Start()
    {
        pm = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
        
        spawnTimer = spawnIntervals;
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer += Time.deltaTime;
               
        if (spawnTimer >= 1f && pm!= null)
        {
           spawnTimer = spawnIntervals;
           float randomspawn = Random.Range(-4.5f, 4.5f);
           Vector3 spawn = new Vector3(randomspawn, 1.0f, 24.0f);
           Instantiate(enemy, spawn, Quaternion.identity);
          
        }
            
    }
}
