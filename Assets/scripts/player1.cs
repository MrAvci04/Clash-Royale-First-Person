using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class BPlayer : MonoBehaviour
{
    //float speed = 0.00000000000000000004F;
    void Start()
    {

    }

   // static int cardsNum = 0; we can use  myCards.Count...
    static List<string> myCards = new List<string>();

    public static int health = 100;
    public static int Casthealth = 100;

    static int coins = 0;

    public GameObject cam;
    public GameObject mySword;
    public GameObject myGun;
    public GameObject myCan;
    public GameObject myFence;
    // Update is called once per frame
    public static int getCoin()
    {
        return coins;
    }

    public static bool PayCoin(int am)
    {
        if(coins < am)
            return false;
        coins -= am;
        return true;
    }
    public static void damCast()
    {
        Casthealth -= 5;
        if (Casthealth <= 0)
        {
            GameObject[] chars = GameObject.FindGameObjectsWithTag("blue");

            foreach (GameObject item in chars)
            {
                Destroy(item);
            }

            Destroy(GameObject.FindGameObjectWithTag("CastBlue"));
        }

    }
    void Update()
    {
        Debug.Log(health);
       
        if (Input.GetKey(KeyCode.S))
            transform.position = (transform.position + new Vector3(-0.018F, 0, 0) );

        if (Input.GetKey(KeyCode.W))
            transform.position = (transform.position + new Vector3(0.018F, 0, 0) );

        if (Input.GetKey(KeyCode.D))
            transform.position = (transform.position + new Vector3(0, 0, -0.018F) );

        if (Input.GetKey(KeyCode.A))
            transform.position = (transform.position + new Vector3(0, 0, 0.018F) );
     //   if (Input.GetKey(KeyCode.Space))
       //     cam.SetActive(false);

        if (Input.GetKey(KeyCode.Q)) { mySword.SetActive(false); myGun.SetActive(false); myCan.SetActive(false); }

        if (Input.GetKey(KeyCode.Alpha1)) { mySword.SetActive(true); myGun.SetActive(false); myCan.SetActive(false); }
       
        if (Input.GetKey(KeyCode.Alpha2)) { mySword.SetActive(false); myGun.SetActive(true); myCan.SetActive(false); }
        
        if (Input.GetKey(KeyCode.Alpha3)) { mySword.SetActive(false); myGun.SetActive(false); myCan.SetActive(true); }
       
        if (Input.GetKey(KeyCode.Alpha4)) 
        {
            if (PayCoin(5) && myFence.activeSelf == false)
            {
                myFence.SetActive(true);
                
            }
        }
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
    public static void damage(GameObject me,int amount)
    {
        health -= amount;

        GameObject foundObject = GameObject.Find("BPlayer");

        if (foundObject != null)
        {

            Transform objTransform = foundObject.transform;

            objTransform.Find("Canvas").GetChild(1).GetComponent<Image>().fillAmount = health / 100f;

        }

        if (health <= 0)
            Destroy(me.gameObject);
        if (health > 100)
            health = 100;
    }

    public static void addCoin()
    {
        coins+= 4;
    }

    public static void loseCoin()
    {
        if(coins > 0)
        coins--;
    }
}
