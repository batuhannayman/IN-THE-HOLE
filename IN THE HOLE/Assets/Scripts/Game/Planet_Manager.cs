using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Planet_Manager : MonoBehaviour
{
    public Animator anim;
    public Rigidbody2D rb;
    public GameObject game_Object;
    public AudioClip eat_Sound, miss_Sound;
    public int isEated;

    // Start is called before the first frame update
    void Start()
    {
        isEated = 0;
        anim = GetComponent<Animator>();
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
        if (collision.gameObject.tag == "Border" || collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
        else if (collision.gameObject.tag == "BottomBorder" && isEated != 1)
        {
            Missing_Manager.Missed();
            Missing_Manager.audio_Source.PlayOneShot(miss_Sound);
            Destroy(this.gameObject);

        }
        else if (collision.gameObject.tag == "BottomBorder")
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            PlayerController.audio_Source_PLayer.PlayOneShot(eat_Sound);
            Score_Manager.ScoreAdd();
            isEated = 1;
            anim.SetInteger("isCrash", 1);

        }
    }
}
