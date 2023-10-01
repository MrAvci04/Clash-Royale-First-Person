using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sword : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    bool flag = true;
    // Update is called once per frame
    void Update()   
    {
        if (this.gameObject.tag == "red")
        {
            if (Input.GetKeyDown(KeyCode.O))
            {
                Debug.Log("you are : +" + this.gameObject.tag + " player");
                if (flag)
                {
                    transform.Rotate(Vector3.down * 37);
                    transform.Rotate(Vector3.right * 35);
                    flag = !flag;
                }

                else
                {
                    transform.Rotate(Vector3.up * 35);
                    transform.Rotate(Vector3.left * 37);
                    flag = !flag;
                }
            }
        }
        if (this.gameObject.tag == "blue")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("you are : +" + this.gameObject.tag + " player");
                if (flag)
                {
                    transform.Rotate(Vector3.down * 32);
                    transform.Rotate(Vector3.right * 35);
                    flag = !flag;
                }

                else
                {
                    transform.Rotate(Vector3.up * 35);
                    transform.Rotate(Vector3.left * 32);
                    flag = !flag;
                }
            }
        }

    }
}
