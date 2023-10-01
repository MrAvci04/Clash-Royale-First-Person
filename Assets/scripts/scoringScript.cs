using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoringScript : MonoBehaviour
{
    // Start is called before the first frame update

    public Text score;
    void Start()
    {
        if (this.name == "sB")
            score.text = "testB";
        if (this.name == "sR")
            score.text = "testR";
    }

    // Update is called once per frame
    void Update()
    {
        if (this.name == "sB")
        {
            score.text = "Health : " + BPlayer.health.ToString() + " \n Coins : " + BPlayer.getCoin().ToString();
        }
        if (this.name == "sR")
        {
            score.text = "Player Health : " + RPlayer.health.ToString() + " \n Coins :" + RPlayer.getCoin().ToString();
        }
    }
}
