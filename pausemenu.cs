using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pausemenu : MonoBehaviour
{
    private bool ispaused = false;
    public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool esc = Input.GetKeyDown(KeyCode.Escape);
        if (ispaused)
        {
            if (esc)
            {
                canvas.SetActive(false);
                Time.timeScale = 1f;
                ispaused = false;
            }
            
        }
        else
        {
            if (esc)
            {
                canvas.SetActive(true);
                Time.timeScale = 0f;
                ispaused = true;
            }
        }

        
    }
}
