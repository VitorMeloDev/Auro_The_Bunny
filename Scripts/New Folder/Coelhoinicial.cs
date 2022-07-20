using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coelhoinicial : MonoBehaviour
{
    private int Coelho;
    [SerializeField] private float timer = 60;
    private Animator meuAnim;
    // Start is called before the first frame update
    void Start()
    {
        meuAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        MudarAnim();
    }

    void MudarAnim()
    {
        timer -= Time.deltaTime;
        
        if(timer <= 0)
        {
            Coelho = Random.Range(0, 2);
            timer = 60;

            if (Coelho == 0)
            {
                meuAnim.SetTrigger("Deitado");
            }

            if (Coelho == 1)
            {
                meuAnim.SetTrigger("Parado");
            }

            if (Coelho == 2)
            {
                meuAnim.SetTrigger("Sentado");
            }
        }


        

    }
}
