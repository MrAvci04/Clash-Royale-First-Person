using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TAImage : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject BWin;
    public GameObject RWin;

    void Start()
    {
        if (BPlayer.health <= 0 || BPlayer.Casthealth <= 0)
        {
            if (RPlayer.health <= 0 || RPlayer.Casthealth <= 0)
            {
                RWin.SetActive(false);
                BWin.SetActive(false);
            }
            else
            {
                RWin.SetActive(true);
                BWin.SetActive(false);
            }
        }
        else if(BPlayer.health + BPlayer.Casthealth + RPlayer.Casthealth + RPlayer.health == 400)
        {
            RWin.SetActive(false);
            BWin.SetActive(false);
        }
        else
        {
            BWin.SetActive(true);
            RWin.SetActive(false);
        }
    }


}
