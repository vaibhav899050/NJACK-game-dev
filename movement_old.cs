using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed= 10f;
    public float jump = 5f;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float x_dir = Input.GetAxis("Horizontal");
        bool b_press = Input.GetKey("b");
        Vector2 curr_pos = new Vector2(transform.position.x, transform.position.y);
        transform.position = new Vector2(curr_pos.x + speed * Time.deltaTime * x_dir, curr_pos.y);
        if (b_press)
        {
            rb.velocity = new Vector2(rb.velocity.x, jump);
        }



        
    }
}
