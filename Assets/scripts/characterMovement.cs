using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterMovement : MonoBehaviour
{
    // Start is called before the first frame update
    CharacterController Controller;

    void Start()
    {
        Controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Controller.Move(new Vector3(vertical, 0,-horizontal) * Time.deltaTime*10);
    }

    //  I have changed this script , look at BPlayer and RPlayer (or player 1 nad player 2)
    // The Movement code in the update() method
  
}
