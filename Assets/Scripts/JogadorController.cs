using UnityEngine;

public class JogadorController : MonoBehaviour
{
    private Animator animator;
    public float velocidade = 5f;
    public float forcaPulo = 7f;
    private Rigidbody2D rb;
    private SpriteRenderer sprite;
    private bool estaNoChao;

    private void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();       
    }

    void Update()
    {
        float movimento = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = new Vector2(movimento * velocidade, rb.linearVelocity.y);
        if (movimento > 0) sprite.flipX = false;        
        if (movimento < 0) sprite.flipX = true;

        if (movimento > 0 || movimento < 0) animator.SetBool("andando", true);
        if (movimento == 0) animator.SetBool("andando", false);

        if (Input.GetKeyDown(KeyCode.Space) && estaNoChao)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, forcaPulo);
        }        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("chao")){
            estaNoChao = true;
            animator.SetBool("estanochao", true);
        }
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("chao")){
            estaNoChao = false;
            animator.SetBool("estanochao", false);
        }
    }
}
