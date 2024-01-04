using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EffectSpawner : MonoBehaviour
{
    [SerializeField] private GameObject sphere;
    [SerializeField] private GameObject sphere2;
    private float spawnTimer = 0f;
    private float spawnIntervals;
    // Start is called before the first frame update
    void Start()
    {
        spawnTimer = spawnIntervals;
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer += Time.deltaTime;
        if(spawnTimer>= 0.5f)
        {
            spawnTimer = spawnIntervals;
            float randomy = Random.Range(2f, 30f);
            float randomx = Random.Range(-40f, 40f);
            Vector3 spawn = new Vector3(randomx, randomy, 80.0f);
            Instantiate(sphere, spawn, Quaternion.identity);
            float randomy2 = Random.Range(2f, 30f);
            float randomx2 = Random.Range(-40f, 40f);
            Vector3 spawn2 = new Vector3(randomx2, randomy2, 80.0f);
            Instantiate(sphere2, spawn2, Quaternion.identity);

        }
    }

}
