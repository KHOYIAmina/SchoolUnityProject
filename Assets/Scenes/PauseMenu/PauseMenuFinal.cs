using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuFinal : MonoBehaviour
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
        if(Input.GetKeyDown(KeyCode.N)){
            if (GameIsPaused)
        {
            Next();
        }
        }
        if(Input.GetKeyDown(KeyCode.I)){
            if (InstrMIsalse)
        {
             Instrf();
        }else
        {
            Instrt();
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
    public void NextApresGLEntr(){
        Time.timeScale = 1f;
        SceneManager.LoadScene("ApresGLEntr");
        
    }
    public void PlayGameglapresEc(){
        Time.timeScale = 1f;
        SceneManager.LoadScene("ApresGLEcole");
    }
    public void PlayGamegcapresEc(){
        Time.timeScale = 1f;
        SceneManager.LoadScene("ApresGCEcole");
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
        SceneManager.LoadScene("ApresGLEntr");
        
    }
    public void Instrf(){
        InstrMenu.SetActive(false);
        InstrMIsalse = false;
    }
    public void Instrt(){
        InstrMenu.SetActive(true);
        InstrMIsalse = true;
    }
    /*public void nextglecole(){
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }*/
}
