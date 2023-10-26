using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttons : MonoBehaviour
{
    // Start is called before the first frame update

    public Image img;
    void Start()
    {
        img.color = new Color(0.65f, 0.65f, 0.65f);
    }

    // Update is called once per frame
    void Update()
    {
        if (
            Input.GetKeyDown(KeyCode.W) && this.name == "W" ||
            Input.GetKeyDown(KeyCode.S) && this.name == "S" ||
            Input.GetKeyDown(KeyCode.D) && this.name == "D" ||
            Input.GetKeyDown(KeyCode.A) && this.name == "A" ||
            Input.GetKeyDown(KeyCode.I) && this.name == "I" ||
            Input.GetKeyDown(KeyCode.K) && this.name == "K" ||
            Input.GetKeyDown(KeyCode.L) && this.name == "L" ||
            Input.GetKeyDown(KeyCode.J) && this.name == "J" ||
            Input.GetKeyDown(KeyCode.E) && this.name == "E" ||
            Input.GetKeyDown(KeyCode.Q) && this.name == "Q" ||
            Input.GetKeyDown(KeyCode.O) && this.name == "O" ||
            Input.GetKeyDown(KeyCode.U) && this.name == "U"
            )
            img.color = Color.cyan;
        
        if (
            Input.GetKeyUp(KeyCode.W) && this.name == "W" ||
            Input.GetKeyUp(KeyCode.S) && this.name == "S" ||
            Input.GetKeyUp(KeyCode.D) && this.name == "D" ||
            Input.GetKeyUp(KeyCode.A) && this.name == "A" ||
            Input.GetKeyUp(KeyCode.I) && this.name == "I" ||
            Input.GetKeyUp(KeyCode.K) && this.name == "K" ||
            Input.GetKeyUp(KeyCode.L) && this.name == "L" ||
            Input.GetKeyUp(KeyCode.J) && this.name == "J" ||
            Input.GetKeyUp(KeyCode.E) && this.name == "E" ||
            Input.GetKeyUp(KeyCode.Q) && this.name == "Q" ||
            Input.GetKeyUp(KeyCode.O) && this.name == "O" ||
            Input.GetKeyUp(KeyCode.U) && this.name == "U"
            )
            img.color = Color.red;
       // else
        //    img.color = new Color(65f, 65f, 65f);
    }
}
