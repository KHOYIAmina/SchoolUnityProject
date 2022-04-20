using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI; 
using UnityStandardAssets.Characters.FirstPerson;
public class assit : MonoBehaviour
{
    
    public GameObject ActionDisplay;
    public GameObject ThePlayer;
    public GameObject TheCamera;
    public GameObject ActionText;
    public GameObject ExtraCursor;
    public static bool i=false;
    // public GameObject ppt;

    // public AudioSource ButtonAudioSource = null;
    // public float Button = 0;
    // Start is called before the first frame update
    void Start()
    {
        
        ThePlayer.GetComponent<Animator>().enabled = false;
        TheCamera.GetComponent<Animator>().enabled = false;
        ActionDisplay.SetActive(false);
            ActionText.SetActive(false);
            ExtraCursor.SetActive(false); 
    }

   
    void OnMouseOver()
    {
        ActionDisplay.SetActive(true);
            ActionText.GetComponent<Text>().text = "Assit";
            ActionText.SetActive(true);
            ExtraCursor.SetActive(true);
        if (Input.GetKeyDown(KeyCode.E))
        {
            i=true;
            ThePlayer.GetComponent<Animator>().enabled = true;
             TheCamera.GetComponent<Animator>().enabled = true;
            ThePlayer.GetComponent<Animator>().Play("assit");
            TheCamera.GetComponent<Animator>().Play("cassit");

            // ButtonAudioSource.PlayDelayed(Button);
            // ppt.GetComponent<MeshRenderer>().enabled = true;
            
            
        }else
        {
            i=false;
            
        }
        
    }

    
    void OnMouseExit()
    {
         ActionDisplay.SetActive(false);
            ActionText.SetActive(false);
            ExtraCursor.SetActive(false);
    }

}
