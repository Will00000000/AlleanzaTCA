using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
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


    public void Resume(GameObject pauseMenu)
    {
        pauseMenu.SetActive(false); 
        Time.timeScale = 1;        
    }
}