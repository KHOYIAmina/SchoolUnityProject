using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fps : MonoBehaviour
{
    public GameObject ThePlayer;
    // Start is called before the first frame update
    void Start()
    {
        ThePlayer.GetComponent<Animator>().enabled = false;
    }

    // Update is called once per frame
    void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            ThePlayer.GetComponent<Animator>().Play("FPS1");
        }
    }
}
