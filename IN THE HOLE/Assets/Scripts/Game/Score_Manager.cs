using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_Manager : MonoBehaviour
{
    public static int score;
    public Text score_Text;
    public Text highest_Text;


    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        Load_Highest();

    }

    // Update is called once per frame
    void Update()
    {
        score_Text.text = score.ToString();

        if (score > PlayerPrefs.GetInt("highest_Score"))
        {
            highest_Text.text = score.ToString();
            PlayerPrefs.SetInt("highest_Score", score);
        }
    }

    void Load_Highest()
    {
        if (PlayerPrefs.HasKey("highest_Score"))
        {
            highest_Text.text = PlayerPrefs.GetInt("highest_Score").ToString();
        }
        else
        {
            PlayerPrefs.SetInt("highest_Score", 0);
            highest_Text.text = PlayerPrefs.GetInt("highest_Score").ToString();
        }
    }

    public static void ScoreAdd()
    {
        score += 10;
    }
}
