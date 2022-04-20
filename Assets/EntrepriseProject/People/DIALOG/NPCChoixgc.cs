using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI; 
using UnityStandardAssets.Characters.FirstPerson;

public class NPCChoixgc : MonoBehaviour
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
                //  this.GetComponent<Animator>().Play("Sitting Talking");
                subBox.SetActive(true);
                voiceLine[0].Play();
                subText.GetComponent<Text>().text = "Bonjour ,Ils m'ont dit que vous êtes ici pour un stage.";
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
        subText.GetComponent<Text>().text = " Est-ce que vous avez ramenez les documents qui prouve que vous êtes un étudiant?           A-oui    B-Non";
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
        subText.GetComponent<Text>().text = "Parfait , Votre encadrant est monsieur X , vous pouvez le trouvez dans le bureau d'étude en premier étage.";
        yield return new WaitForSeconds(5.5f);
        subBox.SetActive(false);
        this.GetComponent<CapsuleCollider>().enabled = true;
        subText.GetComponent<Text>().text = "";
        //  this.GetComponent<Animator>().Play("Sitting Idle");
         Cursor.lockState = CursorLockMode.Locked;
         ThePlayer.GetComponent<FirstPersonController>().enabled = true;
         
        i=true;
    }

    public void BOption(){
        Cursor.visible = false;
        choButton1.SetActive(false);
        choButton2.SetActive(false);
         StartCoroutine(setfaux());
        voiceLine[3].Play();
        this.GetComponent<CapsuleCollider>().enabled = true;
        subText.GetComponent<Text>().text = "Bon , il faut les raméner pour que vous puisse passer le stage chez nous";
        //  this.GetComponent<Animator>().Play("Sitting Idle");
         Cursor.lockState = CursorLockMode.Locked;
         ThePlayer.GetComponent<FirstPersonController>().enabled = true;
    }
    IEnumerator setfaux(){
        yield return new WaitForSeconds(5f);
        subBox.SetActive(false);
        subText.GetComponent<Text>().text = "";
    }

}
