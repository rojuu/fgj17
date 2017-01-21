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
}
