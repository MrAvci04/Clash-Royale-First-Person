using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RPlayer : MonoBehaviour
{
    // Start is called before the first frame update

   // float speed = 0.00000000000000000004F;
    void Start()
    {
        
    }


    // static int cardsNum = 0;
    static List<string> myCards = new List<string>();

    public static int health = 100;
    static int coins = 0;

    public GameObject mySword;
    public GameObject myGun;
    public GameObject myCan;

    // Update is called once per frame
    public static int getCoin()
    {
        return coins;
    }
    public static bool PayCoin(int am)
    {
        if (coins < am)
            return false;
        coins -= am;
        return true;
    }

    void Update()
    {
        if (health <= 0)
            Destroy(this.gameObject);

        if (Input.GetKey(KeyCode.K))
            transform.position =  (transform.position + new Vector3(0.018F, 0, 0) );

        if (Input.GetKey(KeyCode.I))
            transform.position = (transform.position + new Vector3(-0.018F, 0, 0) );

        if (Input.GetKey(KeyCode.L))
            transform.position = (transform.position + new Vector3(0,0, 0.018F) );

        if (Input.GetKey(KeyCode.J))
            transform.position = (transform.position + new Vector3(0,0,-0.018F) );

        if (Input.GetKey(KeyCode.Alpha7)) { mySword.SetActive(true); myGun.SetActive(false); myCan.SetActive(false); }
        
        if (Input.GetKey(KeyCode.Alpha8)) { mySword.SetActive(false); myGun.SetActive(true); myCan.SetActive(false); }
        
        if (Input.GetKey(KeyCode.Alpha9)) { mySword.SetActive(false); myGun.SetActive(false); myCan.SetActive(true); }

        if (Input.GetKey(KeyCode.U)) { mySword.SetActive(false); myGun.SetActive(false); myCan.SetActive(false); }
        
}

    public static void getCards()
    {
        foreach (string item in myCards)
            Debug.Log(item);
    }

    public static void addCard(string st)
    {
        myCards.Add("this is a card : " + st);
    }
    public static void damage(GameObject me, int amount)
    {
        health -= amount;
        if (health <= 0)
            Destroy(me.gameObject);
        if (health > 100)
            health = 100;
    }

    public static void addCoin()
    {
        coins+=4;
    }

    public static void loseCoin()
    {
        if (coins > 0)
            coins--;
    }

}
