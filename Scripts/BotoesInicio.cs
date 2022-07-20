using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotoesInicio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            AudioManager.instance.SonsFXToca(9);
            SceneManager.LoadScene(2);
        }

        if(Input.GetKeyDown(KeyCode.Joystick1Button1))
        {
            AudioManager.instance.SonsFXToca(9);
            SceneManager.LoadScene(2);
        }
    }

   
}
