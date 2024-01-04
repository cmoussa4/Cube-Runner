using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    PauseMenu pMenu;
    // Start is called before the first frame update
    void Start()
    {
        pMenu = GameObject.FindGameObjectWithTag("Canvas").GetComponent<PauseMenu>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R) && !pMenu.gamePaused)
        {
            SceneManager.LoadScene(0);
        }
    }
}
