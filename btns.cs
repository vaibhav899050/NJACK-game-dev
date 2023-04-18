using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class btns : MonoBehaviour
{
    public void playagain()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1f;
        

    }

    public void startgame()
    {
        SceneManager.LoadScene("SampleScene");

    }
    
}
