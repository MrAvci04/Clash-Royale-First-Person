using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bom;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision thing)
    {
        if (this.gameObject.tag == "red" && thing.gameObject.tag == "blue")
        {
            if(thing.gameObject.name == "BPlayer")
                BPlayer.damage(thing.gameObject, 5);
            Instantiate(bom, this.transform.position + new Vector3(-2, 0, 0), Quaternion.identity);
        }
        if (this.gameObject.tag == "blue" && thing.gameObject.tag == "red")
        {
            if (thing.gameObject.name == "RPlayer")
                RPlayer.damage(thing.gameObject, 5);
           // Instantiate(bom,thing.transform.position + new Vector3(-2,2,0),Quaternion.identity);
            Instantiate(bom,this.transform.position + new Vector3(2,0,0),Quaternion.identity);
        }
      //  Instantiate(bom, thing.transform.position + new Vector3(0, -2, 0), Quaternion.identity);
        Destroy(this.gameObject);
 
        
    }

}
