using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class person : MonoBehaviour
{
    public GameObject obt;
    public GameObject Panel;
    public GameObject ThePlayer;
    public GameObject TheCamera;
    public AudioSource ButtonAudioSource = null;
    public GameObject ActionDisplay;
    float distance;

    void OnMouseOver()
    {
        distance = Vector3.Distance(ThePlayer.transform.position, this.transform.position);
        if (distance <= 3f)
        {
            ActionDisplay.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E)){
                obt.SetActive(true);
                Panel.SetActive(true);
                ButtonAudioSource.Play();
            }
        }
    }

     void OnMouseExit()
    {
        ActionDisplay.SetActive(false);
        ButtonAudioSource.Stop();
        obt.SetActive(false);
        Panel.SetActive(false);
    }
}
