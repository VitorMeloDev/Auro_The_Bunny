using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Fases()
    {
        SceneManager.LoadScene(5);
        AudioManager.instance.SonsFXToca(9);
    }

    public void Sair()
    {
        Application.Quit();
        AudioManager.instance.SonsFXToca(9);
    }

    public void TUTORIAL()
    {
        SceneManager.LoadScene(4);
        AudioManager.instance.SonsFXToca(9);
    }

    public void Credits()
    {
       SceneManager.LoadScene(3);
        AudioManager.instance.SonsFXToca(9);
    }
}
