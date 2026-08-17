using UnityEngine;
using UnityEngine.SceneManagement;

public class TelaInicial : MonoBehaviour
{
    public void VoltarMenu()
    {
        GameManager gameManager = FindFirstObjectByType<GameManager>();
        if (gameManager != null) Destroy(gameManager.gameObject);
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
    }
}
