using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Botão : MonoBehaviour
{

    [SerializeField] private int cena;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Fase()
    {
        SceneManager.LoadScene(cena);
        AudioManager.instance.SonsFXToca(9);
    }

    public void ProximaFase()
    {
        Time.timeScale = 1;
        AudioManager.instance.SonsFXToca(9);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Quit()
    {
        AudioManager.instance.SonsFXToca(9);
        SceneManager.LoadScene(2);
        Time.timeScale = 1;
    }

}
