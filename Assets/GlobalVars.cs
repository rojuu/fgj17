using UnityEngine;
using System.Collections;

public class GlobalVars
{
    static GlobalVars sInstance;
    public static GlobalVars Instance
    {
        get
        {
            if (sInstance == null) { sInstance = new GlobalVars(); }
            return sInstance;
        }
    }

    public string GameSceneName = "Game";
    public string MainMenuSceneName = "MainMenu";

    public string BackgroundDaySpriteName = "background_day_big";
    public string PillarDaySpriteName = "pillar_orange";
    
    string MusicDayName = "FGJ17_Music_day";
    string MusicNightName = "FGJ17_Music_night";

    public string MusicGameName
    {
        get
        {
            if (isDay())
            {
                return MusicDayName;
            }
            else
            {
                return MusicNightName;
            }
        }
    }

    public string MusicMenuName
    {
        get
        {
            if (isDay())
            {
                return MusicNightName;
            }
            else
            {
                return MusicDayName;
            }
        }
    }

    public bool isDay()
    {
        return (System.DateTime.Now.Hour >= 6 && System.DateTime.Now.Hour <= 18);
    }
}
