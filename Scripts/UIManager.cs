using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    private GameObject pausePainel;
    private bool menu;
    // Start is called before the first frame update
    void Start()
    {
        pausePainel = GameObject.Find("PauseMenu");
        menu = false;
    }

    // Update is called once per frame
    void Update()
    {
        AtivarMenu();
    }

    void AtivarMenu()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            AudioManager.instance.SonsFXToca(11);
            pausePainel.SetActive(true);
            pausePainel.GetComponent<Animator>().Play("PauseMenu");
            // Time.timeScale = 0;
            menu = true;
        }

        if(Input.GetKeyDown(KeyCode.Joystick1Button7))
        {
            AudioManager.instance.SonsFXToca(11);
            pausePainel.SetActive(true);
            pausePainel.GetComponent<Animator>().Play("PauseMenu");
            // Time.timeScale = 0;
            menu = true;
        }

        if (Input.GetKeyDown(KeyCode.P) && menu == true)
        {
            AudioManager.instance.SonsFXToca(11);
            pausePainel.SetActive(true);
            pausePainel.GetComponent<Animator>().Play("PauseIdle");
            // Time.timeScale = 0;
            menu = false;
        }

        if (Input.GetKeyDown(KeyCode.Joystick1Button7) && menu == true)
        {
            AudioManager.instance.SonsFXToca(11);
            pausePainel.SetActive(true);
            pausePainel.GetComponent<Animator>().Play("PauseIdle");
            // Time.timeScale = 0;
            menu = false;
        }
    }

    public void Continue()
    {
        pausePainel.GetComponent<Animator>().Play("PauseIdle");
        AudioManager.instance.SonsFXToca(9);
    }

    public void Quit()
    {
        AudioManager.instance.SonsFXToca(9);
        SceneManager.LoadScene(2);
        Time.timeScale = 1;
    }
}
