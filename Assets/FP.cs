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
    // Start is called before the first frame update
    void Start()
    { 
        ActionDisplay.SetActive(false);
        ThePlayer.GetComponent<Animator>().enabled = false;
        TheCamera.GetComponent<Animator>().enabled = false;
    }

   
    void OnMouseOver()
    {
        ActionDisplay.SetActive(true);
        if (Input.GetKeyDown(KeyCode.F))
        {
        ThePlayer.GetComponent<Animator>().enabled = true;
        TheCamera.GetComponent<Animator>().enabled = true;
        ThePlayer.GetComponent<Animator>().Play("FPS2");
        TheCamera.GetComponent<Animator>().Play("cfps2");
        }
        ActionDisplay.SetActive(false);
    }
    void OnMouseExit()
    {
         Cursor.visible = true;
    }
}
