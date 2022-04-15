using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MainMenu : MonoBehaviour
{
    //public AudioMixer audioMixer;
   /* */void Update(){
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

    }
    public void PlayGamegl(){
        SceneManager.LoadScene("GLEcole");
    }
    public void PlayGamegc(){
        SceneManager.LoadScene("GCEcole");
    }
    public void PlayGamegcapresEc(){
        Time.timeScale = 1f;
        SceneManager.LoadScene("ApresGCEcole");
    }
    public void PlayGameglapresEc(){
        Time.timeScale = 1f;
        SceneManager.LoadScene("ApresGLEcole");
    }
    public void PlayGamegcStage(){
        SceneManager.LoadScene("GCStage");
    }
    public void PlayGameglStage(){
        SceneManager.LoadScene("GLStage");
    }
    public void PlayGamegcApresStage(){
        Time.timeScale = 1f;
        SceneManager.LoadScene("ApresGCStage");
    }
    public void PlayGameglApresStage(){
        Time.timeScale = 1f;
        SceneManager.LoadScene("ApresGLStage");
    }
    public void PlayGamegcEntr(){
        SceneManager.LoadScene("GCEntr");
    }
    public void PlayGameglEntr(){
        SceneManager.LoadScene("GLEntr");
    }
    public void PlayGamegcApresEntr(){
        Time.timeScale = 1f;
        SceneManager.LoadScene("ApresGCEntr");
    }
    public void PlayGameglApresEntr(){
        Time.timeScale = 1f;
        SceneManager.LoadScene("ApresGLEntr");
    }
    public void QuitGame(){
        Debug.Log("quitter!");
        Application.Quit();
    }
    /*public void SetVolume (float volume)
    {
        audioMixer.SetFloat("volume",volume);
    }*/

}
