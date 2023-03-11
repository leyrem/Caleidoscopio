using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class FirstDialogue : MonoBehaviour
{

    public NPCConversation Conversation;

    // Start is called before the first frame update
    void Start()
    {
        ConversationManager.Instance.StartConversation(Conversation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
