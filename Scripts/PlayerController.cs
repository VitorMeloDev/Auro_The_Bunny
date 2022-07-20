using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D meuRB;

    [SerializeField] private float velPlayer;
    [SerializeField] private float velPulo;
    [SerializeField] private int qtdFrutas;
    private int qtdPulo = 1;
    private int qtdTotalPulo = 1;
    private Animator meuAnim;
    private BoxCollider2D boxCol;
    [SerializeField] private LayerMask level;
    [SerializeField] private GameObject kill;
    private bool piso;
    private GameObject winPainel;
    private bool win;
  

    private bool Morte = false;
   

    public bool onWall;

    public float maxFallSpeed = -1;
    public Vector3 wallOffset;
    
    public float wallRadius;
    public LayerMask walllayer;

    // Start is called before the first frame update
    void Start()
    {
        meuRB = GetComponent<Rigidbody2D>();
        meuAnim = GetComponent<Animator>();
        boxCol = GetComponent<BoxCollider2D>();
        meuAnim.SetBool("Kill", false);

        winPainel = GameObject.Find("WinMenu");
        meuAnim.SetBool("Win", false);
        win = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Morte == false && win == false)
        {
            Movendo();
            Pulo();
            Win();
            PhysicsCheck();
        }
        meuAnim.SetTrigger(null);

        if (win == true)
        {
            meuAnim.SetBool("Win", true);
            meuRB.bodyType = RigidbodyType2D.Static;
        }

    }

    private void FixedUpdate()
    {
        meuAnim.SetBool("Chao", IsGrounded());

       
    }


    void Movendo()
    {
        
            var movimento = Input.GetAxis("Horizontal") * velPlayer;
            meuAnim.SetBool("Andando", false);

            meuRB.velocity = new Vector2(movimento, meuRB.velocity.y);

            if (movimento != 0)
            {
                transform.localScale = new Vector3(Mathf.Sign(movimento), 1, 1);
                meuAnim.SetBool("Andando", true);
            }
        
        
    }

    void Pulo()
    {
        var pulo = Input.GetButtonDown("Jump");

        if (piso == false)
        {
            meuAnim.SetFloat("VelV", meuRB.velocity.y);
        }


        
        if (pulo && qtdPulo > 0)
        {
            
            piso = false;
            meuRB.velocity = new Vector2(meuRB.velocity.x, velPulo);
            AudioManager.instance.SonsFXToca(8);
            qtdPulo--;
        }
    }


    void PhysicsCheck()
    {
        onWall = false;

        bool rightWall = Physics2D.OverlapCircle(transform.position + new Vector3(wallOffset.x, wallOffset.y), wallRadius, walllayer);
        bool leftwall = Physics2D.OverlapCircle(transform.position + new Vector3(-wallOffset.x, wallOffset.y), wallRadius, walllayer);


        if(rightWall || leftwall)
        {
            onWall = true;
        }
        if(onWall)
        {
            if(meuRB.velocity.y < maxFallSpeed)
            {
                meuAnim.SetBool("Wall", true);
                meuRB.velocity = new Vector2(meuRB.velocity.x, maxFallSpeed);
            }
        }else
        {
            meuAnim.SetBool("Wall", false);
        }
    }



    public void Win()
    {
        if(qtdFrutas <= 0)
        {
            win = true;
            Debug.Log("Você venceu");
            //winPainel.GetComponent<Animator>().Play("WinAparece");
            winPainel.GetComponent<Animator>().SetBool("WIN", true);
            
        }
    }

    

    private bool IsGrounded()
    {
        bool chao = Physics2D.Raycast(boxCol.bounds.center, Vector2.down, 0.5f, level);


        return true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Fruta") && Morte == false)
        {
            qtdFrutas--;
        }

        if(collision.gameObject.CompareTag("Morte") && win == false)
        {
            AudioManager.instance.SonsFXToca(7);
            Debug.Log("Você Perdeu");
            Destroy(this.gameObject);
            Instantiate(kill, transform.position, transform.rotation);
            Morte = true;
        }

        if (collision.gameObject.CompareTag("MorteLamina") && win == false)
        {
            AudioManager.instance.SonsFXToca(7);
            Debug.Log("Você Perdeu");
            
            Destroy(this.gameObject);
            Instantiate(kill, transform.position, transform.rotation);
            Morte = true;
        }

        if (collision.gameObject.CompareTag("MorteArmadilha") && win == false)
        {
            AudioManager.instance.SonsFXToca(7);
            Debug.Log("Você Perdeu");
            Destroy(this.gameObject);
            Instantiate(kill, transform.position, transform.rotation);
            Morte = true;
        }

        if(collision.gameObject.CompareTag("MorteLava") && win == false)
        {
            AudioManager.instance.SonsFXToca(13);
            qtdPulo = 0;
            
        }

        if (collision.gameObject.CompareTag("MorteAgua") && win == false)
        {
            AudioManager.instance.SonsFXToca(12);
            qtdPulo = 0;
        }



    }

    private void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.CompareTag("Piso"))
        {
            qtdPulo = qtdTotalPulo;
            meuAnim.SetBool("Chao", true);
            meuAnim.SetBool("Caindo", true);

        }

        if (collision.gameObject.CompareTag("PisoR"))
        {                
           SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (collision.gameObject.CompareTag("Plataforma"))
        {
            piso = true;
            qtdPulo = qtdTotalPulo;
           
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;

        Gizmos.DrawWireSphere(transform.position + new Vector3(wallOffset.x, wallOffset.y), wallRadius);
        Gizmos.DrawWireSphere(transform.position + new Vector3(-wallOffset.x, wallOffset.y), wallRadius);


    }

    private void OnCollisionExit2D(Collision2D collision)
    {




        if (collision.gameObject.CompareTag("Piso") )
        {
            meuAnim.SetBool("Caindo", false);
            meuAnim.SetBool("Chao", false);
        }

    }
}
