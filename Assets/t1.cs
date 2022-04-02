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
    // Start is called before the first frame update
    void Start()
    {
        obt.SetActive(false);
    }

    // Update is called once per frame
    void OnTriggerEnter()
    { 
        player.GetComponent<FirstPersonController>().enabled=false;
        obt.SetActive(true);
        StartCoroutine("Ws");
    }
    IEnumerator Ws(){
        yield return new WaitForSeconds(5);
        Destroy(obt);
        Destroy(gameObject);
        player.GetComponent<FirstPersonController>().enabled=true;
    }
  /*  void OnTriggerExit()
    {
        obt.SetActive(false);
    }*/
}
