using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armadilha : MonoBehaviour
{

    private Animator meuAnim;
    [SerializeField] private GameObject Alertaobj;
    
    // Start is called before the first frame update
    void Start()
    {
        meuAnim = GetComponent<Animator>();
        meuAnim.SetBool("Coelho", false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Alerta()
    {
        Instantiate(Alertaobj, transform.position, transform.rotation);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            meuAnim.SetBool("Coelho", true);
            AudioManager.instance.MusicaFXToca(0);
        }
    }
}
