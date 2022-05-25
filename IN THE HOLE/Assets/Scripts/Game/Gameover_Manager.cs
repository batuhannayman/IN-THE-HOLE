using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gameover_Manager : MonoBehaviour
{
    public GameObject gameover_Panel;
    public AudioClip gameover_Sound;
    AudioSource audio_Source;
    public Text score_go_Text;

    // Start is called before the first frame update
    void Start()
    {
        audio_Source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") == null)
        {
            audio_Source.PlayOneShot(gameover_Sound);
            gameover_Panel.SetActive(true);
            score_go_Text.text = Score_Manager.score.ToString();
        }
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
