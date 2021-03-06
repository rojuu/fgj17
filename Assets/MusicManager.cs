﻿using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MusicManager : MonoBehaviour
{
    static MusicManager instance;

    AudioClip GameMusic;
    AudioClip MenuMusic;

    AudioSource audioSource;

    int lastSceneIndex;

    void Awake()
    {
        if (instance == null) { instance = this; }
        if (instance != this) { Destroy(gameObject); }

        DontDestroyOnLoad(this);
        DontDestroyOnLoad(gameObject);
        
        GameMusic = Resources.Load<AudioClip>(GlobalVars.Instance.MusicGameName);
        MenuMusic = Resources.Load<AudioClip>(GlobalVars.Instance.MusicMenuName);

        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (!audioSource.isPlaying || SceneManager.GetActiveScene().buildIndex != lastSceneIndex)
        {
            if (SceneManager.GetActiveScene().name == GlobalVars.Instance.CreditsSceneName)
                return;

            lastSceneIndex = SceneManager.GetActiveScene().buildIndex;
            audioSource.Stop();
            if (SceneManager.GetActiveScene().name == GlobalVars.Instance.GameSceneName)
            {
                audioSource.clip = GameMusic;
            }
            else
            {
                audioSource.clip = MenuMusic;
            }
            audioSource.Play();
        }
    }
}
