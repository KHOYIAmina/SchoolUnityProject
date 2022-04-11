using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI; 
using UnityStandardAssets.Characters.FirstPerson;

public class FP : MonoBehaviour
{
    // Start is called before the first frame update
   public GameObject ActionDisplay;
    public GameObject ThePlayer;
    public GameObject TheCamera;
    public GameObject ppt ;
    // public GameObject subText;
    public GameObject TheNPC;
    public AudioSource ButtonAudioSource = null;
    public AudioSource ButtonAudioSource1 = null;
    public AudioSource ButtonAudioSource2 = null;
    public AudioSource Audio = null;
     public float Button = 0;
    bool j; 
    // Start is called before the first frame update
   /* void Start()
    { 
        ThePlayer.GetComponent<Animator>().enabled = true;
        TheCamera.GetComponent<Animator>().enabled = true;
    }*/

   void Update()
    {
        j=fps.i;
        
    }
    void OnMouseOver()
    {
        if (j)
        {
            ActionDisplay.SetActive(true);

        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            ThePlayer.GetComponent<Animator>().enabled = true;
            TheCamera.GetComponent<Animator>().enabled = true;
            ThePlayer.GetComponent<Animator>().Play("FPS2");
            TheCamera.GetComponent<Animator>().Play("cfps2"); 
            ButtonAudioSource.Stop();
            ButtonAudioSource1.Stop();
            ButtonAudioSource2.Stop();
            Audio.Play();
            ppt.GetComponent<MeshRenderer>().enabled = false;
            StartCoroutine("Ws");
        }else if (Input.GetKeyDown(KeyCode.T))
        {
            
                TheNPC.GetComponent<Animator>().Play("Idle");
                if (j)
        {
                ButtonAudioSource.PlayDelayed(Button);
                ButtonAudioSource1.PlayDelayed(80f);
                ButtonAudioSource2.PlayDelayed(86f);
        }
                // subText.GetComponent<Text>().text = "Bonjour tous le monde, aujourd'hui est votre premier cour de cette année.";
                // StartCoroutine(StartSelectConvo());
        }
         
          
    }


    /*IEnumerator StartSelectConvo()
    {
        yield return new WaitForSeconds(4.9f);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        subText.GetComponent<Text>().text = "Vous voulez continuer?";
       
    }*/
    IEnumerator Ws(){
        yield return new WaitForSeconds(0.1f);
        ThePlayer.GetComponent<Animator>().enabled = false;
        TheCamera.GetComponent<Animator>().enabled = false;
    }
    void OnMouseExit()
    {
         ActionDisplay.SetActive(false);
    }
}
