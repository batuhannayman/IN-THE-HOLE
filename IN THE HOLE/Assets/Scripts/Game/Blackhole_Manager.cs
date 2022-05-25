using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blackhole_Manager : MonoBehaviour
{
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Score_Manager.score < 100)
        {
            rb.gravityScale = 0.70f;
        }
        else if (Score_Manager.score < 250)
        {
            rb.gravityScale = 1f;
        }
        else if (Score_Manager.score < 400)
        {
            rb.gravityScale = 1.5f;
        }
        else if (Score_Manager.score > 400)
        {
            rb.gravityScale = 2f;

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "BottomBorder")
        {
            Destroy(this.gameObject);
        }
        else if(collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
        }
    }

}
