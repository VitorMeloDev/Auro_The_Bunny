using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fruta : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject coleta;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Replay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            AudioManager.instance.SonsFXToca(2);
            Destroy(gameObject);
            Instantiate(coleta, transform.position, transform.rotation);
            
        }
    }
}
