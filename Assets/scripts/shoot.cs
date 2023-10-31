using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform point;
    public GameObject shot;

    public AudioSource mySound;
    public AudioSource noSound;

    public int pay;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.tag == "red" && Input.GetKeyUp(KeyCode.O))
        {
            if(!RPlayer.PayCoin(pay))
                noSound.Play();
            else
            {
                var st = Instantiate(shot, point.position, Quaternion.LookRotation(new Vector3(45, 180, 0)));
                st.tag = "red";
                st.GetComponent<Rigidbody>().velocity = point.forward * 50;

                mySound.Play();
            }
        }
        
        
        if (this.gameObject.tag == "blue" && Input.GetKeyUp(KeyCode.E))
        {
            if(!BPlayer.PayCoin(pay))
                noSound.Play();
            else
            {
                var st = Instantiate(shot, point.position, Quaternion.LookRotation(new Vector3(45, 180, 0)));
                st.tag = "blue";
                st.GetComponent<Rigidbody>().velocity = point.forward * 50;

                mySound.Play();
            }
        }
    }
    
}
