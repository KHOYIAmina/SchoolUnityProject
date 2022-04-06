using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI; 
using UnityStandardAssets.Characters.FirstPerson;

public class profFe : MonoBehaviour
{
    public GameObject subText;
    // public GameObject ThePlayer;
    bool j;
    void Update()
    {
         j=fps.i;
        
    }
    public void cours(){
         if (j)
        {
                // this.transform.LookAt(new Vector3(ThePlayer.transform.position.x,this.transform.position.y, ThePlayer.transform.position.z));
                this.GetComponent<Animator>().Play("Idle");
                
                subText.GetComponent<Text>().text = "Bonjour tous le monde, aujourd'hui est votre premier cour de cette année.";
                StartCoroutine(StartSelectConvo());
                
        }
    }
    IEnumerator StartSelectConvo()
    {
        yield return new WaitForSeconds(4.9f);
        
        subText.GetComponent<Text>().text = "Vous voulez continuer?";
       
    }
}
