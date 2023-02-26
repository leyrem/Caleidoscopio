using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class PressButtonDialogue : MonoBehaviour
{

    public NPCConversation Conversation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player" || other.tag == "Box") {
            ConversationManager.Instance.StartConversation(Conversation);
        } 
    }

}
