using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Loading : MonoBehaviour
{
    [SerializeField] private float tempo;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        tempo = tempo - Time.deltaTime;
        Carreagar();
    }

    public void Carreagar()
    {
        if (tempo<= 0)
        {
            SceneManager.LoadScene(1);
        }
    }
}
