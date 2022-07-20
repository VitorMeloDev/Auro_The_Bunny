using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuAudioContro : MonoBehaviour
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
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            meuAnim.SetBool("Menu", false);
        }
    }

    public void Menu()
    {
        meuAnim.SetBool("Menu", true);
    }
}
