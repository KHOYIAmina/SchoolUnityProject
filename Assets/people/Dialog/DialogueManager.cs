﻿using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO.Pipes;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public NPC npc;

    bool isTalking = false;

    float distance;
    float curResponseTracker = 0;

    public GameObject player;
    public GameObject ActionDisplay;
    public GameObject dialogueUI;


    public Text npcName;
    public Text npcDialogueBox;
    public Text playerResponse;



    // Start is called before the first frame update
    void Start()
    {
        dialogueUI.SetActive(false);
    }

    void OnMouseOver()
    {
        distance = Vector3.Distance(player.transform.position, this.transform.position);
        if(distance <= 3f)
        {
            ActionDisplay.SetActive(true);
            if(Input.GetAxis("Mouse ScrollWheel") < 0f)
            {
                curResponseTracker++;
                if (curResponseTracker >= npc.playerDialogue.Length - 1)
                {
                    curResponseTracker = npc.playerDialogue.Length - 1;
                }
            }
            else if(Input.GetAxis("Mouse ScrollWheel") > 0f)
            {
                curResponseTracker--;
                if(curResponseTracker < 0)
                {
                    curResponseTracker = 0;
                }
            }
            //trigger dialogue
            if(Input.GetKeyDown(KeyCode.E) && isTalking==false)
            {
                StartConversation();
            }
            else if(Input.GetKeyDown(KeyCode.E) && isTalking == true)
            {
                EndDialogue();
            }

            if(curResponseTracker == 0 && npc.playerDialogue.Length >= 0)
            {
                playerResponse.text = npc.playerDialogue[0];
                if(Input.GetKeyDown(KeyCode.Return))
                {
                    npcDialogueBox.text = npc.dialogue[1];
                }
            }
            else if(curResponseTracker == 1 && npc.playerDialogue.Length >= 1)
            {
                playerResponse.text = npc.playerDialogue[1];
                if(Input.GetKeyDown(KeyCode.Return))
                {
                    npcDialogueBox.text = npc.dialogue[2];
                }
            }
            else if (curResponseTracker == 2 && npc.playerDialogue.Length >= 2)
            {
                playerResponse.text = npc.playerDialogue[2];
                if (Input.GetKeyDown(KeyCode.Return))
                {
                    npcDialogueBox.text = npc.dialogue[3];
                }
            }
            else if (curResponseTracker == 3 && npc.playerDialogue.Length >= 2)
            {
                playerResponse.text = npc.playerDialogue[3];
                if (Input.GetKeyDown(KeyCode.Return))
                {
                    npcDialogueBox.text = npc.dialogue[4];
                }
            }

            else if (curResponseTracker == 4 && npc.playerDialogue.Length >= 2)
            {
                playerResponse.text = npc.playerDialogue[4];
                if (Input.GetKeyDown(KeyCode.Return))
                {
                    npcDialogueBox.text = npc.dialogue[5];
                }
            }

        }
    }

    void StartConversation()
    {
        isTalking = true;
        curResponseTracker = 0;
        dialogueUI.SetActive(true);
        npcName.text = npc.name;
        npcDialogueBox.text = npc.dialogue[0];
    }

    void EndDialogue()
    {
        isTalking = false;
        dialogueUI.SetActive(false);
    }
    void OnMouseExit()
    {
         ActionDisplay.SetActive(false);
    }

}
