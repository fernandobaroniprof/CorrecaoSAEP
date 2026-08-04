using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    // Função para o botão Iniciar
    public void IniciarJogo()
    {
        SceneManager.LoadScene("Fase1");
    }
    // Função para o botão Sair 
    public void SairDoJogo()
    {
        Application.Quit();
        Debug.Log("Saiu do jogo");
    }
}

