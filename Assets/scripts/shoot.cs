using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform point;
    public GameObject shot;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.tag == "red" && Input.GetKeyUp(KeyCode.O) && RPlayer.PayCoin(1) || this.gameObject.tag == "blue" && Input.GetKeyUp(KeyCode.E) && BPlayer.PayCoin(1)) 
        {
            var st = Instantiate(shot, point.position, Quaternion.LookRotation(new Vector3(45, 180, 0)));
            if (this.gameObject.tag == "red")
                st.tag = "red";
            if (this.gameObject.tag == "blue")
                st.tag = "blue";
            st.GetComponent<Rigidbody>().velocity = point.forward*50;
        }
    }
    
}
