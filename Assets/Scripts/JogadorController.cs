using UnityEngine;

public class JogadorController : MonoBehaviour
{
    public float velocidade = 5f;
    public float forcaPulo = 7f;
    private Rigidbody2D rb;
    private SpriteRenderer sprite;
    private bool estaNoChao;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();       
    }

    void Update()
    {
        float movimento = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = new Vector2(movimento * velocidade, rb.linearVelocity.y);
        if (movimento > 0) sprite.flipX = false;        
        if (movimento < 0) sprite.flipX = true;

        if (Input.GetKeyDown(KeyCode.Space) && estaNoChao)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, forcaPulo);
        }        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("chao")){
            estaNoChao = true;
        }
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("chao")){
            estaNoChao = false;
        }
    }
}
