using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI; 
using UnityStandardAssets.Characters.FirstPerson;

public class t1 : MonoBehaviour
{
    public GameObject player;
    public GameObject obt;
    public GameObject obt2;
    public GameObject Panel;
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
        yield return new WaitForSeconds(5);
        Destroy(obt);
        
        obt2.SetActive(true);
        StartCoroutine("Ws2");
        
        //Destroy(gameObject);
        //player.GetComponent<FirstPersonController>().enabled=true;
    }
    IEnumerator Ws2(){
        yield return new WaitForSeconds(5);
        Destroy(obt2);
        Destroy(gameObject);
        Panel.SetActive(false);
        player.GetComponent<FirstPersonController>().enabled=true;
    }
  /*  void OnTriggerExit()
    {
        obt.SetActive(false);
    }*/
}
