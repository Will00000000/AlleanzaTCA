using UnityEngine;
using UnityEngine.SceneManagement;

public class ControleCena : MonoBehaviour
{
    public void SceneBeach()
    {
        SceneManager.LoadScene("Praia");
    }

    public void SceneMinigame()
    {
        SceneManager.LoadScene("Minigame");
    }

    public void SceneTopDraft()
    {
        SceneManager.LoadScene("TopDown");
    }

    public void InventarioAbre(GameObject inventario)
    {
        inventario.SetActive(true);
        Time.timeScale = 0;
    }

    public void inventarioFecha(GameObject inventario)
    {
        inventario.SetActive(false);
        Time.timeScale = 0;
    }
}