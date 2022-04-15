using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI; 
using UnityStandardAssets.Characters.FirstPerson;
public class Code : MonoBehaviour
{
    public GameObject obt;
    public GameObject obt1;
    public GameObject image1;
    public GameObject image2;
    public GameObject Panel;
    public GameObject ThePlayer;
    public GameObject TheCamera;
    float distance;
    public AudioSource ButtonAudioSource = null;



    void Start()
    {
        
        obt.SetActive(false);
        obt1.SetActive(false);

        image1.SetActive(false);
        image2.SetActive(false);

        Panel.SetActive(false);  
    }

    void OnMouseOver()
    {
       distance = Vector3.Distance(ThePlayer.transform.position, this.transform.position);
        if (distance <= 3f)
        {
             ButtonAudioSource.Play();
            
            obt1.SetActive(true);
            obt.SetActive(true);
            Panel.SetActive(true); 

            image1.SetActive(true);
            image2.SetActive(true);
        }
  

    }

    void OnMouseExit()
    {
        obt1.SetActive(false);
        obt.SetActive(false);
        Panel.SetActive(false);
        image1.SetActive(false);
        image2.SetActive(false);
    }

}
