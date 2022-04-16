using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Etage1 : MonoBehaviour
{
    public GameObject message;
    
    void OnTriggerEnter()
    {
        message.SetActive(true);
    }
void OnTriggerExit()
    {
    message.SetActive(false);
    }
}
