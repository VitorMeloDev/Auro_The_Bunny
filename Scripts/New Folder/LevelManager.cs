using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [System.Serializable]
    public class Level 
    {
      public string levelText;
      public bool habilitado;
      public int desbloqueado;
      public bool txtAtivo;
    }

    public GameObject botao;
    public Transform localBtn;
    public List<Level> levelList;


    void ListaAdd()
    {
        foreach (Level level in levelList)
        {
            GameObject btnNovo = Instantiate(botao) as GameObject;
            BotaoLevel btnNew = btnNovo.GetComponent<BotaoLevel> ();
            btnNew.levelTxtBTN.text = level.levelText;
            
            if(PlayerPrefs.GetInt("Level" + btnNew.levelTxtBTN.text) == 1)
            {
                 level.desbloqueado = 1;
                 level.habilitado = true;
                 level.txtAtivo = true;
            }

            btnNew.desbloqueadoBTN = level.desbloqueado;
            btnNew.GetComponent<Button> ().interactable = level.habilitado;
            btnNew.GetComponent<Button>().onClick.AddListener(() => ClickLevel("Level" + btnNew.levelTxtBTN.text));
            btnNew.GetComponentInChildren<Text>().enabled = level.txtAtivo;
            btnNovo.transform.SetParent(localBtn,false);
        }
    }

    void ClickLevel(string level)      
    {
        Debug.Log("Level Carregado � : " + level);
        SceneManager.LoadScene(level);
    }
    
    void Awake()
    {
        Destroy (GameObject.Find("UI_MANAGER(Clone)"));
        Destroy (GameObject.Find("GameManager(Clone)"));
    }


    void Start()
    {
        ListaAdd();
    }
}
