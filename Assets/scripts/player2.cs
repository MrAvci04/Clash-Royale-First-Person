using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RPlayer : MonoBehaviour
{
    // Start is called before the first frame update

   // float speed = 0.00000000000000000004F;
    void Start()
    {
        speed = 5;
        health = 100;
        Casthealth = 100;
        coins = 0;
    }


    // static int cardsNum = 0;
    static List<string> myCards = new List<string>();

    public static int health = 100; 
    public static int Casthealth = 100;
    static int coins = 0;

    public GameObject mySword;
    public GameObject mySK;
    public GameObject myGun;
    public GameObject myWiz;
    public GameObject myCan;
    public GameObject myFence;

    public Scrollbar myScroll;
    private float speed;


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

    public static void damCast()
    {
        Casthealth -= 5;

        GameObject foundObject = GameObject.Find("RCAST");

        if (foundObject != null)
        {

            Transform objTransform = foundObject.transform;

            objTransform.Find("Canvas").GetChild(1).GetComponent<Image>().fillAmount = Casthealth / 100f;

        }

        if (Casthealth <= 0)
        {
            GameObject[] chars = GameObject.FindGameObjectsWithTag("red");

            foreach (GameObject item in chars)
            {
                Destroy(item);
            }

            Destroy(GameObject.FindGameObjectWithTag("CastRed"));

            SceneManager.LoadScene("TryAgainScene");
        }

    }
    void Update()
    {
        if (transform.position.y < -225)
            damage(this.gameObject,100);
        if (health <= 0)
            Destroy(this.gameObject);

        speed = myScroll.value * 10;

        if (Input.GetKey(KeyCode.K))
            transform.position =  (transform.position + new Vector3(0.018F, 0, 0) * speed * 3);

        if (Input.GetKey(KeyCode.I))
            transform.position = (transform.position + new Vector3(-0.018F, 0, 0) * speed * 3);

        if (Input.GetKey(KeyCode.L))
            transform.position = (transform.position + new Vector3(0,0, 0.018F) * speed * 3);

        if (Input.GetKey(KeyCode.J))
            transform.position = (transform.position + new Vector3(0,0,-0.018F) * speed * 3);

        if (Input.GetKey(KeyCode.Alpha7)) 
        { 
            mySword.SetActive(true); mySK.SetActive(true);
            myGun.SetActive(false); myWiz.SetActive(false); 
            myCan.SetActive(false);
           // speed = 8;
        }
        
        if (Input.GetKey(KeyCode.Alpha8))
        { mySword.SetActive(false); mySK.SetActive(false);
            myGun.SetActive(true); myWiz.SetActive(true); 
            myCan.SetActive(false);
           // speed = 7;
        }
        
        if (Input.GetKey(KeyCode.Alpha9)) 
        { mySword.SetActive(false); mySK.SetActive(false);
            myGun.SetActive(false); myWiz.SetActive(false);
            myCan.SetActive(true);
           // speed = 5;
        }

        if (Input.GetKey(KeyCode.U))
        { mySword.SetActive(false); mySK.SetActive(false); 
            myGun.SetActive(false); myWiz.SetActive(false);
            myCan.SetActive(false);
           // speed = 4;
        }

        if (Input.GetKey(KeyCode.Alpha0))
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
    public static void damage(GameObject me, int amount)
    {
        health -= amount;
        
        if (health > 100)
            health = 100;

        GameObject foundObject = GameObject.Find("RPlayer");

        if (foundObject != null)
        {
           
            Transform objTransform = foundObject.transform;

            objTransform.Find("Canvas").GetChild(1).GetComponent<Image>().fillAmount = health/100f ;
            
        }

        if (health <= 0)
        {
            Destroy(me.gameObject);
            SceneManager.LoadScene("TryAgainScene");
        }
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
