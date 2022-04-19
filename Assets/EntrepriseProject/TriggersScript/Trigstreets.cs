using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trigstreets : MonoBehaviour
{
    public AudioSource noise;
    

    void OnTriggerEnter()
    {
        noise.Play();
    }
}
