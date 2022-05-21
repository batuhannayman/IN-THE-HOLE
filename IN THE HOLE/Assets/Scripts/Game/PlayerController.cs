using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float h;
    float maxSpeed = 9;
    float speed = 8;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxisRaw("Horizontal");

        if (h > 0)
        {
            transform.Translate(h * speed * Time.deltaTime, 0, 0);
        }
        if (h < 0)
        {
            transform.Translate(-h * -speed * Time.deltaTime, 0, 0);
        }

        //kaymasını engellemek
        if (rb.velocity.x > maxSpeed)
        {
            rb.velocity = new Vector2(maxSpeed, rb.velocity.y);
        }
        if (rb.velocity.x < -maxSpeed)
        {
            rb.velocity = new Vector2(-maxSpeed, rb.velocity.y);
        }
    }

    void FixedUpdate()
    {

    }

}
