using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class score : MonoBehaviour
{
    public TMP_Text s;
    private float actualscore;
    private float timebefore;

    // Start is called before the first frame update
    void Start()
    {
        timebefore = Time.time;
        
    }

    // Update is called once per frame
    void Update()
    {
        actualscore = Time.time-timebefore;
        s.text = actualscore.ToString();

        
    }
}
