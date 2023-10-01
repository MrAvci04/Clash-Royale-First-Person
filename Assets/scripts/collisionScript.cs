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
    // bool flag = true;
    
    void OnCollisionEnter(Collision thing)
    {
        if (this.name.StartsWith("heart"))
        {
            if (thing.collider.name == "BPlayer")
                BPlayer.damage(thing.gameObject,-15);
            else if (thing.collider.name == "RPlayer")
                RPlayer.damage(thing.gameObject, -15);
            if (!thing.collider.name.StartsWith("Plane"))
            Destroy(this.gameObject);
        }
        else
        {
            if (this.name[0] == thing.collider.name[0])
            // Debug.Log("me :" +this.name[0]); Debug.Log("you :" +thing.collider.name[0]);
            {
                Debug.Log("Destroyed by : " + thing.collider.gameObject.name);
                Destroy(this.gameObject);
                //  addCard(this.name[0]);
                if (thing.collider.name[0] == 'B')
                    BPlayer.addCoin();
                else if (thing.collider.name[0] == 'R')
                    RPlayer.addCoin();
            }
            else
            {

                if (thing.collider.name[0] == 'B')
                {
                    BPlayer.damage(thing.gameObject, 10);
                    Destroy(this.gameObject);
                }
                else if (thing.collider.name[0] == 'R')
                {
                    RPlayer.damage(thing.gameObject, 10);
                    Destroy(this.gameObject);
                }
            }

            if (thing.collider.gameObject.name == "BPlayer")
                CollectCards.Printt('B');
            else if (thing.collider.gameObject.name == "RPlayer")
                CollectCards.Printt('R');

        }
    }
    void addCard(char c)
    {
        if (this.name[0] == 'B')
        {
            BPlayer.addCard("Btest");
            BPlayer.getCards();
        }
        else if (this.name[0] == 'R')
        {
            RPlayer.addCard("Rtest");
            RPlayer.getCards();
        }
    }
};
