using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI; 
using UnityStandardAssets.Characters.FirstPerson;

public class NPCChat : MonoBehaviour
{
    public float TheDistance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject ExtraCursor;
    public GameObject subText;
    public GameObject subBox;
     public GameObject ThePlayer;

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
                subText.GetComponent<Text>().text = "Bonjour tous le monde, aujourd'hui est votre premier cour de cette année.";
                this.GetComponent<CapsuleCollider>().enabled = false;
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                ExtraCursor.SetActive(false);
                StartCoroutine(ResetChat());
            }

        }

    }
    void OnMouseExit()
    {
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
        ExtraCursor.SetActive(false);
    }
    IEnumerator ResetChat()
    {
        yield return new WaitForSeconds(2.5f);
        subBox.SetActive(false);
        this.GetComponent<CapsuleCollider>().enabled = true;
        subText.GetComponent<Text>().text = "";
         this.GetComponent<Animator>().Play("Sitting Idle");
          ThePlayer.GetComponent<FirstPersonController>().enabled = true;
    
    }

}
