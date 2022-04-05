using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI; 
using UnityStandardAssets.Characters.FirstPerson;
public class fps : MonoBehaviour
{
    public GameObject ActionDisplay;
    public GameObject ThePlayer;
    public GameObject TheCamera;
    // Start is called before the first frame update
    void Start()
    {
        
        ThePlayer.GetComponent<Animator>().enabled = false;
        TheCamera.GetComponent<Animator>().enabled = false;
    }

   
    void OnMouseOver()
    {
        ActionDisplay.SetActive(true);
        if (Input.GetKeyDown(KeyCode.E))
        {
            ThePlayer.GetComponent<Animator>().enabled = true;
            TheCamera.GetComponent<Animator>().enabled = true;
            ThePlayer.GetComponent<Animator>().Play("FPS");
            TheCamera.GetComponent<Animator>().Play("cfps");
            
        }
        
    }
    void OnMouseExit()
    {
         ActionDisplay.SetActive(false);
    }

}
