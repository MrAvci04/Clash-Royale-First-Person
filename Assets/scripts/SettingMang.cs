using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingMang : MonoBehaviour
{
    public GameObject menu;
    public GameObject icon;
    public void open()
    {
        menu.SetActive(true);
        icon.SetActive(false);
    }
    public void close()
    {
        menu.SetActive(false);
        icon.SetActive(true);
    }

}
