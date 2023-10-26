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
        if (this.name == "CB")
            score.text = "testB";
        if (this.name == "CR")
            score.text = "testR";
    }

    // Update is called once per frame
    void Update()
    {
        if (this.name == "sB")
        {
            score.text = "PHealth : " + BPlayer.health.ToString() + "\nCoins : " + BPlayer.getCoin().ToString();
        }
        
        if (this.name == "sR")
        {
            score.text = "PHealth : " + RPlayer.health.ToString() + "\nCoins :" + RPlayer.getCoin().ToString();
        }
        
        if (this.name == "CB")
        {
            score.text = "CHealth : " + BPlayer.Casthealth.ToString();
        }
        
        if (this.name == "CR")
        {
            score.text = "CHealth : " + RPlayer.Casthealth.ToString();
        }

    }
}
