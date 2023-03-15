using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class ActivateConv : MonoBehaviour
{

    public NPCConversation Conversation;
    private bool inRange;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("space") && inRange)
        {
            ConversationManager.Instance.StartConversation(Conversation);
        }
    }

        private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player") {
            inRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        if(other.tag == "Player") {
            inRange = false;
        } 
    }
}

