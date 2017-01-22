using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MainMenu : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(SceneManager.GetActiveScene().name == GlobalVars.Instance.MainMenuSceneName)
                Application.Quit();
        }
    }

    public void LoadGameScene()
    {
       SceneManager.LoadScene(GlobalVars.Instance.GameSceneName);
    }

    public void LoadCreditsScene()
    {
        SceneManager.LoadScene(GlobalVars.Instance.CreditsSceneName);
    }

    public void LoadMenuScene()
    {
        SceneManager.LoadScene(GlobalVars.Instance.MainMenuSceneName);
    }
}
