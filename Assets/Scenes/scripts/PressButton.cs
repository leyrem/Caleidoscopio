using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressButton : MonoBehaviour
{

    public GameObject door;

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
            door.SetActive(false);
        } 
    }

    private void OnTriggerExit2D(Collider2D other) {
        if(other.tag == "Player" || other.tag == "Box") {
            door.SetActive(true);
        } 
    }
}