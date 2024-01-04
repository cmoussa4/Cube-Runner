using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreCounter;
    private float seconds;
    // Start is called before the first frame update
    void Start()
    {
        seconds = 0f;
        
    }

    // Update is called once per frame
    void Update()
    {
        seconds += Time.deltaTime;
        
        scoreCounter.text = "SECONDS: " + ((int)seconds).ToString();
    }
}
