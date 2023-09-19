using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class collisionScript : MonoBehaviour
{
    /* Start is called before the first frame update
    void Start()
    {
        
    }

    //Update is called once per frame 
    void Update()
    {
        
    } */
    bool flag = true;
    
    void OnCollisionEnter(Collision thing)
    {
        Debug.Log("Destroyed by : " + thing.collider.gameObject.name);
        Destroy(this.gameObject);

        if (thing.collider.gameObject.name == "BPlayer")
            CollectCards.Printt('B');
        else if (thing.collider.gameObject.name == "RPlayer")
            CollectCards.Printt('R');


    }

};
