using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantarSemilla : MonoBehaviour
{

    public GameObject liana;

    // Start is called before the first frame update
    void Start()
    {
        liana.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player") {
            liana.SetActive(true);
            //this.gameObject.SetActive(false);
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        if(other.tag == "Player") {
            liana.SetActive(false);
        } 
    }
}
