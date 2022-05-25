using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float h;
    float maxSpeed = 9;
    float speed = 8;
    Rigidbody2D rb;
    public static AudioSource audio_Source_PLayer;
    AudioClip eat_Sound;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audio_Source_PLayer = GetComponent<AudioSource>();
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
