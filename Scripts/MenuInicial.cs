using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuInicial : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CarregarProxima();
    }


    public void CarregarProxima()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(2);
            AudioManager.instance.SonsFXToca(9);       
        }

        if(Input.GetKey(KeyCode.JoystickButton0))
        {
            SceneManager.LoadScene(2);
            AudioManager.instance.SonsFXToca(9);
        }
    }

    public void IrParaInicio()
    {
        SceneManager.LoadScene(2);
    }
}
