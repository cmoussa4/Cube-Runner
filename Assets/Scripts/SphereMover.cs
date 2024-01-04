using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMover : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= transform.forward * speed * Time.deltaTime;

        if(transform.position.z <= -30f)
        {
            Destroy(this.gameObject);
        }
        if(transform.position.y == 1f)
        {
            Destroy(this.gameObject);
        }
    }
}
