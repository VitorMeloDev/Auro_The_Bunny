using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirEfeito : MonoBehaviour
{
    [SerializeField] private GameObject Meuobj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Destruir()
    {
        Destroy(Meuobj);
    }
}
