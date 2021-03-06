using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touching_Manager : MonoBehaviour
{
    public float speed = 0.3f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount > 0 &&
       Input.GetTouch(0).phase == TouchPhase.Moved)
        {

            // Get movement of the finger since last frame
            Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;

            // Move object across XY plane
            transform.Translate(touchDeltaPosition.x * speed * Time.deltaTime, 0, 0);
        }
    }
}

