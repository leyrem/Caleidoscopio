using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementEnd : MonoBehaviour
{
    [SerializeField] private float speed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello world!");
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < 72){
            Vector3 movement = new Vector3(0.5f, 0.0f, 0.0f).normalized;
            transform.position = transform.position + movement * Time.deltaTime * speed;
        } else {

        }
        // float h = Input.GetAxisRaw("Horizontal");
        // float v = Input.GetAxisRaw("Vertical");

        // body.velocity = new Vector2(h * speed, v * speed);

    }
}
