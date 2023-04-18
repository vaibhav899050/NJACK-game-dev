using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collide : MonoBehaviour
{
    public GameObject canvas;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(this.gameObject);
        canvas.SetActive(true);
        Time.timeScale = 0f;
    }
}
