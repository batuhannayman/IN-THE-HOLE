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

    }


    public void btn_Options_Click()
    {
        audio_Source.PlayOneShot(button_Sound);
        SceneManager.LoadScene("OptionsMenu");
    }
}
