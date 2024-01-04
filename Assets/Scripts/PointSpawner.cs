using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointSpawner : MonoBehaviour
{
    PlayerMovement pm;
    [SerializeField] private GameObject point;
    private float spawnTimer = 0f;
    private float spawnIntervals;

    private void Awake()
    {
        pm = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
    }
    // Start is called before the first frame update
    void Start()
    {
        spawnTimer = spawnIntervals;
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer += Time.deltaTime;
        if (spawnTimer >= 2.5f && pm!= null)
        {
            spawnTimer = spawnIntervals;
            float randomspawn = Random.Range(-4.5f, 4.5f);
            Vector3 spawn = new Vector3(randomspawn, 1.0f, 24.0f);
            Instantiate(point, spawn, Quaternion.identity);
        }


    }
}
