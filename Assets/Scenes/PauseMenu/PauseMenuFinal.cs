using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuFinal : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    void Update()
    {
        
        
        if(Input.GetKeyDown(KeyCode.Escape)){
          if (GameIsPaused)
        {
            Resume();
        }else
        {
            Pause();
        }  
        }
        if(Input.GetKeyDown(KeyCode.Q)){
            if (GameIsPaused)
        {
            QuitGame();
        }
        }
        if(Input.GetKeyDown(KeyCode.M)){
            if (GameIsPaused)
        {
            Menu();
        }
        }
        
    }
    
    public void Resume(){
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    void Pause(){
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    
    public void QuitGame(){
        Debug.Log("quitter!");
        Application.Quit();
    }
    public void Menu(){
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
        
    }
}
