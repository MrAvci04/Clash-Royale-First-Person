using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceMang : MonoBehaviour
{
    // Start is called before the first frame update
    public void PStart()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void TAgain()
    {
        SceneManager.LoadScene("GameScene");
    }
    
    public void GOver()
    {
        SceneManager.UnloadScene("GameScene");

        SceneManager.LoadScene("TryAgainScene");
    }
   
}