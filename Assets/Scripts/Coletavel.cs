using UnityEngine;

public class Coletavel : MonoBehaviour
{
    public GameManager gameManager;
    public AudioClip somColetavel;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(somColetavel, transform.position);
            gameManager.Cura();
            GameObject.Destroy(gameObject);
        }
    }
}
