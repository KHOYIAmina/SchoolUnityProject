using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI; 
using UnityStandardAssets.Characters.FirstPerson;

public class ENTREPRISEGLD : MonoBehaviour
{
   public GameObject ActionDisplay;
    // public GameObject subText;
    public AudioSource ButtonAudioSource = null;
    public AudioSource ButtonAudioSource1 = null;
    public AudioSource ButtonAudioSource2 = null;
  //  public AudioSource Audiodawdaa = null;
    

  
    void OnMouseOver()
    {
        
            ActionDisplay.SetActive(true);
        if (Input.GetKeyDown(KeyCode.F))
        {
            
            ButtonAudioSource.Stop();
            ButtonAudioSource1.Stop();
            ButtonAudioSource2.Stop();
           // Audiodawdaa.Play();
        }else if (Input.GetKeyDown(KeyCode.T))
        {
                ButtonAudioSource.PlayDelayed(0.2f);
                ButtonAudioSource1.PlayDelayed(24f);
                ButtonAudioSource2.PlayDelayed(86f);
        
        }
         
          
    }

    
    void OnMouseExit()
    {
         ActionDisplay.SetActive(false);
    }
}
