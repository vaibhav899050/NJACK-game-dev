using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 5f;
    private Vector2 bound;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        bound = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(-speed, 0);
        if (transform.position.x < -bound.x)
        {
            Destroy(this.gameObject);
        }
        
    }
}
