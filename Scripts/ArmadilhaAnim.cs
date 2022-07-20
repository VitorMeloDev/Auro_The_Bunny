using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmadilhaAnim : MonoBehaviour
{
    private Animator meuAnim;
    // Start is called before the first frame update
    void Start()
    {
        meuAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Animacao()
    {
       // meuAnim.gameObject.transform.rotation = new Vector3(0f, 0f, 360f);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            AudioManager.instance.MusicaFXToca(0);
        }
    }
}
