using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{//musicas
    public AudioClip[] musicasFX;
    public AudioSource musicas;
    public AudioClip[] clips;
    public AudioSource musicaBG;
//sonsFX
    public AudioClip[] clipsFX;
    public AudioSource sonsFX;
    public int fase;

    public static AudioManager instance;


    private float orthoSize = 5f;
    [SerializeField] private float aspect = 1.75f;


    void Awake()
    {
        if(instance == null)
        {
           instance = this;
           DontDestroyOnLoad(this.gameObject);
        }
        else
        {
             Destroy(gameObject);
        }

       // GameManager.WinerEvent += WinPlayer;
    }
    
    void Start()
    {

        fase = SceneManager.GetActiveScene().buildIndex;

         if (SceneManager.GetActiveScene().buildIndex == 1 || SceneManager.GetActiveScene().buildIndex == 2)
        {
            MusicaToca(0);
            musicaBG.Play();
        }

    }

    // Update is called once per frame
    void Update()
    {

       if(!musicaBG.isPlaying )
        {
            musicaBG.clip = GetRandom();
            musicaBG.Play();
        }

        

        fase = SceneManager.GetActiveScene().buildIndex;

        if (fase != 100)
        {

            Camera.main.projectionMatrix = Matrix4x4.Ortho(-orthoSize * aspect, orthoSize * aspect, -orthoSize, orthoSize, Camera.main.nearClipPlane, Camera.main.farClipPlane);

        }



    }

    AudioClip GetRandom()
    {
        return clips[Random.Range(1,clips.Length)];
    }
     
     public void SonsFXToca(int index)
     {
         sonsFX.clip = clipsFX [index];
         sonsFX.Play();
     }

     public void MusicaFXToca(int index)
     {
         musicas.clip = musicasFX [index];
         musicas.Play();
     }

    public void MusicaToca(int index)
    {
        musicaBG.clip = clips[index];
        musicaBG.Play();
    }

    /*  public void WinPlayer()
      {
          // Será chamado no event do GameManager WinPlayer
          SonsFXToca(5);
      }*/


    void VerificaFase(Scene cena, LoadSceneMode modo)
    {
        fase = SceneManager.GetActiveScene().buildIndex;

        if (fase != 0 && fase != 1 && fase != 2 && fase != 3 && fase != 4 && fase != 5)
        {

            Camera.main.projectionMatrix = Matrix4x4.Ortho(-orthoSize * aspect, orthoSize * aspect, -orthoSize, orthoSize, Camera.main.nearClipPlane, Camera.main.farClipPlane);
            
        }
    }
     
}


