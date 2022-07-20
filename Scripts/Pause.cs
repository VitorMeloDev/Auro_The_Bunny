using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    

    public void Tempo()
    {
        Time.timeScale = 0;
    }

    public void TempoNormal()
    {
        Time.timeScale = 1;
    }
}
