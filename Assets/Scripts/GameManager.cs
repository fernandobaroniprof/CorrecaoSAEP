using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int vida = 4;
    public int vidaMaxima = 6;

    public void Dano()
    {
        vida--;
        if (vida == 0) Derrota();        
    }
    public void Derrota()
    {
        Debug.Log("Derrota");
    }
    public void cura()
    {
        if (vida<6) vida++;
    }
    public void CaiuNoBuraco()
    {
        vida = 0;
        Derrota();
    }
}
