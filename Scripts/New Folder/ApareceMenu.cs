using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ApareceMenu : MonoBehaviour
{
    private int fase;
    // Start is called before the first frame update
    void Start()
    {
        fase = SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Win()
    {
        AudioManager.instance.SonsFXToca(10);
        
    }

    public void Conquistas()
    {
        //Fases 1-10
        if(fase == 13)
        {
            Achivement.instance.UnlockAchievement("Fase1");
        }

        if (fase == 14)
        {
            Achivement.instance.UnlockAchievement("Fase2");
        }
        
        if (fase == 15)
        {
            Achivement.instance.UnlockAchievement("Fase3");
        }

        if (fase == 16)
        {
            Achivement.instance.UnlockAchievement("Fase4");
        }

        if (fase == 17)
        {
            Achivement.instance.UnlockAchievement("Fase5");
        }

        if (fase == 18)
        {
            Achivement.instance.UnlockAchievement("Fase6");
        }

        if (fase == 19)
        {
            Achivement.instance.UnlockAchievement("Fase7");
        }

        if (fase == 20)
        {
            Achivement.instance.UnlockAchievement("Fase8");
        }

        if (fase == 21)
        {
            Achivement.instance.UnlockAchievement("Fase9");
        }

        if (fase == 22)
        {
            Achivement.instance.UnlockAchievement("Fase10");
        }


        //fases 11-20

        if (fase == 23)
        {
            Achivement.instance.UnlockAchievement("Fase11");
        }

        if (fase == 24)
        {
            Achivement.instance.UnlockAchievement("Fase12");
        }

        if (fase == 25)
        {
            Achivement.instance.UnlockAchievement("Fase13");
        }

        if (fase == 26)
        {
            Achivement.instance.UnlockAchievement("Fase14");
        }

        if (fase == 27)
        {
            Achivement.instance.UnlockAchievement("Fase15");
        }

        if (fase == 28)
        {
            Achivement.instance.UnlockAchievement("Fase16");
        }

        if (fase == 29)
        {
            Achivement.instance.UnlockAchievement("Fase17");
        }

        if (fase == 30)
        {
            Achivement.instance.UnlockAchievement("Fase18");
        }

        if (fase == 31)
        {
            Achivement.instance.UnlockAchievement("Fase19");
        }

        if (fase == 32)
        {
            Achivement.instance.UnlockAchievement("Fase20");
        }


        //fases 21 - 30

        if (fase == 33)
        {
            Achivement.instance.UnlockAchievement("Fase21");
        }

        if (fase == 34)
        {
            Achivement.instance.UnlockAchievement("Fase22");
        }

        if (fase == 35)
        {
            Achivement.instance.UnlockAchievement("Fase23");
        }

        if (fase == 36)
        {
            Achivement.instance.UnlockAchievement("Fase24");
        }

        if (fase == 37)
        {
            Achivement.instance.UnlockAchievement("Fase25");
        }

        if (fase == 38)
        {
            Achivement.instance.UnlockAchievement("Fase26");
        }

        if (fase == 39)
        {
            Achivement.instance.UnlockAchievement("Fase27");
        }

        if (fase == 40)
        {
            Achivement.instance.UnlockAchievement("Fase28");
        }

        if (fase == 41)
        {
            Achivement.instance.UnlockAchievement("Fase29");
        }

        if (fase == 42)
        {
            Achivement.instance.UnlockAchievement("Fase30");
        }
    }

    public void ProximaFase()
    {
        //Time.timeScale = 1;
        //AudioManager.instance.SonsFXToca(9);
        if (fase == 10)
        {
            SceneManager.LoadScene(2);
        }
        
        if (fase != 10)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    public void Tempo()
    {
        Time.timeScale = 0;
    }

    public void TempoNormal()
    {
        Time.timeScale = 1;
    }
}
