using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x_dir = Input.GetAxis("Horizontal");
        float y_dir = Input.GetAxis("Vertical");
        transform.position = new Vector2(transform.position.x + speed * Time.deltaTime * x_dir, transform.position.y + speed * Time.deltaTime * y_dir); 
        
    }
}
