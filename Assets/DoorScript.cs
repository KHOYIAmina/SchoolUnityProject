using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    Animator anim;
    public AudioSource doorOpenAudioSource = null;
    public float openDeley = 0;

    public AudioSource doorCloseAudioSource = null;
    public float closeDeley = 0.8f;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        anim.SetTrigger("OpenDoor");
        doorOpenAudioSource.PlayDelayed(openDeley);
        
    }

    void OnTriggerExit(Collider other)
    {
         anim.enabled = true;
         doorCloseAudioSource.PlayDelayed(closeDeley);
    }

    void pauseAnimationEvent()
    {
        anim.enabled = false;
    }
}
