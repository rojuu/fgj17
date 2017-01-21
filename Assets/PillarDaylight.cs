using UnityEngine;
using System.Collections;

public class PillarDaylight : MonoBehaviour
{
    Sprite dayTimeSprite;

    void Start()
    {
        dayTimeSprite = Resources.Load<Sprite>("pillar_orange");
        if (dayTimeSprite == null) { print("PillarDaylight script missing reference to daylight sprite"); }

        SpriteRenderer sr = GetComponent<SpriteRenderer>();

        if (GameManager.Instance.isDay())
        {
            sr.sprite = dayTimeSprite;
        }
    }
}
