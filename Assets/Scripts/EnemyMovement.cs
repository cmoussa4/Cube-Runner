using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyMovement : MonoBehaviour
{
    PlayerMovement pm;
    [SerializeField]private float enemyspeed;
    
    void Awake()
    {
       pm = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
    }
    // Start is called before the first frame update
    void Start()
    {
        float randomsize = Random.Range(1, 5);
       
        transform.localScale = new Vector3(randomsize, 1.0f, 1.0f);        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position -= transform.forward * enemyspeed * Time.deltaTime;

        if(transform.position.y <= 0f)
        {
            Destroy(this.gameObject);
        }       
        
  
        if(pm.pointScore >= 5 && pm.pointScore < 10)
        {
            enemyspeed = 32f;
        }
        else if(pm.pointScore >= 10 && pm.pointScore < 15)
        {
            enemyspeed = 34f;
        }
        else if(pm.pointScore >= 15 && pm.pointScore < 20)
        {
            enemyspeed = 36f;
        }
        else if(pm.pointScore >= 20 && pm.pointScore < 25)
        {
            enemyspeed = 38f;
        }
        else if(pm.pointScore >= 25 && pm.pointScore <30)
        {
            enemyspeed = 40f;
        }
        else if (pm.pointScore >= 30 && pm.pointScore < 35)
        {
            enemyspeed = 42f;
        }
        else if (pm.pointScore >= 35 && pm.pointScore < 40)
        {
            enemyspeed = 44f;
        }
        else if (pm.pointScore >= 40 && pm.pointScore < 45)
        {
            enemyspeed = 46f;
        }
        else if (pm.pointScore >= 45 && pm.pointScore < 50)
        {
            enemyspeed = 48f;
        }
        else if (pm.pointScore >= 50)
        {
            enemyspeed = 50f;
        }
        else
        {
            Debug.Log("ERROR");
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Destroy(GameObject.FindGameObjectWithTag("Player"));
            
        }
    }
}
