using UnityEngine;
using UnityEngine.SceneManagement;

public class TelaInicial : MonoBehaviour
{
    public void VoltarMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
