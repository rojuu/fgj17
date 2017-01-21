using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour
{
    AudioClip GameMusic;
    AudioClip MenuMusic;
    
    void Awake()
    {
        DontDestroyOnLoad(this);
        DontDestroyOnLoad(gameObject);

        GameMusic = Resources.Load<AudioClip>(GlobalVars.Instance.MusicGameName);
        MenuMusic = Resources.Load<AudioClip>(GlobalVars.Instance.MusicMenuName);


    }
}
