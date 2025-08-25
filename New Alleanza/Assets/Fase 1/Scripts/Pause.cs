using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject PauseMenu;
    public bool isPause;
    public GameObject postProcessVolume;

    // Start is called before the first frame update
    void Start()
    {
        PauseMenu.SetActive(false);

        if (postProcessVolume != null)
            postProcessVolume.SetActive(false); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPause)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void PauseGame()
    {
        PauseMenu.SetActive(true);

        if (postProcessVolume != null)
            postProcessVolume.SetActive(true); 

        Time.timeScale = 0f;
        isPause = true;
    }

    public void ResumeGame()
    {
        PauseMenu.SetActive(false);

        if (postProcessVolume != null)
            postProcessVolume.SetActive(false); 
            
        Time.timeScale = 1f;
        isPause = false;
    }
}
