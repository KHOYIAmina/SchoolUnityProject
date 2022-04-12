using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI; 
using UnityStandardAssets.Characters.FirstPerson;

public class Ecole : MonoBehaviour
{
    public GameObject player;
    public GameObject obt;
    public GameObject obt2;
    public GameObject Panel;
    public GameObject choButton1;
    public GameObject choButton2;
    public AudioSource ButtonAudioSource = null;
    public float Button = 0;
    // Start is called before the first frame update
    void Start()
    {
        obt.SetActive(false);
        obt2.SetActive(false);
        Panel.SetActive(false);
    }

    // Update is called once per frame
    void OnTriggerEnter()
    { 
        player.GetComponent<FirstPersonController>().enabled=false;
        Panel.SetActive(true);
        obt.SetActive(true);
        StartCoroutine("Ws");
        
    }
    IEnumerator Ws(){
        yield return new WaitForSeconds(1);
        choButton1.SetActive(true);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        

        //Destroy(gameObject);
        //player.GetComponent<FirstPersonController>().enabled=true;
    }
    public void next1(){
        choButton1.SetActive(false);
        choButton2.SetActive(true);
        Destroy(obt);
        ButtonAudioSource.PlayDelayed(Button);
        obt2.SetActive(true);
        
    }
    public void next2(){
         Destroy(obt2);
        Destroy(gameObject);
        ButtonAudioSource.PlayDelayed(Button);
        Panel.SetActive(false);
        player.GetComponent<FirstPersonController>().enabled=true;
        Cursor.lockState = CursorLockMode.Locked;
    }

  
}
