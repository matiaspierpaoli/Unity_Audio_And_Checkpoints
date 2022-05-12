using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    private const string audioKey = "Audio";

    private void Start()
    {
        int audioController;
        if (PlayerPrefs.HasKey(audioKey))
        {
            audioController = PlayerPrefs.GetInt(audioKey);
            if (audioController == 1)
                AudioListener.volume = 1;
            else
                AudioListener.volume = 0;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
            ToggleAudio();
    }

    public void ToggleAudio()
    {
        if (AudioListener.volume == 0)
        {
            AudioListener.volume = 1;
            PlayerPrefs.SetInt(audioKey, 1);
        }
        else
        {
            AudioListener.volume = 0;
            PlayerPrefs.SetInt(audioKey, 0);
        }
    }


}
