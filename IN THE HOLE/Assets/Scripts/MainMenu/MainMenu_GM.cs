using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu_GM : MonoBehaviour
{
    AudioSource audio_Source;
    public AudioClip button_Sound;

    void Start()
    {
        audio_Source = GetComponent<AudioSource>();

        if (PlayerPrefs.HasKey("audioVolume"))
        {
            AudioListener.volume = PlayerPrefs.GetFloat("audioVolume");
        }
        else
        {
            PlayerPrefs.SetFloat("audioVolume", 0.5f);
            AudioListener.volume = PlayerPrefs.GetFloat("audioVolume");
        }
    }


    public void btn_Options_Click()
    {
        audio_Source.PlayOneShot(button_Sound);
        SceneManager.LoadScene("OptionsMenu");
    }

    public void btn_Play_Click()
    {
        audio_Source.PlayOneShot(button_Sound);
        SceneManager.LoadScene("Game");
    }

    public void btn_Exit_Click()
    {
        Application.Quit();
    }
}
