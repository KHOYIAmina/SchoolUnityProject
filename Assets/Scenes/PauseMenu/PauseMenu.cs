using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public static bool InstrMIsalse = true;
    public GameObject pauseMenuUI;
    public GameObject InstrMenu;
    public AudioSource Audiodawdaa = null;
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
        if(Input.GetKeyDown(KeyCode.I)){
            if (InstrMIsalse)
        {
             instrf();
        }else
        {
            instrt();
        } 
                }

    }
    public void Resume(){
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        Audiodawdaa.Play();
    }
    void Pause(){
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        AudioSource[] audios = FindObjectsOfType<AudioSource>();
        foreach (AudioSource a in audios)
        {
            a.Stop();
        }
        
    }
    
    public void QuitGame(){
        Debug.Log("quitter!");
        Application.Quit();
    }
    public void Menu(){
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
        
    }
    public void Next(){
        Time.timeScale = 1f;
        SceneManager.LoadScene("ApresGCStage");
        
    }
    public void NextApresGLStag(){
        Time.timeScale = 1f;
        SceneManager.LoadScene("ApresGLStage");
        
    }
    public void NextApresGCEntr(){
        Time.timeScale = 1f;
        SceneManager.LoadScene("ApresGCEntr");
        
    }
    
    public void Instrf(){
        InstrMenu.SetActive(false);
        InstrMIsalse = false;
    }
    public void Instrt(){
        InstrMenu.SetActive(true);
        InstrMIsalse = true;
    }
    public void instrf(){
        InstrMenu.SetActive(false);
        InstrMIsalse = false;
    }
    public void instrt(){
        InstrMenu.SetActive(true);
        InstrMIsalse = true;
    }
}
