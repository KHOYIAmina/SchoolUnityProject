using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI; 
using UnityStandardAssets.Characters.FirstPerson;

public class NPCChoix3 : MonoBehaviour
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
                subText.GetComponent<Text>().text = "Bonjour soyez les bien venu chez nous, je suis votre encadrent professionnelle pendant la période de votre stage.";
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
        subText.GetComponent<Text>().text = " donc il faut pratiquer vos connaissances qui vous avez pris pendant votre première année. donc on va travailler par des logiciels et des nouvelles technologies pour découvrir le mode professionnelle. on va travailler par le logiciel AUTOCAD. c'est un logiciel de conception assistée par ordinateur  qui permet de réaliser des dessins, des conceptions et des modélisations 2D et 3D. je vous laisse de faire une autoformation. On peut commencer premièrement tester vos connaissances avec quelque exercices. et après on va choisi un sujet pour un projet pour montrer vos connaissances.";
         StartCoroutine(continueConvo());
        
    }
    IEnumerator continueConvo()
    {
        yield return new WaitForSeconds(34f);
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
        subText.GetComponent<Text>().text = "autrement dit on va travailler des exercices simple pour d'abord découvrir le mode professionnelle et aussi pour prendre des informations sur notre société. après on va utiliser un logiciel pour travailler sur un projet.";
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
