using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fps : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Animator>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            this.GetComponent<Animator>().Play("FPS1");
        }
    }
}
