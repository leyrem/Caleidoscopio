using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantarSemilla : MonoBehaviour
{

    public GameObject liana;
    public GameObject laserWall;
    private bool inRange;

    // Start is called before the first frame update
    void Start()
    {
        liana.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(laserWall) laserWall.SetActive(!liana.activeInHierarchy);

        if (Input.GetKeyDown("space") && inRange)
        {
            liana.SetActive(!liana.activeInHierarchy);
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player") {
            // liana.SetActive(true);
            inRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        if(other.tag == "Player") {
            // liana.SetActive(false);
            inRange = false;
        } 
    }
}
