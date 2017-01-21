using UnityEngine;
using System.Collections;

public class BackgroundDaylight : MonoBehaviour
{
    Sprite dayTimeSprite;

	void Start()
    {
        dayTimeSprite = Resources.Load<Sprite>("background_day_big");
        if(dayTimeSprite == null) { print("BackgrounDaylight script missing reference to daylight sprite"); }

        SpriteRenderer sr = GetComponent<SpriteRenderer>();

        if (GameManager.Instance.isDay())
        {
            sr.sprite = dayTimeSprite;
        }
	}
}
