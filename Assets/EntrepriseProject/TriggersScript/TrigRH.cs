using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrigRH : MonoBehaviour
{
    public GameObject subText;
    public float TheDistance;
    bool t;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t=NPCChoix1.i;
        TheDistance = playerCasting.DistanceFromTarget;
    }
    void OnMouseOver()
    {
        if (t==false)
        {
            if (TheDistance <= 3)
        {
            subText.SetActive(true);
            subText.GetComponent<Text>().text = "Il faut parler avec le responsable RH";
        }
        }
        else if (t)
        {
            this.GetComponent<BoxCollider>().enabled = false;
        }
    
    }
    void OnMouseExit()
    {
            subText.SetActive(false);
    }
}
