using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowdirection : MonoBehaviour
{
    public GameObject arrow;

  void OnTriggerEnter()
    { 
        Destroy(arrow);
        Destroy(gameObject);
    }
}
