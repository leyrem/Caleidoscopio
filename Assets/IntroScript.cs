using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;
using UnityEngine.SceneManagement;

public class IntroScript : MonoBehaviour
{

    private bool isFirst;
    // Start is called before the first frame update
    void Start()
    {
        isFirst = true;
        ConversationManager.OnConversationEnded += ConversationEnd;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void ConversationEnd()
    {
        if(isFirst) {
            SceneManager.LoadScene(sceneName: "Sala1");
            isFirst = false;
        }

        
    }

}
