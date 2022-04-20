using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trigstreet : MonoBehaviour
{
    public AudioSource noise;
    

    void OnTriggerEnter()
    {
        noise.Stop();
    }
}
