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
  public AudioSource Audiodawdaa = null;
  float distance;
    public GameObject player;

  
    void OnMouseOver()
    {
        distance = Vector3.Distance(player.transform.position, this.transform.position);
        if(distance <= 3f)
        {
            ActionDisplay.SetActive(true);
        if (Input.GetKeyDown(KeyCode.F))
        {
            
            ButtonAudioSource.Stop();
            Audiodawdaa.Play();
        }else if (Input.GetKeyDown(KeyCode.T))
        {
                ButtonAudioSource.PlayDelayed(0.2f);
        Audiodawdaa.Stop();
        }
         
        }
    }

    
    void OnMouseExit()
    {
         ActionDisplay.SetActive(false);
    }
}
