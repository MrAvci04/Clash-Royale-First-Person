using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skiliton : MonoBehaviour
{
    // Start is called before the first frame update

   // float speed = 0.00000000000000000004F;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.K))
            transform.position =  (transform.position + new Vector3(0.018F, 0, 0));

        if (Input.GetKey(KeyCode.I))
            transform.position = (transform.position + new Vector3(-0.018F, 0, 0));

        if (Input.GetKey(KeyCode.L))
            transform.position = (transform.position + new Vector3(0,0, 0.018F));

        if (Input.GetKey(KeyCode.J))
            transform.position = (transform.position + new Vector3(0,0,-0.018F));

    }
}
