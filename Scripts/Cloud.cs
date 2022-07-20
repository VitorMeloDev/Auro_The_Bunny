using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour
{
    private Rigidbody2D meuRB;
    [SerializeField] private float velCloud;
    // Start is called before the first frame update
    void Start()
    {
        meuRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        VelNuvem();
    }

    void VelNuvem()
    {
        meuRB.velocity = new Vector2(velCloud, transform.position.y);
    }
}
