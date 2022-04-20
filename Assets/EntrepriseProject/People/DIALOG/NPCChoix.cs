using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI; 
using UnityStandardAssets.Characters.FirstPerson;

public class NPCChoix : MonoBehaviour
{
    public float TheDistance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject ExtraCursor;
    public GameObject subText;
    public GameObject subBox;
     public GameObject ThePlayer;
    public GameObject choButton1;
    public GameObject choButton2;
    public AudioSource[] voiceLine;
    public static bool i=false;

    void Update()
    {
        TheDistance = playerCasting.DistanceFromTarget;
    }
    void OnMouseOver()
    {
        if (TheDistance <= 3)
        {
            ActionDisplay.SetActive(true);
            ActionText.GetComponent<Text>().text = "Parler";
            ActionText.SetActive(true);
            ExtraCursor.SetActive(true);
        }
        else
        {
            ActionDisplay.SetActive(false);
            ActionText.SetActive(false);
            ExtraCursor.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (TheDistance <= 3)
            {
                ThePlayer.GetComponent<FirstPersonController>().enabled = false;
                 this.transform.LookAt(new Vector3(ThePlayer.transform.position.x,this.transform.position.y, ThePlayer.transform.position.z));
                 this.GetComponent<Animator>().Play("Sitting Talking");
                subBox.SetActive(true);
                voiceLine[0].Play();
                subText.GetComponent<Text>().text = "Bonjour et bienvenue dans notre entreprise .";
                this.GetComponent<CapsuleCollider>().enabled = false;
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                ExtraCursor.SetActive(false);
                StartCoroutine(StartSelectConvo());
            }

        }

    }
    void OnMouseExit()
    {
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
        ExtraCursor.SetActive(false);
    }
    IEnumerator StartSelectConvo()
    {

        yield return new WaitForSeconds(3f);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        voiceLine[1].Play();
        subText.GetComponent<Text>().text = "Est-ce que vous êtes ici pour un stage?          A-oui    B-Non";
        choButton1.SetActive(true);
        choButton2.SetActive(true);

    }
    public void AOption(){
        StartCoroutine(StartYes());

    }
    IEnumerator StartYes(){

        choButton1.SetActive(false);
        choButton2.SetActive(false);
        voiceLine[2].Play();
        i=true;
        subText.GetComponent<Text>().text = "Donc il faut aller au département de ressources humaines pour confirmer vous données";
        yield return new WaitForSeconds(4.5f);
        subBox.SetActive(false);
        this.GetComponent<CapsuleCollider>().enabled = true;
        subText.GetComponent<Text>().text = "";
         this.GetComponent<Animator>().Play("Sitting Idle");
         Cursor.lockState = CursorLockMode.Locked;
         ThePlayer.GetComponent<FirstPersonController>().enabled = true;
         
    }

    public void BOption(){
        Cursor.visible = false;
        choButton1.SetActive(false);
        choButton2.SetActive(false);
        subBox.SetActive(false);
        
        this.GetComponent<CapsuleCollider>().enabled = true;
        subText.GetComponent<Text>().text = "";
         this.GetComponent<Animator>().Play("Sitting Idle");
         Cursor.lockState = CursorLockMode.Locked;
         ThePlayer.GetComponent<FirstPersonController>().enabled = true;
    }

}
