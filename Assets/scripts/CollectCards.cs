using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCards : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void Printt(char c)
    {
        Debug.Log(c == 'R' ? "Hello From Red Player" : "Hello From Blue Player");
    }
}
