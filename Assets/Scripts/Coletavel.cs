using UnityEngine;

public class Coletavel : MonoBehaviour
{
    public GameManager gameManager;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gameManager.Cura();
            GameObject.Destroy(gameObject);
        }
    }
}
