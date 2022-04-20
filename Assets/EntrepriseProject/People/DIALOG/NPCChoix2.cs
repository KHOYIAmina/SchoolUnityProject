using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI; 
using UnityStandardAssets.Characters.FirstPerson;

public class NPCChoix2 : MonoBehaviour
{
    public float TheDistance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject ExtraCursor;
    public GameObject subText;
    public GameObject subBox;
     public GameObject NPC;
     public GameObject ThePlayer;
     public GameObject TheCamera;
    public GameObject choButton1;
    public GameObject choButton2;
    public AudioSource[] voiceLine;
    bool j;

    void Update()
    {
        TheDistance = playerCasting.DistanceFromTarget;
        j=assit.i;
    }
    void OnMouseOver()
    {
        if (j)
        {
            ActionDisplay.SetActive(true);
            ActionText.GetComponent<Text>().text = " E pour Parler et F pour se mettre debout";
            ActionText.SetActive(true);
            ExtraCursor.SetActive(true);
        }
        
        if (Input.GetKeyDown(KeyCode.E))
        {
            
                //ThePlayer.GetComponent<FirstPersonController>().enabled = false;
                //  this.transform.LookAt(new Vector3(ThePlayer.transform.position.x,this.transform.position.y, ThePlayer.transform.position.z));
                //  this.GetComponent<Animator>().Play("Sitting Talking");
                subBox.SetActive(true);
                voiceLine[0].Play();
                subText.GetComponent<Text>().text = "Bonjour soyez les bien venu chez nous, je serais votre encadrant pendant cette expérience professionnelle, j'éspère que nous puissions fournir un bon travail qui nous sera utile tous.";
                NPC.GetComponent<CapsuleCollider>().enabled = false;
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                ExtraCursor.SetActive(false);
                StartCoroutine(StartSelectConvo());
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            ThePlayer.GetComponent<Animator>().enabled = true;
            TheCamera.GetComponent<Animator>().enabled = true;
            ThePlayer.GetComponent<Animator>().Play("debout");
            TheCamera.GetComponent<Animator>().Play("cdebout"); 
            
            StartCoroutine("Ws");
        }

    }
    IEnumerator Ws(){
        yield return new WaitForSeconds(0.1f);
        ThePlayer.GetComponent<Animator>().enabled = false;
         TheCamera.GetComponent<Animator>().enabled = false;
    }
    void OnMouseExit()
    {
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
        ExtraCursor.SetActive(false);
    }
    IEnumerator StartSelectConvo()
    {
        yield return new WaitForSeconds(9f);
        voiceLine[1].Play();
        subText.GetComponent<Text>().text = " En ce qui concerne le mode de travail vous serez parmi l'équipe du développement informatique c'est là où vous serez capable d'accumuler un maximum de connaissances dans votre domaine. On peut commencer premièrement tester vos connaissances avec quelque exercices et puis décider le genre de travail qui vous sera affecté.";
         StartCoroutine(continueConvo());
        
    }
    IEnumerator continueConvo()
    {
        yield return new WaitForSeconds(16f);
        ThePlayer.GetComponent<FirstPersonController>().enabled = false;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        voiceLine[2].Play();
        subText.GetComponent<Text>().text = " Voici les membres de notre équipe vous serez en contact direct avec eux n'hésitez pas de demander de l'aide en cas de problème.";
        choButton1.SetActive(true);
        choButton2.SetActive(true);
        
    }
    public void AOption(){
        StartCoroutine(StartYes());

    }
    IEnumerator StartYes(){
        choButton1.SetActive(false);
        choButton2.SetActive(false);
        voiceLine[3].Play();
        subText.GetComponent<Text>().text = "En terme simple vous êtes  ici pour appliquer vos connaissances déjà acquises à l'école en faisant des projets et  même apprendre de nouvelles choses ici avec la pratique. L'autoformation est toujours nécessaire ne la négligez jamais.";
        yield return new WaitForSeconds(11f);
        subBox.SetActive(false);
        NPC.GetComponent<CapsuleCollider>().enabled = true;
        subText.GetComponent<Text>().text = "";
        //  this.GetComponent<Animator>().Play("Sitting Idle");
         Cursor.lockState = CursorLockMode.Locked;
          ThePlayer.GetComponent<FirstPersonController>().enabled = true;
    }

    public void BOption(){
        StartCoroutine(setfaux());
        }
    IEnumerator setfaux(){
        Cursor.visible = false;
        choButton1.SetActive(false);
        choButton2.SetActive(false);
        voiceLine[4].Play();
        subText.GetComponent<Text>().text = "Bon courage";
        yield return new WaitForSeconds(2f);
        //  this.GetComponent<Animator>().Play("Sitting Idle");
         //Cursor.lockState = CursorLockMode.Locked;
        subBox.SetActive(false);
        NPC.GetComponent<CapsuleCollider>().enabled = true;
        subText.GetComponent<Text>().text = "";
        //  this.GetComponent<Animator>().Play("Sitting Idle");
         Cursor.lockState = CursorLockMode.Locked;
          ThePlayer.GetComponent<FirstPersonController>().enabled = true;
    }

}
