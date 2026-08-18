using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    public GameManager gameManager;
    public AudioClip somDano;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(somDano, transform.position);
            gameManager.Dano();
        }
    }
}
