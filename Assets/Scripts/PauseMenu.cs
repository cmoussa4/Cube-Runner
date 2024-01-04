using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    PlayerMovement pm;
    public bool gamePaused = false;
    [SerializeField] private GameObject pauseMenu;
    // Start is called before the first frame update
    void Start()
    {
        pm = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gamePaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    
    }
    public void Resume()
    {
        if(pm!= null)
        {
            pauseMenu.SetActive(false);
            Time.timeScale = 1f;
            gamePaused = false;
            pm.audio.Play();
        }
    }
    void Pause()
    {
        if (pm != null)
        {
            pauseMenu.SetActive(true);
            Time.timeScale = 0f;
            gamePaused = true;
            pm.audio.Pause();
        }
      
    }
}
