using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public int pointScore;
    [SerializeField] TMP_Text highScore;
    [SerializeField] private TMP_Text pointText;
    [SerializeField] private float speed;
    [SerializeField] private ParticleSystem playerExplosion;
    public AudioSource audio;
    public GameObject popuptext;
    // Start is called before the first frame update
    void Start()
    {

        audio.Play();
        pointScore = 0;
        pointText.text = "Score: ";
        highScore.text = PlayerPrefs.GetInt("HighScoreText", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        Score();
        Fall();

        
        if(pointScore > PlayerPrefs.GetInt("HighScoreText", 0))
        {
            PlayerPrefs.SetInt("HighScoreText", pointScore);
            highScore.text = (pointScore).ToString();
        }
    }

    
    void Movement()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= transform.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Point")
        {

            pointText.text = "score: " + pointScore++.ToString();

        }
    }
    void Score()
    {
        pointText.text = "Points: " + pointScore.ToString();

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Instantiate(playerExplosion, transform.position, Quaternion.identity);
        }
    }
    void Fall()
    {
        if (transform.position.y <= 0f)
        {
            Destroy(this.gameObject);
        }
    }

}