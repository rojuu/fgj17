using UnityEngine;
using System.Collections;

public class SpaceTextSwitcher : MonoBehaviour
{

    public Sprite touchScreenText;
    public Sprite spacebarText;

    void Start()
    {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        if (sr == null) return;

#if UNITY_ANDROID
        sr.sprite = touchScreenText;

#elif UNITY_IOS
        sr.sprite = touchScreenText;

#else
        sr.sprite = spacebarText;

#endif

    }
}
