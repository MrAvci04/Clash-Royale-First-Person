using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class spawning : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject blue;
    public GameObject red;
    public GameObject green;

    int cnt = 0;
    void Start()
    {
        InvokeRepeating("spawnC", 0f, 2f);
        InvokeRepeating("spawnH", 0f, 3f);
        InvokeRepeating("stopSpawn",0f,12f);
    }
    private void stopSpawn()
    {
        cnt++;
        if (cnt == 7) 
        {
            CancelInvoke("spawnC");
            CancelInvoke("spawnH");
            CancelInvoke("stopSpawn");
            Destroy(GameObject.Find("lineR"));
            Destroy(GameObject.Find("lineB"));
        }
    }
    private void spawnC()
    {
        GameObject[] choose = new GameObject[] { blue, red };
        Vector3 pos = new Vector3(Random.Range(-30,30), 30, Random.Range(-20, 20));
        Instantiate(choose[Random.Range(0,2)], pos, Quaternion.identity);
    }    

    private void spawnH()
    {
        Vector3 pos = new Vector3(Random.Range(-30, 30), 30, Random.Range(-20, 20));
        Instantiate(green, pos, Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
