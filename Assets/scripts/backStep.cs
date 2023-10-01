using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backStep : MonoBehaviour
{
    // Start is called before the first frame update
   /* void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/
    void OnCollisionEnter(Collision thing)
    {
        if (thing.collider.name == "RPlayer")
        {
            thing.gameObject.transform.position += new Vector3(0.1F, 0, 0);
            RPlayer.damage(thing.gameObject ,1);
        }
        if (thing.collider.name == "BPlayer")
        {
            thing.gameObject.transform.position += new Vector3(-0.1F, 0, 0);
            BPlayer.damage(thing.gameObject ,1);
        }
    }
}
