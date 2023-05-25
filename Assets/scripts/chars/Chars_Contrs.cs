using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chars_Contrs : MonoBehaviour
{
    private DefaultInput defaultInput;
    public Vector2 input_Movement;
    public Vector2 input_Views;

    private void Awake()
    {
        defaultInput = new DefaultInput();
        defaultInput.Characters.Movement.performed += e => input_Movement = e.ReadValue<Vector2>();
        defaultInput.Characters.View.performed += e => input_Views = e.ReadValue<Vector2>();

        defaultInput.Enable();
    }
}
