using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressButton : MonoBehaviour
{

    public GameObject door;
    public GameObject laserWall;
    private bool playerPressing;
    private bool boxPressing;

    // Start is called before the first frame update
    void Start()
    {
        playerPressing = false;
        boxPressing = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerPressing || boxPressing) {
            door.SetActive(false);
            if (laserWall) laserWall.SetActive(false);
        } else {
            door.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player") {
            playerPressing = true;
        } else if (other.tag == "Box") {
            boxPressing = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        if(other.tag == "Player") {
            playerPressing = false;
        } else if (other.tag == "Box") {
            boxPressing = false;
        }
    }
}
