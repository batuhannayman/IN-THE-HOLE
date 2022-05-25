using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Missing_Manager : MonoBehaviour
{

    public static int missing_Count;
    public Text missing_Text;

    public static AudioSource audio_Source;


    // Start is called before the first frame update
    void Start()
    {
        audio_Source = GetComponent<AudioSource>();
        audio_Source.volume = 1;
        missing_Count = 3;
        missing_Text.text = missing_Count.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (missing_Count < 1)
        {
            Destroy(GameObject.FindGameObjectWithTag("Player"));
            audio_Source.volume = 0;
            missing_Count = 0;
        }
        
        missing_Text.text = missing_Count.ToString();
    }

    public static void Missed()
    {
        missing_Count--;
    }
}
