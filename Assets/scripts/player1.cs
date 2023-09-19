using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player1Mov : MonoBehaviour
{
    //float speed = 0.00000000000000000004F;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.S))
            transform.position = (transform.position + new Vector3(-0.018F, 0, 0));

        if (Input.GetKey(KeyCode.W))
            transform.position = (transform.position + new Vector3(0.018F, 0, 0));

        if (Input.GetKey(KeyCode.D))
            transform.position = (transform.position + new Vector3(0, 0, -0.018F));

        if (Input.GetKey(KeyCode.A))
            transform.position = (transform.position + new Vector3(0, 0, 0.018F));

    }
}
