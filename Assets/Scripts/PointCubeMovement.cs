using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointCubeMovement : MonoBehaviour
{
    PlayerMovement pm;
    [SerializeField] private ParticleSystem pointExplosion;
    [SerializeField] private float speed;
    [SerializeField] private float timer = 0f;
    private void Awake()
    {
        pm = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
    }
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

  

        if (pm.pointScore >= 5 && pm.pointScore < 10)
        {
            speed = 32f;
         
        }
        else if (pm.pointScore >= 10 && pm.pointScore < 15)
        {
            speed = 34f;
        }
        else if (pm.pointScore >= 15 && pm.pointScore < 20)
        {
            speed = 36f;
        }
        else if (pm.pointScore >= 20 && pm.pointScore < 25)
        {
            speed = 38f;
        }
        else if (pm.pointScore >= 25 && pm.pointScore <30)
        {
            speed = 40f;
        }
        else if (pm.pointScore >= 30 && pm.pointScore < 35)
        {
            speed = 42f;
        }
        else if (pm.pointScore >= 35 && pm.pointScore < 40)
        {
            speed = 44f;
        }
        else if (pm.pointScore >= 40 && pm.pointScore < 45)
        {
            speed = 46f;
        }
        else if (pm.pointScore >= 45 && pm.pointScore < 50)
        {
            speed = 48f;
        }
        else if (pm.pointScore >= 50)
        {
            speed = 50f;
        }
        else
        {
            Debug.Log("ERROR");
        }

        if (pm.pointScore == 5 || pm.pointScore == 10|| pm.pointScore == 15 || pm.pointScore == 20 || pm.pointScore == 25||pm.pointScore == 30 || pm.pointScore == 35 || pm.pointScore == 40 || pm.pointScore == 45 || pm.pointScore == 50)
        {
            timer += Time.deltaTime;
            if(timer <= 1f)
            {
                pm.popuptext.SetActive(true);
            }
            else
            {
                pm.popuptext.SetActive(false);
            }
            
        }
        else
        {
            pm.popuptext.SetActive(false);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            Instantiate(pointExplosion,transform.position, Quaternion.identity);
        }
    }
}
